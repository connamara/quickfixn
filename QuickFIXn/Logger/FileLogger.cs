using System;
using Microsoft.Extensions.Logging;
using QuickFix.Fields.Converters;
using QuickFix.Util;

namespace QuickFix.Logger;

public class FileLogger : ILogger, IDisposable
{
    private readonly object _messagesLock = new();
    private readonly object _eventsLock = new();

    private System.IO.StreamWriter _messageLog;
    private System.IO.StreamWriter _eventLog;

    private readonly string _messageLogFileName;
    private readonly string _eventLogFileName;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="fileLogPath">
    /// All back or forward slashes in this path will be converted as needed to the running platform's preferred
    /// path separator (i.e. "/" will become "\" on windows, else "\" will become "/" on all other platforms)
    /// </param>
    /// <param name="sessionId"></param>
    internal FileLogger(string fileLogPath, SessionID sessionId)
    {
        string prefix = Prefix(sessionId);

        string normalizedPath = StringUtil.FixSlashes(fileLogPath);

        if (!System.IO.Directory.Exists(normalizedPath))
            System.IO.Directory.CreateDirectory(normalizedPath);

        _messageLogFileName = System.IO.Path.Combine(normalizedPath, prefix + ".messages.current.log");
        _eventLogFileName = System.IO.Path.Combine(normalizedPath, prefix + ".event.current.log");

        _messageLog = new System.IO.StreamWriter(_messageLogFileName, true);
        _eventLog = new System.IO.StreamWriter(_eventLogFileName, true);

        _messageLog.AutoFlush = true;
        _eventLog.AutoFlush = true;
    }

    public static string Prefix(SessionID sessionId)
    {
        System.Text.StringBuilder prefix = new System.Text.StringBuilder(sessionId.BeginString)
            .Append('-').Append(sessionId.SenderCompID);
        if (SessionID.IsSet(sessionId.SenderSubID))
            prefix.Append('_').Append(sessionId.SenderSubID);
        if (SessionID.IsSet(sessionId.SenderLocationID))
            prefix.Append('_').Append(sessionId.SenderLocationID);
        prefix.Append('-').Append(sessionId.TargetCompID);
        if (SessionID.IsSet(sessionId.TargetSubID))
            prefix.Append('_').Append(sessionId.TargetSubID);
        if (SessionID.IsSet(sessionId.TargetLocationID))
            prefix.Append('_').Append(sessionId.TargetLocationID);

        if (SessionID.IsSet(sessionId.SessionQualifier))
            prefix.Append('-').Append(sessionId.SessionQualifier);

        return prefix.ToString();
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,
        Func<TState, Exception?, string> formatter)
    {
        if (!IsEnabled(logLevel)) return;
        if (eventId == LogEventIds.IncomingMessage || eventId == LogEventIds.OutgoingMessage)
        {
            lock (_messagesLock)
            {
                _messageLog.WriteLine(
                    $"{DateTimeConverter.ToFIX(DateTime.UtcNow, TimeStampPrecision.Millisecond)} : {formatter(state, exception)}");
            }
        }
        else
        {
            lock (_eventsLock)
            {
                _eventLog.WriteLine(
                    $"{DateTimeConverter.ToFIX(DateTime.UtcNow, TimeStampPrecision.Millisecond)} : {formatter(state, exception)}");
            }
        }
    }

    public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;

    public void Dispose()
    {
        _messageLog.Dispose();
        _eventLog.Dispose();
    }
}