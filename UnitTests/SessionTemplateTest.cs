using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

using NUnit.Framework;
using QuickFix;
using QuickFix.Transport;

namespace UnitTests
{
    [TestFixture]
    class SessionTemplateTest
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
        ThreadedSocketAcceptor _acceptor;
        Dictionary<string, SocketState> _sessions;
        HashSet<string> _loggedOnCompIDs;
        Socket _listenSocket;

        Dictionary CreateAcceptorConfig()
        {
            Dictionary settings = new Dictionary();
            settings.SetString(SessionSettings.CONNECTION_TYPE, "acceptor");
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.START_TIME, "12:00:00");
            settings.SetString(SessionSettings.END_TIME, "12:00:00");
            settings.SetString(SessionSettings.HEARTBTINT, "300");
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

        void StartAcceptor(SessionID sessionID)
        {
            TestApplication application = new TestApplication(LogonCallback, LogoffCallback);
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionSettings settings = new SessionSettings();
            Dictionary defaults = new Dictionary();
            defaults.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, _logPath);

            // Put IP endpoint settings into default section to verify that that defaults get merged into
            // session-specific settings not only for static sessions, but also for dynamic ones
            defaults.SetString(SessionSettings.SOCKET_ACCEPT_HOST, Host);
            defaults.SetString(SessionSettings.SOCKET_ACCEPT_PORT, AcceptPort.ToString());

            settings.Set(defaults);
            ILogFactory logFactory = new FileLogFactory(settings);

            settings.Set(sessionID, CreateAcceptorConfig());

            _acceptor = new ThreadedSocketAcceptor(application, storeFactory, settings, logFactory);
            _acceptor.Start();
        }

        void StartListener()
        {
            var address = IPAddress.Parse(Host);
            var listenEndpoint = new IPEndPoint(address, ConnectPort);
            _listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _listenSocket.Bind(listenEndpoint);
            _listenSocket.Listen(10);
            _listenSocket.BeginAccept(new AsyncCallback(ProcessInboundConnect), null);
        }

        void ProcessInboundConnect(IAsyncResult ar)
        {
            Socket handler = null;
            try
            {
                handler = _listenSocket.EndAccept(ar);
            }
            catch
            {
                _listenSocket = null; // Assume listener has been closed
            }

            if (handler != null)
            {
                ReceiveAsync(new SocketState(handler));
                _listenSocket.BeginAccept(new AsyncCallback(ProcessInboundConnect), null);
            }
        }

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
            string msgText = CharEncoding.DefaultEncoding.GetString(socketState._rxBuffer, 0, bytesReceived);
            foreach (Match m in Regex.Matches(msgText, FIXMessageDelimit))
            {
                socketState._messageFragment += m.Value;
                if (Regex.IsMatch(socketState._messageFragment, FIXMessageEnd))
                {
                    Message message = new Message(socketState._messageFragment);
                    socketState._messageFragment = string.Empty;
                    string targetCompID = message.Header.GetString(QuickFix.Fields.Tags.TargetCompID);
                    if (message.Header.GetString(QuickFix.Fields.Tags.MsgType) == QuickFix.Fields.MsgType.LOGON)
                        lock (_sessions)
                        {
                            _sessions[targetCompID] = socketState;
                            Monitor.Pulse(_sessions);
                        }
                }
            }
            ReceiveAsync(socketState);
        }

        void ReceiveAsync(SocketState socketState)
        {
            socketState._socket.BeginReceive(socketState._rxBuffer, 0, socketState._rxBuffer.Length, SocketFlags.None, new AsyncCallback(ProcessRXData), socketState); ;
        }

        Socket ConnectToEngine()
        {
            return ConnectToEngine(AcceptPort);
        }

        Socket ConnectToEngine(int port)
        {
            var address = IPAddress.Parse(Host);
            var endpoint = new IPEndPoint(address, port);
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(endpoint);
                ReceiveAsync(new SocketState(socket));
                return socket;
            }
            catch (Exception ex)
            {
                Assert.Fail(string.Format("Failed to connect: {0}", ex.Message));
                return null;
            }
        }

        Socket GetSocket(string compID)
        {
            lock (_sessions)
                return _sessions[compID]._socket;
        }

        bool WaitForLogonStatus(string targetCompID)
        {
            lock (_loggedOnCompIDs)
            {
                if (!_loggedOnCompIDs.Contains(targetCompID))
                    Monitor.Wait(_loggedOnCompIDs, 10000);
                return _loggedOnCompIDs.Contains(targetCompID);
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

        bool WaitForDisconnect(Socket s)
        {
            lock (s)
            {
                if (s.Connected)
                    Monitor.Wait(s, 10000);
                return !s.Connected;
            }
        }

        bool WaitForDisconnect(string compID)
        {
            return WaitForDisconnect(GetSocket(compID));
        }

        bool HasReceivedMessage(string compID)
        {
            lock (_sessions)
                return _sessions.ContainsKey(compID);
        }

        bool IsLoggedOn(string compID)
        {
            lock (_loggedOnCompIDs)
                return _loggedOnCompIDs.Contains(compID);
        }

        void SendInitiatorLogon(string senderCompID)
        {
            SendLogon(GetSocket(senderCompID), senderCompID);
        }

        void SendLogon(Socket s, string senderCompID)
        {
            SendLogon(s, senderCompID, ServerCompID);
        }

        void SendLogon(Socket s, string senderCompID, string targetCompID)
        {
            var msg = new QuickFix.FIX42.Logon();
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(targetCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(senderCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(1));
            msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            msg.SetField(new QuickFix.Fields.HeartBtInt(300));
            // Simple logon message
            s.Send(CharEncoding.DefaultEncoding.GetBytes(msg.ToString()));
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
            if (_acceptor != null)
                _acceptor.Stop(true);

            _initiator = null;
            _acceptor = null;

            Thread.Sleep(500);
            ClearLogs();
        }

        [Test]
        public void DynamicAcceptor()
        {
            // Starting Acceptor with template for sessions
            SessionID templateSessionID = new SessionID(QuickFix.Values.BeginString_FIX42, "DYN_SERVER", "*");
            StartAcceptor(templateSessionID);

            // Ensure we can log using the defined template
            var socket01 = ConnectToEngine();
            SendLogon(socket01, "ANY_CLIENT", "DYN_SERVER");
            Assert.IsTrue(WaitForLogonStatus("ANY_CLIENT"), "Failed to logon templated acceptor session");

            // Ensure we can log using the defined template with the other client CompID
            var socket011 = ConnectToEngine();
            SendLogon(socket011, "ANY_OTHER_CLIENT", "DYN_SERVER");
            Assert.IsTrue(WaitForLogonStatus("ANY_OTHER_CLIENT"), "Failed to logon templated acceptor session");

            // Ensure that attempt to log on as not matching the template does not work
            var socket02 = ConnectToEngine();
            SendLogon(socket02, "NEW_CLIENT", "NOT_CONFIGURED");
            Assert.IsTrue(WaitForDisconnect(socket02), "Server failed to disconnect unconfigured CompID");
            Assert.False(HasReceivedMessage("NEW_CLIENT"), "Unexpected message received for unconfigured CompID");

            // Add the new session template to acceptor and ensure that we can now log on
            SessionID secondTemplateSessionID = new SessionID(QuickFix.Values.BeginString_FIX42, "DYN_2ND_SERVER", "*");
            var sessionConfig = CreateAcceptorConfig();
            Assert.IsTrue(_acceptor.AddSession(secondTemplateSessionID, sessionConfig), "Failed to add dynamic session template to acceptor");
            var socket03 = ConnectToEngine();
            SendLogon(socket03, "NEW_CLIENT", "DYN_2ND_SERVER");
            Assert.IsTrue(WaitForLogonStatus("NEW_CLIENT"), "Failed to logon dynamically added acceptor template session");
            SessionID dynamicDessionID = new SessionID(Values.BeginString_FIX42, "DYN_2ND_SERVER", "NEW_CLIENT");

            // Ensure that we can't add the same session again
            Assert.IsFalse(_acceptor.AddSession(secondTemplateSessionID, sessionConfig), "Added dynamic session template twice");

            // Template session can be deleted even after logon, as the new (non-template) sessions are created for those
            Assert.IsTrue(_acceptor.RemoveSession(secondTemplateSessionID, false), "Failed to remove active session template");
            // Now that dynamic acceptor is logged on, ensure that unforced attempt to remove session fails
            Assert.IsFalse(_acceptor.RemoveSession(dynamicDessionID, false), "Unexpected success removing active session");
            Assert.IsTrue(socket03.Connected, "Unexpected loss of connection");

            // Ensure that forced attempt to remove session dynamic session succeeds, even though it is in logged on state
            Assert.IsTrue(_acceptor.RemoveSession(dynamicDessionID, true), "Failed to remove active session");
            Assert.IsTrue(WaitForDisconnect(socket03), "Socket still connected after session removed");
            Assert.IsFalse(IsLoggedOn("NEW_CLIENT"), "Session still logged on after being removed");
        }    
    }
}
