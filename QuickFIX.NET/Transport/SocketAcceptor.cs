using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix.Config;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace QuickFix.Transport
{
    public class SocketAcceptor
    {
        #region Events/Delegates
        public delegate void DataReceivedFromClientHandler(object sender, string data);
        public event DataReceivedFromClientHandler DataReceivedFromClient;
        #endregion

        #region Constants
        public const int BLOCK_SIZE = 512;
        #endregion

        #region Properties
        public int NumberOfClientsConnected { get { return clientList_.Count; } }
        #endregion

        #region Constructors
        public SocketAcceptor(Application app, Settings settings)
        {
            app_ = app;
            settings_ = settings;
            shutdownRequested_ = false;
        }
        #endregion

        #region Client Communication
        /// <summary>
        /// Start main server loop thread.
        /// </summary>
        public void Start()
        {
            IPAddress address = IPAddress.Parse(settings_.SocketAcceptHost);
            listener_ = new TcpListener(address, settings_.SocketAcceptPort);
            listenThread_ = new Thread(new ThreadStart(AcceptorLoop));
            listenThread_.Start();
        }

        /// <summary>
        /// Main server loop.
        /// </summary>
        private void AcceptorLoop()
        {
            listener_.Start();
            shutdownRequested_ = false;
            while (!shutdownRequested_)
            {
                try
                {
                    TcpClient client = listener_.AcceptTcpClient();
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                    clientThread.Start(client);
                }
                catch (SocketException e)
                {
                    if(!shutdownRequested_)
                        System.Console.WriteLine("Error accepting connection: " + e.Message);
                }
            }
        }

        /// <summary>
        /// Handle newly connected client and spawn a thread.
        /// </summary>
        /// <param name="client">Connected TcpClient</param>
        private void HandleClient(object client)
        {
            TcpClient c = (TcpClient)client;
            clientList_.Add(c.GetHashCode(), c);

            NetworkStream clientStream = c.GetStream();
            // Initialize message buffer for new client.
            currentClientMsg_.Add(clientStream.GetHashCode(), String.Empty);

            byte[] message = new byte[BLOCK_SIZE];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, BLOCK_SIZE);
                }
                catch (System.Exception e) // Socket error
                {
                    Debug.WriteLine("SocketAcceptor: client read exception: " + e.ToString());
                    break;
                }

                if (ClientHasDisconnected(bytesRead))
                    break;

                HandleDataReceived(Encoding.UTF8.GetString(message, 0, bytesRead), clientStream.GetHashCode());
            }
        }

        private void HandleDataReceived(string data, int clientHashCode)
        {
            string[] split = data.Split('\n');

            for (int i = 0; i < split.Length; i++)
            {
                currentClientMsg_[clientHashCode] += split[i].Trim(trimChars);
                if (currentClientMsg_[clientHashCode].Length > 0)
                {
                    NotifyRawData(currentClientMsg_[clientHashCode]);
                    NotifyApplication(currentClientMsg_[clientHashCode]);
                }
                currentClientMsg_[clientHashCode] = String.Empty;
            }

            currentClientMsg_[clientHashCode] = split[split.Length-1];
        }

        private static char[] trimChars = { '\0' };

        private bool ClientHasDisconnected(int bytesRead) { return (bytesRead == 0); }
        #endregion

        #region Shutdown/Logout
        /// <summary>
        /// Forcefully close all connections without sending logout.
        /// </summary>
        public void ForceShutdown()
        {
            foreach (TcpClient client in clientList_.Values)
            {
                try
                {
                    client.Close();
                }
                catch (SocketException ex)
                {
                    Debug.WriteLine("Exception while closing socket: " + ex.ToString());
                }
            }

            clientList_.Clear();
        }

        /// <summary>
        /// Closes and stops socket listener.
        /// </summary>
        public void Stop()
        {
            if (!listenThread_.IsAlive)
                return;

            shutdownRequested_ = true;
            //listenThread_.Interrupt();
            listener_.Server.Close();
            listener_.Stop();
            listenThread_.Join(5000);
        }

        /// <summary>
        /// Gracefully shut down all clients, sending a logout to each.
        /// </summary>
        public void Shutdown()
        {
            throw new NotImplementedException("Graceful shutdowns not yet implemented.");
        }
        #endregion

        private void NotifyApplication(string data)
        {
            Message msg = new Message();
            msg.FromString(data);
            app_.OnMessage(msg);
        }

        #region Event Helpers
        private void NotifyRawData(string data)
        {
            if (DataReceivedFromClient != null)
                DataReceivedFromClient(this, data);
        }
        #endregion

        #region Private Members
        private Application app_;
        private Settings settings_;
        private TcpListener listener_;
        private Thread listenThread_;
        private volatile bool shutdownRequested_;
        private Dictionary<int, TcpClient> clientList_ = new Dictionary<int,TcpClient>();
        private Dictionary<int, string> currentClientMsg_ = new Dictionary<int,string>();
        #endregion
    }
}
