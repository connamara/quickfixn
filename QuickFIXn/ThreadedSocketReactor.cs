﻿using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System;

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
            get { return state_; }
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

        #endregion

        #region Private Members

        private object sync_ = new object();
        private State state_ = State.SHUTDOWN_COMPLETE;
        private long nextClientId_ = 0;
        private Thread serverThread_ = null;
        private Dictionary<long, ClientHandlerThread> clientThreads_ = new Dictionary<long, ClientHandlerThread>();
        private TcpListener tcpListener_;
        private SocketSettings socketSettings_;
        private QuickFix.Dictionary sessionDict_;

        #endregion

        [Obsolete("Use the other constructor")]
        public ThreadedSocketReactor(IPEndPoint serverSocketEndPoint, SocketSettings socketSettings)
            : this(serverSocketEndPoint, socketSettings, null)
        { }
        
        public ThreadedSocketReactor(IPEndPoint serverSocketEndPoint, SocketSettings socketSettings, QuickFix.Dictionary sessionDict)
        {
            socketSettings_ = socketSettings;
            tcpListener_ = new TcpListener(serverSocketEndPoint);
            sessionDict_ = sessionDict;
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

        private const int TenSecondsInTicks = 10000;

        private void WaitForShutdown()
        {
            int start = Environment.TickCount;
            while( State.SHUTDOWN_REQUESTED == state_ && (Environment.TickCount - start) < TenSecondsInTicks)
            {
                new ManualResetEvent(false).WaitOne(100);
            }
            if( State.SHUTDOWN_REQUESTED == state_ )
            {
                throw new ConnectionShutdownRequestedException();
            }
        }

        public void Shutdown()
        {
            lock (sync_)
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
            WaitForShutdown();
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
        /// FIXME get socket options from SessionSettings
        /// </summary>
        /// <param name="client"></param>
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
        }

        private void ShutdownClientHandlerThreads()
        {
            lock (sync_)
            {
                if (State.SHUTDOWN_COMPLETE != state_)
                {
                    this.Log("shutting down...");

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

        /// <summary>
        /// FIXME do real logging
        /// </summary>
        /// <param name="s"></param>
        private void Log(string s)
        {
            System.Console.WriteLine(s);
        }
    }
}
