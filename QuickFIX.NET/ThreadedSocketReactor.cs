using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;

namespace QuickFix
{
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
        private LinkedList<ClientHandlerThread> clientThreads_ = new LinkedList<ClientHandlerThread>();
        private TcpListener tcpListener_;

        #endregion

        public ThreadedSocketReactor(IPEndPoint serverSocketEndPoint)
        {
            tcpListener_ = new TcpListener(serverSocketEndPoint);
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
                        this.Log("Eror while closing server socket: " + e.Message);
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
                    ApplySocketOptions(client);
                    ClientHandlerThread t = new ClientHandlerThread(client, nextClientId_++);
                    lock (sync_)
                    {
                        clientThreads_.AddLast(t);
                    }
                    // FIXME set the client thread's exception handler here
                    t.Log("connected");
                    t.Start();
                }
                catch (System.Exception e)
                {
                    if (State.RUNNING == ReactorState)
                        this.Log("Error accepting connection: " + e.Message);
                }
            }
            ShutdownClientHandlerThreads();
        }

        /// <summary>
        /// FIXME get socket options from SessionSettings
        /// </summary>
        /// <param name="client"></param>
        public static void ApplySocketOptions(TcpClient client)
        {
            client.LingerState = new LingerOption(false, 0);
            client.NoDelay = true;
        }

        private void ShutdownClientHandlerThreads()
        {
            lock(sync_)
            {
                if(State.SHUTDOWN_COMPLETE != state_) 
                {
                    this.Log("shutting down...");
                    while(clientThreads_.Count > 0)
                    {
                        ClientHandlerThread t = clientThreads_.First.Value;
                        clientThreads_.RemoveFirst();
                        t.Shutdown();
                        try
                        {
                            t.Join();
                        }
                        catch(System.Exception e)
                        {
                            t.Log("Error shutting down: " + e.Message);
                        }
                    }
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
