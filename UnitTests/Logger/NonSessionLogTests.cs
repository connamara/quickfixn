using System.IO;
using NUnit.Framework;
using QuickFix.Logger;

namespace UnitTests.Logger;

[TestFixture]
public class NonSessionLogTests
{
    private readonly string _logDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "log");

    [TearDown]
    public void Teardown()
    {
    }

    private FileLogFactory CreateFileLogFactory()
    {
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

        QuickFix.SessionSettings settings = new(
            new StringReader(configString));

        return new FileLogFactory(settings);
    }

    [Test]
    public void TestWithFileLogFactory()
    {
        FileLogFactory flf = CreateFileLogFactory();
        NonSessionLog nslog = new(flf);

        // Log artifact not created before first log-write
        Assert.That(Directory.Exists(_logDirectory), Is.False);

        // Log artifact exists after first log-write
        nslog.OnEvent("some text");
        Assert.That(Directory.Exists(_logDirectory));
        Assert.That(File.Exists(Path.Combine(_logDirectory, "Non-Session-Log.event.current.log")));

        // cleanup (don't delete log unless success)
        Directory.Delete(_logDirectory, true);
    }

    [Test]
    public void TestTwoFileLogs()
    {
        FileLogFactory flf = CreateFileLogFactory();
        NonSessionLog nslog = new(flf);
        nslog.OnEvent("log1");

        NonSessionLog nslog2 = new(flf);
        nslog2.OnEvent("log2");

        // cleanup (don't delete log unless success)
        Directory.Delete(_logDirectory, true);
    }

    [Test]
    public void TestWithCompositeLogFactory()
    {
        CompositeLogFactory clf = new CompositeLogFactory([CreateFileLogFactory(), new NullLogFactory()]);
        NonSessionLog nslog = new(clf);

        // Log artifact not created before first log-write
        Assert.That(Directory.Exists(_logDirectory), Is.False);

        // Log artifact exists after first log-write
        nslog.OnEvent("some text");
        Assert.That(Directory.Exists(_logDirectory));
        Assert.That(File.Exists(Path.Combine(_logDirectory, "Non-Session-Log.event.current.log")));

        // cleanup (don't delete log unless success)
        Directory.Delete(_logDirectory, true);
    }
}
