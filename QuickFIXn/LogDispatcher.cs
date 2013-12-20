using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Logging;

namespace QuickFix
{
    /// <summary>
    /// This is a temporary mechanism for the transition from the legacy ILog- and ILogFactory- based
    /// logging to Common.Logging. It replicates the Common.Logging API and is logged to by all parts
    /// of QuickFix, and dispatches log messages to both the legacy system and Common.Logging.
    /// </summary>
    class LogDispatcher
    {
        private Common.Logging.ILog newLog_;
        private QuickFix.ILog legacyLog_;

        public LogDispatcher(Common.Logging.ILog newLog, QuickFix.ILog legacyLog)
        {
            newLog_ = newLog;
            legacyLog_ = legacyLog;
        }

        #region Trace

        public void Trace(object message)
        {
            newLog_.Trace(message);
        }

        public void Trace(object message, Exception exception)
        {
            newLog_.Trace(message, exception);
        }

        public void TraceFormat(string format, params object[] args)
        {
            newLog_.TraceFormat(format, args);
        }

        public void TraceFormat(string format, Exception exception, params object[] args)
        {
            newLog_.TraceFormat(format, exception, args);
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            newLog_.TraceFormat(formatProvider, format, args);
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            newLog_.TraceFormat(formatProvider, format, exception, args);
        }

        #endregion

        #region Debug

        public void Debug(object message)
        {
            newLog_.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            newLog_.Debug(message, exception);
        }

        public void DebugFormat(string format, params object[] args)
        {
            newLog_.DebugFormat(format, args);
        }

        public void DebugFormat(string format, Exception exception, params object[] args)
        {
            newLog_.DebugFormat(format, exception, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            newLog_.DebugFormat(formatProvider, format, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            newLog_.DebugFormat(formatProvider, format, exception, args);
        }

        #endregion

        #region Info

        public void Info(object message)
        {
            newLog_.Info(message);
            legacyLog_.OnEvent((string)message);
        }

        public void Info(object message, Exception exception)
        {
            newLog_.Info(message, exception);
            legacyLog_.OnEvent(message + ": " + exception.Message);
        }

        public void InfoFormat(string format, params object[] args)
        {
            newLog_.InfoFormat(format, args);
            legacyLog_.OnEvent(String.Format(format, args));
        }

        public void InfoFormat(string format, Exception exception, params object[] args)
        {
            newLog_.InfoFormat(format, exception, args);
            legacyLog_.OnEvent(String.Format(format + ": " + exception.Message, args));
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            newLog_.InfoFormat(formatProvider, format, args);
            legacyLog_.OnEvent(String.Format(formatProvider, format, args));
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            newLog_.InfoFormat(formatProvider, format, exception, args);
            legacyLog_.OnEvent(String.Format(formatProvider, format, args) + ": " + exception.Message);
        }

        #endregion

        #region Warn

        public void Warn(object message)
        {
            newLog_.Warn(message);
            legacyLog_.OnEvent((string)message);
        }

        public void Warn(object message, Exception exception)
        {
            newLog_.Warn(message, exception);
            legacyLog_.OnEvent(message + ": " + exception.Message);
        }

        public void WarnFormat(string format, params object[] args)
        {
            newLog_.WarnFormat(format, args);
            legacyLog_.OnEvent(String.Format(format, args));
        }

        public void WarnFormat(string format, Exception exception, params object[] args)
        {
            newLog_.WarnFormat(format, exception, args);
            legacyLog_.OnEvent(String.Format(format + ": " + exception.Message, args));
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            newLog_.WarnFormat(formatProvider, format, args);
            legacyLog_.OnEvent(String.Format(formatProvider, format, args));
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            newLog_.WarnFormat(formatProvider, format, exception, args);
            legacyLog_.OnEvent(String.Format(formatProvider, format, args) + ": " + exception.Message);
        }

        #endregion

        #region Error

        public void Error(object message)
        {
            newLog_.Error(message);
            legacyLog_.OnEvent((string)message);
        }

        public void Error(object message, Exception exception)
        {
            newLog_.Error(message, exception);
            legacyLog_.OnEvent(message + ": " + exception.Message);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            newLog_.ErrorFormat(format, args);
            legacyLog_.OnEvent(String.Format(format, args));
        }

        public void ErrorFormat(string format, Exception exception, params object[] args)
        {
            newLog_.ErrorFormat(format, exception, args);
            legacyLog_.OnEvent(String.Format(format + ": " + exception.Message, args));
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            newLog_.ErrorFormat(formatProvider, format, args);
            legacyLog_.OnEvent(String.Format(formatProvider, format, args));
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            newLog_.ErrorFormat(formatProvider, format, exception, args);
            legacyLog_.OnEvent(String.Format(formatProvider, format, args) + ": " + exception.Message);
        }

        #endregion

        #region Fatal

        public void Fatal(object message)
        {
            newLog_.Fatal(message);
            legacyLog_.OnEvent((string)message);
        }

        public void Fatal(object message, Exception exception)
        {
            newLog_.Fatal(message, exception);
            legacyLog_.OnEvent(message + ": " + exception.Message);
        }

        public void FatalFormat(string format, params object[] args)
        {
            newLog_.FatalFormat(format, args);
            legacyLog_.OnEvent(String.Format(format, args));
        }

        public void FatalFormat(string format, Exception exception, params object[] args)
        {
            newLog_.FatalFormat(format, exception, args);
            legacyLog_.OnEvent(String.Format(format + ": " + exception.Message, args));
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            newLog_.FatalFormat(formatProvider, format, args);
            legacyLog_.OnEvent(String.Format(formatProvider, format, args));
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            newLog_.FatalFormat(formatProvider, format, exception, args);
            legacyLog_.OnEvent(String.Format(formatProvider, format, args) + ": " + exception.Message);
        }

        #endregion

        #region Message logging

        /// <summary>
        /// Logs an incoming message
        /// </summary>
        /// <param name="msg">a raw FIX message</param>
        public void OnIncomingMessage(string msg)
        {
            newLog_.Info(msg);
            legacyLog_.OnIncoming(msg);
        }

        /// <summary>
        /// Logs an outgoing message
        /// </summary>
        /// <param name="msg">a raw FIX message</param>
        public void OnOutgoingMessage(string msg)
        {
            newLog_.Info(msg);
            legacyLog_.OnOutgoing(msg);            
        }

        #endregion

        public bool IsTraceEnabled { get { return newLog_.IsTraceEnabled; } }
        public bool IsDebugEnabled { get { return newLog_.IsDebugEnabled; } }
        public bool IsInfoEnabled { get { return true; } }
        public bool IsWarnEnabled { get { return true; } }
        public bool IsErrorEnabled { get { return true; } }
        public bool IsFatalEnabled { get { return true; } }
    }
}
