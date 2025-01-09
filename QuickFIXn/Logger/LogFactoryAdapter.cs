using System;
using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

internal class LogFactoryAdapter : IQuickFixLoggerFactory, IDisposable
{
    private readonly ILogFactory _logFactory;
    private readonly ConcurrentDictionary<SessionID, ILogger> _loggers = new();
    private readonly Lazy<ILogger> _nonSessionLogger;

    internal LogFactoryAdapter(ILogFactory logFactory)
    {
        _logFactory = logFactory;
        _nonSessionLogger = new Lazy<ILogger>(() => new LogAdapter(_logFactory.CreateNonSessionLog()));
    }

    public ILogger CreateSessionLogger(SessionID sessionId) =>
        _loggers.GetOrAdd(sessionId, sId => new LogAdapter(_logFactory.Create(sId)));

    public ILogger CreateNonSessionLogger<T>() => _nonSessionLogger.Value;

    public void Dispose()
    {
        foreach (var (_, logger) in _loggers)
        {
            if (logger is IDisposable disposable)
            {
                try
                {
                    disposable.Dispose();
                }
                catch
                {
                }
            }
        }

        try
        {
            if (_nonSessionLogger.IsValueCreated && _nonSessionLogger.Value is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
        catch
        {
        }
    }
}

internal class LogAdapter : ILogger, IDisposable
{
    private readonly ILog _log;

    public LogAdapter(ILog log)
    {
        _log = log;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,
        Func<TState, Exception?, string> formatter)
    {
        if (!IsEnabled(logLevel)) return;
        if (eventId == LogEventIds.IncomingMessage)
        {
            _log.OnIncoming(formatter(state, exception));
        }
        else if (eventId == LogEventIds.OutgoingMessage)
        {
            _log.OnOutgoing(formatter(state, exception));
        }
        else
        {
            _log.OnEvent(formatter(state, exception));
        }
    }

    public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;

    public IDisposable BeginScope<TState>(TState state) => default!;

    public void Dispose()
    {
        _log.Dispose();
    }
}