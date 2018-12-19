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

        [System.Obsolete("Has never worked.  Always returns false.  Will be removed.")]
        public bool Connected { get { return false; } }

        #endregion

        #region Private Members

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
            if (t == null) return;

            string exceptionEvent = null;
            try
            {
                try
                {
                    t.Connect();
                    t.Initiator.SetConnected(t.Session.SessionID);
                    t.Session.Log.OnEvent("Connection succeeded");
                    t.Session.Next();
                    while (t.Read())
                    {
                    }

                    if (t.Initiator.IsStopped)
                        t.Initiator.RemoveThread(t);
                    t.Initiator.SetDisconnected(t.Session.SessionID);
                }
                catch (IOException ex) // Can be exception when connecting, during ssl authentication or when reading
                {
                    exceptionEvent = $"Connection failed: {ex.Message}";
                }
                catch (SocketException e)
                {
                    exceptionEvent = $"Connection failed: {e.Message}";
                }
                catch (System.Security.Authentication.AuthenticationException ex) // some certificate problems
                {
                    exceptionEvent = $"Connection failed (AuthenticationException): {ex.Message}";
                }
                catch (Exception ex)
                {
                    exceptionEvent = $"Unexpected exception: {ex}";
                }

                if (exceptionEvent != null)
                {
                    if (t.Session.Disposed)
                    {
                        // The session is disposed, and so is its log. We cannot use it to log the event,
                        // so we resort to storing it in a local file.
                        try
                        {
                            File.AppendAllText("DisposedSessionEvents.log", $"{System.DateTime.Now:G}: {exceptionEvent}{Environment.NewLine}");
                        }
                        catch (IOException)
                        {
                            // Prevent IO exceptions from crashing the application
                        }
                    }
                    else
                    {
                        t.Session.Log.OnEvent(exceptionEvent);
                    }
                }
            }
            finally
            {
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
            RemoveThread(thread.Session.SessionID);
        }

        private void RemoveThread(SessionID sessionID)
        {
            // We can come in here on the thread being removed, and on another thread too in the case 
            // of dynamic session removal, so make sure we won't deadlock...
            if (Monitor.TryEnter(sync_))
            {
                SocketInitiatorThread thread = null;
                if (threads_.TryGetValue(sessionID, out thread))
                {
                    try
                    {
                        thread.Join();
                    }
                    catch { }
                    threads_.Remove(sessionID);
                }
                Monitor.Exit(sync_);
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
                var hostName = settings.GetString(hostKey);
                IPAddress[] addrs = Dns.GetHostAddresses(hostName);
                int port = System.Convert.ToInt32(settings.GetLong(portKey));
                sessionToHostNum_[sessionID] = ++num;

                socketSettings_.ServerCommonName = hostName;
                return new IPEndPoint(addrs.First(a => a.AddressFamily == AddressFamily.InterNetwork), port);
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

            // Don't know if this is required in order to handle settings in the general section
            socketSettings_.Configure(settings.Get());
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

        /// <summary>
        /// Ad-hoc session removal
        /// </summary>
        /// <param name="sessionID">ID of session being removed</param>
        protected override void OnRemove(SessionID sessionID)
        {
            RemoveThread(sessionID);
        }

        protected override bool OnPoll(double timeout)
        {
            throw new NotImplementedException("FIXME - SocketInitiator.OnPoll not implemented!");
        }

        protected override void OnStop()
        {
            shutdownRequested_ = true;
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

                //Setup socket settings based on current section
                var socketSettings = socketSettings_.Clone();
                socketSettings.Configure(settings);

                // Create a Ssl-SocketInitiatorThread if a certificate is given
                SocketInitiatorThread t = new SocketInitiatorThread(this, session, socketEndPoint, socketSettings);                
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
