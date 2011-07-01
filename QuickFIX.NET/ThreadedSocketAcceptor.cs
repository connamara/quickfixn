using System.Collections.Generic;
using System.Threading;
using System.Net;

namespace QuickFix
{
    public class ThreadedSocketAcceptor : Acceptor
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

            public AcceptorSocketDescriptor(IPEndPoint socketEndPoint)
            {
                socketEndPoint_ = socketEndPoint;
                socketReactor_ = new ThreadedSocketReactor(socketEndPoint_);
            }

            public void AcceptSession(Session session)
            {
                acceptedSessions_[session.SessionID] = session;
            }

            public Dictionary<SessionID, Session> GetAcceptedSessions() 
            {
                return new Dictionary<SessionID,Session>(acceptedSessions_);
            }
        }

        private SessionSettings settings_;
        private SessionFactory sessionFactory_;
        private Dictionary<SessionID, Session> sessions_ = new Dictionary<SessionID, Session>();
        private Dictionary<IPEndPoint, AcceptorSocketDescriptor> socketDescriptorForAddress_ = new Dictionary<IPEndPoint, AcceptorSocketDescriptor>();
        private bool isStarted_ = false;
        private object sync_ = new object();

        #region Constructors

        public ThreadedSocketAcceptor(Application application, MessageStoreFactory storeFactory, SessionSettings settings)
            : this(new SessionFactory(application, storeFactory), settings)
        { }

        public ThreadedSocketAcceptor(Application application, MessageStoreFactory storeFactory, SessionSettings settings, LogFactory logFactory)
            : this(new SessionFactory(application, storeFactory, logFactory), settings)
        { }

        public ThreadedSocketAcceptor(SessionFactory sessionFactory, SessionSettings settings)
        {
            settings_ = settings;
            sessionFactory_ = sessionFactory;

            try
            {
                CreateSessions(settings_);
            }
            catch (System.Exception e)
            {
                throw new ConfigError(e.Message, e);
            }
        }

        #endregion

        #region Private Methods

        private void CreateSessions(SessionSettings settings)
	    {
            foreach(SessionID sessionID in settings.GetSessions())
		    {
                QuickFix.Dictionary dict = settings.Get(sessionID);
                string connectionType = dict.GetString(SessionSettings.CONNECTION_TYPE);
               
                if("acceptor".Equals(connectionType))
			    {
                    AcceptorSocketDescriptor descriptor = GetAcceptorSocketDescriptor(settings, sessionID);
                    Session session = sessionFactory_.Create(sessionID, dict);
                    descriptor.AcceptSession(session);
                    sessions_[sessionID] = session;
                }
            }

            if(0 == socketDescriptorForAddress_.Count)
                throw new ConfigError("No acceptor sessions found in SessionSettings.");
        }

        private AcceptorSocketDescriptor GetAcceptorSocketDescriptor(SessionSettings settings, SessionID sessionID)
        {
            QuickFix.Dictionary dict = settings_.Get(sessionID);
            int port = System.Convert.ToInt32(dict.GetLong(SessionSettings.SOCKET_ACCEPT_PORT));

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

            AcceptorSocketDescriptor descriptor;
            if (!socketDescriptorForAddress_.TryGetValue(socketEndPoint, out descriptor))
            {
                descriptor = new AcceptorSocketDescriptor(socketEndPoint);
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
            foreach(Session session in sessions_.Values)
            {
                try
                {
                    session.Logout();
                }
                catch(System.Exception e)
                {
                    /// FIXME logError(session.getSessionID(), "Error during logout", e);
                    System.Console.WriteLine("Error during logout of Session " + session.SessionID + ": " + e.Message);
                }
            }

            if (force && IsLoggedOn())
            {
                foreach (Session session in sessions_.Values)
                {
                    try
                    {
                        if (session.IsLoggedOn)
                            session.Disconnect("Forcibly disconnecting session");
                    }
                    catch(System.Exception e)
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
            lock(sync_)
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

        public bool IsLoggedOn()
        {
            throw new System.NotImplementedException();
        }

        public HashSet<SessionID> GetSessionIDs()
        {
            throw new System.NotImplementedException();
        }

        public HashSet<Session> GetSessions()
        {
            throw new System.NotImplementedException();
        }

        public Dictionary<SessionID, IPEndPoint> GetAcceptorAddresses()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
