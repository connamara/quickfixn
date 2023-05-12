using System;
using System.Collections.Generic;
using SeqNumType = System.UInt64;

namespace QuickFix
{
    /// <summary>
    /// In-memory message store implementation
    /// </summary>
    public class MemoryStore : IMessageStore
    {
        #region Private Members

        System.Collections.Generic.Dictionary<SeqNumType, string> messages_;
        DateTime? creationTime;

        #endregion

        public MemoryStore()
        {
            messages_ = new System.Collections.Generic.Dictionary<SeqNumType, string>();
            Reset();
        }

        public void Get(SeqNumType begSeqNo, SeqNumType endSeqNo, List<string> messages)
        {
            for (SeqNumType current = begSeqNo; current <= endSeqNo; current++)
            {
                if (messages_.ContainsKey(current))
                    messages.Add(messages_[current]);
            }
        }

        #region MessageStore Members

        public bool Set(SeqNumType msgSeqNum, string msg)
        {
            messages_[msgSeqNum] = msg;
            return true;
        }

        public SeqNumType NextSenderMsgSeqNum { get; set; }
        public SeqNumType NextTargetMsgSeqNum { get; set; }

        public void IncrNextSenderMsgSeqNum()
        { ++NextSenderMsgSeqNum; }

        public void IncrNextTargetMsgSeqNum()
        { ++NextTargetMsgSeqNum; }

        public System.DateTime? CreationTime
        {
            get { return creationTime; }
            internal set { creationTime = value; }
        }

        public void Reset()
        {
            NextSenderMsgSeqNum = 1;
            NextTargetMsgSeqNum = 1;
            messages_.Clear();
            creationTime = DateTime.UtcNow;
        }

        public void Refresh()
        { }

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
                messages_ = null;
            }
            _disposed = true;
        }

        ~MemoryStore() => Dispose(false);
        #endregion
    }
}
