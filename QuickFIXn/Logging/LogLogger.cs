using Microsoft.Extensions.Logging;
using System;

namespace QuickFix
{
    internal class LogLogger : ILogger, ILog
    {
        private readonly ILog _log;

        [Obsolete]
        internal LogLogger(ILog log)
        {
            _log = log;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return _log.IsEnabled(logLevel);
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            _log.Log(logLevel, eventId, state, exception, formatter);
        }

        [Obsolete]
        public void Clear()
        {
            _log.Clear();
        }

        [Obsolete]
        public void Dispose()
        {
            if (_log != null)
                _log.Dispose();
        }

        [Obsolete]
        public void OnEvent(string s)
        {
            _log.OnEvent(s);
        }

        [Obsolete]
        public void OnIncoming(string msg)
        {
            _log.OnIncoming(msg);
        }

        [Obsolete]
        public void OnOutgoing(string msg)
        {
            _log.OnOutgoing(msg);
        }
    }
}
