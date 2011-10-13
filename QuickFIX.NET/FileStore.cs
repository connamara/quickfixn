using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public class FileStore : MessageStore, IDisposable
    {
        private System.IO.FileStream seqNumsFile;
        private string seqNumsFileName;

        public static string Prefix(SessionID sessionID)
        {
            System.Text.StringBuilder prefix = new System.Text.StringBuilder(sessionID.BeginString)
                .Append('-').Append(sessionID.SenderCompID)
                .Append('-').Append(sessionID.TargetCompID);

            if (sessionID.SessionQualifier.Length != 0)
                prefix.Append('-').Append(sessionID.SessionQualifier);

            return prefix.ToString();
        }

        public FileStore(string path, SessionID sessionID)
        {
            if (!System.IO.Directory.Exists(path))
                System.IO.Directory.CreateDirectory(path);

            seqNumsFileName = System.IO.Path.Combine(path, Prefix(sessionID)+".seqnums");
            seqNumsFile = new System.IO.FileStream(seqNumsFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
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

        #region IDisposable Members

        public void Dispose()
        {
            seqNumsFile.Close();
        }

        #endregion
    }
}
