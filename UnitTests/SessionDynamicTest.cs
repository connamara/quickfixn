using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
    class SessionDynamicTest
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
        const string ServerCompID = "dummy";
        const string StaticInitiatorCompID = "ini01";
        const string StaticAcceptorCompID = "acc01";

        const string FIXMessageEnd = @"\x0110=\d{3}\x01";
        const string FIXMessageDelimit = @"(8=FIX|\A).*?(" + FIXMessageEnd + @"|\z)";

        string _logPath;
        SocketInitiator _initiator;
        ThreadedSocketAcceptor _acceptor;
        Dictionary<string, SocketState> _sessions;
        HashSet<string> _loggedOnCompIDs;
        Socket _listenSocket;

        Dictionary CreateSessionConfig(string targetCompID, bool isInitiator)
        {
            Dictionary settings = new Dictionary();
            settings.SetString(SessionSettings.CONNECTION_TYPE, isInitiator ? "initiator" : "acceptor");
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

        void StartEngine(bool initiator)
        {
            TestApplication application = new TestApplication(LogonCallback, LogoffCallback);
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionSettings settings = new SessionSettings();
            Dictionary defaults = new Dictionary();
            defaults.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, _logPath);

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
                settings.Set(CreateSessionID(StaticInitiatorCompID), CreateSessionConfig(StaticInitiatorCompID, true));
                _initiator = new SocketInitiator(application, storeFactory, settings, logFactory);
                _initiator.Start();
            }
            else
            {
                settings.Set(CreateSessionID(StaticAcceptorCompID), CreateSessionConfig(StaticAcceptorCompID, false));
                _acceptor = new ThreadedSocketAcceptor(application, storeFactory, settings, logFactory);
                _acceptor.Start();
            }
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
            int bytesReceived  = 0;
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
            string msgText = SessionFactory.DefaultEncoding.GetString(socketState._rxBuffer, 0, bytesReceived);
            foreach (Match m in Regex.Matches(msgText, FIXMessageDelimit))
            {
                socketState._messageFragment += m.Value;
                if (Regex.IsMatch(socketState._messageFragment, FIXMessageEnd))
                {
                    Message message = new Message(socketState._messageFragment);
                    socketState._messageFragment = string.Empty;
                    string targetCompID = message.Header.GetField(QuickFix.Fields.Tags.TargetCompID);
                    if (message.Header.GetField(QuickFix.Fields.Tags.MsgType) == QuickFix.Fields.MsgType.LOGON)
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
             socketState._socket.BeginReceive(socketState._rxBuffer, 0, socketState._rxBuffer.Length, SocketFlags.None, new AsyncCallback(ProcessRXData), socketState);;
        }

        Socket ConnectToEngine()
        {
            var address = IPAddress.Parse(Host);
            var endpoint = new IPEndPoint(address, AcceptPort);
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
            var msg = new QuickFix.FIX42.Logon();
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(ServerCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(senderCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(1));
            msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            msg.SetField(new QuickFix.Fields.HeartBtInt(300));
            // Simple logon message, use default encoding
            s.Send(SessionFactory.DefaultEncoding.GetBytes(msg.ToString()));
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
            StartEngine(false);

            // Ensure we can log on statically (normally) configured acceptor
            var socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompID);
            Assert.IsTrue(WaitForLogonStatus(StaticAcceptorCompID), "Failed to logon static acceptor session");

            // Ensure that attempt to log on as yet un-added dynamic acceptor fails
            var socket02 = ConnectToEngine();
            string dynamicCompID = "acc10";
            SendLogon(socket02, dynamicCompID);
            Assert.IsTrue(WaitForDisconnect(socket02), "Server failed to disconnect unconfigured CompID");
            Assert.False(HasReceivedMessage(dynamicCompID), "Unexpected message received for unconfigured CompID");

            // Add the dynamic acceptor and ensure that we can now log on
            var sessionID = CreateSessionID(dynamicCompID);
            var sessionConfig = CreateSessionConfig(dynamicCompID, false);
            Assert.IsTrue(_acceptor.AddSession(sessionID, sessionConfig), "Failed to add dynamic session to acceptor");
            var socket03 = ConnectToEngine();
            SendLogon(socket03, dynamicCompID);
            Assert.IsTrue(WaitForLogonStatus(dynamicCompID), "Failed to logon dynamic acceptor session");

            // Ensure that we can't add the same session again
            Assert.IsFalse(_acceptor.AddSession(sessionID, sessionConfig), "Added dynamic session twice");

            // Now that dynamic acceptor is logged on, ensure that unforced attempt to remove session fails
            Assert.IsFalse(_acceptor.RemoveSession(sessionID, false), "Unexpected success removing active session");
            Assert.IsTrue(socket03.Connected, "Unexpected loss of connection");

            // Ensure that forced attempt to remove session dynamic session succeeds, even though it is in logged on state
            Assert.IsTrue(_acceptor.RemoveSession(sessionID, true), "Failed to remove active session");
            Assert.IsTrue(WaitForDisconnect(socket03), "Socket still connected after session removed");
            Assert.IsFalse(IsLoggedOn(dynamicCompID), "Session still logged on after being removed");

            // Ensure that we can perform unforced removal of a dynamic session that is not logged on.
            string dynamicCompID2 = "acc20";
            var sessionID2 = CreateSessionID(dynamicCompID2);
            Assert.IsTrue(_acceptor.AddSession(sessionID2, CreateSessionConfig(dynamicCompID2, false)), "Failed to add dynamic session to acceptor");
            Assert.IsTrue(_acceptor.RemoveSession(sessionID2, false), "Failed to remove inactive session");

            // Ensure that we can remove statically configured session
            Assert.IsTrue(IsLoggedOn(StaticAcceptorCompID), "Unexpected logoff");
            Assert.IsTrue(_acceptor.RemoveSession(CreateSessionID(StaticAcceptorCompID), true), "Failed to remove active session");
            Assert.IsTrue(WaitForDisconnect(socket01), "Socket still connected after session removed");
            Assert.IsFalse(IsLoggedOn(StaticAcceptorCompID), "Session still logged on after being removed");

        }

        [Test]
        public void DynamicInitiator()
        {
            StartListener();
            StartEngine(true);

            // Ensure we can log on statically (normally) configured initiator
            Assert.IsTrue(WaitForLogonMessage(StaticInitiatorCompID),  "Failed to get logon message for static initiator session");
            SendInitiatorLogon(StaticInitiatorCompID);

            // Add the dynamic initator and ensure that we can log on
            string dynamicCompID = "ini10";
            var sessionID = CreateSessionID(dynamicCompID);
            var sessionConfig = CreateSessionConfig(dynamicCompID, true);
            Assert.IsTrue(_initiator.AddSession(sessionID, sessionConfig), "Failed to add dynamic session to initiator");
            Assert.IsTrue(WaitForLogonMessage(dynamicCompID), "Failed to get logon message for dynamic initiator session");
            SendInitiatorLogon(dynamicCompID);
            Assert.IsTrue(WaitForLogonStatus(dynamicCompID), "Failed to logon dynamic initiator session");

            // Ensure that we can't add the same session again
            Assert.IsFalse(_initiator.AddSession(sessionID, sessionConfig), "Added dynamic session twice");

            // Now that dynamic initiator is logged on, ensure that unforced attempt to remove session fails
            Assert.IsFalse(_initiator.RemoveSession(sessionID, false), "Unexpected success removing active session");
            Assert.IsTrue(IsLoggedOn(dynamicCompID), "Unexpected logoff");

            // Ensure that forced attempt to remove session dynamic session succeeds, even though it is in logged on state
            Assert.IsTrue(_initiator.RemoveSession(sessionID, true), "Failed to remove active session");
            Assert.IsTrue(WaitForDisconnect(dynamicCompID), "Socket still connected after session removed");
            Assert.IsFalse(IsLoggedOn(dynamicCompID), "Session still logged on after being removed");

            // Ensure that we can perform unforced removal of a dynamic session that is not logged on.
            string dynamicCompID2 = "ini20";
            var sessionID2 = CreateSessionID(dynamicCompID2);
            Assert.IsTrue(_initiator.AddSession(sessionID2, CreateSessionConfig(dynamicCompID2, true)), "Failed to add dynamic session to initiator");
            Assert.IsTrue(WaitForLogonMessage(dynamicCompID2), "Failed to get logon message for dynamic initiator session");
            Assert.IsFalse(IsLoggedOn(dynamicCompID2), "Session logged on");
            Assert.IsTrue(_initiator.RemoveSession(sessionID2, false), "Failed to remove inactive session");
            Assert.IsTrue(WaitForDisconnect(dynamicCompID2), "Socket still connected after session removed");

            // Ensure that we can remove statically configured session
            Assert.IsTrue(IsLoggedOn(StaticInitiatorCompID), "Unexpected loss of connection");
            Assert.IsTrue(_initiator.RemoveSession(CreateSessionID(StaticInitiatorCompID), true), "Failed to remove active session");
            Assert.IsTrue(WaitForDisconnect(StaticInitiatorCompID), "Socket still connected after session removed");
            Assert.IsFalse(IsLoggedOn(StaticInitiatorCompID), "Session still logged on after being removed");

            // Check that log directory default setting has been effective
            Assert.Greater(System.IO.Directory.GetFiles(_logPath, QuickFix.Values.BeginString_FIX42 + "*.log").Length, 0); 
        }
    }
}
