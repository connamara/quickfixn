using System.Collections.Generic;

namespace QuickFix
{
    public class Session
    {
        private static Dictionary<SessionID, Session> sessions_ = new Dictionary<SessionID, Session>();
        private SessionState state_ = new SessionState();
        private object responderSync_ = new object();
        private Responder responder_ = null;
        private Log log_;
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

        public bool HasResponder
        {
            get { return null != responder_; }
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
            if (null != logFactory)
                log_ = logFactory.Create(sessID);
            else
                log_ = new NullLog();
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

        public void Disconnect(string reason)
        {
            lock (responderSync_)
            {
                if (!HasResponder)
                {
                    log_.OnEvent("Session " + this.SessionID + " already disconnected: " + reason);
                    return;
                }
                log_.OnEvent("Session " + this.SessionID + " disconnecting: " + reason);
                responder_.Disconnect();
                responder_ = null;
            }
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
