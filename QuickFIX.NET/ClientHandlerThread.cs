using System.Net.Sockets;
using System.Threading;

namespace QuickFix
{
    public class ClientHandlerThread
    {
        private Thread thread_ = null;
        private volatile bool isShutdownRequested_ = false;
        private SocketReader socketReader_;
        private long id_;

        public ClientHandlerThread(TcpClient tcpClient, long clientId)
        {
            socketReader_ = new SocketReader(tcpClient);
            id_ = clientId;
        }

        public void Start()
        {
            thread_ = new Thread(new ThreadStart(Run));
            thread_.Start();
        }

        public void Shutdown()
        {
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
                    this.Log("Error reading socket: " + e.Message);
                    Shutdown();
                }
            }

            this.Log("shutdown");
        }

        /// <summary>
        /// FIXME do real logging
        /// </summary>
        /// <param name="s"></param>
        public void Log(string s)
        {
            System.Console.WriteLine("client " + id_ + ": " + s);
        }
    }
}
