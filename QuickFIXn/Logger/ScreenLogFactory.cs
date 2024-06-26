#nullable enable

namespace QuickFix.Logger;

public class ScreenLogFactory : ILogFactory
{
    private const string SCREEN_LOG_SHOW_INCOMING = "ScreenLogShowIncoming";
    private const string SCREEN_LOG_SHOW_OUTGOING = "ScreenLogShowOutgoing";
    private const string SCREEN_LOG_SHOW_EVENTS   = "ScreenLogShowEvents";

    private readonly SessionSettings _settings;

    private readonly bool _logIncoming = false;
    private readonly bool _logOutgoing = false;
    private readonly bool _logEvent = false;

    public ScreenLogFactory(SessionSettings settings)
    {
        _settings = settings;
    }

    public ScreenLogFactory(bool logIncoming, bool logOutgoing, bool logEvent)
    {
        _logIncoming = logIncoming;
        _logOutgoing = logOutgoing;
        _logEvent    = logEvent;

        _settings = new SessionSettings();
    }

    public ILog Create(SessionID sessionId) {
        bool logIncoming = _logIncoming;
        bool logOutgoing = _logOutgoing;
        bool logEvent = _logEvent;

        if(_settings.Has(sessionId))
        {
            SettingsDictionary dict = _settings.Get(sessionId);

            logIncoming = _logIncoming || dict.IsBoolPresentAndTrue(SCREEN_LOG_SHOW_INCOMING);
            logOutgoing = _logOutgoing || dict.IsBoolPresentAndTrue(SCREEN_LOG_SHOW_OUTGOING);
            logEvent = _logEvent || dict.IsBoolPresentAndTrue(SCREEN_LOG_SHOW_EVENTS);
        }

        return new ScreenLog(logIncoming, logOutgoing, logEvent);
    }

    public ILog CreateNonSessionLog() {
        return new ScreenLog(true, true, true);
    }
}
