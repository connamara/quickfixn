using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// Public interface for initiator.
    /// Establishes sessions with FIX servers and manages the associated sessions.
    /// The class AbstractInitiator contains a default base implementation.
    /// </summary>
    public interface IInitiator
    {
        bool IsStopped { get; }

        /// <summary>
        /// Starts a connection with a remote acceptor
        /// </summary>
        void Start();

        /// <summary>
        /// Logout existing session and close connection
        /// </summary>
        void Stop();

        /// <summary>
        /// Stops existing session, optinally waiting for logout completion
        /// </summary>
        /// <param name="force">don't wait for logout before disconnect</param>
        void Stop(bool force);

        /// <summary>
        /// Checks the logged on status of the session
        /// </summary>
        /// <returns>true if the session is logged on, false otherwise</returns>
        bool IsLoggedOn();

        /// <summary>
        /// Get the SessionIDs for the sessions managed by this initiator.
        /// </summary>
        /// <returns>the SessionIDs for the sessions managed by this initiator</returns>
        HashSet<SessionID> GetSessionIDs();
    }
}
