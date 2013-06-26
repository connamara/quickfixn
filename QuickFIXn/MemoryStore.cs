using System;
using System.Collections.Generic;

namespace QuickFix
{
    /// <summary>
    /// In-memory message store implementation
    /// </summary>
    public class MemoryStore : IMessageStore
    {
        #region Private Members

        System.Collections.Generic.Dictionary<int, string> messages_;
        int nextSenderMsgSeqNum_;
        int nextTargetMsgSeqNum_;
        DateTime? creationTime;

        #endregion

        public MemoryStore()
        {
            messages_ = new System.Collections.Generic.Dictionary<int, string>();
            Reset();
        }

        public void Get(int begSeqNo, int endSeqNo, List<string> messages)
        {
            for (int current = begSeqNo; current <= endSeqNo; current++)
            {
                if (messages_.ContainsKey(current))
                    messages.Add(messages_[current]);
            }
        }

        #region MessageStore Members

        public bool Set(int msgSeqNum, string msg)
        {
            messages_[msgSeqNum] = msg;
            return true;
        }

        public int GetNextSenderMsgSeqNum()
        { return nextSenderMsgSeqNum_; }

        public int GetNextTargetMsgSeqNum()
        { return nextTargetMsgSeqNum_; }

        public void SetNextSenderMsgSeqNum(int value)
        { nextSenderMsgSeqNum_ = value; }

        public void SetNextTargetMsgSeqNum(int value)
        { nextTargetMsgSeqNum_ = value; }

        public void IncrNextSenderMsgSeqNum()
        { ++nextSenderMsgSeqNum_; }

        public void IncrNextTargetMsgSeqNum()
        { ++nextTargetMsgSeqNum_; }

        public System.DateTime? CreationTime
        {
            get { return creationTime; }
            internal set { creationTime = value; }
        }

        [System.Obsolete("Use CreationTime instead")]
        public DateTime GetCreationTime()
        {
            throw new NotImplementedException();
        }


        public void Reset()
        {
            nextSenderMsgSeqNum_ = 1;
            nextTargetMsgSeqNum_ = 1;
            messages_.Clear();
            creationTime = DateTime.UtcNow;
        }

        public void Refresh()
        { }

        public void Dispose()
        { }

        #endregion
    }
}
