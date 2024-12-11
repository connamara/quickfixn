using System;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

[Obsolete("This class is provided to ease migration from the old logging system to Microsoft.Extensions.Logging." +
          "It is an attempt to maintain the behavior of the previous ScreenLog and ScreenLogFactory while plugging into the Microsoft.Extensions.Logging ecosystem. " +
          "Consider using the more robust logging options available in the .NET ecosystem, like the MS Console logging provider, Serilog and NLog.")]
public class ScreenLoggerProvider : ILoggerProvider
{
    private const string SCREEN_LOG_SHOW_INCOMING = "ScreenLogShowIncoming";
    private const string SCREEN_LOG_SHOW_OUTGOING = "ScreenLogShowOutgoing";
    private const string SCREEN_LOG_SHOW_EVENTS = "ScreenLogShowEvents";
    private readonly bool _logIncoming = false;
    private readonly bool _logOutgoing = false;
    private readonly bool _logEvent = false;
    private readonly SessionSettings _settings;

    public ScreenLoggerProvider(SessionSettings settings)
    {
        _settings = settings;
    }

    public ScreenLoggerProvider(bool logIncoming, bool logOutgoing, bool logEvent)
    {
        _logIncoming = logIncoming;
        _logOutgoing = logOutgoing;
        _logEvent = logEvent;
        _settings = new SessionSettings();
    }

    public ILogger CreateLogger(string categoryName)
    {
        // category will be "QuickFix" for non-session logger and "QuickFix.<session ID>" for session logger
        var sessionIdString = categoryName.Length > "QuickFix.".Length ? categoryName.Substring(9) : "";
        bool logIncoming = _logIncoming;
        bool logOutgoing = _logOutgoing;
        bool logEvent = _logEvent;

        var sessionId = _settings.GetSessions()
            .SingleOrDefault(s => s.ToString().Equals(sessionIdString, StringComparison.InvariantCulture));
        if (sessionId is not null)
        {
            SettingsDictionary dict = _settings.Get(sessionId);

            logIncoming = _logIncoming || dict.IsBoolPresentAndTrue(SCREEN_LOG_SHOW_INCOMING);
            logOutgoing = _logOutgoing || dict.IsBoolPresentAndTrue(SCREEN_LOG_SHOW_OUTGOING);
            logEvent = _logEvent || dict.IsBoolPresentAndTrue(SCREEN_LOG_SHOW_EVENTS);
        }

        return new ScreenLog(logIncoming, logOutgoing, logEvent);
    }

    public void Dispose()
    {
    }
}