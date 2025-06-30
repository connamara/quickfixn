using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

/// <summary>
/// Interface for all QuickFixLoggerFactory classes.
/// (Introduced in v1.15 to replace old ILogFactory interface.)
/// </summary>
public interface IQuickFixLoggerFactory
{
    public ILogger CreateSessionLogger(SessionID sessionId);
    public ILogger CreateNonSessionLogger<T>();
}
