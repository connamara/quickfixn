
using System;

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

        private string messageLogFileName_;
        private string eventLogFileName_;


        public FileLog(string fileLogPath)
        {
            Init(fileLogPath, "GLOBAL");
        }

        public FileLog(string fileLogPath, SessionID sessionID)
        {
            Init(fileLogPath, Prefix(sessionID));
        }   
        

        private void Init(string fileLogPath, string prefix)
        {
            if (!System.IO.Directory.Exists(fileLogPath))
                System.IO.Directory.CreateDirectory(fileLogPath);

            messageLogFileName_ = System.IO.Path.Combine(fileLogPath, prefix + ".messages.current.log");
            eventLogFileName_ = System.IO.Path.Combine(fileLogPath, prefix + ".event.current.log");

            messageLog_ = new System.IO.StreamWriter(messageLogFileName_,true);
            eventLog_ = new System.IO.StreamWriter(eventLogFileName_,true);

            messageLog_.AutoFlush = true;
            eventLog_.AutoFlush = true;
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
                messageLog_.Close();
                eventLog_.Close();

                messageLog_ = new System.IO.StreamWriter(messageLogFileName_, false);
                eventLog_ = new System.IO.StreamWriter(eventLogFileName_, false);

                messageLog_.AutoFlush = true;
                eventLog_.AutoFlush = true;
            }
        }

        public void OnIncoming(string msg)
        {
            DisposedCheck();

            lock (sync_)
            {
                messageLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : " + msg);
            }
        }

        public void OnOutgoing(string msg)
        {
            DisposedCheck();

            lock (sync_)
            {
                messageLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : " + msg);
            }
        }

        public void OnEvent(string s)
        {
            DisposedCheck();

            lock (sync_)
            {
                eventLog_.WriteLine(Fields.Converters.DateTimeConverter.Convert(System.DateTime.UtcNow) + " : "+ s);
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
                if (messageLog_ != null) { messageLog_.Dispose(); }
                if (eventLog_ != null) { eventLog_.Dispose(); }

                messageLog_ = null;
                eventLog_ = null;
            }
            _disposed = true;
        }
        ~FileLog() => Dispose(false);
        #endregion
    }
}
