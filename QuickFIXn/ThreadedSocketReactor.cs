using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System;
using QuickFix.Logger;

namespace QuickFix
{
    // TODO v2.0 - consider changing to internal

    /// <summary>
    /// Handles incoming connections on a single endpoint. When a socket connection
    /// is accepted, a ClientHandlerThread is created to handle the connection
    /// </summary>
    public class ThreadedSocketReactor
    {
        public enum State { RUNNING, SHUTDOWN_REQUESTED, SHUTDOWN_COMPLETE }

        public State ReactorState
        {
            get { return _state; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is running.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is running; otherwise, <c>false</c>.
        /// </value>
        public bool IsRunning
        {
            get
            {
                return ReactorState == State.RUNNING;
            }
        }

        private readonly object _sync = new ();
        private State _state = State.SHUTDOWN_COMPLETE;
        private long _nextClientId = 0;
        private Thread? _serverThread = null;
        private readonly Dictionary<long, ClientHandlerThread> _clientThreads = new ();
        private readonly TcpListener _tcpListener;
        private readonly SocketSettings _socketSettings;
        private readonly IPEndPoint _serverSocketEndPoint;
        private readonly AcceptorSocketDescriptor? _acceptorSocketDescriptor;
        private readonly NonSessionLog _nonSessionLog;

        internal ThreadedSocketReactor(
            IPEndPoint serverSocketEndPoint,
            SocketSettings socketSettings,
            AcceptorSocketDescriptor? acceptorSocketDescriptor,
            NonSessionLog nonSessionLog)
        {
            _socketSettings = socketSettings;
            _serverSocketEndPoint = serverSocketEndPoint;
            _tcpListener = new TcpListener(_serverSocketEndPoint);
            _acceptorSocketDescriptor = acceptorSocketDescriptor;
            _nonSessionLog = nonSessionLog;
        }

        public void Start()
        {
            lock( sync_ )
            {
                if( State.SHUTDOWN_COMPLETE == state_ )
                {
                    state_ = State.RUNNING;
                    tcpListener_.Start();
                    serverThread_ = new Thread( new ThreadStart( Run ) );
                    serverThread_.Start();
                }
            }
        }

        public void Shutdown()
        {
            lock (_sync)
            {
                if (IsRunning)
                {
                    try
                    {
                        tcpListener_.Server.Close();
                        tcpListener_.Stop();
                        state_ = State.SHUTDOWN_REQUESTED;
                    }
                    catch (System.Exception e)
                    {
                        this.Log("Error while closing server socket: " + e.Message);
                    }
                }
            }
        }

        /// <summary>
        /// TODO apply networking options, e.g. NO DELAY, LINGER, etc.
        /// </summary>
        public void Run()
        {
            while (IsRunning)
            {
                try
                {
                    if( !tcpListener_.Pending() )
                    {
                        new ManualResetEvent(false).WaitOne(100);
                        continue;
                    }
                    TcpClient client = tcpListener_.AcceptTcpClient();
                    ApplySocketOptions(client, socketSettings_);
                    ClientHandlerThread t = new ClientHandlerThread(client, nextClientId_++, sessionDict_, socketSettings_);
                    t.Exited += OnClientHandlerThreadExited;
                    lock (sync_)
                    {
                        clientThreads_.Add(t.Id, t);
                    }
                    // FIXME set the client thread's exception handler here
                    t.Log("connected");
                    t.Start();
                }
                catch (System.Exception e)
                {
                    if (IsRunning)
                        this.Log("Error accepting connection: " + e.Message);
                }
            }
            ShutdownClientHandlerThreads();
        }

        internal void OnClientHandlerThreadExited(object sender, ClientHandlerThread.ExitedEventArgs e)
        {
            lock(_sync)
            {
                if(_clientThreads.TryGetValue(e.ClientHandlerThread.Id, out var t))
                {
                    _clientThreads.Remove(t.Id);
                    t.Dispose();
                }
            }
        }

        /// <summary>
        /// Apply socket options from settings
        /// </summary>
        /// <param name="client"></param>
        /// <param name="socketSettings"></param>
        public static void ApplySocketOptions(TcpClient client, SocketSettings socketSettings)
        {
            client.LingerState = new LingerOption(false, 0);
            client.NoDelay = socketSettings.SocketNodelay;
            if (socketSettings.SocketReceiveBufferSize.HasValue)
            {
                client.ReceiveBufferSize = socketSettings.SocketReceiveBufferSize.Value;
            }
            if (socketSettings.SocketSendBufferSize.HasValue)
            {
                client.SendBufferSize = socketSettings.SocketSendBufferSize.Value;
            }
            if (socketSettings.SocketReceiveTimeout.HasValue)
            {
                client.ReceiveTimeout = socketSettings.SocketReceiveTimeout.Value;
            }
            if (socketSettings.SocketSendTimeout.HasValue)
            {
                client.SendTimeout = socketSettings.SocketSendTimeout.Value;
            }
        }

        private void ShutdownClientHandlerThreads()
        {
            lock (_sync)
            {
                if (State.SHUTDOWN_COMPLETE != _state)
                {
                    foreach (ClientHandlerThread t in _clientThreads.Values)
                    {
                        t.Exited -= OnClientHandlerThreadExited;
                        t.Shutdown("reactor is shutting down");
                        try
                        {
                            t.Join();
                        }
                        catch (Exception e)
                        {
                            LogError("Error shutting down", e);
                        }
                        t.Dispose();
                    }
                    _clientThreads.Clear();
                    _state = State.SHUTDOWN_COMPLETE;
                }
            }
        }

        /// <summary>
        /// Write to the NonSessionLog
        /// </summary>
        /// <param name="s"></param>
        /// <param name="ex"></param>
        private void LogError(string s, Exception? ex = null) {
            _nonSessionLog.OnEvent(ex is null ? $"{s}" : $"{s}: {ex}");
        }
    }
}
