using System;
using System.Collections.Generic;
using System.Text;
using QuickFix.Util;

namespace QuickFix.Store;

/// <summary>
/// File store implementation
/// </summary>
public class FileStore : IMessageStore
{
    private class MsgDef
    {
        public long Index { get; }
        public int Size { get; }

        public MsgDef(long index, int size)
        {
            Index = index;
            Size = size;
        }
    }

    private readonly string _seqNumsFileName;
    private readonly string _msgFileName;
    private readonly string _headerFileName;
    private readonly string _sessionFileName;

    private System.IO.FileStream _seqNumsFile;
    private System.IO.FileStream _msgFile;
    private System.IO.StreamWriter _headerFile;

    private readonly MemoryStore _cache = new();

    private readonly Dictionary<SeqNumType, MsgDef> _offsets = new();

    public static string Prefix(SessionID sessionId)
    {
        StringBuilder prefix = new StringBuilder(sessionId.BeginString)
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

    /// <summary>
    ///
    /// </summary>
    /// <param name="path">
    /// All back or forward slashes in this path will be converted as needed to the running platform's preferred
    /// path separator (i.e. "/" will become "\" on windows, else "\" will become "/" on all other platforms)
    /// </param>
    /// <param name="sessionId"></param>
    public FileStore(string path, SessionID sessionId)
    {
        string normalizedPath = StringUtil.FixSlashes(path);

        if (!System.IO.Directory.Exists(normalizedPath))
            System.IO.Directory.CreateDirectory(normalizedPath);

        string prefix = Prefix(sessionId);

        _seqNumsFileName = System.IO.Path.Combine(normalizedPath, prefix + ".seqnums");
        _msgFileName = System.IO.Path.Combine(normalizedPath, prefix + ".body");
        _headerFileName = System.IO.Path.Combine(normalizedPath, prefix + ".header");
        _sessionFileName = System.IO.Path.Combine(normalizedPath, prefix + ".session");

        // The compiler isn't smart enough to see that Open() initializes these 3 vars,
        // but we can use "= null!" to make it accept that these are non-null
        _seqNumsFile = null!;
        _msgFile = null!;
        _headerFile = null!;
        Open();
    }

    private void Open()
    {
        Close();

        ConstructFromFileCache();
        InitializeSessionCreateTime();

        _seqNumsFile = new System.IO.FileStream(_seqNumsFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
        _msgFile = new System.IO.FileStream(_msgFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
        _headerFile = new System.IO.StreamWriter(_headerFileName, true);
    }

    private void Close()
    {
        // these vars will be null only during construction (ctor()->Open()->Close())
        _seqNumsFile?.Dispose();
        _msgFile?.Dispose();
        _headerFile?.Dispose();
    }

    private static void PurgeSingleFile(System.IO.Stream stream, string filename)
    {
        stream.Close();
        if (System.IO.File.Exists(filename))
            System.IO.File.Delete(filename);
    }

    private static void PurgeSingleFile(System.IO.StreamWriter stream, string filename)
    {
        stream.Close();
        if (System.IO.File.Exists(filename))
            System.IO.File.Delete(filename);
    }

    private static void PurgeSingleFile(string filename)
    {
        if (System.IO.File.Exists(filename))
            System.IO.File.Delete(filename);
    }

    private void PurgeFileCache()
    {
        PurgeSingleFile(_seqNumsFile, _seqNumsFileName);
        PurgeSingleFile(_msgFile, _msgFileName);
        PurgeSingleFile(_headerFile, _headerFileName);
        PurgeSingleFile(_sessionFileName);
    }


    private void ConstructFromFileCache()
    {
        _offsets.Clear();
        if (System.IO.File.Exists(_headerFileName))
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(_headerFileName))
            {
                while (reader.ReadLine() is { } line)
                {
                    string[] headerParts = line.Split(',');
                    if (headerParts.Length == 3)
                    {
                        _offsets[Convert.ToUInt64(headerParts[0])] = new MsgDef(
                            Convert.ToInt64(headerParts[1]), Convert.ToInt32(headerParts[2]));
                    }
                }
            }
        }

        if (System.IO.File.Exists(_seqNumsFileName))
        {
            using (System.IO.StreamReader seqNumReader = new System.IO.StreamReader(_seqNumsFileName))
            {
                string[] parts = seqNumReader.ReadToEnd().Split(':');
                if (parts.Length == 2)
                {
                    _cache.NextSenderMsgSeqNum = Convert.ToUInt64(parts[0]);
                    _cache.NextTargetMsgSeqNum = Convert.ToUInt64(parts[1]);
                }
            }
        }
    }

    private void InitializeSessionCreateTime()
    {
        if (System.IO.File.Exists(_sessionFileName) && new System.IO.FileInfo(_sessionFileName).Length > 0)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(_sessionFileName))
            {
                string s = reader.ReadToEnd();
                _cache.CreationTime = UtcDateTimeSerializer.FromString(s);
            }
        }
        else
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(_sessionFileName, false)) {
                writer.Write(UtcDateTimeSerializer.ToString(_cache.CreationTime ?? new DateTime()));
            }
        }
    }


    #region MessageStore Members

    /// <summary>
    /// Get messages within the range of sequence numbers
    /// </summary>
    /// <param name="startSeqNum"></param>
    /// <param name="endSeqNum"></param>
    /// <param name="messages"></param>
    public void Get(SeqNumType startSeqNum, SeqNumType endSeqNum, List<string> messages)
    {
        for (SeqNumType i = startSeqNum; i <= endSeqNum; i++)
        {
            if (_offsets.ContainsKey(i))
            {
                _msgFile.Seek(_offsets[i].Index, System.IO.SeekOrigin.Begin);
                byte[] msgBytes = new byte[_offsets[i].Size];
                _msgFile.Read(msgBytes, 0, msgBytes.Length);

                messages.Add(CharEncoding.DefaultEncoding.GetString(msgBytes));
            }
        }

    }

    /// <summary>
    /// Store a message
    /// </summary>
    /// <param name="msgSeqNum"></param>
    /// <param name="msg"></param>
    /// <returns></returns>
    public bool Set(SeqNumType msgSeqNum, string msg)
    {
        _msgFile.Seek(0, System.IO.SeekOrigin.End);

        long offset = _msgFile.Position;
        byte[] msgBytes = CharEncoding.DefaultEncoding.GetBytes(msg);
        int size = msgBytes.Length;

        StringBuilder b = new StringBuilder();
        b.Append(msgSeqNum).Append(',').Append(offset).Append(',').Append(size);
        _headerFile.WriteLine(b.ToString());
        _headerFile.Flush();

        _offsets[msgSeqNum] = new MsgDef(offset, size);

        _msgFile.Write(msgBytes, 0, size);
        _msgFile.Flush();


        return true;
    }

    public SeqNumType NextSenderMsgSeqNum {
        get => _cache.NextSenderMsgSeqNum;
        set {
            _cache.NextSenderMsgSeqNum = value;
            SetSeqNum();
        }
    }

    public SeqNumType NextTargetMsgSeqNum {
        get => _cache.NextTargetMsgSeqNum;
        set {
            _cache.NextTargetMsgSeqNum = value;
            SetSeqNum();
        }
    }

    public void IncrNextSenderMsgSeqNum()
    {
        _cache.IncrNextSenderMsgSeqNum();
        SetSeqNum();
    }

    public void IncrNextTargetMsgSeqNum()
    {
        _cache.IncrNextTargetMsgSeqNum();
        SetSeqNum();
    }

    private void SetSeqNum()
    {
        _seqNumsFile.Seek(0, System.IO.SeekOrigin.Begin);
        System.IO.StreamWriter writer = new System.IO.StreamWriter(_seqNumsFile);

        writer.Write(NextSenderMsgSeqNum.ToString("D20") + " : " + NextTargetMsgSeqNum.ToString("D20") + "  ");
        writer.Flush();
    }

    public DateTime? CreationTime => _cache.CreationTime;

    public void Reset()
    {
        _cache.Reset();
        PurgeFileCache();
        Open();
    }

    public void Refresh()
    {
        _cache.Reset();
        Open();
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
        if (_disposed) return;
        if (disposing)
        {
            Close();
        }
        _disposed = true;
    }

    ~FileStore() => Dispose(false);
    #endregion
}
