using System;
using Serilog;

namespace SerilogLog
{
    /// <summary>
    /// Sample implementation of QuickFix.ILog
    /// featuring rolling log files and limited total log size.
    /// </summary>
    public class SerilogLog : QuickFix.ILog
    {
        private Serilog.Core.Logger _messageLog;
        private Serilog.Core.Logger _eventLog;
        private string _pathPrefix;

        public long? MessagesFileSizeLimitBytes { get; }
        public int? MessagesFilesLimit { get; }
        public long? EventsFileSizeLimitBytes { get; }
        public int? EventsFilesLimit { get; }

        /// <summary>
        /// Feel free to add / change logging parameters
        /// based on the actual requirements
        /// </summary>
        /// <param name="fileLogPath">All loges are stored in this folder</param>
        /// <param name="sessionID">SessionID of the </param>
        /// <param name="messagesFileSizeLimitBytes">null => no limit</param>
        /// <param name="messagesFilesLimit">null => no limit</param>
        /// <param name="eventsFileSizeLimitBytes">null => no limit</param>
        /// <param name="eventsFilesLimit">null => no limit</param>
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

        /// <summary>
        /// Here is the place to customize logging parameters as needed
        /// </summary>
        private void CreateLoggers()
        {
            string messagesFilePath = _pathPrefix + @".messages.log";
            // You can replace Serilog with any other library of your choice or your own implementation
            _messageLog = new LoggerConfiguration()
                .WriteTo.File(messagesFilePath,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} : {Message}\n",
                    // the special log features are defined in the below parameters
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
