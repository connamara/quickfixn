using System.Collections.Generic;
using System.Linq;
using System.Net;
using System;
using System.Threading;
using QuickFix.Logger;
using QuickFix.Store;

namespace QuickFix
{
    // TODO v2.0 - consider changing to internal

    /// <summary>
    /// Acceptor implementation - with threads
    /// Creates a ThreadedSocketReactor for every listening endpoint.
    /// </summary>
    public class ThreadedSocketAcceptor : IAcceptor
    {
        private readonly Dictionary<SessionID, Session> _sessions = new();
        private readonly SessionSettings _settings;
        private readonly Dictionary<IPEndPoint, AcceptorSocketDescriptor> _socketDescriptorForAddress = new();
        private readonly SessionFactory _sessionFactory;
        private bool _isStarted = false;
        private bool _disposed = false;
        private readonly object _sync = new();
        private readonly NonSessionLog _nonSessionLog;

        #region Constructors

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
            ILogFactory? logFactory = null,
            IMessageFactory? messageFactory = null)
        {
            ILogFactory lf = logFactory ?? new NullLogFactory();
            IMessageFactory mf = messageFactory ?? new DefaultMessageFactory();
            _settings = settings;
            _sessionFactory = new SessionFactory(application, storeFactory, lf, mf);
            _nonSessionLog = new NonSessionLog(lf);

            try
            {
                foreach (SessionID sessionId in settings.GetSessions())
                {
                    SettingsDictionary dict = settings.Get(sessionId);
                    CreateSession(sessionId, dict);
                }
            }
            catch (Exception e)
            {
                throw new ConfigError(e.Message, e);
            }
        }

        #endregion

        #region Private Methods

        private AcceptorSocketDescriptor GetAcceptorSocketDescriptor(SettingsDictionary dict)
        {
            int port = System.Convert.ToInt32(dict.GetLong(SessionSettings.SOCKET_ACCEPT_PORT));
            SocketSettings socketSettings = new SocketSettings();

            IPEndPoint socketEndPoint;
            if (dict.Has(SessionSettings.SOCKET_ACCEPT_HOST))
            {
                string host = dict.GetString(SessionSettings.SOCKET_ACCEPT_HOST);

                if (IsAnyIpAddress(host))
                {
                    socketEndPoint = new IPEndPoint(IPAddress.Any, port);
                }
                else
                {
                    IPAddress[] addrs = Dns.GetHostAddresses(host);
                    socketEndPoint = new IPEndPoint(addrs[0], port);
                    // Set hostname (if it is not already configured)
                    socketSettings.ServerCommonName ??= host;
                }
            }
            else
            {
                socketEndPoint = new IPEndPoint(IPAddress.Any, port);
            }

            socketSettings.Configure(dict);

            if (!_socketDescriptorForAddress.TryGetValue(socketEndPoint, out var descriptor))
            {
                descriptor = new AcceptorSocketDescriptor(socketEndPoint, socketSettings, _nonSessionLog);
                _socketDescriptorForAddress[socketEndPoint] = descriptor;
            }

            return descriptor;
        }

        /// <summary>
        /// Checks if the host address is the "any" address in either IPv4 (0.0.0.0) or IPv6 (::)
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        private static bool IsAnyIpAddress(string host)
        {
            return IPAddress.TryParse(host, out IPAddress? address) &&
                   (address.Equals(IPAddress.Any) ||
                    address.Equals(IPAddress.IPv6Any));
        }

        /// <summary>
        /// Create session, either at start-up or as an ad-hoc operation
        /// </summary>
        /// <param name="sessionId">ID of new session</param>
        /// <param name="dict">config settings for new session</param>
        /// <returns>true if session added successfully, false if session already exists or is not an acceptor</returns>
        private bool CreateSession(SessionID sessionId, SettingsDictionary dict)
        {
            if (!_sessions.ContainsKey(sessionId))
            {
                string connectionType = dict.GetString(SessionSettings.CONNECTION_TYPE);
                if ("acceptor" == connectionType)
                {
                    AcceptorSocketDescriptor descriptor = GetAcceptorSocketDescriptor(dict);
                    Session session = _sessionFactory.Create(sessionId, dict);
                    descriptor.AcceptSession(session);
                    _sessions[sessionId] = session;

                    // start SocketReactor if it was created via AddSession call
                    // and if acceptor is already started
                    if (_isStarted && !_disposed)
                    {
                        descriptor.SocketReactor.Start();
                    }

                    return true;
                }
            }
            return false;
        }

        private void StartAcceptingConnections()
        {
            lock (_sync)
            {
                foreach (AcceptorSocketDescriptor socketDescriptor in _socketDescriptorForAddress.Values)
                {
                    socketDescriptor.SocketReactor.Start();
                }
            }
        }

        private void StopAcceptingConnections()
        {
            lock (_sync)
            {
                foreach (AcceptorSocketDescriptor socketDescriptor in _socketDescriptorForAddress.Values)
                {
                    socketDescriptor.SocketReactor.Shutdown();
                }
            }
        }

        private void LogonAllSessions()
        {
            foreach (Session session in _sessions.Values)
            {
                try
                {
                    session.Logon();
                }
                catch (System.Exception e)
                {
                    LogEvent( session.Log, "Error during logon of Session " + session.SessionID + ": " + e.Message);
                }
            }
        }

        private void LogoutAllSessions(bool force)
        {
            foreach (Session session in _sessions.Values)
            {
                try
                {
                    session.Logout();
                }
                catch (System.Exception e)
                {
                    LogEvent(session.Log, "Error during logout of Session " + session.SessionID + ": " + e.Message);
                }
            }

            if (force && IsLoggedOn)
            {
                DisconnectSessions("Forcibly disconnecting session");
            }

            if (!force)
                WaitForLogout();
        }

        private static void LogEvent( ILog log, string message )
        {
            if( log != null )
            {
                log.OnEvent( message );
            }
        }

        private const int TenSecondsInTicks = 10000;

        /// <summary>
        /// FIXME
        /// </summary>
        private void WaitForLogout()
        {
            int start = Environment.TickCount;
            using( var resetEvent = new ManualResetEvent( false ) )
            {
                while (IsLoggedOn && (Environment.TickCount - start) < TenSecondsInTicks)
                {
                    resetEvent.WaitOne( 100 );
                }
            }
            DisconnectSessions("Logout timeout, force disconnect");
        }

        private void DisconnectSessions(string disconnectMessage)
        {
            foreach (Session session in _sessions.Values)
            {
                try
                {
                    if (session.IsLoggedOn)
                        session.Disconnect(disconnectMessage);
                }
                catch (System.Exception e)
                {
                    LogEvent( session.Log, "Error during disconnect of Session " + session.SessionID + ": " + e.Message );
                }
            }
        }

        private void DisposeSessions()
        {
            foreach (var session in _sessions.Values)
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

            lock (_sync)
            {
                if (!_isStarted)
                {
                    LogonAllSessions();
                    StartAcceptingConnections();
                    _isStarted = true;
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

            lock( _sync )
            {
                if( _isStarted )
                {
                    _isStarted = false;
                    LogoutAllSessions(force);
                    StopAcceptingConnections();
                }
            }
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
                return _sessions.Values.Any(session => session.IsLoggedOn);
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is started.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is started; otherwise, <c>false</c>.
        /// </value>
        public bool IsStarted
        {
            get
            {
                return _isStarted;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is started.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is started; otherwise, <c>false</c>.
        /// </value>
        public bool AreSocketsRunning
        {
            get
            {
                return _socketDescriptorForAddress.All( s => s.Value.SocketReactor.IsRunning );
            }
        }

        /// <summary>
        /// Get the SessionIDs for the sessions managed by this acceptor.
        /// </summary>
        /// <returns>the SessionIDs for the sessions managed by this acceptor</returns>
        public HashSet<SessionID> GetSessionIDs()
        {
            return new HashSet<SessionID>(_sessions.Keys);
        }

        /// <summary>
        /// TODO: not yet implemented
        /// </summary>
        /// <returns></returns>
        public Dictionary<SessionID, IPEndPoint> GetAcceptorAddresses()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add new session as an ad-oc (dynamic) operation
        /// </summary>
        /// <param name="sessionId">ID of new session</param>
        /// <param name="dict">config settings for new session</param>
        /// <returns>true if session added successfully, false if session already exists or is not an acceptor</returns>
        public bool AddSession(SessionID sessionId, SettingsDictionary dict)
        {
            lock (_settings)
                if (!_settings.Has(sessionId)) // session won't be in settings if ad-hoc creation after startup
                    _settings.Set(sessionId, dict); // need to to this here to merge in default config settings
                else
                    return false; // session already exists

            if (CreateSession(sessionId, dict))
                return true;

            lock (_settings) // failed to create session, so remove from settings
                _settings.Remove(sessionId);
            return false;
        }


        /// <summary>
        /// Ad-hoc removal of an existing session
        /// </summary>
        /// <param name="sessionId">ID of session to be removed</param>
        /// <param name="terminateActiveSession">if true, force disconnection and removal of session even if it has an active connection</param>
        /// <returns>true if session removed or not already present; false if could not be removed due to an active connection</returns>
        public bool RemoveSession(SessionID sessionId, bool terminateActiveSession)
        {
            if (_sessions.TryGetValue(sessionId, out var session))
            {
                if (session.IsLoggedOn && !terminateActiveSession)
                    return false;
                session.Disconnect("Dynamic session removal");
                foreach (AcceptorSocketDescriptor descriptor in _socketDescriptorForAddress.Values)
                    if (descriptor.RemoveSession(sessionId))
                        break;
                _sessions.Remove(sessionId);
                session.Dispose();
                lock (_settings)
                    _settings.Remove(sessionId);
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
            if( _disposed ) return;
            try
            {
                Stop();
                DisposeSessions();
                _sessions.Clear();
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
            Dispose( true );
            GC.SuppressFinalize( this );
        }
    }
}
