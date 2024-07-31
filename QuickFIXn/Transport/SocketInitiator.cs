#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using QuickFix.Logger;
using QuickFix.Store;

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

        private volatile bool _shutdownRequested = false;
        private DateTime _lastConnectTimeDt = DateTime.MinValue;
        private int _reconnectInterval = 30;
        private readonly SocketSettings _socketSettings = new();
        private readonly Dictionary<SessionID, SocketInitiatorThread> _threads = new();
        private readonly Dictionary<SessionID, int> _sessionToHostNum = new();
        private readonly object _sync = new();
        
        public SocketInitiator(
            IApplication application,
            IMessageStoreFactory storeFactory,
            SessionSettings settings,
            ILogFactory? logFactoryNullable = null,
            IMessageFactory? messageFactoryNullable = null)
            : base(application, storeFactory, settings, logFactoryNullable, messageFactoryNullable)
        { }

        public static void SocketInitiatorThreadStart(object? socketInitiatorThread)
        {
            SocketInitiatorThread? t = socketInitiatorThread as SocketInitiatorThread;
            if (t == null) return;

            try
            {
                t.Connect();
                t.Initiator.SetConnected(t.Session.SessionID);
                t.Session.Log.OnEvent("Connection succeeded");
                t.Session.Next();
                while (t.Read()) {
                }

                if (t.Initiator.IsStopped)
                    t.Initiator.RemoveThread(t);
                t.Initiator.SetDisconnected(t.Session.SessionID);
            }
            catch (IOException ex) // Can be exception when connecting, during ssl authentication or when reading
            {
                LogThreadStartConnectionFailed(t, ex);
            }
            catch (SocketException ex)
            {
                LogThreadStartConnectionFailed(t, ex);
            }
            catch (System.Security.Authentication.AuthenticationException ex) // some certificate problems
            {
                LogThreadStartConnectionFailed(t, ex);
            }
            catch (Exception ex)
            {
                LogThreadStartConnectionFailed(t, ex);
            }
            finally
            {
                t.Initiator.RemoveThread(t);
                t.Initiator.SetDisconnected(t.Session.SessionID);
            }
        }

        private static void LogThreadStartConnectionFailed(SocketInitiatorThread t, Exception e) {
            if (t.Session.Disposed) {
                t.NonSessionLog.OnEvent($"Connection failed [session {t.Session.SessionID}]: {e}");
                return;
            }
            t.Session.Log.OnEvent($"Connection failed: {e}");
        }

        private void AddThread(SocketInitiatorThread thread)
        {
            lock (_sync)
            {
                _threads[thread.Session.SessionID] = thread;
            }
        }

        private void RemoveThread(SocketInitiatorThread thread)
        {
            RemoveThread(thread.Session.SessionID);
        }

        private void RemoveThread(SessionID sessionId)
        {
            // We can come in here on the thread being removed, and on another thread too in the case 
            // of dynamic session removal, so make sure we won't deadlock...
            if (Monitor.TryEnter(_sync))
            {
                if (_threads.TryGetValue(sessionId, out var thread))
                {
                    try
                    {
                        thread.Join();
                    }
                    catch { }
                    _threads.Remove(sessionId);
                }
                Monitor.Exit(_sync);
            }
        }

        private IPEndPoint GetNextSocketEndPoint(SessionID sessionId, SettingsDictionary settings)
        {
            if (!_sessionToHostNum.TryGetValue(sessionId, out var num))
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
                _sessionToHostNum[sessionId] = ++num;

                _socketSettings.ServerCommonName = hostName;
                return new IPEndPoint(addrs.First(a => a.AddressFamily == AddressFamily.InterNetwork), port);
            }
            catch (Exception e)
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
                _reconnectInterval = Convert.ToInt32(settings.Get().GetLong(SessionSettings.RECONNECT_INTERVAL));
            }
            catch (Exception)
            { }

            // Don't know if this is required in order to handle settings in the general section
            _socketSettings.Configure(settings.Get());
        }       

        protected override void OnStart()
        {
            _shutdownRequested = false;

            while(!_shutdownRequested)
            {
                try
                {
                    double reconnectIntervalAsMilliseconds = 1000 * _reconnectInterval;
                    DateTime nowDt = DateTime.UtcNow;

                    if (nowDt.Subtract(_lastConnectTimeDt).TotalMilliseconds >= reconnectIntervalAsMilliseconds)
                    {
                        Connect();
                        _lastConnectTimeDt = nowDt;
                    }
                }
                catch (Exception e)
                {
                    _nonSessionLog.OnEvent($"Failed to start: {e}");
                }

                Thread.Sleep(1 * 1000);
            }
        }

        /// <summary>
        /// Ad-hoc session removal
        /// </summary>
        /// <param name="sessionId">ID of session being removed</param>
        protected override void OnRemove(SessionID sessionId)
        {
            RemoveThread(sessionId);
        }

        protected override bool OnPoll(double timeout)
        {
            throw new NotImplementedException("FIXME - SocketInitiator.OnPoll not implemented!");
        }

        protected override void OnStop()
        {
            _shutdownRequested = true;
        }

        protected override void DoConnect(Session session, SettingsDictionary settings)
        {
            try
            {
                if (!session.IsSessionTime)
                    return;

                IPEndPoint socketEndPoint = GetNextSocketEndPoint(session.SessionID, settings);
                SetPending(session.SessionID);
                session.Log.OnEvent($"Connecting to {socketEndPoint.Address} on port {socketEndPoint.Port}");

                //Setup socket settings based on current section
                var socketSettings = _socketSettings.Clone();
                socketSettings.Configure(settings);

                // Create a Ssl-SocketInitiatorThread if a certificate is given
                SocketInitiatorThread t = new SocketInitiatorThread(
                    this, session, socketEndPoint, socketSettings, _nonSessionLog);
                t.Start();
                AddThread(t);
            }
            catch (Exception e) {
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
