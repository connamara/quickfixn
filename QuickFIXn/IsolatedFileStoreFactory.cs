using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFix
{
    public class IsolatedFileStoreFactory : FileStoreFactory
    {
        private IsolatedStorageFile isoStorage_;

        /// <summary>
        /// Create the factory with configuration in session settings
        /// </summary>
        /// <param name="store"></param>
        /// <param name="settings"></param>
        public IsolatedFileStoreFactory(IsolatedStorageFile store, SessionSettings settings)
            : base(settings)
        {
            isoStorage_ = store;
        }

        /// <summary>
        /// Creates a file-based message store
        /// </summary>
        /// <param name="sessionID">session ID for the message store</param>
        /// <returns></returns>
        public override IMessageStore Create(SessionID sessionID)
        {
            return new IsolatedFileStore(isoStorage_, Settings.Get(sessionID).GetString(SessionSettings.FILE_STORE_PATH), sessionID);
        }
    }
}
