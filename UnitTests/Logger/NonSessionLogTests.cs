using System.IO;
using NUnit.Framework;
using QuickFix.Logger;

namespace UnitTests.Logger;

[TestFixture]
public class NonSessionLogTests {
    private readonly string _logDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "log");

    private NonSessionLog? _nslog;
    private NonSessionLog? _nslog2;

    [TearDown]
    public void Teardown()
    {
        _nslog?.Dispose();
        _nslog = null;
        _nslog2?.Dispose();
        _nslog2 = null;
    }

    private FileLogFactory CreateFileLogFactory() {
        if (Directory.Exists(_logDirectory))
            Directory.Delete(_logDirectory, true);

        string configString = $"""
                               [DEFAULT]
                               ConnectionType=initiator
                               FileLogPath={_logDirectory}

                               [SESSION]
                               BeginString=FIX.4.2
                               SenderCompID=SENDERCOMP
                               TargetCompID=TARGETCOMP
                               """;

        QuickFix.SessionSettings settings = new QuickFix.SessionSettings(
            new StringReader(configString));

        return new FileLogFactory(settings);
    }

    [Test]
    public void TestWithFileLogFactory() {
        FileLogFactory flf = CreateFileLogFactory();
        _nslog = new NonSessionLog(flf);

        // Log artifact not created before first log-write
        Assert.That(Directory.Exists(_logDirectory), Is.False);

        // Log artifact exists after first log-write
        _nslog.OnEvent("some text");
        Assert.That(Directory.Exists(_logDirectory));
        Assert.That(File.Exists(Path.Combine(_logDirectory, "Non-Session-Log.event.current.log")));

        // cleanup (don't delete log unless success)
        _nslog.Dispose();
        _nslog = null;
        Directory.Delete(_logDirectory, true);
    }

    [Test]
    public void TestTwoFileLogs()
    {
        FileLogFactory flf = CreateFileLogFactory();
        _nslog = new NonSessionLog(flf);
        _nslog.OnEvent("log1");

        _nslog2 = new NonSessionLog(flf);
        _nslog2.OnEvent("log2");

        // cleanup (don't delete log unless success)
        _nslog.Dispose();
        _nslog = null;
        _nslog2.Dispose();
        _nslog2 = null;
        Directory.Delete(_logDirectory, true);
    }

    [Test]
    public void TestWithCompositeLogFactory() {
        CompositeLogFactory clf = new CompositeLogFactory([CreateFileLogFactory(), new NullLogFactory()]);
        _nslog = new NonSessionLog(clf);

        // Log artifact not created before first log-write
        Assert.That(Directory.Exists(_logDirectory), Is.False);

        // Log artifact exists after first log-write
        _nslog.OnEvent("some text");
        Assert.That(Directory.Exists(_logDirectory));
        Assert.That(File.Exists(Path.Combine(_logDirectory, "Non-Session-Log.event.current.log")));

        // cleanup (don't delete log unless success)
        _nslog.Dispose();
        _nslog = null;
        Directory.Delete(_logDirectory, true);
    }
}
