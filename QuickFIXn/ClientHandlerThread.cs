using System.Net.Sockets;
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
    public class ClientHandlerThread : IResponder, IDisposable
    {
        internal class ExitedEventArgs : EventArgs
        {
            public ClientHandlerThread ClientHandlerThread { get; private set; }

            public ExitedEventArgs(ClientHandlerThread clientHandlerThread)
            {
                this.ClientHandlerThread = clientHandlerThread;
            }
        }

        internal delegate void ExitedEventHandler(object sender, ClientHandlerThread.ExitedEventArgs e);
        internal event ExitedEventHandler Exited;

        public long Id { get; private set; }

        private Thread thread_ = null;
        private volatile bool isShutdownRequested_ = false;
        private SocketReader socketReader_;
        private FileLog log_;

        [Obsolete("Don't use this constructor")]
        public ClientHandlerThread(TcpClient tcpClient, long clientId)
            : this(tcpClient, clientId, new QuickFix.Dictionary())
        { }


        [Obsolete("Don't use this constructor")]
        public ClientHandlerThread(TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict)
            : this(tcpClient, clientId, settingsDict, new SocketSettings())
        {
        }

        /// <summary>
        /// Creates a ClientHandlerThread
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="clientId"></param>
        /// <param name="settingsDict"></param>
        /// <param name="socketSettings"></param>
        public ClientHandlerThread(TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict, SocketSettings socketSettings)
            : this(tcpClient, clientId, settingsDict, socketSettings, null)
        {
            
        }

        internal ClientHandlerThread(TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict,
            SocketSettings socketSettings, AcceptorSocketDescriptor acceptorDescriptor)
        {
            string debugLogFilePath = "log";
            if (settingsDict.Has(SessionSettings.DEBUG_FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.DEBUG_FILE_LOG_PATH);
            else if (settingsDict.Has(SessionSettings.FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.FILE_LOG_PATH);

            // FIXME - do something more flexible than hardcoding a filelog
            log_ = new FileLog(debugLogFilePath, new SessionID(
                    "ClientHandlerThread", clientId.ToString(), "Debug-" + Guid.NewGuid().ToString()));

            this.Id = clientId;
            socketReader_ = new SocketReader(tcpClient, socketSettings, this, acceptorDescriptor);
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
            OnExited();
        }

        protected void OnExited()
        {
            if (Exited != null)
                Exited(this, new ExitedEventArgs(this));
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

        public bool Send(string data)
        {
            return socketReader_.Send(data) > 0;
        }

        public void Disconnect()
        {
            Shutdown("Disconnected");
        }

        #endregion

        ~ClientHandlerThread() => Dispose(false);
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                if (socketReader_ != null)
                {
                    socketReader_.Dispose();
                    socketReader_ = null;
                }

                if (log_ != null)
                {
                    log_.Dispose();
                    log_ = null;
                }
            }
            _disposed = true;
        }
    }
}
