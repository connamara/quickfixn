using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

internal class LogFactoryAdapter : IQuickFixLoggerFactory, IDisposable
{
    private readonly ILogFactory _logFactory;
    private readonly object _dictionaryLock = new();
    private readonly Dictionary<SessionID, ILogger> _loggers = new();
    private readonly Lazy<ILogger> _nonSessionLogger;

    internal LogFactoryAdapter(ILogFactory logFactory)
    {
        _logFactory = logFactory;
        _nonSessionLogger = new Lazy<ILogger>(() => new LogAdapter(_logFactory.CreateNonSessionLog()));
    }

    public ILogger CreateSessionLogger(SessionID sessionId)
    {
        lock (_dictionaryLock)
        {
            if (!_loggers.TryGetValue(sessionId, out var logger))
            {
                logger = new LogAdapter(_logFactory.Create(sessionId));
                _loggers.Add(sessionId, logger);
            }

            return logger;
        }
    }

    public ILogger CreateNonSessionLogger<T>() => _nonSessionLogger.Value;

    public void Dispose()
    {
        lock (_dictionaryLock)
        {
            foreach (var (_, logger) in _loggers)
            {
                if (logger is IDisposable disposable)
                {
                    try
                    {
                        disposable.Dispose();
                    }
                    catch
                    {
                    }
                }
            }
        }

        try
        {
            if (_nonSessionLogger.IsValueCreated && _nonSessionLogger.Value is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
        catch
        {
        }
    }
}
