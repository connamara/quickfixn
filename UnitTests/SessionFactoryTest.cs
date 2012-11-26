using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class SessionFactoryTest
    {
        [Test]
        public void TestPersistMessages()
        {
            IApplication app = new NullApplication();
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionFactory factory = new SessionFactory(app, storeFactory);

            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Dictionary settings = new Dictionary();
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.CONNECTION_TYPE, "initiator");
            settings.SetString(SessionSettings.HEARTBTINT, "30");
            settings.SetString(SessionSettings.START_TIME, "12:00:00");
            settings.SetString(SessionSettings.END_TIME, "12:00:00");
            Session session = factory.Create(sessionID, settings);

            //true by default
            Assert.That(session.PersistMessages);

            settings.SetBool(SessionSettings.PERSIST_MESSAGES, false);
            session = factory.Create(sessionID, settings);

            Assert.That(!session.PersistMessages);
        }
        [Test]
        public void ValidConfiguration()
        {
            IApplication app = new NullApplication();
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionFactory factory = new SessionFactory(app, storeFactory);

            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Dictionary settings = new Dictionary();
            settings.SetString(SessionSettings.CONNECTION_TYPE, "initiator");
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.START_TIME, "12:00:00");
            settings.SetString(SessionSettings.END_TIME, "12:00:00");
            settings.SetString(SessionSettings.HEARTBTINT, "30");

            Assert.DoesNotThrow(delegate { factory.Create(sessionID, settings); });
        }

        [Test]
        public void StartDayAndEndDayAreDifferent()
        {
            IApplication app = new NullApplication();
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionFactory factory = new SessionFactory(app, storeFactory);

            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Dictionary settings = new Dictionary();
            settings.SetString(SessionSettings.CONNECTION_TYPE, "initiator");
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.START_TIME, "12:00:00");
            settings.SetString(SessionSettings.END_TIME, "12:00:00");
            settings.SetString(SessionSettings.START_DAY, "Sun");
            settings.SetString(SessionSettings.END_DAY, "Mon");
            settings.SetString(SessionSettings.HEARTBTINT, "30");

            Assert.DoesNotThrow(delegate { factory.Create(sessionID, settings); });
        }

        [Test]
        public void TestExtendedSettings()
        {
            IApplication app = new NullApplication();
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionFactory factory = new SessionFactory(app, storeFactory);

            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Dictionary settings = new Dictionary();
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS, "Y");
            settings.SetString(SessionSettings.MILLISECONDS_IN_TIMESTAMP, "Y");
            settings.SetString(SessionSettings.CONNECTION_TYPE, "initiator");
            settings.SetString(SessionSettings.HEARTBTINT, "30");
            settings.SetString(SessionSettings.START_TIME, "12:00:00");
            settings.SetString(SessionSettings.END_TIME, "12:00:00");
            settings.SetString(SessionSettings.ENABLE_LAST_MSG_SEQ_NUM_PROCESSED, "Y");
            settings.SetString(SessionSettings.MAX_MESSAGES_IN_RESEND_REQUEST, "2500");
            settings.SetString(SessionSettings.SEND_LOGOUT_BEFORE_TIMEOUT_DISCONNECT, "Y");
            settings.SetString(SessionSettings.IGNORE_POSSDUP_RESEND_REQUESTS, "Y");

            Session session = factory.Create(sessionID, settings);

            Assert.That(session.SendRedundantResendRequests);
            Assert.That(session.MillisecondsInTimeStamp);

            settings.SetString(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS, "N");
            settings.SetString(SessionSettings.MILLISECONDS_IN_TIMESTAMP, "N");
            session = factory.Create(sessionID, settings);

            Assert.That(!session.SendRedundantResendRequests);
            Assert.That(!session.MillisecondsInTimeStamp);
            Assert.That(session.EnableLastMsgSeqNumProcessed);
            Assert.That(session.MaxMessagesInResendRequest, Is.EqualTo(2500));
            Assert.That(session.SendLogoutBeforeTimeoutDisconnect);
            Assert.That(session.IgnorePossDupResendRequests);
        }
    }
}
