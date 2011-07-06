using System.Collections.Generic;

namespace QuickFix
{
    public class SessionState : MessageStore
    {
        #region Private Members

        private object sync_ = new object();
        private bool isEnabled_ = true;
        private bool receivedLogon_ = false;
        private bool receivedReset_ = false;
        private string logoutReason_ = "";
        private int testRequestCounter_ = 0;
        private int nextSenderMsgSeqNum_ = 1;
        private Log log_;

        #endregion

        #region Unsynchronized Properties

        public bool IsInitiator
        { get; set; }

        public bool ShouldSendLogon
        { get { return IsInitiator && !SentLogon; } }

        public bool SentLogon
        { get; set; }

        public bool SentReset
        { get; set; }

        public int HeartBtInt
        { get; set; }

        public Log Log
        { get { return log_; } }

        public int LastSentTimeTickCount
        { get; set; }

        public int LastReceivedTimeTickCount
        { get; set; }

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

        public int NextSenderMsgSeqNum
        {
            get { lock (sync_) { return nextSenderMsgSeqNum_; } }
        }

        #endregion

        public SessionState(Log log, int heartBtInt)
        {
            log_ = log;
            this.IsInitiator = (0 != heartBtInt);
            this.HeartBtInt = heartBtInt;
        }

        /// <summary>
        /// FIXME
        /// </summary>
        public void Reset()
        {
            // messageStore_.Reset();
        }

        /// <summary>
        /// FIXME
        /// </summary>
        /// <returns></returns>
        public bool LogonTimedOut()
        {
            return false;
        }

        public bool TimedOut()
        {
            int nowTickCount = System.Environment.TickCount;
            double heartBtIntAsTickCount = 1000.0 * this.HeartBtInt;
            int elapsedTickCount = nowTickCount - this.LastReceivedTimeTickCount;
            return elapsedTickCount >= (2.4 * heartBtIntAsTickCount);
        }

        public bool NeedTestRequest()
        {
            int nowTickCount = System.Environment.TickCount;
            double heartBtIntAsTickCount = 1000.0 * this.HeartBtInt;
            int elapsedTickCount = nowTickCount - this.LastReceivedTimeTickCount;
            return elapsedTickCount >= ((1.2 * ((double)this.TestRequestCounter + 1)) * heartBtIntAsTickCount);
        }

        public bool NeedHeartbeat()
        {
            int nowTickCount = System.Environment.TickCount;
            int elapsedTickCount = nowTickCount - this.LastSentTimeTickCount;
            int heartBtIntAsTickCount = 1000 * this.HeartBtInt;
            return (elapsedTickCount >= heartBtIntAsTickCount && 0 == this.TestRequestCounter);
        }

        public bool WithinHeartbeat()
        {
            int nowTickCount = System.Environment.TickCount;
            int heartBtIntAsTickCount = 1000 * this.HeartBtInt;

            return ((nowTickCount - this.LastSentTimeTickCount) < heartBtIntAsTickCount)
                && ((nowTickCount - this.LastReceivedTimeTickCount) < heartBtIntAsTickCount);
        }

        public void IncrNextTargetMsgSeqNum()
        {
            lock (sync_)
            {
                ///FIXME
            }
        }
    }
}
