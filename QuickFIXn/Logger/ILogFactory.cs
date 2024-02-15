#nullable enable

namespace QuickFix.Logger;

/// <summary>
/// Used by a session to create a log implementation
/// </summary>
public interface ILogFactory
{
    /// <summary>
    /// Create a log implementation
    /// </summary>
    /// <param name="sessionId">session ID usually used for configuration access</param>
    /// <returns></returns>
    ILog Create(SessionID sessionId);
}
