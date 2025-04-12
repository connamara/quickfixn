using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Extensions.Logging;

namespace QuickFix
{
    internal class AcceptorSocketDescriptor
    {
        public ThreadedSocketReactor SocketReactor { get; }
        public IPEndPoint Address { get; }

        private readonly Dictionary<SessionID, Session> _acceptedSessions = new ();

        public AcceptorSocketDescriptor(
            IPEndPoint socketEndPoint,
            SocketSettings socketSettings,
            ILogger nonSessionLog)
        {
            Address = socketEndPoint;
            SocketReactor = new ThreadedSocketReactor(Address, socketSettings, this, nonSessionLog);
        }

        [Obsolete("Param 'sessionDict' is unused.  Use the alt constructor without it.")]
        public AcceptorSocketDescriptor(
            IPEndPoint socketEndPoint,
            SocketSettings socketSettings,
            SettingsDictionary sessionDict,
            ILogger nonSessionLog) : this(socketEndPoint, socketSettings, nonSessionLog)
        { }

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
