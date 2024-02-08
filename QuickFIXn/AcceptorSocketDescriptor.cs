#nullable enable
using System.Collections.Generic;
using System.Net;

namespace QuickFix
{
    internal class AcceptorSocketDescriptor
    {
        #region Properties

        public ThreadedSocketReactor SocketReactor { get; }

        public IPEndPoint Address { get; }

        #endregion

        #region Private Members

        private readonly Dictionary<SessionID, Session> _acceptedSessions = new ();

        #endregion

        public AcceptorSocketDescriptor(IPEndPoint socketEndPoint, SocketSettings socketSettings, QuickFix.SettingsDictionary sessionDict)
        {
            Address = socketEndPoint;
            SocketReactor = new ThreadedSocketReactor(Address, socketSettings, sessionDict, this);
        }

        internal void AcceptSession(Session session)
        {
            lock (_acceptedSessions)
            {
                _acceptedSessions[session.SessionID] = session;
            }
        }

        /// <summary>
        /// Remove a session from those tied to this socket.
        /// </summary>
        /// <param name="sessionId">ID of session to be removed</param>
        /// <returns>true if session removed, false if not found</returns>
        internal bool RemoveSession(SessionID sessionId)
        {
            lock (_acceptedSessions)
            {
                return _acceptedSessions.Remove(sessionId);
            }
        }

        internal Dictionary<SessionID, Session> GetAcceptedSessions()
        {
            lock (_acceptedSessions)
            {
                return new Dictionary<SessionID, Session>(_acceptedSessions);
            }
        }
    }
}
