using System.Collections.Generic;
using System;

namespace QuickFix
{
    /// <summary>
    /// Used by the session communications code. Not intended to be used by applications.
    /// </summary>
    public class SessionState : MessageStore
    {
        #region Private Members

        private object sync_ = new object();
        private bool isEnabled_ = true;
        private bool receivedLogon_ = false;
        private bool receivedReset_ = false;
        private bool sentLogon_ = false;
        private bool sentLogout_ = false;
        private bool sentReset_ = false;
        private string logoutReason_ = "";
        private int testRequestCounter_ = 0;
        private int heartBtInt_ = 0;
        private int heartBtIntAsTickCount_ = 0;
        private DateTime lastReceivedTimeDT_ = DateTime.MinValue;
        private DateTime lastSentTimeDT_ = DateTime.MinValue;
        private int logonTimeout_ = 10;
        private long logonTimeoutAsTickCount_ = 10 * 1000;
        private int logoutTimeout_ = 2;
        private long logoutTimeoutAsTickCount_ = 2 * 1000;
        private ResendRange resendRange_ = new ResendRange(0,0);
        private Dictionary<int, Message> msgQueue = new Dictionary<int, Message>();

        private Log log_;

        #endregion

        #region Unsynchronized Properties

        public MessageStore MessageStore
        { get; set; }

        public bool IsInitiator
        { get; set; }

        public bool ShouldSendLogon
        { get { return IsInitiator && !SentLogon; } }

        public Log Log
        { get { return log_; } }

        #endregion

        #region Synchronized Properties

        public bool IsEnabled
        {
            get { lock (sync_) { return isEnabled_; } }
            set { lock (sync_) { isEnabled_ = value; } }
        }

        public bool ReceivedLogon
        {
            get { lock (sync_) { return receivedLogon_; } }
            set { lock (sync_) { receivedLogon_ = value; } }
        }

        public bool ReceivedReset
        {
            get { lock (sync_) { return receivedReset_; } }
            set { lock (sync_) { receivedReset_ = value; } }
        }

        public bool SentLogon
        {
            get { lock (sync_) { return sentLogon_; } }
            set { lock (sync_) { sentLogon_ = value; } }
        }

        public bool SentLogout
        {
            get { lock (sync_) { return sentLogout_; } }
            set { lock (sync_) { sentLogout_ = value; } }
        }

        public bool SentReset
        {
            get { lock (sync_) { return sentReset_; } }
            set { lock (sync_) { sentReset_ = value; } }
        }

        public string LogoutReason
        {
            get { lock (sync_) { return logoutReason_; } }
            set { lock (sync_) { logoutReason_ = value; } }
        }

        public int TestRequestCounter
        {
            get { lock (sync_) { return testRequestCounter_; } }
            set { lock (sync_) { testRequestCounter_ = value; } }
        }

        public int HeartBtInt
        {
            get { lock (sync_) { return heartBtInt_; } }
            set { lock (sync_) { heartBtInt_ = value; heartBtIntAsTickCount_ = 1000 * value;  } }
        }

        public int HeartBtIntAsTickCount
        {
            get { lock (sync_) { return heartBtIntAsTickCount_; } }
        }

        public DateTime LastReceivedTimeDT
        {
            get { lock (sync_) { return lastReceivedTimeDT_; } }
            set { lock (sync_) { lastReceivedTimeDT_ = value; } }
        }


        public DateTime LastSentTimeDT
        {
            get { lock (sync_) { return lastSentTimeDT_; } }
            set { lock (sync_) { lastSentTimeDT_ = value; } }
        }

        public int LogonTimeout
        {
            get { lock (sync_) { return logonTimeout_; } }
            set { lock (sync_) { logonTimeout_ = value; logonTimeoutAsTickCount_ = 1000 * value; } }
        }

        public long LogonTimeoutAsTickCount
        {
            get { lock (sync_) { return logonTimeoutAsTickCount_; } }
        }

        public int LogoutTimeout
        {
            get { lock (sync_) { return logoutTimeout_; } }
            set { lock (sync_) { logoutTimeout_ = value; logoutTimeoutAsTickCount_ = 1000 * value; } }
        }

        public long LogoutTimeoutAsTickCount
        {
            get { lock (sync_) { return logoutTimeoutAsTickCount_; } }
        }

        private Dictionary<int, Message> MsgQueue
        {
            get { lock (sync_) { return msgQueue; } }
            set { lock (sync_) { msgQueue = value; } }
        }

        #endregion

        public SessionState(Log log, int heartBtInt)
        {
            log_ = log;
            this.HeartBtInt = heartBtInt;
            this.IsInitiator = (0 != heartBtInt);
            int now = System.Environment.TickCount;
            lastReceivedTimeDT_ = DateTime.Now;
            lastSentTimeDT_ = DateTime.Now;
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
            return (now.Subtract(lastReceivedTime).TotalMilliseconds) >= logonTimeout;
        }
        public bool LogonTimedOut()
        {
            return LogonTimedOut(DateTime.Now, this.LogonTimeoutAsTickCount, this.LastReceivedTimeDT);
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
            int elapsed = Convert.ToInt32(now.Subtract(lastReceivedTime).TotalMilliseconds);
            return elapsed >= (2.4 * heartBtIntMillis);
        }
        public bool TimedOut()
        {
            return TimedOut(DateTime.Now, this.HeartBtIntAsTickCount, this.LastReceivedTimeDT);
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
            return sentLogout && ((now.Subtract(lastSentTime).TotalMilliseconds) >= logoutTimeout);
        }
        public bool LogoutTimedOut()
        {
            return LogoutTimedOut(DateTime.Now, this.SentLogout, this.LogoutTimeoutAsTickCount, this.LastSentTimeDT);
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
            int elapsedTickCount = Convert.ToInt32(now.Subtract(lastReceivedTime).TotalMilliseconds);
            return elapsedTickCount >= (1.2 * ((testRequestCounter + 1) * heartBtIntMillis));
        }
        public bool NeedTestRequest()
        {
            return NeedTestRequest(DateTime.Now, this.HeartBtIntAsTickCount, this.LastReceivedTimeDT, this.TestRequestCounter);
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
            int elapsed = Convert.ToInt32(now.Subtract(lastSentTime).TotalMilliseconds);
            return (elapsed >= heartBtIntMillis) && (0 == testRequestCounter);
        }
        public bool NeedHeartbeat()
        {
            return NeedHeartbeat(DateTime.Now, this.HeartBtIntAsTickCount, this.LastSentTimeDT, this.TestRequestCounter);
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
            return ((Convert.ToInt32(now.Subtract(lastSentTime).TotalMilliseconds)) < heartBtIntMillis)
                && ((Convert.ToInt32(now.Subtract(lastReceivedTime).TotalMilliseconds)) < heartBtIntMillis);
        }
        public bool WithinHeartbeat()
        {
            return WithinHeartbeat(DateTime.Now, this.HeartBtIntAsTickCount, this.LastSentTimeDT, this.LastReceivedTimeDT);
        }

        public ResendRange GetResendRange()
        {
            return resendRange_;
        }

        public void Get(int begSeqNo, int endSeqNo, List<string> messages)
        {
            MessageStore.Get(begSeqNo, endSeqNo, messages);
        }

        public void SetResendRange(int begin, int end)
        {
            resendRange_.BeginSeqNo = begin;
            resendRange_.EndSeqNo = end;
        }

        public bool ResendRequested()
        {
            return !(resendRange_.BeginSeqNo == 0 && resendRange_.EndSeqNo == 0);
        }
        
        public void Queue(int msgSeqNum, Message msg)
        {
            MsgQueue.Add(msgSeqNum, msg);
        }

        public void ClearQueue()
        {
           MsgQueue.Clear();
        }

        public QuickFix.Message Dequeue(int num)
        {
            if(MsgQueue.ContainsKey(num))
            {
                QuickFix.Message msg = MsgQueue[num];
                MsgQueue.Remove(num);
                return msg;
            }
            return null;
        }

        public Message Retrieve(int msgSeqNum)
        {
            Message msg = null;
            if(MsgQueue.ContainsKey(msgSeqNum))
            {
                msg = MsgQueue[msgSeqNum];
                MsgQueue.Remove(msgSeqNum);
            }
            return msg;
        }

        /// <summary>
        /// All time values are displayed in milliseconds.
        /// </summary>
        /// <returns>a string that represents the session state</returns>
        public override string ToString()
        {
            return new System.Text.StringBuilder("SessionState ")
                .Append("[ Now=").Append(System.Environment.TickCount)
                .Append(", HeartBtInt=").Append(this.HeartBtIntAsTickCount)
                .Append(", LastSentTime=").Append(this.LastSentTimeDT.Ticks)
                .Append(", LastReceivedTime=").Append(this.LastReceivedTimeDT.Ticks)
                .Append(", TestRequestCounter=").Append(this.TestRequestCounter)
                .Append(", WithinHeartbeat=").Append(WithinHeartbeat())
                .Append(", NeedHeartbeat=").Append(NeedHeartbeat())
                .Append(", NeedTestRequest=").Append(NeedTestRequest())
                .Append(", ResendRange=").Append(GetResendRange())
                .Append(" ]").ToString();
            
        }

        #region MessageStore Members

        public bool Set(int msgSeqNum, string msg)
        {
            lock (sync_) { return this.MessageStore.Set(msgSeqNum, msg); }
        }

        public int GetNextSenderMsgSeqNum()
        {
            lock (sync_) { return this.MessageStore.GetNextSenderMsgSeqNum(); }
        }

        public int GetNextTargetMsgSeqNum()
        {
            lock (sync_) { return this.MessageStore.GetNextTargetMsgSeqNum(); }
        }

        public void SetNextSenderMsgSeqNum(int value)
        {
            lock (sync_) { this.MessageStore.SetNextSenderMsgSeqNum(value); }
        }

        public void SetNextTargetMsgSeqNum(int value)
        {
            lock (sync_) { this.MessageStore.SetNextTargetMsgSeqNum(value); }
        }

        public void IncrNextSenderMsgSeqNum()
        {
            lock (sync_) { this.MessageStore.IncrNextSenderMsgSeqNum(); }
        }

        public void IncrNextTargetMsgSeqNum()
        {
            lock (sync_) { this.MessageStore.IncrNextTargetMsgSeqNum(); }
        }

        public System.DateTime GetCreationTime()
        {
            lock (sync_) { return this.MessageStore.GetCreationTime(); }
        }

        public void Reset()
        {
            lock (sync_) { this.MessageStore.Reset(); }
        }

        public void Refresh()
        {
            lock (sync_) { this.MessageStore.Refresh(); }
        }

        #endregion
    }
}
