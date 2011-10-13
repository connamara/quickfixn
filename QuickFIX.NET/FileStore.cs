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

        private MemoryStore cache = new MemoryStore();

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
            open();
        }

        private void open()
        {
            seqNumsFile = new System.IO.FileStream(seqNumsFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);

            System.IO.StreamReader reader = new System.IO.StreamReader(seqNumsFile);
            
            string[] parts = reader.ReadToEnd().Split(':');
            if (parts.Length == 2)
            {
                cache.SetNextSenderMsgSeqNum(Convert.ToInt32(parts[0]));
                cache.SetNextTargetMsgSeqNum(Convert.ToInt32(parts[1]));
            }
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
            return cache.GetNextSenderMsgSeqNum();
        }

        public int GetNextTargetMsgSeqNum()
        {
            return cache.GetNextTargetMsgSeqNum();
        }

        public void SetNextSenderMsgSeqNum(int value)
        {
            cache.SetNextSenderMsgSeqNum(value);
            setSeqNum();
        }

        public void SetNextTargetMsgSeqNum(int value)
        {
            cache.SetNextTargetMsgSeqNum(value);
            setSeqNum();
        }

        public void IncrNextSenderMsgSeqNum()
        {
            cache.IncrNextSenderMsgSeqNum();
            setSeqNum();
        }

        public void IncrNextTargetMsgSeqNum()
        {
            cache.IncrNextTargetMsgSeqNum();
            setSeqNum();
        }

        private void setSeqNum()
        {
            seqNumsFile.Seek(0, System.IO.SeekOrigin.Begin);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(seqNumsFile);
            writer.Write(GetNextSenderMsgSeqNum().ToString("D10") + " : " + GetNextTargetMsgSeqNum().ToString("D10"));
            writer.Flush();
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
