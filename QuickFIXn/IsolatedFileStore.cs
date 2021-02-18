using QuickFix.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using System.Threading.Tasks;

namespace QuickFix
{
    class IsolatedFileStore : FileStore
    {
       private IsolatedStorageFile store_;

        public IsolatedFileStore(IsolatedStorageFile store, string basePath, SessionID sessionID)
            : base(basePath, sessionID)
        {
            store_ = store;
        }

        protected override System.IO.FileStream GetStream(string path, System.IO.FileMode fileMode, System.IO.FileAccess fileAccess)
        {
            DisposedCheck();

            if (!store_.DirectoryExists(BasePath))
               store_.CreateDirectory(BasePath);

            var stream = new IsolatedStorageFileStream(path, fileMode, fileAccess, System.IO.FileShare.ReadWrite, store_);
            return stream;
        }

        protected override void PurgeSingleFile(string filename)
        {
            if (store_.FileExists(filename))
                store_.DeleteFile(filename);
        }

        protected override bool FileExists(string filename)
        {
            return store_.FileExists(filename);
        }

        protected override bool FileExistsWithNonZeroLength(string filename)
        {
            if (store_.FileExists(filename))
                using (var stream = new IsolatedStorageFileStream(filename, FileMode.Open, FileAccess.Read, store_))
                {
                    return stream.Length > 0;
                }
            return false;
        }

        private void DisposedCheck()
        {
            if (_disposed)
                throw new System.ObjectDisposedException(this.GetType().Name);
        }

        #region IDisposable Members
        private bool _disposed = false;
        protected override void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                //store_?.Dispose(); //Doesn't own
            }
            
            store_ = null;

            _disposed = true;

            base.Dispose(disposing);
        }

        ~IsolatedFileStore() => Dispose(false);
        #endregion
    }
}