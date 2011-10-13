using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    class FileStore : MessageStore
    {
        public FileStore(string path, SessionID sessionID)
        {

        }

        #region MessageStore Members

        public bool Get(int startSeqNum, int endSeqNum, List<string> messages)
        {
            throw new NotImplementedException();
        }

        public bool Set(int msgSeqNum, string msg)
        {
            throw new NotImplementedException();
        }

        public int GetNextSenderMsgSeqNum()
        {
            throw new NotImplementedException();
        }

        public int GetNextTargetMsgSeqNum()
        {
            throw new NotImplementedException();
        }

        public void SetNextSenderMsgSeqNum(int value)
        {
            throw new NotImplementedException();
        }

        public void SetNextTargetMsgSeqNum(int value)
        {
            throw new NotImplementedException();
        }

        public void IncrNextSenderMsgSeqNum()
        {
            throw new NotImplementedException();
        }

        public void IncrNextTargetMsgSeqNum()
        {
            throw new NotImplementedException();
        }

        public DateTime GetCreationTime()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
