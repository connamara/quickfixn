using System.Collections.Generic;

namespace QuickFix
{
    public class Session
    {
        private static Dictionary<SessionID, Session> sessions_ = new Dictionary<SessionID, Session>();
        private object responderSync_ = new object();
        private Responder responder_ = null;
        private SessionSchedule schedule_;
        private SessionState state_;

        #region Properties

        public Log Log
        {
            get { return state_.Log; }
        }

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
            get { lock (responderSync_) { return null != responder_; } }
        }

        public Responder Responder
        {
            get { lock (responderSync_) { return responder_; } }
            set { lock (responderSync_) { responder_ = value; } }
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

            Log log;
            if (null != logFactory)
                log = logFactory.Create(sessID);
            else
                log = new NullLog();

            state_ = new SessionState(log);

            lock (sessions_)
            {
                sessions_[this.SessionID] = this;
            }
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

        /// <summary>
        /// FIXME send Message, not string
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool SendToTarget(string message, SessionID sessionID)
        {
            //message.SessionID = sessionID;
            Session session = Session.LookupSession(sessionID);
            if(null == session)
                throw new SessionNotFound(sessionID);
            return session.Send(message);
        }

        #endregion

        public bool Send(string message)
        {
            this.Log.OnOutgoing(message);
            lock(responderSync_)
            {
                if(null == responder_)
                    return false;
                return responder_.Send(message);
            }
        }

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
                    this.Log.OnEvent("Session " + this.SessionID + " already disconnected: " + reason);
                    return;
                }
                this.Log.OnEvent("Session " + this.SessionID + " disconnecting: " + reason);
                responder_.Disconnect();
                responder_ = null;
            }
        }

        public void Next()
        {
            System.Console.WriteLine("Session.Next: implement me!");
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
