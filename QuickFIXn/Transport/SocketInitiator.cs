﻿using System;
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

        #region Private Members
        
        private IApplication app_;
        private SessionSettings settings_;
        private IMessageStoreFactory storeFactory_;
        private ILogFactory logFactory_;
        //private Socket socket_ = null;
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
        {
            app_ = application;
            storeFactory_ = storeFactory;
            settings_ = settings;
            logFactory_ = logFactory;
        }

        public SocketInitiator(IApplication application, IMessageStoreFactory storeFactory, SessionSettings settings, ILogFactory logFactory, IMessageFactory messageFactory)
            : base(application, storeFactory, settings, logFactory, messageFactory)
        {
            app_ = application;
            storeFactory_ = storeFactory;
            settings_ = settings;
            logFactory_ = logFactory;
        }

        public static void SocketInitiatorThreadStart(object socketInitiatorThread)
        {
            SocketInitiatorThread t = socketInitiatorThread as SocketInitiatorThread;
            try
            {
                t.Connect();
                t.Initiator.SetConnected(t.SessionID);
                t.Session.Log.OnEvent("Connection succeeded");
                t.Session.Next();
                while (t.Read())
                { }
                if (t.Initiator.IsStopped)
                    t.Initiator.RemoveThread(t);
                t.Initiator.SetDisconnected(t.SessionID);
            }
            catch (IOException ex) // Can be exception when connecting, during ssl authentication or when reading
            {
                t.Session.Log.OnEvent("Connection failed: " + ex.Message);
                t.Initiator.RemoveThread(t);
                t.Initiator.SetDisconnected(t.SessionID);
            }
            catch (SocketException e) 
            {
                t.Session.Log.OnEvent("Connection failed: " + e.Message);
                t.Initiator.RemoveThread(t);
                t.Initiator.SetDisconnected(t.SessionID);
            }
        }
        
        private void AddThread(SocketInitiatorThread thread)
        {
            lock (sync_)
            {
                threads_[thread.SessionID] = thread;
            }
        }

        private void RemoveThread(SocketInitiatorThread thread)
        {
            lock (sync_)
            {
                thread.Join();
                threads_.Remove(thread.SessionID);
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
                socketSettings_.Configure(settings);

                // Create a Ssl-SocketInitiatorThread if a certificate is given
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
    }
}
