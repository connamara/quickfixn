using System.Net.Sockets;
using System.Threading;
using System;
using Microsoft.Extensions.Logging;

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
        private ILogger _logger;

        [Obsolete("Don't use this constructor")]
        public ClientHandlerThread(TcpClient tcpClient, long clientId)
            : this(tcpClient, clientId, new QuickFix.Dictionary())
        { }


        [Obsolete("Don't use this constructor")]
        public ClientHandlerThread(TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict)
            : this(tcpClient, clientId, settingsDict, new SocketSettings())
        {
        }

        [Obsolete("Use constructor with injecting ILoggerFactory")]
        public ClientHandlerThread(
            TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict, SocketSettings socketSettings)
            : this(tcpClient, clientId, settingsDict, socketSettings, (AcceptorSocketDescriptor)null)
        {
            
        }

        /// <summary>
        /// Creates a ClientHandlerThread
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="clientId"></param>
        /// <param name="settingsDict"></param>
        /// <param name="socketSettings"></param>
        /// <param name="loggerFactory"></param>
        public ClientHandlerThread(
            TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict, SocketSettings socketSettings, ILoggerFactory loggerFactory)
            : this(tcpClient, clientId, settingsDict, socketSettings, null, loggerFactory)
        {
        }

        [Obsolete("Creates File Logger under the hood, please use Constructor with ILoggerFactory")]
        internal ClientHandlerThread(TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict,
            SocketSettings socketSettings, AcceptorSocketDescriptor acceptorDescriptor)
        {
            string debugLogFilePath = "log";
            if (settingsDict.Has(SessionSettings.DEBUG_FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.DEBUG_FILE_LOG_PATH);
            else if (settingsDict.Has(SessionSettings.FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.FILE_LOG_PATH);
            var sessionID = new SessionID(
                    "ClientHandlerThread", clientId.ToString(), "Debug-" + Guid.NewGuid().ToString());
            _logger = new FileLog(debugLogFilePath, sessionID);
            this.Id = clientId;
            socketReader_ = new SocketReader(tcpClient, socketSettings, this, acceptorDescriptor);
        }

        internal ClientHandlerThread(TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict,
        SocketSettings socketSettings, AcceptorSocketDescriptor acceptorDescriptor, ILoggerFactory loggerFactory)
        {
            var sessionID = new SessionID(
                    "ClientHandlerThread", clientId.ToString(), "Debug-" + Guid.NewGuid().ToString());
            _logger = loggerFactory.CreateLogger(sessionID.ToString());
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
            _logger.LogEvent(s);
        }

        /// <summary>
        /// Provide StreamReader with access to the log
        /// </summary>
        /// <returns></returns>
        internal ILogger GetLogger()
        {
            return _logger;
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

                if (_logger != null)
                {
                    _logger = null;
                }
            }
            _disposed = true;
        }
    }
}
