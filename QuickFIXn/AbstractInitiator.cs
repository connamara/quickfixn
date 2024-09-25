using System.Threading;
using System.Collections.Generic;
using System;
using QuickFix.Logger;
using QuickFix.Store;

namespace QuickFix
{
    public abstract class AbstractInitiator : IInitiator
    {
        // from constructor
        private readonly SessionSettings _settings;

        private readonly object _sync = new();
        private readonly Dictionary<SessionID, Session> _sessions = new();
        private readonly HashSet<SessionID> _sessionIDs = new();
        private readonly HashSet<SessionID> _pending = new();
        private readonly HashSet<SessionID> _connected = new();
        private readonly HashSet<SessionID> _disconnected = new();
        private readonly SessionFactory _sessionFactory;
        private Thread? _thread;

        protected readonly NonSessionLog _nonSessionLog;

        public bool IsStopped { get; private set; } = true;

        protected AbstractInitiator(
            IApplication app,
            IMessageStoreFactory storeFactory,
            SessionSettings settings,
            ILogFactory? logFactoryNullable,
            IMessageFactory? messageFactoryNullable)
        {
            _settings = settings;
            var logFactory = logFactoryNullable ?? new NullLogFactory();
            var msgFactory = messageFactoryNullable ?? new DefaultMessageFactory();
            _sessionFactory = new SessionFactory(app, storeFactory, logFactory, msgFactory);
            _nonSessionLog = new NonSessionLog(logFactory);

            HashSet<SessionID> definedSessions = _settings.GetSessions();
            if (0 == definedSessions.Count)
                throw new ConfigError("No sessions defined");
        }

        public void Start()
        {
            if (_disposed)
                throw new ObjectDisposedException(this.GetType().Name);

            // create all sessions
            foreach (SessionID sessionId in _settings.GetSessions())
            {
                SettingsDictionary dict = _settings.Get(sessionId);
                CreateSession(sessionId, dict);
            }

            if (0 == _sessions.Count)
                throw new ConfigError("No sessions defined for initiator");

            // start it up
            IsStopped = false;
            OnConfigure(_settings);
            _thread = new Thread(OnStart);
            _thread.Start();
        }

        /// <summary>
        /// Add new session as an ad-hoc (dynamic) operation
        /// </summary>
        /// <param name="sessionId">ID of new session</param>
        /// <param name="dict">config settings for new session</param>
        /// <returns>true if session added successfully, false if session already exists or is not an initiator</returns>
        public bool AddSession(SessionID sessionId, SettingsDictionary dict)
        {
            lock (_settings)
                if (!_settings.Has(sessionId)) // session won't be in settings if ad-hoc creation after startup
                    _settings.Set(sessionId, dict); // need to to this here to merge in default config settings
                else
                    return false; // session already exists

            if (CreateSession(sessionId, dict))
                return true;

            lock (_settings) // failed to create new session
                _settings.Remove(sessionId);
            return false;
        }

        /// <summary>
        /// Create session, either at start-up or as an ad-hoc operation
        /// </summary>
        /// <param name="sessionId">ID of new session</param>
        /// <param name="dict">config settings for new session</param>
        /// <returns>true if session added successfully, false if session already exists or is not an initiator</returns>
        private bool CreateSession(SessionID sessionId, SettingsDictionary dict)
        {
            if (dict.GetString(SessionSettings.CONNECTION_TYPE) == "initiator" && !_sessionIDs.Contains(sessionId))
            {
                Session session = _sessionFactory.Create(sessionId, dict);
                lock (_sync)
                {
                    _sessionIDs.Add(sessionId);
                    _sessions[sessionId] = session;
                    SetDisconnected(sessionId);
                }
                return true;
            }
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
            Session? session = null;
            bool disconnectRequired = false;
            lock (_sync)
            {
                if (_sessionIDs.Contains(sessionId))
                {
                    session = _sessions[sessionId];
                    if (session.IsLoggedOn && !terminateActiveSession)
                        return false;
                    _sessions.Remove(sessionId);
                    disconnectRequired = IsConnected(sessionId) || IsPending(sessionId);
                    if (disconnectRequired)
                        SetDisconnected(sessionId);
                    _disconnected.Remove(sessionId);
                    _sessionIDs.Remove(sessionId);
                }
            }
            lock (_settings)
                _settings.Remove(sessionId);
            if (disconnectRequired)
                session?.Disconnect("Dynamic session removal");
            OnRemove(sessionId); // ensure session's reader thread is gone before we dispose session
            session?.Dispose();

            return true;
        }

        /// <summary>
        /// Logout existing session and close connection.  Attempt graceful disconnect first.
        /// </summary>
        public void Stop()
        {
            Stop(false);
        }

        /// <summary>
        /// Logout existing session and close connection
        /// </summary>
        /// <param name="force">If true, terminate immediately.  </param>
        public void Stop(bool force)
        {
            if (_disposed)
                throw new ObjectDisposedException(this.GetType().Name);

            if (IsStopped)
                return;

            lock (_sync)
            {
                foreach (SessionID sessionId in _connected)
                {
                    Session? session = Session.LookupSession(sessionId);
                    if (session is not null && session.IsEnabled)
                    {
                        session.Logout();
                    }
                }
            }

            if (!force)
            {
                // TODO change this duration to always exceed LogoutTimeout setting
                for (int second = 0; (second < 10) && IsLoggedOn; ++second)
                    Thread.Sleep(1000);
            }

            lock (_sync)
            {
                HashSet<SessionID> connectedSessionIDs = new HashSet<SessionID>(_connected);
                foreach (SessionID sessionId in connectedSessionIDs) {
                    Session? session = Session.LookupSession(sessionId);
                    if (session is not null)
                        SetDisconnected(session.SessionID);
                }
            }

            IsStopped = true;
            OnStop();

            // Give OnStop() time to finish its business
            _thread?.Join(5000);
            _thread = null;

            // dispose all sessions and clear all session sets
            lock (_sync)
            {
                foreach (Session s in _sessions.Values)
                    s.Dispose();

                _sessions.Clear();
                _sessionIDs.Clear();
                _pending.Clear();
                _connected.Clear();
                _disconnected.Clear();
            }
        }

        public bool IsLoggedOn
        {
            get
            {
                lock (_sync)
                {
                    foreach (SessionID sessionId in _connected)
                    {
                        Session? session = Session.LookupSession(sessionId);
                        return session is not null && session.IsLoggedOn;
                    }
                }

                return false;
            }
        }

        #region Virtual Methods

        /// <summary>
        /// Override this to configure additional implemenation-specific settings
        /// </summary>
        /// <param name="settings"></param>
        protected virtual void OnConfigure(SessionSettings settings)
        { }

        /// <summary>
        /// Implement this to provide custom reaction behavior to an ad-hoc session removal.
        /// (This is called after the session is removed.)
        /// </summary>
        /// <param name="sessionId">ID of session that was removed</param>
        protected virtual void OnRemove(SessionID sessionId)
        { }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// Implemented to start connecting to targets.
        /// </summary>
        protected abstract void OnStart();
        /// <summary>
        /// Implemented to connect and poll for events.
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        protected abstract bool OnPoll(double timeout);
        /// <summary>
        /// Implemented to stop a running initiator.
        /// </summary>
        protected abstract void OnStop();

        /// <summary>
        /// Implemented to connect a session to its target.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="settings"></param>
        protected abstract void DoConnect(Session session, QuickFix.SettingsDictionary settings);

        #endregion

        #region Protected Methods

        protected void Connect()
        {
            lock (_sync)
            {
                HashSet<SessionID> disconnectedSessions = new HashSet<SessionID>(_disconnected);
                foreach (SessionID sessionId in disconnectedSessions)
                {
                    Session? session = Session.LookupSession(sessionId);
                    if (session is not null && session.IsEnabled)
                    {
                        if (session.IsNewSession)
                            session.Reset("New session");
                        if (session.IsSessionTime)
                            DoConnect(session, _settings.Get(sessionId));
                    }
                }
            }
        }

        protected void SetPending(SessionID sessionId)
        {
            lock (_sync)
            {
                _pending.Add(sessionId);
                _connected.Remove(sessionId);
                _disconnected.Remove(sessionId);
            }
        }

        protected void SetConnected(SessionID sessionId)
        {
            lock (_sync)
            {
                _pending.Remove(sessionId);
                _connected.Add(sessionId);
                _disconnected.Remove(sessionId);
            }
        }

        protected void SetDisconnected(SessionID sessionId)
        {
            lock (_sync)
            {
                if (_sessionIDs.Contains(sessionId))
                {
                    _pending.Remove(sessionId);
                    _connected.Remove(sessionId);
                    _disconnected.Add(sessionId);
                }
            }
        }

        protected bool IsPending(SessionID sessionId)
        {
            lock (_sync)
            {
                return _pending.Contains(sessionId);
            }
        }

        protected bool IsConnected(SessionID sessionId)
        {
            lock (_sync)
            {
                return _connected.Contains(sessionId);
            }
        }

        protected bool IsDisconnected(SessionID sessionId)
        {
            lock (_sync)
            {
                return _disconnected.Contains(sessionId);
            }
        }

        #endregion


        /// <summary>
        /// Get the SessionIDs for the sessions managed by this initiator.
        /// </summary>
        /// <returns>the SessionIDs for the sessions managed by this initiator</returns>
        public HashSet<SessionID> GetSessionIDs()
        {
            return new HashSet<SessionID>(_sessions.Keys);
        }

        private bool _disposed = false;
        /// <summary>
        /// Any subclasses of AbstractInitiator should override this if they have resources to dispose
        /// that aren't already covered in its OnStop() handler.
        /// Any override should call base.Dispose(disposing).
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                this.Stop();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~AbstractInitiator() => Dispose(false);
    }
}
