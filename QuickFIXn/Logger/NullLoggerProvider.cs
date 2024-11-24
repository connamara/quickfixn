using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

public class NullLoggerProvider : ILoggerProvider
{
    public void Dispose(){}

    public ILogger CreateLogger(string categoryName) => new NullLogger();
}