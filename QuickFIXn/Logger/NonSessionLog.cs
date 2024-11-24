using System;

namespace QuickFix.Logger;

/// <summary>
/// A logger that can be used when the calling logic cannot identify a session (which is rare).
/// Does not create a log artifact until first write.
/// </summary>
[Obsolete("Use Microsoft.Extensions.Logging instead.")]
public class NonSessionLog {

    private readonly ILogFactory _logFactory;

    private readonly static object _sync = new();

    internal NonSessionLog(ILogFactory logFactory) {
        _logFactory = logFactory;
    }

    /// <summary>
    /// Write to a log that is not tied to a session.
    /// Calls to this should be rare, and only to record problem events that
    /// cannot be tied to a specific session.
    /// (Think errors and maybe warnings, NOT infos.)
    /// </summary>
    /// <param name="s">message to log</param>
    internal void OnEvent(string s) {
        // Atomic open/write/close operation.
        // This function should not be called often enough
        //   for this overhead to cause a performance issue.
        lock (_sync) {
            ILog _log = _logFactory.CreateNonSessionLog();
            _log.OnEvent(s);
            _log.Dispose();
        }
    }
}
