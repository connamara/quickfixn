
using System;

namespace QuickFix
{
    /// <summary>
    /// File log implementation
    /// </summary>
    internal class CompositeLog : ILog
    {
        private ILog[] logs_;

        private bool _disposed = false;

        public CompositeLog(ILog[] logs)
        {
            logs_ = logs;
        }

        public void Clear()
        {
            DisposedCheck();
            foreach (var log in logs_)
                log.Clear();
        }

        public void OnIncoming(string msg)
        {
            DisposedCheck();
            foreach (var log in logs_)
                log.OnIncoming(msg);
        }

        public void OnOutgoing(string msg)
        {
            DisposedCheck();
            foreach (var log in logs_)
                log.OnOutgoing(msg);
        }

        public void OnEvent(string s)
        {
            DisposedCheck();
            foreach (var log in logs_)
                log.OnEvent(s);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                foreach (var log in logs_)
                    log.Dispose();
            }
            _disposed = true;
        }

        private void DisposedCheck()
        {
            if (_disposed)
                throw new System.ObjectDisposedException(this.GetType().Name);
        }

        ~CompositeLog() => Dispose(false);
    }
}
