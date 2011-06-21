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

        public SocketInitiator(Application application, MessageStoreFactory storeFactory, SessionSettings settings, LogFactory logFactory)
        {
            throw new System.NotImplementedException();
        }

        public void Start()
        {
            if ((clientThread_ != null) && clientThread_.IsAlive)
                return;

            disconnectRequested_ = false;
            shutdownRequested_ = false;
            clientThread_ = new Thread(new ThreadStart(ClientLoop));
            clientThread_.Start();
        }

        public void Stop()
        {
            shutdownRequested_ = true;
            Close();
            clientThread_.Join(5000);
        }

        /// <summary>
        /// Main initiator reconnect loop.
        /// </summary>
        private void ClientLoop()
        {
            while (!shutdownRequested_)
            {
                try
                {
                    _socket.Connect(_settings.SocketConnectHost, _settings.SocketConnectPort);
                }
                catch (SocketException e)
                {
                    Console.WriteLine("Error connecting to socket: " + e.Message);
                    Thread.Sleep(_settings.ReconnectInterval * 1000);
                    continue;
                }

                while(!disconnectRequested_)
                {
                    try
                    {
                        int bytesReceived = _socket.Receive(_readBuffer);
                        HandleMessage(Encoding.UTF8.GetString(_readBuffer, 0, bytesReceived));
                    }
                    catch (SocketException e)
                    {
                        if(!disconnectRequested_)
                            Console.WriteLine("Error reading socket: " + e.Message);
                    }
                }

                disconnectRequested_ = false;
            }
        }

        /// <summary>
        /// Message parsing and passing back to crackers will go here.
        /// </summary>
        /// <param name="data"></param>
        private void HandleMessage(string data)
        {
            string[] split = data.Split('\n');

            for (int i = 0; i < split.Length-1; i++)
            {
                _currentMessage += split[i];
                NotifyRawData(_currentMessage);
                NotifyApplication(_currentMessage);
                _currentMessage = String.Empty;
            }

            _currentMessage = split[split.Length-1];
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
            disconnectRequested_ = true;
            _socket.Shutdown(SocketShutdown.Both);
        }

        private void NotifyApplication(string data)
        {
            Message msg = new Message();
            msg.FromString(data);
            _app.OnMessage(msg);
        }

        private void NotifyRawData(string data)
        {
            if (RawDataReceived != null)
                RawDataReceived(this, data);
        }

        #region Private Members
        private Thread clientThread_;
        private Socket _socket;
        private Application _app;
        private Settings _settings;
        private byte[] _readBuffer = new byte[512];
        private string _currentMessage;
        private volatile bool disconnectRequested_ = false;
        private volatile bool shutdownRequested_ = false;
        #endregion
    }
}
