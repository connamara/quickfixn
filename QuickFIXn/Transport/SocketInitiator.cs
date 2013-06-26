using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using QuickFix.Config;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace QuickFix.Transport
{
    /// <summary>
    /// Initiates connections and uses a single thread to process messages for all sessions.
    /// </summary>
    public class SocketInitiator : AbstractInitiator
    {
        public const string SOCKET_CONNECT_HOST = "SocketConnectHost";
        public const string SOCKET_CONNECT_PORT = "SocketConnectPort";
        public const string RECONNECT_INTERVAL  = "ReconnectInterval";

        #region Properties
        
        public bool Connected
        {
            get
            {
                if (null == socket_)
                    return false;
                return socket_.Connected;
            }
        }

        #endregion

        #region Private Members
        
        private Socket socket_ = null;
        private volatile bool shutdownRequested_ = false;
        private DateTime lastConnectTimeDT = DateTime.MinValue;
        private int reconnectInterval_ = 30;
        private SocketSettings socketSettings_ = new SocketSettings();
        private Dictionary<SessionID, SocketInitiatorThread> threads_ = new Dictionary<SessionID, SocketInitiatorThread>();
        private Dictionary<SessionID, int> sessionToHostNum_ = new Dictionary<SessionID, int>();
        private object sync_ = new object();
        
        #endregion

        public SocketInitiator(IApplication application, IMessageStoreFactory storeFactory, SessionSettings settings)
            : this(application, storeFactory, settings, null)
        { }

        public SocketInitiator(IApplication application, IMessageStoreFactory storeFactory, SessionSettings settings, ILogFactory logFactory)
            : base(application, storeFactory, settings, logFactory)
        { }

        public SocketInitiator(IApplication application, IMessageStoreFactory storeFactory, SessionSettings settings, ILogFactory logFactory, IMessageFactory messageFactory)
            : base(application, storeFactory, settings, logFactory, messageFactory)
        { }

        public static void SocketInitiatorThreadStart(object socketInitiatorThread)
        {
            SocketInitiatorThread t = socketInitiatorThread as SocketInitiatorThread;
            try
            {
                t.Connect();
                t.Initiator.SetConnected(t.Session.SessionID);
                t.Session.Log.OnEvent("Connection succeeded");
                t.Session.Next();
                while (t.Read())
                { }
                if (t.Initiator.IsStopped)
                    t.Initiator.RemoveThread(t);
                t.Initiator.SetDisconnected(t.Session.SessionID);
            }
            catch (SocketException e)
            {
                t.Session.Log.OnEvent("Connection failed: " + e.Message);
                t.Initiator.RemoveThread(t);
                t.Initiator.SetDisconnected(t.Session.SessionID);
            }
        }
        
        private void AddThread(SocketInitiatorThread thread)
        {
            lock (sync_)
            {
                threads_[thread.Session.SessionID] = thread;
            }
        }

        private void RemoveThread(SocketInitiatorThread thread)
        {
            lock (sync_)
            {
                thread.Join();
                threads_.Remove(thread.Session.SessionID);
            }
        }

        private IPEndPoint GetNextSocketEndPoint(SessionID sessionID, QuickFix.Dictionary settings)
        {
            int num;
            if (!sessionToHostNum_.TryGetValue(sessionID, out num))
                num = 0;

            string hostKey = SessionSettings.SOCKET_CONNECT_HOST + num;
            string portKey = SessionSettings.SOCKET_CONNECT_PORT + num;
            if (!settings.Has(hostKey) || !settings.Has(portKey))
            {
                num = 0;
                hostKey = SessionSettings.SOCKET_CONNECT_HOST;
                portKey = SessionSettings.SOCKET_CONNECT_PORT;
            }

            try
            {
                IPAddress[] addrs = Dns.GetHostAddresses(settings.GetString(hostKey));
                int port = System.Convert.ToInt32(settings.GetLong(portKey));
                sessionToHostNum_[sessionID] = ++num;
                return new IPEndPoint(addrs[0], port);
            }
            catch (System.Exception e)
            {
                throw new ConfigError(e.Message, e);
            }
        }

        #region Initiator Methods
        
        /// <summary>
        /// handle other socket options like TCP_NO_DELAY here
        /// </summary>
        /// <param name="settings"></param>
        protected override void OnConfigure(SessionSettings settings)
        {
            try
            {
                reconnectInterval_ = Convert.ToInt32(settings.Get().GetLong(SessionSettings.RECONNECT_INTERVAL));
            }
            catch (System.Exception)
            { }
            if (settings.Get().Has(SessionSettings.SOCKET_NODELAY))
            {
                socketSettings_.SocketNodelay = settings.Get().GetBool(SessionSettings.SOCKET_NODELAY);
            }
        }

        protected override void OnStart()
        {
            shutdownRequested_ = false;

            while(!shutdownRequested_)
            {
                double reconnectIntervalAsMilliseconds = 1000 * reconnectInterval_;
                DateTime nowDT = DateTime.UtcNow;

                if ((nowDT.Subtract(lastConnectTimeDT).TotalMilliseconds) >= reconnectIntervalAsMilliseconds)
                {
                    Connect();
                    lastConnectTimeDT = nowDT;
                }

                Thread.Sleep(1 * 1000);
            }
        }

        protected override bool OnPoll(double timeout)
        {
            throw new NotImplementedException("FIXME - SocketInitiator.OnPoll not implemented!");
        }

        protected override void OnStop()
        {
            shutdownRequested_ = true;
            if (null != socket_)
                socket_.Close();
        }

        protected override void DoConnect(SessionID sessionID, Dictionary settings)
        {
            Session session = null;

            try
            {
                session = Session.LookupSession(sessionID);
                if (!session.IsSessionTime)
                    return;

                IPEndPoint socketEndPoint = GetNextSocketEndPoint(sessionID, settings);
                SetPending(sessionID);
                session.Log.OnEvent("Connecting to " + socketEndPoint.Address + " on port " + socketEndPoint.Port);

                SocketInitiatorThread t = new SocketInitiatorThread(this, session, socketEndPoint, socketSettings_);
                t.Start();
                AddThread(t);

            }
            catch (System.Exception e)
            {
                if (null != session)
                    session.Log.OnEvent(e.Message);
            }
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            // nothing additional to do for this subclass
            base.Dispose(disposing);
        }
    }
}
