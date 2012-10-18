using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// File store implementation
    /// </summary>
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

        private string seqNumsFileName_;
        private string msgFileName_;
        private string headerFileName_;

        private System.IO.FileStream seqNumsFile_;
        private System.IO.FileStream msgFile_;

        private System.IO.StreamWriter headerFile_;

        private MemoryStore cache_ = new MemoryStore();

        System.Collections.Generic.Dictionary<int, MsgDef> offsets_ = new Dictionary<int, MsgDef>();

        public static string Prefix(SessionID sessionID)
        {
            System.Text.StringBuilder prefix = new System.Text.StringBuilder(sessionID.BeginString)
                .Append('-').Append(sessionID.SenderCompID);
            if (SessionID.IsSet(sessionID.SenderSubID))
                prefix.Append('_').Append(sessionID.SenderSubID);
            if (SessionID.IsSet(sessionID.SenderLocationID))
                prefix.Append('_').Append(sessionID.SenderLocationID);
            prefix.Append('-').Append(sessionID.TargetCompID);
            if (SessionID.IsSet(sessionID.TargetSubID))
                prefix.Append('_').Append(sessionID.TargetSubID);
            if (SessionID.IsSet(sessionID.TargetLocationID))
                prefix.Append('_').Append(sessionID.TargetLocationID);

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
            ConstructFromFileCache();

            seqNumsFile_ = new System.IO.FileStream(seqNumsFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            msgFile_ = new System.IO.FileStream(msgFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            headerFile_ = new System.IO.StreamWriter(headerFileName_, true);
        }

        private void PurgeFileCache()
        {
            if (seqNumsFile_ != null)
                seqNumsFile_.Close();

            if (msgFile_ != null)
                msgFile_.Close();

            if (headerFile_ != null)
                headerFile_.Close();

            if (System.IO.File.Exists(seqNumsFileName_))
                System.IO.File.Delete(seqNumsFileName_);

            if (System.IO.File.Exists(headerFileName_))
                System.IO.File.Delete(headerFileName_);

            if (System.IO.File.Exists(msgFileName_))
                System.IO.File.Delete(msgFileName_);
        }

        private void ConstructFromFileCache()
        {
            offsets_.Clear();
            if (System.IO.File.Exists(headerFileName_))
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(headerFileName_))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
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

            if (System.IO.File.Exists(seqNumsFileName_))
            {
                using (System.IO.StreamReader seqNumReader = new System.IO.StreamReader(seqNumsFileName_))
                {
                    string[] parts = seqNumReader.ReadToEnd().Split(':');
                    if (parts.Length == 2)
                    {
                        cache_.SetNextSenderMsgSeqNum(Convert.ToInt32(parts[0]));
                        cache_.SetNextTargetMsgSeqNum(Convert.ToInt32(parts[1]));
                    }
                }
            }
        }




        #region MessageStore Members

        public void Get(int startSeqNum, int endSeqNum, List<string> messages)
        {
            for (int i = startSeqNum; i <= endSeqNum; i++)
            {
                if (offsets_.ContainsKey(i))
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

            offsets_[msgSeqNum] = new MsgDef(offset, size);

            msgFile_.Write(msgBytes, 0, size);
            msgFile_.Flush();


            return true;
        }

        public int GetNextSenderMsgSeqNum()
        {
            return cache_.GetNextSenderMsgSeqNum();
        }

        public int GetNextTargetMsgSeqNum()
        {
            return cache_.GetNextTargetMsgSeqNum();
        }

        public void SetNextSenderMsgSeqNum(int value)
        {
            cache_.SetNextSenderMsgSeqNum(value);
            setSeqNum();
        }

        public void SetNextTargetMsgSeqNum(int value)
        {
            cache_.SetNextTargetMsgSeqNum(value);
            setSeqNum();
        }

        public void IncrNextSenderMsgSeqNum()
        {
            cache_.IncrNextSenderMsgSeqNum();
            setSeqNum();
        }

        public void IncrNextTargetMsgSeqNum()
        {
            cache_.IncrNextTargetMsgSeqNum();
            setSeqNum();
        }

        private void setSeqNum()
        {
            seqNumsFile_.Seek(0, System.IO.SeekOrigin.Begin);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(seqNumsFile_);

            writer.Write(GetNextSenderMsgSeqNum().ToString("D10") + " : " + GetNextTargetMsgSeqNum().ToString("D10"));
            writer.Flush();
        }

        public DateTime? CreationTime
        {
            get
            {
                if (System.IO.File.Exists(seqNumsFileName_))
                {
                    return System.IO.File.GetCreationTimeUtc(seqNumsFileName_);
                }
                else
                    return null;
            }
        }

        [System.Obsolete("Use CreationTime instead")]
        public DateTime GetCreationTime()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            cache_.Reset();
            PurgeFileCache();
            open();
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
