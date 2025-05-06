using System;
using System.IO;
using NUnit.Framework;
using QuickFix.Logger;

namespace UnitTests.Logger;

[TestFixture]
public class FileLogTests
{
    private FileLog? _log;

    private readonly QuickFix.SessionID _defaultSessionId = new ("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
    private readonly string _logDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "log");
    private readonly string _eventLogFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "log",
        "FIX.4.2-SENDERCOMP-TARGETCOMP.event.current.log");
    private readonly string _messagesLogFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "log",
            "FIX.4.2-SENDERCOMP-TARGETCOMP.messages.current.log");

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

        Assert.That(FileLog.Prefix(someSessionId), Is.EqualTo("FIX.4.4-sender-target"));
        Assert.That(FileLog.Prefix(someSessionIdWithQualifier), Is.EqualTo("FIX.4.3-sender-target-foo"));
    }

    [Test]
    public void TestPrefixForSubsAndLocation()
    {
        QuickFix.SessionID sessionIdWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "SENDERLOC", "TARGETCOMP", "TARGETSUB", "TARGETLOC");
        Assert.That(FileLog.Prefix(sessionIdWithSubsAndLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB_SENDERLOC-TARGETCOMP_TARGETSUB_TARGETLOC"));

        QuickFix.SessionID sessionIdWithSubsNoLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "TARGETCOMP", "TARGETSUB");
        Assert.That(FileLog.Prefix(sessionIdWithSubsNoLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB-TARGETCOMP_TARGETSUB"));
    }

    private FileLogFactory CreateTestFactory()
    {
        if (Directory.Exists(_logDirectory))
            Directory.Delete(_logDirectory, true);

        QuickFix.SessionSettings settings = new QuickFix.SessionSettings();
        QuickFix.SettingsDictionary config = new QuickFix.SettingsDictionary();
        config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
        config.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, _logDirectory);

        settings.Set(_defaultSessionId, config);
        return new FileLogFactory(settings);
    }

    [Test]
    public void TestGeneratedFileName()
    {
        FileLogFactory factory = CreateTestFactory();
        _log = (FileLog)factory.Create(_defaultSessionId);

        // Log files aren't created before first log statement
        Assert.That(!File.Exists(_eventLogFilePath));
        Assert.That(!File.Exists(_messagesLogFilePath));

        _log.OnEvent("some event");

        // The event file exists now
        Assert.That(File.Exists(_eventLogFilePath));
        Assert.That(!File.Exists(_messagesLogFilePath));

        _log.OnIncoming("some incoming");
        _log.OnOutgoing("some outgoing");

        // The message file exists now
        Assert.That(File.Exists(_eventLogFilePath));
        Assert.That(File.Exists(_messagesLogFilePath));

        // cleanup (don't delete log unless success)
        _log.Dispose();
        _log = null;
        Directory.Delete(_logDirectory, true);
    }

    [Test]
    public void TestThrowsIfNoConfig()
    {
        QuickFix.SettingsDictionary config = new QuickFix.SettingsDictionary();
        config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
        QuickFix.SessionSettings settings = new QuickFix.SessionSettings();
        settings.Set(_defaultSessionId, config);

        FileLogFactory factory = new FileLogFactory(settings);
        var ex = Assert.Throws<QuickFix.ConfigError>(delegate { factory.Create(_defaultSessionId); });
        Assert.That(ex!.Message, Does.Contain("Configuration failed: No value for key: FileLogPath"));
    }

    [Test]
    public void TestClear()
    {
        FileLogFactory factory = CreateTestFactory();
        _log = (FileLog)factory.Create(_defaultSessionId);

        _log.OnEvent("some event");
        _log.OnIncoming("some incoming");

        // Clear() should delete the contents of the log files...
        _log.Clear();
        Assert.That(new FileInfo(_eventLogFilePath).Length, Is.EqualTo(0));
        Assert.That(new FileInfo(_messagesLogFilePath).Length, Is.EqualTo(0));

        // ... and leave them ready for more logging
        Assert.DoesNotThrow(delegate { _log.OnEvent("another event after clear"); });
        Assert.DoesNotThrow(delegate { _log.OnIncoming("another incoming after clear"); });

        // cleanup (don't delete log unless success)
        _log.Dispose();
        _log = null;
        Directory.Delete(_logDirectory, true);
    }
}
