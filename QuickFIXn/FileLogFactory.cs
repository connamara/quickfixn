
using Microsoft.Extensions.Logging;
using System;

namespace QuickFix
{
    /// <summary>
    /// Creates a message store that stores messages in a file
    /// </summary>
    [Obsolete("Use File Logger Provider of your choice")]
    public class FileLogFactory : ILoggerProvider, ILogFactory
    {
        private readonly SessionSettings _settings;

        #region LogFactory Members

        public FileLogFactory(SessionSettings settings)
        {
            _settings = settings;
        }

        [Obsolete]
        public ILog Create(SessionID sessionID)
        {
            return CreateFileLog(sessionID);
        }

        /// <summary>
        /// Creates a file-based message store
        /// </summary>
        /// <param name="categoryName">session ID value for the message store</param>
        /// <returns></returns>
        public ILogger CreateLogger(string categoryName)
        {
            return CreateFileLog(SessionID.FromString(categoryName));
        }

        public void Dispose()
        {
            return;
        }

        #endregion

        private FileLog CreateFileLog(SessionID sessionID)
        {
            return new FileLog(_settings.Get(sessionID).GetString(SessionSettings.FILE_LOG_PATH), sessionID);
        }
    }
}
