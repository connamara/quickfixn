
namespace QuickFix
{
    public class MemoryStore : MessageStore
    {
        #region Private Members

        System.Collections.Generic.Dictionary<int, string> messages_;
        int nextSenderMsgSeqNum_;
        int nextTargetMsgSeqNum_;

        #endregion

        public MemoryStore()
        {
            messages_ = new System.Collections.Generic.Dictionary<int, string>();
            Reset();
        }

        #region MessageStore Members

        public bool Set(int msgSeqNum, string msg)
        {
            messages_[msgSeqNum] = msg;
            return true;
        }

        public int GetNextSenderMsgSeqNum()
        { return nextSenderMsgSeqNum_;  }

        public int GetNextTargetMsgSeqNum()
        { return nextTargetMsgSeqNum_; }

        public void SetNextSenderMsgSeqNum(int value)
        { nextSenderMsgSeqNum_ = value; }

        public void SetNextTargetMsgSeqNum(int value)
        { nextTargetMsgSeqNum_ = value; }

        public void IncrNextSenderMsgSeqNum()
        { ++nextSenderMsgSeqNum_;  }

        public void IncrNextTargetMsgSeqNum()
        { ++nextTargetMsgSeqNum_; }

        public System.DateTime GetCreationTime()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            nextSenderMsgSeqNum_ = 1;
            nextTargetMsgSeqNum_ = 1;
            messages_.Clear();
        }

        public void Refresh()
        { }

        #endregion
    }
}
