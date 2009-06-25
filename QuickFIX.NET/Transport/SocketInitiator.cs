using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using QuickFIX.NET.Config;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace QuickFIX.NET.Transport
{
    public class SocketInitiator
    {
        public bool Connected { get { return _socket.Connected; } }

        public SocketInitiator(Application application, Settings settings)
        {
            _application = application;
            _settings = settings;
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            Thread t = new Thread(new ThreadStart(ClientLoop));
            t.IsBackground = false;
            t.Start();
        }

        /// <summary>
        /// Main initiator reconnect loop.
        /// </summary>
        private void ClientLoop()
        {
            while (true)
            {
                try
                {
                    // TODO: Can use .BeginConnect() if asychronous "connected" callback is necessary.
                    _socket.Connect(_settings.SocketConnectHost, _settings.SocketConnectPort);
                }
                catch (SocketException sex)
                {
                    Debug.WriteLine(sex.ToString());
                    Thread.Sleep(_settings.ReconnectInterval);
                    continue;
                }

                while (true)
                {
                    _socket.Receive(_readBuffer);
                    Debug.WriteLine("Received: " + _readBuffer);
                }
            }
        }

        /// <summary>
        /// Close connection.
        /// </summary>
        public void Close()
        {
            _socket.Disconnect(true);
        }

        #region Private Members
        private Socket _socket;
        private Application _application;
        private Settings _settings;
        private byte[] _readBuffer = new byte[512];
        #endregion
    }
}
