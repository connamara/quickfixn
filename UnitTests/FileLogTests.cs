using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class FileLogTests
    {
        QuickFix.FileLog log;

        [SetUp]
        public void setup()
        { }

        [TearDown]
        public void teardown()
        {
            if (log != null)
                log.Dispose();
        }

        [Test]
        public void testPrefix()
        {
            QuickFix.SessionID someSessionID = new QuickFix.SessionID("FIX.4.4", "sender", "target");
            QuickFix.SessionID someSessionIDWithQualifier = new QuickFix.SessionID("FIX.4.3", "sender", "target", "foo");

            Assert.AreEqual("FIX.4.4-sender-target", QuickFix.FileLog.Prefix(someSessionID));
            Assert.AreEqual("FIX.4.3-sender-target-foo", QuickFix.FileLog.Prefix(someSessionIDWithQualifier));
        }

        [Test]
        public void testPrefixForSubsAndLocation()
        {
            QuickFix.SessionID sessionIDWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "SENDERLOC", "TARGETCOMP", "TARGETSUB", "TARGETLOC");
            Assert.That(QuickFix.FileLog.Prefix(sessionIDWithSubsAndLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB_SENDERLOC-TARGETCOMP_TARGETSUB_TARGETLOC"));

            QuickFix.SessionID sessionIDWithSubsNoLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "TARGETCOMP", "TARGETSUB");
            Assert.That(QuickFix.FileLog.Prefix(sessionIDWithSubsNoLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB-TARGETCOMP_TARGETSUB"));
        }

        [Test]
        public void testGeneratedFileName()
        {
            if (System.IO.Directory.Exists("log"))
                System.IO.Directory.Delete("log", true);

            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
            QuickFix.SessionSettings settings = new QuickFix.SessionSettings();

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, "log");

            settings.Set(sessionID, config);

            QuickFix.FileLogFactory factory = new QuickFix.FileLogFactory(settings);
            log = (QuickFix.FileLog)factory.Create(sessionID);

            log.OnEvent("some event");
            log.OnIncoming("some incoming");
            log.OnOutgoing("some outgoing");

            Assert.That(System.IO.File.Exists("log/FIX.4.2-SENDERCOMP-TARGETCOMP.event.current.log"));
            Assert.That(System.IO.File.Exists("log/FIX.4.2-SENDERCOMP-TARGETCOMP.messages.current.log"));
        }

        [Test]
        public void testThrowsIfNoConfig()
        {
            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            QuickFix.SessionSettings settings = new QuickFix.SessionSettings();
            settings.Set(sessionID, config);

            QuickFix.FileLogFactory factory = new QuickFix.FileLogFactory(settings);

            Assert.Throws<QuickFix.ConfigError>(delegate { factory.Create(sessionID); });
        }
    }
}
