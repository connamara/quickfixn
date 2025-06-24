using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

public interface IQuickFixLoggerFactory
{
    public ILogger CreateSessionLogger(SessionID sessionId);
    public ILogger CreateNonSessionLogger<T>();
}
