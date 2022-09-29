
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace QuickFix
{
    /// <summary>
    /// File log implementation
    /// </summary>
    [Obsolete("For Composite Logging use LoggerFactory")]
    internal class CompositeLog : ILogger, ILog
    {
        private IEnumerable<ILogger> _logger;

        private bool _disposed = false;

        [Obsolete]
        public CompositeLog(ILog[] logs)
        {
            _logger = logs.Select(x => new LogLogger(x));
        }

        public CompositeLog(IEnumerable<ILogger> logger)
        {
            _logger = logger;
        }

        public void Clear()
        {
            DisposedCheck();
            foreach (var logger in _logger)
            {
                var log = logger as ILog;
                if (log != null)
                    log.Clear();
            }
                
        }

        public void OnIncoming(string msg)
        {
            DisposedCheck();
            foreach (var logger in _logger)
                logger.LogIncoming(msg);
        }

        public void OnOutgoing(string msg)
        {
            DisposedCheck();
            foreach (var logger in _logger)
                logger.LogOutgoing(msg);
        }

        public void OnEvent(string s)
        {
            DisposedCheck();
            foreach (var logger in _logger)
                logger.LogEvent(s);
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
                foreach (var logger in _logger)
                {
                    var log = logger as ILog;
                    if (log != null)
                        log.Dispose();
                }
                    
            }
            _disposed = true;
        }

        private void DisposedCheck()
        {
            if (_disposed)
                throw new System.ObjectDisposedException(this.GetType().Name);
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            DisposedCheck();
            foreach (var logger in _logger)
                ((ILog)logger).Log(logLevel, eventId, state, exception, formatter);
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return ((ILog)this).IsEnabled(logLevel);
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        ~CompositeLog() => Dispose(false);
    }
}
