using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickFix
{
    /// <summary>
    /// Allows multiple log factories to be used with QuickFIX/N. For example, you could log events to the console and also log all events and messages to a file.
    /// </summary>
    [Obsolete("Please use LoggerFactory instead")]
    public class CompositeLogFactory : ILoggerProvider, ILogFactory
    {
        private readonly ILoggerFactory _factory = new LoggerFactory();

        private readonly IEnumerable<ILogFactory> _logFactories;

        [Obsolete]
        public CompositeLogFactory(IEnumerable<ILogFactory> factories)
        {
            _logFactories = factories;
            foreach (var factory in factories)
            {
                _factory.AddProvider(new LogFactoryLoggerProvider(factory));
            }
        }

        /// <summary>
        /// Creates a composite log
        /// </summary>
        /// <param name="sessionID">session ID for the message store</param>
        /// <returns></returns>
        [Obsolete]
        public ILog Create(SessionID sessionID)
        {
            return new CompositeLog(_logFactories.Select(f => f.Create(sessionID)).ToArray());
        }

        public ILogger CreateLogger(string categoryName)
        {
            return _factory.CreateLogger(categoryName);
        }

        public void Dispose()
        {
            _factory.Dispose();
        }
    }
}
