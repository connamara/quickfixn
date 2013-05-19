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
    public class ClientHandlerThread : IResponder
    {
        private Thread thread_ = null;
        private volatile bool isShutdownRequested_ = false;
        private TcpClient tcpClient_;
        private SocketReader socketReader_;
        private long id_;
        private ILog log_;

        [Obsolete("Not used.  Will probably be removed in v2.")]
        public ClientHandlerThread(TcpClient tcpClient, long clientId)
            : this(tcpClient, clientId, new QuickFix.Dictionary())
        { }

        [Obsolete("This constructor is needed for the DebugFileLogPath config setting, which is being removed.")] // v2
        public ClientHandlerThread(TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict)
        {
            string debugLogFilePath = "log";
            if (settingsDict.Has(SessionSettings.DEBUG_FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.DEBUG_FILE_LOG_PATH);
            else if (settingsDict.Has(SessionSettings.FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.FILE_LOG_PATH);

            // FIXME - do something more flexible than hardcoding a filelog
            log_ = new FileLog(debugLogFilePath, new SessionID("ClientHandlerThread", clientId.ToString(), "Debug"));

            tcpClient_ = tcpClient;
            id_ = clientId;
            socketReader_ = new SocketReader(tcpClient_, this, log_);
        }

        /// <summary>
        /// Create a ClientHandlerThread.
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="clientId"></param>
        /// <param name="log">If null, then will not log</param>
        public ClientHandlerThread(TcpClient tcpClient, long clientId, ILog log)
        {
            tcpClient_ = tcpClient;
            id_ = clientId;
            socketReader_ = new SocketReader(tcpClient_, this, log);
            log_ = (log == null) ? NullLog.GetInstance() : log;
        }

        public void Start()
        {
            thread_ = new Thread(new ThreadStart(Run));
            thread_.Start();
        }

        public void Shutdown(string reason)
        {
            log_.OnEvent("shutdown requested: " + reason);
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

            log_.OnEvent("shutdown");
        }

        #region Responder Members

        public bool Send(string data)
        {
            byte[] rawData = System.Text.Encoding.UTF8.GetBytes(data);
            int bytesSent = tcpClient_.Client.Send(rawData);
            return bytesSent > 0;
        }

        public void Disconnect()
        {
            Shutdown("Disconnected");
            tcpClient_.Client.Close();
            tcpClient_.Close();
        }

        #endregion
    }
}
