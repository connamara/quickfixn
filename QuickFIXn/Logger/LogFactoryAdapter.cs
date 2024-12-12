using System;
using System.Collections.Concurrent;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

internal class LogFactoryAdapter : ILoggerFactory
{
    private readonly ILogFactory _logFactory;
    private readonly SessionSettings _settings;
    private readonly ConcurrentDictionary<SessionID, ILogger> _loggers = new();

    internal LogFactoryAdapter(ILogFactory logFactory, SessionSettings settings)
    {
        _logFactory = logFactory;
        _settings = settings;
    }

    public ILogger CreateLogger(string categoryName)
    {
        // category will be "QuickFix" for non-session logger and "QuickFix.<session ID>" for session logger
        var sessionIdString = categoryName.Length > "QuickFix.".Length ? categoryName.Substring(9) : "";
        var sessionId = _settings.GetSessions()
            .SingleOrDefault(s =>
                s.ToString().Equals(sessionIdString, StringComparison.InvariantCulture));
        var defaultSessionId = new SessionID("Non", "Session", "Log");

        return _loggers.GetOrAdd(sessionId ?? defaultSessionId, sid => sessionId is not null
            ? new LogAdapter(_logFactory.Create(sid))
            : new LogAdapter(_logFactory.CreateNonSessionLog()));
    }

    public void AddProvider(ILoggerProvider provider)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
    }
}

internal class LogAdapter : ILogger
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

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;
}