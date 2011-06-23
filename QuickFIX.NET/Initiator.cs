using System.Collections.Generic;

namespace QuickFix
{
    public abstract class Initiator
    {
        private object sync_ = new object();
        private Dictionary<SessionID,Session> sessions_ = new Dictionary<SessionID, Session>();
        private HashSet<SessionID> sessionIDs_ = new HashSet<SessionID>();
        private HashSet<SessionID> pending_ = new HashSet<SessionID>();
        private HashSet<SessionID> connected_ = new HashSet<SessionID>();
        private HashSet<SessionID> disconnected_ = new HashSet<SessionID>();
        
        public Initiator(Application application, MessageStoreFactory storeFactory, SessionSettings settings)
            : this(application, storeFactory, settings, null)
        { }

        public Initiator(Application app, MessageStoreFactory storeFactory, SessionSettings settings, LogFactory logFactory)
        {
            HashSet<SessionID> definedSessions = settings.GetSessions();
            if (0 == definedSessions.Count)
                throw new ConfigError("No sessions defined");

            SessionFactory factory = new SessionFactory(app, storeFactory, logFactory);
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


        #region Protected Methods
        
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
    }
}
