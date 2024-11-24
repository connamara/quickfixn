using System;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

/// <summary>
/// FIXME - needs to log sessionIDs, timestamps, etc.
/// </summary>
public class ScreenLogger : ILogger
{
    private readonly bool _logIncoming;
    private readonly bool _logOutgoing;
    private readonly bool _logEvent;

    public ScreenLogger(bool logIncoming, bool logOutgoing, bool logEvent)
    {
        _logIncoming = logIncoming;
        _logOutgoing = logOutgoing;
        _logEvent = logEvent;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,
        Func<TState, Exception?, string> formatter)
    {
        if (!IsEnabled(logLevel)) return;
        if (eventId == LogEventIds.IncomingMessage && _logIncoming)
        {
            Console.WriteLine($"<incoming> {formatter(state, exception).Replace(Message.SOH, '|')}");
        }
        else if (eventId == LogEventIds.OutgoingMessage && _logOutgoing)
        {
            Console.WriteLine($"<outgoing> {formatter(state, exception).Replace(Message.SOH, '|')}");
        }
        else if (_logEvent)
        {
            Console.WriteLine($"<event> {formatter(state, exception)}");
        }
    }

    public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;
}