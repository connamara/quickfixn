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
            get { lock (_sync) { return _state; } }
        }

        private readonly object _sync = new ();
        private State _state = State.RUNNING;
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
            lock (_sync)
            {
                if (_state == State.RUNNING && _serverThread is null)
                {
                    _serverThread = new Thread(Run);
                    _serverThread.Start();
                }
            }
        }

        public void Shutdown()
        {
            lock (_sync)
            {
                if (State.RUNNING == _state)
                {
                    try
                    {
                        _state = State.SHUTDOWN_REQUESTED;
                        using (TcpClient killer = new TcpClient())
                        {
                            try
                            {
                                IPEndPoint killerEndPoint =  new IPEndPoint(IPAddress.Loopback, _serverSocketEndPoint.Port);
                                killer.Connect(killerEndPoint);
                            }
                            catch (Exception e)
                            {
                                LogError("Tried to interrupt server socket but was already closed", e);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        LogError("Error while closing server socket", e);
                    }
                }
            }
        }

        public void Run()
        {
            lock (_sync)
            {
                if (State.SHUTDOWN_REQUESTED != _state)
                {
                    try
                    {
                        _tcpListener.Start();
                    }
                    catch(Exception e)
                    {
                        LogError("Error starting listener", e);
                        throw;
                    }
                }
            }

            while (State.RUNNING == ReactorState)
            {
                try
                {
                    TcpClient client = _tcpListener.AcceptTcpClient();
                    if (State.RUNNING == ReactorState)
                    {
                        ApplySocketOptions(client, _socketSettings);
                        ClientHandlerThread t = new ClientHandlerThread(
                            client, _nextClientId++, _socketSettings, _acceptorSocketDescriptor, _nonSessionLog);
                        t.Exited += OnClientHandlerThreadExited;
                        lock (_sync)
                        {
                            _clientThreads.Add(t.Id, t);
                        }

                        t.Start();
                    }
                    else
                    {
                        client.Dispose();
                    }
                }
                catch (Exception e)
                {
                    if (State.RUNNING == ReactorState)
                        LogError("Error accepting connection", e);
                }
            }
            _tcpListener.Server.Close();
            _tcpListener.Stop();
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
