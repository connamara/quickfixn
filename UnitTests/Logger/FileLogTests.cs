#nullable enable

using System.IO;
using NUnit.Framework;
using QuickFix.Logger;

namespace UnitTests.Logger;

[TestFixture]
public class FileLogTests
{
    private FileLog? _log;

    [SetUp]
    public void Setup()
    { }

    [TearDown]
    public void Teardown()
    {
        _log?.Dispose();
        _log = null;
    }

    [Test]
    public void TestPrefix()
    {
        QuickFix.SessionID someSessionId = new QuickFix.SessionID("FIX.4.4", "sender", "target");
        QuickFix.SessionID someSessionIdWithQualifier = new QuickFix.SessionID("FIX.4.3", "sender", "target", "foo");

        Assert.AreEqual("FIX.4.4-sender-target", FileLog.Prefix(someSessionId));
        Assert.AreEqual("FIX.4.3-sender-target-foo", FileLog.Prefix(someSessionIdWithQualifier));
    }

    [Test]
    public void TestPrefixForSubsAndLocation()
    {
        QuickFix.SessionID sessionIdWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "SENDERLOC", "TARGETCOMP", "TARGETSUB", "TARGETLOC");
        Assert.That(FileLog.Prefix(sessionIdWithSubsAndLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB_SENDERLOC-TARGETCOMP_TARGETSUB_TARGETLOC"));

        QuickFix.SessionID sessionIdWithSubsNoLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "TARGETCOMP", "TARGETSUB");
        Assert.That(FileLog.Prefix(sessionIdWithSubsNoLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB-TARGETCOMP_TARGETSUB"));
    }

    [Test]
    public void TestGeneratedFileName()
    {
        var logDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "log");

        if (Directory.Exists(logDirectory))
            Directory.Delete(logDirectory, true);

        QuickFix.SessionID sessionId = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
        QuickFix.SessionSettings settings = new QuickFix.SessionSettings();

        QuickFix.SettingsDictionary config = new QuickFix.SettingsDictionary();
        config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
        config.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, logDirectory);

        settings.Set(sessionId, config);

        FileLogFactory factory = new FileLogFactory(settings);
        _log = (FileLog)factory.Create(sessionId);

        _log.OnEvent("some event");
        _log.OnIncoming("some incoming");
        _log.OnOutgoing("some outgoing");

        Assert.That(File.Exists(Path.Combine(logDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.event.current.log")));
        Assert.That(File.Exists(Path.Combine(logDirectory, "FIX.4.2-SENDERCOMP-TARGETCOMP.messages.current.log")));
    }

    [Test]
    public void TestThrowsIfNoConfig()
    {
        QuickFix.SessionID sessionId = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
        QuickFix.SettingsDictionary config = new QuickFix.SettingsDictionary();
        config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
        QuickFix.SessionSettings settings = new QuickFix.SessionSettings();
        settings.Set(sessionId, config);

        FileLogFactory factory = new FileLogFactory(settings);

        Assert.Throws<QuickFix.ConfigError>(delegate { factory.Create(sessionId); });
    }
}
