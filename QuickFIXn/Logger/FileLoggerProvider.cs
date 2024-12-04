using System;
using System.Collections.Concurrent;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

[Obsolete("This class is provided to ease migration from the old logging system to Microsoft.Extensions.Logging." +
          "It is an attempt to maintain the behavior of the previous FileLog and FileLogFactory while plugging into the Microsoft.Extensions.Logging ecosystem. " +
          "Consider using the more robust logging options available in the .NET ecosystem, like the MS Console logging provider, Serilog and NLog.")]
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