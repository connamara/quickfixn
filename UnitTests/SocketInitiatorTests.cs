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
        public void TestBasicSockets()
        {
            TcpClient client = new TcpClient();
            TcpListener server = new TcpListener(IPAddress.Loopback, 56123);
            server.Start();
            client.Connect(IPAddress.Loopback, 56123);
            Socket s = server.AcceptSocket();
        }

        private void Connected(IAsyncResult ar)
        {
            TcpListener listener = (TcpListener)ar.AsyncState;
            _clientSocket = listener.EndAcceptSocket(ar); 
        }

        [Test]
        public void TestConnect()
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
            i.Start();

            // Create a socket listener and expect connection.
            Assert.That(_clientSocket.Connected, Is.True);
            Assert.That(i.Connected, Is.True);

            try
            {
                _clientSocket.Disconnect(true);
                i.Close();
                listener.Stop();
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private Application _fixApp;
        private Settings _settings;
        private Socket _clientSocket;
    }
}
