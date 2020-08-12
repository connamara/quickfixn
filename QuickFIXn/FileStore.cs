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

        public const string WILDCARD_FILE_PREFIX = "DS_"; // Dynamic Session
        public const string WILDCARD_REPLACEMENT = "(ANY)";
        /// <summary>
        /// Calculates unique filename prefix from SessionID.
        /// Handles wildcards in SessionID fields
        /// </summary>
        /// <returns>Filename prefix unique for SessioID</returns>
        public static string Prefix(SessionID sessionID)
        {

            bool hasWildcard = false;

            System.Text.StringBuilder prefix = new System.Text.StringBuilder();
            if (Values.WILDCARD_VALUE.Equals(sessionID.BeginString))
            {
                hasWildcard = true;
                prefix.Append(WILDCARD_REPLACEMENT).Append('-');
            }
            else prefix.Append(sessionID.BeginString).Append('-');
            if (Values.WILDCARD_VALUE.Equals(sessionID.SenderCompID))
            {
                hasWildcard = true;
                prefix.Append(WILDCARD_REPLACEMENT);
            }
            else prefix.Append(sessionID.SenderCompID);


            if (SessionID.IsSet(sessionID.SenderSubID))
            {
                prefix.Append('_');
                if (Values.WILDCARD_VALUE.Equals(sessionID.SenderSubID))
                {
                    hasWildcard = true;
                    prefix.Append(WILDCARD_REPLACEMENT);
                }
                else prefix.Append(sessionID.SenderSubID);
            }
            if (SessionID.IsSet(sessionID.SenderLocationID))
            {
                prefix.Append('_');
                if (Values.WILDCARD_VALUE.Equals(sessionID.SenderLocationID))
                {
                    hasWildcard = true;
                    prefix.Append(WILDCARD_REPLACEMENT);
                }
                else prefix.Append(sessionID.SenderLocationID);
            }
            prefix.Append('-');
            if (Values.WILDCARD_VALUE.Equals(sessionID.TargetCompID))
            {
                hasWildcard = true;
                prefix.Append(WILDCARD_REPLACEMENT);
            }
            else prefix.Append(sessionID.TargetCompID);

            if (SessionID.IsSet(sessionID.TargetSubID))
            {
                prefix.Append('_');
                if (Values.WILDCARD_VALUE.Equals(sessionID.TargetSubID))
                {
                    hasWildcard = true;
                    prefix.Append(WILDCARD_REPLACEMENT);
                }
                else prefix.Append(sessionID.TargetSubID);
            }
            if (SessionID.IsSet(sessionID.TargetLocationID))
            {
                prefix.Append('_');
                if (Values.WILDCARD_VALUE.Equals(sessionID.TargetLocationID))
                {
                    hasWildcard = true;
                    prefix.Append(WILDCARD_REPLACEMENT);
                }
                else prefix.Append(sessionID.TargetLocationID);
            }
            // SessionQualifier now is not allowed for acceptor, so cannot be a wildcard,
            // still should not hurt to implement wildcard logic for it
            if (SessionID.IsSet(sessionID.SessionQualifier))
            {
                prefix.Append('-');
                if (Values.WILDCARD_VALUE.Equals(sessionID.SessionQualifier))
                {
                    hasWildcard = true;
                    prefix.Append(WILDCARD_REPLACEMENT);
                }
                else prefix.Append(sessionID.SessionQualifier);
            }
            // To guarantee unique file name,
            // even if someone uses WILDCARD_REPLACEMENT as a part if SessionID
            if (hasWildcard) return WILDCARD_FILE_PREFIX + prefix.ToString();
            // No wildcard(s) - no additional prefix 
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
            close();

            ConstructFromFileCache();
            InitializeSessionCreateTime();

            seqNumsFile_ = new System.IO.FileStream(seqNumsFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            msgFile_ = new System.IO.FileStream(msgFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            headerFile_ = new System.IO.StreamWriter(headerFileName_, true);
        }

        private void close()
        {
            seqNumsFile_?.Dispose();
            msgFile_?.Dispose();
            headerFile_?.Dispose();
        }

        private void PurgeSingleFile(System.IO.Stream stream, string filename)
        {
            if (stream != null)
                stream.Close();
            if (System.IO.File.Exists(filename))
                System.IO.File.Delete(filename);
        }

        private void PurgeSingleFile(System.IO.StreamWriter stream, string filename)
        {
            if (stream != null)
                stream.Close();
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

        private void InitializeSessionCreateTime()
        {
            if (System.IO.File.Exists(sessionFileName_) && new System.IO.FileInfo(sessionFileName_).Length > 0)
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(sessionFileName_))
                {
                    string s = reader.ReadToEnd();
                    cache_.CreationTime = UtcDateTimeSerializer.FromString(s);
                }
            }
            else
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(sessionFileName_, false))
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

                    messages.Add(CharEncoding.DefaultEncoding.GetString(msgBytes));
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
            byte[] msgBytes = CharEncoding.DefaultEncoding.GetBytes(msg);
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
            return CreationTime.GetValueOrDefault();
        }

        public void Reset()
        {
            cache_.Reset();
            PurgeFileCache();
            open();
        }

        public void Refresh()
        {
            cache_.Reset();
            open();
        }

        #endregion

        #region IDisposable Members

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
                close();
            }
            _disposed = true;
        }

        ~FileStore() => Dispose(false);
        #endregion
    }
}
