using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class FileLogTests
    {
        QuickFix.FileLog log;

        [SetUp]
        public void setup()
        { }

        [TearDown]
        public void teardown()
        {
            if (log != null)
            {
                log.Dispose();
                log = null;
            }
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
        public void testPrefixWildcards()
        {
            QuickFix.SessionID someSessionID = new QuickFix.SessionID("FIX.4.4", QuickFix.Values.WILDCARD_VALUE, "target");
            QuickFix.SessionID someSessionIDWithQualifier = new QuickFix.SessionID(QuickFix.Values.WILDCARD_VALUE, "sender", QuickFix.Values.WILDCARD_VALUE, "foo");

            Assert.AreEqual($"{QuickFix.FileLog.WILDCARD_FILE_PREFIX}FIX.4.4-{QuickFix.FileLog.WILDCARD_REPLACEMENT}-target", QuickFix.FileLog.Prefix(someSessionID));
            Assert.AreEqual($"{QuickFix.FileLog.WILDCARD_FILE_PREFIX}{QuickFix.FileLog.WILDCARD_REPLACEMENT}-sender-{QuickFix.FileLog.WILDCARD_REPLACEMENT}-foo", QuickFix.FileLog.Prefix(someSessionIDWithQualifier));
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
        public void testPrefixForSubsAndLocationWildcards()
        {
            QuickFix.SessionID sessionIDWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", QuickFix.Values.WILDCARD_VALUE,
                "TARGETCOMP", "TARGETSUB", QuickFix.Values.WILDCARD_VALUE);
            Assert.That(QuickFix.FileLog.Prefix(sessionIDWithSubsAndLocation), Is.EqualTo($"{QuickFix.FileLog.WILDCARD_FILE_PREFIX}FIX.4.2-SENDERCOMP_SENDERSUB_{QuickFix.FileLog.WILDCARD_REPLACEMENT}-TARGETCOMP_TARGETSUB_{QuickFix.FileLog.WILDCARD_REPLACEMENT}"));

            QuickFix.SessionID sessionIDWithSubsNoLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", QuickFix.Values.WILDCARD_VALUE, "TARGETCOMP", QuickFix.Values.WILDCARD_VALUE);
            Assert.That(QuickFix.FileLog.Prefix(sessionIDWithSubsNoLocation), Is.EqualTo($"{QuickFix.FileLog.WILDCARD_FILE_PREFIX}FIX.4.2-SENDERCOMP_{QuickFix.FileLog.WILDCARD_REPLACEMENT}-TARGETCOMP_{QuickFix.FileLog.WILDCARD_REPLACEMENT}"));
        }

        [Test]
        public void testGeneratedFileName()
        {
            var logDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "log");

            if (System.IO.Directory.Exists(logDirectory))
                System.IO.Directory.Delete(logDirectory, true);

            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
            QuickFix.SessionSettings settings = new QuickFix.SessionSettings();

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, logDirectory);

            settings.Set(sessionID, config);

            QuickFix.FileLogFactory factory = new QuickFix.FileLogFactory(settings);
            log = (QuickFix.FileLog)factory.Create(sessionID);

            log.OnEvent("some event");
            log.OnIncoming("some incoming");
            log.OnOutgoing("some outgoing");

            Assert.That(System.IO.File.Exists(Path.Combine(logDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.event.current.log")));
            Assert.That(System.IO.File.Exists(Path.Combine(logDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.messages.current.log")));
        }

        [Test]
        public void testGeneratedFileNameWildcards()
        {
            var logDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "log");

            if (System.IO.Directory.Exists(logDirectory))
                System.IO.Directory.Delete(logDirectory, true);

            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", QuickFix.Values.WILDCARD_VALUE, QuickFix.Values.WILDCARD_VALUE);
            QuickFix.SessionSettings settings = new QuickFix.SessionSettings();

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "acceptor");
            config.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, logDirectory);

            settings.Set(sessionID, config);

            QuickFix.FileLogFactory factory = new QuickFix.FileLogFactory(settings);
            log = (QuickFix.FileLog)factory.Create(sessionID);

            log.OnEvent("some event");
            log.OnIncoming("some incoming");
            log.OnOutgoing("some outgoing");

            Assert.That(System.IO.File.Exists(Path.Combine(logDirectory, $"{QuickFix.FileLog.WILDCARD_FILE_PREFIX}FIX.4.2-{QuickFix.FileLog.WILDCARD_REPLACEMENT}-{QuickFix.FileLog.WILDCARD_REPLACEMENT}.event.current.log")));
            Assert.That(System.IO.File.Exists(Path.Combine(logDirectory, $"{QuickFix.FileLog.WILDCARD_FILE_PREFIX}FIX.4.2-{QuickFix.FileLog.WILDCARD_REPLACEMENT}-{QuickFix.FileLog.WILDCARD_REPLACEMENT}.messages.current.log")));
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
