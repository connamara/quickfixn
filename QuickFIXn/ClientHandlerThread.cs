﻿using System.Net.Sockets;
using System.Threading;
using System;

namespace QuickFix
{
    // TODO v2.0 - consider changing to internal

    /// <summary>
    /// Created by a ThreadedSocketReactor to handle a client connection.
    /// Each ClientHandlerThread has a SocketReader which reads
    /// from the socket.
    /// </summary>
    public class ClientHandlerThread : IResponder
    {
        private Thread thread_ = null;
        private volatile bool isShutdownRequested_ = false;
        private SocketReader socketReader_;
        private long id_;
        private ILog log_;

        /// <summary>
        /// Creates a ClientHandlerThread
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="clientId"></param>
        /// <param name="debugLogFilePath">path where thread log will go</param>
        public ClientHandlerThread(TcpClient tcpClient, long clientId, ILogFactory logFactory, SocketSettings socketSettings)
        {
            // FIXME - this uses a mock session since there is no way to do non-session specific logging.
            log_ = logFactory.Create(new SessionID("ClientHandlerThread", clientId.ToString(), "Debug"));
            id_ = clientId;
            socketReader_ = new SocketReader(tcpClient, socketSettings, this);
        }

        public void Start()
        {
            thread_ = new Thread(new ThreadStart(Run));
            thread_.Start();
        }

        public void Shutdown(string reason)
        {
            Log("shutdown requested: " + reason);
            isShutdownRequested_ = true;
        }

        public void Join()
        {
            if(null == thread_)
                return;
            if(thread_.IsAlive)
                thread_.Join(5000);
            thread_ = null;
        }

        public void Run()
        {
            while (!isShutdownRequested_)
            {
                try
                {
                    socketReader_.Read();
                }
                catch (System.Exception e)
                {
                    Shutdown(e.Message);
                }
            }

            this.Log("shutdown");
        }

        /// FIXME do real logging
        public void Log(string s)
        {
            log_.OnEvent(s);
        }

        /// <summary>
        /// Provide StreamReader with access to the log
        /// </summary>
        /// <returns></returns>
        internal ILog GetLog()
        {
            return log_;
        }

        #region Responder Members

        public bool Send(byte[] data)
        {
            return socketReader_.Send(data) > 0;
        }

        public void Disconnect()
        {
            Shutdown("Disconnected");
            socketReader_.Dispose();
        }

        #endregion
    }
}
