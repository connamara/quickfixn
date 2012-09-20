using System.Threading;
using System.Collections.Generic;

namespace QuickFix
{
    public abstract class AbstractInitiator : IInitiator
    {
        private object sync_ = new object();
        private Dictionary<SessionID,Session> sessions_ = new Dictionary<SessionID, Session>();
        private HashSet<SessionID> sessionIDs_ = new HashSet<SessionID>();
        private HashSet<SessionID> pending_ = new HashSet<SessionID>();
        private HashSet<SessionID> connected_ = new HashSet<SessionID>();
        private HashSet<SessionID> disconnected_ = new HashSet<SessionID>();
        private bool isStopped_ = true;
        private SessionSettings settings_;
        private Thread thread_;

        #region Properties
        
        public bool IsStopped
        {
            get { return isStopped_; }
        }

        #endregion

        public AbstractInitiator(Application application, MessageStoreFactory storeFactory, SessionSettings settings)
            : this(application, storeFactory, settings, null, null)
        { }

        public AbstractInitiator(Application application, MessageStoreFactory storeFactory, SessionSettings settings, LogFactory logFactory)
            : this(application, storeFactory, settings, null, null)
        { }

        public AbstractInitiator(Application app, MessageStoreFactory storeFactory, SessionSettings settings, LogFactory logFactory, IMessageFactory messageFactory)
        {
            settings_ = settings;

            HashSet<SessionID> definedSessions = settings.GetSessions();
            if (0 == definedSessions.Count)
                throw new ConfigError("No sessions defined");

            SessionFactory factory = new SessionFactory(app, storeFactory, logFactory, messageFactory);
            foreach (SessionID sessionID in definedSessions)
            {
                Dictionary dict = settings.Get(sessionID);
                if ("initiator".Equals(dict.GetString(SessionSettings.CONNECTION_TYPE)))
                {
                    sessionIDs_.Add(sessionID);
                    sessions_[sessionID] = factory.Create(sessionID, dict);
                    SetDisconnected(sessionID);
                }
            }

            if (0 == sessions_.Count)
                throw new ConfigError("No sessions defined for initiator");
        }

        public void Start()
        {
            isStopped_ = false;
            OnConfigure(settings_);
            OnInitialize(settings_);
            thread_ = new Thread(new ThreadStart(OnStart));
            thread_.Start();
        }

        public void Stop()
        {
            Stop(false);
        }

        public void Stop(bool force)
        {
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
                for (int second = 0; (second < 10) && IsLoggedOn(); ++second)
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
            thread_.Join(5000);
            thread_ = null;

            foreach (Session session in enabledSessions)
                session.Logon();
        }

        public bool IsLoggedOn()
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

        #region Virtual Methods

        /// <summary>
        /// Implemented to configure acceptor
        /// </summary>
        /// <param name="settings"></param>
        protected virtual void OnConfigure(SessionSettings settings)
        { }
        /// <summary>
        /// Implemented to initialize initiator
        /// </summary>
        /// <param name="settings"></param>
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
            lock(sync_)
            {
                HashSet<SessionID> disconnectedSessions = new HashSet<SessionID>(disconnected_);
                foreach(SessionID sessionID in disconnectedSessions)
                {
                    Session session = Session.LookupSession(sessionID);
                    if(session.IsEnabled && session.IsSessionTime)
                        DoConnect(sessionID, settings_.Get(sessionID));
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
                pending_.Remove(sessionID);
                connected_.Remove(sessionID);
                disconnected_.Add(sessionID);
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
    }
}
