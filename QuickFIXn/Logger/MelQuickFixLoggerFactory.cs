using Microsoft.Extensions.Logging;
using QuickFix.ObjectPooling;

namespace QuickFix.Logger;

/// <summary>
/// Factory that invokes its member ILoggerFactory to create MEL ILoggers
/// </summary>
internal class MelQuickFixLoggerFactory : IQuickFixLoggerFactory
{
    private readonly ILoggerFactory _loggerFactory;

    public MelQuickFixLoggerFactory(ILoggerFactory loggerFactory)
    {
        _loggerFactory = loggerFactory;
    }

    /// <summary>
    /// Creates a new <see cref="ILogger"/> instance using the Session ID.
    /// </summary>
    /// <returns>The <see cref="ILogger"/> that was created</returns>
    public ILogger CreateSessionLogger(SessionID sessionId) =>
        _loggerFactory.CreateLogger($"QuickFix.SessionLogs.{GetCategoryFromSessionId(sessionId)}");

    /// <summary>
    /// Creates a new <see cref="ILogger"/> instance using the full name of the given type.
    /// </summary>
    /// <typeparam name="T">The type</typeparam>
    /// <returns>The <see cref="ILogger"/> that was created</returns>
    public ILogger CreateNonSessionLogger<T>() => _loggerFactory.CreateLogger<T>();

    private static string GetCategoryFromSessionId(SessionID sessionId)
    {
        using PooledStringBuilder pooledSb = new PooledStringBuilder();
        System.Text.StringBuilder category = pooledSb.Builder.Append(sessionId.BeginString)
            .Append('-').Append(sessionId.SenderCompID);
        if (SessionID.IsSet(sessionId.SenderSubID))
            category.Append('_').Append(sessionId.SenderSubID);
        if (SessionID.IsSet(sessionId.SenderLocationID))
            category.Append('_').Append(sessionId.SenderLocationID);
        category.Append('-').Append(sessionId.TargetCompID);
        if (SessionID.IsSet(sessionId.TargetSubID))
            category.Append('_').Append(sessionId.TargetSubID);
        if (SessionID.IsSet(sessionId.TargetLocationID))
            category.Append('_').Append(sessionId.TargetLocationID);

        if (SessionID.IsSet(sessionId.SessionQualifier))
            category.Append('-').Append(sessionId.SessionQualifier);

        return category.ToString();
    }
}
