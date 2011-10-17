﻿using System.Collections.Generic;
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
        private IMessageFactory msgFactory_;
        private static readonly HashSet<string> AdminMsgTypes = new HashSet<string>() { "0", "A", "1", "2", "3", "4", "5" };

        #endregion

        #region Properties

        // state
        public Log Log { get { return state_.Log; } }
        public bool IsEnabled { get { return state_.IsEnabled; } }
        public bool IsSessionTime { get { return schedule_.IsSessionTime(System.DateTime.UtcNow); } }
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
        public ApplVerID targetDefaultApplVerID { get; set;}
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
            SessionSchedule sessionSchedule, int heartBtInt, LogFactory logFactory, IMessageFactory msgFactory, string senderDefaultApplVerID)
        {
            this.Application = app;
            this.SessionID = sessID;
            this.DataDictionaryProvider = new DataDictionaryProvider(dataDictProvider);
            this.schedule_ = sessionSchedule;
            this.msgFactory_ = msgFactory;
            
            this.SenderDefaultApplVerID = senderDefaultApplVerID;

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

            if (!IsSessionTime)
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
            if (null == session)
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
            lock (sync_)
            {
                if (null == responder_)
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

                if (state_.ReceivedLogon || state_.SentLogon)
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
            if (!HasResponder)
                return;

            if (!IsSessionTime) 
            {
                Reset();
                return;
            }

            if (!IsEnabled)
            {
                if (!IsLoggedOn)
                    return;

                if (!state_.SentLogon) 
                {
                    this.Log.OnEvent("Initiated logout request");
                    GenerateLogout(state_.LogoutReason);
                }
            }

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

        public void Next(string msgStr)
        {
            try
            {
                this.Log.OnIncoming(msgStr);

                MsgType msgType = Message.IdentifyType(msgStr);
                string beginString = Message.ExtractBeginString(msgStr);

                Message message = msgFactory_.Create(beginString, msgType.Obj);
                message.FromString(
                    msgStr,
                    this.ValidateLengthAndChecksum,
                    this.SessionDataDictionary,
                    this.ApplicationDataDictionary);

                Next(message);
            }
            catch (InvalidMessage e)
            {
                this.Log.OnEvent(e.Message);

                try
                {
                    if (MsgType.LOGON.Equals(Message.IdentifyType(msgStr)))
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


                if (MsgType.LOGON.Equals(msgType))
                {
                    if (this.SessionID.IsFIXT)
                    {
                        targetDefaultApplVerID = new ApplVerID(message.GetString(Fields.Tags.DefaultApplVerID));
                    }
                    else
                    {
                        targetDefaultApplVerID = Message.GetApplVerID(beginString);
                    }
                }

                if (this.SessionID.IsFIXT && !Message.IsAdminMsgType(msgType))
                {

                    DataDictionary.DataDictionary.Validate(message, SessionDataDictionary, ApplicationDataDictionary, beginString, msgType);
                }
                else
                {
                    this.SessionDataDictionary.Validate(message, beginString, msgType);
                }


                //End Refactor
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
                else if (MsgType.RESEND_REQUEST.Equals(msgType))
                    NextResendRequest(message);
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
            catch (UnsupportedMessageType e)
            {
                this.Log.OnEvent("Unsupported message type: " + e.Message);
                GenerateBusinessMessageReject(message, Fields.BusinessRejectReason.UNKNOWN_MESSAGE_TYPE, 0);
            }
            catch (FieldNotFoundException e)
            {
                this.Log.OnEvent("Rejecting invalid message, field not found: " + e.Message);
                if ((SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0) && (message.IsApp()))
                {
                    GenerateBusinessMessageReject(message, Fields.BusinessRejectReason.CONDITIONALLY_REQUIRED_FIELD_MISSING, e.Field);
                }
                else
                {
                    if (msgType.Equals(Fields.MsgType.LOGON))
                    {
                        this.Log.OnEvent("Required field missing from logon");
                        Disconnect("Required field missing from logon");
                    }
                    else
                        GenerateReject(message, new QuickFix.FixValues.SessionRejectReason(SessionRejectReason.REQUIRED_TAG_MISSING, "Required Tag Missing"), e.Field);
                }
            }
            catch (RejectLogon e)
            {
                GenerateLogout(e.Message);
                Disconnect(e.Message);
            }
                    
	    NextQueued();
        }

        protected void NextLogon(Message logon)
        {
            Fields.ResetSeqNumFlag resetSeqNumFlag = new Fields.ResetSeqNumFlag(false);
            if (logon.IsSetField(resetSeqNumFlag))
                logon.GetField(resetSeqNumFlag);
            state_.ReceivedReset = resetSeqNumFlag.Obj;

            if (!state_.IsInitiator && this.ResetOnLogon)
                state_.Reset();

            if (!Verify(logon, false, true))
                return;

            if (!IsGoodTime(logon))
            {
                this.Log.OnEvent("Logon had bad sending time");
                Disconnect("bad sending time");
                return;
            }

            state_.ReceivedLogon = true;
            this.Log.OnEvent("Received logon");
            if (!state_.IsInitiator)
            {
                int heartBtInt = logon.GetInt(Fields.Tags.HeartBtInt);
                state_.HeartBtInt = heartBtInt;
                GenerateLogon(heartBtInt);
                this.Log.OnEvent("Responding to logon request");
            }

            state_.SentReset = false;
            state_.ReceivedReset = false;

            int msgSeqNum = logon.Header.GetInt(Fields.Tags.MsgSeqNum);
            if (IsTargetTooHigh(msgSeqNum) && !resetSeqNumFlag.Obj)
            {
                DoTargetTooHigh(logon, msgSeqNum);
            }
            else
            {
                state_.IncrNextTargetMsgSeqNum();
                NextQueued();
            }

            if (this.IsLoggedOn)
                this.Application.OnLogon(this.SessionID);
        }

        protected void NextTestRequest(Message testRequest)
        {
            if (!Verify(testRequest))
                return;
            GenerateHeartbeat(testRequest);
            state_.IncrNextTargetMsgSeqNum();
            NextQueued();
        }

        protected void NextResendRequest(Message resendReq)
        {
            try
            {
                int begSeqNo = resendReq.GetInt(Fields.Tags.BeginSeqNo);
                int endSeqNo = resendReq.GetInt(Fields.Tags.EndSeqNo);
                this.Log.OnEvent("Got resend request from " + begSeqNo + " to " + endSeqNo);

                if ((endSeqNo == 999999) || (endSeqNo == 0))
                {
                    endSeqNo = state_.GetNextSenderMsgSeqNum() - 1;
                }

                if (!PersistMessages)
                {
                    endSeqNo++;
                    int next = state_.GetNextSenderMsgSeqNum();
                    if (endSeqNo > next)
                        endSeqNo = next;
                    GenerateSequenceReset(begSeqNo, endSeqNo);
                    return;
                }

                List<string> messages = new List<string>();
                state_.Get(begSeqNo, endSeqNo, messages);
                int current = begSeqNo;
                int begin = 0;
                int msgSeqNum = 0;
                foreach (string msgStr in messages)
                {
                    Message msg = new Message(msgStr);
                    msgSeqNum = msg.Header.GetInt(Tags.MsgSeqNum);

                    if ((current != msgSeqNum) && begin == 0)
                    {
                        begin = current;
                    }

                    if (IsAdminMessage(msg))
                    {
                        if (begin == 0)
                        {
                            begin = msgSeqNum;
                        }
                    }
                    else
                    {
                        
                        initializeResendFields(msg);
                        if (begin != 0)
                        {
                            GenerateSequenceReset(begin, msgSeqNum);
                        }
                        Send(msg.ToString());
                        begin = 0;
                    }
                    current = msgSeqNum + 1;
                }

                if (begin != 0)
                {
                    GenerateSequenceReset(begin, msgSeqNum + 1);
                }

                if (endSeqNo > msgSeqNum) {
                    endSeqNo = endSeqNo + 1;
                    int next = state_.GetNextSenderMsgSeqNum();
                    if (endSeqNo > next) {
                        endSeqNo = next;
                    }
                    GenerateSequenceReset(begSeqNo, endSeqNo);
                }

                msgSeqNum = resendReq.Header.GetInt(Tags.MsgSeqNum);
                if (!IsTargetTooHigh(msgSeqNum) && !IsTargetTooLow(msgSeqNum))
                {
                    state_.IncrNextTargetMsgSeqNum();
                }

            }
            catch (System.Exception e)
            {
                this.Log.OnEvent("ERROR during resend request " + e.Message);
            }
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
            if (sequenceReset.IsSetField(Fields.Tags.GapFillFlag))
                isGapFill = sequenceReset.GetBoolean(Fields.Tags.GapFillFlag);

            if (!Verify(sequenceReset, isGapFill, isGapFill))
                return;

            if (sequenceReset.IsSetField(Fields.Tags.NewSeqNo))
            {
                int newSeqNo = sequenceReset.GetInt(Fields.Tags.NewSeqNo);
                this.Log.OnEvent("Received SequenceReset FROM: " + state_.GetNextTargetMsgSeqNum() + " TO: " + newSeqNo);

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

                if (checkTooHigh || checkTooLow)
                    msgSeqNum = msg.Header.GetInt(Fields.Tags.MsgSeqNum);

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
            catch (System.Exception e)
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
            if (!IsSessionTime)
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

        private void initializeResendFields(Message message)
        {
            FieldMap header = message.Header;
            System.DateTime sendingTime = header.GetDateTime(Fields.Tags.SendingTime);
            InsertOrigSendingTime(header, sendingTime);
            header.SetField(new Fields.PossDupFlag(true));
            InsertSendingTime(header);
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

            if (state_.ResendRequested())
            {
                ResendRange range = state_.GetResendRange();

                if (!this.SendRedundantResendRequests && msgSeqNum >= range.BeginSeqNo)
                {
                    this.Log.OnEvent("Already sent ResendRequest FROM: " + range.BeginSeqNo + " TO: " + range.EndSeqNo + ".  Not sending another.");
                    return;
                }
            }

            GenerateResendRequest(beginString, msgSeqNum);
        }

        protected bool DoTargetTooLow(Message msg, int msgSeqNum)
        {
            bool possDupFlag = false;
            if (msg.Header.IsSetField(Fields.Tags.PossDupFlag))
                possDupFlag = msg.Header.GetBoolean(Fields.Tags.PossDupFlag);

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
            if (!msg.Header.IsSetField(Fields.Tags.OrigSendingTime))
            {
                GenerateReject(msg, FixValues.SessionRejectReason.REQUIRED_TAG_MISSING, Fields.Tags.OrigSendingTime);
                return false;
            }
            var origSendingTime = msg.Header.GetDateTime(Fields.Tags.OrigSendingTime);
            var sendingTime = msg.Header.GetDateTime(Fields.Tags.SendingTime);

            System.TimeSpan tmSpan = origSendingTime - sendingTime;
            if (tmSpan.TotalSeconds > 0)
            {
                GenerateReject(msg, FixValues.SessionRejectReason.SENDING_TIME_ACCURACY_PROBLEM);
                GenerateLogout();
                return false;
            }
            return true;
        }

        protected void GenerateBusinessMessageReject(Message message, int err, int field)
        {
            string msgType = message.Header.GetString(Tags.MsgType);
            int msgSeqNum = message.Header.GetInt(Tags.MsgSeqNum);            
            string reason = FixValues.BusinessRejectReason.RejText[err];
            Message reject;
            if (this.SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
            {
                reject = msgFactory_.Create(this.SessionID.BeginString, MsgType.BUSINESS_MESSAGE_REJECT);
                reject.SetField(new RefMsgType(msgType));
                reject.SetField(new BusinessRejectReason(err));
            }
            else
            {
                reject = msgFactory_.Create(this.SessionID.BeginString, MsgType.REJECT);
                char[] reasonArray = reason.ToLower().ToCharArray();
                reasonArray[0] = char.ToUpper(reasonArray[0]);
                reason = new string(reasonArray);
            }
            InitializeHeader(reject);
            reject.SetField(new RefSeqNum(msgSeqNum));
            state_.IncrNextTargetMsgSeqNum();


            reject.SetField(new Text(reason));
            Log.OnEvent("Reject sent for Message: " + msgSeqNum + " Reason:" + reason);
            SendRaw(reject, 0);
        }

        protected bool GenerateResendRequest(string beginString, int msgSeqNum)
        {
            Message resendRequest = msgFactory_.Create(beginString, MsgType.RESEND_REQUEST);

            Fields.BeginSeqNo beginSeqNo = new Fields.BeginSeqNo(state_.GetNextTargetMsgSeqNum());
            Fields.EndSeqNo endSeqNo;
            if (beginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
                endSeqNo = new Fields.EndSeqNo(0);
            else if (beginString.CompareTo(FixValues.BeginString.FIX41) <= 0)
                endSeqNo = new Fields.EndSeqNo(999999);
            else
                endSeqNo = new Fields.EndSeqNo(msgSeqNum - 1);

            resendRequest.SetField(beginSeqNo);
            resendRequest.SetField(endSeqNo);
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
            Message logon = msgFactory_.Create(this.SessionID.BeginString, Fields.MsgType.LOGON);
            logon.SetField(new Fields.EncryptMethod(0));
            logon.SetField(new Fields.HeartBtInt(state_.HeartBtInt));

            if (this.SessionID.IsFIXT)
                logon.SetField(new Fields.DefaultApplVerID(this.SenderDefaultApplVerID));
            if (this.RefreshOnLogon)
                Refresh();
            if (this.ResetOnLogon)
                state_.Reset();
            if (ShouldSendReset())
                logon.SetField(new Fields.ResetSeqNumFlag(true));

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
            Message logon = msgFactory_.Create(this.SessionID.BeginString, Fields.MsgType.LOGON);
            logon.SetField(new Fields.EncryptMethod(0));
            if (this.SessionID.IsFIXT)
                logon.SetField(new Fields.DefaultApplVerID(this.SenderDefaultApplVerID));
            if (state_.ReceivedReset)
                logon.SetField(new Fields.ResetSeqNumFlag(true));
            logon.SetField(new Fields.HeartBtInt(heartBtInt));
            InitializeHeader(logon);
            state_.SentLogon = SendRaw(logon, 0);
            return state_.SentLogon;
        }

        public bool GenerateTestRequest(string id)
        {
            Message testRequest = msgFactory_.Create(this.SessionID.BeginString, Fields.MsgType.TEST_REQUEST);
            InitializeHeader(testRequest);
            testRequest.SetField(new Fields.TestReqID(id));
            return SendRaw(testRequest, 0);
        }

        public bool GenerateLogout()
        {
            return GenerateLogout("");
        }

        public bool GenerateLogout(string text)
        {
            Message logout = msgFactory_.Create(this.SessionID.BeginString, Fields.MsgType.LOGOUT);
            InitializeHeader(logout);
            if (text.Length > 0)
                logout.SetField(new Fields.Text(text));
            state_.SentLogout = SendRaw(logout, 0);
            return state_.SentLogout;
        }

        public bool GenerateHeartbeat()
        {
            Message heartbeat = msgFactory_.Create(this.SessionID.BeginString, Fields.MsgType.HEARTBEAT);
            InitializeHeader(heartbeat);
            return SendRaw(heartbeat, 0);
        }

        public bool GenerateHeartbeat(Message testRequest)
        {
            Message heartbeat = msgFactory_.Create(this.SessionID.BeginString, Fields.MsgType.HEARTBEAT);
            InitializeHeader(heartbeat);
            try
            {
                heartbeat.SetField(new Fields.TestReqID(testRequest.GetField(Fields.Tags.TestReqID)));
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

            Message reject = msgFactory_.Create(beginString, Fields.MsgType.REJECT);
            reject.ReverseRoute(message.Header);
            InitializeHeader(reject);

            string msgType;
            if (message.Header.IsSetField(Fields.Tags.MsgType))
                msgType = message.Header.GetField(Fields.Tags.MsgType);
            else
                msgType = "";

            int msgSeqNum = 0;
            if (message.Header.IsSetField(Fields.Tags.MsgSeqNum))
            {
                try
                {
                    msgSeqNum = message.Header.GetInt(Fields.Tags.MsgSeqNum);
                    reject.SetField(new Fields.RefSeqNum(msgSeqNum));
                }
                catch (System.Exception)
                { }
            }

            if (beginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
            {
                if (msgType.Length > 0)
                    reject.SetField(new Fields.RefMsgType(msgType));
                if ((FixValues.BeginString.FIX42.Equals(beginString) && reason.Value <= FixValues.SessionRejectReason.INVALID_MSGTYPE.Value) || (beginString.CompareTo(FixValues.BeginString.FIX42) > 0))
                {
                    reject.SetField(new Fields.SessionRejectReason(reason.Value));
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
                if (FixValues.SessionRejectReason.INVALID_MSGTYPE.Equals(reason))
                {
                    if (this.SessionID.BeginString.CompareTo(FixValues.BeginString.FIX43) >= 0)
                        PopulateRejectReason(reject, reason.Description);
                    else
                        PopulateSessionRejectReason(reject, field, reason.Description, false);
                }
                else
                    PopulateSessionRejectReason(reject, field, reason.Description, true);
                
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

        protected void PopulateSessionRejectReason(Message reject, int field, string text, bool includeFieldInfo)
        {
            if (this.SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
            {
                reject.SetField(new Fields.RefTagID(field));
                reject.SetField(new Fields.Text(text));
            }
            else
            {
                if(includeFieldInfo)
                    reject.SetField(new Fields.Text(text + " (" + field + ")"));
                else
                    reject.SetField(new Fields.Text(text));
            }
        }

        protected void PopulateRejectReason(Message reject, string text)
        {
            reject.SetField(new Fields.Text(text));
        }

        /// <summary>
        /// FIXME don't do so much operator new here
        /// </summary>
        /// <param name="m"></param>
        protected void InitializeHeader(Message m, int msgSeqNum)
        {
            state_.LastSentTimeTickCount = System.Environment.TickCount;
            m.Header.SetField(new Fields.BeginString(this.SessionID.BeginString));
            m.Header.SetField(new Fields.SenderCompID(this.SessionID.SenderCompID));
            m.Header.SetField(new Fields.TargetCompID(this.SessionID.TargetCompID));

            if (msgSeqNum > 0)
                m.Header.SetField(new Fields.MsgSeqNum(msgSeqNum));
            else
                m.Header.SetField(new Fields.MsgSeqNum(state_.GetNextSenderMsgSeqNum()));

            InsertSendingTime(m.Header);
        }
        protected void InitializeHeader(Message m)
        {
            InitializeHeader(m, 0);
        }

        protected void InsertSendingTime(FieldMap header)
        {
            if (this.SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
                header.SetField(new Fields.SendingTime(System.DateTime.UtcNow));
            else
                header.SetField(new Fields.SendingTime(System.DateTime.UtcNow, false));
        }

        protected void Persist(Message message, string messageString)
        {
            if (this.PersistMessages)
            {
                int msgSeqNum = message.Header.GetInt(Fields.Tags.MsgSeqNum);
                state_.Set(msgSeqNum, messageString);
            }
            state_.IncrNextSenderMsgSeqNum();
        }

        protected bool IsGoodTime(Message msg)
        {
            var sendingTime = msg.Header.GetDateTime(Fields.Tags.SendingTime);
            System.TimeSpan tmSpan = System.DateTime.UtcNow - sendingTime;
            if (System.Math.Abs(tmSpan.TotalSeconds) > MaxLatency)
            {
                return false;
            }
            return true;
        }

        private void GenerateSequenceReset(int beginSeqNo, int endSeqNo)  
        {
            string beginString = this.SessionID.BeginString;
            Message sequenceReset = msgFactory_.Create(beginString, Fields.MsgType.SEQUENCE_RESET);
            InitializeHeader(sequenceReset);
            int newSeqNo = endSeqNo;
            sequenceReset.Header.SetField(new PossDupFlag(true));
            InsertOrigSendingTime(sequenceReset.Header, sequenceReset.Header.GetDateTime(Tags.SendingTime));
            
            sequenceReset.Header.SetField(new MsgSeqNum(beginSeqNo));
            sequenceReset.SetField(new NewSeqNo(newSeqNo));
            sequenceReset.SetField(new GapFillFlag(true));
            SendRaw(sequenceReset, beginSeqNo);
            this.Log.OnEvent("Sent SequenceReset TO: " + newSeqNo);
        }

        protected void InsertOrigSendingTime(FieldMap header, System.DateTime sendingTime)
        {
            if (this.SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
                header.SetField(new OrigSendingTime(sendingTime));
            else
                header.SetField(new OrigSendingTime(sendingTime, false));
        }
        protected void NextQueued()
        {
            while (NextQueued(state_.MessageStore.GetNextTargetMsgSeqNum())) {
                // continue
            }
        }

        protected bool NextQueued(int num) 
        {
            Message msg = state_.Dequeue(num);
    
            if (msg != null) {
                Log.OnEvent("Processing queued message: " + num);
    
                string msgType = msg.Header.GetString(Tags.MsgType);
                if (msgType.Equals(MsgType.LOGON) || msgType.Equals(MsgType.RESEND_REQUEST)) {
                    state_.IncrNextTargetMsgSeqNum();
                } else {
                    Next(msg.ToString());
                }
                return true;
            }
            return false;
        }
	


        private bool IsAdminMessage(Message msg)
        {
            var msgType = msg.Header.GetString(Fields.Tags.MsgType);
            return AdminMsgTypes.Contains(msgType);
        }

        protected bool SendRaw(Message message, int seqNum)
        {
            lock (sync_)
            {
                string msgType = message.Header.GetField(Fields.Tags.MsgType);

                InitializeHeader(message, seqNum);

                if (Message.IsAdminMsgType(msgType))
                {
                    this.Application.ToAdmin(message, this.SessionID);

                    if (MsgType.LOGON.Equals(msgType) && !state_.ReceivedReset)
                    {
                        Fields.ResetSeqNumFlag resetSeqNumFlag = new QuickFix.Fields.ResetSeqNumFlag(false);
                        if (message.IsSetField(resetSeqNumFlag))
                            message.GetField(resetSeqNumFlag);
                        if (resetSeqNumFlag.getValue())
                        {
                            state_.Reset();
                            message.Header.SetField(new Fields.MsgSeqNum(state_.GetNextSenderMsgSeqNum()));
                        }
                        state_.SentReset = resetSeqNumFlag.Obj;
                    }
                }
                else
                {
                    this.Application.ToApp(message, this.SessionID);
                }

                string messageString = message.ToString();
                if (0 == seqNum)
                    Persist(message, messageString);
                return Send(messageString);
            }
        }
    }
}
