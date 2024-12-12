using System;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

/// <summary>
/// Like the file logger, but only creates the files on first write
/// </summary>
internal class NonSessionFileLogger : ILogger, IDisposable
{
    private readonly Lazy<FileLog> _fileLog;

    internal NonSessionFileLogger(string fileLogPath, SessionID sessionId)
    {
        _fileLog = new Lazy<FileLog>(() => new FileLog(fileLogPath, sessionId));
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,
        Func<TState, Exception?, string> formatter) =>
        _fileLog.Value.Log(logLevel, eventId, state, exception, formatter);

    public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;

#pragma warning disable CS8633
    public IDisposable BeginScope<TState>(TState state) where TState : notnull => _fileLog.Value.BeginScope(state);
#pragma warning restore CS8633

    public void Dispose()
    {
        if (_fileLog.IsValueCreated) _fileLog.Value.Dispose();
    }
}