using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using QuickFix.Fields.Converters;
using QuickFix.Util;

namespace QuickFix.Logger;

/// <summary>
/// File log implementation
/// </summary>
public class FileLog : ILog
{
    private readonly object _sync = new();

    private System.IO.StreamWriter? _messageLog;
    private System.IO.StreamWriter? _eventLog;

    private readonly string _messageLogFileName;
    private readonly string _eventLogFileName;

    /// <summary>
    ///
    /// </summary>
    /// <param name="fileLogPath">
    /// All back or forward slashes in this path will be converted as needed to the running platform's preferred
    /// path separator (i.e. "/" will become "\" on windows, else "\" will become "/" on all other platforms)
    /// </param>
    /// <param name="sessionId"></param>
    public FileLog(string fileLogPath, SessionID sessionId)
    {
        string prefix = Prefix(sessionId);

        string normalizedPath = StringUtil.FixSlashes(fileLogPath);

        if (!System.IO.Directory.Exists(normalizedPath))
            System.IO.Directory.CreateDirectory(normalizedPath);

        _messageLogFileName = System.IO.Path.Combine(normalizedPath, prefix + ".messages.current.log");
        _eventLogFileName = System.IO.Path.Combine(normalizedPath, prefix + ".event.current.log");
    }

    public static string Prefix(SessionID sessionId)
    {
        System.Text.StringBuilder prefix = new System.Text.StringBuilder(sessionId.BeginString)
            .Append('-').Append(sessionId.SenderCompID);
        if (SessionID.IsSet(sessionId.SenderSubID))
            prefix.Append('_').Append(sessionId.SenderSubID);
        if (SessionID.IsSet(sessionId.SenderLocationID))
            prefix.Append('_').Append(sessionId.SenderLocationID);
        prefix.Append('-').Append(sessionId.TargetCompID);
        if (SessionID.IsSet(sessionId.TargetSubID))
            prefix.Append('_').Append(sessionId.TargetSubID);
        if (SessionID.IsSet(sessionId.TargetLocationID))
            prefix.Append('_').Append(sessionId.TargetLocationID);

        if (SessionID.IsSet(sessionId.SessionQualifier))
            prefix.Append('-').Append(sessionId.SessionQualifier);

        return prefix.ToString();
    }

    private void DisposedCheck()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
    }

    [MemberNotNull(nameof(_messageLog))]
    private void EnsureMessageLogInit(bool append = true)
    {
        Debug.Assert(Monitor.IsEntered(_sync), "Expected to hold the lock");

        _messageLog ??= new System.IO.StreamWriter(_messageLogFileName, append)
        {
            AutoFlush = true
        };
    }

    [MemberNotNull(nameof(_eventLog))]
    private void EnsureEventLogInit(bool append = true)
    {
        Debug.Assert(Monitor.IsEntered(_sync), "Expected to hold the lock");

        _eventLog ??= new System.IO.StreamWriter(_eventLogFileName, append)
        {
            AutoFlush = true
        };
    }

    #region Log Members

    public void Clear()
    {
        lock (_sync)
        {
            DisposedCheck();

            _messageLog?.Dispose();
            _eventLog?.Dispose();

            EnsureMessageLogInit(append: false);
            EnsureEventLogInit(append: false);
        }
    }

    public void OnIncoming(string msg)
    {
        lock (_sync)
        {
            DisposedCheck();
            EnsureMessageLogInit();
            _messageLog.WriteLine(DateTimeConverter.ToFIX(DateTime.UtcNow, TimeStampPrecision.Millisecond) + " : " + msg);
        }
    }

    public void OnOutgoing(string msg)
    {
        lock (_sync)
        {
            DisposedCheck();
            EnsureMessageLogInit();
            _messageLog.WriteLine(DateTimeConverter.ToFIX(DateTime.UtcNow, TimeStampPrecision.Millisecond) + " : " + msg);
        }
    }

    public void OnEvent(string s)
    {
        lock (_sync)
        {
            DisposedCheck();
            EnsureEventLogInit();
            _eventLog.WriteLine(DateTimeConverter.ToFIX(DateTime.UtcNow, TimeStampPrecision.Millisecond) + " : " + s);
        }
    }

    #endregion

    #region IDisposable Members
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private bool _disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (!disposing)
        {
            return;
        }

        lock (_sync)
        {
            if (_disposed)
            {
                return;
            }

            _messageLog?.Dispose();
            _eventLog?.Dispose();

            _disposed = true;
        }
    }
    #endregion
}
