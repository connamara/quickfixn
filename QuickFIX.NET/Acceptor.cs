using System.Net;
using System.Collections.Generic;

namespace QuickFix
{
    /// <summary>
    /// Accepts connections from FIX clients and manages the associated sessions.
    /// </summary>
    public interface Acceptor
    {
        /// <summary>
        /// Start accepting connections
        /// </summary>
        void Start();

        /// <summary>
        /// Close exising connections and stop accepting new ones
        /// </summary>
        void Stop();

        /// <summary>
        /// Close exising connections and stop accepting new ones
        /// </summary>
        /// <param name="force">If true, do not wait for existing Sessions to logout</param>
        void Stop(bool force);

        /// <summary>
        /// Check whether any sessions are logged on
        /// </summary>
        /// <returns>true if any session is logged on, else false</returns>
        bool IsLoggedOn();

        /// <summary>
        /// Get the SessionIDs managed by this Acceptor
        /// </summary>
        /// <returns>the SessionIDs managed by this Acceptor</returns>
        HashSet<SessionID> GetSessionIDs();

        /// <summary>
        /// Get the Sessions managed by this Acceptor
        /// </summary>
        /// <returns>the Sessions managed by this Acceptor</returns>
        HashSet<Session> GetSessions();

        /// <summary>
        /// Get accepted socket end points
        /// </summary>
        /// <returns>a map of SessionIDs to EndPoints</returns>
        Dictionary<SessionID,IPEndPoint> GetAcceptorAddresses();
    }
}
