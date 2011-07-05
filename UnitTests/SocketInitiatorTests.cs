using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFix.Transport;
using QuickFix;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using QuickFix.Applications;

namespace UnitTests
{
    [TestFixture]
    public class SocketInitiatorTests
    {
        [TearDown]
        public void Dispose()
        {
            if (initiator_ != null)
                initiator_.Stop();
        }

        [Test]
        public void TestConnectAndReceive()
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(localAddr, 56123);
            listener.Start();
            listener.BeginAcceptSocket(new AsyncCallback(Connected), listener);
            
            string conf = new StringBuilder()
                .AppendLine("[DEFAULT]")
                .AppendLine("ConnectionType=initiator")
                .AppendLine("ReconnectInterval=1")
                .AppendLine("HeartBtInt=60")
                .AppendLine("SocketConnectHost=127.0.0.1")
                .AppendLine("SocketConnectPort=56123")
                .AppendLine("UseDataDictionary=N")
                .AppendLine("[SESSION]")
                .AppendLine("BeginString=FIX.4.2")
                .AppendLine("SenderCompID=TW")
                .AppendLine("TargetCompID=ISLD")
                .ToString();
            settings_ = new SessionSettings(new System.IO.StringReader(conf));
         
            _fixApp = new FIX4Application();
            initiator_ = new SocketInitiator(_fixApp, new MemoryStoreFactory(), settings_);
            initiator_.RawDataReceived += new SocketInitiator.RawDataReceivedHandler(i_RawDataReceived);
            initiator_.Start();

            Thread.Sleep(250);  
            // Server sends initiator a message.

            Assert.NotNull(_clientSocket);
            //XXX_clientSocket.Send(Encoding.UTF8.GetBytes(expectedData + "\n"));
            Thread.Sleep(500);

            // initiator sends Logon to mock acceptor
            byte[] r = new byte[512];
            _clientSocket.Receive(r);
            string received = Encoding.UTF8.GetString(r);
            Thread.Sleep(500);
            const string expectedDataRegex = "8=FIX.4.2\x01" + "9=57\x01" + "35=A\x01" + "34=1\x01" + "49=TW\x01" + "52=.+\x01" + "56=ISLD\x01" + ".+\x01";
            StringAssert.IsMatch(expectedDataRegex, received);

            // mock acceptor sends Logon reply to initiator
            const string logonReplyData = "8=FIX.4.2\x01" + "9=57\x01" + "35=A\x01" + "34=1\x01" + "49=ISLD\x01" +
                "52=20000426-12:05:06\x01" + "56=TW\x01" + "98=0\x01" + "10=000\x01";
            _clientSocket.Send(Encoding.UTF8.GetBytes(logonReplyData + "\n"));
            const string logonReplyDataRegex = "8=FIX.4.2\x01" + "9=57\x01" + "35=A\x01" + "34=1\x01" + "49=ISLD\x01" + "52=.+\x01" + "56=TW\x01" + ".+\x01";
            StringAssert.IsMatch(logonReplyDataRegex, _lastReceived);
            
            _clientSocket.Shutdown(SocketShutdown.Both);
            _clientSocket.Close();
            listener.Stop();
        }

        void i_RawDataReceived(object sender, string rawData)
        {
            _lastReceived = rawData;
        }

        private void Connected(IAsyncResult ar)
        {
            TcpListener listener = (TcpListener)ar.AsyncState;
            _clientSocket = listener.EndAcceptSocket(ar);
        }

        private string _lastReceived;
        private Application _fixApp;
        private SessionSettings settings_;
        private Socket _clientSocket;
        private SocketInitiator initiator_;
    }
}
