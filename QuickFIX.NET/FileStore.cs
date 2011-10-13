using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public class FileStore : MessageStore, IDisposable
    {
        private class MsgDef
        {
            public long index { get; private set; }
            public int size { get; private set; }
            
            public MsgDef(long index, int size)
            {
                this.index = index;
                this.size = size;
            }
        }

        private System.IO.FileStream seqNumsFile_;
        private string seqNumsFileName_;

        private System.IO.FileStream msgFile_;
        private string msgFileName_;

        private System.IO.StreamWriter headerFile_;
        private string headerFileName_;

        private MemoryStore cache = new MemoryStore();

        System.Collections.Generic.Dictionary<int, MsgDef> offsets_ = 
            new Dictionary<int, MsgDef>();

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

            string prefix = Prefix(sessionID);

            seqNumsFileName_ = System.IO.Path.Combine(path, prefix + ".seqnums");
            msgFileName_ = System.IO.Path.Combine(path, prefix + ".body");
            headerFileName_ = System.IO.Path.Combine(path, prefix + ".header");

            open();
        }

        private void open()
        {
            seqNumsFile_ = new System.IO.FileStream(seqNumsFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            msgFile_ = new System.IO.FileStream(msgFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);

            if(System.IO.File.Exists(headerFileName_))
            {
                using(System.IO.StreamReader reader = new System.IO.StreamReader(headerFileName_))
                {
                    string line;
                    while((line = reader.ReadLine())!=null)
                    {
                        string[] headerParts = line.Split(',');
                        if (headerParts.Length == 3)
                        {
                            offsets_[Convert.ToInt32(headerParts[0])] = new MsgDef(
                                Convert.ToInt64(headerParts[1]), Convert.ToInt32(headerParts[2]));
                        }
                    }
                }
            }

            headerFile_ = new System.IO.StreamWriter(headerFileName_, true);

            System.IO.StreamReader seqNumReader = new System.IO.StreamReader(seqNumsFile_);
            string[] parts = seqNumReader.ReadToEnd().Split(':');
            if (parts.Length == 2)
            {
                cache.SetNextSenderMsgSeqNum(Convert.ToInt32(parts[0]));
                cache.SetNextTargetMsgSeqNum(Convert.ToInt32(parts[1]));
            }
        }




        #region MessageStore Members

        public void Get(int startSeqNum, int endSeqNum, List<string> messages)
        {
            for(int i = startSeqNum; i<=endSeqNum; i++)
            {
                if(offsets_.ContainsKey(i))
                {
                    msgFile_.Seek(offsets_[i].index, System.IO.SeekOrigin.Begin);
                    byte[] msgBytes = new byte[offsets_[i].size];
                    msgFile_.Read(msgBytes, 0, msgBytes.Length);

                    messages.Add(Encoding.UTF8.GetString(msgBytes));
                }
            }

        }

        public bool Set(int msgSeqNum, string msg)
        {
            msgFile_.Seek(0, System.IO.SeekOrigin.End);

            long offset = msgFile_.Position;
            byte[] msgBytes = Encoding.UTF8.GetBytes(msg);
            int size = msgBytes.Length;

            StringBuilder b = new StringBuilder();
            b.Append(msgSeqNum).Append(",").Append(offset).Append(",").Append(size);
            headerFile_.WriteLine(b.ToString());
            headerFile_.Flush();

            offsets_[msgSeqNum] = new MsgDef(offset,size);

            msgFile_.Write(msgBytes, 0, size);
            msgFile_.Flush();


            return true;
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
            seqNumsFile_.Seek(0, System.IO.SeekOrigin.Begin);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(seqNumsFile_);
            
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
            seqNumsFile_.Close();
            msgFile_.Close();
            headerFile_.Close();
        }

        #endregion
    }
}
