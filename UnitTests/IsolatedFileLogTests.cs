using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class IsolatedFileLogTests
    {
        QuickFix.IsolatedFileLog log;

        [SetUp]
        public void setup()
        {

        }

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
            var logDirectory = "log";

            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
            QuickFix.SessionSettings settings = new QuickFix.SessionSettings();

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, logDirectory);

            settings.Set(sessionID, config);

            var isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.Machine | IsolatedStorageScope.Assembly, null, null);
            QuickFix.IsolatedFileLogFactory factory = new QuickFix.IsolatedFileLogFactory(isoStore, settings);
            if (isoStore.DirectoryExists(logDirectory))
            {
                foreach (var isoFile in isoStore.GetFileNames(logDirectory + @"\*"))
                {
                    isoStore.DeleteFile(Path.Combine(logDirectory, isoFile));

                }
                isoStore.DeleteDirectory(logDirectory);
            }

            log = (QuickFix.IsolatedFileLog)factory.Create(sessionID);

            Assert.IsFalse(log.IsOpen);
            log.OnEvent("some event");
            log.OnIncoming("some incoming");
            log.OnOutgoing("some outgoing");
            Assert.IsTrue(log.IsOpen);

            Assert.That(isoStore.FileExists(Path.Combine(logDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.event.current.log")));
            Assert.That(isoStore.FileExists(Path.Combine(logDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.messages.current.log")));
        }

        [Test]
        public void testThrowsIfNoConfig()
        {
            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            QuickFix.SessionSettings settings = new QuickFix.SessionSettings();
            settings.Set(sessionID, config);

            var isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.Machine | IsolatedStorageScope.Assembly, null, null);
            QuickFix.IsolatedFileLogFactory factory = new QuickFix.IsolatedFileLogFactory(isoStore, settings);

            Assert.Throws<QuickFix.ConfigError>(delegate { factory.Create(sessionID); });
        }

        [Test]
        public void testThrowsIfDisposed()
        {
            var logDirectory = "log";

            QuickFix.SessionID sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
            QuickFix.SessionSettings settings = new QuickFix.SessionSettings();

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, logDirectory);

            settings.Set(sessionID, config);

            var isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.Machine | IsolatedStorageScope.Assembly, null, null);
            QuickFix.IsolatedFileLogFactory factory = new QuickFix.IsolatedFileLogFactory(isoStore, settings);
            if (isoStore.DirectoryExists(logDirectory))
            {
                foreach (var isoFile in isoStore.GetFileNames(logDirectory + @"\*"))
                {
                    isoStore.DeleteFile(Path.Combine(logDirectory, isoFile));

                }
                isoStore.DeleteDirectory(logDirectory);
            }

            log = (QuickFix.IsolatedFileLog)factory.Create(sessionID);
            log.Dispose();

            Assert.Throws<ObjectDisposedException>(delegate { log.Clear(); });
            Assert.Throws<ObjectDisposedException>(delegate { log.OnEvent("write to disposed"); });
            Assert.Throws<ObjectDisposedException>(delegate { log.OnIncoming("write to disposed"); });
            Assert.Throws<ObjectDisposedException>(delegate { log.OnOutgoing("write to disposed"); });            
        }
    }
}
