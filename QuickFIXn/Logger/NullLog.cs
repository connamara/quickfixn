
using System;

namespace QuickFix.Logger;

/// <summary>
/// Log implementation that does not do anything
/// </summary>
[Obsolete("Use Microsoft.Extensions.Logging instead.")]
public sealed class NullLog : ILog
{
    #region ILog Members

    public void Clear()
    { }

    public void OnIncoming(string msg)
    { }

    public void OnOutgoing(string msg)
    { }

    public void OnEvent(string s)
    { }

    public void Dispose()
    { }

    #endregion
}
