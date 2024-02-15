using System;
using System.Net;
using System.Collections.Generic;

namespace QuickFix
{
    /// <summary>
    /// Accepts connections from FIX clients and manages the associated sessions.
    /// </summary>
    public interface IAcceptor : IDisposable
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
        bool IsLoggedOn { get; }

        /// <summary>
        /// Get the SessionIDs for the sessions managed by this acceptor.
        /// </summary>
        /// <returns>the SessionIDs for the sessions managed by this acceptor</returns>
        HashSet<SessionID> GetSessionIDs();

        /// <summary>
        /// Get accepted socket end points
        /// </summary>
        /// <returns>a map of SessionIDs to EndPoints</returns>
        Dictionary<SessionID,IPEndPoint> GetAcceptorAddresses();

        /// <summary>
        /// Add a new session after acceptor has been started
        /// </summary>
        /// <param name="sessionID">ID of session to be added</param>
        /// <param name="dict">session settings</param>
        /// <returns>>true if session added successfully, false if session already exists or is not an acceptor</returns>
        bool AddSession(SessionID sessionID, QuickFix.SettingsDictionary dict);

        /// <summary>
        /// Remove an existing session after acceptor has been started
        /// </summary>
        /// <param name="sessionID">ID of session to be removed</param>
        /// <param name="terminateActiveSession">if true, force disconnection and removal of session even if it has an active connection</param>
        /// <returns>true if session removed or not already present; false if could not be removed due to an active connection</returns>
        bool RemoveSession(SessionID sessionID, bool terminateActiveSession);
    }
}
