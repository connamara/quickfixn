
namespace QuickFix
{
    /// <summary>
    /// (Renamed per naming convention.)
    /// </summary>
    [System.Obsolete("Use ILogFactory instead.")]
    public interface LogFactory : ILogFactory { }

    /// <summary>
    /// Used by a session to create a log implementation
    /// </summary>
    public interface ILogFactory
    {
        /// <summary>
        /// Create a log implementation
        /// </summary>
        /// <param name="sessionID">session ID usually used for configuration access</param>
        /// <returns></returns>
        ILog Create(SessionID sessionID);
    }
}
