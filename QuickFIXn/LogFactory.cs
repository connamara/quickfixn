
namespace QuickFix
{
    /// <summary>
    /// Used by a session to create a log implementation
    /// </summary>
    public interface LogFactory
    {
        /// <summary>
        /// Create a log implementation
        /// </summary>
        /// <param name="sessionID">session ID usually used for configuration access</param>
        /// <returns></returns>
        Log Create(SessionID sessionID);
    }
}
