using System.Collections.Generic;
using System.Linq;

namespace QuickFix
{
    /// <summary>
    /// Allows multiple log factories to be used with QuickFIX/N. For example, you could log events to the console and also log all events and messages to a file.
    /// </summary>
    public class CompositeLogFactory : ILogFactory
    {
        private ILogFactory[] factories_;

        public CompositeLogFactory(ILogFactory[] factories)
        {
            factories_ = factories;
        }

        /// <summary>
        /// Creates a composite log
        /// </summary>
        /// <param name="sessionID">session ID for the message store</param>
        /// <returns></returns>
        public ILog Create(SessionID sessionID)
        {
            return new CompositeLog(factories_.Select(f => f.Create(sessionID)).ToArray());
        }
    }
}
