using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

/// <summary>
/// Creates QuickFIX/n-specific ILoggers.
/// Introduced in v1.15 for Microsoft.Extensions.Logging support.
/// </summary>
internal interface IQuickFixLoggerFactory
{
    public ILogger CreateSessionLogger(SessionID sessionId);
    public ILogger CreateNonSessionLogger<T>();
}
