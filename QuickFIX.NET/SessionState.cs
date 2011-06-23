using System.Collections.Generic;

namespace QuickFix
{
    public class SessionState
    {
        private object sync_ = new object();
        private bool isEnabled_ = true;
        private bool sentLogon_ = false;
        private bool receivedLogon_ = false;
        private string logoutReason_ = "";

        #region Properties

        public bool IsEnabled
        {
            get { lock (sync_) { return isEnabled_; } }
            set { lock (sync_) { isEnabled_ = value; } }
        }

        public bool SentLogon
        {
            get { lock (sync_) { return sentLogon_; } }
            set { lock (sync_) { sentLogon_ = value; } }
        }

        public bool ReceivedLogon
        {
            get { lock (sync_) { return receivedLogon_; } }
            set { lock (sync_) { receivedLogon_ = value; } }
        }

        public string LogoutReason
        {
            get { lock (sync_) { return logoutReason_; } }
            set { lock (sync_) { logoutReason_ = value; } }
        }
        
        #endregion

        public SessionState()
        { }
    }
}
