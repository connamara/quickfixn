
namespace QuickFix
{
    public class SessionID
    {
        #region Properties
        
        public string BeginString
        {
            get { return beginString_; }
        }

        public string SenderCompID
        {
            get { return senderCompID_; }
        }

        public string TargetCompID
        {
            get { return targetCompID_; }
        }

        public string SessionQualifier
        {
            get { return sessionQualifier_; }
        }

        public bool isFIXT
        {
            get { return isFIXT_; }
        }

        #endregion

        #region Private Members
        
        private string beginString_;
        private string senderCompID_;
        private string targetCompID_;
        private string sessionQualifier_;
        private bool isFIXT_;

        #endregion

        public SessionID(string beginString, string senderCompID, string targetCompID)
            : this(beginString, senderCompID, targetCompID, "")
        { }

        public SessionID(string beginString, string senderCompID, string targetCompID, string sessionQualifier)
        {
            beginString_  = beginString;
            senderCompID_ = senderCompID;
            targetCompID_ = targetCompID;
            sessionQualifier_ = sessionQualifier;
            isFIXT_ = beginString_.StartsWith("FIXT");
        }
    }
}
