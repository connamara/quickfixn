using NUnit.Framework;
using QuickFix;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using QuickFix.Logger;

namespace UnitTests
{
    [TestFixture]
    public class ThreadedSocketReactorTests
    {
        static TcpListener? _tcpListener;

        private int OccupyAPort()
        {
            Random random = new();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int randomPort = random.Next(5000, 6000);
                    _tcpListener = new TcpListener(IPAddress.Loopback, randomPort);
                    _tcpListener.Start();
                    
                    return randomPort;
                }
                catch { }
            }

            throw new Exception("Could not occupy a port in 10 attempts");
        }

        static StringWriter GetStdOut()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            return stringWriter;
        }

        [Test]
        public void TestStartOnBusyPort()
        {
            var port = OccupyAPort();

            var settings = new SocketSettings();
            var testingObject = new ThreadedSocketReactor(
                new IPEndPoint(IPAddress.Loopback, port),
                settings,
                acceptorSocketDescriptor: null,
                new NonSessionLog(new ScreenLogFactory(true, true, true)));

            var stdOut = GetStdOut();
            var ex = Assert.Throws<SocketException>(delegate { testingObject.Run(); })!;

            StringAssert.StartsWith("<event> Error starting listener:", stdOut.ToString());
            StringAssert.StartsWith("Address already in use", ex.Message);
        }

        [TearDown]
        public void TearDown() {
            _tcpListener?.Stop();
        }
    }
}
