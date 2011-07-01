using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using QuickFix.Config;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace QuickFix.Transport
{
    public class SocketInitiator : Initiator
    {
        public const string SOCKET_CONNECT_HOST = "SocketConnectHost";
        public const string SOCKET_CONNECT_PORT = "SocketConnectPort";
        public const string RECONNECT_INTERVAL  = "ReconnectInterval";

        #region Events/Delegates
        public delegate void RawDataReceivedHandler(object sender, string rawData);
        public event RawDataReceivedHandler RawDataReceived;
        #endregion

        #region Properties
        
        public bool Connected
        {
            get
            {
                if (null == socket_)
                    return false;
                return socket_.Connected;
            }
        }

        #endregion

        #region Private Members
        
        private Application app_;
        private SessionSettings settings_;
        private MessageStoreFactory storeFactory_;
        private LogFactory logFactory_;
        private Socket socket_ = null;
        private byte[] _readBuffer = new byte[512];
        private string _currentMessage;
        private volatile bool disconnectRequested_ = false;
        private volatile bool shutdownRequested_ = false;
        
        #endregion

        public SocketInitiator(Application application, MessageStoreFactory storeFactory, SessionSettings settings)
            : this(application, storeFactory, settings, null)
        { }

        public SocketInitiator(Application application, MessageStoreFactory storeFactory, SessionSettings settings, LogFactory logFactory)
            : base(application, storeFactory, settings, logFactory)
        {
            app_ = application;
            storeFactory_ = storeFactory;
            settings_ = settings;
            logFactory_ = logFactory;
        }

        /// <summary>
        /// Main initiator reconnect loop.
        /// </summary>
        private void ClientLoop()
        {
            string host = "";
            int port = -1;
            int reconnectInterval = -1;

            try
            {
                /// FIXME we need to load settings for each Session in the cfg, not just the defaults
                QuickFix.Dictionary dict = settings_.Get();
                host = dict.GetString(SOCKET_CONNECT_HOST);
                port = Convert.ToInt32(dict.GetLong(SOCKET_CONNECT_PORT));
                reconnectInterval = Convert.ToInt32(dict.GetLong(RECONNECT_INTERVAL));
            }
            catch (ConfigError e)
            {
                System.Console.WriteLine(e.Message);
                return;
            }

            while (!shutdownRequested_)
            {
                try
                {
                    socket_ = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket_.Connect(host, port);
                }
                catch (SocketException e)
                {
                    Console.WriteLine("Error connecting to socket: " + e.Message);
                    Thread.Sleep(reconnectInterval * 1000);
                    continue;
                }

                ///FIXME Send("8=FIX.4.2\x01" + "9=54\x01" + "35=A\x01" + "34=1\x01" + "49=CLIENT1\x01" + "52=20110625-08:45:00\x01" + "56=EXECUTOR\x01" + "10=000\x01");
                while(!disconnectRequested_)
                {
                    try
                    {
                        int bytesReceived = socket_.Receive(_readBuffer);
                        HandleMessage(Encoding.UTF8.GetString(_readBuffer, 0, bytesReceived));
                    }
                    catch (SocketException e)
                    {
                        if(!disconnectRequested_)
                            Console.WriteLine("Error reading socket: " + e.Message);
                        disconnectRequested_ = true;
                    }
                }

                socket_.Shutdown(SocketShutdown.Both);
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
            socket_.Send(rawData);
        }

        private void NotifyApplication(string data)
        {
            Message msg = new Message();
            msg.FromString(data);
            app_.OnMessage(msg);
        }

        private void NotifyRawData(string data)
        {
            if (RawDataReceived != null)
                RawDataReceived(this, data);
        }

        #region Initiator Methods
        
        protected override void OnStart()
        {
            disconnectRequested_ = false;
            shutdownRequested_ = false;
            ClientLoop();
        }

        protected override bool OnPoll(double timeout)
        {
            throw new NotImplementedException("FIXME - SocketInitiator.OnPoll not implemented!");
        }

        protected override void OnStop()
        {
            shutdownRequested_ = true;
            disconnectRequested_ = true;
            if(null != socket_)
                socket_.Shutdown(SocketShutdown.Both);
        }

        protected override void DoConnect(SessionID sessionID, Dictionary settings)
        {
            throw new NotImplementedException("FIXME - SocketInitiator.DoConnect not implemented!");
        }

        #endregion
    }
}
