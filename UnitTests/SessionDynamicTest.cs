using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

using NUnit.Framework;
using QuickFix;
using QuickFix.Logger;
using QuickFix.Store;
using QuickFix.Transport;

namespace UnitTests
{
    [TestFixture]
    [Category("DynamicSession")]
    public class SessionDynamicTest
    {
        public class TestApplication : IApplication
        {
            private readonly Action<string> _logonNotify;
            private readonly Action<string> _logoffNotify;
            public TestApplication(Action<string> logonNotify, Action<string> logoffNotify)
            {
                _logonNotify = logonNotify;
                _logoffNotify = logoffNotify;
            }
            public void FromAdmin(Message message, SessionID sessionId)
            { }

            public void FromApp(Message message, SessionID sessionId)
            { }

            public void OnCreate(SessionID sessionId) { }
            public void OnLogout(SessionID sessionId)
            {
                _logoffNotify(sessionId.TargetCompID);
            }
            public void OnLogon(SessionID sessionId)
            {
                _logonNotify(sessionId.TargetCompID);
            }

            public void ToAdmin(Message message, SessionID sessionId) { }
            public void ToApp(Message message, SessionID sessionId) { }
        }

        class SocketState
        {
            public SocketState(Socket s)
            {
                Socket = s;
            }
            public readonly Socket Socket;
            public readonly byte[] RxBuffer = new byte[1024];
            public string MessageFragment = string.Empty;
        }

        private const string Host = "127.0.0.1";
        private const int ConnectPort = 55100;
        private const int AcceptPort = 55101;
        private const int AcceptPort2 = 55102;
        private const string ServerCompId = "dummy";
        private const string StaticInitiatorCompId = "ini01";
        private const string StaticAcceptorCompId = "acc01";
        private const string StaticAcceptorCompId2 = "acc02";

        private const string FixMessageEnd = @"\x0110=\d{3}\x01";
        private const string FixMessageDelimit = @"(8=FIX|\A).*?(" + FixMessageEnd + @"|\z)";

        private string _logPath = "unset";
        private SocketInitiator? _initiator;
        private ThreadedSocketAcceptor? _acceptor;
        private Dictionary<string, SocketState> _sessions = new();
        private HashSet<string> _loggedOnCompIDs = new();
        private Socket? _listenSocket;

        private static SettingsDictionary CreateSessionConfig(bool isInitiator)
        {
            SettingsDictionary settings = new SettingsDictionary();
            settings.SetString(SessionSettings.CONNECTION_TYPE, isInitiator ? "initiator" : "acceptor");
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.START_TIME, "12:00:00");
            settings.SetString(SessionSettings.END_TIME, "12:00:00");
            settings.SetString(SessionSettings.HEARTBTINT, "300");
            return settings;
        }

        private static SessionID CreateSessionId(string targetCompId)
        {
            return new SessionID(QuickFix.Values.BeginString_FIX42, ServerCompId, targetCompId);
        }

        private void LogonCallback(string compId)
        {
            lock (_loggedOnCompIDs)
            {
                _loggedOnCompIDs.Add(compId);
                Monitor.Pulse(_loggedOnCompIDs);
            }
        }

        private void LogoffCallback(string compId)
        {
            lock (_loggedOnCompIDs)
            {
                _loggedOnCompIDs.Remove(compId);
                Monitor.Pulse(_loggedOnCompIDs);
            }
        }

        private void StartEngine(bool initiator, bool twoSessions = false)
        {
            TestApplication application = new TestApplication(LogonCallback, LogoffCallback);
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionSettings settings = new SessionSettings();
            SettingsDictionary defaults = new SettingsDictionary();
            defaults.SetString(SessionSettings.FILE_LOG_PATH, _logPath);

            // Put IP endpoint settings into default section to verify that that defaults get merged into
            // session-specific settings not only for static sessions, but also for dynamic ones
            defaults.SetString(SessionSettings.SOCKET_CONNECT_HOST, Host);
            defaults.SetString(SessionSettings.SOCKET_CONNECT_PORT, ConnectPort.ToString());
            defaults.SetString(SessionSettings.SOCKET_ACCEPT_HOST, Host);
            defaults.SetString(SessionSettings.SOCKET_ACCEPT_PORT, AcceptPort.ToString());

            settings.Set(defaults);
            ILogFactory logFactory = new FileLogFactory(settings);

            if (initiator)
            {
                defaults.SetString(SessionSettings.RECONNECT_INTERVAL, "1");
                settings.Set(CreateSessionId(StaticInitiatorCompId), CreateSessionConfig(true));
                _initiator = new SocketInitiator(application, storeFactory, settings, logFactory);
                _initiator.Start();
            }
            else
            {
                settings.Set(CreateSessionId(StaticAcceptorCompId), CreateSessionConfig(false));

                if (twoSessions)
                {
                    var id = CreateSessionId(StaticAcceptorCompId2);
                    var conf = CreateSessionConfig(false);

                    conf.SetString(SessionSettings.SOCKET_ACCEPT_PORT, AcceptPort2.ToString());
                    conf.SetString(SessionSettings.FILE_LOG_PATH, _logPath + "2");

                    settings.Set(id, conf);
                }

                _acceptor = new ThreadedSocketAcceptor(application, storeFactory, settings, logFactory);
                _acceptor.Start();
            }
        }

        private void StartListener()
        {
            var address = IPAddress.Parse(Host);
            var listenEndpoint = new IPEndPoint(address, ConnectPort);
            _listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _listenSocket.Bind(listenEndpoint);
            _listenSocket.Listen(10);
            _listenSocket.BeginAccept(ProcessInboundConnect, null);
        }

        private void ProcessInboundConnect(IAsyncResult ar)
        {
            if (_listenSocket == null)
                return;

            try
            {
                Socket handler = _listenSocket.EndAccept(ar);
                ReceiveAsync(new SocketState(handler));
                _listenSocket.BeginAccept(ProcessInboundConnect, null);
            }
            catch
            {
                _listenSocket = null; // Assume listener has been closed
            }
        }

        void ProcessRxData(IAsyncResult ar)
        {
            SocketState? socketState = (SocketState?)ar.AsyncState;
            if (socketState is null)
                throw new AssertionException("socketState is null");

            int bytesReceived = 0;
            try
            {
                bytesReceived = socketState.Socket.EndReceive(ar);
            }
            catch (Exception ex)
            {
                // don't know what else to do with this
                Console.WriteLine(ex.InnerException == null ? ex.Message : ex.InnerException.Message);
            }

            if (bytesReceived == 0)
            {
                socketState.Socket.Close();
                lock (socketState.Socket)
                    Monitor.Pulse(socketState.Socket);
                return;
            }
            string msgText = CharEncoding.DefaultEncoding.GetString(socketState.RxBuffer, 0, bytesReceived);
            foreach (Match m in Regex.Matches(msgText, FixMessageDelimit))
            {
                socketState.MessageFragment += m.Value;
                if (Regex.IsMatch(socketState.MessageFragment, FixMessageEnd))
                {
                    Message message = new Message(socketState.MessageFragment);
                    socketState.MessageFragment = string.Empty;
                    string targetCompId = message.Header.GetString(QuickFix.Fields.Tags.TargetCompID);
                    if (message.Header.GetString(QuickFix.Fields.Tags.MsgType) == QuickFix.Fields.MsgType.LOGON)
                        lock (_sessions)
                        {
                            _sessions[targetCompId] = socketState;
                            Monitor.Pulse(_sessions);
                        }
                }
            }

            try
            {
                ReceiveAsync(socketState);
            }
            catch (ObjectDisposedException)
            {
                // ignore socket disposed
            }
        }

        void ReceiveAsync(SocketState socketState)
        {
            socketState.Socket.BeginReceive(socketState.RxBuffer, 0, socketState.RxBuffer.Length, SocketFlags.None, ProcessRxData, socketState);
        }

        private Socket ConnectToEngine(int port = AcceptPort, int numRetries = 3)
        {
            var address = IPAddress.Parse(Host);
            var endpoint = new IPEndPoint(address, port);
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(endpoint);
                ReceiveAsync(new SocketState(socket));
            }
            catch (Exception ex)
            {
                string errorMsg = $"Failed to connect: {ex.Message}";
                if (numRetries > 0)
                {
                    numRetries--;
                    TestContext.Out.WriteLine($"{errorMsg}: Retries Remaining: {numRetries}: Retrying...");
                    Thread.Sleep(500);
                    return ConnectToEngine(port, numRetries);
                }

                Assert.Fail(errorMsg);
            }
            return socket;
        }

        Socket GetSocket(string compId)
        {
            lock (_sessions)
                return _sessions[compId].Socket;
        }

        bool WaitForLogonStatus(string targetCompId)
        {
            lock (_loggedOnCompIDs)
            {
                if (!_loggedOnCompIDs.Contains(targetCompId))
                    Monitor.Wait(_loggedOnCompIDs, 10000);
                return _loggedOnCompIDs.Contains(targetCompId);
            }
        }

        bool WaitForLogonMessage(string targetCompId)
        {
            lock (_sessions)
            {
                if (!_sessions.ContainsKey(targetCompId))
                    Monitor.Wait(_sessions, 10000);
                return _sessions.ContainsKey(targetCompId);
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

        bool WaitForDisconnect(string compId)
        {
            return WaitForDisconnect(GetSocket(compId));
        }

        bool HasReceivedMessage(string compId)
        {
            lock (_sessions)
                return _sessions.ContainsKey(compId);
        }

        bool IsLoggedOn(string compId)
        {
            lock (_loggedOnCompIDs)
                return _loggedOnCompIDs.Contains(compId);
        }

        void SendInitiatorLogon(string senderCompId)
        {
            SendLogon(GetSocket(senderCompId), senderCompId);
        }

        void SendLogon(Socket s, string senderCompId)
        {
            var msg = new QuickFix.FIX42.Logon();
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(ServerCompId));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(senderCompId));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(1));
            msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            msg.SetField(new QuickFix.Fields.HeartBtInt(300));
            // Simple logon message
            s.Send(CharEncoding.DefaultEncoding.GetBytes(msg.ConstructString()));
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
            _listenSocket?.Close();
            _initiator?.Stop(true);
            _acceptor?.Stop(true);

            _initiator = null;
            _acceptor = null;

            Thread.Sleep(500);
            ClearLogs();
        }

        [Test]
        public void DifferentPortForAcceptorTest()
        {
            //create two sessions with two different SOCKET_ACCEPT_PORT
            StartEngine(false, twoSessions: true);

            Thread.Sleep(100);

            // Ensure we can log on 1st session to 1st port
            using (var socket11 = ConnectToEngine(AcceptPort))
            {
                Assert.IsTrue(socket11.Connected, "Failed to connect to 1st accept port");
                SendLogon(socket11, StaticAcceptorCompId);
                Assert.IsTrue(WaitForLogonStatus(StaticAcceptorCompId), "Failed to logon 1st acceptor session");
            }

            // Ensure we can't log on 2nd session to 1st port
            using (var socket12 = ConnectToEngine(AcceptPort))
            {
                Assert.IsTrue(socket12.Connected, "Failed to connect to 1st accept port");
                SendLogon(socket12, StaticAcceptorCompId2);
                Assert.IsTrue(WaitForDisconnect(socket12), "Server failed to disconnect 2nd CompID from 1st port");
            }
        }

        [Test]
        public void AddSessionDynamicWithDifferentPortTest()
        {
            StartEngine(false);

            // Add the dynamic acceptor with another port and ensure that we can now log on
            const string dynamicCompId = "acc10";
            SessionID sessionId = CreateSessionId(dynamicCompId);
            SettingsDictionary sessionConfig = CreateSessionConfig(false);
            sessionConfig.SetString(SessionSettings.SOCKET_ACCEPT_PORT, AcceptPort2.ToString());

            if (_acceptor is null)
                throw new AssertionException("_acceptor is null");
            _acceptor.AddSession(sessionId, sessionConfig);

            var socket = ConnectToEngine(AcceptPort2);
            SendLogon(socket, dynamicCompId);

            Assert.IsTrue(WaitForLogonStatus(dynamicCompId), "Failed to logon dynamic added acceptor session with another port");
        }
        
        [Test]
        public void DynamicAcceptor()
        {
            StartEngine(false);
            if (_acceptor is null)
                throw new AssertionException("_acceptor is null");

            // Ensure we can log on statically (normally) configured acceptor
            var socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompId);
            Assert.IsTrue(WaitForLogonStatus(StaticAcceptorCompId), "Failed to logon static acceptor session");

            // Ensure that attempt to log on as yet un-added dynamic acceptor fails
            var socket02 = ConnectToEngine();
            string dynamicCompId = "acc10";
            SendLogon(socket02, dynamicCompId);
            Assert.IsTrue(WaitForDisconnect(socket02), "Server failed to disconnect unconfigured CompID");
            Assert.False(HasReceivedMessage(dynamicCompId), "Unexpected message received for unconfigured CompID");

            // Add the dynamic acceptor and ensure that we can now log on
            SessionID sessionId = CreateSessionId(dynamicCompId);
            SettingsDictionary sessionConfig = CreateSessionConfig(false);
            Assert.IsTrue(_acceptor.AddSession(sessionId, sessionConfig), "Failed to add dynamic session to acceptor");
            var socket03 = ConnectToEngine();
            SendLogon(socket03, dynamicCompId);
            Assert.IsTrue(WaitForLogonStatus(dynamicCompId), "Failed to logon dynamic acceptor session");

            // Ensure that we can't add the same session again
            Assert.IsFalse(_acceptor.AddSession(sessionId, sessionConfig), "Added dynamic session twice");

            // Now that dynamic acceptor is logged on, ensure that unforced attempt to remove session fails
            Assert.IsFalse(_acceptor.RemoveSession(sessionId, false), "Unexpected success removing active session");
            Assert.IsTrue(socket03.Connected, "Unexpected loss of connection");

            // Ensure that forced attempt to remove session dynamic session succeeds, even though it is in logged on state
            Assert.IsTrue(_acceptor.RemoveSession(sessionId, true), "Failed to remove active session");
            Assert.IsTrue(WaitForDisconnect(socket03), "Socket still connected after session removed");
            Assert.IsFalse(IsLoggedOn(dynamicCompId), "Session still logged on after being removed");

            // Ensure that we can perform unforced removal of a dynamic session that is not logged on.
            string dynamicCompId2 = "acc20";
            var sessionId2 = CreateSessionId(dynamicCompId2);
            Assert.IsTrue(_acceptor.AddSession(sessionId2, CreateSessionConfig(false)), "Failed to add dynamic session to acceptor");
            Assert.IsTrue(_acceptor.RemoveSession(sessionId2, false), "Failed to remove inactive session");

            // Ensure that we can remove statically configured session
            Assert.IsTrue(IsLoggedOn(StaticAcceptorCompId), "Unexpected logoff");
            Assert.IsTrue(_acceptor.RemoveSession(CreateSessionId(StaticAcceptorCompId), true), "Failed to remove active session");
            Assert.IsTrue(WaitForDisconnect(socket01), "Socket still connected after session removed");
            Assert.IsFalse(IsLoggedOn(StaticAcceptorCompId), "Session still logged on after being removed");
        }

        [Test]
        public void DynamicInitiator()
        {
            StartListener();
            StartEngine(true);
            if (_initiator is null)
                throw new AssertionException("_initiator is null");

            // Ensure we can log on statically (normally) configured initiator
            Assert.IsTrue(WaitForLogonMessage(StaticInitiatorCompId), "Failed to get logon message for static initiator session");
            SendInitiatorLogon(StaticInitiatorCompId);

            // Add the dynamic initator and ensure that we can log on
            string dynamicCompId = "ini10";
            var sessionId = CreateSessionId(dynamicCompId);
            var sessionConfig = CreateSessionConfig(true);
            Assert.IsTrue(_initiator.AddSession(sessionId, sessionConfig), "Failed to add dynamic session to initiator");
            Assert.IsTrue(WaitForLogonMessage(dynamicCompId), "Failed to get logon message for dynamic initiator session");
            SendInitiatorLogon(dynamicCompId);
            Assert.IsTrue(WaitForLogonStatus(dynamicCompId), "Failed to logon dynamic initiator session");

            // Ensure that we can't add the same session again
            Assert.IsFalse(_initiator.AddSession(sessionId, sessionConfig), "Added dynamic session twice");

            // Now that dynamic initiator is logged on, ensure that unforced attempt to remove session fails
            Assert.IsFalse(_initiator.RemoveSession(sessionId, false), "Unexpected success removing active session");
            Assert.IsTrue(IsLoggedOn(dynamicCompId), "Unexpected logoff");

            // Ensure that forced attempt to remove session dynamic session succeeds, even though it is in logged on state
            Assert.IsTrue(_initiator.RemoveSession(sessionId, true), "Failed to remove active session");
            Assert.IsTrue(WaitForDisconnect(dynamicCompId), "Socket still connected after session removed");
            Assert.IsFalse(IsLoggedOn(dynamicCompId), "Session still logged on after being removed");

            // Ensure that we can perform unforced removal of a dynamic session that is not logged on.
            string dynamicCompId2 = "ini20";
            var sessionId2 = CreateSessionId(dynamicCompId2);
            Assert.IsTrue(_initiator.AddSession(sessionId2, CreateSessionConfig(true)), "Failed to add dynamic session to initiator");
            Assert.IsTrue(WaitForLogonMessage(dynamicCompId2), "Failed to get logon message for dynamic initiator session");
            Assert.IsFalse(IsLoggedOn(dynamicCompId2), "Session logged on");
            Assert.IsTrue(_initiator.RemoveSession(sessionId2, false), "Failed to remove inactive session");
            Assert.IsTrue(WaitForDisconnect(dynamicCompId2), "Socket still connected after session removed");

            // Ensure that we can remove statically configured session
            Assert.IsTrue(IsLoggedOn(StaticInitiatorCompId), "Unexpected loss of connection");
            Assert.IsTrue(_initiator.RemoveSession(CreateSessionId(StaticInitiatorCompId), true), "Failed to remove active session");
            Assert.IsTrue(WaitForDisconnect(StaticInitiatorCompId), "Socket still connected after session removed");
            Assert.IsFalse(IsLoggedOn(StaticInitiatorCompId), "Session still logged on after being removed");

            // Check that log directory default setting has been effective
            Assert.Greater(System.IO.Directory.GetFiles(_logPath, QuickFix.Values.BeginString_FIX42 + "*.log").Length, 0);
        }
    }
}
