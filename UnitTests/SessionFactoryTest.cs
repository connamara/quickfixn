using System.Collections.Generic;
using QuickFix;
using Xunit;

namespace UnitTests
{
    public class SessionFactoryTest
    {
        [Fact]
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
            Assert.True(session.PersistMessages);

            settings.SetBool(SessionSettings.PERSIST_MESSAGES, false);
            session = factory.Create(sessionID, settings);

            Assert.False(session.PersistMessages);
        }

        [Fact]
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

            factory.Create(sessionID, settings);
        }

        [Fact]
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

            factory.Create(sessionID, settings);
        }

        [Fact]
        public void TestExtendedSettings()
        {
            IApplication app = new NullApplication();
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionFactory factory = new SessionFactory(app, storeFactory);

            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Dictionary settings = new Dictionary();
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS, "Y");
            settings.SetString(SessionSettings.RESEND_SESSION_LEVEL_REJECTS, "Y");
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

            Assert.True(session.SendRedundantResendRequests);
            Assert.True(session.ResendSessionLevelRejects);
            Assert.True(session.MillisecondsInTimeStamp);

            settings.SetString(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS, "N");
            settings.SetString(SessionSettings.RESEND_SESSION_LEVEL_REJECTS, "N");
            settings.SetString(SessionSettings.MILLISECONDS_IN_TIMESTAMP, "N");
            session = factory.Create(sessionID, settings);

            Assert.True(!session.SendRedundantResendRequests);
            Assert.True(!session.ResendSessionLevelRejects);
            Assert.True(!session.MillisecondsInTimeStamp);
            Assert.True(session.EnableLastMsgSeqNumProcessed);
            Assert.Equal(2500, session.MaxMessagesInResendRequest);
            Assert.True(session.SendLogoutBeforeTimeoutDisconnect);
            Assert.True(session.IgnorePossDupResendRequests);
        }

        [Fact]
        public void TestTimeStampPrecisionSettings()
        {
            IApplication app = new NullApplication();
            IMessageStoreFactory storeFactory = new MemoryStoreFactory();
            SessionFactory factory = new SessionFactory(app, storeFactory);

            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            Dictionary settings = new Dictionary();
            settings.SetString(SessionSettings.CONNECTION_TYPE, "initiator");
            settings.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
            settings.SetString(SessionSettings.HEARTBTINT, "30");
            settings.SetString(SessionSettings.START_TIME, "12:00:00");
            settings.SetString(SessionSettings.END_TIME, "12:00:00");
            settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Microsecond");

            Session session = factory.Create(sessionID, settings);

            Assert.Equal(QuickFix.Fields.Converters.TimeStampPrecision.Microsecond, session.TimeStampPrecision );

            settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Micro");

            session = factory.Create(sessionID, settings);

            Assert.Equal(QuickFix.Fields.Converters.TimeStampPrecision.Microsecond, session.TimeStampPrecision );

            settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Millisecond");
            session = factory.Create(sessionID, settings);
            Assert.Equal(QuickFix.Fields.Converters.TimeStampPrecision.Millisecond, session.TimeStampPrecision );

            settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Milli");
            session = factory.Create(sessionID, settings);
            Assert.Equal(QuickFix.Fields.Converters.TimeStampPrecision.Millisecond, session.TimeStampPrecision );

            settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Second");
            session = factory.Create(sessionID, settings);
            Assert.Equal(QuickFix.Fields.Converters.TimeStampPrecision.Second, session.TimeStampPrecision );
        }
    }
}
