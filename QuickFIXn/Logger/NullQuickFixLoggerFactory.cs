using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace QuickFix.Logger;

/// <summary>
/// Factory that only returns the MEL NullLogger instance (which logs nothing).
/// </summary>
internal class NullQuickFixLoggerFactory : IQuickFixLoggerFactory
{
    public ILogger CreateSessionLogger(SessionID sessionId) => NullLogger.Instance;
    public ILogger CreateNonSessionLogger<T>() => NullLogger<T>.Instance;
    public static readonly NullQuickFixLoggerFactory Instance = new();
}
