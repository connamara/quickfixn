using System.Collections.Generic;

namespace QuickFix
{
    public class Session
    {
        private static Dictionary<SessionID, Session> sessions_ = new Dictionary<SessionID, Session>();
        private object sync_ = new object();
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

        public int HeartBtInt
        {
            get { return state_.HeartBtInt; }
        }

        public bool PersistMessages
        { get; set; }

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

            state_ = new SessionState(log, heartBtInt);
            state_.MessageStore = storeFactory.Create(sessID);

            lock (sessions_)
            {
                sessions_[this.SessionID] = this;
            }

            this.PersistMessages = true;
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
            //System.Console.WriteLine(state_.ToString());

            if (!IsEnabled) 
            {
                if (!IsLoggedOn)
                    return;
                
                /* TODO
                if (!state_.SentLogon) 
                {
                    this.Log.OnEvent("Initiated logout request");
                    GenerateLogout(state_.LogoutReason);
                }
                */
            }

            /* TODO
            if (!CheckSessionTime()) 
            {
                Reset();
                return;
            }
            */

            if (!HasResponder) 
                return;

            if (!state_.ReceivedLogon) 
            {
                if (state_.ShouldSendLogon && IsTimeToGenerateLogon())
                {
                    if (GenerateLogon()) 
                        this.Log.OnEvent("Initiated logon request");
                    else
                        this.Log.OnEvent("Error during logon request initiation");
                
                } 
                else if (state_.SentLogon && state_.LogonTimedOut()) 
                {
                    Disconnect("Timed out waiting for logon response");
                }
                return;
            }

            if (0 == state_.HeartBtInt)
                return;
          
            /* TODO
            if (state_.IsLogoutTimedOut)
                Disconnect("Timed out waiting for heartbeat");
            */

            if (state_.WithinHeartbeat())
                return;

            if (state_.TimedOut()) 
            {
                Disconnect("Timed out waiting for heartbeat");
            }
            else 
            {
                if (state_.NeedTestRequest())
                {
                    
                    GenerateTestRequest("TEST");
                    state_.TestRequestCounter += 1;
                    this.Log.OnEvent("Sent test request TEST");
                } 
                else if (state_.NeedHeartbeat()) 
                {
                    GenerateHeartbeat();
                }
            }
        }

        public void Next(string message)
        {
            this.Log.OnIncoming(message);
            Next(new Message(message));
        }

        public void Next(Message message)
        {
            Header header = message.Header;
            string msgType = header.GetField(Fields.Tags.MsgType);
            if ("A".Equals(msgType))
                NextLogon(message);
            else if ("0".Equals(msgType))
                NextHeartbeat(message);
            else if ("1".Equals(msgType))
                NextTestRequest(message);
            else if ("5".Equals(msgType))
                NextLogout(message);
            else
            {
                if (!Verify(message))
                    return;
                state_.IncrNextTargetMsgSeqNum();
            }
        }

        protected void NextQueued()
        {
            System.Console.WriteLine("FIXME - Session.NextQueued not implemented!");
        }

        protected void NextLogon(Message logon)
        {
            if (!Verify(logon))
                return;

            state_.ReceivedLogon = true;
            this.Log.OnEvent("Received logon");
            if (!state_.IsInitiator)
            {
                int heartBtInt = Fields.Converters.IntConverter.Convert(logon.GetField(Fields.Tags.HeartBtInt)); /// FIXME
                state_.HeartBtInt = heartBtInt;
                GenerateLogon(heartBtInt);
                this.Log.OnEvent("Responding to logon request");
            }

            state_.SentReset = false;
            state_.ReceivedReset = false;
        }

        protected void NextTestRequest(Message testRequest)
        {
            if (!Verify(testRequest))
                return;
            GenerateHeartbeat(testRequest);
            state_.IncrNextTargetMsgSeqNum();
            NextQueued();
        }

        protected void NextLogout(Message logout)
        {
            if (!Verify(logout))
                return;

            string disconnectReason;

            if (!state_.SentLogout)
            {
                disconnectReason = "Received logout request";
                this.Log.OnEvent(disconnectReason);
                GenerateLogout();
                this.Log.OnEvent("Sending logout response");
            }
            else
            {
                disconnectReason = "Received logout response";
                this.Log.OnEvent(disconnectReason);
            }

            state_.IncrNextTargetMsgSeqNum();
            /// FIXME if (this.ResetOnLogout)
            /// FIXME    state_.Reset();
            Disconnect(disconnectReason);
        }

        protected void NextHeartbeat(Message heartbeat)
        {
            if (!Verify(heartbeat))
                return;
            state_.IncrNextTargetMsgSeqNum();
            NextQueued();
        }

        public bool Verify(Message message)
        {
            state_.LastReceivedTimeTickCount = System.Environment.TickCount;
            state_.TestRequestCounter = 0;
            return true;
        }

        /// <summary>
        /// FIXME
        /// </summary>
        /// <param name="s"></param>
        public void SetSenderDefaultApplVerID(string s)
        {
        }

        /// <summary>
        /// FIXME
        /// </summary>
        /// <returns></returns>
        protected bool IsTimeToGenerateLogon()
        {
            return true;
        }

        /// <summary>
        /// FIXME
        /// </summary>
        /// <returns></returns>
        protected bool GenerateLogon()
        {
            Message logon = new Message();
            logon.Header.setField(new Fields.MsgType("A"));
            logon.setField(new Fields.EncryptMethod(0));
            logon.setField(new Fields.HeartBtInt(state_.HeartBtInt));
            /*
            if( this.SessionID.IsFIXT)
                logon.setField( new Fields.DefaultApplVerID("FIXME"));
            if(RefreshOnLogon)
                Refresh();
            if(ResetOnLogon)
                state_.Reset();
            if(ShouldSendReset)
                logon.setField(new Fields.ResetSeqNumFlag(true));
            */
            InitializeHeader(logon);
            state_.LastReceivedTimeTickCount = System.Environment.TickCount;
            state_.TestRequestCounter = 0;
            state_.SentLogon = true;
            return SendRaw(logon, 0);
        }

        /// <summary>
        /// FIXME don't do so much operator new here
        /// </summary>
        /// <param name="heartBtInt"></param>
        /// <returns></returns>
        protected bool GenerateLogon(int heartBtInt)
        {
            Message logon = new Message();
            logon.setField(new Fields.EncryptMethod(0));
            if (this.SessionID.IsFIXT)
                logon.setField(new Fields.DefaultApplVerID("FIXME"));
            if (state_.ReceivedReset)
                logon.setField(new Fields.ResetSeqNumFlag(true));
            logon.Header.setField(new Fields.MsgType("A"));
            logon.setField(new Fields.HeartBtInt(heartBtInt));
            InitializeHeader(logon);
            state_.SentLogon = SendRaw(logon, 0);
            return state_.SentLogon;
        }

        public bool GenerateTestRequest(string id)
        {
            Message testRequest = new Message();
            testRequest.Header.setField(new Fields.MsgType("1"));
            InitializeHeader(testRequest);
            testRequest.setField(new Fields.TestReqID(id));
            return SendRaw(testRequest, 0);
        }

        public bool GenerateLogout()
        {
            return GenerateLogout("");
        }

        public bool GenerateLogout(string text)
        {
            Message logout = new Message();
            logout.Header.setField(new Fields.MsgType("5"));
            InitializeHeader(logout);
            if (text.Length > 0)
                logout.setField(new Fields.Text(text));
            state_.SentLogout = SendRaw(logout, 0);
            return state_.SentLogout;
        }

        public bool GenerateHeartbeat()
        {
            Message heartbeat = new Message();
            heartbeat.Header.setField(new Fields.MsgType("0"));
            InitializeHeader(heartbeat);
            return SendRaw(heartbeat, 0);
        }

        public bool GenerateHeartbeat(Message testRequest)
        {
            Message heartbeat = new Message();
            heartbeat.Header.setField(new Fields.MsgType("0"));
            InitializeHeader(heartbeat);
            try
            {
                heartbeat.setField(new Fields.TestReqID(testRequest.GetField(Fields.Tags.TestReqID)));
            }
            catch (FieldNotFoundException)
            { }
            return SendRaw(heartbeat, 0);
        }

        /// <summary>
        /// FIXME don't do so much operator new here
        /// </summary>
        /// <param name="m"></param>
        protected void InitializeHeader(Message m)
        {
            state_.LastSentTimeTickCount = System.Environment.TickCount;
            m.Header.setField(new Fields.BeginString(this.SessionID.BeginString));
            m.Header.setField(new Fields.SenderCompID(this.SessionID.SenderCompID));
            m.Header.setField(new Fields.TargetCompID(this.SessionID.TargetCompID));
            m.Header.setField(new Fields.MsgSeqNum(state_.GetNextSenderMsgSeqNum()));
            InsertSendingTime(m.Header);    
        }

        protected void InsertSendingTime(FieldMap header)
        {
            header.setField(new Fields.SendingTime(System.DateTime.UtcNow));
        }

        protected void Persist(Message message, string messageString)
        {
            Fields.MsgSeqNum msgSeqNum = new Fields.MsgSeqNum();
            message.Header.getField(msgSeqNum);
            if (this.PersistMessages)
                state_.Set(msgSeqNum.Obj, messageString);
            state_.IncrNextSenderMsgSeqNum();
        }

        protected bool SendRaw(Message message, int seqNum)
        {
            lock (sync_)
            {
                string msgType = message.Header.GetField(Fields.Tags.MsgType);
                if(Message.IsAdminMsgType(msgType))
                {
                    /// FIXME application_.ToAdmin(message, this.SessionID);

                    if( msgType == "A" && !state_.ReceivedReset)
                    {
                        Fields.ResetSeqNumFlag resetSeqNumFlag = new QuickFix.Fields.ResetSeqNumFlag(false);
                        if(message.isSetField(resetSeqNumFlag))
                            message.getField(resetSeqNumFlag);
                        if(resetSeqNumFlag.getValue())
                        {
                            state_.Reset();
                            message.Header.setField(new Fields.MsgSeqNum(state_.GetNextSenderMsgSeqNum()));
                        }
                        state_.SentReset = resetSeqNumFlag.Obj;
                    }
                }

                string messageString = message.ToString();
                if(0 == seqNum)
                    Persist(message, messageString);
                return Send(messageString);
            }
        }
    }
}
