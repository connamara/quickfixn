﻿using System;
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
    public interface IInitiator : IDisposable
    {
        bool IsStopped { get; }

        /// <summary>
        /// Starts a connection with a remote acceptor
        /// </summary>
        void Start();

        /// <summary>
        /// Logout existing session and close connection.  All open resources are released.
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
        bool IsLoggedOn { get; }

        /// <summary>
        /// Get the SessionIDs for the sessions managed by this initiator.
        /// </summary>
        /// <returns>the SessionIDs for the sessions managed by this initiator</returns>
        HashSet<SessionID> GetSessionIDs();

        /// <summary>
        /// Add a new session after initiator has been started
        /// </summary>
        /// <param name="sessionID">ID of session to be added</param>
        /// <param name="dict">session settings</param>
        /// <returns>true if session added successfully, false if session already exists or is not an initiator</returns>
        bool AddSession(SessionID sessionID, QuickFix.Dictionary dict);

        /// <summary>
        /// Remove an existing session after initiator has been started
        /// </summary>
        /// <param name="sessionID">ID of session to be removed</param>
        /// <param name="terminateActiveSession">if true, force disconnection and removal of session even if it has an active connection</param>
        /// <returns>true if session removed or not already present; false if could not be removed due to an active connection</returns>
        bool RemoveSession(SessionID sessionID, bool terminateActiveSession);
    }

    /// <summary>
    /// Extension hack to preserve the public interface.
    /// #220 changed IsLoggedOn from a method to a property, which is good, but changes the public interface,
    /// which we don't want to do until 2.0.  So we will keep the method too.
    /// Normally, you can't have a property and method with the same name, but you can get around
    /// this with an extension method.
    /// </summary>
    [System.Obsolete]
    public static class IInitiatorExtension
    {
        [System.Obsolete("Use the property version instead (i.e. get rid of those parens!)")]
        public static bool IsLoggedOn(this IInitiator init)
        {
            return init.IsLoggedOn;
        }
    }
}
