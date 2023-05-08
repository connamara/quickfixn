using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using System.Threading;

namespace UnitTests
{
    [TestFixture]
    public class FileStoreTests
    {
        private QuickFix.FileStore _store;
        private QuickFix.FileStoreFactory _factory;

        private QuickFix.SessionSettings _settings;
        private QuickFix.SessionID _sessionID;

        private string _storeDirectory;

        [SetUp]
        public void Setup()
        {
            _storeDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "store");

            if (System.IO.Directory.Exists(_storeDirectory))
                System.IO.Directory.Delete(_storeDirectory, true);

            _sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.FILE_STORE_PATH, _storeDirectory);

            _settings = new QuickFix.SessionSettings();
            _settings.Set(_sessionID, config);
            _factory = new QuickFix.FileStoreFactory(_settings);

            _store = (QuickFix.FileStore)_factory.Create(_sessionID);
        }

        void RebuildStore()
        {
            if(_store != null)
            {
                _store.Dispose();
            }

            _store = (QuickFix.FileStore)_factory.Create(_sessionID);
        }


        [TearDown]
        public void Teardown()
        {
            _store.Dispose();
            Directory.Delete(_storeDirectory, true);
        }

        [Test]
        public void TestPrefixForSessionWithSubsAndLoc()
        {
            QuickFix.SessionID sessionIDWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "SENDERLOC", "TARGETCOMP", "TARGETSUB", "TARGETLOC");
            Assert.That(QuickFix.FileStore.Prefix(sessionIDWithSubsAndLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB_SENDERLOC-TARGETCOMP_TARGETSUB_TARGETLOC"));

            QuickFix.SessionID sessionIDWithSubsNoLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "TARGETCOMP", "TARGETSUB");
            Assert.That(QuickFix.FileStore.Prefix(sessionIDWithSubsNoLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB-TARGETCOMP_TARGETSUB"));
        }

        [Test]
        public void GenerateFileNamesTest()
        {
            Assert.That(System.IO.File.Exists(Path.Combine(_storeDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.seqnums")));
            Assert.That(System.IO.File.Exists(Path.Combine(_storeDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.body")));
            Assert.That(System.IO.File.Exists(Path.Combine(_storeDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.header")));
            Assert.That(System.IO.File.Exists(Path.Combine(_storeDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.session")));
        }

        [Test]
        public void NextSenderMsgSeqNumTest()
        {
            Assert.AreEqual(1, _store.NextSenderMsgSeqNum);
            _store.NextSenderMsgSeqNum = 5;
            Assert.AreEqual(5, _store.NextSenderMsgSeqNum);
            RebuildStore();
            Assert.AreEqual(5, _store.NextSenderMsgSeqNum);
        }

        [Test]
        public void IncNextSenderMsgSeqNumTest()
        {
            _store.IncrNextSenderMsgSeqNum();
            Assert.AreEqual(2, _store.NextSenderMsgSeqNum);
            RebuildStore();
            Assert.AreEqual(2, _store.NextSenderMsgSeqNum);
        }

        [Test]
        public void NextTargetMsgSeqNumTest()
        {
            Assert.AreEqual(1, _store.NextTargetMsgSeqNum);
            _store.NextTargetMsgSeqNum = 6;
            Assert.AreEqual(6, _store.NextTargetMsgSeqNum);
            RebuildStore();
            Assert.AreEqual(6, _store.NextTargetMsgSeqNum);
        }

        [Test]
        public void IncNextTargetMsgSeqNumTest()
        {
            _store.IncrNextTargetMsgSeqNum();
            Assert.AreEqual(2, _store.NextTargetMsgSeqNum);
            RebuildStore();
            Assert.AreEqual(2, _store.NextTargetMsgSeqNum);
        }

        [Test]
        public void ResetTest()
        {
            // seq nums reset
            _store.NextTargetMsgSeqNum = 5;
            _store.NextSenderMsgSeqNum = 4;
            _store.Reset();
            Assert.AreEqual(1, _store.NextTargetMsgSeqNum);
            Assert.AreEqual(1, _store.NextSenderMsgSeqNum);

            // Check that messages do not persist after reset
            _store.Set(1, "dude");
            _store.Set(2, "pude");
            _store.Set(3, "ok");
            _store.Set(4, "ohai");

            _store.Reset();

            var msgs = new List<string>();
            _store.Get(2, 3, msgs);
            Assert.That(msgs,Is.Empty);
        }

        [Test]
        public void CreationTimeTest()
        {
            DateTime d1 = _store.CreationTime.Value;
            RebuildStore();
            DateTime d2 = _store.CreationTime.Value;
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d1, d2);

            Thread.Sleep(1000);
            _store.Reset();
            DateTime d3 = _store.CreationTime.Value;
            Assert.AreEqual(-1, DateTimeOffset.Compare(d1, d3)); // e.g. d1 is earlier than d3
        }


        [Test]
        public void GetTest()
        {
            _store.Set(1, "dude");
            _store.Set(2, "pude");
            _store.Set(3, "ok");
            _store.Set(4, "ohai");

            var msgs = new List<string>();
            _store.Get(2, 3, msgs);
            var expected = new List<string>() { "pude", "ok" };

            Assert.AreEqual(expected, msgs);

            RebuildStore();

            msgs = new List<string>();
            _store.Get(2, 3, msgs);

            Assert.AreEqual(expected, msgs);
        }
    }
}
