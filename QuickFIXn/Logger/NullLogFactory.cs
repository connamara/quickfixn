using System;

namespace QuickFix.Logger;

[Obsolete("Use Microsoft.Extensions.Logging instead.")]
public class NullLogFactory : ILogFactory
{
    public NullLogFactory() { }

    public ILog Create(SessionID _x)
    {
        return new NullLog();
    }

    public ILog CreateNonSessionLog()
    {
        return new NullLog();
    }
}
