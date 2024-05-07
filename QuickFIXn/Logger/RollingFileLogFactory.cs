using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFix.Logger
{
    /// <summary>
    /// Creates a message store that stores messages in a file separated by date
    /// </summary>
    public class RollingFileLogFactory : ILogFactory
    {
        private readonly SessionSettings _settings;

        #region LogFactory Members

        public RollingFileLogFactory(SessionSettings settings)
        {
            _settings = settings;
        }

        /// <summary>
        /// Creates a file-based message store separated by date
        /// </summary>
        /// <param name="sessionId">session ID for the message store</param>
        /// <returns></returns>
        public ILog Create(SessionID sessionId)
        {
            return new FileLog(_settings.Get(sessionId).GetString(SessionSettings.FILE_LOG_PATH), sessionId,true);
        }

        #endregion
    }
}
