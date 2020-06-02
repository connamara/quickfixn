using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading;

namespace UnitTests
{
    [TestFixture]
    class FileStoreWildcardTests
    {
        QuickFix.FileStore store;
        QuickFix.FileStoreFactory factory;

        QuickFix.SessionSettings settings;
        QuickFix.SessionID sessionID;

        private string storeDirectory;

        [SetUp]
        public void setup()
        {
            storeDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "store");

            if (System.IO.Directory.Exists(storeDirectory))
                System.IO.Directory.Delete(storeDirectory, true);

            sessionID = new QuickFix.SessionID(QuickFix.Values.WILDCARD_VALUE, QuickFix.Values.WILDCARD_VALUE, QuickFix.Values.WILDCARD_VALUE);

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "acceptor");
            config.SetString(QuickFix.SessionSettings.FILE_STORE_PATH, storeDirectory);

            settings = new QuickFix.SessionSettings();
            settings.Set(sessionID, config);
            factory = new QuickFix.FileStoreFactory(settings);

            store = (QuickFix.FileStore)factory.Create(sessionID);
        }

        [TearDown]
        public void teardown()
        {
            store.Dispose();
            Directory.Delete(storeDirectory, true);
        }

        [Test]
        public void testPrefixForSessionWithSubsAndLocWildcards()
        {
            QuickFix.SessionID sessionIDWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", QuickFix.Values.WILDCARD_VALUE, "TARGETCOMP", "TARGETSUB", QuickFix.Values.WILDCARD_VALUE);
            Assert.That(QuickFix.FileStore.Prefix(sessionIDWithSubsAndLocation), Is.EqualTo($"{QuickFix.FileStore.WILDCARD_FILE_PREFIX}FIX.4.2-SENDERCOMP_SENDERSUB_{QuickFix.FileStore.WILDCARD_REPLACEMENT}-TARGETCOMP_TARGETSUB_{QuickFix.FileStore.WILDCARD_REPLACEMENT}"));

            QuickFix.SessionID sessionIDWithSubsNoLocation = new QuickFix.SessionID(QuickFix.Values.WILDCARD_VALUE, QuickFix.Values.WILDCARD_VALUE, QuickFix.Values.WILDCARD_VALUE,
                QuickFix.Values.WILDCARD_VALUE, QuickFix.Values.WILDCARD_VALUE);
            Assert.That(QuickFix.FileStore.Prefix(sessionIDWithSubsNoLocation), Is.EqualTo($"{QuickFix.FileStore.WILDCARD_FILE_PREFIX}{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}_{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}_{QuickFix.FileStore.WILDCARD_REPLACEMENT}"));
        }

        [Test]
        public void generateFileNamesTest()
        {
            Assert.That(System.IO.File.Exists(Path.Combine(storeDirectory, $"{QuickFix.FileStore.WILDCARD_FILE_PREFIX}{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}.seqnums")));
            Assert.That(System.IO.File.Exists(Path.Combine(storeDirectory, $"{QuickFix.FileStore.WILDCARD_FILE_PREFIX}{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}.body")));
            Assert.That(System.IO.File.Exists(Path.Combine(storeDirectory, $"{QuickFix.FileStore.WILDCARD_FILE_PREFIX}{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}.header")));
            Assert.That(System.IO.File.Exists(Path.Combine(storeDirectory, $"{QuickFix.FileStore.WILDCARD_FILE_PREFIX}{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}-{QuickFix.FileStore.WILDCARD_REPLACEMENT}.session")));
        }

    }
}
