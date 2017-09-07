using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using QuickFix;
using Xunit;

namespace UnitTests
{
    public class ThreadedSocketAcceptorTests
    {
        private const string Config = @"
[DEFAULT]
StartTime = 00:00:00
EndTime = 23:59:59
ConnectionType = acceptor
SocketAcceptHost = 127.0.0.1
SocketAcceptPort = 10000
FileStorePath = store
FileLogPath = log
UseDataDictionary = N

[SESSION]
SenderCompID = sender
TargetCompID = target
BeginString = FIX.4.4
";

        private static SessionSettings CreateSettings()
        {
            return new SessionSettings(new StringReader(Config));
        }

        private static ThreadedSocketAcceptor CreateAcceptor()
        {
            var settings = CreateSettings();
            return new ThreadedSocketAcceptor(
                new NullApplication(),
                new FileStoreFactory(settings),
                settings,
                new FileLogFactory(settings));
        }

        [Fact]
        public void TestRecreation()
        {
            StartStopAcceptor();
            StartStopAcceptor();
            StartStopAcceptor();
        }

        private static void StartStopAcceptor()
        {
            var acceptor = CreateAcceptor();
            acceptor.Start();
            acceptor.Dispose();
        }
    }
}
