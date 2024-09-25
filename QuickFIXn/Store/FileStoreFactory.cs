namespace QuickFix.Store;

/// <summary>
/// Creates a message store that stores messages in a file
/// </summary>
public class FileStoreFactory : IMessageStoreFactory
{
    private readonly SessionSettings _settings;

    /// <summary>
    /// Create the factory with configuration in session settings
    /// </summary>
    /// <param name="settings"></param>
    public FileStoreFactory(SessionSettings settings)
    {
        _settings = settings;
    }

    /// <summary>
    /// Creates a file-based message store
    /// </summary>
    /// <param name="sessionId">session ID for the message store</param>
    /// <returns></returns>
    public IMessageStore Create(SessionID sessionId)
    {
        return new FileStore(_settings.Get(sessionId).GetString(SessionSettings.FILE_STORE_PATH), sessionId);
    }
}
