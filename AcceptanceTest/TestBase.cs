using NUnit.Framework;
using QuickFix;
using System.IO;
using System.Net;

namespace AcceptanceTest;

public abstract class TestBase
{
    private int _port;
    private FileLog _debugLog;
    private ThreadedSocketAcceptor _acceptor;

    protected abstract SessionSettings Settings { get; }

    [OneTimeSetUp]
    public void Setup()
    {
        SessionSettings settings = Settings;

        _port = settings.Get().GetInt(SessionSettings.SOCKET_ACCEPT_PORT);
        _debugLog = new FileLog("log", new SessionID("AT", "Application", "Debug"));
        var testApp = new ATApplication(_debugLog);
        var storeFactory = new MemoryStoreFactory();

        ILogFactory? logFactory = settings.Get().Has("Verbose") && settings.Get().GetBool("Verbose")
            ? new FileLogFactory(settings)
            : null;

        _acceptor = new ThreadedSocketAcceptor(testApp, storeFactory, settings, logFactory);

        _acceptor.Start();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _acceptor?.Dispose();
        _debugLog?.Dispose();
    }

    protected void RunTest(string definitionPath)
    {
        using Runner runner = new(new IPEndPoint(IPAddress.Loopback, _port));
        using StreamReader sr = new(definitionPath);
        runner.Run(sr);
    }
}