using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFix
{
    /// <summary>
    /// Issolated File log implementation
    /// </summary>
    public class IsolatedFileLog : FileLog
    {
        IsolatedStorageFile store_;

        public IsolatedFileLog(IsolatedStorageFile store, string fileLogPath, SessionID sessionID)
            : base(fileLogPath, sessionID)
        {
            store_ = store;
        }

        protected override System.IO.FileStream GetStream(string path, FileMode fileMode)
        {
            DisposedCheck();

            if (!store_.DirectoryExists(BasePath))
                store_.CreateDirectory(BasePath);

            var stream = new IsolatedStorageFileStream(path, fileMode, FileAccess.Write, FileShare.Read, store_);
            return stream;
        }

        #region IDisposable Members
        private void DisposedCheck()
        {
            if (_disposed)
                throw new System.ObjectDisposedException(this.GetType().Name);
        }

        bool _disposed = false;
        protected override void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                store_?.Dispose();
            }

            store_ = null;

            _disposed = true;

            base.Dispose(disposing);
        }
        #endregion
    }
}