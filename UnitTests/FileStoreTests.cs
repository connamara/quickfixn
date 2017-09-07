using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using System.Threading;

namespace UnitTests
{
    public class FileStoreTests : IDisposable
    {
        QuickFix.FileStore store;
        QuickFix.FileStoreFactory factory;

        QuickFix.SessionSettings settings;
        QuickFix.SessionID sessionID;

        public FileStoreTests()
        {
            if (System.IO.Directory.Exists("store"))
                System.IO.Directory.Delete("store", true);

            sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.FILE_STORE_PATH, "store");

            settings = new QuickFix.SessionSettings();
            settings.Set(sessionID, config);
            factory = new QuickFix.FileStoreFactory(settings);

            store = (QuickFix.FileStore)factory.Create(sessionID);
        }

        void rebuildStore()
        {
            if (store != null)
            {
                store.Dispose();
            }

            store = (QuickFix.FileStore)factory.Create(sessionID);
        }

        public void Dispose()
        {
            store.Dispose();
        }

        [Fact]
        public void testPrefixForSessionWithSubsAndLoc()
        {
            QuickFix.SessionID sessionIDWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "SENDERLOC", "TARGETCOMP", "TARGETSUB", "TARGETLOC");
            Assert.Equal("FIX.4.2-SENDERCOMP_SENDERSUB_SENDERLOC-TARGETCOMP_TARGETSUB_TARGETLOC", QuickFix.FileStore.Prefix(sessionIDWithSubsAndLocation));

            QuickFix.SessionID sessionIDWithSubsNoLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "TARGETCOMP", "TARGETSUB");
            Assert.Equal("FIX.4.2-SENDERCOMP_SENDERSUB-TARGETCOMP_TARGETSUB", QuickFix.FileStore.Prefix(sessionIDWithSubsNoLocation));
        }

        [Fact]
        public void generateFileNamesTest()
        {
            Assert.True(System.IO.File.Exists("store/FIX.4.2-SENDERCOMP-TARGETCOMP.seqnums"));
            Assert.True(System.IO.File.Exists("store/FIX.4.2-SENDERCOMP-TARGETCOMP.body"));
            Assert.True(System.IO.File.Exists("store/FIX.4.2-SENDERCOMP-TARGETCOMP.header"));
            Assert.True(System.IO.File.Exists("store/FIX.4.2-SENDERCOMP-TARGETCOMP.session"));
        }

        [Fact]
        public void getNextSenderMsgSeqNumTest()
        {
            Assert.Equal(1, store.GetNextSenderMsgSeqNum());
            store.SetNextSenderMsgSeqNum(5);
            Assert.Equal(5, store.GetNextSenderMsgSeqNum());
            rebuildStore();
            Assert.Equal(5, store.GetNextSenderMsgSeqNum());
        }

        [Fact]
        public void incNextSenderMsgSeqNumTest()
        {
            store.IncrNextSenderMsgSeqNum();
            Assert.Equal(2, store.GetNextSenderMsgSeqNum());
            rebuildStore();
            Assert.Equal(2, store.GetNextSenderMsgSeqNum());
        }

        [Fact]
        public void getNextTargetMsgSeqNumTest()
        {
            Assert.Equal(1, store.GetNextTargetMsgSeqNum());
            store.SetNextTargetMsgSeqNum(6);
            Assert.Equal(6, store.GetNextTargetMsgSeqNum());
            rebuildStore();
            Assert.Equal(6, store.GetNextTargetMsgSeqNum());
        }

        [Fact]
        public void incNextTargetMsgSeqNumTest()
        {
            store.IncrNextTargetMsgSeqNum();
            Assert.Equal(2, store.GetNextTargetMsgSeqNum());
            rebuildStore();
            Assert.Equal(2, store.GetNextTargetMsgSeqNum());
        }

        [Fact]
        public void resetTest()
        {
            // seq nums reset
            store.SetNextTargetMsgSeqNum(5);
            store.SetNextSenderMsgSeqNum(4);
            store.Reset();
            Assert.Equal(1, store.GetNextTargetMsgSeqNum());
            Assert.Equal(1, store.GetNextSenderMsgSeqNum());

            // Check that messages do not persist after reset
            store.Set(1, "dude");
            store.Set(2, "pude");
            store.Set(3, "ok");
            store.Set(4, "ohai");

            store.Reset();

            var msgs = new List<string>();
            store.Get(2, 3, msgs);
            Assert.Empty(msgs);
        }

        [Fact]
        public void CreationTimeTest()
        {
            DateTime d1 = store.CreationTime.Value;
            rebuildStore();
            DateTime d2 = store.CreationTime.Value;
            Util.UtcDateTimeSerializerTests.AssertHackyDateTimeEquality(d1, d2);

            Thread.Sleep(1000);
            store.Reset();
            DateTime d3 = store.CreationTime.Value;
            Assert.Equal(-1, DateTimeOffset.Compare(d1, d3)); // e.g. d1 is earlier than d3
        }

        [Fact]
        public void getTest()
        {
            store.Set(1, "dude");
            store.Set(2, "pude");
            store.Set(3, "ok");
            store.Set(4, "ohai");

            var msgs = new List<string>();
            store.Get(2, 3, msgs);
            var expected = new List<string>() { "pude", "ok" };

            Assert.Equal(expected, msgs);

            rebuildStore();

            msgs = new List<string>();
            store.Get(2, 3, msgs);

            Assert.Equal(expected, msgs);
        }
    }
}
