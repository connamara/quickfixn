using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace QuickFix
{
    public static class LoggerExtensions
    {
        internal static EventId Event { get; } = new EventId(1, "event");

        internal static EventId Incoming { get; } = new EventId(2, "incoming");

        internal static EventId Outgoing { get; } = new EventId(3, "outgoing");

        public static void LogEvent(this ILogger logger, string s, LogLevel logLevel = LogLevel.Information, params object[] args)
        {
            logger.Log(logLevel, Event, s, args);
        }

        public static void LogOutgoing(this ILogger logger, string message, LogLevel logLevel = LogLevel.Debug, params object[] args)
        {
            logger.Log(logLevel, Outgoing, message, args);
        }

        public static void LogIncoming(this ILogger logger, string message, LogLevel logLevel = LogLevel.Debug, params object[] args)
        {
            logger.Log(logLevel, Incoming, message, args);
        }

        [Obsolete]
        internal static void Log<TState>(
            this ILog log, 
            LogLevel logLevel, 
            EventId eventId, 
            TState state, 
            Exception exception, 
            Func<TState, Exception, string> formatter)
        {
            if (eventId == Incoming)
            {
                log.OnIncoming(formatter(state, exception));
            }
            else if (eventId == Outgoing)
            {
                log.OnOutgoing(formatter(state, exception));
            }
            else
            {
                log.OnEvent(formatter(state, exception));
            }
        }

        [Obsolete]
        internal static bool IsEnabled(this ILog log, LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Trace: return true;
                case LogLevel.Debug: return true;
                case LogLevel.Information: return true;
                case LogLevel.Error: return true;
                case LogLevel.Warning: return true;
                default: return true;
            }
        }

        [Obsolete("Please use constructors to inject instead")]
        internal static ILoggerFactory DefaultLoggerFactorySingleton { get; } = new LoggerFactory();

        [Obsolete("Please use constructors to inject instead")]
        internal static ILoggerFactory DefaultLoggerFactoryTransient => new LoggerFactory();

        [Obsolete]
        internal static ILoggerFactory LoggerFactorySingleton(ILogFactory logFactory)
        {
            DefaultLoggerFactorySingleton.AddProvider(new LogFactoryLoggerProvider(logFactory));
            return DefaultLoggerFactorySingleton;
        }

        [Obsolete]
        internal static ILoggerFactory LoggerFactoryTransient(ILogFactory logFactory)
        {
            var loggerFactory = DefaultLoggerFactoryTransient;
            loggerFactory.AddProvider(new LogFactoryLoggerProvider(logFactory != null ? logFactory : (ILogFactory)NullLogFactory.Instance));
            return loggerFactory;
        }
    }
}
