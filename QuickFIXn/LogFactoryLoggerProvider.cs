using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix
{
    [Obsolete]
    internal class LogFactoryLoggerProvider : ILoggerProvider
    {
        private readonly ILogFactory _logFactory;

        internal LogFactoryLoggerProvider(ILogFactory logFactory)
        {
            _logFactory = logFactory;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new LogLogger(_logFactory.Create(SessionID.FromString(categoryName)));
        }

        public void Dispose()
        {
            return;
        }
    }
}
