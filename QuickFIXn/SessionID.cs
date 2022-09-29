
using System;

namespace QuickFix
{
    /// <summary>
    /// Identifies a session. Only supports a company ID (target, sender)
    /// and a session qualifier. Sessions are also identified by FIX version so
    /// that it's possible to have multiple sessions to the same counterparty
    /// but using different FIX versions (and/or session qualifiers).
    /// 
    /// </summary>
    public class SessionID : IEquatable<SessionID>
    {
        #region Public Members
        public const string NOT_SET = "";
        #endregion

        #region Private Members
        private readonly string _id;
        #endregion

        public SessionID(string beginString, string senderCompID, string senderSubID, string senderLocationID, string targetCompID, string targetSubID, string targetLocationID, string sessionQualifier)
        {
            if (beginString == null)
                throw new ArgumentNullException("beginString");
            if (senderCompID == null)
                throw new ArgumentNullException("senderCompID");
            if (targetCompID == null)
                throw new ArgumentNullException("targetCompID");
            BeginString = beginString;
            SenderCompID = senderCompID;
            SenderSubID = senderSubID;
            SenderLocationID = senderLocationID;
            TargetCompID = targetCompID;
            TargetSubID = targetSubID;
            TargetLocationID = targetLocationID;
            SessionQualifier = sessionQualifier;
            IsFIXT = beginString.StartsWith("FIXT");
            _id = $"{beginString}:{senderCompID}{(IsSet(senderSubID) ? "/" + senderSubID : "")}{(IsSet(senderLocationID) ? "/" + senderLocationID : "")}" +
                $"->{targetCompID}{(IsSet(targetSubID) ? "/" + targetSubID : "")}{(IsSet(targetLocationID) ? "/" + targetLocationID : "")}{(string.IsNullOrEmpty(sessionQualifier) ? "" : ":" + sessionQualifier)}";
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

        #region Properties

        public string BeginString { get; }

        public string SenderCompID { get; }

        public string SenderSubID { get; }

        public string SenderLocationID { get; }

        public string TargetCompID { get; }

        public string TargetSubID { get; }

        public string TargetLocationID { get; }

        /// <summary>
        /// Session qualifier can be used to identify different sessions
        /// for the same target company ID. Session qualifiers can only be used
        /// with initiated sessions. They cannot be used with accepted sessions.
        /// </summary>
        public string SessionQualifier { get; }

        /// <summary>
        /// Returns whether session version is FIXT 1.1 or newer
        /// </summary>
        public bool IsFIXT { get; }

        #endregion

        public static bool IsSet(string value)
        {
            return value != null && value != NOT_SET;
        }

        public override string ToString()
        {
            return _id;
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Equals(obj as SessionID);
        }

        public bool Equals(SessionID other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            return _id.Equals(other._id);
        }

        [Obsolete]
        internal static SessionID FromString(string sessionID)
        {
            if (string.IsNullOrEmpty(sessionID))
            {
                throw new ArgumentNullException("invalid sessionID");
            }
            var initialSplit = sessionID.Split(':');
            if (initialSplit.Length < 2 || initialSplit.Length > 3)
            {
                throw new ArgumentException("invalid sessionID");
            }
            var sessionQualifier = initialSplit.Length == 3 ? initialSplit[2] : NOT_SET;
            var beginString = initialSplit[0];
            var midSplit = initialSplit[1].Split(new string[] { "->" }, StringSplitOptions.None);
            if (midSplit.Length != 2)
            {
                throw new ArgumentException("invalid sessionID");
            }
            var senderSplit = midSplit[0].Split('/');
            var targetSplit = midSplit[1].Split('/');
            if (senderSplit.Length > 3 || targetSplit.Length > 3)
            {
                throw new ArgumentException("invalid sessionID");
            }
            var senderCompID = senderSplit[0];
            var senderSubID = senderSplit.Length > 1 ? senderSplit[1] : NOT_SET;
            var senderLocationID = senderSplit.Length > 2 ? senderSplit[2] : NOT_SET;
            var targetCompID = targetSplit[0];
            var targetSubID = targetSplit.Length > 1 ? targetSplit[1] : NOT_SET;
            var targetLocationID = targetSplit.Length > 2 ? targetSplit[2] : NOT_SET;
            return new SessionID(
                beginString, 
                senderCompID, 
                senderSubID, 
                senderLocationID, 
                targetCompID, 
                targetSubID, 
                targetLocationID, 
                sessionQualifier);
        }

        
    }
}
