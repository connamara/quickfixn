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
        #region Events/Delegates
        public delegate void RawDataReceivedHandler(object sender, string rawData);
        public event RawDataReceivedHandler RawDataReceived;
        #endregion

        #region Properties
        public bool Connected { get { return _socket.Connected; } }
        #endregion

        public SocketInitiator(Application application, Settings settings)
        {
            _app = application;
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

                while (true)
                {
                    if (_shutdown) break;

                    try
                    {
                        int bytesReceived = _socket.Receive(_readBuffer);
                        HandleMessage(Encoding.UTF8.GetString(_readBuffer, 0, bytesReceived));
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
        /// Message parsing and passing back to crackers will go here.
        /// </summary>
        /// <param name="data"></param>
        private void HandleMessage(string data)
        {
            string[] split = data.Split('\n');

            for (int i = 0; i < split.Length; i++)
            {
                _currentMessage += split[i];
                NotifyRawData(_currentMessage);
                _currentMessage = String.Empty;
            }

            _currentMessage = split[split.Length];
        }

        /// <summary>
        /// Send raw string over socket.
        /// </summary>
        /// <param name="data"></param>
        public void Send(string data)
        {

            byte[] rawData = Encoding.UTF8.GetBytes(data);
            _socket.Send(rawData);
        }

        /// <summary>
        /// Close connection.
        /// </summary>
        public void Close()
        {
            _shutdown = true;
            _socket.Shutdown(SocketShutdown.Both);
        }

        private void NotifyRawData(string data)
        {
            if (RawDataReceived != null)
                RawDataReceived(this, data);
        }

        #region Private Members
        private Socket _socket;
        private Application _app;
        private Settings _settings;
        private byte[] _readBuffer = new byte[512];
        private string _currentMessage;
        private bool _shutdown = false;
        #endregion
    }
}
