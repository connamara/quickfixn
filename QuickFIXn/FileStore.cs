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

        public string BasePath { get; private set; }

        public bool IsOpen { get; private set; }

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

        public FileStore(string basePath, SessionID sessionID)
        {
            BasePath = basePath;

            string prefix = Prefix(sessionID);

            seqNumsFileName_ = System.IO.Path.Combine(BasePath, prefix + ".seqnums");
            msgFileName_ = System.IO.Path.Combine(BasePath, prefix + ".body");
            headerFileName_ = System.IO.Path.Combine(BasePath, prefix + ".header");
            sessionFileName_ = System.IO.Path.Combine(BasePath, prefix + ".session");
        }

        protected virtual System.IO.FileStream GetStream(string path, System.IO.FileMode fileMode, System.IO.FileAccess fileAccess)
        {
            DisposedCheck();

            if (!System.IO.Directory.Exists(BasePath))
                System.IO.Directory.CreateDirectory(BasePath);

            var stream = new System.IO.FileStream(path, fileMode, fileAccess, System.IO.FileShare.ReadWrite);
            return stream;
        }

        System.IO.StreamWriter GetStreamWriter(System.IO.FileStream stream)
        {
            var writer = new System.IO.StreamWriter(stream)
            {
                AutoFlush = true
            };

            return writer;
        }

        internal void Open()
        {
            ConstructFromFileCache();
            InitializeSessionCreateTime();

            var seqNumsStream = GetStream(seqNumsFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            seqNumsFile_ = seqNumsStream;

            var msgStream = GetStream(msgFileName_, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
            msgFile_ = msgStream;

            var headerStream = GetStream(headerFileName_, System.IO.FileMode.Append, System.IO.FileAccess.Write);
            var headerReader = GetStreamWriter(headerStream);
            headerFile_ = headerReader;

            IsOpen = true;
        }

        internal void Close()
        {
            seqNumsFile_?.Dispose();
            msgFile_?.Dispose();
            headerFile_?.Dispose();

            IsOpen = false;
        }

        private void PurgeSingleFile(System.IO.Stream stream, string filename)
        {
            if (stream != null)
                stream.Close();
            PurgeSingleFile(filename);
        }

        private void PurgeSingleFile(System.IO.StreamWriter stream, string filename)
        {
            if (stream != null)
                stream.Close();
            PurgeSingleFile(filename);
        }

        protected virtual void PurgeSingleFile(string filename)
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

        protected virtual bool FileExists(string filename)
        {
            return System.IO.File.Exists(filename);
        }

        protected virtual bool FileExistsWithNonZeroLength(string filename)
        {
            var fileInfo = new System.IO.FileInfo(filename);
            return fileInfo.Exists && fileInfo.Length > 0;
        }

        private void ConstructFromFileCache()
        {
            offsets_.Clear();
            if (FileExists(headerFileName_))
            {
                using (var stream = GetStream(headerFileName_, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    using (var reader = new System.IO.StreamReader(stream))
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
            }

            if (FileExists(seqNumsFileName_))
            {
                using (var stream = GetStream(seqNumsFileName_, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    using (var seqNumReader = new System.IO.StreamReader(stream))
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
        }

        private void InitializeSessionCreateTime()
        {
            if (FileExistsWithNonZeroLength(sessionFileName_))
            {
                using (var stream = GetStream(sessionFileName_, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        string s = reader.ReadToEnd();
                        cache_.CreationTime = UtcDateTimeSerializer.FromString(s);
                    }
                }
            }
            else
            {
                using (var stream = GetStream(sessionFileName_, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    using (var writer = GetStreamWriter(stream))
                    {
                        writer.Write(UtcDateTimeSerializer.ToString(cache_.CreationTime.Value));
                    }
                }
            }
        }

        private void DisposedCheck()
        {
            if (_disposed)
                throw new System.ObjectDisposedException(this.GetType().Name);
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
            if (!IsOpen)
                Open();

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
            if (!IsOpen)
                Open();

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
            if (!IsOpen)
                Open();

            return cache_.GetNextSenderMsgSeqNum();
        }

        public int GetNextTargetMsgSeqNum()
        {
            if (!IsOpen)
                Open();

            return cache_.GetNextTargetMsgSeqNum();
        }

        public void SetNextSenderMsgSeqNum(int value)
        {
            if (!IsOpen)
                Open();

            cache_.SetNextSenderMsgSeqNum(value);
            setSeqNum();
        }

        public void SetNextTargetMsgSeqNum(int value)
        {
            if (!IsOpen)
                Open();

            cache_.SetNextTargetMsgSeqNum(value);
            setSeqNum();
        }

        public void IncrNextSenderMsgSeqNum()
        {
            if (!IsOpen)
                Open();

            cache_.IncrNextSenderMsgSeqNum();
            setSeqNum();
        }

        public void IncrNextTargetMsgSeqNum()
        {
            if (!IsOpen)
                Open();

            cache_.IncrNextTargetMsgSeqNum();
            setSeqNum();
        }

        private void setSeqNum()
        {
            seqNumsFile_.Seek(0, System.IO.SeekOrigin.Begin);
            using (var writer = new System.IO.StreamWriter(seqNumsFile_, Encoding.Default, 1096, true))
            {
                writer.Write(GetNextSenderMsgSeqNum().ToString("D10") + " : " + GetNextTargetMsgSeqNum().ToString("D10") + "  ");
                writer.Flush();
            }
        }

        public DateTime? CreationTime
        {
            get
            {
                if (!IsOpen)
                    Open();
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
            Open();
        }

        public void Refresh()
        {
            cache_.Reset();
            Open();
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
                Close();
            }

            seqNumsFile_ = null;
            msgFile_ = null;
            headerFile_ = null;

            _disposed = true;
        }

        ~FileStore() => Dispose(false);
        #endregion
    }
}
