using System;
using System.Collections.Generic;
using QuickFix.Logger;
using QuickFix.Store;
using MessagesBySeqNum = System.Collections.Generic.Dictionary<ulong, QuickFix.Message>;

namespace QuickFix
{
    // v2 TODO - consider making this internal
    /// <summary>
    /// Used by the session communications code. Not intended to be used by applications.
    /// </summary>
    public class SessionState : IDisposable
    {
        #region Private Members

        private readonly object _sync = new object();
        private bool _isEnabled = true;
        private bool _receivedLogon = false;
        private bool _receivedReset = false;
        private bool _sentLogon = false;
        private bool _sentLogout = false;
        private bool _sentReset = false;
        private string _logoutReason = "";
        private int _testRequestCounter = 0;
        private int _heartBtInt = 0;
        private int _heartBtIntAsMilliSecs = 0;
        private DateTime _lastReceivedTimeDt = DateTime.MinValue;
        private DateTime _lastSentTimeDt = DateTime.MinValue;
        private int _logonTimeout = 10;
        private long _logonTimeoutAsMilliSecs = 10 * 1000;
        private int _logoutTimeout = 2;
        private long _logoutTimeoutAsMilliSecs = 2 * 1000;
        private readonly ResendRange _resendRange = new ();
        private MessagesBySeqNum _msgQueue = new ();

        #endregion

        #region Unsynchronized Properties

        public IMessageStore MessageStore
        { get; }

        public bool IsInitiator
        { get; set; }

        public bool ShouldSendLogon => IsInitiator && !SentLogon;

        public ILog Log { get; }

        #endregion

        #region Synchronized Properties

        public bool IsEnabled
        {
            get { lock (_sync) { return _isEnabled; } }
            set { lock (_sync) { _isEnabled = value; } }
        }

        public bool ReceivedLogon
        {
            get { lock (_sync) { return _receivedLogon; } }
            set { lock (_sync) { _receivedLogon = value; } }
        }

        public bool ReceivedReset
        {
            get { lock (_sync) { return _receivedReset; } }
            set { lock (_sync) { _receivedReset = value; } }
        }

        public bool SentLogon
        {
            get { lock (_sync) { return _sentLogon; } }
            set { lock (_sync) { _sentLogon = value; } }
        }

        public bool SentLogout
        {
            get { lock (_sync) { return _sentLogout; } }
            set { lock (_sync) { _sentLogout = value; } }
        }

        public bool SentReset
        {
            get { lock (_sync) { return _sentReset; } }
            set { lock (_sync) { _sentReset = value; } }
        }

        public string LogoutReason
        {
            get { lock (_sync) { return _logoutReason; } }
            set { lock (_sync) { _logoutReason = value; } }
        }

        public int TestRequestCounter
        {
            get { lock (_sync) { return _testRequestCounter; } }
            set { lock (_sync) { _testRequestCounter = value; } }
        }

        public int HeartBtInt
        {
            get { lock (_sync) { return _heartBtInt; } }
            set { lock (_sync) { _heartBtInt = value; _heartBtIntAsMilliSecs = 1000 * value; } }
        }

        public int HeartBtIntAsMilliSecs
        {
            get { lock (_sync) { return _heartBtIntAsMilliSecs; } }
        }

        public DateTime LastReceivedTimeDT
        {
            get { lock (_sync) { return _lastReceivedTimeDt; } }
            set { lock (_sync) { _lastReceivedTimeDt = value; } }
        }


        public DateTime LastSentTimeDT
        {
            get { lock (_sync) { return _lastSentTimeDt; } }
            set { lock (_sync) { _lastSentTimeDt = value; } }
        }

        public int LogonTimeout
        {
            get { lock (_sync) { return _logonTimeout; } }
            set { lock (_sync) { _logonTimeout = value; _logonTimeoutAsMilliSecs = 1000 * value; } }
        }

        public long LogonTimeoutAsMilliSecs
        {
            get { lock (_sync) { return _logonTimeoutAsMilliSecs; } }
        }

        public int LogoutTimeout
        {
            get { lock (_sync) { return _logoutTimeout; } }
            set { lock (_sync) { _logoutTimeout = value; _logoutTimeoutAsMilliSecs = 1000 * value; } }
        }

        public long LogoutTimeoutAsMilliSecs
        {
            get { lock (_sync) { return _logoutTimeoutAsMilliSecs; } }
        }

        private MessagesBySeqNum MsgQueue
        {
            get { lock (_sync) { return _msgQueue; } }
            set { lock (_sync) { _msgQueue = value; } }
        }

        #endregion

        public SessionState(bool isInitiator, ILog log, int heartBtInt, IMessageStore messageStore)
        {
            Log = log;
            HeartBtInt = heartBtInt;
            IsInitiator = isInitiator;
            _lastReceivedTimeDt = DateTime.UtcNow;
            _lastSentTimeDt = DateTime.UtcNow;
            MessageStore = messageStore;
        }

        /// <summary>
        /// All time args are in milliseconds
        /// </summary>
        /// <param name="now">current system time</param>
        /// <param name="lastReceivedTime">last received time</param>
        /// <param name="logonTimeout">number of milliseconds to wait for a Logon from the counterparty</param>
        /// <returns></returns>
        public static bool LogonTimedOut(DateTime now, long logonTimeout, DateTime lastReceivedTime)
        {
            return now.Subtract(lastReceivedTime).TotalMilliseconds >= logonTimeout;
        }
        public bool LogonTimedOut()
        {
            return LogonTimedOut(DateTime.UtcNow, LogonTimeoutAsMilliSecs, LastReceivedTimeDT);
        }

        /// <summary>
        /// All time args are in milliseconds
        /// </summary>
        /// <param name="now">current system datetime</param>
        /// <param name="heartBtIntMillis">heartbeat interval in milliseconds</param>
        /// <param name="lastReceivedTime">last received datetime</param>
        /// <returns>true if timed out</returns>
        public static bool TimedOut(DateTime now, int heartBtIntMillis, DateTime lastReceivedTime)
        {
            double elapsed = now.Subtract(lastReceivedTime).TotalMilliseconds;
            return elapsed >= (2.4 * heartBtIntMillis);
        }
        public bool TimedOut()
        {
            return TimedOut(DateTime.UtcNow, HeartBtIntAsMilliSecs, LastReceivedTimeDT);
        }

        /// <summary>
        /// All time args are in milliseconds
        /// </summary>
        /// <param name="now">current system time</param>
        /// <param name="sentLogout">true if a Logout has been sent to the counterparty, otherwise false</param>
        /// <param name="logoutTimeout">number of milliseconds to wait for a Logout from the counterparty</param>
        /// <param name="lastSentTime">last sent time</param>
        /// <returns></returns>
        public static bool LogoutTimedOut(DateTime now, bool sentLogout, long logoutTimeout, DateTime lastSentTime)
        {
            return sentLogout && (now.Subtract(lastSentTime).TotalMilliseconds >= logoutTimeout);
        }
        public bool LogoutTimedOut()
        {
            return LogoutTimedOut(DateTime.UtcNow, SentLogout, LogoutTimeoutAsMilliSecs, LastSentTimeDT);
        }

        /// <summary>
        /// All time args are in milliseconds
        /// </summary>
        /// <param name="now">current system time</param>
        /// <param name="heartBtIntMillis">heartbeat interval in milliseconds</param>
        /// <param name="lastReceivedTime">last received time</param>
        /// <param name="testRequestCounter">test request counter</param>
        /// <returns>true if test request is needed</returns>
        public static bool NeedTestRequest(DateTime now, int heartBtIntMillis, DateTime lastReceivedTime, int testRequestCounter)
        {
            double elapsedMilliseconds = now.Subtract(lastReceivedTime).TotalMilliseconds;
            return elapsedMilliseconds >= (1.2 * ((testRequestCounter + 1) * heartBtIntMillis));
        }
        public bool NeedTestRequest()
        {
            return NeedTestRequest(DateTime.UtcNow, HeartBtIntAsMilliSecs, LastReceivedTimeDT, TestRequestCounter);
        }

        /// <summary>
        /// All time args are in milliseconds
        /// </summary>
        /// <param name="now">current system time</param>
        /// <param name="heartBtIntMillis">heartbeat interval in milliseconds</param>
        /// <param name="lastSentTime">last sent time</param>
        /// <param name="testRequestCounter">test request counter</param>
        /// <returns>true if heartbeat is needed</returns>
        public static bool NeedHeartbeat(DateTime now, int heartBtIntMillis, DateTime lastSentTime, int testRequestCounter)
        {
            double elapsed = now.Subtract(lastSentTime).TotalMilliseconds;
            return (elapsed >= Convert.ToDouble(heartBtIntMillis)) && (0 == testRequestCounter);
        }
        public bool NeedHeartbeat()
        {
            return NeedHeartbeat(DateTime.UtcNow, HeartBtIntAsMilliSecs, LastSentTimeDT, TestRequestCounter);
        }

        /// <summary>
        /// All time args are in milliseconds
        /// </summary>
        /// <param name="now">current system time</param>
        /// <param name="heartBtIntMillis">heartbeat interval in milliseconds</param>
        /// <param name="lastSentTime">last sent time</param>
        /// <param name="lastReceivedTime">last received time</param>
        /// <returns>true if within heartbeat interval</returns>
        public static bool WithinHeartbeat(DateTime now, int heartBtIntMillis, DateTime lastSentTime, DateTime lastReceivedTime)
        {
            return (now.Subtract(lastSentTime).TotalMilliseconds < Convert.ToDouble(heartBtIntMillis))
                && (now.Subtract(lastReceivedTime).TotalMilliseconds < Convert.ToDouble(heartBtIntMillis));
        }
        public bool WithinHeartbeat()
        {
            return WithinHeartbeat(DateTime.UtcNow, HeartBtIntAsMilliSecs, LastSentTimeDT, LastReceivedTimeDT);
        }

        public ResendRange GetResendRange()
        {
            return _resendRange;
        }

        public void Get(SeqNumType begSeqNo, SeqNumType endSeqNo, List<string> messages)
        {
            lock (_sync)
            {
              MessageStore.Get(begSeqNo, endSeqNo, messages);
            }
        }

        public void SetResendRange(SeqNumType begin, SeqNumType end, SeqNumType chunkEnd = ResendRange.NOT_SET)
        {
            _resendRange.BeginSeqNo = begin;
            _resendRange.EndSeqNo = end;
            _resendRange.ChunkEndSeqNo = chunkEnd == ResendRange.NOT_SET ? end : chunkEnd;
        }

        public bool ResendRequested()
        {
            return !(_resendRange.BeginSeqNo == 0 && _resendRange.EndSeqNo == 0);
        }

        public void Queue(SeqNumType msgSeqNum, Message msg)
        {
            if (!MsgQueue.ContainsKey(msgSeqNum))
            {
                MsgQueue.Add(msgSeqNum, msg);
            }
        }

        public void ClearQueue()
        {
            MsgQueue.Clear();
        }

        public QuickFix.Message? Dequeue(SeqNumType num)
        {
            if (MsgQueue.ContainsKey(num))
            {
                QuickFix.Message msg = MsgQueue[num];
                MsgQueue.Remove(num);
                return msg;
            }
            return null;
        }

        public Message? Retrieve(SeqNumType msgSeqNum)
        {
            if (MsgQueue.ContainsKey(msgSeqNum))
            {
                Message msg = MsgQueue[msgSeqNum];
                MsgQueue.Remove(msgSeqNum);
                return msg;
            }

            return null;
        }

        /// <summary>
        /// All time values are displayed in milliseconds.
        /// </summary>
        /// <returns>a string that represents the session state</returns>
        public override string ToString()
        {
            return new System.Text.StringBuilder("SessionState ")
                .Append("[ Now=").Append(DateTime.UtcNow)
                .Append(", HeartBtInt=").Append(HeartBtIntAsMilliSecs)
                .Append(", LastSentTime=").Append(LastSentTimeDT)
                .Append(", LastReceivedTime=").Append(LastReceivedTimeDT)
                .Append(", TestRequestCounter=").Append(TestRequestCounter)
                .Append(", WithinHeartbeat=").Append(WithinHeartbeat())
                .Append(", NeedHeartbeat=").Append(NeedHeartbeat())
                .Append(", NeedTestRequest=").Append(NeedTestRequest())
                .Append(", ResendRange=").Append(GetResendRange())
                .Append(" ]").ToString();

        }

        #region MessageStore-manipulating Members

        public bool Set(SeqNumType msgSeqNum, string msg)
        {
            lock (_sync) { return MessageStore.Set(msgSeqNum, msg); }
        }

        public SeqNumType NextSenderMsgSeqNum
        {
            get { lock (_sync) { return MessageStore.NextSenderMsgSeqNum; } }
            set { lock (_sync) { MessageStore.NextSenderMsgSeqNum = value; } }
        }

        public SeqNumType NextTargetMsgSeqNum
        {
            get { lock (_sync) { return MessageStore.NextTargetMsgSeqNum; } }
            set { lock (_sync) { MessageStore.NextTargetMsgSeqNum = value; } }
        }

        public void IncrNextSenderMsgSeqNum()
        {
            lock (_sync) { MessageStore.IncrNextSenderMsgSeqNum(); }
        }

        public void IncrNextTargetMsgSeqNum()
        {
            lock (_sync) { MessageStore.IncrNextTargetMsgSeqNum(); }
        }

        public DateTime? CreationTime
        {
            get
            {
                lock (_sync) { return MessageStore.CreationTime; }
            }
        }

        /// <summary>
        /// Reset the MessageStore
        /// </summary>
        /// <param name="reason">this is for the log statement</param>
        public void Reset(string reason)
        {
            lock (_sync)
            {
                MessageStore.Reset();
                Log.OnEvent("Session reset: " + reason);
            }
        }

        public void Refresh()
        {
            lock (_sync) { MessageStore.Refresh(); }
        }

        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                Log.Dispose();
                MessageStore.Dispose();
            }
            _disposed = true;
        }

        ~SessionState() => Dispose(false);
    }
}
