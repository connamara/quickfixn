using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Net.Http.Headers;

namespace QuickFix
{
    [Obsolete("Use NullLoggerFactory instead")]
    public class NullLogFactory : ILoggerProvider, ILogFactory
    {
        public NullLogFactory() { }

        public static readonly NullLoggerFactory Instance = new NullLoggerFactory();

        [Obsolete]
        public ILog Create(SessionID _x)
        {
            return NullLog.Instance;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return Instance.CreateLogger(categoryName);
        }

        public void Dispose()
        {
            Instance.Dispose();
        }
    }
}
