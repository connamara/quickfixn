using System.Collections.Generic;
using System.Linq;
using System.Net;
using System;

namespace QuickFix
{
    // TODO v2.0 - consider changing to internal

    /// <summary>
    /// Acceptor implementation - with threads
    /// Creates a ThreadedSocketReactor for every listening endpoint.
    /// </summary>
    public class ThreadedSocketAcceptor : IAcceptor
    {
        class AcceptorSocketDescriptor
        {
            #region Properties

            public ThreadedSocketReactor SocketReactor
            {
                get { return socketReactor_; }
            }

            public IPEndPoint Address
            {
                get { return socketEndPoint_; }
            }

            #endregion

            #region Private Members

            private ThreadedSocketReactor socketReactor_;
            private IPEndPoint socketEndPoint_;
            private Dictionary<SessionID, Session> acceptedSessions_ = new Dictionary<SessionID, Session>();

            #endregion
            
            public AcceptorSocketDescriptor(IPEndPoint socketEndPoint, SocketSettings socketSettings, QuickFix.Dictionary sessionDict)
            {
                socketEndPoint_ = socketEndPoint;
                socketReactor_ = new ThreadedSocketReactor(socketEndPoint_, socketSettings, sessionDict);
            }

            public void AcceptSession(Session session)
            {
                acceptedSessions_[session.SessionID] = session;
            }

            public Dictionary<SessionID, Session> GetAcceptedSessions()
            {
                return new Dictionary<SessionID, Session>(acceptedSessions_);
            }
        }

        private Dictionary<SessionID, Session> sessions_ = new Dictionary<SessionID, Session>();
        private Dictionary<IPEndPoint, AcceptorSocketDescriptor> socketDescriptorForAddress_ = new Dictionary<IPEndPoint, AcceptorSocketDescriptor>();
        private bool isStarted_ = false;
        private object sync_ = new object();

        #region Constructors

        public ThreadedSocketAcceptor(IApplication application, IMessageStoreFactory storeFactory, SessionSettings settings)
            : this(new SessionFactory(application, storeFactory), settings)
        { }

        public ThreadedSocketAcceptor(IApplication application, IMessageStoreFactory storeFactory, SessionSettings settings, ILogFactory logFactory)
            : this(new SessionFactory(application, storeFactory, logFactory), settings)
        { }

        public ThreadedSocketAcceptor(IApplication application, IMessageStoreFactory storeFactory, SessionSettings settings, ILogFactory logFactory, IMessageFactory messageFactory)
            : this(new SessionFactory(application, storeFactory, logFactory, messageFactory), settings)
        { }

        public ThreadedSocketAcceptor(SessionFactory sessionFactory, SessionSettings settings)
        {
            try
            {
                CreateSessions(settings, sessionFactory);
            }
            catch (System.Exception e)
            {
                throw new ConfigError(e.Message, e);
            }
        }

        #endregion

        #region Private Methods

        private void CreateSessions(SessionSettings settings, SessionFactory sessionFactory)
        {
            foreach (SessionID sessionID in settings.GetSessions())
            {
                QuickFix.Dictionary dict = settings.Get(sessionID);
                string connectionType = dict.GetString(SessionSettings.CONNECTION_TYPE);

                if ("acceptor".Equals(connectionType))
                {
                    AcceptorSocketDescriptor descriptor = GetAcceptorSocketDescriptor(settings, sessionID);
                    Session session = sessionFactory.Create(sessionID, dict);
                    descriptor.AcceptSession(session);
                    sessions_[sessionID] = session;
                }
            }

            if (0 == socketDescriptorForAddress_.Count)
                throw new ConfigError("No acceptor sessions found in SessionSettings.");
        }

        private AcceptorSocketDescriptor GetAcceptorSocketDescriptor(SessionSettings settings, SessionID sessionID)
        {
            QuickFix.Dictionary dict = settings.Get(sessionID);
            int port = System.Convert.ToInt32(dict.GetLong(SessionSettings.SOCKET_ACCEPT_PORT));
            SocketSettings socketSettings = new SocketSettings();

            IPEndPoint socketEndPoint;
            if (dict.Has(SessionSettings.SOCKET_ACCEPT_HOST))
            {
                string host = dict.GetString(SessionSettings.SOCKET_ACCEPT_HOST);
                IPAddress[] addrs = Dns.GetHostAddresses(host);
                socketEndPoint = new IPEndPoint(addrs[0], port);
            }
            else
            {
                socketEndPoint = new IPEndPoint(IPAddress.Any, port);
            }

            if (dict.Has(SessionSettings.SOCKET_NODELAY))
            {
                socketSettings.SocketNodelay = dict.GetBool(SessionSettings.SOCKET_NODELAY);
            }

            AcceptorSocketDescriptor descriptor;
            if (!socketDescriptorForAddress_.TryGetValue(socketEndPoint, out descriptor))
            {
                descriptor = new AcceptorSocketDescriptor(socketEndPoint, socketSettings, dict);
                socketDescriptorForAddress_[socketEndPoint] = descriptor;
            }

            return descriptor;
        }

        private void StartAcceptingConnections()
        {
            lock (sync_)
            {
                /// FIXME StartSessionTimer();
                foreach (AcceptorSocketDescriptor socketDescriptor in socketDescriptorForAddress_.Values)
                {
                    socketDescriptor.SocketReactor.Start();
                    /// FIXME log_.Info("Listening for connections on " + socketDescriptor.getAddress());
                }
            }
        }

        private void StopAcceptingConnections()
        {
            lock (sync_)
            {
                foreach (AcceptorSocketDescriptor socketDescriptor in socketDescriptorForAddress_.Values)
                {
                    socketDescriptor.SocketReactor.Shutdown();
                    /// FIXME log_.Info("No longer accepting connections on " + socketDescriptor.getAddress());
                }
            }
        }

        private void LogoutAllSessions(bool force)
        {
            foreach (Session session in sessions_.Values)
            {
                try
                {
                    session.Logout();
                }
                catch (System.Exception e)
                {
                    /// FIXME logError(session.getSessionID(), "Error during logout", e);
                    System.Console.WriteLine("Error during logout of Session " + session.SessionID + ": " + e.Message);
                }
            }

            if (force && IsLoggedOn)
            {
                foreach (Session session in sessions_.Values)
                {
                    try
                    {
                        if (session.IsLoggedOn)
                            session.Disconnect("Forcibly disconnecting session");
                    }
                    catch (System.Exception e)
                    {
                        /// FIXME logError(session.getSessionID(), "Error during disconnect", e);
                        System.Console.WriteLine("Error during disconnect of Session " + session.SessionID + ": " + e.Message);
                    }
                }
            }

            if (!force)
                WaitForLogout();
        }

        /// <summary>
        /// FIXME
        /// </summary>
        private void WaitForLogout()
        {
            System.Console.WriteLine("TODO - ThreadedSocketAcceptor.WaitForLogout not implemented!");
            /*
            int start = System.Environment.TickCount;
            HashSet<Session> sessions = new HashSet<Session>(sessions_.Values);
            while(sessions.Count > 0)
            {
                Thread.Sleep(100);
                
                int elapsed = System.Environment.TickCount - start;
                Iterator<Session> sessionItr = loggedOnSessions.iterator();
                while (sessionItr.hasNext())
                {
                    Session session = sessionItr.next();
                    if (elapsed >= session.getLogoutTimeout() * 1000L)
                    {
                        session.disconnect("Logout timeout, force disconnect", false);
                        sessionItr.remove();
                    }
                }
                // Be sure we don't look forever
                if (elapsed > 60000)
                {
                    log.warn("Stopping session logout wait after 1 minute");
                    break;
                }
            }
            */
        }

        #endregion

        #region Acceptor Members

        public void Start()
        {
            lock (sync_)
            {
                if (!isStarted_)
                {
                    StartAcceptingConnections();
                    isStarted_ = true;
                }
            }
        }

        public void Stop()
        {
            Stop(false);
        }

        public void Stop(bool force)
        {
            StopAcceptingConnections();
            LogoutAllSessions(force);
            /// FIXME StopSessionTimer();
            /// FIXME Session.UnregisterSessions(GetSessions());
        }

        /// <summary>
        /// Check whether any sessions are logged on
        /// </summary>
        /// <returns>true if any session is logged on, else false</returns>
        public bool IsLoggedOn
        {
            get
            {
                return sessions_.Values.Any(session => session.IsLoggedOn);
            }
        }

        /// <summary>
        /// Get the SessionIDs for the sessions managed by this acceptor.
        /// </summary>
        /// <returns>the SessionIDs for the sessions managed by this acceptor</returns>
        public HashSet<SessionID> GetSessionIDs()
        {
            return new HashSet<SessionID>(sessions_.Keys);
        }

        /// <summary>
        /// TODO: not yet implemented
        /// </summary>
        /// <returns></returns>
        public Dictionary<SessionID, IPEndPoint> GetAcceptorAddresses()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
