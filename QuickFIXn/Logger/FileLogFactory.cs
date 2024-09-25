namespace QuickFix.Logger;

/// <summary>
/// Creates a message store that stores messages in a file
/// </summary>
public class FileLogFactory : ILogFactory
{
    private readonly SessionSettings _settings;

    public FileLogFactory(SessionSettings settings)
    {
        _settings = settings;
    }

    /// <summary>
    /// Creates a file-based message log
    /// </summary>
    /// <param name="sessionId">session ID for the message log</param>
    /// <returns></returns>
    public ILog Create(SessionID sessionId)
    {
        return new FileLog(_settings.Get(sessionId).GetString(SessionSettings.FILE_LOG_PATH), sessionId);
    }

    public ILog CreateNonSessionLog() {
        return new FileLog(
            _settings.Get().GetString(SessionSettings.FILE_LOG_PATH),
            new SessionID("Non", "Session", "Log"));
    }
}
