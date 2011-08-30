using System.Collections.Generic;
using QuickFix.Fields;

namespace QuickFix
{
    public class Session
    {
        #region Private Members

        private static Dictionary<SessionID, Session> sessions_ = new Dictionary<SessionID, Session>();
        private object sync_ = new object();
        private Responder responder_ = null;
        private SessionSchedule schedule_;
        private SessionState state_;

        #endregion

        #region Properties
        
        // state
        public Log Log { get { return state_.Log; } }
        public bool IsEnabled { get { return state_.IsEnabled; } }
        public bool IsSessionTime { get { return schedule_.IsSessionTime; } }
        public bool IsLoggedOn { get { return ReceivedLogon && SentLogon; } }
        public bool SentLogon { get { return state_.SentLogon; } }
        public bool ReceivedLogon { get { return state_.ReceivedLogon; } }
        public int HeartBtInt { get { return state_.HeartBtInt; } }
        public bool CheckLatency { get; set; }
        public int MaxLatency { get; set; }
        // unsynchronized
        public bool PersistMessages { get; set; }
        public bool RefreshOnLogon { get; set; }
        public bool ResetOnLogon { get; set; }
        public bool ResetOnLogout { get; set; }
        public bool ResetOnDisconnect { get; set; }
        public bool SendRedundantResendRequests { get; set; }
        public bool ValidateLengthAndChecksum { get; set; }
        public bool CheckCompID { get; set; }
        public string SenderDefaultApplVerID { get; set; }
        public SessionID SessionID { get; set; }
        public Application Application { get; set; }
        public DataDictionaryProvider DataDictionaryProvider { get; set; }
        public DataDictionary.DataDictionary SessionDataDictionary { get; private set; }
        public DataDictionary.DataDictionary ApplicationDataDictionary { get; private set; }
        // synchronized
        public bool HasResponder { get { lock (sync_) { return null != responder_; } } }

        #endregion
 
        /// FIXME
        public Session(
            Application app, MessageStoreFactory storeFactory, SessionID sessID, DataDictionaryProvider dataDictProvider,
            SessionSchedule sessionSchedule, int heartBtInt, LogFactory logFactory)
        {
            this.Application = app;
            this.SessionID = sessID;
            this.DataDictionaryProvider = new DataDictionaryProvider(dataDictProvider);
            this.schedule_ = sessionSchedule;

            this.SessionDataDictionary = this.DataDictionaryProvider.GetSessionDataDictionary(this.SessionID.BeginString);
            if (this.SessionID.IsFIXT)
                this.ApplicationDataDictionary = this.DataDictionaryProvider.GetApplicationDataDictionary(this.SenderDefaultApplVerID);
            else
                this.ApplicationDataDictionary = this.SessionDataDictionary;

            Log log;
            if (null != logFactory)
                log = logFactory.Create(sessID);
            else
                log = new NullLog();

            state_ = new SessionState(log, heartBtInt);
            state_.MessageStore = storeFactory.Create(sessID);

            this.PersistMessages = true;
            this.ResetOnDisconnect = false;
            this.SendRedundantResendRequests = false;
            this.ValidateLengthAndChecksum = true;
            this.CheckCompID = true;

            if (!CheckSessionTime())
                Reset();

            lock (sessions_)
            {
                sessions_[this.SessionID] = this;
            }

            this.Application.OnCreate(this.SessionID);
            this.Log.OnEvent("Created session");
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
        public static bool SendToTarget(Message message, SessionID sessionID)
        {
            message.SetSessionID(sessionID);
            Session session = Session.LookupSession(sessionID);
            if(null == session)
                throw new SessionNotFound(sessionID);
            return session.Send(message);
        }

        /// <summary>
        /// Send to session indicated by header fields in message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool SendToTarget(Message message)
        {
            SessionID sessionID = message.GetSessionID(message);
            return SendToTarget(message, sessionID);
        }

        #endregion

        public bool Send(Message message)
        {
            message.Header.RemoveField(Fields.Tags.PossDupFlag);
            message.Header.RemoveField(Fields.Tags.OrigSendingTime);
            return SendRaw(message, 0);
        }

        public bool Send(string message)
        {
            lock(sync_)
            {
                if(null == responder_)
                    return false;
                this.Log.OnOutgoing(message);
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
            lock (sync_)
            {
                if (null != responder_)
                {
                    this.Log.OnEvent("Session " + this.SessionID + " disconnecting: " + reason);
                    responder_.Disconnect();
                    responder_ = null;
                }
                else
                {
                    this.Log.OnEvent("Session " + this.SessionID + " already disconnected: " + reason);
                }

                if(state_.ReceivedLogon || state_.SentLogon)
                {
                    state_.ReceivedLogon = false;
                    state_.SentLogon = false;
                    this.Application.OnLogout(this.SessionID);
                }

                state_.SentLogout = false;
                state_.ReceivedReset = false;
                state_.SentReset = false;
                state_.ClearQueue();
                state_.LogoutReason = "";
                if (this.ResetOnDisconnect)
                    state_.Reset();
                state_.SetResendRange(0, 0);
            }
        }

        public void Next()
        {
            //System.Console.WriteLine(state_.ToString());
            //this.Log.OnEvent(state_.ToString());

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

            
            if (state_.LogoutTimedOut())
                Disconnect("Timed out waiting for logout response");
            

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
            try
            {
                this.Log.OnIncoming(message);
                Next(new Message(message, this.SessionDataDictionary, this.ApplicationDataDictionary, this.ValidateLengthAndChecksum));
            }
            catch (InvalidMessage e)
            {
                this.Log.OnEvent(e.Message);
                
                try
                {
                    if (MsgType.LOGON.Equals(Message.IdentifyType(message)))
                        Disconnect("Logon message is not valid");
                }
                catch (MessageParseError)
                { }

                throw e;
            }
        }

        public void Next(Message message)
        {
            Header header = message.Header;
            string msgType = "";

            try
            {
                msgType = header.GetField(Fields.Tags.MsgType);
                string beginString = header.GetField(Fields.Tags.BeginString);

                if (!beginString.Equals(this.SessionID.BeginString))
                    throw new UnsupportedVersion();

                if (this.SessionID.IsFIXT && !Message.IsAdminMsgType(msgType))
                {
                    throw new UnsupportedVersion("'FIXT' Sessions are not implemented yet!");
                }
                else
                {
                    this.SessionDataDictionary.Validate(message, beginString, msgType);
                }

                if (MsgType.LOGON.Equals(msgType))
                    NextLogon(message);
                else if (MsgType.HEARTBEAT.Equals(msgType))
                    NextHeartbeat(message);
                else if (MsgType.TEST_REQUEST.Equals(msgType))
                    NextTestRequest(message);
                else if (MsgType.SEQUENCE_RESET.Equals(msgType))
                    NextSequenceReset(message);
                else if (MsgType.LOGOUT.Equals(msgType))
                    NextLogout(message);
                else
                {
                   if (!Verify(message))
                        return;
                   state_.IncrNextTargetMsgSeqNum();
                }
            }
            catch (TagException e)
            {
                if (null != e.InnerException)
                    this.Log.OnEvent(e.InnerException.Message);
                GenerateReject(message, e.sessionRejectReason, e.field);
            }
            catch (UnsupportedVersion)
            {
                if (MsgType.LOGOUT.Equals(msgType))
                {
                    NextLogout(message);
                }
                else
                {
                    GenerateLogout("Incorrect BeginString");
                    state_.IncrNextTargetMsgSeqNum();
                }
            }
        }

        protected void NextQueued()
        {
            System.Console.WriteLine("FIXME - Session.NextQueued not implemented!");
            this.Log.OnEvent("FIXME - Session.NextQueued not implemented!");
        }

        protected void NextLogon(Message logon)
        {
            Fields.ResetSeqNumFlag resetSeqNumFlag = new Fields.ResetSeqNumFlag(false);
            if (logon.isSetField(resetSeqNumFlag))
                logon.getField(resetSeqNumFlag);
            state_.ReceivedReset = resetSeqNumFlag.Obj;

            if (!state_.IsInitiator && this.ResetOnLogon)
                state_.Reset();
            
            if (!Verify(logon, false, true))
                return;

            if(!IsGoodTime(logon))
            {
                this.Log.OnEvent("Logon had bad sending time");
                Disconnect("bad sending time");
                return;
            }

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

            int msgSeqNum = Fields.Converters.IntConverter.Convert(logon.Header.GetField(Fields.Tags.MsgSeqNum)); /// FIXME
            if (IsTargetTooHigh(msgSeqNum) && !resetSeqNumFlag.Obj)
            {
                DoTargetTooHigh(logon, msgSeqNum);
            }
            else
            {
                state_.IncrNextTargetMsgSeqNum();
                NextQueued();
            }
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
            if (!Verify(logout, false, false))
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
            if (this.ResetOnLogout)
                state_.Reset();
            Disconnect(disconnectReason);
        }

        protected void NextHeartbeat(Message heartbeat)
        {
            if (!Verify(heartbeat))
                return;
            state_.IncrNextTargetMsgSeqNum();
            NextQueued();
        }

        protected void NextSequenceReset(Message sequenceReset)
        {
            bool isGapFill = false;
            if(sequenceReset.isSetField(Fields.Tags.GapFillFlag))
                 isGapFill = Fields.Converters.BoolConverter.Convert(sequenceReset.GetField(Fields.Tags.GapFillFlag)); /// FIXME

            if(!Verify( sequenceReset, isGapFill, isGapFill ))
                return ;

            if(sequenceReset.isSetField(Fields.Tags.NewSeqNo))
            {
                int newSeqNo = Fields.Converters.IntConverter.Convert(sequenceReset.GetField(Fields.Tags.NewSeqNo)); /// FIXME
                this.Log.OnEvent( "Received SequenceReset FROM: " + state_.GetNextTargetMsgSeqNum() + " TO: " + newSeqNo);

                if (newSeqNo > state_.GetNextTargetMsgSeqNum())
                {
                    state_.SetNextTargetMsgSeqNum(newSeqNo);
                }
                else
                {
                    if (newSeqNo < state_.GetNextTargetMsgSeqNum())
                        GenerateReject(sequenceReset, FixValues.SessionRejectReason.VALUE_IS_INCORRECT);
                }
            }
        }

        public bool Verify(Message message)
        {
            return Verify(message, true, true);
        }
        public bool Verify(Message msg, bool checkTooHigh, bool checkTooLow)
        {
            int msgSeqNum = 0;
            string msgType = ""; 

            try
            {
                msgType = msg.Header.GetField(Fields.Tags.MsgType);
                string senderCompID = msg.Header.GetField(Fields.Tags.SenderCompID);
                string targetCompID = msg.Header.GetField(Fields.Tags.TargetCompID);
                
                if (!IsCorrectCompID(senderCompID, targetCompID))
                {
                    GenerateReject(msg, FixValues.SessionRejectReason.COMPID_PROBLEM);
                    GenerateLogout();
                    return false;
                }

                if(checkTooHigh || checkTooLow)
                    msgSeqNum = Fields.Converters.IntConverter.Convert(msg.Header.GetField(Fields.Tags.MsgSeqNum)); /// FIXME

                if (checkTooHigh && IsTargetTooHigh(msgSeqNum))
                {
                    DoTargetTooHigh(msg, msgSeqNum);
                    return false;
                }
                else if (checkTooLow && IsTargetTooLow(msgSeqNum))
                {
                    DoTargetTooLow(msg, msgSeqNum);
                    return false;
                }

                if ((checkTooHigh || checkTooLow) && state_.ResendRequested())
                {
                    ResendRange range = state_.GetResendRange();
                    if (msgSeqNum >= range.EndSeqNo)
                    {
                        this.Log.OnEvent("ResendRequest for messages FROM: " + range.BeginSeqNo + " TO: " + range.EndSeqNo + " has been satisfied.");
                        state_.SetResendRange(0, 0);
                    }
                }

                if (CheckLatency && !IsGoodTime(msg))
                {
                    this.Log.OnEvent("Sending time accuracy problem");
                    GenerateReject(msg, FixValues.SessionRejectReason.SENDING_TIME_ACCURACY_PROBLEM);
                    GenerateLogout();
                    return false;
                }
            }
            catch(System.Exception e)
            {
                this.Log.OnEvent("Verify failed: " + e.Message);
                Disconnect("Verify failed: " + e.Message);
                return false;
            }

            state_.LastReceivedTimeTickCount = System.Environment.TickCount;
            state_.TestRequestCounter = 0;

            if (Message.IsAdminMsgType(msgType))
                this.Application.FromAdmin(msg, this.SessionID);
            else
                this.Application.FromApp(msg, this.SessionID);

            return true;
        }

        public void SetResponder(Responder responder)
        {
            if (!CheckSessionTime())
                Reset();

            lock (sync_)
            {
                responder_ = responder;
            }
        }

        /// FIXME
        public void Refresh()
        {
        }

        public void Reset()
        {
            GenerateLogout();
            Disconnect("Resetting...");
            state_.Reset();
        }

        protected bool CheckSessionTime()
        {
            return true;
        }

        protected bool ShouldSendReset()
        {
            return (this.SessionID.BeginString.CompareTo(FixValues.BeginString.FIX41) >= 0)
                && (this.ResetOnLogon || this.ResetOnLogout || this.ResetOnDisconnect)
                && (state_.GetNextSenderMsgSeqNum() == 1)
                && (state_.GetNextTargetMsgSeqNum() == 1);
        }

        protected bool IsCorrectCompID(string senderCompID, string targetCompID)
        {
            if (!this.CheckCompID)
                return true;
            return this.SessionID.SenderCompID.Equals(targetCompID) 
                && this.SessionID.TargetCompID.Equals(senderCompID);
        }

        /// FIXME
        protected bool IsTimeToGenerateLogon()
        {
            return true;
        }

        protected bool IsTargetTooHigh(int msgSeqNum)
        {
            return msgSeqNum > state_.GetNextTargetMsgSeqNum();
        }

        protected bool IsTargetTooLow(int msgSeqNum)
        {
            return msgSeqNum < state_.GetNextTargetMsgSeqNum();
        }

        protected void DoTargetTooHigh(Message msg, int msgSeqNum)
        {
            string beginString = msg.Header.GetField(Fields.Tags.BeginString);

            this.Log.OnEvent("MsgSeqNum too high, expecting " + state_.GetNextTargetMsgSeqNum() + " but received " + msgSeqNum);
            state_.Queue(msgSeqNum, msg);

            if(state_.ResendRequested())
            {
                ResendRange range = state_.GetResendRange();
                
                if( !this.SendRedundantResendRequests && msgSeqNum >= range.BeginSeqNo )
                {
                    this.Log.OnEvent ("Already sent ResendRequest FROM: " + range.BeginSeqNo  + " TO: " + range.EndSeqNo + ".  Not sending another.");
                    return;
                }
            }
            
            GenerateResendRequest(beginString, msgSeqNum);
        }

        protected bool DoTargetTooLow(Message msg, int msgSeqNum)
        {
            bool possDupFlag = false;
            if(msg.Header.isSetField(Fields.Tags.PossDupFlag))
                possDupFlag = Fields.Converters.BoolConverter.Convert(msg.Header.GetField(Fields.Tags.PossDupFlag));

            if (!possDupFlag)
            {
                string err = "MsgSeqNum too low, expecting " + state_.GetNextTargetMsgSeqNum() + " but received " + msgSeqNum;
                GenerateLogout(err);
                throw new QuickFIXException(err);
            }

            return DoPossDup(msg);
        }

        /// FIXME
        protected bool DoPossDup(Message msg)
        {
            var origSendingTimeFld = new StringField(Fields.Tags.OrigSendingTime);
            if(!msg.Header.isSetField(origSendingTimeFld))
            {
                GenerateReject(msg, FixValues.SessionRejectReason.REQUIRED_TAG_MISSING, Fields.Tags.OrigSendingTime);
                return false;
            }
            msg.Header.getField(origSendingTimeFld);
            var origSendingTime = Fields.Converters.DateTimeConverter.Convert(origSendingTimeFld.getValue());

            var sendingTimeFld = new StringField(Fields.Tags.SendingTime);
            msg.Header.getField(sendingTimeFld);
            var sendingTime = Fields.Converters.DateTimeConverter.Convert(sendingTimeFld.getValue());

            System.TimeSpan tmSpan = origSendingTime - sendingTime;
            if (tmSpan.TotalSeconds > 0)
            {
                GenerateReject(msg, FixValues.SessionRejectReason.SENDING_TIME_ACCURACY_PROBLEM);
                GenerateLogout();
                return false;
            }
            return true;
        }

        protected bool GenerateResendRequest(string beginString, int msgSeqNum)
        {
            Message resendRequest = new Message();

            Fields.BeginSeqNo beginSeqNo = new Fields.BeginSeqNo(state_.GetNextTargetMsgSeqNum());
            Fields.EndSeqNo endSeqNo;
            if (beginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
                endSeqNo =  new Fields.EndSeqNo(0);
            else if (beginString.CompareTo(FixValues.BeginString.FIX41) <= 0)
                endSeqNo =  new Fields.EndSeqNo(999999);
            else
                endSeqNo =  new Fields.EndSeqNo(msgSeqNum - 1);
            
            resendRequest.Header.setField(new Fields.MsgType("2"));
            resendRequest.setField(beginSeqNo);
            resendRequest.setField(endSeqNo);
            InitializeHeader(resendRequest);
            if (SendRaw(resendRequest, 0))
            {
                this.Log.OnEvent("Sent ResendRequest FROM: " + beginSeqNo.Obj + " TO: " + endSeqNo.Obj);
                state_.SetResendRange(beginSeqNo.Obj, msgSeqNum - 1);
                return true;
            }
            else
            {
                this.Log.OnEvent("Error sending ResendRequest (" + beginSeqNo.Obj + " ," + endSeqNo.Obj + ")");
                return false;
            }
        }

        /// <summary>
        /// FIXME
        /// </summary>
        /// <returns></returns>
        protected bool GenerateLogon()
        {
            Message logon = new Message();
            logon.Header.setField(new Fields.MsgType(MsgType.LOGON));
            logon.setField(new Fields.EncryptMethod(0));
            logon.setField(new Fields.HeartBtInt(state_.HeartBtInt));

            if( this.SessionID.IsFIXT)
                logon.setField( new Fields.DefaultApplVerID("FIXME"));
            if(this.RefreshOnLogon)
                Refresh();
            if(this.ResetOnLogon)
                state_.Reset();
            if(ShouldSendReset())
                logon.setField(new Fields.ResetSeqNumFlag(true));

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
            logon.Header.setField(new Fields.MsgType(MsgType.LOGON));
            logon.setField(new Fields.HeartBtInt(heartBtInt));
            InitializeHeader(logon);
            state_.SentLogon = SendRaw(logon, 0);
            return state_.SentLogon;
        }

        public bool GenerateTestRequest(string id)
        {
            Message testRequest = new Message();
            testRequest.Header.setField(new Fields.MsgType(MsgType.TEST_REQUEST));
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
            logout.Header.setField(new Fields.MsgType(MsgType.LOGOUT));
            InitializeHeader(logout);
            if (text.Length > 0)
                logout.setField(new Fields.Text(text));
            state_.SentLogout = SendRaw(logout, 0);
            return state_.SentLogout;
        }

        public bool GenerateHeartbeat()
        {
            Message heartbeat = new Message();
            heartbeat.Header.setField(new Fields.MsgType(MsgType.HEARTBEAT));
            InitializeHeader(heartbeat);
            return SendRaw(heartbeat, 0);
        }

        public bool GenerateHeartbeat(Message testRequest)
        {
            Message heartbeat = new Message();
            heartbeat.Header.setField(new Fields.MsgType(MsgType.HEARTBEAT));
            InitializeHeader(heartbeat);
            try
            {
                heartbeat.setField(new Fields.TestReqID(testRequest.GetField(Fields.Tags.TestReqID)));
            }
            catch (FieldNotFoundException)
            { }
            return SendRaw(heartbeat, 0);
        }

        public bool GenerateReject(Message message, FixValues.SessionRejectReason reason)
        {
            return GenerateReject(message, reason, 0);
        }
        public bool GenerateReject(Message message, FixValues.SessionRejectReason reason, int field)
        {
            string beginString = this.SessionID.BeginString;

            Message reject = new Message();
            reject.Header.setField(new Fields.MsgType(MsgType.REJECT));
            reject.ReverseRoute(message.Header);
            InitializeHeader(reject);

            string msgType;
            if (message.Header.isSetField(Fields.Tags.MsgType))
                msgType = message.Header.GetField(Fields.Tags.MsgType);
            else
                msgType = "";

            int msgSeqNum = 0;
            if (message.Header.isSetField(Fields.Tags.MsgSeqNum))
            {
                try
                {
                    msgSeqNum = Fields.Converters.IntConverter.Convert(message.Header.GetField(Fields.Tags.MsgSeqNum)); /// FIXME
                    reject.setField(new Fields.RefSeqNum(msgSeqNum));
                }
                catch (System.Exception)
                { }
            }

            if (beginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
            {
                if (msgType.Length > 0)
                    reject.setField(new Fields.RefMsgType(msgType));
                if ((FixValues.BeginString.FIX42.Equals(beginString) && reason.Value <= FixValues.SessionRejectReason.INVALID_MSGTYPE.Value) || (beginString.CompareTo(FixValues.BeginString.FIX42) > 0))
                {
                    reject.setField(new Fields.SessionRejectReason(reason.Value));
                }
            }
            if (!MsgType.LOGON.Equals(msgType)
              && !MsgType.SEQUENCE_RESET.Equals(msgType)
              && (msgSeqNum == state_.GetNextTargetMsgSeqNum()))
            {
                state_.IncrNextTargetMsgSeqNum();
            }

            if ((0 != field) || FixValues.SessionRejectReason.INVALID_TAG_NUMBER.Equals(reason))
            {
                PopulateSessionRejectReason(reject, field, reason.Description);
                this.Log.OnEvent("Message " + msgSeqNum + " Rejected: " + reason.Description + " (Field=" + field + ")");
            }
            else
            {
                PopulateRejectReason(reject, reason.Description);
                this.Log.OnEvent("Message " + msgSeqNum + " Rejected: " + reason.Value);
            }

            if (!state_.ReceivedLogon)
                throw new QuickFIXException("Tried to send a reject while not logged on");

            return SendRaw(reject, 0);
        }

        protected void PopulateSessionRejectReason(Message reject, int field, string text)
        {
            if (this.SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
            {
                reject.setField(new Fields.RefTagID(field));
                reject.setField(new Fields.Text(text));
            }
            else
            {
                reject.setField(new Fields.Text(text + " (" + field + ")"));
            }
        }

        protected void PopulateRejectReason(Message reject, string text)
        {
            reject.setField(new Fields.Text(text));
        }

        /// <summary>
        /// FIXME don't do so much operator new here
        /// </summary>
        /// <param name="m"></param>
        protected void InitializeHeader(Message m, int msgSeqNum)
        {
            state_.LastSentTimeTickCount = System.Environment.TickCount;
            m.Header.setField(new Fields.BeginString(this.SessionID.BeginString));
            m.Header.setField(new Fields.SenderCompID(this.SessionID.SenderCompID));
            m.Header.setField(new Fields.TargetCompID(this.SessionID.TargetCompID));
            
            if(msgSeqNum > 0)
                m.Header.setField(new Fields.MsgSeqNum(msgSeqNum));
            else
                m.Header.setField(new Fields.MsgSeqNum(state_.GetNextSenderMsgSeqNum()));

            InsertSendingTime(m.Header);    
        }
        protected void InitializeHeader(Message m)
        {
            InitializeHeader(m, 0);
        }

        protected void InsertSendingTime(FieldMap header)
        {
            header.setField(new Fields.SendingTime(System.DateTime.UtcNow));
        }

        protected void Persist(Message message, string messageString)
        {
            if (this.PersistMessages)
            {
                int msgSeqNum = Fields.Converters.IntConverter.Convert(message.Header.GetField(Fields.Tags.MsgSeqNum)); /// FIXME
                state_.Set(msgSeqNum, messageString);
            }
            state_.IncrNextSenderMsgSeqNum();
        }

        protected bool IsGoodTime(Message msg)
        {
            var fld = new StringField(Fields.Tags.SendingTime);
            msg.Header.getField(fld);
            System.DateTime sendingTime = Fields.Converters.DateTimeConverter.Convert(fld.getValue());
            System.TimeSpan tmSpan = System.DateTime.UtcNow - sendingTime;
            if (System.Math.Abs(tmSpan.TotalSeconds) > MaxLatency)
            {
                return false;
            }
            return true;
        }

        protected bool SendRaw(Message message, int seqNum)
        {
            lock (sync_)
            {
                string msgType = message.Header.GetField(Fields.Tags.MsgType);

                InitializeHeader(message, seqNum);

                if(Message.IsAdminMsgType(msgType))
                {
                    /// FIXME this.Application.ToAdmin(message, this.SessionID);

                    if (MsgType.LOGON.Equals(msgType) && !state_.ReceivedReset)
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
