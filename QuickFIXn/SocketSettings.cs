using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// Keep all socket settings in one place
    /// </summary>
    public class SocketSettings
    {
        public bool SocketNodelay = true;

        #region SSL Settings
        public string HostName;
        public bool ValidateServerCertificate = true;
        public string CertificatePath;
        public string CertificatePassword;
        public SslProtocols SslProtocol = SslProtocols.Default;
        public bool CheckCertificateRevocation = true;

        public bool UseSSL
        {
            get
            {
                return !string.IsNullOrEmpty(CertificatePath);
            }
        }

        /// <summary>
        /// Path to .cer with the public part of the Certificate CA to validate clients against
        /// </summary>
        public string CACertificatePath;
        public bool RequireClientCertificate { get { return !string.IsNullOrEmpty(CACertificatePath); } }
        #endregion

        /// <summary>
        /// Setup socket settings based on setttings specified in dictionary
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

            if (dictionary.Has(SessionSettings.SSL_HOSTNAME))
                HostName = dictionary.GetString(SessionSettings.SSL_HOSTNAME);

            if (dictionary.Has(SessionSettings.SSL_CA_CERTIFICATE_PATH))
                CACertificatePath = dictionary.GetString(SessionSettings.SSL_CA_CERTIFICATE_PATH);

            if (dictionary.Has(SessionSettings.SSL_CERTIFICATE_PATH))
                CertificatePath = dictionary.GetString(SessionSettings.SSL_CERTIFICATE_PATH);

            if (dictionary.Has(SessionSettings.SSL_CERTIFICATE_PASSWORD))
                CertificatePassword = dictionary.GetString(SessionSettings.SSL_CERTIFICATE_PASSWORD);

            if (dictionary.Has(SessionSettings.SSL_VALIDATE_SERVER_CERTIFICATE))
                ValidateServerCertificate = dictionary.GetBool(SessionSettings.SSL_VALIDATE_SERVER_CERTIFICATE);

            if (dictionary.Has(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION))
                CheckCertificateRevocation = dictionary.GetBool(SessionSettings.SSL_CHECK_CERTIFICATE_REVOCATION);

            if (dictionary.Has(SessionSettings.SSL_PROTOCOLS))
            {
                var protocolString = dictionary.GetString(SessionSettings.SSL_PROTOCOLS);

                // only work in .net 4.0 so comment out
                //// Try to parse enum while ignoring case
                //System.Security.Authentication.SslProtocols protocol;
                //if (Enum.TryParse<System.Security.Authentication.SslProtocols>(protocolString, true, out protocol))
                //    socketSettings_.SslProtocol = protocol;

                try
                {
                    SslProtocol = (System.Security.Authentication.SslProtocols)
                                                       Enum.Parse(typeof(System.Security.Authentication.SslProtocols), protocolString, ignoreCase: true);
                }
                catch (Exception)
                {
                }
            }
        }


    }
}
