#nullable enable

namespace QuickFix.Logger;

/// <summary>
/// Creates a log instance
/// </summary>
public interface ILogFactory
{
    /// <summary>
    /// Create a log instance for a session
    /// </summary>
    /// <param name="sessionId">session ID usually used for configuration access</param>
    /// <returns></returns>
    ILog Create(SessionID sessionId);

    /// <summary>
    /// Create a log instance that is not tied to a session.
    /// This log will
    /// (1) only be used for messages that cannot be linked to a session
    /// (2) only have its OnEvent() method called
    /// (3) only be created when a message is logged (to avoid empty log files)
    /// Messages are written to this log only on rare occasions.  It's possible you may never see it created.
    /// </summary>
    /// <returns></returns>
    ILog CreateNonSessionLog();
}
