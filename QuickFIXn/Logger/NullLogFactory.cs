﻿#nullable enable

namespace QuickFix.Logger;

public class NullLogFactory : ILogFactory
{
    public NullLogFactory() { }

    public ILog Create(SessionID _x)
    {
        return new NullLog();
    }
}
