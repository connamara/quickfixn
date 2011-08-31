using System.Collections.Generic;

namespace QuickFix
{
    public interface MessageStore
    {
        bool Get(int startSeqNum, int endSeqNum, List<string> messages);
        bool Set(int msgSeqNum, string msg);
        int GetNextSenderMsgSeqNum();
        int GetNextTargetMsgSeqNum();
        void SetNextSenderMsgSeqNum(int value);
        void SetNextTargetMsgSeqNum(int value);
        void IncrNextSenderMsgSeqNum();
        void IncrNextTargetMsgSeqNum();
        System.DateTime GetCreationTime();
        void Reset();
        void Refresh();
    }
}
