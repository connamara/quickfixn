#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using QuickFix.Logger;
using QuickFix.Util;

namespace QuickFix.Transport
{
    /// <summary>
    /// StreamFactory is responsible for initiating <see cref="T:System.IO.Stream"/> for communication.
    /// If any SSL setup is required it is performed here
    /// </summary>
    public static class StreamFactory
    {
        private static Socket? CreateTunnelThruProxy(string destIp, int destPort)
        {
            string destUriWithPort = $"{destIp}:{destPort}";
            UriBuilder uriBuilder = new UriBuilder(destUriWithPort);
            Uri destUri = uriBuilder.Uri;
            IWebProxy webProxy = WebRequest.GetSystemWebProxy();

            try
            {
                if (webProxy.IsBypassed(destUri))
                    return null;
            }
            catch (PlatformNotSupportedException)
            {
                // .NET Core doesn't support IWebProxy.IsBypassed
                // (because .NET Core doesn't have access to Windows-specific services, of course)
                return null;
            }

            Uri? proxyUri = webProxy.GetProxy(destUri);
            if (proxyUri is null)
                return null;

            IPAddress[] proxyEntry = Dns.GetHostAddresses(proxyUri.Host);
            int iPort = proxyUri.Port;
            IPAddress address = proxyEntry.First(a => a.AddressFamily == AddressFamily.InterNetwork);
            IPEndPoint proxyEndPoint = new IPEndPoint(address, iPort);
            Socket socketThruProxy = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketThruProxy.Connect(proxyEndPoint);

            string proxyMsg = $"CONNECT {destIp}:{destPort} HTTP/1.1 \n\n";
            byte[] buffer = Encoding.ASCII.GetBytes(proxyMsg);
            byte[] buffer12 = new byte[500];
            socketThruProxy.Send(buffer, buffer.Length, 0);
            socketThruProxy.Receive(buffer12, 500, 0);
            string data = Encoding.ASCII.GetString(buffer12);
            int index = data.IndexOf("200", StringComparison.Ordinal);

            if (index < 0)
                throw new ApplicationException(
                    $"Connection failed to {destUriWithPort} through proxy server {proxyUri}.");

            return socketThruProxy;
        }

        /// <summary>
        /// Connect to the specified endpoint and return a stream that can be used to communicate with it. (for initiator)
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="settings">The socket settings.</param>
        /// <param name="logger">Logger to use.</param>
        /// <returns>an opened and initiated stream which can be read and written to</returns>
        public static Stream CreateClientStream(IPEndPoint endpoint, SocketSettings settings, ILog logger)
        {
            Socket? socket = null;

            if (!settings.SocketIgnoreProxy)
            {
                // If system has configured a proxy for this config, use it.
                socket = CreateTunnelThruProxy(endpoint.Address.ToString(), endpoint.Port);
            }

            // No proxy.  Set up a regular socket.
            if (socket is null)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.NoDelay = settings.SocketNodelay;
                if (settings.SocketReceiveBufferSize.HasValue)
                {
                    socket.ReceiveBufferSize = settings.SocketReceiveBufferSize.Value;
                }
                if (settings.SocketSendBufferSize.HasValue)
                {
                    socket.SendBufferSize = settings.SocketSendBufferSize.Value;
                }
                socket.Connect(endpoint);
            }
            if (settings.SocketReceiveTimeout.HasValue)
            {
                socket.ReceiveTimeout = settings.SocketReceiveTimeout.Value;
            }
            if (settings.SocketSendTimeout.HasValue)
            {
                socket.SendTimeout = settings.SocketSendTimeout.Value;
            }

            Stream stream = new NetworkStream(socket, true);

            if (settings.UseSSL)
                stream = new SslStreamFactory(settings).CreateClientStreamAndAuthenticate(stream);

            return stream;
        }

        /// <summary>
        /// Initiate communication to the remote client and return a stream that can be used to communicate with it. (for acceptor)
        /// </summary>
        /// <param name="tcpClient">The TCP client.</param>
        /// <param name="settings">The socket settings.</param>
        /// <returns>an opened and initiated stream which can be read and written to</returns>
        /// <exception cref="System.ArgumentException">tcp client must be connected in order to get stream;tcpClient</exception>
        public static Stream CreateServerStream(TcpClient tcpClient, SocketSettings settings)
        {
            if (tcpClient.Connected == false)
                throw new ArgumentException("tcp client must be connected in order to get stream", nameof(tcpClient));

            Stream stream = tcpClient.GetStream();
            if (settings.UseSSL)
            {
                stream = new SslStreamFactory(settings).CreateServerStreamAndAuthenticate(stream);
            }

            return stream;
        }

        /// <summary>
        /// Cache loaded certificates since loading a certificate can be a costly operation
        /// </summary>
        private static readonly Dictionary<string, X509Certificate2> CertificateCache = new ();

        /// <summary>
        /// Loads the specified certificate given a path, DistinguishedName or subject name
        /// </summary>
        /// <param name="name">The certificate path or DistinguishedName/subjectname if it should be loaded from the personal certificate store.</param>
        /// <param name="password">The certificate password.</param>
        /// <returns>The specified certificate, or null if no certificate is found</returns>
        private static X509Certificate2? LoadCertificate(string name, string? password)
        {
            // TODO: Change _certificateCache's type to ConcurrentDictionary once we start targeting .NET 4,
            //   then remove this lock and use GetOrAdd function of concurrent dictionary
            //   e.g.: certificate = _certificateCache.GetOrAdd(name, (key) => LoadCertificateInner(name, password));
            lock (CertificateCache)
            {
                if (CertificateCache.TryGetValue(name, out X509Certificate2? certificate))
                    return certificate;

                certificate = LoadCertificateInner(name, password);

                if (certificate is not null)
                    CertificateCache.Add(name, certificate);

                return certificate;
            }
        }

        /// <summary>
        /// Perform the actual loading of a certificate
        /// </summary>
        /// <param name="name">The certificate path or DistinguishedName/subjectname if it should be loaded from the personal certificate store.</param>
        /// <param name="password">The certificate password.</param>
        /// <returns>The specified certificate, or null if no certificate is found</returns>
        private static X509Certificate2? LoadCertificateInner(string name, string? password)
        {
            X509Certificate2? certificate;

            // If no extension is found try to get from certificate store
            if (!File.Exists(name))
            {
                certificate = GetCertificateFromStore(name);
            }
            else {
                certificate = password is not null
                    ? new X509Certificate2(name, password)
                    : new X509Certificate2(name);
            }
            return certificate;
        }

        /// <summary>
        /// Gets the certificate from store.
        /// </summary>
        /// <remarks>See http://msdn.microsoft.com/en-us/library/system.security.cryptography.x509certificates.x509certificate2.aspx for complete example</remarks>
        /// <param name="certName">Name of the cert.</param>
        /// <returns>The cert, or null if not found</returns>
        private static X509Certificate2? GetCertificateFromStore(string certName)
        {
            return GetCertificateFromStoreHelper(certName, new X509Store(StoreLocation.LocalMachine))
                ?? GetCertificateFromStoreHelper(certName, new X509Store(StoreLocation.CurrentUser));
        }

        private static X509Certificate2? GetCertificateFromStoreHelper(string certName, X509Store store)
        {
            try
            {
                store.Open(OpenFlags.ReadOnly);

                // Place all certificates in an X509Certificate2Collection object.
                X509Certificate2Collection certCollection = store.Certificates;
                // If using a certificate with a trusted root you do not need to FindByTimeValid, instead: 
                // currentCerts.Find(X509FindType.FindBySubjectDistinguishedName, certName, true);
                X509Certificate2Collection currentCerts = certCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, false);

                currentCerts = currentCerts.Find(certName.Contains("CN=")
                    ? X509FindType.FindBySubjectDistinguishedName
                    : X509FindType.FindBySubjectName, certName, false);

                if (currentCerts.Count == 0)
                    return null;

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
        private sealed class SslStreamFactory
        {
            private readonly SocketSettings _socketSettings;
            private const string CLIENT_AUTHENTICATION_OID = "1.3.6.1.5.5.7.3.2";
            private const string SERVER_AUTHENTICATION_OID = "1.3.6.1.5.5.7.3.1";

            public SslStreamFactory(SocketSettings settings)
            {
                _socketSettings = settings;
            }

            /// <summary>
            /// Creates a SslStream in client mode and authenticate.
            /// </summary>
            /// <param name="innerStream">The stream to use for the actual (ssl encrypted) communication.</param>
            /// <returns>a ssl enabled stream</returns>
            public Stream CreateClientStreamAndAuthenticate(Stream innerStream)
            {
                SslStream sslStream = new SslStream(
                    innerStream,
                    false,
                    ValidateServerCertificate,
#pragma warning disable CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).
                    // Per MS docs, this delete /should/ have a nullable return type
                    SelectLocalCertificate);
#pragma warning restore CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).

                try
                {
                    // Setup secure SSL Communication
                    X509CertificateCollection clientCertificates = GetClientCertificates();
                    sslStream.AuthenticateAsClient(_socketSettings.ServerCommonName,
                        clientCertificates,
                        _socketSettings.SslProtocol,
                        _socketSettings.CheckCertificateRevocation);
                }
                catch (System.Security.Authentication.AuthenticationException ex)
                {
                    Log($"Unable to perform authentication against server: {ex.GetFullMessage()}");
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
                SslStream sslStream = new SslStream(
                    innerStream,
                    false,
                    ValidateClientCertificate,
#pragma warning disable CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).
                    // Per MS docs, this delete /should/ have a nullable return type
                    SelectLocalCertificate);
#pragma warning restore CS8621 // Nullability of reference types in return type doesn't match the target delegate (possibly because of nullability attributes).

                try
                {
                    if (string.IsNullOrEmpty(_socketSettings.CertificatePath))
                        throw new Exception($"No server certificate specified, the {SessionSettings.SSL_CERTIFICATE} setting must be configured");

                    // Setup secure SSL Communication
                    X509Certificate2? serverCertificate = LoadCertificate(_socketSettings.CertificatePath, _socketSettings.CertificatePassword);
                    sslStream.AuthenticateAsServer(new SslServerAuthenticationOptions
                    {
                        ServerCertificate = serverCertificate,
                        ClientCertificateRequired = _socketSettings.RequireClientCertificate,
                        EnabledSslProtocols = _socketSettings.SslProtocol,
                        CertificateRevocationCheckMode = _socketSettings.CheckCertificateRevocation ? X509RevocationMode.Online : X509RevocationMode.NoCheck,
                        EncryptionPolicy = EncryptionPolicy.RequireEncryption
                    });
                }
                catch (System.Security.Authentication.AuthenticationException ex)
                {
                    Log($"Unable to perform authentication against server: {ex.GetFullMessage()}");
                    throw;
                }

                return sslStream;
            }

            private X509CertificateCollection GetClientCertificates()
            {
                var rv = new X509Certificate2Collection();
                if (!string.IsNullOrEmpty(_socketSettings.CertificatePath))
                {
                    X509Certificate2? clientCert = LoadCertificate(_socketSettings.CertificatePath, _socketSettings.CertificatePassword);
                    if (clientCert is not null)
                        rv.Add(clientCert);
                }

                return rv;
            }

            /// <summary>
            /// Perform validation of the servers certificate. (the initiator validates the server/acceptors certificate)
            /// (Satisfies interface to delegate System.Net.Security.RemoteCertificateValidationCallback)
            /// </summary>
            /// <param name="sender">The sender.</param>
            /// <param name="certificate">The certificate.</param>
            /// <param name="chain">The chain.</param>
            /// <param name="sslPolicyErrors">The SSL policy errors.</param>
            /// <returns> <c>true</c> if the certificate should be treated as trusted; otherwise <c>false</c> </returns>
            private bool ValidateServerCertificate(object sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors)
            {
                return VerifyRemoteCertificate(certificate, sslPolicyErrors, SERVER_AUTHENTICATION_OID);
            }

            /// <summary>
            /// Perform validation of a a client certificate.(the acceptor validates the client/initiators certificate)
            /// (Satisfies interface to delegate System.Net.Security.RemoteCertificateValidationCallback)
            /// </summary>
            /// <param name="sender">The sender.</param>
            /// <param name="certificate">The certificate.</param>
            /// <param name="chain">The chain.</param>
            /// <param name="sslPolicyErrors">The SSL policy errors.</param>
            /// <returns> <c>true</c> if the certificate should be treated as trusted; otherwise <c>false</c> </returns>
            private bool ValidateClientCertificate(object sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors)
            {
                return VerifyRemoteCertificate(certificate, sslPolicyErrors, CLIENT_AUTHENTICATION_OID);
            }

            /// <summary>
            /// Perform certificate validation common for both server and client.
            /// </summary>
            /// <param name="certificate">The remote certificate to validate.</param>
            /// <param name="sslPolicyErrors">The SSL policy errors supplied by .Net.</param>
            /// <param name="enhancedKeyUsage">Enhanced key usage, which the remote computers certificate should contain.</param>
            /// <returns> <c>true</c> if the certificate should be treated as trusted; otherwise <c>false</c> </returns>
            private bool VerifyRemoteCertificate(
                X509Certificate? certificate,
                SslPolicyErrors sslPolicyErrors,
                string enhancedKeyUsage)
            {
                // Accept without looking at if the certificate is valid if validation is disabled
                if (_socketSettings.ValidateCertificates == false)
                    return true;

                if (certificate is null)
                    return false;

                // Validate enhanced key usage
                if (!ContainsEnhancedKeyUsage(certificate, enhancedKeyUsage)) {
                    if (enhancedKeyUsage == CLIENT_AUTHENTICATION_OID)
                        Log($"Remote certificate is not intended for client authentication: It is missing enhanced key usage {enhancedKeyUsage}");
                    else
                        Log($"Remote certificate is not intended for server authentication: It is missing enhanced key usage {enhancedKeyUsage}");

                    return false;
                }

                if (string.IsNullOrEmpty(_socketSettings.CACertificatePath)) {
                    Log("CACertificatePath is not specified");
                    return false;
                }

                // If CA Certficiate is specified then validate agains the CA certificate, otherwise it is validated against the installed certificates
                X509Certificate2? cert = LoadCertificate(_socketSettings.CACertificatePath, null);
                if (cert is null) {
                    Log($"Remote certificate was not recognized as a valid certificate: {sslPolicyErrors}");
                    return false;
                }

                X509Chain chain0 = new X509Chain();
                chain0.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                // add all your extra certificate chain

                chain0.ChainPolicy.ExtraStore.Add(cert);
                chain0.ChainPolicy.VerificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;
                bool isValid = chain0.Build((X509Certificate2)certificate);

                if (isValid)
                {
                    // resets the sslPolicyErrors.RemoteCertificateChainErrors status
                    sslPolicyErrors &= ~SslPolicyErrors.RemoteCertificateChainErrors;
                }
                else
                {
                    sslPolicyErrors |= SslPolicyErrors.RemoteCertificateChainErrors;
                }

                // Any basic authentication check failed, do after checking CA
                if (sslPolicyErrors != SslPolicyErrors.None)
                {
                    Log($"Remote certificate was not recognized as a valid certificate: {sslPolicyErrors}");
                    return false;
                }

                // No errors found accept the certificate
                return true;
            }

            /// <summary>
            /// Check if the given certificate contains the given enhanced key usage Oid
            /// </summary>
            /// <param name="certificate">X509 certificate</param>
            /// <param name="enhancedKeyOid">the oid to check if it is specified</param>
            /// <returns><c>true</c> if the oid is specified as an enhanced key usage; otherwise <c>false</c></returns>
            private static bool ContainsEnhancedKeyUsage(X509Certificate certificate, string enhancedKeyOid)
            {
                X509Certificate2 cert2 = certificate as X509Certificate2 ?? new X509Certificate2(certificate);

                foreach (X509Extension extension in cert2.Extensions)
                {
                    if (extension is X509EnhancedKeyUsageExtension keyUsage)
                    {
                        foreach (System.Security.Cryptography.Oid oid in keyUsage.EnhancedKeyUsages)
                        {
                            if (oid.Value == enhancedKeyOid)
                                return true;
                        }
                    }
                }

                return false;
            }

            /// <summary>
            /// (Satisfies interface to delegate System.Net.Security.LocalCertificateSelectionCallback)
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="targetHost"></param>
            /// <param name="localCertificates"></param>
            /// <param name="remoteCertificate"></param>
            /// <param name="acceptableIssuers"></param>
            /// <returns></returns>
            private static X509Certificate? SelectLocalCertificate(
                object sender,
                string targetHost,
                X509CertificateCollection localCertificates,
                X509Certificate? remoteCertificate,
                string[] acceptableIssuers)
            {
                // No certificate can be selected if we have no local certificates at all
                if (localCertificates.Count <= 0)
                    return null;

                Debug.Assert(localCertificates is not null && localCertificates.Count > 0);

                //Otherwise we select the first availible certificate as per msdn documentation
                // http://msdn.microsoft.com/en-us/library/system.net.security.localcertificateselectioncallback.aspx
                if (acceptableIssuers.Length > 0)
                {
                    // Use the first certificate that is from an acceptable issuer. 
                    foreach (X509Certificate certificate in localCertificates)
                    {
                        string issuer = certificate.Issuer;
                        if (Array.IndexOf(acceptableIssuers, issuer) != -1)
                            return certificate;
                    }
                }

                // Just use any certificate (if there is one)
                if (localCertificates.Count > 0)
                    return localCertificates[0];

                return null;
            }

            private void Log(string s) {
                // TODO this is just a temp console log until I do something better
                Console.WriteLine(s);
            }
        }
    }
}
