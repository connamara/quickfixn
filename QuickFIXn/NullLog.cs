
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;

namespace QuickFix
{
    /// <summary>
    /// Log implementation that does not do anything
    /// </summary>
    [Obsolete("Use NullLogger instead")]
    public sealed class NullLog : ILogger, ILog
    {
        private readonly NullLogger _nullLogger = NullLogger.Instance;
        #region ILog Members

        public static NullLog Instance { get; } = new NullLog();

        [Obsolete]
        public void Clear()
        { }

        [Obsolete]
        public void OnIncoming(string msg)
        { }

        [Obsolete]
        public void OnOutgoing(string msg)
        { }

        [Obsolete]
        public void OnEvent(string s)
        { }

        [Obsolete]
        public void Dispose()
        { }

        public void Log<TState>(
            LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            _nullLogger.Log(logLevel, eventId, state, exception, formatter);
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return _nullLogger.IsEnabled(logLevel);
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return _nullLogger.BeginScope(state);
        }

        #endregion
    }
}
