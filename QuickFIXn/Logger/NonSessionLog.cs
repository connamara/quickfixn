#nullable enable
using System;

namespace QuickFix.Logger;

/// <summary>
/// A logger that can be used when the calling logic cannot identify a session (which is rare).
/// Does not create a file until first write.
/// </summary>
public class NonSessionLog {

    private readonly ILogFactory _logFactory;
    private ILog? _log;

    private readonly object _sync = new();

    internal NonSessionLog(ILogFactory logFactory) {
        _logFactory = logFactory;
    }

    internal void OnEvent(string s) {
        lock (_sync) {
            _log ??= _logFactory.CreateNonSessionLog();
        }
        _log.OnEvent(s);
    }
}

