using System;
using System.Collections.Generic;
using System.Text;
using QuickFix.Util;

namespace QuickFix
{
    /// <summary>
    /// File store implementation
    /// </summary>
    public class FileStore : IMessageStore
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
        private string sessionFileName_;

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

            if (SessionID.IsSet(sessionID.SessionQualifier))
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
            sessionFileName_ = System.IO.Path.Combine(path, prefix + ".session");

            open();
        }

        private void open()
        {
            ConstructFromFileCache();
            InitializeSessionCreateTime();

            seqNumsFile_ = new System.IO.FileStream(seqNumsFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            msgFile_ = new System.IO.FileStream(msgFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
#if !NETSTANDARD1_6
            headerFile_ = new System.IO.StreamWriter(headerFileName_, true);
#else
            headerFile_ = new System.IO.StreamWriter(System.IO.File.Open(headerFileName_, System.IO.FileMode.Append));
#endif
        }

        private void PurgeSingleFile(System.IO.Stream stream, string filename)
        {
#if !NETSTANDARD1_6
            if (stream != null)
                stream.Close();
#else
            if (stream != null)
                stream.Dispose();
#endif
            if (System.IO.File.Exists(filename))
                System.IO.File.Delete(filename);
        }

        private void PurgeSingleFile(System.IO.StreamWriter stream, string filename)
        {
#if !NETSTANDARD1_6
            if (stream != null)
                stream.Close();
#else
            if (stream != null)
                stream.Dispose();
#endif
            if (System.IO.File.Exists(filename))
                System.IO.File.Delete(filename);
        }

        private void PurgeSingleFile(string filename)
        {
            if (System.IO.File.Exists(filename))
                System.IO.File.Delete(filename);
        }

        private void PurgeFileCache()
        {
            PurgeSingleFile(seqNumsFile_, seqNumsFileName_);
            PurgeSingleFile(msgFile_, msgFileName_);
            PurgeSingleFile(headerFile_, headerFileName_);
            PurgeSingleFile(sessionFileName_);
        }


        private void ConstructFromFileCache()
        {
            offsets_.Clear();
            if (System.IO.File.Exists(headerFileName_))
            {
#if !NETSTANDARD1_6
                using (System.IO.StreamReader reader = new System.IO.StreamReader(headerFileName_))
#else
                using (System.IO.StreamReader reader = new System.IO.StreamReader(System.IO.File.OpenRead(headerFileName_)))
#endif
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
#if !NETSTANDARD1_6
                using (System.IO.StreamReader seqNumReader = new System.IO.StreamReader(seqNumsFileName_))
#else
                using (System.IO.StreamReader seqNumReader = new System.IO.StreamReader(System.IO.File.OpenRead(seqNumsFileName_)))
#endif
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

        private void InitializeSessionCreateTime()
        {
            if (System.IO.File.Exists(sessionFileName_) && new System.IO.FileInfo(sessionFileName_).Length > 0)
            {
#if !NETSTANDARD1_6
                using (System.IO.StreamReader reader = new System.IO.StreamReader(sessionFileName_))
#else
                using (System.IO.StreamReader reader = new System.IO.StreamReader(System.IO.File.OpenRead(sessionFileName_)))
#endif
                {
                    string s = reader.ReadToEnd();
                    cache_.CreationTime = UtcDateTimeSerializer.FromString(s);
                }
            }
            else
            {
#if !NETSTANDARD1_6
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(sessionFileName_, false))
#else
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(System.IO.File.Open(sessionFileName_, System.IO.FileMode.Create)))
#endif
                {
                    writer.Write(UtcDateTimeSerializer.ToString(cache_.CreationTime.Value));
                }
            }
        }


#region MessageStore Members

        /// <summary>
        /// Get messages within the range of sequence numbers
        /// </summary>
        /// <param name="startSeqNum"></param>
        /// <param name="endSeqNum"></param>
        /// <param name="messages"></param>
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
        
        /// <summary>
        /// Store a message
        /// </summary>
        /// <param name="msgSeqNum"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
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

            writer.Write(GetNextSenderMsgSeqNum().ToString("D10") + " : " + GetNextTargetMsgSeqNum().ToString("D10") + "  ");
            writer.Flush();
        }

        public DateTime? CreationTime
        {
            get
            {
                return cache_.CreationTime;
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
            seqNumsFile_.Dispose();
            msgFile_.Dispose();
            headerFile_.Dispose();
        }

#endregion
    }
}
