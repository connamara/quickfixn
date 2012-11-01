using System.Net.Sockets;
using System.Threading;
using System;
using Common.Logging;

namespace QuickFix
{
    // TODO v2.0 - consider changing to internal

    /// <summary>
    /// Created by a ThreadedSocketReactor to handle a client connection.
    /// Each ClientHandlerThread has a SocketReader which reads
    /// from the socket.
    /// </summary>
    public class ClientHandlerThread : Responder
    {
        private Thread thread_ = null;
        private volatile bool isShutdownRequested_ = false;
        private TcpClient tcpClient_;
        private SocketReader socketReader_;
        private long id_;
        private FileLog log_;
        private ILog logger_;

        [Obsolete("Use the other constructor")]
        public ClientHandlerThread(TcpClient tcpClient, long clientId)
            : this(tcpClient, clientId, new QuickFix.Dictionary())
        { }
        
        /// <summary>
        /// Creates a ClientHandlerThread
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <param name="clientId"></param>
        /// <param name="debugLogFilePath">path where thread log will go</param>
        public ClientHandlerThread(TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict)
        {
            if (settingsDict.Has(SessionSettings.DEBUG_FILE_LOG_PATH))
            {
                // Support for old debug log only when DEBUG_FILE_LOG_PATH is set in settings
                string debugLogFilePath = settingsDict.GetString(SessionSettings.DEBUG_FILE_LOG_PATH);
                log_ = new FileLog(debugLogFilePath, new SessionID("ClientHandlerThread", clientId.ToString(), "Debug"));
            }

            // Support for Common.Logging
            logger_ = LogManager.GetCurrentClassLogger();

            tcpClient_ = tcpClient;
            id_ = clientId;
            socketReader_ = new SocketReader(tcpClient_, this);
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

        public void Log(string s)
        {
            Log(s, null);
        }

        public void Log(string s, Exception ex)
        {
            if (log_ != null) log_.OnEvent(s);
            logger_.Debug(m => m("Cliend Id: {0}; {1}", id_, s), ex);
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
