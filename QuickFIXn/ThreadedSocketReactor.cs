using System.Collections.Generic;
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
            get { lock (sync_) { return state_; } }
        }

        public ILog Log { get; private set; }

        #endregion

        #region Private Members

        private object sync_ = new object();
        private State state_ = State.RUNNING;
        private long nextClientId_ = 0;
        private Thread serverThread_ = null;
        private LinkedList<ClientHandlerThread> clientThreads_ = new LinkedList<ClientHandlerThread>();
        private TcpListener tcpListener_;
        private SocketSettings socketSettings_;
        private QuickFix.Dictionary sessionDict_; // remove in v2, as only needed for deprecated DebugFileLogPath setting

        #endregion

        [Obsolete("Not used.  Will probably be removed in v2.")]
        public ThreadedSocketReactor(IPEndPoint serverSocketEndPoint, SocketSettings socketSettings)
            : this(serverSocketEndPoint, socketSettings, (ILog)null)
        { }

        [Obsolete("This constructor is needed for the DebugFileLogPath config setting, which is being removed.")] // v2
        public ThreadedSocketReactor(IPEndPoint serverSocketEndPoint, SocketSettings socketSettings, QuickFix.Dictionary sessionDict)
        {
            socketSettings_ = socketSettings;
            tcpListener_ = new TcpListener(serverSocketEndPoint);
            sessionDict_ = sessionDict;
        }

        /// <summary>
        /// Create a ThreadedSocketReactor.
        /// </summary>
        /// <param name="serverSocketEndPoint"></param>
        /// <param name="socketSettings"></param>
        /// <param name="log">Can be null, in which case no logging will be performed.</param>
        public ThreadedSocketReactor(IPEndPoint serverSocketEndPoint, SocketSettings socketSettings, ILog log)
        {
            socketSettings_ = socketSettings;
            tcpListener_ = new TcpListener(serverSocketEndPoint);
            Log = (log == null) ? NullLog.GetInstance() : log;
        }

        public void Start()
        {
            serverThread_ = new Thread(new ThreadStart(Run));
            serverThread_.Start();
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
                        tcpListener_.Server.Close();
                        tcpListener_.Stop();
                    }
                    catch (System.Exception e)
                    {
                        Log.OnEvent("Error while closing server socket: " + e.Message);
                        Log.OnDebug(e.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// TODO apply networking options, e.g. NO DELAY, LINGER, etc.
        /// </summary>
        public void Run()
        {
            tcpListener_.Start();
            while (State.RUNNING == ReactorState)
            {
                try
                {
                    TcpClient client = tcpListener_.AcceptTcpClient();
                    ApplySocketOptions(client, socketSettings_);

                    ClientHandlerThread t = null;
                    if (sessionDict_ != null)
                    {
                        // this if only needed for deprecated DebugFileLogPath setting - remove in v2
#pragma warning disable 618
                        t = new ClientHandlerThread(client, nextClientId_++, sessionDict_);
#pragma warning restore 618
                    }
                    else
                    {
                        t = new ClientHandlerThread(client, nextClientId_++, Log);
                    }


                    lock (sync_)
                    {
                        clientThreads_.AddLast(t);
                    }

                    Log.OnEvent("connected");

                    t.Start();
                }
                catch (System.Exception e)
                {
                    if (State.RUNNING == ReactorState)
                    {
                        Log.OnEvent("Error accepting connection: " + e.Message);
                        Log.OnDebug(e.ToString());
                    }
                }
            }
            ShutdownClientHandlerThreads();
        }

        /// <summary>
        /// FIXME get socket options from SessionSettings
        /// </summary>
        /// <param name="client"></param>
        public static void ApplySocketOptions(TcpClient client, SocketSettings socketSettings)
        {
            client.LingerState = new LingerOption(false, 0);
            client.NoDelay = socketSettings.SocketNodelay;
        }

        private void ShutdownClientHandlerThreads()
        {
            lock (sync_)
            {
                if (State.SHUTDOWN_COMPLETE != state_)
                {
                    Log.OnEvent("shutting down...");

                    while (clientThreads_.Count > 0)
                    {
                        ClientHandlerThread t = clientThreads_.First.Value;
                        clientThreads_.RemoveFirst();
                        t.Shutdown("reactor is shutting down");
                        try
                        {
                            t.Join();
                        }
                        catch (System.Exception e)
                        {
                            Log.OnEvent("Error shutting down: " + e.Message);
                            Log.OnDebug(e.ToString());
                        }
                    }
                    state_ = State.SHUTDOWN_COMPLETE;
                }
            }
        }
    }
}
