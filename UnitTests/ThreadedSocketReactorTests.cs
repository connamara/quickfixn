using NUnit.Framework;
using QuickFix;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace UnitTests
{
    [TestFixture]
    public class ThreadedSocketReactorTests
    {
        static readonly Random _random = new Random();
        static TcpListener _tcpListener;

        private int OccupyAPort()
        {
            int randomPort;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    randomPort = _random.Next(5000, 6000);
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
            var testingObject = new ThreadedSocketReactor(new IPEndPoint(IPAddress.Loopback, port), settings, sessionDict: null);

            var stdOut = GetStdOut();

            Exception exceptionResult = null;
            string stdOutResult = null;

            try
            {
                testingObject.Run();
            }
            catch (Exception ex)
            {
                exceptionResult = ex;
                stdOutResult = stdOut.ToString();
            }

            Assert.IsNotNull(exceptionResult);
            Assert.IsNotNull(stdOutResult);

            Assert.AreEqual(typeof(SocketException), exceptionResult.GetType());
            Assert.IsTrue(stdOutResult.StartsWith("Error starting listener: "));
        }

        [TearDown]
        public void TearDown()
        {
            if (_tcpListener != null)
                _tcpListener.Stop();
        }
    }
}
