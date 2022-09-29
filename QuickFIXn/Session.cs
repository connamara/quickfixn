using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using QuickFix.Fields;
using QuickFix.Fields.Converters;

namespace QuickFix
{
    /// <summary>
    /// The Session is the primary FIX abstraction for message communication. 
    /// It performs sequencing and error recovery and represents a communication
    /// channel to a counterparty. Sessions are independent of specific communication
    /// layer connections. A Session is defined as starting with message sequence number
    /// of 1 and ending when the session is reset. The Session could span many sequential
    /// connections (it cannot operate on multiple connections simultaneously).
    /// </summary>
    public class Session : IDisposable
    {
        #region Private Members

        private static Dictionary<SessionID, Session> _sessions = new Dictionary<SessionID, Session>();
        private object _sync = new object();
        private IResponder _responder = null;
        private SessionSchedule _schedule;
        private SessionState _state;
        private IMessageFactory _msgFactory;
        private bool _appDoesEarlyIntercept;
        private static readonly HashSet<string> AdminMsgTypes = new HashSet<string>() { "0", "A", "1", "2", "3", "4", "5" };

        #endregion

        #region Properties

        // state
        public IMessageStore MessageStore { get { return _state.MessageStore; } }

        [Obsolete]
        public ILog Log => _state.Log;

        public ILogger Logger => _state.Logger;
        public bool IsInitiator { get { return _state.IsInitiator; } }
        public bool IsAcceptor { get { return !_state.IsInitiator; } }
        public bool IsEnabled { get { return _state.IsEnabled; } }
        public bool IsSessionTime { get { return _schedule.IsSessionTime(System.DateTime.UtcNow); } }
        public bool IsLoggedOn { get { return ReceivedLogon && SentLogon; } }
        public bool SentLogon { get { return _state.SentLogon; } }
        public bool ReceivedLogon { get { return _state.ReceivedLogon; } }
        public bool IsNewSession
        {
            get
            {
                DateTime? creationTime = _state.CreationTime;
                return creationTime.HasValue == false
                    || _schedule.IsNewSession(creationTime.Value, DateTime.UtcNow);
            }
        }


        /// <summary>
        /// Session setting for heartbeat interval (in seconds)
        /// </summary>
        public int HeartBtInt { get { return _state.HeartBtInt; } }

        /// <summary>
        /// Session setting for enabling message latency checks
        /// </summary>
        public bool CheckLatency { get; set; }

        /// <summary>
        /// Session setting for maximum message latency (in seconds)
        /// </summary>
        public int MaxLatency { get; set; }

        /// <summary>
        /// Send a logout if counterparty times out and does not heartbeat
        /// in response to a TestRequeset. Defaults to false
        /// </summary>
        public bool SendLogoutBeforeTimeoutDisconnect { get; set; }

        /// <summary>
        /// Gets or sets the next expected outgoing sequence number
        /// </summary>
        public int NextSenderMsgSeqNum
        {
            get
            {
                return _state.GetNextSenderMsgSeqNum();
            }
            set
            {
                _state.SetNextSenderMsgSeqNum(value);
            }
        }

        /// <summary>
        /// Gets or sets the next expected incoming sequence number
        /// </summary>
        public int NextTargetMsgSeqNum
        {
            get
            {
                return _state.GetNextTargetMsgSeqNum();
            }
            set
            {
                _state.SetNextTargetMsgSeqNum(value);
            }
        }

        /// <summary>
        /// Logon timeout in seconds
        /// </summary>
        public int LogonTimeout
        {
            get { return _state.LogonTimeout; }
            set { _state.LogonTimeout = value; }
        }

        /// <summary>
        /// Logout timeout in seconds
        /// </summary>
        public int LogoutTimeout
        {
            get { return _state.LogoutTimeout; }
            set { _state.LogoutTimeout = value; }
        }

        // unsynchronized properties
        /// <summary>
        /// Whether to persist messages or not. Setting to false forces quickfix 
        /// to always send GapFills instead of resending messages.
        /// </summary>
        public bool PersistMessages { get; set; }

        /// <summary>
        /// Determines if session state should be restored from persistance
        /// layer when logging on. Useful for creating hot failover sessions.
        /// </summary>
        public bool RefreshOnLogon { get; set; }

        /// <summary>
        /// Reset sequence numbers on logon request
        /// </summary>
        public bool ResetOnLogon { get; set; }

        /// <summary>
        /// Reset sequence numbers to 1 after a normal logout
        /// </summary>
        public bool ResetOnLogout { get; set; }

        /// <summary>
        /// Reset sequence numbers to 1 after abnormal termination
        /// </summary>
        public bool ResetOnDisconnect { get; set; }

        /// <summary>
        /// Whether to send redundant resend requests
        /// </summary>
        public bool SendRedundantResendRequests { get; set; }

        /// <summary>
        /// Whether to resend session level rejects (msg type '3') when servicing a resend request
        /// </summary>
        public bool ResendSessionLevelRejects { get; set; }

        /// <summary>
        /// Whether to validate length and checksum of messages
        /// </summary>
        public bool ValidateLengthAndChecksum { get; set; }

        /// <summary>
        /// Validates Comp IDs for each message
        /// </summary>
        public bool CheckCompID { get; set; }

        /// <summary>
        /// Determines if milliseconds should be added to timestamps.
        /// Only avilable on FIX4.2. or greater
        /// </summary>
        public bool MillisecondsInTimeStamp
        {
            get
            {
                return TimeStampPrecision == TimeStampPrecision.Millisecond;
            }
            set
            {
                TimeStampPrecision = value ? TimeStampPrecision.Millisecond : TimeStampPrecision.Second;
            }
        }

        /// <summary>
        /// Gets or sets the time stamp precision.
        /// </summary>
        /// <value>
        /// The time stamp precision.
        /// </value>
        public TimeStampPrecision TimeStampPrecision
        {
            get;
            set;
        }

        /// <summary>
        /// Adds the last message sequence number processed in the header (tag 369)
        /// </summary>
        public bool EnableLastMsgSeqNumProcessed { get; set; }

        /// <summary>
        /// Ignores resend requests marked poss dup
        /// </summary>
        public bool IgnorePossDupResendRequests { get; set; }

        /// <summary>
        /// Sets a maximum number of messages to request in a resend request.
        /// </summary>
        public int MaxMessagesInResendRequest { get; set; }

        /// <summary>
        /// This is the FIX field value, e.g. "6" for FIX44
        /// </summary>
        public ApplVerID targetDefaultApplVerID { get; set; }

        /// <summary>
        /// This is the FIX field value, e.g. "6" for FIX44
        /// </summary>
        public string SenderDefaultApplVerID { get; set; }

        public SessionID SessionID { get; set; }
        public IApplication Application { get; set; }
        public DataDictionaryProvider DataDictionaryProvider { get; set; }
        public DataDictionary.DataDictionary SessionDataDictionary { get; private set; }
        public DataDictionary.DataDictionary ApplicationDataDictionary { get; private set; }

        /// <summary>
        /// Returns whether the Session has a Responder. This method is synchronized
        /// </summary>
        public bool HasResponder { get { lock (_sync) { return null != _responder; } } }

        /// <summary>
        /// Returns whether the Sessions will allow ResetSequence messages sent as
        /// part of a resend request (PossDup=Y) to omit the OrigSendingTime
        /// </summary>
        public bool RequiresOrigSendingTime { get; set; }

        #endregion

        /// <summary>
        /// Don't use this.  It decides the connection is an initiator if heartBtInt=0,
        /// which is bad because 0 is actually a valid (though not-often-used) setting.
        /// </summary>
        [System.Obsolete("Use the constructor that takes the isInitiator parameter.")]
        public Session(
            IApplication app,
            IMessageStoreFactory storeFactory,
            SessionID sessID,
            DataDictionaryProvider dataDictProvider,
            SessionSchedule sessionSchedule,
            int heartBtInt,
            ILogFactory logFactory,
            IMessageFactory msgFactory,
            string senderDefaultApplVerID)
            : this(0 == heartBtInt, app, storeFactory, sessID, dataDictProvider, sessionSchedule, heartBtInt, logFactory, msgFactory, senderDefaultApplVerID)
        { }

        /// <summary>
        /// Don't use this.  It decides the connection is an initiator if heartBtInt=0,
        /// which is bad because 0 is actually a valid (though not-often-used) setting.
        /// </summary>
        [System.Obsolete("Use the constructor that takes the isInitiator parameter.")]
        public Session(
            IApplication app, 
            IMessageStoreFactory storeFactory, 
            SessionID sessID, 
            DataDictionaryProvider dataDictProvider,
            SessionSchedule sessionSchedule, 
            int heartBtInt, 
            ILoggerFactory logFactory, 
            IMessageFactory msgFactory, 
            string senderDefaultApplVerID)
            : this(0 == heartBtInt, app, storeFactory, sessID, dataDictProvider, sessionSchedule, heartBtInt, logFactory, msgFactory, senderDefaultApplVerID)
        { }

        [Obsolete("Use Constructor with ILoggerFactory instead")]
        public Session(
            bool isInitiator,
            IApplication app,
            IMessageStoreFactory storeFactory,
            SessionID sessID,
            DataDictionaryProvider dataDictProvider,
            SessionSchedule sessionSchedule,
            int heartBtInt,
            ILogFactory logFactory,
            IMessageFactory msgFactory,
            string senderDefaultApplVerID) 
            : this(isInitiator, app, storeFactory, sessID, dataDictProvider, sessionSchedule, heartBtInt, LoggerExtensions.LoggerFactoryTransient(logFactory),msgFactory, senderDefaultApplVerID)
        {

        }

        public Session(
        bool isInitiator,
        IApplication app,
        IMessageStoreFactory storeFactory,
        SessionID sessID,
        DataDictionaryProvider dataDictProvider,
        SessionSchedule sessionSchedule,
        int heartBtInt,
        ILoggerFactory logFactory,
        IMessageFactory msgFactory,
        string senderDefaultApplVerID)
        {
            Application = app;
            SessionID = sessID;
            DataDictionaryProvider = new DataDictionaryProvider(dataDictProvider);
            _schedule = sessionSchedule;
            _msgFactory = msgFactory;
            _appDoesEarlyIntercept = app is IApplicationExt;

            SenderDefaultApplVerID = senderDefaultApplVerID;

            SessionDataDictionary = DataDictionaryProvider.GetSessionDataDictionary(SessionID.BeginString);
            if (SessionID.IsFIXT)
                ApplicationDataDictionary = DataDictionaryProvider.GetApplicationDataDictionary(SenderDefaultApplVerID);
            else
                ApplicationDataDictionary = SessionDataDictionary;

            ILogger log = logFactory != null ? logFactory.CreateLogger(sessID.ToString()) : NullLogger.Instance;
            _state = new SessionState(isInitiator, log, heartBtInt)
            {
                MessageStore = storeFactory.Create(sessID)
            };

            // Configuration defaults.
            // Will be overridden by the SessionFactory with values in the user's configuration.
            PersistMessages = true;
            ResetOnDisconnect = false;
            SendRedundantResendRequests = false;
            ResendSessionLevelRejects = false;
            ValidateLengthAndChecksum = true;
            CheckCompID = true;
            TimeStampPrecision = TimeStampPrecision.Millisecond;
            EnableLastMsgSeqNumProcessed = false;
            MaxMessagesInResendRequest = 0;
            SendLogoutBeforeTimeoutDisconnect = false;
            IgnorePossDupResendRequests = false;
            RequiresOrigSendingTime = true;
            CheckLatency = true;
            MaxLatency = 120;

            if (!IsSessionTime)
                Reset("Out of SessionTime (Session construction)");
            else if (IsNewSession)
                Reset("New session");

            lock (_sessions)
            {
                _sessions[SessionID] = this;
            }

            Application.OnCreate(SessionID);
            Logger.LogEvent("Created session");
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
            lock (_sessions)
            {
                if (!_sessions.TryGetValue(sessionID, out result))
                    result = null;
            }
            return result;
        }

        /// <summary>
        /// Looks up a Session by its SessionID
        /// </summary>
        /// <param name="sessionID">the SessionID of the Session</param>
        /// <returns>the true if Session exists, false otherwise</returns>
        public static bool DoesSessionExist(SessionID sessionID)
        {
            return LookupSession(sessionID) == null ? false : true;
        }

        /// <summary>
        /// Sends a message to the session specified by the provider session ID.
        /// </summary>
        /// <param name="message">FIX message</param>
        /// <param name="sessionID">target SessionID</param>
        /// <returns>true if send was successful, false otherwise</returns>
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

        /// <summary>
        /// Sends a message via the session indicated by the header fields
        /// </summary>
        /// <param name="message">message to send</param>
        /// <returns>true if was sent successfully</returns>
        public virtual bool Send(Message message)
        {
            message.Header.RemoveField(Fields.Tags.PossDupFlag);
            message.Header.RemoveField(Fields.Tags.OrigSendingTime);
            return SendRaw(message, 0);
        }

        /// <summary>
        /// Sends a message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool Send(string message)
        {
            lock (_sync)
            {
                if (null == _responder)
                    return false;
                Logger.LogOutgoing(message);
                return _responder.Send(message);
            }
        }

        // TODO for v2 - rename, make internal
        /// <summary>
        /// Sets some internal state variables.  Despite the name, it does not do anything to make a logon occur.
        /// </summary>
        public void Logon()
        {
            _state.IsEnabled = true;
            _state.LogoutReason = "";
        }

        // TODO for v2 - rename, make internal
        /// <summary>
        /// Sets some internal state variables.  Despite the name, it does not cause a logout to occur.
        /// </summary>
        public void Logout()
        {
            Logout("");
        }

        // TODO for v2 - rename, make internal
        /// <summary>
        /// Sets some internal state variables.  Despite the name, it does not cause a logout to occur.
        /// </summary>
        public void Logout(string reason)
        {
            _state.IsEnabled = false;
            _state.LogoutReason = reason;
        }

        /// <summary>
        /// Logs out from session and closes the network connection
        /// </summary>
        /// <param name="reason"></param>
        public void Disconnect(string reason)
        {
            lock (_sync)
            {
                if (null != _responder)
                {
                    Logger.LogEvent("Session " + SessionID + " disconnecting: " + reason);
                    _responder.Disconnect();
                    _responder = null;
                }
                else
                {
                    Logger.LogEvent("Session " + SessionID + " already disconnected: " + reason);
                }

                if (_state.ReceivedLogon || _state.SentLogon)
                {
                    _state.ReceivedLogon = false;
                    _state.SentLogon = false;
                    Application.OnLogout(SessionID);
                }

                _state.SentLogout = false;
                _state.ReceivedReset = false;
                _state.SentReset = false;
                _state.ClearQueue();
                _state.LogoutReason = "";
                if (ResetOnDisconnect)
                    _state.Reset("ResetOnDisconnect");
                _state.SetResendRange(0, 0);
            }
        }

        /// <summary>
        /// There's no message to process, but check the session state to see if there's anything to do
        /// (e.g. send heartbeat, logout at end of session, etc)
        /// </summary>
        public void Next()
        {
            if (!HasResponder)
                return;

            if (!IsSessionTime)
            {
                if(IsInitiator)
                    Reset("Out of SessionTime (Session.Next())");
                else
                    Reset("Out of SessionTime (Session.Next())", "Message received outside of session time");
                return;
            }

            if (IsNewSession)
                _state.Reset("New session (detected in Next())");

            if (!IsEnabled)
            {
                if (!IsLoggedOn)
                    return;

                if (!_state.SentLogout)
                {
                    Logger.LogEvent("Initiated logout request");
                    GenerateLogout(_state.LogoutReason);
                }
            }

            if (!_state.ReceivedLogon)
            {
                if (_state.ShouldSendLogon && IsTimeToGenerateLogon())
                {
                    if (GenerateLogon())
                        Logger.LogEvent("Initiated logon request");
                    else
                        Logger.LogEvent("Error during logon request initiation");

                }
                else if (_state.SentLogon && _state.LogonTimedOut())
                {
                    Disconnect("Timed out waiting for logon response");
                }
                return;
            }

            if (0 == _state.HeartBtInt)
                return;


            if (_state.LogoutTimedOut())
                Disconnect("Timed out waiting for logout response");


            if (_state.WithinHeartbeat())
                return;

            if (_state.TimedOut())
            {
                if (SendLogoutBeforeTimeoutDisconnect)
                    GenerateLogout();
                Disconnect("Timed out waiting for heartbeat");
            }
            else
            {
                if (_state.NeedTestRequest())
                {

                    GenerateTestRequest("TEST");
                    _state.TestRequestCounter += 1;
                    Logger.LogEvent("Sent test request TEST");
                }
                else if (_state.NeedHeartbeat())
                {
                    GenerateHeartbeat();
                }
            }
        }

        /// <summary>
        /// Process a message (in string form) from the counterparty
        /// </summary>
        /// <param name="msgStr"></param>
        public void Next(string msgStr)
        {
            NextMessage(msgStr);
            NextQueued();
        }

        /// <summary>
        /// Process a message (in string form) from the counterparty
        /// </summary>
        /// <param name="msgStr"></param>
        private void NextMessage(string msgStr)
        {
            Logger.LogIncoming(msgStr);

            MessageBuilder msgBuilder = new MessageBuilder(
                    msgStr,
                    SenderDefaultApplVerID,
                    ValidateLengthAndChecksum,
                    SessionDataDictionary,
                    ApplicationDataDictionary,
                    _msgFactory);

            Next(msgBuilder);
        }

        /// <summary>
        /// Process a message from the counterparty.
        /// </summary>
        /// <param name="msgBuilder"></param>
        internal void Next(MessageBuilder msgBuilder)
        {
            if (!IsSessionTime)
            {
                Reset("Out of SessionTime (Session.Next(message))", "Message received outside of session time");
                return;
            }

            if (IsNewSession)
                _state.Reset("New session (detected in Next(Message))");

            Message message = null; // declared outside of try-block so that catch-blocks can use it

            try
            {
                message = msgBuilder.Build();

                if (_appDoesEarlyIntercept)
                    ((IApplicationExt)Application).FromEarlyIntercept(message, SessionID);

                Header header = message.Header;
                string msgType = msgBuilder.MsgType.Obj;
                string beginString = msgBuilder.BeginString;

                if (!beginString.Equals(SessionID.BeginString))
                    throw new UnsupportedVersion(beginString);


                if (MsgType.LOGON.Equals(msgType))
                {
                    if (SessionID.IsFIXT)
                    {
                        targetDefaultApplVerID = new ApplVerID(message.GetString(Fields.Tags.DefaultApplVerID));
                    }
                    else
                    {
                        targetDefaultApplVerID = Message.GetApplVerID(beginString);
                    }
                }

                if (SessionID.IsFIXT && !Message.IsAdminMsgType(msgType))
                {
                    DataDictionary.DataDictionary.Validate(message, SessionDataDictionary, ApplicationDataDictionary, beginString, msgType);
                }
                else
                {
                    SessionDataDictionary.Validate(message, beginString, msgType);
                }


                if (MsgType.LOGON.Equals(msgType))
                    NextLogon(message);
                else if (MsgType.LOGOUT.Equals(msgType))
                    NextLogout(message);
                else if (!IsLoggedOn)
                    Disconnect(string.Format("Received msg type '{0}' when not logged on", msgType));
                else if (MsgType.HEARTBEAT.Equals(msgType))
                    NextHeartbeat(message);
                else if (MsgType.TEST_REQUEST.Equals(msgType))
                    NextTestRequest(message);
                else if (MsgType.SEQUENCE_RESET.Equals(msgType))
                    NextSequenceReset(message);
                else if (MsgType.RESEND_REQUEST.Equals(msgType))
                    NextResendRequest(message);
                else
                {
                    if (!Verify(message))
                        return;
                    _state.IncrNextTargetMsgSeqNum();
                }

            }
            catch (InvalidMessage e)
            {
                Logger.LogEvent(e.Message);

                try
                {
                    if (MsgType.LOGON.Equals(msgBuilder.MsgType.Obj))
                        Disconnect("Logon message is not valid");
                }
                catch (MessageParseError)
                { }

                throw e;
            }
            catch (TagException e)
            {
                if (null != e.InnerException)
                    Logger.LogEvent(e.InnerException.Message);
                GenerateReject(msgBuilder, e.sessionRejectReason, e.Field);
            }
            catch (UnsupportedVersion uvx)
            {
                if (MsgType.LOGOUT.Equals(msgBuilder.MsgType.Obj))
                {
                    NextLogout(message);
                }
                else
                {
                    Logger.LogEvent(uvx.ToString());
                    GenerateLogout(uvx.Message);
                    _state.IncrNextTargetMsgSeqNum();
                }
            }
            catch (UnsupportedMessageType e)
            {
                Logger.LogEvent("Unsupported message type: " + e.Message);
                GenerateBusinessMessageReject(message, Fields.BusinessRejectReason.UNKNOWN_MESSAGE_TYPE, 0);
            }
            catch (FieldNotFoundException e)
            {
                Logger.LogEvent("Rejecting invalid message, field not found: " + e.Message);
                if ((SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0) && (message.IsApp()))
                {
                    GenerateBusinessMessageReject(message, Fields.BusinessRejectReason.CONDITIONALLY_REQUIRED_FIELD_MISSING, e.Field);
                }
                else
                {
                    if (MsgType.LOGON.Equals(msgBuilder.MsgType.Obj))
                    {
                        Logger.LogEvent("Required field missing from logon");
                        Disconnect("Required field missing from logon");
                    }
                    else
                        GenerateReject(msgBuilder, new QuickFix.FixValues.SessionRejectReason(SessionRejectReason.REQUIRED_TAG_MISSING, "Required Tag Missing"), e.Field);
                }
            }
            catch (RejectLogon e)
            {
                GenerateLogout(e.Message);
                Disconnect(e.ToString());
            }

            Next();
        }

        protected void NextLogon(Message logon)
        {
            Fields.ResetSeqNumFlag resetSeqNumFlag = new Fields.ResetSeqNumFlag(false);
            if (logon.IsSetField(resetSeqNumFlag))
                logon.GetField(resetSeqNumFlag);
            _state.ReceivedReset = resetSeqNumFlag.Obj;

            if (_state.ReceivedReset)
            {
                Logger.LogEvent("Sequence numbers reset due to ResetSeqNumFlag=Y");
                if (!_state.SentReset)
                {
                    _state.Reset("Reset requested by counterparty");
                }
            }

            if (IsAcceptor && ResetOnLogon)
                _state.Reset("ResetOnLogon");
            if (RefreshOnLogon)
                Refresh();

            if (!Verify(logon, false, true))
                return;

            if (!IsGoodTime(logon))
            {
                Logger.LogEvent("Logon has bad sending time");
                Disconnect("bad sending time");
                return;
            }

            _state.ReceivedLogon = true;
            Logger.LogEvent("Received logon");
            if (IsAcceptor)
            {
                int heartBtInt = logon.GetInt(Fields.Tags.HeartBtInt);
                _state.HeartBtInt = heartBtInt;
                GenerateLogon(logon);
                Logger.LogEvent("Responding to logon request");
            }

            _state.SentReset = false;
            _state.ReceivedReset = false;

            int msgSeqNum = logon.Header.GetInt(Fields.Tags.MsgSeqNum);
            if (IsTargetTooHigh(msgSeqNum) && !resetSeqNumFlag.Obj)
            {
                DoTargetTooHigh(logon, msgSeqNum);
            }
            else
            {
                _state.IncrNextTargetMsgSeqNum();
            }

            if (IsLoggedOn)
                Application.OnLogon(SessionID);
        }

        protected void NextTestRequest(Message testRequest)
        {
            if (!Verify(testRequest))
                return;
            GenerateHeartbeat(testRequest);
            _state.IncrNextTargetMsgSeqNum();
        }

        protected void NextResendRequest(Message resendReq)
        {
            if (!Verify(resendReq, false, false))
                return;
            try
            {
                int msgSeqNum = 0;
                if (!(IgnorePossDupResendRequests && resendReq.Header.IsSetField(Tags.PossDupFlag)))
                {
                    int begSeqNo = resendReq.GetInt(Fields.Tags.BeginSeqNo);
                    int endSeqNo = resendReq.GetInt(Fields.Tags.EndSeqNo);
                    Logger.LogEvent("Got resend request from " + begSeqNo + " to " + endSeqNo);

                    if ((endSeqNo == 999999) || (endSeqNo == 0))
                    {
                        endSeqNo = _state.GetNextSenderMsgSeqNum() - 1;
                    }

                    if (!PersistMessages)
                    {
                        endSeqNo++;
                        int next = _state.GetNextSenderMsgSeqNum();
                        if (endSeqNo > next)
                            endSeqNo = next;
                        GenerateSequenceReset(resendReq, begSeqNo, endSeqNo);
                        msgSeqNum = resendReq.Header.GetInt(Tags.MsgSeqNum);
                        if (!IsTargetTooHigh(msgSeqNum) && !IsTargetTooLow(msgSeqNum))
                        {
                            _state.IncrNextTargetMsgSeqNum();
                        }
                        return;
                    }

                    List<string> messages = new List<string>();
                    _state.Get(begSeqNo, endSeqNo, messages);
                    int current = begSeqNo;
                    int begin = 0;
                    foreach (string msgStr in messages)
                    {
                        Message msg = new Message();
                        msg.FromString(msgStr, true, SessionDataDictionary, ApplicationDataDictionary, _msgFactory);
                        msgSeqNum = msg.Header.GetInt(Tags.MsgSeqNum);

                        if ((current != msgSeqNum) && begin == 0)
                        {
                            begin = current;
                        }

                        if (IsAdminMessage(msg) && !(ResendSessionLevelRejects && msg.Header.GetString(Tags.MsgType) == MsgType.REJECT))
                        {
                            if (begin == 0)
                            {
                                begin = msgSeqNum;
                            }
                        }
                        else
                        {

                            initializeResendFields(msg);
                            if(!ResendApproved(msg, SessionID)) 
                            {
                                continue;
                            }

                            if (begin != 0)
                            {
                                GenerateSequenceReset(resendReq, begin, msgSeqNum);
                            }
                            Send(msg.ToString());
                            begin = 0;
                        }
                        current = msgSeqNum + 1;
                    }

                    int nextSeqNum = _state.GetNextSenderMsgSeqNum();
                    if (++endSeqNo > nextSeqNum)
                    {
                        endSeqNo = nextSeqNum;
                    }

                    if (begin == 0)
                    {
                        begin = current;
                    }

                    if (endSeqNo > begin)
                    {
                        GenerateSequenceReset(resendReq, begin, endSeqNo);
                    }
                }
                msgSeqNum = resendReq.Header.GetInt(Tags.MsgSeqNum);
                if (!IsTargetTooHigh(msgSeqNum) && !IsTargetTooLow(msgSeqNum))
                {
                    _state.IncrNextTargetMsgSeqNum();
                }

            }
            catch (System.Exception e)
            {
                Logger.LogEvent("ERROR during resend request " + e.Message);
            }
        }
        private bool ResendApproved(Message msg, SessionID sessionID)
        {
            try
            {
                Application.ToApp(msg, sessionID);
            }
            catch (DoNotSend)
            {
                return false;
            }

            return true;
        }

        protected void NextLogout(Message logout)
        {
            if (!Verify(logout, false, false))
                return;

            string disconnectReason;

            if (!_state.SentLogout)
            {
                disconnectReason = "Received logout request";
                Logger.LogEvent(disconnectReason);
                GenerateLogout(logout);
                Logger.LogEvent("Sending logout response");
            }
            else
            {
                disconnectReason = "Received logout response";
                Logger.LogEvent(disconnectReason);
            }

            _state.IncrNextTargetMsgSeqNum();
            if (ResetOnLogout)
                _state.Reset("ResetOnLogout");
            Disconnect(disconnectReason);
        }

        protected void NextHeartbeat(Message heartbeat)
        {
            if (!Verify(heartbeat))
                return;
            _state.IncrNextTargetMsgSeqNum();
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
                Logger.LogEvent("Received SequenceReset FROM: " + _state.GetNextTargetMsgSeqNum() + " TO: " + newSeqNo);

                if (newSeqNo > _state.GetNextTargetMsgSeqNum())
                {
                    _state.SetNextTargetMsgSeqNum(newSeqNo);
                }
                else
                {
                    if (newSeqNo < _state.GetNextTargetMsgSeqNum())
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
                msgType = msg.Header.GetString(Fields.Tags.MsgType);
                string senderCompID = msg.Header.GetString(Fields.Tags.SenderCompID);
                string targetCompID = msg.Header.GetString(Fields.Tags.TargetCompID);

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

                if ((checkTooHigh || checkTooLow) && _state.ResendRequested())
                {
                    ResendRange range = _state.GetResendRange();
                    if (msgSeqNum >= range.EndSeqNo)
                    {
                        Logger.LogEvent("ResendRequest for messages FROM: " + range.BeginSeqNo + " TO: " + range.EndSeqNo + " has been satisfied.");
                        _state.SetResendRange(0, 0);
                    }
                    else if (msgSeqNum >= range.ChunkEndSeqNo)
                    {
                        Logger.LogEvent("Chunked ResendRequest for messages FROM: " + range.BeginSeqNo + " TO: " + range.ChunkEndSeqNo + " has been satisfied.");
                        int newChunkEndSeqNo = Math.Min(range.EndSeqNo, range.ChunkEndSeqNo + MaxMessagesInResendRequest);
                        GenerateResendRequestRange(msg.Header.GetString(Fields.Tags.BeginString), range.ChunkEndSeqNo + 1, newChunkEndSeqNo);
                        range.ChunkEndSeqNo = newChunkEndSeqNo;
                    }
                }

                if (!IsGoodTime(msg))
                {
                    Logger.LogEvent("Sending time accuracy problem");
                    GenerateReject(msg, FixValues.SessionRejectReason.SENDING_TIME_ACCURACY_PROBLEM);
                    GenerateLogout();
                    return false;
                }
            }
            catch (System.Exception e)
            {
                Logger.LogEvent("Verify failed: " + e.Message);
                Disconnect("Verify failed: " + e.Message);
                return false;
            }

            _state.LastReceivedTimeDT = DateTime.UtcNow;
            _state.TestRequestCounter = 0;

            if (Message.IsAdminMsgType(msgType))
                Application.FromAdmin(msg, SessionID);
            else
                Application.FromApp(msg, SessionID);

            return true;
        }

        public void SetResponder(IResponder responder)
        {
            if (!IsSessionTime)
                Reset("Out of SessionTime (Session.SetResponder)");

            lock (_sync)
            {
                _responder = responder;
            }
        }

        public void Refresh()
        {
            _state.Refresh();
        }

        [Obsolete("Use Reset(reason) instead.")]
        public void Reset()
        {
            Reset("(unspecified reason)");
        }

        /// <summary>
        /// Send a logout, disconnect, and reset session state
        /// </summary>
        /// <param name="loggedReason">reason for the reset (for the log)</param>
        public void Reset(string loggedReason)
        {
            Reset(loggedReason, null);
        }

        /// <summary>
        /// Send a logout, disconnect, and reset session state
        /// </summary>
        /// <param name="loggedReason">reason for the reset (for the log)</param>
        /// <param name="logoutMessage">message to put in the Logout message's Text field (ignored if null/empty string)</param>
        public void Reset(string loggedReason, string logoutMessage)
        {
            if(IsLoggedOn)
                GenerateLogout(logoutMessage);
            Disconnect("Resetting...");
            _state.Reset(loggedReason);
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
            return (SessionID.BeginString.CompareTo(FixValues.BeginString.FIX41) >= 0)
                && (ResetOnLogon || ResetOnLogout || ResetOnDisconnect)
                && (_state.GetNextSenderMsgSeqNum() == 1)
                && (_state.GetNextTargetMsgSeqNum() == 1);
        }

        protected bool IsCorrectCompID(string senderCompID, string targetCompID)
        {
            if (!CheckCompID)
                return true;
            return SessionID.SenderCompID.Equals(targetCompID)
                && SessionID.TargetCompID.Equals(senderCompID);
        }

        /// FIXME
        protected bool IsTimeToGenerateLogon()
        {
            return true;
        }

        protected bool IsTargetTooHigh(int msgSeqNum)
        {
            return msgSeqNum > _state.GetNextTargetMsgSeqNum();
        }

        protected bool IsTargetTooLow(int msgSeqNum)
        {
            return msgSeqNum < _state.GetNextTargetMsgSeqNum();
        }

        protected void DoTargetTooHigh(Message msg, int msgSeqNum)
        {
            string beginString = msg.Header.GetString(Fields.Tags.BeginString);

            Logger.LogEvent("MsgSeqNum too high, expecting " + _state.GetNextTargetMsgSeqNum() + " but received " + msgSeqNum);
            _state.Queue(msgSeqNum, msg);

            if (_state.ResendRequested())
            {
                ResendRange range = _state.GetResendRange();

                if (!SendRedundantResendRequests && msgSeqNum >= range.BeginSeqNo)
                {
                    Logger.LogEvent("Already sent ResendRequest FROM: " + range.BeginSeqNo + " TO: " + range.EndSeqNo + ".  Not sending another.");
                    return;
                }
            }

            GenerateResendRequest(beginString, msgSeqNum);
        }

        protected void DoTargetTooLow(Message msg, int msgSeqNum)
        {
            bool possDupFlag = false;
            if (msg.Header.IsSetField(Fields.Tags.PossDupFlag))
                possDupFlag = msg.Header.GetBoolean(Fields.Tags.PossDupFlag);

            if (!possDupFlag)
            {
                string err = "MsgSeqNum too low, expecting " + _state.GetNextTargetMsgSeqNum() + " but received " + msgSeqNum;
                GenerateLogout(err);
                throw new QuickFIXException(err);
            }

            DoPossDup(msg);
        }

        /// <summary>
        /// Validates a message where PossDupFlag=Y
        /// </summary>
        /// <param name="msg"></param>
        protected void DoPossDup(Message msg)
        {
            // If config RequiresOrigSendingTime=N, then tolerate SequenceReset messages that lack OrigSendingTime (issue #102).
            // (This field doesn't really make sense in this message, so some parties omit it, even though spec requires it.)
            string msgType = msg.Header.GetString(Fields.Tags.MsgType); 
            if (msgType == Fields.MsgType.SEQUENCE_RESET && RequiresOrigSendingTime == false)
                return;

            // Reject if messages don't have OrigSendingTime set
            if (!msg.Header.IsSetField(Fields.Tags.OrigSendingTime))
            {
                GenerateReject(msg, FixValues.SessionRejectReason.REQUIRED_TAG_MISSING, Fields.Tags.OrigSendingTime);
                return;
            }

            // Ensure sendingTime is later than OrigSendingTime, else reject and logout
            DateTime origSendingTime = msg.Header.GetDateTime(Fields.Tags.OrigSendingTime);
            DateTime sendingTime = msg.Header.GetDateTime(Fields.Tags.SendingTime);
            System.TimeSpan tmSpan = origSendingTime - sendingTime;

            if (tmSpan.TotalSeconds > 0)
            {
                GenerateReject(msg, FixValues.SessionRejectReason.SENDING_TIME_ACCURACY_PROBLEM);
                GenerateLogout();
            }
        }

        protected void GenerateBusinessMessageReject(Message message, int err, int field)
        {
            string msgType = message.Header.GetString(Tags.MsgType);
            int msgSeqNum = message.Header.GetInt(Tags.MsgSeqNum);
            string reason = FixValues.BusinessRejectReason.RejText[err];
            Message reject;
            if (SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
            {
                reject = _msgFactory.Create(SessionID.BeginString, MsgType.BUSINESS_MESSAGE_REJECT);
                reject.SetField(new RefMsgType(msgType));
                reject.SetField(new BusinessRejectReason(err));
            }
            else
            {
                reject = _msgFactory.Create(SessionID.BeginString, MsgType.REJECT);
                char[] reasonArray = reason.ToLower().ToCharArray();
                reasonArray[0] = char.ToUpper(reasonArray[0]);
                reason = new string(reasonArray);
            }
            InitializeHeader(reject);
            reject.SetField(new RefSeqNum(msgSeqNum));
            _state.IncrNextTargetMsgSeqNum();


            reject.SetField(new Text(reason));
            Logger.LogEvent("Reject sent for Message: " + msgSeqNum + " Reason:" + reason);
            SendRaw(reject, 0);
        }

        protected bool GenerateResendRequestRange(string beginString, int startSeqNum, int endSeqNum)
        {
            Message resendRequest = _msgFactory.Create(beginString, MsgType.RESEND_REQUEST);

            resendRequest.SetField(new Fields.BeginSeqNo(startSeqNum));
            resendRequest.SetField(new Fields.EndSeqNo(endSeqNum));

            InitializeHeader(resendRequest);
            if (SendRaw(resendRequest, 0))
            {
                Logger.LogEvent("Sent ResendRequest FROM: " + startSeqNum + " TO: " + endSeqNum);
                return true;
            }
            else
            {
                Logger.LogEvent("Error sending ResendRequest (" + startSeqNum + " ," + endSeqNum + ")");
                return false;
            }
        }

        protected bool GenerateResendRequest(string beginString, int msgSeqNum)
        {
            int beginSeqNum = _state.GetNextTargetMsgSeqNum();
            int endRangeSeqNum = msgSeqNum - 1;
            int endChunkSeqNum;
            if (MaxMessagesInResendRequest > 0)
            {
                endChunkSeqNum = Math.Min(endRangeSeqNum, beginSeqNum + MaxMessagesInResendRequest - 1);
            }
            else
            {
                if (beginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
                    endRangeSeqNum = 0;
                else if (beginString.CompareTo(FixValues.BeginString.FIX41) <= 0)
                    endRangeSeqNum = 999999;
                endChunkSeqNum = endRangeSeqNum;
            }

            if (!GenerateResendRequestRange(beginString, beginSeqNum, endChunkSeqNum))
            {
                return false;
            }

            _state.SetResendRange(beginSeqNum, endRangeSeqNum, endChunkSeqNum);
            return true;
        }

        /// <summary>
        /// FIXME
        /// </summary>
        /// <returns></returns>
        protected bool GenerateLogon()
        {
            Message logon = _msgFactory.Create(SessionID.BeginString, Fields.MsgType.LOGON);
            logon.SetField(new Fields.EncryptMethod(0));
            logon.SetField(new Fields.HeartBtInt(_state.HeartBtInt));

            if (SessionID.IsFIXT)
                logon.SetField(new Fields.DefaultApplVerID(SenderDefaultApplVerID));
            if (RefreshOnLogon)
                Refresh();
            if (ResetOnLogon)
                _state.Reset("ResetOnLogon");
            if (ShouldSendReset())
                logon.SetField(new Fields.ResetSeqNumFlag(true));

            InitializeHeader(logon);
            _state.LastReceivedTimeDT = DateTime.UtcNow;
            _state.TestRequestCounter = 0;
            _state.SentLogon = true;
            return SendRaw(logon, 0);
        }

        /// <summary>
        /// FIXME don't do so much operator new here
        /// </summary>
        /// <param name="otherLogon"></param>
        /// <returns></returns>
        protected bool GenerateLogon(Message otherLogon)
        {
            Message logon = _msgFactory.Create(SessionID.BeginString, Fields.MsgType.LOGON);
            logon.SetField(new Fields.EncryptMethod(0));
            if (SessionID.IsFIXT)
                logon.SetField(new Fields.DefaultApplVerID(SenderDefaultApplVerID));
            logon.SetField(new Fields.HeartBtInt(otherLogon.GetInt(Tags.HeartBtInt)));
            if (EnableLastMsgSeqNumProcessed)
                logon.Header.SetField(new Fields.LastMsgSeqNumProcessed(otherLogon.Header.GetInt(Tags.MsgSeqNum)));

            InitializeHeader(logon);
            _state.SentLogon = SendRaw(logon, 0);
            return _state.SentLogon;
        }

        public bool GenerateTestRequest(string id)
        {
            Message testRequest = _msgFactory.Create(SessionID.BeginString, Fields.MsgType.TEST_REQUEST);
            InitializeHeader(testRequest);
            testRequest.SetField(new Fields.TestReqID(id));
            return SendRaw(testRequest, 0);
        }

        /// <summary>
        /// Send a basic Logout message
        /// </summary>
        /// <returns></returns>
        public bool GenerateLogout()
        {
            return GenerateLogout(null, null);
        }

        /// <summary>
        /// Send a Logout message
        /// </summary>
        /// <param name="text">written into the Text field</param>
        /// <returns></returns>
        private bool GenerateLogout(string text)
        {
            return GenerateLogout(null, text);
        }

        /// <summary>
        /// Send a Logout message
        /// </summary>
        /// <param name="other">used to fill MsgSeqNum field, if configuration requires it</param>
        /// <returns></returns>
        private bool GenerateLogout(Message other)
        {
            return GenerateLogout(other, null);
        }

        /// <summary>
        /// Send a Logout message
        /// </summary>
        /// <param name="other">used to fill MsgSeqNum field, if configuration requires it; ignored if null</param>
        /// <param name="text">written into the Text field; ignored if empty/null</param>
        /// <returns></returns>
        private bool GenerateLogout(Message other, string text)
        {
            Message logout = _msgFactory.Create(SessionID.BeginString, Fields.MsgType.LOGOUT);
            InitializeHeader(logout);
            if (text != null && text.Length > 0)
                logout.SetField(new Fields.Text(text));
            if (other != null && EnableLastMsgSeqNumProcessed)
            {
                try
                {
                    logout.Header.SetField(new Fields.LastMsgSeqNumProcessed(other.Header.GetInt(Tags.MsgSeqNum)));
                }
                catch (FieldNotFoundException)
                {
                    Logger.LogEvent("Error: No message sequence number: " + other);
                }
            }
            _state.SentLogout = SendRaw(logout, 0);
            return _state.SentLogout;
        }

        public bool GenerateHeartbeat()
        {
            Message heartbeat = _msgFactory.Create(SessionID.BeginString, Fields.MsgType.HEARTBEAT);
            InitializeHeader(heartbeat);
            return SendRaw(heartbeat, 0);
        }

        public bool GenerateHeartbeat(Message testRequest)
        {
            Message heartbeat = _msgFactory.Create(SessionID.BeginString, Fields.MsgType.HEARTBEAT);
            InitializeHeader(heartbeat);
            try
            {
                heartbeat.SetField(new Fields.TestReqID(testRequest.GetString(Fields.Tags.TestReqID)));
                if (EnableLastMsgSeqNumProcessed)
                {
                    heartbeat.Header.SetField(new Fields.LastMsgSeqNumProcessed(testRequest.Header.GetInt(Tags.MsgSeqNum)));
                }
            }
            catch (FieldNotFoundException)
            { }
            return SendRaw(heartbeat, 0);
        }


        internal bool GenerateReject(MessageBuilder msgBuilder, FixValues.SessionRejectReason reason)
        {
            return GenerateReject(msgBuilder.RejectableMessage(), reason, 0);
        }
       
        internal bool GenerateReject(MessageBuilder msgBuilder, FixValues.SessionRejectReason reason, int field)
        {
            return GenerateReject(msgBuilder.RejectableMessage(), reason, field);
        }

        public bool GenerateReject(Message message, FixValues.SessionRejectReason reason)
        {
            return GenerateReject(message, reason, 0);
        }

        public bool GenerateReject(Message message, FixValues.SessionRejectReason reason, int field)
        {
            string beginString = SessionID.BeginString;

            Message reject = _msgFactory.Create(beginString, Fields.MsgType.REJECT);
            reject.ReverseRoute(message.Header);
            InitializeHeader(reject);

            string msgType;
            if (message.Header.IsSetField(Fields.Tags.MsgType))
                msgType = message.Header.GetString(Fields.Tags.MsgType);
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
              && (msgSeqNum == _state.GetNextTargetMsgSeqNum()))
            {
                _state.IncrNextTargetMsgSeqNum();
            }

            if ((0 != field) || FixValues.SessionRejectReason.INVALID_TAG_NUMBER.Equals(reason))
            {
                if (FixValues.SessionRejectReason.INVALID_MSGTYPE.Equals(reason))
                {
                    if (SessionID.BeginString.CompareTo(FixValues.BeginString.FIX43) >= 0)
                        PopulateRejectReason(reject, reason.Description);
                    else
                        PopulateSessionRejectReason(reject, field, reason.Description, false);
                }
                else
                    PopulateSessionRejectReason(reject, field, reason.Description, true);

                Logger.LogEvent("Message " + msgSeqNum + " Rejected: " + reason.Description + " (Field=" + field + ")");
            }
            else
            {
                PopulateRejectReason(reject, reason.Description);
                Logger.LogEvent("Message " + msgSeqNum + " Rejected: " + reason.Value);
            }

            if (!_state.ReceivedLogon)
                throw new QuickFIXException("Tried to send a reject while not logged on");

            return SendRaw(reject, 0);
        }

        protected void PopulateSessionRejectReason(Message reject, int field, string text, bool includeFieldInfo)
        {
            if (SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0)
            {
                reject.SetField(new RefTagID(field));
                reject.SetField(new Text(text));
            }
            else
            {
                if (includeFieldInfo)
                    reject.SetField(new Text(text + " (" + field + ")"));
                else
                    reject.SetField(new Text(text));
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
        /// <param name="msgSeqNum"></param>
        protected void InitializeHeader(Message m, int msgSeqNum)
        {
            _state.LastSentTimeDT = DateTime.UtcNow;
            m.Header.SetField(new Fields.BeginString(SessionID.BeginString));
            m.Header.SetField(new Fields.SenderCompID(SessionID.SenderCompID));
            if (SessionID.IsSet(SessionID.SenderSubID))
                m.Header.SetField(new Fields.SenderSubID(SessionID.SenderSubID));
            if (SessionID.IsSet(SessionID.SenderLocationID))
                m.Header.SetField(new Fields.SenderLocationID(SessionID.SenderLocationID));
            m.Header.SetField(new Fields.TargetCompID(SessionID.TargetCompID));
            if (SessionID.IsSet(SessionID.TargetSubID))
                m.Header.SetField(new Fields.TargetSubID(SessionID.TargetSubID));
            if (SessionID.IsSet(SessionID.TargetLocationID))
                m.Header.SetField(new Fields.TargetLocationID(SessionID.TargetLocationID));

            if (msgSeqNum > 0)
                m.Header.SetField(new Fields.MsgSeqNum(msgSeqNum));
            else
                m.Header.SetField(new Fields.MsgSeqNum(_state.GetNextSenderMsgSeqNum()));

            if (EnableLastMsgSeqNumProcessed && !m.Header.IsSetField(Tags.LastMsgSeqNumProcessed))
            {
                m.Header.SetField(new LastMsgSeqNumProcessed(NextTargetMsgSeqNum - 1));
            }

            InsertSendingTime(m.Header);
        }
        protected void InitializeHeader(Message m)
        {
            InitializeHeader(m, 0);
        }

        protected void InsertSendingTime(FieldMap header)
        {
            bool fix42OrAbove = false;
            if (SessionID.BeginString == FixValues.BeginString.FIXT11)
                fix42OrAbove = true;
            else
                fix42OrAbove = SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0;

            header.SetField(new SendingTime(DateTime.UtcNow, fix42OrAbove ? TimeStampPrecision : TimeStampPrecision.Second ) );
        }

        protected void Persist(Message message, string messageString)
        {
            if (PersistMessages)
            {
                int msgSeqNum = message.Header.GetInt(Fields.Tags.MsgSeqNum);
                _state.Set(msgSeqNum, messageString);
            }
            _state.IncrNextSenderMsgSeqNum();
        }

        protected bool IsGoodTime(Message msg)
        {
            if (!CheckLatency)
                return true;

            var sendingTime = msg.Header.GetDateTime(Fields.Tags.SendingTime);
            TimeSpan tmSpan = DateTime.UtcNow - sendingTime;
            if (Math.Abs(tmSpan.TotalSeconds) > MaxLatency)
            {
                return false;
            }
            return true;
        }

        private void GenerateSequenceReset(Message receivedMessage, int beginSeqNo, int endSeqNo)
        {
            string beginString = SessionID.BeginString;
            Message sequenceReset = _msgFactory.Create(beginString, Fields.MsgType.SEQUENCE_RESET);
            InitializeHeader(sequenceReset);
            int newSeqNo = endSeqNo;
            sequenceReset.Header.SetField(new PossDupFlag(true));
            InsertOrigSendingTime(sequenceReset.Header, sequenceReset.Header.GetDateTime(Tags.SendingTime));

            sequenceReset.Header.SetField(new MsgSeqNum(beginSeqNo));
            sequenceReset.SetField(new NewSeqNo(newSeqNo));
            sequenceReset.SetField(new GapFillFlag(true));
            if (receivedMessage != null && EnableLastMsgSeqNumProcessed)
            {
                try
                {
                    sequenceReset.Header.SetField(new Fields.LastMsgSeqNumProcessed(receivedMessage.Header.GetInt(Tags.MsgSeqNum)));
                }
                catch (FieldNotFoundException)
                {
                    Logger.LogEvent("Error: Received message without MsgSeqNum: " + receivedMessage);
                }
            }
            SendRaw(sequenceReset, beginSeqNo);
            Logger.LogEvent("Sent SequenceReset TO: " + newSeqNo);
        }

        protected void InsertOrigSendingTime(FieldMap header, System.DateTime sendingTime)
        {
            bool fix42OrAbove = false;
            if (SessionID.BeginString == FixValues.BeginString.FIXT11)
                fix42OrAbove = true;
            else
                fix42OrAbove = SessionID.BeginString.CompareTo(FixValues.BeginString.FIX42) >= 0;

            header.SetField(new OrigSendingTime(sendingTime, fix42OrAbove ? TimeStampPrecision : TimeStampPrecision.Second ) );
        }
        protected void NextQueued()
        {
            while (NextQueued(_state.MessageStore.GetNextTargetMsgSeqNum()))
            {
                // continue
            }
        }

        protected bool NextQueued(int num)
        {
            Message msg = _state.Dequeue(num);

            if (msg != null)
            {
                Logger.LogEvent("Processing queued message: " + num);

                string msgType = msg.Header.GetString(Tags.MsgType);
                if (msgType.Equals(MsgType.LOGON) || msgType.Equals(MsgType.RESEND_REQUEST))
                {
                    _state.IncrNextTargetMsgSeqNum();
                }
                else
                {
                    NextMessage(msg.ToString());
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
            lock (_sync)
            {
                string msgType = message.Header.GetString(Fields.Tags.MsgType);

                InitializeHeader(message, seqNum);

                if (Message.IsAdminMsgType(msgType))
                {
                    Application.ToAdmin(message, SessionID);

                    if (MsgType.LOGON.Equals(msgType) && !_state.ReceivedReset)
                    {
                        Fields.ResetSeqNumFlag resetSeqNumFlag = new QuickFix.Fields.ResetSeqNumFlag(false);
                        if (message.IsSetField(resetSeqNumFlag))
                            message.GetField(resetSeqNumFlag);
                        if (resetSeqNumFlag.getValue())
                        {
                            _state.Reset("ResetSeqNumFlag");
                            message.Header.SetField(new Fields.MsgSeqNum(_state.GetNextSenderMsgSeqNum()));
                        }
                        _state.SentReset = resetSeqNumFlag.Obj;
                    }
                }
                else
                {
                    try
                    {
                        Application.ToApp(message, SessionID);
                    }
                    catch (DoNotSend)
                    {
                        return false;
                    }
                }

                string messageString = message.ToString();
                if (0 == seqNum)
                    Persist(message, messageString);
                return Send(messageString);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed_ = false;
        protected virtual void Dispose(bool disposing)
        {
            if (disposed_) return;
            if (disposing)
            {
                if (_state != null) { _state.Dispose(); }
                lock (_sessions)
                {
                    _sessions.Remove(SessionID);
                }
            }
            disposed_ = true;
        }

        public bool Disposed
        {
            get { return disposed_; }
        }
        ~Session() => Dispose(false);
    }
}
