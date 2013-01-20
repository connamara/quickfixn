using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Diagnostics;
using System.Net;

namespace QuickFix.Transport
{
    public static class StreamFactory
    {
        public static Stream CreateClientStream(IPEndPoint endpoint, SocketSettings settings, ILog logger)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.NoDelay = settings.SocketNodelay;
            socket.Connect(endpoint);
            Stream stream = new NetworkStream(socket, ownsSocket: true);

            if (settings.UseSSL)
            {
                stream = new SSLStreamFactory(logger, settings)
                                .CreateClientStreamAndAuthenticate(stream);
            }

            return stream;
        }

        public static Stream CreateServerStream(TcpClient tcpClient, SocketSettings settings, ILog logger)
        {
            if (tcpClient.Connected == false)
                throw new ArgumentException("tcp client must be connected in order to get stream", "tcpClient");

            //TODO: Add SL
            Stream stream = tcpClient.GetStream();

            if (settings.UseSSL)
            {
                stream = new SSLStreamFactory(logger, settings)
                                .CreateServerStreamAndAuthenticate(stream);
            }

            return stream;
        }


        /// <summary>
        /// The SSLClientStreamFactory is responsible for setting up a SSLStream in client mode
        /// </summary>
        private sealed class SSLStreamFactory
        {
            ILog log_;
            SocketSettings socketSettings_;
            const string clientAuthenticationOid = "1.3.6.1.5.5.7.3.2";
            const string serverAuthenticationOid = "1.3.6.1.5.5.7.3.1";

            public SSLStreamFactory(ILog log, SocketSettings settings)
            {
                log_ = log;
                socketSettings_ = settings;
            }

            public Stream CreateClientStreamAndAuthenticate(Stream innerStream)
            {
                var sslStream = new SslStream(innerStream,
                                                leaveInnerStreamOpen: false,
                                                userCertificateValidationCallback: ValidateServerCertificate,
                                                userCertificateSelectionCallback: SelectLocalCertificate);

                try
                {
                    // Setup secure SSL Communication
                    var clientCertificates = GetClientCertificates();
                    sslStream.AuthenticateAsClient(socketSettings_.HostName,
                        clientCertificates,
                        socketSettings_.SslProtocol,
                        socketSettings_.CheckCertificateRevocation);
                }
                catch (System.Security.Authentication.AuthenticationException ex)
                {
                    log_.OnEvent("Unable to perform authentication against server: " + ex.Message);
                    throw;
                }

                return sslStream;
            }

            public Stream CreateServerStreamAndAuthenticate(Stream innerStream)
            {
                var sslStream = new SslStream(innerStream,
                                                leaveInnerStreamOpen: false,
                                                userCertificateValidationCallback: ValidateClientCertificate,
                                                userCertificateSelectionCallback: SelectLocalCertificate);

                try
                {
                    if (string.IsNullOrEmpty(socketSettings_.CertificatePath))
                        throw new Exception(string.Format("No server certificate specified, the {0} setting must be configured", SessionSettings.SSL_CERTIFICATE_PATH));

                    // Setup secure SSL Communication
                    var serverCertificate = new X509Certificate2(socketSettings_.CertificatePath, socketSettings_.CertificatePassword);
                    sslStream.AuthenticateAsServer(serverCertificate,
                        socketSettings_.RequireClientCertificate,
                        socketSettings_.SslProtocol,
                        socketSettings_.CheckCertificateRevocation);
                }
                catch (System.Security.Authentication.AuthenticationException ex)
                {
                    log_.OnEvent("Unable to perform authentication against server: " + ex.Message);
                    throw;
                }

                return sslStream;
            }


            X509CertificateCollection GetClientCertificates()
            {
                X509CertificateCollection certificates = new X509Certificate2Collection();

                if (!string.IsNullOrEmpty(socketSettings_.CertificatePath))
                {
                    certificates.Add(new X509Certificate2(socketSettings_.CertificatePath, socketSettings_.CertificatePassword));
                }

                return certificates;
            }

            public bool ValidateServerCertificate(object sender,
                      X509Certificate certificate,
                      X509Chain chain,
                      SslPolicyErrors sslPolicyErrors)
            {
                // Unknown server certificate, only accept if we should not validate it
                if (socketSettings_.ValidateServerCertificate == false)
                    return true;

                if (sslPolicyErrors != SslPolicyErrors.None)
                {
                    log_.OnEvent("Server certificate was not recognized as a valid certificate: " + sslPolicyErrors);
                    return false;
                }

                return true;
            }

            public bool ValidateClientCertificate(object sender,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors)
            {
                // Invalid certificate, only accept if we should not validate it
                if (socketSettings_.ValidateServerCertificate == false)
                    return true;

                // If CA Certficiate is specifed then validate agains the CA certificate
                if (!string.IsNullOrEmpty(socketSettings_.CACertificatePath))
                {
                    X509Chain chain0 = new X509Chain();
                    chain0.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                    // add all your extra certificate chain
                    chain0.ChainPolicy.ExtraStore.Add(new X509Certificate2(socketSettings_.CACertificatePath));
                    chain0.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;
                    bool isValid = chain0.Build((X509Certificate2)certificate);

                    // If the certificate is valid then reset the sslPolicyErrors.RemoteCertificateChainErrors status
                    if (isValid && sslPolicyErrors == SslPolicyErrors.RemoteCertificateChainErrors)
                        sslPolicyErrors = SslPolicyErrors.None;
                    // If the certificate could not be validated against CA, then set the SslPolicyErrors.RemoteCertificateChainErrors
                    else if (isValid == false)
                        sslPolicyErrors |= SslPolicyErrors.RemoteCertificateChainErrors;
                }

                // Any basic authentication check failed, do after checking CA
                if (sslPolicyErrors != SslPolicyErrors.None)
                {
                    log_.OnEvent("Client certificate was not recognized as a valid certificate: " + sslPolicyErrors);
                    return false;
                }

                // Validate enchanced key usage
                if (!ContainsEchangedKeyUsage(certificate, clientAuthenticationOid))
                {
                    log_.OnEvent("Client certificate is not intended for client authentication: It is missing enchancheded key usage " + clientAuthenticationOid);
                    return false;
                }

                // No errors found accept the certificate
                return true;
            }

            /// <summary>
            /// Check if the given certificate contains the given enchanced key usage Oid
            /// </summary>
            /// <param name="certificate">X509 certificate</param>
            /// <param name="enchanchedKeyOid">the oid to check if it is specified</param>
            /// <returns><c>true</c> if the oid is specified as an enhanced key usage; otherwise <c>false</c></returns>
            private static bool ContainsEchangedKeyUsage(X509Certificate certificate, string enchanchedKeyOid)
            {
                X509Certificate2 cert2 = certificate as X509Certificate2;

                if (cert2 == null)
                    cert2 = new X509Certificate2(certificate);

                foreach (X509Extension extension in cert2.Extensions)
                {
                    if (extension is X509EnhancedKeyUsageExtension)
                    {
                        var keyUsage = (X509EnhancedKeyUsageExtension)extension;
                        foreach (var oid in keyUsage.EnhancedKeyUsages)
                        {
                            if (oid.Value == enchanchedKeyOid)
                                return true;
                        }
                    }
                }

                return false;
            }


            public X509Certificate SelectLocalCertificate(object sender, string targetHost,
                                            X509CertificateCollection localCertificates,
                                            X509Certificate remoteCertificate,
                                            string[] acceptableIssuers)
            {
                // No certificate can be selected if we have no local certificates at all
                if (localCertificates == null || localCertificates.Count <= 0)
                    return null;

                Debug.Assert(localCertificates != null && localCertificates.Count > 0);

                //Otherwise we select the first availible certificate as per msdn documentation
                // http://msdn.microsoft.com/en-us/library/system.net.security.localcertificateselectioncallback.aspx
                if (acceptableIssuers != null)
                {
                    // Use the first certificate that is from an acceptable issuer. 
                    foreach (X509Certificate certificate in localCertificates)
                    {
                        string issuer = certificate.Issuer;
                        if (Array.IndexOf(acceptableIssuers, issuer) != -1)
                            return certificate;
                    }
                }

                // Just use any certificate
                return localCertificates[0];
            }
        }


    }
}
