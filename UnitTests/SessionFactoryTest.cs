using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;
using QuickFix.Store;

namespace UnitTests;

[TestFixture]
public class SessionFactoryTest
{
    [SetUp,TearDown]
    public void TearDown() {
        CharEncoding.ResetToDefaultEncoding();
    }

    private SettingsDictionary CreateMinimalSettings() {
        SettingsDictionary rv = new();
        rv.SetString(SessionSettings.USE_DATA_DICTIONARY, "N");
        rv.SetString(SessionSettings.CONNECTION_TYPE, "initiator");
        rv.SetString(SessionSettings.HEARTBTINT, "30");
        rv.SetString(SessionSettings.START_TIME, "12:00:00");
        rv.SetString(SessionSettings.END_TIME, "12:00:00");
        return rv;
    }

    [Test]
    public void TestPersistMessages()
    {
        IApplication app = new NullApplication();
        IMessageStoreFactory storeFactory = new MemoryStoreFactory();
        SessionFactory factory = new SessionFactory(app, storeFactory);

        SessionID sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
        SettingsDictionary settings = CreateMinimalSettings();
        Session session = factory.Create(sessionId, settings);

        //true by default
        Assert.That(session.PersistMessages);

        settings.SetBool(SessionSettings.PERSIST_MESSAGES, false);
        session = factory.Create(sessionId, settings);

        Assert.That(!session.PersistMessages);
    }

    [Test]
    public void ValidConfiguration()
    {
        IApplication app = new NullApplication();
        IMessageStoreFactory storeFactory = new MemoryStoreFactory();
        SessionFactory factory = new SessionFactory(app, storeFactory);

        SessionID sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
        SettingsDictionary settings = CreateMinimalSettings();

        Assert.DoesNotThrow(delegate { factory.Create(sessionId, settings); });
    }

    [Test]
    public void StartDayAndEndDayAreDifferent()
    {
        IApplication app = new NullApplication();
        IMessageStoreFactory storeFactory = new MemoryStoreFactory();
        SessionFactory factory = new SessionFactory(app, storeFactory);

        SessionID sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
        SettingsDictionary settings = CreateMinimalSettings();
        settings.SetString(SessionSettings.START_DAY, "Sun");
        settings.SetString(SessionSettings.END_DAY, "Mon");

        Assert.DoesNotThrow(delegate { factory.Create(sessionId, settings); });
    }

    [Test]
    public void TestExtendedSettings()
    {
        IApplication app = new NullApplication();
        IMessageStoreFactory storeFactory = new MemoryStoreFactory();
        SessionFactory factory = new SessionFactory(app, storeFactory);

        SessionID sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
        SettingsDictionary settings = CreateMinimalSettings();
        settings.SetString(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS, "Y");
        settings.SetString(SessionSettings.RESEND_SESSION_LEVEL_REJECTS, "Y");
        settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "millis");
        settings.SetString(SessionSettings.ENABLE_LAST_MSG_SEQ_NUM_PROCESSED, "Y");
        settings.SetString(SessionSettings.MAX_MESSAGES_IN_RESEND_REQUEST, "2500");
        settings.SetString(SessionSettings.SEND_LOGOUT_BEFORE_TIMEOUT_DISCONNECT, "Y");
        settings.SetString(SessionSettings.IGNORE_POSSDUP_RESEND_REQUESTS, "Y");

        Session session = factory.Create(sessionId, settings);

        Assert.That(session.SendRedundantResendRequests);
        Assert.That(session.ResendSessionLevelRejects);
        Assert.That(session.TimeStampPrecision, Is.EqualTo(TimeStampPrecision.Millisecond));

        settings.SetString(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS, "N");
        settings.SetString(SessionSettings.RESEND_SESSION_LEVEL_REJECTS, "N");
        settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "nanos");
        session = factory.Create(sessionId, settings);

        Assert.That(!session.SendRedundantResendRequests);
        Assert.That(!session.ResendSessionLevelRejects);
        Assert.That(session.TimeStampPrecision, Is.EqualTo(TimeStampPrecision.Nanosecond));
        Assert.That(session.EnableLastMsgSeqNumProcessed);
        Assert.That(session.MaxMessagesInResendRequest, Is.EqualTo(2500));
        Assert.That(session.SendLogoutBeforeTimeoutDisconnect);
        Assert.That(session.IgnorePossDupResendRequests);
    }

    [Test]
    public void TestTimeStampPrecisionSettings()
    {
        SessionFactory factory = new SessionFactory(
            new NullApplication(),
            new MemoryStoreFactory());

        SessionID sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
        SettingsDictionary settings = CreateMinimalSettings();

        // check default precision
        Session session = factory.Create(sessionId, settings);
        Assert.That(session.TimeStampPrecision == TimeStampPrecision.Millisecond );

        settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "MiCrOsEcOnD");
        session = factory.Create(sessionId, settings);
        Assert.That(session.TimeStampPrecision == TimeStampPrecision.Microsecond );

        settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Micro");
        session = factory.Create(sessionId, settings);
        Assert.That(session.TimeStampPrecision == TimeStampPrecision.Microsecond);

        settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Millisecond");
        session = factory.Create(sessionId, settings);
        Assert.That(session.TimeStampPrecision == TimeStampPrecision.Millisecond);

        settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Milli");
        session = factory.Create(sessionId, settings);
        Assert.That(session.TimeStampPrecision == TimeStampPrecision.Millisecond);

        settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Nanosecond");
        session = factory.Create(sessionId, settings);
        Assert.That(session.TimeStampPrecision == TimeStampPrecision.Nanosecond);

        settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Nano");
        session = factory.Create(sessionId, settings);
        Assert.That(session.TimeStampPrecision == TimeStampPrecision.Nanosecond);

        settings.SetString(SessionSettings.TIMESTAMP_PRECISION, "Second");
        session = factory.Create(sessionId, settings);
        Assert.That(session.TimeStampPrecision == TimeStampPrecision.Second);
    }

    [Test]
    public void TestCharEncoding() {
        IApplication app = new NullApplication();
        IMessageStoreFactory storeFactory = new MemoryStoreFactory();
        SessionFactory factory = new SessionFactory(app, storeFactory);

        SessionID sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
        SettingsDictionary settings = CreateMinimalSettings();
        settings.SetString(SessionSettings.ENCODING, "windows-1251");

        // Yes, CharEncoding is a global static at this time.  Sorry.

        // CharEncoding is set to default before this session is created
        Assert.That(CharEncoding.DefaultCharEncoding, Is.EqualTo("iso-8859-1"));
        Assert.That(CharEncoding.SelectedEncoding, Is.EqualTo(
            System.Text.Encoding.GetEncoding(CharEncoding.DefaultCharEncoding)));

        // When a session changes the Encoding, it's a global change:
        factory.Create(sessionId, settings);
        Assert.That(CharEncoding.SelectedEncoding, Is.EqualTo(
            System.Text.Encoding.GetEncoding("windows-1251")));
    }
}

