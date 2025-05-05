using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using QuickFix;
using QuickFix.Logger;
using QuickFix.Store;

namespace UnitTests
{
    [TestFixture]
    public class RestartingTheThreadedSocketAcceptorTests
    {
        private const string Host = "127.0.0.1";
        private const int AcceptPort = 55101;
        private const string StaticAcceptorCompID = "acc01";
        private const string StaticAcceptorCompID2 = "acc02";
        private const string ServerCompID = "dummy";
        private ThreadedSocketAcceptor? _acceptor;
        private const string FIXMessageEnd = @"\x0110=\d{3}\x01";
        private const string FIXMessageDelimit = @"(8=FIX|\A).*?(" + FIXMessageEnd + @"|\z)";
        private Dictionary<string, SocketState> _sessions = new Dictionary<string, SocketState>();
        private HashSet<string> _loggedOnCompIDs = new HashSet<string>();
        private ulong _senderSequenceNumber = 1;

        public class TestApplication : IApplication
        {
            private Action<string> _logonNotify;
            private Action<string> _logoffNotify;

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

        private void LogonCallback(string compID)
        {
            lock (_loggedOnCompIDs)
            {
                _loggedOnCompIDs.Add(compID);
                Monitor.Pulse(_loggedOnCompIDs);
            }
        }
        private void LogoffCallback(string compID)
        {
            lock (_loggedOnCompIDs)
            {
                _loggedOnCompIDs.Remove(compID);
                Monitor.Pulse(_loggedOnCompIDs);
            }
        }

        private class SocketState
        {
            public SocketState(Socket s)
            {
                _socket = s;
            }
            public Socket _socket;
            public byte[] _rxBuffer = new byte[1024];
            public string _messageFragment = string.Empty;
            public string _exMessage = string.Empty;
        }


        const int ConnectPort = 55100;
        private SettingsDictionary CreateSessionConfig()
        {
            SettingsDictionary settings = new SettingsDictionary();
            settings.SetString(SessionSettings.CONNECTION_TYPE, "acceptor");
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.START_TIME, "12:00:00");
            settings.SetString(SessionSettings.END_TIME, "12:00:00");
            settings.SetString(SessionSettings.HEARTBTINT, "300");
            settings.SetString(SessionSettings.SOCKET_CONNECT_HOST, Host);
            settings.SetString(SessionSettings.SOCKET_CONNECT_PORT, ConnectPort.ToString());
            settings.SetString(SessionSettings.SOCKET_ACCEPT_HOST, Host);
            settings.SetString(SessionSettings.SOCKET_ACCEPT_PORT, AcceptPort.ToString());
            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                            ?? throw new InvalidOperationException("Could not determine the directory of the executing assembly.");
            var logPath = Path.Combine(directory, "log");
            settings.SetString(SessionSettings.FILE_LOG_PATH, logPath);
            return settings;
        }

        private SessionID CreateSessionID(string targetCompID)
        {
            return new SessionID(QuickFix.Values.BeginString_FIX42, ServerCompID, targetCompID);
        }

        private void CreateAcceptorFromSessionConfig()
        {
            TestApplication application = new TestApplication(LogonCallback, LogoffCallback);
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            ILogFactory logFactory = new ScreenLogFactory(false, false, false);
            SessionSettings settings = new SessionSettings();

            settings.Set(CreateSessionID(StaticAcceptorCompID), CreateSessionConfig());
            settings.Set(CreateSessionID(StaticAcceptorCompID2), CreateSessionConfig());
            _acceptor = new ThreadedSocketAcceptor(application, storeFactory, settings, logFactory);
        }

        private Socket ConnectToEngine()
        {
            return ConnectToEngine( false );
        }

        private Socket ConnectToEngine( bool expectFailure )
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
                if (expectFailure) throw;
                Assert.Fail(string.Format("Failed to connect: {0}", ex.Message));
            }
            return socket;
        }

        private void ReceiveAsync(SocketState socketState)
        {
            try
            {
                if (socketState._socket == null || !socketState._socket.Connected)
                    return; // Socket already closed, don't attempt receive

                socketState._socket.BeginReceive(
                    socketState._rxBuffer, 0, socketState._rxBuffer.Length,
                    SocketFlags.None, new AsyncCallback(ProcessRxData), socketState);
            }
            catch (SocketException e)
            {
                if (e.SocketErrorCode != SocketError.Shutdown)
                {
                    throw;
                }
            }
            catch (ObjectDisposedException)
            {
                // Socket was disposed between check and operation: ignore safely
            }
        }

        private void CloseAndNotify(Socket s)
        {
            lock (s)
            {
                if (s.Connected)
                {
                    try { s.Shutdown(SocketShutdown.Both); } catch {}
                }
                s.Close();
                SafePulse(s);
            }
        }
        
        private void SafePulse(object socket)
        {
            try
            {
                lock (socket)
                {
                    Monitor.Pulse(socket);
                }
            }
            catch (ObjectDisposedException)
            {
                // Ignore, socket already disposed
            }
            catch (SynchronizationLockException)
            {
                // Ignore, socket already finalized and GC'ed
            }
        }
        
        private void ProcessRxData(IAsyncResult ar)
        {
            SocketState socketState = (SocketState)ar.AsyncState!;
            int bytesReceived = 0;
            try
            {
                bytesReceived = socketState._socket.EndReceive(ar);
            }
            catch (ObjectDisposedException)
            {
                CloseAndNotify(socketState._socket);
                return;
            }
            catch (Exception ex)
            {
                socketState._exMessage = ex.InnerException == null ? ex.Message : ex.InnerException.Message;
                CloseAndNotify(socketState._socket);
                return;
            }

            if (bytesReceived == 0)
            {
                CloseAndNotify(socketState._socket);
                return;
            }
            string msgText = Encoding.ASCII.GetString(socketState._rxBuffer, 0, bytesReceived);
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
                            SafePulse(_sessions);
                        }
                    if (message.Header.GetString(QuickFix.Fields.Tags.MsgType) == QuickFix.Fields.MsgType.LOGOUT)
                        lock (_sessions)
                        {
                            SendLogout(socketState._socket, targetCompID );
                            _sessions.Remove( targetCompID );
                            SafePulse(_sessions);
                        }
                }
            }
            if (socketState._socket.Connected)
            {
                ReceiveAsync(socketState);
            }
        }

        private void SendLogon(Socket s, string senderCompID)
        {
            var msg = new QuickFix.FIX42.Logon();
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(ServerCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(senderCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(_senderSequenceNumber++));
            msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            msg.SetField(new QuickFix.Fields.HeartBtInt(300));
            s.Send(Encoding.ASCII.GetBytes(msg.ConstructString()));
        }

        private void SendLogout(Socket s, string senderCompID)
        {
            var msg = new QuickFix.FIX42.Logout();
            msg.Header.SetField(new QuickFix.Fields.TargetCompID(ServerCompID));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID(senderCompID));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(_senderSequenceNumber++));
            msg.Header.SetField(new QuickFix.Fields.SendingTime(System.DateTime.UtcNow));
            s.Send(Encoding.ASCII.GetBytes(msg.ConstructString()));
        }

        private bool WaitForSessionStatus(string acceptorCompId)
        {
            lock (_sessions)
            {
                if (!_sessions.ContainsKey(acceptorCompId))
                    Monitor.Wait(_sessions, 10000);
                return _sessions.ContainsKey(acceptorCompId);
            }
        }

        private bool WaitForLogonStatus(string targetCompID, int waitTime = 10000 )
        {
            lock (_loggedOnCompIDs)
            {
                if (!_loggedOnCompIDs.Contains(targetCompID))
                    Monitor.Wait(_loggedOnCompIDs, waitTime);
                return _loggedOnCompIDs.Contains(targetCompID);
            }
        }

        private bool WaitForDisconnect(Socket s)
        {
            lock (s)
            {
                var timeoutMilliseconds = 10000; // total 10 seconds
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();

                while (IsSocketConnected(s))
                {
                    var remainingTimeout = timeoutMilliseconds - (int)stopwatch.ElapsedMilliseconds;
                    if (remainingTimeout <= 0)
                        break;

                    Monitor.Wait(s, Math.Min(remainingTimeout, 500)); // Wait at most 500ms or remaining
                }

                return !IsSocketConnected(s);
            }
        }
        
        private bool IsSocketConnected(Socket socket)
        {
            try
            {
                if (socket == null || !socket.Connected)
                    return false;

                bool connectionClosed = socket.Poll(0, SelectMode.SelectRead);
                bool dataAvailable = (socket.Available == 0);
                return !(connectionClosed && dataAvailable);
            }
            catch (SocketException)
            {
                return false;
            }
            catch (ObjectDisposedException)
            {
                return false;
            }
        }

        [SetUp]
        public void Setup()
        {
            CreateAcceptorFromSessionConfig();
            _sessions = new Dictionary<string, SocketState>();
            _loggedOnCompIDs = new HashSet<string>();
            _senderSequenceNumber = 1;
        }

        [TearDown]
        public void TearDown()
        {
            _acceptor!.Stop( true );
            _acceptor.Dispose();
        }


        [Test]
        public void TestAcceptorInStoppedStateOnInitialisation()
        {
            //GIVEN - an acceptor created in SetUp
            //THEN - is should be stopped
            Assert.That(_acceptor!.IsStarted, Is.False);
            Assert.That(_acceptor.AreSocketsRunning, Is.False);
            Assert.That(_acceptor.IsLoggedOn, Is.False);
        }

        [Test]
        public void TestAcceptorInStoppedStateOnInitialisationThenCannotReceiveConnections()
        {
            //GIVEN - an acceptor created in SetUp
            // a connection is received
            bool exceptionFound = false;
            try
            {
                var socket01 = ConnectToEngine(true);
            }
            //THEN - Expect failure to connect
            catch (SocketException)
            {
                //SUCCESS
                exceptionFound = true;
            }
            Assert.That(exceptionFound, Is.True);
        }

        [Test]
        public void TestCanStartAcceptor()
        {
            //GIVEN - an acceptor created in SetUp
            //WHEN - it is started
            _acceptor!.Start();
            //THEN - is be running
            Assert.That(_acceptor.IsStarted, Is.True);
            Assert.That(_acceptor.AreSocketsRunning, Is.True);
            Assert.That(_acceptor.IsLoggedOn, Is.False);
        }

        [Test]
        public void TestStartedAcceptorAndReceiveConnection()
        {
            //GIVEN - a started acceptor created in SetUp
            _acceptor!.Start();
            //WHEN - a connection is received
            var socket01 = ConnectToEngine();
            SendLogon( socket01, StaticAcceptorCompID );
            //THEN - is be running
            Assert.That(WaitForLogonStatus(StaticAcceptorCompID), Is.True);
            Assert.That(_acceptor.IsLoggedOn, Is.True);

            //CLEANUP - disconnect client connections
            DisconnectSocket(socket01);
        }

        [Test]
        public void TestStartedAcceptorAndReceiveMultipleConnections()
        {
            //GIVEN - a started acceptor created in SetUp
            _acceptor!.Start();
            //WHEN - a connection is received
            var socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompID);
            var socket02 = ConnectToEngine();
            SendLogon(socket02, StaticAcceptorCompID2);
            //THEN - is be running
            Assert.That(WaitForLogonStatus(StaticAcceptorCompID), Is.True);
            Assert.That(WaitForLogonStatus(StaticAcceptorCompID2), Is.True);
            Assert.That(_acceptor.IsLoggedOn, Is.True);


            //CLEANUP - disconnect client connections
            DisconnectSocket(socket02);
            DisconnectSocket(socket01);
        }

        private void DisconnectSocket(Socket socket)
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Dispose();
        }

        [Test]
        public void TestCanStopAcceptor()
        {
            //GIVEN - started acceptor created in SetUp
            _acceptor!.Start();
            //WHEN - it is stopped
            _acceptor.Stop();
            //THEN - it should no longer be running
            Assert.That(_acceptor.IsStarted, Is.False);
            Assert.That(_acceptor.AreSocketsRunning, Is.False);
            Assert.That(_acceptor.IsLoggedOn, Is.False);
        }

        [Test]
        public void TestCanForceStopAcceptorAndLogOffCounterpartyIfLoggedOn()
        {
            //GIVEN - started acceptor with a logged on session created in SetUp
            _acceptor!.Start();
            var socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompID);
            //WHEN - it is stopped with forced disconnection
            _acceptor.Stop(true);
            //THEN - it should no longer be running
            Assert.That(WaitForDisconnect(socket01), Is.True);
            Assert.That(_acceptor.AreSocketsRunning, Is.False);
        }

        [Test]
        public void TestCanStopAcceptorAndLogOffCounterpartyIfLoggedOn()
        {
            //GIVEN - started acceptor with a logged on session created in SetUp
            _acceptor!.Start();
            var socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompID);
            Assert.That(WaitForLogonStatus(StaticAcceptorCompID), Is.True);
            //WHEN - it is stopped
            _acceptor.Stop();
            //THEN - it should no longer be running
            Assert.That(WaitForDisconnect(socket01), Is.True);
            Assert.That(_loggedOnCompIDs.Contains(StaticAcceptorCompID), Is.False);
            Assert.That(_sessions.ContainsKey(StaticAcceptorCompID), Is.False);
            Assert.That(_acceptor.AreSocketsRunning, Is.False);
            Assert.That(_acceptor.IsLoggedOn, Is.False);
        }

        [Test]
        public void TestCanRestartAcceptorAfterStopping()
        {
            //GIVEN - a started then stopped acceptor created in SetUp
            _acceptor!.Start();
            _acceptor.Stop();
            //WHEN - it is started again
            _acceptor.Start();
            //THEN - it should be marked as running
            Assert.That(_acceptor.IsStarted, Is.True);
            Assert.That(_acceptor.AreSocketsRunning, Is.True);
            Assert.That(_acceptor.IsLoggedOn, Is.False);
        }

        [Test]
        public void TestCanRestartAcceptorAfterStoppingAndCounterPartyCanThenLogon()
        {
            //GIVEN - a started then stopped acceptor created in SetUp
            _acceptor!.Start();
            _acceptor.Stop();
            //WHEN - it is started again
            _acceptor.Start();
            //THEN - a counterparty should be able to logon
            Assert.That(_acceptor.IsStarted, Is.True);
            Assert.That(_acceptor.AreSocketsRunning, Is.True);
            var socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompID);
            Assert.That(WaitForLogonStatus(StaticAcceptorCompID), Is.True);
            Assert.That(_acceptor.IsLoggedOn, Is.True);
            Assert.That(WaitForSessionStatus(StaticAcceptorCompID), Is.True);
        }

        [Test]
        public void TestCanRestartAcceptorAndCounterPartyCanLogonAfterCounterParttyLoggedOnThenAcceptorStopped()
        {
            //GIVEN - a started then stopped acceptor created in SetUp
            _acceptor!.Start();
            var socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompID);
            Assert.That(WaitForLogonStatus(StaticAcceptorCompID), Is.True);
            _acceptor.Stop();
            //WHEN - it is started again
            _acceptor.Start();
            //THEN - a counterparty should be able to logon
            Assert.That(_acceptor.IsStarted, Is.True);
            Assert.That(_acceptor.AreSocketsRunning, Is.True);
            socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompID);
            Assert.That(WaitForLogonStatus(StaticAcceptorCompID), Is.True);
            Assert.That(_acceptor.IsLoggedOn, Is.True);
            Assert.That(WaitForSessionStatus(StaticAcceptorCompID), Is.True);
        }


        [Test]
        public void TestCanRestartAcceptorAndCounterPartyCanLogonAfterCounterParttyLoggedOnThenAcceptorForceStopped()
        {
            //GIVEN - a started then stopped acceptor created in SetUp
            _acceptor!.Start();
            var socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompID);
            Assert.That(WaitForLogonStatus(StaticAcceptorCompID), Is.True);
            _acceptor.Stop(true);
            //WHEN - it is started again
            _acceptor.Start();
            //THEN - a counterparty should be able to logon
            Assert.That(_acceptor.IsStarted, Is.True);
            Assert.That(_acceptor.AreSocketsRunning, Is.True);
            socket01 = ConnectToEngine();
            SendLogon(socket01, StaticAcceptorCompID);
            Assert.That(WaitForLogonStatus(StaticAcceptorCompID, 60000), Is.True);
            Assert.That(_acceptor.IsLoggedOn, Is.True);

            //CLEANUP - disconnect client connections
            DisconnectSocket(socket01);
        }
    }
}
