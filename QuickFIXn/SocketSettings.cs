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
        #endregion
    }
}
