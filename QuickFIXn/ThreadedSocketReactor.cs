using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.Logging;
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

        public State ReactorState => _state;

        /// <summary>
        /// Gets a value indicating whether this instance is running.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is running; otherwise, <c>false</c>.
        /// </value>
        public bool IsRunning => ReactorState == State.RUNNING;

        private readonly object _sync = new ();
        private State _state = State.SHUTDOWN_COMPLETE;
        private long _nextClientId = 0;
        private readonly Dictionary<long, ClientHandlerThread> _clientThreads = new ();
        private readonly TcpListener _tcpListener;
        private readonly SocketSettings _socketSettings;
        private readonly AcceptorSocketDescriptor? _acceptorSocketDescriptor;
        private readonly ILogger _nonSessionLog;
        private readonly IQuickFixLoggerFactory _loggerFactory;

        internal ThreadedSocketReactor(
            IPEndPoint serverSocketEndPoint,
            SocketSettings socketSettings,
            AcceptorSocketDescriptor? acceptorSocketDescriptor,
            IQuickFixLoggerFactory loggerFactory)
        {
            _socketSettings = socketSettings;
            _tcpListener = new TcpListener(serverSocketEndPoint);
            _acceptorSocketDescriptor = acceptorSocketDescriptor;
            _loggerFactory = loggerFactory;
            _nonSessionLog = loggerFactory.CreateNonSessionLogger<ThreadedSocketReactor>();
        }

        public void Start()
        {
            lock (_sync)
            {
                if( State.SHUTDOWN_COMPLETE == _state )
                {
                    try
                    {
                        _tcpListener.Start();
                        _state = State.RUNNING;
                        _tcpListener.BeginAcceptTcpClient(AcceptTcpClientCallback, _tcpListener);
                    }
                    catch (Exception e) {
                        _nonSessionLog.LogError(e, "Error starting listener");
                        throw;
                    }
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
                        _state = State.SHUTDOWN_REQUESTED;
                        _tcpListener.Server.Close();
                        _tcpListener.Stop();
                        ShutdownClientHandlerThreads();
                    }
                    catch (Exception e)
                    {
                        _nonSessionLog.LogError(e, "Error while closing server socket");
                    }
                }
            }
        }

        private void AcceptTcpClientCallback( IAsyncResult ar )
        {
            // If socket is in process of shutting down then a client may
            // still be able to connect until it has shutdown
            // but really we don't want to do anything with the connection so just ignore it
            if (!IsRunning)
                return;

            TcpListener listener = (TcpListener)ar.AsyncState!;
            try
            {
                TcpClient client = listener.EndAcceptTcpClient(ar);
                ApplySocketOptions(client, _socketSettings);
                ClientHandlerThread t = new ClientHandlerThread(
                    client, _nextClientId++, _socketSettings, _acceptorSocketDescriptor, _loggerFactory);
                t.Exited += OnClientHandlerThreadExited;
                lock (_sync)
                {
                    _clientThreads.Add(t.Id, t);
                }
                // FIXME set the client thread's exception handler here
                t.Start();
            }
            catch (Exception e)
            {
                if (IsRunning)
                    _nonSessionLog.LogError(e, "Error accepting connection");
            }
            if( IsRunning )
            {
                listener.BeginAcceptTcpClient( AcceptTcpClientCallback, listener );
            }
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
                            _nonSessionLog.LogError(e, "Error shutting down");
                        }
                        t.Dispose();
                    }
                    _clientThreads.Clear();
                    _state = State.SHUTDOWN_COMPLETE;
                }
            }
        }
    }
}
