using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace QuickFix.Logger;

internal class NullQuickFixLoggerFactory : IQuickFixLoggerFactory
{
    public ILogger CreateSessionLogger(SessionID sessionId) => NullLogger.Instance;
    public ILogger CreateNonSessionLogger<T>() => NullLogger<T>.Instance;
    public static readonly NullQuickFixLoggerFactory Instance = new();
}
