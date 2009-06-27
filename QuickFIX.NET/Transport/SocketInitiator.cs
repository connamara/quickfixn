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
            _socket.ReceiveTimeout = 5000;
        }

        public void Start()
        {
            Thread t = new Thread(new ThreadStart(ClientLoop));
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
                    _socket.Connect(_settings.SocketConnectHost, _settings.SocketConnectPort);
                }
                catch (SocketException ex)
                {
                    Console.WriteLine(ex.ToString());
                    Thread.Sleep(_settings.ReconnectInterval);
                    continue;
                }

                Console.WriteLine("Connected");

                while (true)
                {
                    if (_shutdown) break;

                    try
                    {
                        _socket.Receive(_readBuffer);
                        Debug.WriteLine("Received: " + _readBuffer.ToString());
                    }
                    catch (SocketException iex)
                    {
                        Console.WriteLine(iex.ToString());
                    }
                }

                if (_shutdown) break;
            }
        }

        /// <summary>
        /// Send raw string over socket.
        /// </summary>
        /// <param name="data"></param>
        public void Send(string data)
        {
            byte[] rawData = Encoding.ASCII.GetBytes(data);
            _socket.Send(rawData);
        }

        /// <summary>
        /// Close connection.
        /// </summary>
        public void Close()
        {
            _shutdown = true;
            _socket.Disconnect(true);
        }

        #region Private Members
        private Socket _socket;
        private Application _application;
        private Settings _settings;
        private byte[] _readBuffer = new byte[512];
        private bool _shutdown = false;
        #endregion
    }
}
