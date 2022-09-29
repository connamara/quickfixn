
using Microsoft.Extensions.Logging;
using System;

namespace QuickFix
{
    /// <summary>
    /// FIXME - needs to log sessionIDs, timestamps, etc.
    /// </summary>
    [Obsolete("Please use ConsoleLogger instead")]
    public class ScreenLog : ILogger, ILog
    {
        private object _sync = new object();
        private readonly bool _logIncoming;
        private readonly bool _logOutgoing;
        private readonly bool _logEvent;

        public ScreenLog(SessionID sessionID, bool logIncoming, bool logOutgoing, bool logEvent)
        {
            _logIncoming = logIncoming;
            _logOutgoing = logOutgoing;
            _logEvent    = logEvent;
        }

        #region ILog Members

        public void Clear()
        { }

        public void OnIncoming(string msg)
        {
            if (!_logIncoming)
                return;

            lock (_sync)
            {
                System.Console.WriteLine("<incoming> " + msg);
            }
        }

        public void OnOutgoing(string msg)
        {
            if (!_logOutgoing)
                return;

            lock (_sync)
            {
                Console.WriteLine("<outgoing> " + msg);
            }
        }

        public void OnEvent(string s)
        {
            if (!_logEvent)
                return;

            lock (_sync)
            {
                Console.WriteLine("<event> " + s);
            }
        }
        #endregion

        #region ILogger Members
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            ((ILog)this).Log(logLevel, eventId, state, exception, formatter);
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return ((ILog)this).IsEnabled(logLevel);
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable implementation
        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            // Nothing to dispose of...
        }

        

        ~ScreenLog() => Dispose(false);
        #endregion
    }
}
