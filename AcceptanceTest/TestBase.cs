using NUnit.Framework;
using QuickFix;
using System.IO;
using System.Net;
using QuickFix.Logger;
using QuickFix.Store;

namespace AcceptanceTest;

public abstract class TestBase
{
    private int _port;
    private ThreadedSocketAcceptor _acceptor;

    protected abstract SessionSettings Settings { get; }

    [OneTimeSetUp]
    public void Setup()
    {
        SessionSettings settings = Settings;

        _port = settings.Get().GetInt(SessionSettings.SOCKET_ACCEPT_PORT);
        var testApp = new ATApplication();
        var storeFactory = new MemoryStoreFactory();

        ILogFactory? logFactory = settings.Get().Has("Verbose") && settings.Get().GetBool("Verbose")
            ? new FileLogFactory(settings)
            : new NullLogFactory();

        _acceptor = new ThreadedSocketAcceptor(testApp, storeFactory, settings, logFactory);

        _acceptor.Start();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _acceptor?.Dispose();
    }

    protected void RunTest(string definitionPath)
    {
        System.Threading.Thread.Sleep(100);
        using Runner runner = new(new IPEndPoint(IPAddress.Loopback, _port));
        using StreamReader sr = new(definitionPath);
        runner.Run(sr);
    }
}
