namespace QuickFix.Logger;

/// <summary>
/// A logger that can be used when the calling logic cannot identify a session (which is rare).
/// Does not create a log artifact until first write.
/// </summary>
public class NonSessionLog : System.IDisposable {

    private readonly ILogFactory _logFactory;
    private ILog? _log;

    private readonly object _sync = new();

    internal NonSessionLog(ILogFactory logFactory) {
        _logFactory = logFactory;
    }

    internal void OnEvent(string s) {
        if (_disposed) return;

        lock (_sync) {
            _log ??= _logFactory.CreateNonSessionLog();
        }
        _log?.OnEvent(s);
    }

    private bool _disposed;
    public void Dispose() {
        if (_disposed) return;

        if (_log != null) {
            _log.Dispose();
            _log = null;
            _disposed = true;
        }
    }
}

