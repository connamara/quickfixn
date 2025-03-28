using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using QuickFix;
using QuickFix.Logger;
using QuickFix.Store;
using QuickFix.Transport;

namespace UnitTests
{
    [TestFixture]
    [Category("SocketInitiator")]
    class SocketInitiatorTests
    {
        public class TestApplication : IApplication
        {
            Action<string> _logonNotify;
            Action<string> _logoffNotify;
            
            public TestApplication(Action<string> logonNotify, Action<string> logoffNotify)
            {
                _logonNotify = logonNotify;
                _logoffNotify = logoffNotify;
            }
            public void FromAdmin(Message message, SessionID sessionID)
            { }

            public void FromApp(Message message, SessionID sessionID)
            { }

            public void OnCreate(SessionID sessionID) { }
            public void OnLogout(SessionID sessionID)
            {
                _logoffNotify(sessionID.TargetCompID);
            }
            public void OnLogon(SessionID sessionID)
            {
                _logonNotify(sessionID.TargetCompID);
            }

            public void ToAdmin(Message message, SessionID sessionID) { }
            public void ToApp(Message message, SessionID sessionID) { }
        }
        class SocketState
        {
            public SocketState(Socket s)
            {
                _socket = s;
            }
            public Socket _socket;
            public byte[] _rxBuffer = new byte[1024];
            public string _messageFragment = string.Empty;
            public string _exMessage;
        }

        const string Host = "127.0.0.1";
        const int ConnectPort = 55100;
        const int AcceptPort = 55101;
        const int AcceptPort2 = 55102;
        const string ServerCompID = "dummy";
        const string StaticInitiatorCompID = "ini01";
        const string StaticAcceptorCompID = "acc01";
        const string StaticAcceptorCompID2 = "acc02";

        const string FIXMessageEnd = @"\x0110=\d{3}\x01";
        const string FIXMessageDelimit = @"(8=FIX|\A).*?(" + FIXMessageEnd + @"|\z)";

        string _logPath;
        SocketInitiator _initiator;
        Dictionary<string, SocketState> _sessions;
        HashSet<string> _loggedOnCompIDs;
        Socket _listenSocket;
        bool _disconnectOnLogon = false;

        SettingsDictionary CreateSessionConfig(string targetCompID, bool isInitiator, string startTime = null, string endTime = null )
        {
            startTime ??= "00:00:00";
            endTime ??= "00:00:00";
            SettingsDictionary settings = new SettingsDictionary();
            settings.SetString(SessionSettings.CONNECTION_TYPE, isInitiator ? "initiator" : "acceptor");
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.START_TIME, startTime);
            settings.SetString(SessionSettings.END_TIME, endTime);
            settings.SetString(SessionSettings.HEARTBTINT, "3");
            return settings;
        }

        SessionID CreateSessionID(string targetCompID)
        {
            return new SessionID(QuickFix.Values.BeginString_FIX42, ServerCompID, targetCompID);
        }

        void LogonCallback(string compID)
        {
            lock (_loggedOnCompIDs)
            {
                _loggedOnCompIDs.Add(compID);
                Monitor.Pulse(_loggedOnCompIDs);
            }
        }
        void LogoffCallback(string compID)
        {
            lock (_loggedOnCompIDs)
            {
                _loggedOnCompIDs.Remove(compID);
                Monitor.Pulse(_loggedOnCompIDs);
            }
        }

        void StartEngine(string sessionStartTime = null, string sessionEndTime = null )
        {
            TestApplication application = new TestApplication(LogonCallback, LogoffCallback);
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionSettings settings = new SessionSettings();
            SettingsDictionary defaults = new SettingsDictionary();
            defaults.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, _logPath);

            // Put IP endpoint settings into default section to verify that that defaults get merged into
            // session-specific settings not only for static sessions, but also for dynamic ones
            defaults.SetString(SessionSettings.SOCKET_CONNECT_HOST, Host);
            defaults.SetString(SessionSettings.SOCKET_CONNECT_PORT, ConnectPort.ToString());
            defaults.SetString(SessionSettings.SOCKET_ACCEPT_HOST, Host);
            defaults.SetString(SessionSettings.SOCKET_ACCEPT_PORT, AcceptPort.ToString());

            settings.Set(defaults);
            ILogFactory logFactory = new FileLogFactory(settings);

            defaults.SetString(SessionSettings.RECONNECT_INTERVAL, "2");
            defaults.SetString(SessionSettings.HEARTBTINT, "2");
            settings.Set(CreateSessionID(StaticInitiatorCompID), CreateSessionConfig(StaticInitiatorCompID, true, sessionStartTime, sessionEndTime));
            _initiator = new SocketInitiator(application, storeFactory, settings, logFactory);
            _initiator.Start();
        }

        void StartListener()
        {
            var address = IPAddress.Parse(Host);
            var listenEndpoint = new IPEndPoint(address, ConnectPort);
            if (_listenSocket == null)
            {
                _listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _listenSocket.Bind(listenEndpoint);
                
            }
            _listenSocket.Listen(10);
            _listenSocket.BeginAccept(ProcessInboundConnect, _listenSocket);
        }

        void DisonnectSessionSocket(string compId)
        {
            GetSocket(compId).Disconnect(true);
            _loggedOnCompIDs.Remove(compId);
            _sessions.Remove(compId);
        }

        void ProcessInboundConnect(IAsyncResult ar)
        {
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = null;
            try
            {
                handler = listener.EndAccept(ar);
            }
            catch
            {
                _listenSocket = null; // Assume listener has been closed
            }

            if (handler != null)
            {
                ReceiveAsync(new SocketState(handler));
                _listenSocket.BeginAccept(ProcessInboundConnect, null);
            }
        }

        private ulong _seqNum = 1;

        void ProcessRXData(IAsyncResult ar)
        {
            SocketState socketState = (SocketState)ar.AsyncState;
            int bytesReceived = 0;
            try
            {
                bytesReceived = socketState._socket.EndReceive(ar);
            }
            catch (Exception ex)
            {
                socketState._exMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
            }

            if (bytesReceived == 0)
            {
                socketState._socket.Close();
                lock (socketState._socket)
                    Monitor.Pulse(socketState._socket);
                return;
            }
            string msgText = CharEncoding.SelectedEncoding.GetString(socketState._rxBuffer, 0, bytesReceived);
            foreach (Match m in Regex.Matches(msgText, FIXMessageDelimit))
            {
                socketState._messageFragment += m.Value;
                if (Regex.IsMatch(socketState._messageFragment, FIXMessageEnd))
                {
                    Message message = new Message(socketState._messageFragment);
                    socketState._messageFragment = string.Empty;
                    string targetCompID = message.Header.GetString(QuickFix.Fields.Tags.TargetCompID);
                    if (message.Header.GetString(QuickFix.Fields.Tags.MsgType) == QuickFix.Fields.MsgType.LOGON)
                    {
                        
                        lock (_sessions)
                        {
                            _sessions[targetCompID] = socketState;
                            Monitor.Pulse(_sessions);
                        }
                        SendInitiatorLogon(targetCompID);
                    }
                    else if (message.Header.GetString(QuickFix.Fields.Tags.MsgType) == QuickFix.Fields.MsgType.HEARTBEAT)
                    {
                        SendHeartbeat(GetSocket(targetCompID), targetCompID);
                    }
                    else
                    {
                        Console.WriteLine(message.ToString());
                    }
                }
            }

            try
            {
                ReceiveAsync(socketState);
            }
            catch (System.ObjectDisposedException)
            {
                // ignore socket disposed
            }
        }

        void ReceiveAsync(SocketState socketState)
        {
            socketState._socket.BeginReceive(socketState._rxBuffer, 0, socketState._rxBuffer.Length, SocketFlags.None, ProcessRXData, socketState);
        }

        Socket GetSocket(string compID)
        {
            lock (_sessions)
                return _sessions[compID]._socket;
        }
        
        bool HasLogonMessage(string targetCompID)
        {
            lock (_sessions)
            {
                return _sessions.ContainsKey(targetCompID);
            }
        }

        bool WaitForLogonMessage(string targetCompID)
        {
            lock (_sessions)
            {
                if (!_sessions.ContainsKey(targetCompID))
                    Monitor.Wait(_sessions, 10000);
                return _sessions.ContainsKey(targetCompID);
            }
        }

        void SendInitiatorLogon(string senderCompID)
        {
            SendLogon(GetSocket(senderCompID), senderCompID);
        }

        void SendLogon(Socket s, string senderCompID)
        {
            var msg = new QuickFix.FIX42.Logon();
            _seqNum = 1;
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(ServerCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(senderCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum++));
            msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            msg.SetField(new QuickFix.Fields.ResetSeqNumFlag(true));
            msg.SetField(new QuickFix.Fields.HeartBtInt(300));
            // Simple logon message
            var send = CharEncoding.GetBytes(msg.ConstructString());
            s.BeginSend(send, 0, send.Length, SocketFlags.None, SendCallback, s);
        }
        
        void SendHeartbeat(Socket s, string senderCompID)
        {
            var msg = new QuickFix.FIX42.Heartbeat();
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(ServerCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(senderCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(_seqNum++));
            msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            // Simple logon message
            var send = CharEncoding.GetBytes(msg.ConstructString());
            s.BeginSend(send, 0, send.Length, SocketFlags.None, SendCallback, s);
        }
        
        private static void SendCallback(IAsyncResult ar)
        {
            Socket clientSocket = (Socket)ar.AsyncState;
            int bytesSent = clientSocket.EndSend(ar);
            Console.WriteLine("Sent {0} bytes to client.", bytesSent);
        }
        
        void SendLogoff(Socket s, string senderCompID)
        {
            var msg = new QuickFix.FIX42.Logout();
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(ServerCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(senderCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(1));
            msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            msg.SetField(new QuickFix.Fields.Text("Logout"));
            // Simple logon message
            s.Send(CharEncoding.GetBytes(msg.ToString()));
        }

        void ClearLogs()
        {
            if (System.IO.Directory.Exists(_logPath))
                try
                {
                    System.IO.Directory.Delete(_logPath, true);
                }
                catch { }
        }

        [SetUp]
        public void Setup()
        {
            _logPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "log");
            _sessions = new Dictionary<string, SocketState>();
            _loggedOnCompIDs = new HashSet<string>();
            ClearLogs();
        }

        [TearDown]
        public void TearDown()
        {
            if (_listenSocket != null)
                _listenSocket.Close();
            if (_initiator != null)
                _initiator.Stop(true);

            _initiator = null;

            Thread.Sleep(500);
            ClearLogs();
        }

        /* The initial exception comes in when the listener (acceptor) disconnects the session this leads to a broken pipe Socket Exception during the SocketInitiatorThread.ReadSome method
         * subsequently because the Session is not set to be logged off every second the SocketInitiator will attempt to Generate a logout but this will fail because the socket has been disposed
         * with the following stack trace: * 
         * 
         * 
         * System.Network.NetworkStream.Write
         * QuickFix.SocketInitiatorThread.Send
         * QuickFix.Session.Send
         * QuickFix.Session.SendRaw
         * QuickFix.Session.ImplGenerateLogout
         * QuickFix.Session.Reset
         * QuickFix.AbstractInitiator.Connect
         * QuickFix.Transport.SocketInitiator.OnStart
         *
         * This test starts a listening socket to simulate an acceptor and then starts the initiator waits for a logon to be achieved and then kills the listening socket, waits for the session start time
         * and then start the listening socket and checks that the initiator can reconnect and establish the session  
         */
        [Test]
        public void Disconnecting_An_Initiator_From_A_Listening_Acceptor_At_End_Of_Session_Should_Allow_The_Initiator_To_Reconnect_At_Start()
        {
            // GIVEN - a listening socket that will disconnect on receiving a logon message from an initiator
            _disconnectOnLogon = true;
            StartListener();
            StartEngine(DateTime.UtcNow.AddSeconds(5).ToString("HH:mm:ss"),DateTime.UtcNow.AddSeconds(2).ToString("HH:mm:ss"));

            // WHEN - the logon is received the connection should disconnect
            Assert.That(WaitForLogonMessage(StaticInitiatorCompID), Is.True, "Failed to get logon message for static initiator session");
            Task.Delay(500).Wait();
            Assert.That(Session.LookupSession(CreateSessionID(StaticInitiatorCompID)).IsLoggedOn, Is.True);
            DisonnectSessionSocket(StaticInitiatorCompID);
            _listenSocket.Disconnect(true);
            Assert.That( HasLogonMessage(StaticInitiatorCompID), Is.False);
            Task.Delay(5000).Wait();
            Assert.That(Session.LookupSession(CreateSessionID(StaticInitiatorCompID)).IsLoggedOn, Is.False);
            
            //THEN Session Start Time the initiator should be able to logon again
            _disconnectOnLogon = false;
            StartListener();
            Task.Delay(5000).Wait();
            Assert.That(WaitForLogonMessage(StaticInitiatorCompID), Is.True,"Failed to get logon message for static initiator session");
            Assert.That(Session.LookupSession(CreateSessionID(StaticInitiatorCompID)).IsLoggedOn, Is.True);
        }
    }
}
