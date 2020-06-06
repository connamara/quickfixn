using System;
using Serilog;

namespace SerilogLog
{
    public class SerilogLog : QuickFix.ILog
    {
        private Serilog.Core.Logger _messageLog;
        private Serilog.Core.Logger _eventLog;
        private string _pathPrefix;

        public long? MessagesFileSizeLimitBytes { get; }
        public int? MessagesFilesLimit { get; }
        public long? EventsFileSizeLimitBytes { get; }
        public int? EventsFilesLimit { get; }

        public SerilogLog(string fileLogPath, QuickFix.SessionID sessionID,
            long? messagesFileSizeLimitBytes, int? messagesFilesLimit,
            long? eventsFileSizeLimitBytes, int? eventsFilesLimit)
        {
            MessagesFileSizeLimitBytes = messagesFileSizeLimitBytes;
            MessagesFilesLimit = messagesFilesLimit;
            EventsFileSizeLimitBytes = eventsFileSizeLimitBytes;
            EventsFilesLimit = eventsFilesLimit;
            _pathPrefix = System.IO.Path.Combine(fileLogPath, QuickFix.FileStore.Prefix(sessionID));
            CreateLoggers();
        }


        public SerilogLog(string fileLogPath, QuickFix.SessionID sessionID)
            : this(fileLogPath, sessionID, null, null, null, null)
        {
        }

        private void CreateLoggers()
        {
            string messagesFilePath = _pathPrefix + @".messages.log";
            _messageLog = new LoggerConfiguration()
                .WriteTo.File(messagesFilePath,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} : {Message}\n",
                    rollOnFileSizeLimit: true,
                    fileSizeLimitBytes: MessagesFileSizeLimitBytes,
                    retainedFileCountLimit: MessagesFilesLimit)
                .CreateLogger();
            string eventsFilePath = _pathPrefix + @".events.log";
            _eventLog = new LoggerConfiguration()
                .WriteTo.File(eventsFilePath,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} : {Message}\n",
                    rollOnFileSizeLimit: true,
                    fileSizeLimitBytes: EventsFileSizeLimitBytes,
                    retainedFileCountLimit: EventsFilesLimit)
                .CreateLogger();
        }

        private readonly object _sync = new object();
        public void Clear()
        {
            lock (_sync)
            {
                DisposeLoggers();
                CreateLoggers();
            }
        }

        private void DisposeLoggers()
        {
            _eventLog?.Dispose();
            _eventLog = null;
            _messageLog?.Dispose();
            _messageLog = null;
        }


        public void OnEvent(string s)
        {

            lock (_sync)
            {
                DisposedCheck();
                _eventLog.Information(s);
            }
        }

        public void OnIncoming(string msg)
        {
            lock (_sync)
            {
                DisposedCheck();
                _messageLog.Information(msg);
            }
        }

        public void OnOutgoing(string msg)
        {
            lock (_sync)
            {
                DisposedCheck();
                _messageLog.Information(msg);

            }
        }

        private void DisposedCheck()
        {
            if (_disposed)
                throw new System.ObjectDisposedException(this.GetType().Name);
        }

        #region IDisposable
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
                DisposeLoggers();
            }
            _disposed = true;
        }
        ~SerilogLog() => Dispose(false);
        #endregion
    }
}
