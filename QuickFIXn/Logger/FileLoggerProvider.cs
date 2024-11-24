using System;
using System.Collections.Concurrent;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

public class FileLoggerProvider : ILoggerProvider
{
    private readonly SessionSettings _settings;
    private readonly ConcurrentDictionary<SessionID, ILogger> _loggers = new();

    public FileLoggerProvider(SessionSettings settings)
    {
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

        return _loggers.GetOrAdd(sessionId ?? defaultSessionId, sessionId is not null
            ? new FileLogger(_settings.Get(sessionId).GetString(SessionSettings.FILE_LOG_PATH), sessionId)
            : new NonSessionFileLogger(_settings.Get().GetString(SessionSettings.FILE_LOG_PATH), defaultSessionId));
    }

    public void Dispose()
    {
    }
}