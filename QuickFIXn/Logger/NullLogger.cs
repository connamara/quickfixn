using System;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

/// <summary>
/// Log implementation that does not do anything
/// </summary>
public sealed class NullLogger : ILogger
{
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,
        Func<TState, Exception?, string> formatter)
    {
    }

    public bool IsEnabled(LogLevel logLevel) => false;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;
}