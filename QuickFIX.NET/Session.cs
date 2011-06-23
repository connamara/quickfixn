using System.Collections.Generic;

namespace QuickFix
{
    public class Session
    {
        private static Dictionary<SessionID, Session> sessions_ = new Dictionary<SessionID, Session>();
        private SessionState state_ = new SessionState();
        private SessionSchedule schedule_;

        #region Properties

        public bool IsEnabled
        {
            get { return state_.IsEnabled; }
        }

        public bool IsSessionTime
        {
            get { return schedule_.IsSessionTime; }
        }

        public bool IsLoggedOn
        {
            get { return ReceivedLogon && SentLogon; }
        }

        public bool SentLogon
        {
            get { return state_.SentLogon; }
        }

        public bool ReceivedLogon
        {
            get { return state_.ReceivedLogon; }
        }

        public SessionID SessionID
        { get; set; }

        #endregion

        /// <summary>
        /// FIXME
        /// </summary>
        /// <param name="app"></param>
        /// <param name="storeFactory"></param>
        /// <param name="sessID"></param>
        /// <param name="dataDictProvider"></param>
        /// <param name="sessionSchedule"></param>
        /// <param name="heartBtInt"></param>
        /// <param name="logFactory"></param>
        public Session(Application app, MessageStoreFactory storeFactory, SessionID sessID, DataDictionaryProvider dataDictProvider, SessionSchedule sessionSchedule, int heartBtInt, LogFactory logFactory)
        {
            this.SessionID = sessID;
            schedule_ = sessionSchedule;
        }

        #region Static Methods

        /// <summary>
        /// Looks up a Session by its SessionID
        /// </summary>
        /// <param name="sessionID">the SessionID of the Session</param>
        /// <returns>the Session if found, else returns null</returns>
        public static Session LookupSession(SessionID sessionID)
        {
            Session result;
            lock (sessions_)
            {
                if (!sessions_.TryGetValue(sessionID, out result))
                    result = null;
            }
            return result;
        }

        public static void SendToTarget(Message m)
        { }

        #endregion

        public void Logon()
        {
            state_.IsEnabled = true;
            state_.LogoutReason = "";
        }

        public void Logout()
        {
            Logout("");
        }

        public void Logout(string reason)
        {
            state_.IsEnabled = false;
            state_.LogoutReason = reason;
        }

        /// <summary>
        /// FIXME
        /// </summary>
        /// <param name="s"></param>
        public void SetSenderDefaultApplVerID(string s)
        {
        }
    }
}
