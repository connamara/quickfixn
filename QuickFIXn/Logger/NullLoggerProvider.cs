using System;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

[Obsolete("This class is provided to ease migration from the old logging system to Microsoft.Extensions.Logging." +
          "It is an attempt to maintain the behavior of the previous NullLog and NullLogFactory while plugging into the Microsoft.Extensions.Logging ecosystem. " +
          "Consider using the more robust logging options available in the .NET ecosystem, like the MS Console logging provider, Serilog and NLog.")]
public class NullLoggerProvider : ILoggerProvider
{
    public void Dispose(){}

    public ILogger CreateLogger(string categoryName) => new NullLogger();
}