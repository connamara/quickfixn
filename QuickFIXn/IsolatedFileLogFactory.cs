
using System.IO;
using System.IO.IsolatedStorage;

namespace QuickFix
{
    /// <summary>
    /// Creates a message store that stores messages in a file
    /// </summary>
    public class IsolatedFileLogFactory : FileLogFactory
    {
        private IsolatedStorageFile isoStorage_;

        #region LogFactory Members

        public IsolatedFileLogFactory(IsolatedStorageFile store, SessionSettings settings)
            :base(settings)
        {
            isoStorage_ = store;
        }

        /// <summary>
        /// Creates a file-based message store
        /// </summary>
        /// <param name="sessionID">session ID for the message store</param>
        /// <returns></returns>
        public override ILog Create(SessionID sessionID)
        {
            return new IsolatedFileLog(isoStorage_, Settings.Get(sessionID).GetString(SessionSettings.FILE_LOG_PATH), sessionID);
        }

        #endregion
    }
}
