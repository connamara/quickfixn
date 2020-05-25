using System.Collections.Generic;
using System.Linq;
using System.Net;
using System;

namespace QuickFix
{
    /// <summary>
    /// Acceptor implementation - with threads
    /// Creates a ThreadedSocketReactor for every listening endpoint.
    /// </summary>
    public class ThreadedSocketAcceptor : IAcceptor
    {
        

        private Dictionary<SessionID, Session> sessions_ = new Dictionary<SessionID, Session>();
        private SessionSettings settings_;
        private Dictionary<IPEndPoint, AcceptorSocketDescriptor> socketDescriptorForAddress_ = new Dictionary<IPEndPoint, AcceptorSocketDescriptor>();
        private SessionFactory sessionFactory_;
        private bool isStarted_ = false;
        private bool _disposed = false;
        private object sync_ = new object();

        #region Constructors

        /// <summary>
        /// Create a ThreadedSocketAcceptor with a NullLogFactory and DefaultMessageFactory
        /// </summary>
        /// <param name="application"></param>
        /// <param name="storeFactory"></param>
        /// <param name="settings"></param>
        public ThreadedSocketAcceptor(IApplication application, IMessageStoreFactory storeFactory, SessionSettings settings)
            : this(application, storeFactory, settings, null, null)
        { }

        /// <summary>
        /// Create a ThreadedSocketAcceptor with a DefaultMessageFactory
        /// </summary>
        /// <param name="application"></param>
        /// <param name="storeFactory"></param>
        /// <param name="settings"></param>
        /// <param name="logFactory"></param>
        public ThreadedSocketAcceptor(IApplication application, IMessageStoreFactory storeFactory, SessionSettings settings, ILogFactory logFactory)
            : this(application, storeFactory, settings, logFactory, null)
        { }

        /// <summary>
        /// Create a ThreadedSocketAcceptor
        /// </summary>
        /// <param name="application"></param>
        /// <param name="storeFactory"></param>
        /// <param name="settings"></param>
        /// <param name="logFactory">If null, a NullFactory will be used.</param>
        /// <param name="messageFactory">If null, a DefaultMessageFactory will be created (using settings parameters)</param>
        public ThreadedSocketAcceptor(
            IApplication application,
            IMessageStoreFactory storeFactory,
            SessionSettings settings,
            ILogFactory logFactory,
            IMessageFactory messageFactory)
        {
            logFactory = logFactory ?? new NullLogFactory();
            messageFactory = messageFactory ?? new DefaultMessageFactory();
            SessionFactory sf = new SessionFactory(application, storeFactory, logFactory, messageFactory);

            try
            {
                CreateSessions(settings, sf);
            }
            catch (System.Exception e)
            {
                throw new ConfigError(e.Message, e);
            }
        }

        [Obsolete("Will be removed in a future release.")]
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
            sessionFactory_ = sessionFactory;
            settings_ = settings;
            foreach (SessionID sessionID in settings.GetSessions())
            {
                QuickFix.Dictionary dict = settings.Get(sessionID);
                CreateSession(sessionID, dict);
            }

            if (0 == socketDescriptorForAddress_.Count)
                throw new ConfigError("No acceptor sessions found in SessionSettings.");
        }

        private AcceptorSocketDescriptor GetAcceptorSocketDescriptor(Dictionary dict)
        {
            int port = System.Convert.ToInt32(dict.GetLong(SessionSettings.SOCKET_ACCEPT_PORT));
            SocketSettings socketSettings = new SocketSettings();

            IPEndPoint socketEndPoint;
            if (dict.Has(SessionSettings.SOCKET_ACCEPT_HOST))
            {
                string host = dict.GetString(SessionSettings.SOCKET_ACCEPT_HOST);                
                IPAddress[] addrs = Dns.GetHostAddresses(host);
                socketEndPoint = new IPEndPoint(addrs[0], port);
                // Set hostname (if it is not already configured)
                socketSettings.ServerCommonName = socketSettings.ServerCommonName ?? host;
            }
            else
            {
                socketEndPoint = new IPEndPoint(IPAddress.Any, port);
            }

            socketSettings.Configure(dict);
            

            AcceptorSocketDescriptor descriptor;
            if (!socketDescriptorForAddress_.TryGetValue(socketEndPoint, out descriptor))
            {
                descriptor = new AcceptorSocketDescriptor(socketEndPoint, socketSettings, dict);
                socketDescriptorForAddress_[socketEndPoint] = descriptor;
            }

            return descriptor;
        }

        /// <summary>
        /// Create session, either at start-up or as an ad-hoc operation
        /// </summary>
        /// <param name="sessionID">ID of new session</param>
        /// <param name="dict">config settings for new session</param>
        /// <returns>true if session added successfully, false if session already exists or is not an acceptor</returns>
        private bool CreateSession(SessionID sessionID, Dictionary dict)
        {
            if (!sessions_.ContainsKey(sessionID))
            {
                string connectionType = dict.GetString(SessionSettings.CONNECTION_TYPE);
                if ("acceptor" == connectionType)
                {
                    AcceptorSocketDescriptor descriptor = GetAcceptorSocketDescriptor(dict);
                    Session session = sessionFactory_.Create(sessionID, dict);
                    descriptor.AcceptSession(session);
                    sessions_[sessionID] = session;
                    return true;
                }
            }
            return false;
        }

        private void StartAcceptingConnections()
        {
            lock (sync_)
            {
                // FIXME StartSessionTimer();
                foreach (AcceptorSocketDescriptor socketDescriptor in socketDescriptorForAddress_.Values)
                {
                    socketDescriptor.SocketReactor.Start();
                    // FIXME log_.Info("Listening for connections on " + socketDescriptor.getAddress());
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
                    // FIXME log_.Info("No longer accepting connections on " + socketDescriptor.getAddress());
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
                    // FIXME logError(session.getSessionID(), "Error during logout", e);
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
                        // FIXME logError(session.getSessionID(), "Error during disconnect", e);
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

        private void DisposeSessions()
        {
            foreach (var session in sessions_.Values)
            {
                session.Dispose();
            }
        }

        #endregion

        #region Acceptor Members

        public void Start()
        {
            if (_disposed)
                throw new ObjectDisposedException(GetType().Name);

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
            if (_disposed)
                throw new ObjectDisposedException(GetType().Name);

            StopAcceptingConnections();
            LogoutAllSessions(force);
            DisposeSessions();
            sessions_.Clear();

            // FIXME StopSessionTimer();
            // FIXME Session.UnregisterSessions(GetSessions());
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

        /// <summary>
        /// Add new session as an ad-oc (dynamic) operation
        /// </summary>
        /// <param name="sessionID">ID of new session</param>
        /// <param name="dict">config settings for new session</param>
        /// <returns>true if session added successfully, false if session already exists or is not an acceptor</returns>
        public bool AddSession(SessionID sessionID, Dictionary dict)
        {
            lock (settings_)
                if (!settings_.Has(sessionID)) // session won't be in settings if ad-hoc creation after startup
                    settings_.Set(sessionID, dict); // need to to this here to merge in default config settings
                else
                    return false; // session already exists

            if (CreateSession(sessionID, dict))
                return true;

            lock (settings_) // failed to create session, so remove from settings
                settings_.Remove(sessionID);
            return false;
        }


        /// <summary>
        /// Ad-hoc removal of an existing session
        /// </summary>
        /// <param name="sessionID">ID of session to be removed</param>
        /// <param name="terminateActiveSession">if true, force disconnection and removal of session even if it has an active connection</param>
        /// <returns>true if session removed or not already present; false if could not be removed due to an active connection</returns>
        public bool RemoveSession(SessionID sessionID, bool terminateActiveSession)
        {
            Session session = null;
            if (sessions_.TryGetValue(sessionID, out session))
            {
                if (session.IsLoggedOn && !terminateActiveSession)
                    return false;
                session.Disconnect("Dynamic session removal");
                foreach (AcceptorSocketDescriptor descriptor in socketDescriptorForAddress_.Values)
                    if (descriptor.RemoveSession(sessionID))
                        break;
                sessions_.Remove(sessionID);
                session.Dispose();
                lock (settings_)
                    settings_.Remove(sessionID);
            }
            return true;
        }

        #endregion

        /// <summary>
        /// Any subclasses of ThreadedSocketAcceptor should override this if they have resources to dispose
        /// Any override should call base.Dispose(disposing).
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            try
            {
                Stop();
                _disposed = true;
            }
            catch (ObjectDisposedException)
            {
                // ignore
            }
        }

        /// <summary>
        /// Disposes created sessions
        /// </summary>
        /// <remarks>
        /// To simply stop the acceptor without disposing sessions, use Stop() or Stop(bool)
        /// </remarks>
        public void Dispose()
        {
            Stop();
        }
    }
}
