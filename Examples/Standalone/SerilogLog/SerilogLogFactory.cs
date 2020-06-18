using System;
using System.Collections.Generic;
using System.Text;
using QuickFix;

namespace SerilogLog
{
    /// <summary>
    /// Sample implementation of QuickFix.ILog for SerilogLog.
    /// Usage example:
    ///     ILogFactory logFactory = new SerilogLogFactory(settings);
    ///     ThreadedSocketAcceptor _acceptor = new ThreadedSocketAcceptor(executorApp, storeFactory, settings, logFactory);
    /// - all sessions created by this acceptor will be using SerilogLog for messages and events logging
    /// </summary>
    public class SerilogLogFactory : QuickFix.ILogFactory
    {
        SessionSettings _settings;

        /// <summary>
        /// Feel free to add other logging parameters
        /// based on the actual requirements, e.g. limits to be set in `public ILog Create`
        /// </summary>
        public SerilogLogFactory(SessionSettings settings)
        {
            _settings = settings;
        }

        public ILog Create(SessionID sessionID)
        {
            // Here you can also change logging parameters depending on sessionID value.
            // I.e. if you have separate sessions for streaming prices and for trading, you can set some max size for the prices log and no limit (null) for the trading log.
            // You can even create NullLog for the prices, if no log is required, to avoid file I/O operations and so to improve performance.
            return new SerilogLog(_settings.Get(sessionID).GetString(SessionSettings.FILE_LOG_PATH),
                sessionID,
                // change below to your actual requirements
                1024*1024, 10, 1024*1024, 2);
        }
    }
}
