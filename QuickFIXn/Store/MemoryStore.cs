using System;
using System.Collections.Generic;

namespace QuickFix.Store;

/// <summary>
/// In-memory message store implementation
/// </summary>
public class MemoryStore : IMessageStore
{
    private readonly Dictionary<SeqNumType, string> _messages;

    public MemoryStore()
    {
        _messages = new Dictionary<SeqNumType, string>();
        Reset();
    }

    public void Get(SeqNumType begSeqNo, SeqNumType endSeqNo, List<string> messages)
    {
        for (SeqNumType current = begSeqNo; current <= endSeqNo; current++)
        {
            if (_messages.TryGetValue(current, out var message))
                messages.Add(message);
        }
    }

    #region MessageStore Members

    public bool Set(SeqNumType msgSeqNum, string msg)
    {
        _messages[msgSeqNum] = msg;
        return true;
    }

    public SeqNumType NextSenderMsgSeqNum { get; set; }
    public SeqNumType NextTargetMsgSeqNum { get; set; }

    public void IncrNextSenderMsgSeqNum()
    { ++NextSenderMsgSeqNum; }

    public void IncrNextTargetMsgSeqNum()
    { ++NextTargetMsgSeqNum; }

    public DateTime? CreationTime { get; internal set; }

    public void Reset()
    {
        NextSenderMsgSeqNum = 1;
        NextTargetMsgSeqNum = 1;
        _messages.Clear();
        CreationTime = DateTime.UtcNow;
    }

    public void Refresh()
    { }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    private bool _disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;
        if (disposing)
        {
            _messages.Clear();
        }
        _disposed = true;
    }

    ~MemoryStore() => Dispose(false);
    #endregion
}
