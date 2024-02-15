#nullable enable

namespace QuickFix.Logger;

/// <summary>
/// Creates a message store that stores messages in a file
/// </summary>
public class FileLogFactory : ILogFactory
{
    private readonly SessionSettings _settings;

    #region LogFactory Members

    public FileLogFactory(SessionSettings settings)
    {
        _settings = settings;
    }

    /// <summary>
    /// Creates a file-based message store
    /// </summary>
    /// <param name="sessionId">session ID for the message store</param>
    /// <returns></returns>
    public ILog Create(SessionID sessionId)
    {
        return new FileLog(_settings.Get(sessionId).GetString(SessionSettings.FILE_LOG_PATH), sessionId);
    }

    #endregion
}
