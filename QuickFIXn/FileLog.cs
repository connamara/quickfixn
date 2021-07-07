
using System;
using System.IO;

namespace QuickFix
{
    /// <summary>
    /// File log implementation
    /// </summary>
    public class FileLog : ILog, System.IDisposable
    {
        private object sync_ = new object();

        private System.IO.StreamWriter messageLog_;
        private System.IO.StreamWriter eventLog_;

        public string BasePath { get; private set; }
        protected string messageLogFileName_;
        protected string eventLogFileName_;

        public bool IsOpen { get; private set; }

        public FileLog(string fileLogPath)
            : this(fileLogPath, "GLOBAL")
        {
        }
        public FileLog(string fileLogPath, SessionID sessionID)
            : this(fileLogPath, Prefix(sessionID))
        {
        }
        public FileLog(string fileLogPath, string prefix)
        {
            BasePath = fileLogPath;
            messageLogFileName_ = System.IO.Path.Combine(BasePath, prefix + ".messages.current.log");
            eventLogFileName_ = System.IO.Path.Combine(BasePath, prefix + ".event.current.log");
        }

        protected virtual System.IO.FileStream GetStream(string path, FileMode fileMode)
        {
            DisposedCheck();

            if (!System.IO.Directory.Exists(BasePath))
                System.IO.Directory.CreateDirectory(BasePath);

            var stream = new FileStream(path, fileMode, FileAccess.Write, FileShare.Read);
            return stream;
        }

        protected StreamWriter GetStreamWriter(FileStream stream)
        {
            var writer = new StreamWriter(stream)
            {
                AutoFlush = true
            };
            return writer;
        }

        private void Open(FileMode fileMode)
        {
            var messageStream = GetStream(messageLogFileName_, fileMode);
            messageLog_ = GetStreamWriter(messageStream);
            var eventStream = GetStream(eventLogFileName_, fileMode);
            eventLog_ = GetStreamWriter(eventStream);

            IsOpen = true;
        }
        private void Close()
        {
            messageLog_?.Close();
            eventLog_?.Close();

            IsOpen = false;
        }

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

        private void DisposedCheck()
        {
            if (_disposed)
                throw new System.ObjectDisposedException(this.GetType().Name);
        }

        #region Log Members

        public void Clear()
        {
            DisposedCheck();

            lock (sync_)
            {
                Close();

                Open(FileMode.Create);
            }
        }

        public void OnIncoming(string msg)
        {
            DisposedCheck();

            lock (sync_)
            {
                if (!IsOpen)
                    Open(FileMode.Append);

                messageLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : " + msg);
            }
        }

        public void OnOutgoing(string msg)
        {
            DisposedCheck();

            lock (sync_)
            {
                if (!IsOpen)
                    Open(FileMode.Append);

                messageLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : " + msg);
            }
        }

        public void OnEvent(string s)
        {
            DisposedCheck();

            lock (sync_)
            {
                if (!IsOpen)
                    Open(FileMode.Append);

                eventLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : " + s);
            }
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

            BasePath = null;
            messageLog_ = null;
            eventLog_ = null;

            _disposed = true;
        }
        ~FileLog() => Dispose(false);
        #endregion
    }
}
