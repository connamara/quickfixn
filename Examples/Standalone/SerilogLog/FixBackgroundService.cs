using Microsoft.Extensions.Options;
using QuickFix;
using QuickFix.Store;
using QuickFix.Transport;

namespace SerilogLog;

public class FixBackgroundService(IOptions<AppSettings> appSettings, ILoggerFactory loggerFactory) : IHostedService, IApplication
{
    private SocketInitiator? _initiator;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        var settings = new SessionSettings(appSettings.Value.ConfigFilePath);

        var storeFactory = new FileStoreFactory(settings);
        _initiator = new SocketInitiator(
            this,
            storeFactory,
            settings,
            loggerFactory);

        _initiator.Start();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _initiator?.Stop();
        return Task.CompletedTask;
    }

    public void ToAdmin(Message message, SessionID sessionId)
    {
    }

    public void FromAdmin(Message message, SessionID sessionId)
    {
    }

    public void ToApp(Message message, SessionID sessionId)
    {
    }

    public void FromApp(Message message, SessionID sessionId)
    {
    }

    public void OnCreate(SessionID sessionId)
    {
    }

    public void OnLogout(SessionID sessionId)
    {
    }

    public void OnLogon(SessionID sessionId)
    {
    }
}