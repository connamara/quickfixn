using System.Threading;
using System.Collections.Generic;

namespace QuickFix
{
    public abstract class AbstractInitiator : IInitiator
    {
        // from constructor
        private IApplication _app = null;
        private IMessageStoreFactory _storeFactory = null;
        private SessionSettings _settings = null;
        private ILogFactory _logFactory = null;
        private IMessageFactory _msgFactory = null;


        private object sync_ = new object();
        private bool _disposed = false;
        private Dictionary<SessionID, Session> sessions_ = new Dictionary<SessionID, Session>();
        private HashSet<SessionID> sessionIDs_ = new HashSet<SessionID>();
        private HashSet<SessionID> pending_ = new HashSet<SessionID>();
        private HashSet<SessionID> connected_ = new HashSet<SessionID>();
        private HashSet<SessionID> disconnected_ = new HashSet<SessionID>();
        private bool isStopped_ = true;
        private Thread thread_;
		private SessionFactory sessionFactory_ = null;

        #region Properties

        public bool IsStopped
        {
            get { return isStopped_; }
        }

        #endregion

        public AbstractInitiator(IApplication app, IMessageStoreFactory storeFactory, SessionSettings settings)
            : this(app, storeFactory, settings, null, null)
        { }

        public AbstractInitiator(IApplication app, IMessageStoreFactory storeFactory, SessionSettings settings, ILogFactory logFactory)
            : this(app, storeFactory, settings, logFactory, null)
        { }

        public AbstractInitiator(
            IApplication app, IMessageStoreFactory storeFactory, SessionSettings settings, ILogFactory logFactory, IMessageFactory messageFactory)
        {
            _app = app;
            _storeFactory = storeFactory;
            _settings = settings;
            _logFactory = logFactory;
            _msgFactory = messageFactory;

            HashSet<SessionID> definedSessions = _settings.GetSessions();
            if (0 == definedSessions.Count)
                throw new ConfigError("No sessions defined");
        }

        public void Start()
        {
            if (_disposed)
                throw new System.ObjectDisposedException(this.GetType().Name);

            // create all sessions
            sessionFactory_ = new SessionFactory(_app, _storeFactory, _logFactory, _msgFactory);
            foreach (SessionID sessionID in _settings.GetSessions())
            {
                Dictionary dict = _settings.Get(sessionID);
				AddSession(sessionID, dict);
            }

            if (0 == sessions_.Count)
                throw new ConfigError("No sessions defined for initiator");

            // start it up
            isStopped_ = false;
            OnConfigure(_settings);
            thread_ = new Thread(new ThreadStart(OnStart));
            thread_.Start();
        }

		/// <summary>
		/// Add new session, either at start-up or as an ad-hoc operation
		/// </summary>
		/// <param name="sessionID">ID of new session<param>
		/// <param name="dict">config settings for new session</param></param>
		/// <returns>true if session added succesfully, false if session already exists or is of wrong type</returns>
		public bool AddSession(SessionID sessionID, Dictionary dict)
		{
		    string connectionType = dict.GetString(SessionSettings.CONNECTION_TYPE);
			if (!sessionIDs_.Contains(sessionID) && "initiator" == connectionType)
			{
				sessionIDs_.Add(sessionID);
				sessions_[sessionID] = sessionFactory_.Create(sessionID, dict);
				SetDisconnected(sessionID);
				return true;
			}
			return false;
		}

		/// <summary>
		/// Ad-hoc removal of an existing sssion
		/// </summary>
		/// <param name="sessionID">ID of session to be removed</param>
		/// <param name="terminateActiveSession">true if sesion to be removed even if it has an active connection</param>
		/// <returns>true if session removed or was already not present, false if could not be removed because of active connection</returns>
		public bool RemoveSession(SessionID sessionID, bool terminateActiveSession)
		{
			if (sessionIDs_.Contains(sessionID))
			{
				Session session = sessions_[sessionID];
				bool isDisconnected = false;
				lock (sync_)
				{
					isDisconnected = IsDisconnected(sessionID);
					if (!(isDisconnected || terminateActiveSession))
						return false;
					sessionIDs_.Remove(sessionID);
					sessions_.Remove(sessionID);
					SetDisconnected(sessionID);
					disconnected_.Remove(sessionID);
					OnRemove(sessionID);
				}
				if (!isDisconnected)
					session.Reset("Session reconfigured(AbstractInitiator.RemoveSession)", "Session disabled");
				session.Dispose();
			}
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
                throw new System.ObjectDisposedException(this.GetType().Name);

            if (IsStopped)
                return;

            List<Session> enabledSessions = new List<Session>();

            lock (sync_)
            {
                foreach (SessionID sessionID in connected_)
                {
                    Session session = Session.LookupSession(sessionID);
                    if (session.IsEnabled)
                    {
                        enabledSessions.Add(session);
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

            lock (sync_)
            {
                HashSet<SessionID> connectedSessionIDs = new HashSet<SessionID>(connected_);
                foreach (SessionID sessionID in connectedSessionIDs)
                    SetDisconnected(Session.LookupSession(sessionID).SessionID);
            }

            isStopped_ = true;
            OnStop();

            // Give OnStop() time to finish its business
            thread_.Join(5000);
            thread_ = null;

            // dispose all sessions and clear all session sets
            lock (sync_)
            {
                foreach (Session s in sessions_.Values)
                    s.Dispose();
            }
            sessions_.Clear();
            sessionIDs_.Clear();
            pending_.Clear();
            connected_.Clear();
            disconnected_.Clear();
        }

        public bool IsLoggedOn
        {
            get
            {
                lock (sync_)
                {
                    foreach (SessionID sessionID in connected_)
                    {
                        if (Session.LookupSession(sessionID).IsLoggedOn)
                            return true;
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
		/// Override this to handle ad-hoc session removal
		/// </summary>
		/// <param name="sessionID">ID of session being remvoed</param>
		protected virtual void OnRemove(SessionID sessionID)
		{ }

		[System.Obsolete("This method's intended purpose is unclear.  Don't use it.")]
        protected virtual void OnInitialize(SessionSettings settings)
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
        /// <param name="sessionID"></param>
        /// <param name="settings"></param>
        protected abstract void DoConnect(SessionID sessionID, QuickFix.Dictionary settings);

        #endregion

        #region Protected Methods

        protected void Connect()
        {
            lock (sync_)
            {
                HashSet<SessionID> disconnectedSessions = new HashSet<SessionID>(disconnected_);
                foreach (SessionID sessionID in disconnectedSessions)
                {
                    Session session = Session.LookupSession(sessionID);
                    if (session.IsEnabled)
                    {
                        if (session.IsNewSession)
                            session.Reset("New session");
                        if (session.IsSessionTime)
                            DoConnect(sessionID, _settings.Get(sessionID));
                    }
                }
            }
        }

        protected void SetPending(SessionID sessionID)
        {
            lock (sync_)
            {
                pending_.Add(sessionID);
                connected_.Remove(sessionID);
                disconnected_.Remove(sessionID);
            }
        }

        protected void SetConnected(SessionID sessionID)
        {
            lock (sync_)
            {
                pending_.Remove(sessionID);
                connected_.Add(sessionID);
                disconnected_.Remove(sessionID);
            }
        }

        protected void SetDisconnected(SessionID sessionID)
        {
            lock (sync_)
            {
				if (sessionIDs_.Contains(sessionID))
				{
					pending_.Remove(sessionID);
					connected_.Remove(sessionID);
					disconnected_.Add(sessionID);
				}
            }
        }

        protected bool IsPending(SessionID sessionID)
        {
            lock (sync_)
            {
                return pending_.Contains(sessionID);
            }
        }

        protected bool IsConnected(SessionID sessionID)
        {
            lock (sync_)
            {
                return connected_.Contains(sessionID);
            }
        }

        protected bool IsDisconnected(SessionID sessionID)
        {
            lock (sync_)
            {
                return disconnected_.Contains(sessionID);
            }
        }

        #endregion


        /// <summary>
        /// Get the SessionIDs for the sessions managed by this initiator.
        /// </summary>
        /// <returns>the SessionIDs for the sessions managed by this initiator</returns>
        public HashSet<SessionID> GetSessionIDs()
        {
            return new HashSet<SessionID>(sessions_.Keys);
        }

        /// <summary>
        /// Any subclasses of AbstractInitiator should override this if they have resources to dispose
        /// that aren't already covered in its OnStop() handler.
        /// Any override should call base.Dispose(disposing).
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            this.Stop();
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
