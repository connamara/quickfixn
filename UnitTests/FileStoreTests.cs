using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class FileStoreTests
    {
        QuickFix.FileStore store;
        QuickFix.SessionSettings settings;
        QuickFix.SessionID sessionID;

        [SetUp]
        public void setup()
        {
            if (System.IO.Directory.Exists("store"))
                System.IO.Directory.Delete("store", true);

            sessionID = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");

            QuickFix.Dictionary config = new QuickFix.Dictionary();
            config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
            config.SetString(QuickFix.SessionSettings.FILE_STORE_PATH, "store");

            settings = new QuickFix.SessionSettings();
            settings.Set(sessionID, config);
            QuickFix.FileStoreFactory factory = new QuickFix.FileStoreFactory(settings);
            store = (QuickFix.FileStore)factory.Create(sessionID);
        }
        [TearDown]
        public void teardown()
        {
            store.Dispose();
        }

        [Test]
        public void testGenerateFileNames()
        {
            Assert.That(System.IO.File.Exists("store/FIX.4.2-SENDERCOMP-TARGETCOMP.seqnums"));
        }
    }
}
