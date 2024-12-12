using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using QuickFix;
using QuickFix.Logger;
using QuickFix.Store;

namespace UnitTests
{
    [TestFixture]
    public class ThreadedSocketAcceptorTests
    {
        private static string Config = $@"
[DEFAULT]
StartTime = 00:00:00
EndTime = 23:59:59
ConnectionType = acceptor
SocketAcceptHost = 127.0.0.1
SocketAcceptPort = 10000
FileStorePath = {TestContext.CurrentContext.TestDirectory}\store
FileLogPath = {TestContext.CurrentContext.TestDirectory}\log
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

        [Test]
        public void TestRecreation()
        {
            StartStopAcceptor();
            StartStopAcceptor();
            StartStopAcceptor();
        }

        private static void StartStopAcceptor()
        {
            var settings = CreateSettings();
            using var lf = new LoggerFactory([new FileLoggerProvider(settings)]);

            var acceptor = new ThreadedSocketAcceptor(
                new NullApplication(),
                new FileStoreFactory(settings),
                settings,
                lf);
            acceptor.Start();
            acceptor.Dispose();
        }
    }
}
