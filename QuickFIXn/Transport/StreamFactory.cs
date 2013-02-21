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
    /// <summary>
    /// Streamfactory is resposible for initiating <see cref="T:System.IO.Stream"/> for communication.
    /// If any SSL setup is required it is performed here
    /// </summary>
    public static class StreamFactory
    {
        /// <summary>
        /// Connect to the specified endpoint and return a stream that can be used to communicate with it. (for initiator)
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="settings">The socket settings.</param>
        /// <param name="logger">Logger to use.</param>
        /// <returns>an opened and initiated stream which can be read and written to</returns>
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

        /// <summary>
        /// Initiate communication to the remote client and return a stream that can be used to communicate with it. (for acceptor)
        /// </summary>
        /// <param name="tcpClient">The TCP client.</param>
        /// <param name="settings">The socket settings.</param>
        /// <param name="logger">Logger to use.</param>
        /// <returns>an opened and initiated stream which can be read and written to</returns>
        /// <exception cref="System.ArgumentException">tcp client must be connected in order to get stream;tcpClient</exception>
        public static Stream CreateServerStream(TcpClient tcpClient, SocketSettings settings, ILog logger)
        {
            if (tcpClient.Connected == false)
                throw new ArgumentException("tcp client must be connected in order to get stream", "tcpClient");

            Stream stream = tcpClient.GetStream();
            if (settings.UseSSL)
            {
                stream = new SSLStreamFactory(logger, settings)
                                .CreateServerStreamAndAuthenticate(stream);
            }

            return stream;
        }

        /// <summary>
        /// Cache loaded certificates since loading a certificate can be a costly operation
        /// </summary>
        private static Dictionary<string, X509Certificate2> _certificateCache = new Dictionary<string, X509Certificate2>();

        /// <summary>
        /// Loads the specified certificate given a path, DistinguishedName or subject name
        /// </summary>
        /// <param name="name">The certificate path or DistinguishedName/subjectname if it should be loaded from the personal certificate store.</param>
        /// <param name="password">The certificate password.</param>
        /// <returns>The specified certificate, or null if no certificate is found</returns>
        internal static X509Certificate2 LoadCertificate(string name, string password)
        {
            X509Certificate2 certificate;

            if(_certificateCache.TryGetValue(name, out certificate))
                return certificate;


            // If no extension is found try to get from certificate store
            if (!File.Exists(name))
            {
                certificate = GetCertificateFromStore(name);
            }
            else
            {
                if(password != null)
                    certificate = new X509Certificate2(name, password);
                else
                    certificate = new X509Certificate2(name);
            }

            if(certificate != null)
                _certificateCache.Add(name, certificate);

            return certificate;
        }

        /// <summary>
        /// Gets the certificate from store.
        /// </summary>
        /// <remarks>See http://msdn.microsoft.com/en-us/library/system.security.cryptography.x509certificates.x509certificate2.aspx for complete example</remarks>
        /// <param name="certName">Name of the cert.</param>
        /// <returns></returns>
        private static X509Certificate2 GetCertificateFromStore(string certName)
        {

            // Get the certificate store for the current user.
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadOnly);

                // Place all certificates in an X509Certificate2Collection object.
                X509Certificate2Collection certCollection = store.Certificates;
                // If using a certificate with a trusted root you do not need to FindByTimeValid, instead: 
                // currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, certName, true);
                X509Certificate2Collection currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);

                if(certName.Contains("CN="))
                    currentCerts = currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, certName, false);
                else
                    currentCerts = currentCerts.Find(X509FindType.FindBySubjectName, certName, false);

                if (currentCerts.Count == 0)
                    return null;

                // Return the first certificate in the collection, has the right name and is current. 
                return currentCerts[0];
            }
            finally
            {
                store.Close();
            }

        }


        /// <summary>
        /// The SSLClientStreamFactory is responsible for setting up a SSLStream in either client or server mode
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

            /// <summary>
            /// Creates a SslStream in client mode and authenticate.
            /// </summary>
            /// <param name="innerStream">The stream to use for the actual (ssl encrypted) communication.</param>
            /// <returns>a ssl enabled stream</returns>
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
                    sslStream.AuthenticateAsClient(socketSettings_.ServerCommonName,
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

            /// <summary>
            /// Creates a SslStream in server mode and authenticate.
            /// </summary>
            /// <param name="innerStream">The stream to use for the actual (ssl encrypted) communication.</param>
            /// <returns>a ssl enabled stream</returns>
            public Stream CreateServerStreamAndAuthenticate(Stream innerStream)
            {
                var sslStream = new SslStream(innerStream,
                                                leaveInnerStreamOpen: false,
                                                userCertificateValidationCallback: ValidateClientCertificate,
                                                userCertificateSelectionCallback: SelectLocalCertificate);

                try
                {
                    if (string.IsNullOrEmpty(socketSettings_.CertificatePath))
                        throw new Exception(string.Format("No server certificate specified, the {0} setting must be configured", SessionSettings.SSL_CERTIFICATE));

                    // Setup secure SSL Communication
                    var serverCertificate = StreamFactory.LoadCertificate(socketSettings_.CertificatePath, socketSettings_.CertificatePassword);
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

            private X509CertificateCollection GetClientCertificates()
            {
                if (!string.IsNullOrEmpty(socketSettings_.CertificatePath))
                {
                    X509CertificateCollection certificates = new X509Certificate2Collection();
                    var clientCert = StreamFactory.LoadCertificate(socketSettings_.CertificatePath, socketSettings_.CertificatePassword);
                    certificates.Add(clientCert);
                    return certificates;
                }
                else
                {
                    return new X509Certificate2Collection();
                }                
            }


            /// <summary>
            /// Perform validation of the servers certificate. (the initiator validates the server/acceptors certificate)
            /// </summary>
            /// <param name="sender">The sender.</param>
            /// <param name="certificate">The certificate.</param>
            /// <param name="chain">The chain.</param>
            /// <param name="sslPolicyErrors">The SSL policy errors.</param>
            /// <returns><c>true</c>true if the certificate </returns>
            private bool ValidateServerCertificate(object sender,
                      X509Certificate certificate,
                      X509Chain chain,
                      SslPolicyErrors sslPolicyErrors)
            {
                // Accept without looking at if the certificat is valid if validation is disabled
                if (socketSettings_.ValidateCertificates == false)
                    return true;

                if (sslPolicyErrors != SslPolicyErrors.None)
                {
                    log_.OnEvent("Server certificate was not recognized as a valid certificate: " + sslPolicyErrors);
                    return false;
                }

                // Validate enchanced key usage
                if (!ContainsEchangedKeyUsage(certificate, serverAuthenticationOid))
                {
                    log_.OnEvent("Server certificate is not intended for server authentication: It is missing enhanced key usage " + serverAuthenticationOid);
                    return false;
                }

                return true;
            }

            /// <summary>
            /// Perform validation of a a client certificate.(the acceptor validates the client/initiators certificate)
            /// </summary>
            /// <param name="sender">The sender.</param>
            /// <param name="certificate">The certificate.</param>
            /// <param name="chain">The chain.</param>
            /// <param name="sslPolicyErrors">The SSL policy errors.</param>
            /// <returns><c>true</c>true if the certificate </returns>
            private bool ValidateClientCertificate(object sender,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors)
            {
                // Accept without looking at if the certificat is valid if validation is disabled
                if (socketSettings_.ValidateCertificates == false)
                    return true;

                // If CA Certficiate is specifed then validate agains the CA certificate, otherwise it is validated against the installed certificates
                if (!string.IsNullOrEmpty(socketSettings_.CACertificatePath))
                {
                    X509Chain chain0 = new X509Chain();
                    chain0.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                    // add all your extra certificate chain

                    chain0.ChainPolicy.ExtraStore.Add(StreamFactory.LoadCertificate(socketSettings_.CACertificatePath,null));
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
                    log_.OnEvent("Client certificate is not intended for client authentication: It is missing enhanced key usage " + clientAuthenticationOid);
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
