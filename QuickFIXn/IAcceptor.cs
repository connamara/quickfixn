using System.Net;
using System.Collections.Generic;

namespace QuickFix
{
    /// <summary>
    /// Accepts connections from FIX clients and manages the associated sessions.
    /// </summary>
    public interface IAcceptor
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
        /// <returns>>true if session added succesfully, false if session already exists or is of wrong type</returns>
        bool AddSession(SessionID sessionID, QuickFix.Dictionary dict);

        /// <summary>
        /// Remove an existing session after acceptor has been started
        /// </summary>
        /// <param name="sessionID">ID of session to be removed</param>
        /// <param name="terminateActiveSession">true if sesion to be removed even if it has an active connection</param>
        /// <returns>true if session removed or was already not present, false if could not be removed because of active connection</returns>
        bool RemoveSession(SessionID sessionID, bool terminateActiveSession);
    }

    /// <summary>
    /// (Renamed per naming convention.)
    /// </summary>
    [System.Obsolete("Use IAcceptor instead")]
    public interface Acceptor : IAcceptor
    { }

    /// <summary>
    /// Extension hack to preserve the public interface.
    /// #220 changed IsLoggedOn from a method to a property, which is good, but changes the public interface,
    /// which we don't want to do until 2.0.  So we will keep the method too.
    /// Normally, you can't have a property and method with the same name, but you can get around
    /// this with an extension method.
    /// </summary>
    [System.Obsolete]
    public static class IAcceptorExtension
    {
        [System.Obsolete("Use the property version instead (i.e. get rid of those parens!)")]
        public static bool IsLoggedOn(this IAcceptor acc)
        {
            return acc.IsLoggedOn;
        }
    }
}
