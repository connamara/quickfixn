#nullable enable
using System.Net.Sockets;
using System.Threading;
using System;
using QuickFix.Logger;

namespace QuickFix
{
    /// <summary>
    /// Created by a ThreadedSocketReactor to handle a client connection.
    /// Each ClientHandlerThread has a SocketReader which reads
    /// from the socket.
    /// </summary>
    internal class ClientHandlerThread : IResponder, IDisposable
    {
        internal class ExitedEventArgs : EventArgs
        {
            public ClientHandlerThread ClientHandlerThread { get; private set; }

            public ExitedEventArgs(ClientHandlerThread clientHandlerThread)
            {
                ClientHandlerThread = clientHandlerThread;
            }
        }

        internal delegate void ExitedEventHandler(object sender, ClientHandlerThread.ExitedEventArgs e);
        internal event ExitedEventHandler? Exited;

        public long Id { get; private set; }

        private Thread? _thread = null;
        private volatile bool _isShutdownRequested = false;
        private readonly SocketReader _socketReader;
        private readonly FileLog _log;

        internal ClientHandlerThread(TcpClient tcpClient, long clientId, QuickFix.Dictionary settingsDict,
            SocketSettings socketSettings, AcceptorSocketDescriptor? acceptorDescriptor)
        {
            string debugLogFilePath = "log";
            if (settingsDict.Has(SessionSettings.DEBUG_FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.DEBUG_FILE_LOG_PATH);
            else if (settingsDict.Has(SessionSettings.FILE_LOG_PATH))
                debugLogFilePath = settingsDict.GetString(SessionSettings.FILE_LOG_PATH);

            // FIXME - do something more flexible than hardcoding a filelog
            _log = new FileLog(debugLogFilePath, new SessionID(
                    "ClientHandlerThread", clientId.ToString(), "Debug-" + Guid.NewGuid()));

            Id = clientId;
            _socketReader = new SocketReader(tcpClient, socketSettings, this, acceptorDescriptor);
        }

        public void Start()
        {
            _thread = new Thread(Run);
            _thread.Start();
        }

        public void Shutdown(string reason)
        {
            Log("shutdown requested: " + reason);
            _isShutdownRequested = true;
        }

        public void Join()
        {
            if (_thread is null)
                return;
            if (_thread.IsAlive)
                _thread.Join(5000);
            _thread = null;
        }

        private void Run()
        {
            while (!_isShutdownRequested)
            {
                try
                {
                    _socketReader.Read();
                }
                catch (Exception e)
                {
                    Shutdown(e.Message);
                }
            }

            Log("shutdown");
            OnExited();
        }

        private void OnExited() {
            Exited?.Invoke(this, new ExitedEventArgs(this));
        }

        /// FIXME do real logging
        public void Log(string s)
        {
            _log.OnEvent(s);
        }

        /// <summary>
        /// Provide StreamReader with access to the log
        /// </summary>
        /// <returns></returns>
        internal ILog GetLog()
        {
            return _log;
        }

        #region Responder Members

        public bool Send(string data)
        {
            return _socketReader.Send(data) > 0;
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
                _socketReader.Dispose();
                _log.Dispose();
            }
            _disposed = true;
        }
    }
}
