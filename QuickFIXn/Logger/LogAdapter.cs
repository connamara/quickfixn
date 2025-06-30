using System;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

/// <summary>
/// Wraps the legacy (pre-v1.15) ILog interface so that it can
/// be used as an ILogger.
/// </summary>
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
