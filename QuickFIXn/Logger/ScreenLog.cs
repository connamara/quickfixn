using System;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

/// <summary>
/// FIXME - needs to log sessionIDs, timestamps, etc.
/// </summary>
[Obsolete("Use Microsoft.Extensions.Logging instead.")]
public class ScreenLog : ILog, ILogger
{
    private readonly object _sync = new ();
    private readonly bool _logIncoming;
    private readonly bool _logOutgoing;
    private readonly bool _logEvent;

    public ScreenLog(bool logIncoming, bool logOutgoing, bool logEvent)
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
            System.Console.WriteLine("<incoming> " + msg.Replace(Message.SOH, '|'));
        }
    }

    public void OnOutgoing(string msg)
    {
        if (!_logOutgoing)
            return;

        lock (_sync)
        {
            System.Console.WriteLine("<outgoing> " + msg.Replace(Message.SOH, '|'));
        }
    }

    public void OnEvent(string s)
    {
        if (!_logEvent)
            return;

        lock (_sync)
        {
            System.Console.WriteLine("<event> " + s);
        }
    }
    #endregion

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

#pragma warning disable CS8633
    public IDisposable BeginScope<TState>(TState state) where TState : notnull => default!;
#pragma warning restore CS8633

    public void Dispose(){}
}
