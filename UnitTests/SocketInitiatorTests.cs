using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFIX.NET.Transport;
using QuickFIX.NET;
using QuickFIX.NET.Config;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace UnitTests
{
    [TestFixture]
    public class SocketInitiatorTests
    {
        [Test]
        public void TestConnectAndReceive()
        {
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(localAddr, 56123);
            listener.Start();
            listener.BeginAcceptSocket(new AsyncCallback(Connected), listener);

            _fixApp = new Application();
            _settings = new Settings();
            _settings.SocketConnectHost = "127.0.0.1";
            _settings.SocketConnectPort = 56123;
            SocketInitiator i = new SocketInitiator(_fixApp, _settings);
            i.RawDataReceived += new SocketInitiator.RawDataReceivedHandler(i_RawDataReceived);
            i.Start();

            Thread.Sleep(100);
            // Server sends initiator a message.
            _clientSocket.Send(Encoding.UTF8.GetBytes("TESTING123\n"));
            Thread.Sleep(100);

            // Assert that the initiator is connected and receives it.
            Assert.That(_clientSocket.Connected, Is.True);
            Assert.That(i.Connected, Is.True);
            Assert.That(_lastReceived, Is.EqualTo("TESTING123"));
            
            // Send message from initiator to server.
            string testSend = "TESTING456";
            i.Send(testSend);

            byte[] r = new byte[256];
            _clientSocket.Receive(r);
            string received = Encoding.UTF8.GetString(r);
            Thread.Sleep(100);

            // Assert that dummy server receives our test message.
            // Note the substring, our dummy TcpListener is only receiving raw socket blocks of 256 bytes,
            // so we only assert that what we sent is contained in the first part of the 256 byte block.
            Assert.That(received.Substring(0, testSend.Length), Is.EqualTo(testSend));

            _clientSocket.Shutdown(SocketShutdown.Both);
            i.Close();
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
        private Settings _settings;
        private Socket _clientSocket;
    }
}
