#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using QuickFix.Logger;

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

        #region Private Members

        private volatile bool _shutdownRequested = false;
        private DateTime _lastConnectTimeDt = DateTime.MinValue;
        private int _reconnectInterval = 30;
        private readonly SocketSettings _socketSettings = new();
        private readonly Dictionary<SessionID, SocketInitiatorThread> _threads = new();
        private readonly Dictionary<SessionID, int> _sessionToHostNum = new();
        private readonly object _sync = new();
        
        #endregion

        public SocketInitiator(
            IApplication application,
            IMessageStoreFactory storeFactory,
            SessionSettings settings,
            ILogFactory? logFactoryNullable = null,
            IMessageFactory? messageFactoryNullable = null)
            : base(application, storeFactory, settings, logFactoryNullable, messageFactoryNullable)
        { }

        public static void SocketInitiatorThreadStart(object socketInitiatorThread)
        {
            SocketInitiatorThread? t = socketInitiatorThread as SocketInitiatorThread;
            if (t == null) return;

            string? exceptionEvent = null;
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

                if (exceptionEvent is not null)
                {
                    if (t.Session.Disposed)
                    {
                        // The session is disposed, and so is its log. We cannot use it to log the event,
                        // so we resort to storing it in a local file.
                        try
                        {
                            File.AppendAllText("DisposedSessionEvents.log", $"{DateTime.Now:G}: {exceptionEvent}{Environment.NewLine}");
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

        private IPEndPoint GetNextSocketEndPoint(SessionID sessionId, QuickFix.Dictionary settings)
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
                double reconnectIntervalAsMilliseconds = 1000 * _reconnectInterval;
                DateTime nowDt = DateTime.UtcNow;

                if ((nowDt.Subtract(_lastConnectTimeDt).TotalMilliseconds) >= reconnectIntervalAsMilliseconds)
                {
                    Connect();
                    _lastConnectTimeDt = nowDt;
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

        protected override void DoConnect(Session session, Dictionary settings)
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
                SocketInitiatorThread t = new SocketInitiatorThread(this, session, socketEndPoint, socketSettings);
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
