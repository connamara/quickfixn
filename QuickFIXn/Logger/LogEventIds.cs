using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

public static class LogEventIds
{
    public static readonly EventId IncomingMessage = new(7702, "IncomingMessage");
    public static readonly EventId OutgoingMessage = new(7703, "OutgoingMessage");
}
