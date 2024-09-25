using System.Linq;

namespace QuickFix.Logger;

/// <summary>
/// Allows multiple log factories to be used with QuickFIX/N.
/// For example, you could log events to the console and also log all events and messages to a file.
/// </summary>
public class CompositeLogFactory : ILogFactory
{
    private readonly ILogFactory[] _factories;

    public CompositeLogFactory(ILogFactory[] factories)
    {
        _factories = factories;
    }

    /// <summary>
    /// Creates a composite log
    /// </summary>
    /// <param name="sessionID">session ID for the message store</param>
    /// <returns></returns>
    public ILog Create(SessionID sessionID)
    {
        return new CompositeLog(_factories.Select(f => f.Create(sessionID)).ToArray());
    }

    public ILog CreateNonSessionLog() {
        return new CompositeLog(_factories.Select(f => f.Create(new SessionID("Non", "Session", "Log"))).ToArray());
    }
}
