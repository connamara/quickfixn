
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

        public string SenderSubID
        {
            get { return senderSubID_; }
        }

        public string SenderLocationID
        {
            get { return senderLocationID_; }
        }

        public string TargetCompID
        {
            get { return targetCompID_; }
        }

        public string TargetSubID
        {
            get { return targetSubID_; }
        }

        public string TargetLocationID
        {
            get { return targetLocationID_; }
        }

        public string SessionQualifier
        {
            get { return sessionQualifier_; }
        }

        public bool IsFIXT
        {
            get { return isFIXT_; }
        }

        #endregion

        #region Public Members
        public const string NOT_SET = "";
        #endregion

        #region Private Members
        private string id_;
        private string beginString_;
        private string senderCompID_;
        private string senderSubID_;
        private string senderLocationID_;
        private string targetCompID_;
        private string targetSubID_;
        private string targetLocationID_;
        private string sessionQualifier_;
        private bool isFIXT_;

        #endregion

        public SessionID(string beginString, string senderCompID, string senderSubID, string senderLocationID, string targetCompID, string targetSubID, string targetLocationID, string sessionQualifier)
        {
            beginString_ = beginString;
            senderCompID_ = senderCompID;
            senderSubID_ = senderSubID;
            senderLocationID_ = senderLocationID;
            targetCompID_ = targetCompID;
            targetSubID_ = targetSubID;
            targetLocationID_ = targetLocationID;
            sessionQualifier_ = sessionQualifier;
            isFIXT_ = beginString_.StartsWith("FIXT");

            id_ = beginString_
                + ":"
                + senderCompID_
                + (IsSet(senderSubID_) ? "/" + senderSubID_ : "")
                + (IsSet(senderLocationID_) ? "/" + senderLocationID_ : "")
                + "->"
                + targetCompID_
                + (IsSet(targetSubID_) ? "/" + targetSubID_ : "")
                + (IsSet(targetLocationID_) ? "/" + targetLocationID_ : "");
            if (null != sessionQualifier_ && sessionQualifier_.Length > 0)
                id_ += ":" + sessionQualifier_;
        }

        public SessionID(string beginString, string senderCompID, string targetCompID)
            : this(beginString, senderCompID, targetCompID, NOT_SET)
        { }

        public SessionID(string beginString, string senderCompID, string senderSubID, string targetCompID, string targetSubID)
            : this(beginString, senderCompID, senderSubID, NOT_SET, targetCompID, targetSubID, NOT_SET, NOT_SET)
        { }

        public SessionID(string beginString, string senderCompID, string senderSubID, string senderLocationID, string targetCompID, string targetSubID, string targetLocationID)
            : this(beginString, senderCompID, senderSubID, senderLocationID, targetCompID, targetSubID, targetLocationID, NOT_SET)
        { }

        public SessionID(string beginString, string senderCompID, string targetCompID, string sessionQualifier) 
            : this(beginString, senderCompID, NOT_SET, NOT_SET, targetCompID, NOT_SET, NOT_SET, sessionQualifier)
        { }

        public static bool IsSet(string value)
        {
            return value != null && value != NOT_SET;
        }

        public override string ToString()
        {
            return id_;
        }

        public override int GetHashCode()
        {
            return id_.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            SessionID rhs = (SessionID)obj;
            return id_.Equals(rhs.id_);
        }
    }
}
