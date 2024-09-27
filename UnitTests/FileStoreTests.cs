using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using System.Threading;
using QuickFix;
using QuickFix.Store;

namespace UnitTests
{
    [TestFixture]
    public class FileStoreTests
    {
        private FileStore? _store;
        private FileStoreFactory? _factory;

        private QuickFix.SessionSettings _settings = new();
        private QuickFix.SessionID _sessionId = new("unset", "unset", "unset");

        private string _storeDirectory = "unset";

        [SetUp]
        public void Setup()
        {
            _storeDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "store");

            if (System.IO.Directory.Exists(_storeDirectory))
                System.IO.Directory.Delete(_storeDirectory, true);

            _sessionId = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");

            QuickFix.SettingsDictionary config = new QuickFix.SettingsDictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.FILE_STORE_PATH, _storeDirectory);

            _settings = new QuickFix.SessionSettings();
            _settings.Set(_sessionId, config);
            _factory = new FileStoreFactory(_settings);

            _store = (FileStore)_factory.Create(_sessionId);
        }

        void RebuildStore()
        {
            _store?.Dispose();
            _store = (FileStore)_factory!.Create(_sessionId);
        }


        [TearDown]
        public void Teardown()
        {
            _store!.Dispose();
            Directory.Delete(_storeDirectory, true);
        }

        [Test]
        public void TestPrefixForSessionWithSubsAndLoc()
        {
            QuickFix.SessionID sessionIDWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "SENDERLOC", "TARGETCOMP", "TARGETSUB", "TARGETLOC");
            Assert.That(FileStore.Prefix(sessionIDWithSubsAndLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB_SENDERLOC-TARGETCOMP_TARGETSUB_TARGETLOC"));

            QuickFix.SessionID sessionIDWithSubsNoLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "TARGETCOMP", "TARGETSUB");
            Assert.That(FileStore.Prefix(sessionIDWithSubsNoLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB-TARGETCOMP_TARGETSUB"));
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
            Assert.That(_store!.NextSenderMsgSeqNum, Is.EqualTo(1));
            _store.NextSenderMsgSeqNum = 5;
            Assert.That(_store.NextSenderMsgSeqNum, Is.EqualTo(5));
            RebuildStore();
            Assert.That(_store.NextSenderMsgSeqNum, Is.EqualTo(5));
        }

        [Test]
        public void IncNextSenderMsgSeqNumTest()
        {
            _store!.IncrNextSenderMsgSeqNum();
            Assert.That(_store.NextSenderMsgSeqNum, Is.EqualTo(2));
            RebuildStore();
            Assert.That(_store.NextSenderMsgSeqNum, Is.EqualTo(2));
        }

        [Test]
        public void NextTargetMsgSeqNumTest()
        {
            Assert.That(_store!.NextTargetMsgSeqNum, Is.EqualTo(1));
            _store.NextTargetMsgSeqNum = 6;
            Assert.That(_store.NextTargetMsgSeqNum, Is.EqualTo(6));
            RebuildStore();
            Assert.That(_store.NextTargetMsgSeqNum, Is.EqualTo(6));
        }

        [Test]
        public void IncNextTargetMsgSeqNumTest()
        {
            _store!.IncrNextTargetMsgSeqNum();
            Assert.That(_store.NextTargetMsgSeqNum, Is.EqualTo(2));
            RebuildStore();
            Assert.That(_store.NextTargetMsgSeqNum, Is.EqualTo(2));
        }

        /// Using UInt64 seqnums per FIX Trading Community Continuous Markets Working Group recommendations.
        [Test]
        public void TestSeqNumLimitsForContinuousMarkets()
        {
            // Given the next seqnums are UInt64.MaxValue - 1
            _store!.NextSenderMsgSeqNum = System.UInt64.MaxValue - 1;
            _store.NextTargetMsgSeqNum = _store.NextSenderMsgSeqNum;

            // When the next seqnums are incremented
            _store.IncrNextSenderMsgSeqNum();
            _store.IncrNextTargetMsgSeqNum();

            // Then the next seqnums should be UInt64.MaxValue
            Assert.That(_store.NextSenderMsgSeqNum, Is.EqualTo(System.UInt64.MaxValue));
            Assert.That(_store.NextTargetMsgSeqNum, Is.EqualTo(System.UInt64.MaxValue));

            // When the store is reloaded from files
            RebuildStore();

            // Then the next seqnums should still be UInt64.MaxValue
            Assert.That(_store.NextSenderMsgSeqNum, Is.EqualTo(System.UInt64.MaxValue));
            Assert.That(_store.NextTargetMsgSeqNum, Is.EqualTo(System.UInt64.MaxValue));

            // When the next seqnums are incremented again
            _store.IncrNextSenderMsgSeqNum();
            _store.IncrNextTargetMsgSeqNum();

            // Then the next seqnums should overflow to zero
            Assert.That(_store.NextSenderMsgSeqNum, Is.EqualTo(0));
            Assert.That(_store.NextTargetMsgSeqNum, Is.EqualTo(0));
            
            // When the store is reloaded from files
            RebuildStore();

            // Then the next seqnums should still be zero
            Assert.That(_store.NextSenderMsgSeqNum, Is.EqualTo(0));
            Assert.That(_store.NextTargetMsgSeqNum, Is.EqualTo(0));
        }

        [Test]
        public void ResetTest()
        {
            // seq nums reset
            _store!.NextTargetMsgSeqNum = 5;
            _store.NextSenderMsgSeqNum = 4;
            _store.Reset();
            Assert.That(_store.NextTargetMsgSeqNum, Is.EqualTo(1));
            Assert.That(_store.NextSenderMsgSeqNum, Is.EqualTo(1));

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
            DateTime d1 = _store!.CreationTime!.Value;
            RebuildStore();
            DateTime d2 = _store.CreationTime.Value;
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d1, d2);

            Thread.Sleep(1000);
            _store.Reset();
            DateTime d3 = _store.CreationTime.Value;
            Assert.That(DateTimeOffset.Compare(d1, d3), Is.EqualTo(-1)); // e.g. d1 is earlier than d3
        }


        [Test]
        public void GetTest()
        {
            _store!.Set(1, "dude");
            _store.Set(2, "pude");
            _store.Set(3, "ok");
            _store.Set(4, "ohai");

            var msgs = new List<string>();
            _store.Get(2, 3, msgs);
            var expected = new List<string>() { "pude", "ok" };

            Assert.That(msgs, Is.EqualTo(expected));

            RebuildStore();

            msgs = new List<string>();
            _store.Get(2, 3, msgs);

            Assert.That(msgs, Is.EqualTo(expected));
        }
    }
}
