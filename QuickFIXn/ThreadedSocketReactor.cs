﻿using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System;
using Microsoft.Extensions.Logging;

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

        #region Properties

        public State ReactorState
        {
            get { lock (sync_) { return state_; } }
        }

        #endregion

        #region Private Members

        private object sync_ = new object();
        private State state_ = State.RUNNING;
        private long nextClientId_ = 0;
        private Thread serverThread_ = null;
        private Dictionary<long, ClientHandlerThread> clientThreads_ = new Dictionary<long, ClientHandlerThread>();
        private TcpListener tcpListener_;
        private readonly ILoggerFactory _loggerFactory;
        private readonly ILogger _logger;
        private SocketSettings socketSettings_;
        private QuickFix.Dictionary sessionDict_;
        private IPEndPoint serverSocketEndPoint_;
        private readonly AcceptorSocketDescriptor acceptorDescriptor_;

        #endregion

        [Obsolete("Use the other constructor")]
        public ThreadedSocketReactor(IPEndPoint serverSocketEndPoint, SocketSettings socketSettings)
            : this(serverSocketEndPoint, socketSettings, null)
        { }

        [Obsolete]
        public ThreadedSocketReactor(IPEndPoint serverSocketEndPoint, SocketSettings socketSettings,
            QuickFix.Dictionary sessionDict) : this(serverSocketEndPoint, socketSettings, sessionDict, (AcceptorSocketDescriptor)null)
        {
            
        }

        public ThreadedSocketReactor(IPEndPoint serverSocketEndPoint, SocketSettings socketSettings,
            QuickFix.Dictionary sessionDict, ILoggerFactory loggerFactory) : this(serverSocketEndPoint, socketSettings, sessionDict, null, loggerFactory)
        {

        }

        [Obsolete]
        internal ThreadedSocketReactor(IPEndPoint serverSocketEndPoint, SocketSettings socketSettings, QuickFix.Dictionary sessionDict, AcceptorSocketDescriptor acceptorDescriptor)
        {
            socketSettings_ = socketSettings;
            serverSocketEndPoint_ = serverSocketEndPoint;
            tcpListener_ = new TcpListener(serverSocketEndPoint_);
            sessionDict_ = sessionDict;
            acceptorDescriptor_ = acceptorDescriptor;
        }

        internal ThreadedSocketReactor(
            IPEndPoint serverSocketEndPoint, 
            SocketSettings socketSettings, 
            QuickFix.Dictionary sessionDict, 
            AcceptorSocketDescriptor acceptorDescriptor, 
            ILoggerFactory loggerFactory)
        {
            socketSettings_ = socketSettings;
            serverSocketEndPoint_ = serverSocketEndPoint;
            tcpListener_ = new TcpListener(serverSocketEndPoint_);
            sessionDict_ = sessionDict;
            acceptorDescriptor_ = acceptorDescriptor;
            _loggerFactory = loggerFactory;
            _logger = loggerFactory.CreateLogger(nameof(ThreadedSocketReactor));
        }

        public void Start()
        {
            lock (sync_)
            {
                if (state_ == State.RUNNING && serverThread_ == null)
                {
                    serverThread_ = new Thread(Run);
                    serverThread_.Start();
                }
            }
        }

        public void Shutdown()
        {
            lock (sync_)
            {
                if (State.RUNNING == state_)
                {
                    try
                    {
                        state_ = State.SHUTDOWN_REQUESTED;
                        using (TcpClient killer = new TcpClient())
                        {
                            try
                            {
                                IPEndPoint killerEndPoint =  new IPEndPoint(IPAddress.Loopback, serverSocketEndPoint_.Port);
                                killer.Connect(killerEndPoint);
                            }
                            catch (System.Exception e)
                            {
                                _logger.LogError("Tried to interrupt server socket but was already closed: " + e.Message);
                            }
                        }
                    }
                    catch (System.Exception e)
                    {
                        _logger.LogError("Error while closing server socket: " + e.Message);
                    }
                }
            }
        }

        /// <summary>
        /// TODO apply networking options, e.g. NO DELAY, LINGER, etc.
        /// </summary>
        public void Run()
        {
            lock (sync_)
            {
                if (State.SHUTDOWN_REQUESTED != state_)
                {
                    try
                    {
                        tcpListener_.Start();
                    }
                    catch(Exception e)
                    {
                        _logger.LogError("Error starting listener: " + e.Message);
                        throw;
                    }
                }
            }

            while (State.RUNNING == ReactorState)
            {
                try
                {
                    TcpClient client = tcpListener_.AcceptTcpClient();
                    if (State.RUNNING == ReactorState)
                    {
                        ApplySocketOptions(client, socketSettings_);
                        ClientHandlerThread t =
                            new ClientHandlerThread(
                                client, nextClientId_++, sessionDict_, socketSettings_, acceptorDescriptor_, _loggerFactory);
                        t.Exited += OnClientHandlerThreadExited;
                        lock (sync_)
                        {
                            clientThreads_.Add(t.Id, t);
                        }

                        // FIXME set the client thread's exception handler here
                        t.Log("connected");
                        t.Start();
                    }
                    else
                    {
                        client.Dispose();
                    }
                }
                catch (System.Exception e)
                {
                    if (State.RUNNING == ReactorState)
                        _logger.LogError("Error accepting connection: " + e.Message);
                }
            }
            tcpListener_.Server.Close();
            tcpListener_.Stop();
            ShutdownClientHandlerThreads();
        }

        internal void OnClientHandlerThreadExited(object sender, ClientHandlerThread.ExitedEventArgs e)
        {
            lock(sync_)
            {
                ClientHandlerThread t = null;
                if(clientThreads_.TryGetValue(e.ClientHandlerThread.Id, out t))
                {
                    clientThreads_.Remove(t.Id);
                    t.Dispose();
                    t = null;
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
            lock (sync_)
            {
                if (State.SHUTDOWN_COMPLETE != state_)
                {
                    _logger.LogInformation("shutting down...");

                    foreach (ClientHandlerThread t in clientThreads_.Values)
                    {
                        t.Exited -= OnClientHandlerThreadExited;
                        t.Shutdown("reactor is shutting down");
                        try
                        {
                            t.Join();
                        }
                        catch (System.Exception e)
                        {
                            t.Log("Error shutting down: " + e.Message);
                        }
                        t.Dispose();
                    }
                    clientThreads_.Clear();
                    state_ = State.SHUTDOWN_COMPLETE;
                }
            }
        }
    }
}
