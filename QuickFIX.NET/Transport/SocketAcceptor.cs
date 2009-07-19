using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFIX.NET.Config;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace QuickFIX.NET.Transport
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
        public int NumberOfClientsConnected { get { return _clientList.Count; } }
        #endregion

        #region Constructors
        public SocketAcceptor(Application app, Settings settings)
        {
            _app = app;
            _settings = settings;
        }
        #endregion

        #region Client Communication
        /// <summary>
        /// Start main server loop thread.
        /// </summary>
        public void Start()
        {
            IPAddress address = IPAddress.Parse(_settings.SocketAcceptHost);
            _listener = new TcpListener(address, _settings.SocketAcceptPort);
            _listenThread = new Thread(new ThreadStart(AcceptorLoop));
            _listenThread.Start();
        }

        /// <summary>
        /// Main server loop.
        /// </summary>
        private void AcceptorLoop()
        {
            _listener.Start();

            while (true)
            {
                TcpClient client = _listener.AcceptTcpClient();
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                clientThread.Start(client);
            }
        }

        /// <summary>
        /// Handle newly connected client and spawn a thread.
        /// </summary>
        /// <param name="client">Connected TcpClient</param>
        private void HandleClient(object client)
        {
            TcpClient c = (TcpClient)client;
            _clientList.Add(c.GetHashCode(), c);

            NetworkStream clientStream = c.GetStream();
            // Initialize message buffer for new client.
            _currentClientMsg.Add(clientStream.GetHashCode(), String.Empty);

            byte[] message = new byte[BLOCK_SIZE];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, BLOCK_SIZE);
                }
                catch (Exception e) // Socket error
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
                _currentClientMsg[clientHashCode] += split[i].Trim(trimChars);
                if (_currentClientMsg[clientHashCode].Length > 0)
                {
                    NotifyRawData(_currentClientMsg[clientHashCode]);
                    NotifyApplication(_currentClientMsg[clientHashCode]);
                }
                _currentClientMsg[clientHashCode] = String.Empty;
            }

            _currentClientMsg[clientHashCode] = split[split.Length-1];
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
            foreach (TcpClient client in _clientList.Values)
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

            _clientList.Clear();
        }

        /// <summary>
        /// Closes and stops socket listener.
        /// </summary>
        public void Stop()
        {
            _listener.Server.Close();
            _listener.Stop();
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
            _app.OnMessage(msg);
        }

        #region Event Helpers
        private void NotifyRawData(string data)
        {
            if (DataReceivedFromClient != null)
                DataReceivedFromClient(this, data);
        }
        #endregion

        #region Private Members
        private Application _app;
        private Settings _settings;
        private TcpListener _listener;
        private Thread _listenThread;
        private Dictionary<int, TcpClient> _clientList = new Dictionary<int,TcpClient>();
        private Dictionary<int, string> _currentClientMsg = new Dictionary<int,string>();
        #endregion
    }
}
