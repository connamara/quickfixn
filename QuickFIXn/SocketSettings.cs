using System;
using System.Security.Authentication;

namespace QuickFix
{
    /// <summary>
    /// Keep all socket settings in one place
    /// </summary>
    /// <remarks>
    /// Property setters are internal so they can be set in tests, otherwise the settings should
    /// be set using the <see cref="Configure"/> function
    /// </remarks>
    public class SocketSettings : ICloneable
    {
        #region Socket Settings

        /// <summary>
        /// Gets a value that specifies whether the <see cref="T:System.Net.Sockets.Socket"/> is using the Nagle algorithm.
        /// </summary>
        /// <value>
        /// <c>false</c> if the socket uses the Nagle algorithm; otherwise, <c>true</c>. The default is <c>false</c>.
        /// </value>
        public bool SocketNodelay { get; internal set; }

        /// <summary>
        /// Gets the size of the <see cref="T:System.Net.Sockets.Socket"/> receive buffer.
        /// </summary>
        /// <value>
        /// The size, in bytes, of the receive buffer. A <c>null</c> value defaults to 8192.
        /// </value>
        public int? SocketReceiveBufferSize { get; internal set; }

        /// <summary>
        /// Gets the size of the <see cref="T:System.Net.Sockets.Socket"/> send buffer.
        /// </summary>
        /// <value>
        /// The size, in bytes, of the send buffer. A <c>null</c> value defaults to 8192.
        /// </value>
        public int? SocketSendBufferSize { get; internal set; }

        /// <summary>
        /// Gets the amount of time in milliseconds after which a synchronous
        /// <see cref="T:System.Net.Sockets.Socket"/> Receive() call will time out.
        /// </summary>
        /// <value>
        /// The time-out value, in milliseconds. A <c>null</c>, <c>0</c> or <c>-1</c>
        /// value indicates an infinite time-out period.
        /// </value>
        public int? SocketReceiveTimeout { get; internal set; }

        /// <summary>
        /// Gets the amount of time in milliseconds after which a synchronous
        /// <see cref="T:System.Net.Sockets.Socket"/> Send() call will time out.
        /// </summary>
        /// <value>
        /// The time-out value, in milliseconds. A <c>null</c>, <c>0</c> or <c>-1</c>
        /// value indicates an infinite time-out period.
        /// </value>
        public int? SocketSendTimeout { get; internal set; }

        #endregion

        #region SSL Settings

        /// <summary>
        /// Gets the Server's Common Name (CN) .
        /// </summary>
        /// <value>
        /// The common name is the name of the Server's certificate and it is usually
        /// the DNS name of the server.
        /// </value>
        public string ServerCommonName { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether certificates of the other endpoint should be validated.
        /// </summary>
        /// <value>
        /// <c>true</c> if certificates should be validated; otherwise, <c>false</c>.
        /// </value>
        public bool ValidateCertificates { get; internal set; }

        /// <summary>
        /// Gets the path the the client/server-certificate.
        /// </summary>
        /// <value>
        /// The certificate path.
        /// </value>
        public string CertificatePath { get; internal set; }

        /// <summary>
        /// Gets the certificate password.
        /// </summary>
        /// <value>
        /// The certificate password.
        /// </value>
        public string CertificatePassword { get; internal set; }

        /// <summary>
        /// Gets the SSL protocol to use (for initiator) or accept (for acceptor)
        /// </summary>
        /// <value>
        /// The SSL protocol.
        /// </value>
        public SslProtocols SslProtocol { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether the check for certificate revocation (use CRL)
        /// </summary>
        /// <value>
        /// <c>true</c> if certificate revocation status should be checked; otherwise, <c>false</c>.
        /// </value>
        public bool CheckCertificateRevocation { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether SSL should be used for the socket.
        /// </summary>
        /// <value>
        ///   <c>true</c> if SSL should be enabled; otherwise, <c>false</c>.
        /// </value>
        public bool UseSSL { get; private set; }


        /// <summary>
        /// Path to .cer with the public part of the Certificate CA to validate clients against (acceptor setting).
        /// </summary>
        /// <value>
        /// The CA certificate path.
        /// </value>
        public string CACertificatePath { get; set; }

        /// <summary>
        /// Gets a value indicating whether client certificate are required (acceptor setting).
        /// </summary>
        /// <value>
        /// <c>true</c> if [require client certificate]; otherwise, <c>false</c>.
        /// </value>
        public bool RequireClientCertificate { get; internal set; }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="SocketSettings"/> class.
        /// Here we setup the default values
        /// </summary>
        public SocketSettings()
        {
            ValidateCertificates = true;
            SslProtocol = SslProtocols.Default;
            CheckCertificateRevocation = true;
            RequireClientCertificate = true;
            SocketNodelay = true;
        }

        /// <summary>
        /// Setup socket settings based on settings specified in dictionary
        /// </summary>
        /// <remarks>
        /// used "Configure" as name since it is used in a lot of other places, 
        /// alternative names are ReadSettings or FromDictionary 
        /// </remarks>
        /// <param name="dictionary">the dictionary to read the settings from</param>
        public void Configure(QuickFix.Dictionary dictionary)
        {
            if (dictionary.Has(SessionSettings.SOCKET_NODELAY))
                SocketNodelay = dictionary.GetBool(SessionSettings.SOCKET_NODELAY);

            if (dictionary.Has(SessionSettings.SOCKET_RECEIVE_BUFFER_SIZE))
                SocketReceiveBufferSize = dictionary.GetInt(SessionSettings.SOCKET_RECEIVE_BUFFER_SIZE);

            if (dictionary.Has(SessionSettings.SOCKET_SEND_BUFFER_SIZE))
                SocketSendBufferSize = dictionary.GetInt(SessionSettings.SOCKET_SEND_BUFFER_SIZE);

            if (dictionary.Has(SessionSettings.SOCKET_RECEIVE_TIMEOUT))
                SocketReceiveTimeout = dictionary.GetInt(SessionSettings.SOCKET_RECEIVE_TIMEOUT);

            if (dictionary.Has(SessionSettings.SOCKET_SEND_TIMEOUT))
                SocketSendTimeout = dictionary.GetInt(SessionSettings.SOCKET_SEND_TIMEOUT);

            if (dictionary.Has(SessionSettings.SSL_SERVERNAME))
                ServerCommonName = dictionary.GetString(SessionSettings.SSL_SERVERNAME);

            if (dictionary.Has(SessionSettings.SSL_CA_CERTIFICATE))
                CACertificatePath = dictionary.GetString(SessionSettings.SSL_CA_CERTIFICATE);

            if (dictionary.Has(SessionSettings.SSL_CERTIFICATE))
                CertificatePath = dictionary.GetString(SessionSettings.SSL_CERTIFICATE);

            if (dictionary.Has(SessionSettings.SSL_CERTIFICATE_PASSWORD))
                CertificatePassword = dictionary.GetString(SessionSettings.SSL_CERTIFICATE_PASSWORD);

            if (dictionary.Has(SessionSettings.SSL_VALIDATE_CERTIFICATES))
                ValidateCertificates = dictionary.GetBool(SessionSettings.SSL_VALIDATE_CERTIFICATES);

            if (dictionary.Has(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION))
            {
                // can only be true if ValdateCertificates is true (this is noted in the config docs)
                CheckCertificateRevocation = ValidateCertificates && dictionary.GetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION);
            }

            // Use setting for client certificate check if one exist 
            // otherwise enable client certificate check if a ca certificate is specified
            if (dictionary.Has(SessionSettings.SSL_REQUIRE_CLIENT_CERTIFICATE))
                RequireClientCertificate = dictionary.GetBool(SessionSettings.SSL_REQUIRE_CLIENT_CERTIFICATE);

            // Use setting for SSL if one exist 
            // otherwise enable ssl if certificate path is specified 
            if (dictionary.Has(SessionSettings.SSL_ENABLE))
                UseSSL = dictionary.GetBool(SessionSettings.SSL_ENABLE);
            else
                UseSSL = !string.IsNullOrEmpty(CertificatePath);

            if (dictionary.Has(SessionSettings.SSL_PROTOCOLS))
            {
                var protocolString = dictionary.GetString(SessionSettings.SSL_PROTOCOLS);

                try
                {
                    SslProtocol = (System.Security.Authentication.SslProtocols)
                        Enum.Parse(typeof(System.Security.Authentication.SslProtocols), protocolString, true);
                }
                catch (Exception)
                {
                    // TODO: figure out a way to log this somehow (even though it's not likely to occur)
                }
            }
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public SocketSettings Clone()
        {
            return (SocketSettings)MemberwiseClone();
        }
    }
}
