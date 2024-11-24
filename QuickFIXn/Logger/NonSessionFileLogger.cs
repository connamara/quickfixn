using System;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

/// <summary>
/// Like the file logger, but only creates the files on first write
/// </summary>
internal class NonSessionFileLogger : ILogger
{
    private readonly Lazy<FileLogger> _fileLog;

    internal NonSessionFileLogger(string fileLogPath, SessionID sessionId)
    {
        _fileLog = new Lazy<FileLogger>(() => new FileLogger(fileLogPath, sessionId));
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,
        Func<TState, Exception?, string> formatter) =>
        _fileLog.Value.Log(logLevel, eventId, state, exception, formatter);

    public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => _fileLog.Value.BeginScope(state);
}