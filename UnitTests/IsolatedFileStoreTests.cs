using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading;
using System.IO.IsolatedStorage;
using System.IO;

namespace UnitTests
{
    [TestFixture]
    public class IsolatedFileStoreTests
    {
        QuickFix.IsolatedFileStore store;
        QuickFix.IsolatedFileStoreFactory factory;

        QuickFix.SessionSettings settings;
        QuickFix.SessionID sessionID;

        IsolatedStorageFile isoStore;

        private string storeDirectory;

        [SetUp]
        public void setup()
        {
            storeDirectory = "store";

            if (System.IO.Directory.Exists(storeDirectory))
                System.IO.Directory.Delete(storeDirectory, true);

            sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.FILE_STORE_PATH, storeDirectory);

            settings = new QuickFix.SessionSettings();
            settings.Set(sessionID, config);

            isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.Machine | IsolatedStorageScope.Assembly, null, null);
            factory = new QuickFix.IsolatedFileStoreFactory(isoStore, settings);

            store = (QuickFix.IsolatedFileStore)factory.Create(sessionID);
        }

        void rebuildStore()
        {
            if(store != null)
            {
                store.Dispose();
            }

            store = (QuickFix.IsolatedFileStore)factory.Create(sessionID);
        }


        [TearDown]
        public void teardown()
        {
            store.Dispose();
            if (isoStore.DirectoryExists(storeDirectory))
            {
                foreach (var isoFile in isoStore.GetFileNames(storeDirectory + @"\*"))
                {
                    isoStore.DeleteFile(Path.Combine(storeDirectory, isoFile));
                }
                isoStore.DeleteDirectory(storeDirectory);
            }
            isoStore.Dispose();
            isoStore = null;
        }

        [Test]
        public void testPrefixForSessionWithSubsAndLoc()
        {
            QuickFix.SessionID sessionIDWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "SENDERLOC", "TARGETCOMP", "TARGETSUB", "TARGETLOC");
            Assert.That(QuickFix.IsolatedFileStore.Prefix(sessionIDWithSubsAndLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB_SENDERLOC-TARGETCOMP_TARGETSUB_TARGETLOC"));

            QuickFix.SessionID sessionIDWithSubsNoLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "TARGETCOMP", "TARGETSUB");
            Assert.That(QuickFix.IsolatedFileStore.Prefix(sessionIDWithSubsNoLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB-TARGETCOMP_TARGETSUB"));
        }

        [Test]
        public void generateFileNamesTest()
        {
            Assert.IsFalse(store.IsOpen);
            store.Open();
            Assert.IsTrue(store.IsOpen);
            Assert.That(isoStore.FileExists(Path.Combine(storeDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.seqnums")));
            Assert.That(isoStore.FileExists(Path.Combine(storeDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.body")));
            Assert.That(isoStore.FileExists(Path.Combine(storeDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.header")));
            Assert.That(isoStore.FileExists(Path.Combine(storeDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.session")));
        }

        [Test]
        public void getNextSenderMsgSeqNumTest()
        {
            Assert.IsFalse(store.IsOpen);
            store.Open();
            Assert.IsTrue(store.IsOpen);
            Assert.AreEqual(1, store.GetNextSenderMsgSeqNum());
            store.SetNextSenderMsgSeqNum(5);
            Assert.AreEqual(5, store.GetNextSenderMsgSeqNum());
            rebuildStore();
            Assert.IsFalse(store.IsOpen);
            Assert.AreEqual(5, store.GetNextSenderMsgSeqNum());
            Assert.IsTrue(store.IsOpen);
        }

        [Test]
        public void incNextSenderMsgSeqNumTest()
        {
            Assert.IsFalse(store.IsOpen);
            store.IncrNextSenderMsgSeqNum();
            Assert.IsTrue(store.IsOpen);
            Assert.AreEqual(2, store.GetNextSenderMsgSeqNum());
            rebuildStore();
            Assert.IsFalse(store.IsOpen);
            Assert.AreEqual(2, store.GetNextSenderMsgSeqNum());
            Assert.IsTrue(store.IsOpen);
        }

        [Test]
        public void getNextTargetMsgSeqNumTest()
        {
            Assert.IsFalse(store.IsOpen);
            Assert.AreEqual(1, store.GetNextTargetMsgSeqNum());
            Assert.IsTrue(store.IsOpen);
            store.SetNextTargetMsgSeqNum(6);
            Assert.AreEqual(6, store.GetNextTargetMsgSeqNum());
            rebuildStore();
            Assert.IsFalse(store.IsOpen);
            Assert.AreEqual(6, store.GetNextTargetMsgSeqNum());
            Assert.IsTrue(store.IsOpen);
        }

        [Test]
        public void incNextTargetMsgSeqNumTest()
        {
            Assert.IsFalse(store.IsOpen);
            store.IncrNextTargetMsgSeqNum();
            Assert.IsTrue(store.IsOpen);
            Assert.AreEqual(2, store.GetNextTargetMsgSeqNum());
            
            rebuildStore();
            Assert.IsFalse(store.IsOpen);
            Assert.AreEqual(2, store.GetNextTargetMsgSeqNum());
            Assert.IsTrue(store.IsOpen);
        }

        [Test]
        public void resetTest()
        {
            // seq nums reset
            store.SetNextTargetMsgSeqNum(5);
            store.SetNextSenderMsgSeqNum(4);
            store.Reset();
            Assert.AreEqual(1, store.GetNextTargetMsgSeqNum());
            Assert.AreEqual(1, store.GetNextSenderMsgSeqNum());

            // Check that messages do not persist after reset
            store.Set(1, "dude");
            store.Set(2, "pude");
            store.Set(3, "ok");
            store.Set(4, "ohai");

            store.Reset();

            var msgs = new List<string>();
            store.Get(2, 3, msgs);
            Assert.That(msgs,Is.Empty);
        }

        [Test]
        public void CreationTimeTest()
        {
            Assert.IsFalse(store.IsOpen);
            DateTime d1 = store.CreationTime.Value;
            Assert.IsTrue(store.IsOpen);
            rebuildStore();
            Assert.IsFalse(store.IsOpen);
            DateTime d2 = store.CreationTime.Value;
            Assert.IsTrue(store.IsOpen);
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d1, d2);

            Thread.Sleep(1000);
            store.Reset();
            DateTime d3 = store.CreationTime.Value;
            Assert.AreEqual(-1, DateTimeOffset.Compare(d1, d3)); // e.g. d1 is earlier than d3
        }


        [Test]
        public void getTest()
        {
            store.Set(1, "dude");
            store.Set(2, "pude");
            store.Set(3, "ok");
            store.Set(4, "ohai");

            var msgs = new List<string>();
            store.Get(2, 3, msgs);
            var expected = new List<string>() { "pude", "ok" };

            Assert.AreEqual(expected, msgs);

            rebuildStore();

            msgs = new List<string>();
            store.Get(2, 3, msgs);

            Assert.AreEqual(expected, msgs);
        }
    }
}
