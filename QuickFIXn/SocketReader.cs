﻿using System.Net.Sockets;
using System.IO;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using QuickFix.Logger;

namespace QuickFix;

public class SocketReader : IDisposable
{
    public const int BUF_SIZE = 4096;
    private readonly byte[] _readBuffer = new byte[BUF_SIZE];
    private readonly Parser _parser = new();
    private Session? _qfSession;
    private readonly Stream _stream;
    private readonly CancellationTokenSource _readCancellationTokenSource = new();
    private readonly TcpClient _tcpClient;
    private readonly ClientHandlerThread _responder;
    private readonly AcceptorSocketDescriptor? _acceptorDescriptor;
    private readonly ILogger _nonSessionLog;
    private ILogger UnconditionalLogger
    {
        get
        {
            if (_qfSession?.Log is { } logger) return logger;
            return _nonSessionLog;
        }
    }

    /// <summary>
    /// Keep a task for handling async read
    /// </summary>
    private Task<int>? _currentReadTask;

    internal SocketReader(
        TcpClient tcpClient,
        SocketSettings settings,
        ClientHandlerThread responder,
        AcceptorSocketDescriptor? acceptorDescriptor,
        IQuickFixLoggerFactory loggerFactory)
    {
        _tcpClient = tcpClient;
        _responder = responder;
        _acceptorDescriptor = acceptorDescriptor;
        _stream = Transport.StreamFactory.CreateServerStream(tcpClient, settings, loggerFactory);
        _nonSessionLog = loggerFactory.CreateNonSessionLogger<SocketReader>();
    }

    public void Read()
    {
        try
        {
            int bytesRead = ReadSome(_readBuffer, 1000);
            if (bytesRead > 0)
                _parser.AddToStream(new ReadOnlySpan<byte>(_readBuffer, 0, bytesRead));
            else
                _qfSession?.Next();

            ProcessStream();
        }
        catch (MessageParseError e)
        {
            HandleExceptionInternal(_qfSession, e);
        }
        catch (Exception e)
        {
            HandleExceptionInternal(_qfSession, e);
            throw;
        }
    }

    /// <summary>
    /// Reads data from the network into the specified buffer.
    /// It will wait up to the specified number of milliseconds for data to arrive,
    /// if no data has arrived after the specified number of milliseconds then the function returns 0
    /// </summary>
    /// <param name="buffer">The buffer.</param>
    /// <param name="timeoutMilliseconds">The timeout milliseconds.</param>
    /// <returns>The number of bytes read into the buffer</returns>
    /// <exception cref="System.Net.Sockets.SocketException">On connection reset</exception>
    protected virtual int ReadSome(byte[] buffer, int timeoutMilliseconds)
    {
        // NOTE: THIS FUNCTION IS (nearly) EXACTLY THE SAME AS THE ONE IN SocketInitiatorThread.
        // Any changes made here should also be performed there.
        try {
            // Begin read if it is not already started
            _currentReadTask ??= _stream.ReadAsync(buffer, 0, buffer.Length, _readCancellationTokenSource.Token);

            if (_currentReadTask.Wait(timeoutMilliseconds)) {
                // Dispose/nullify currentReadTask *before* retrieving .Result.
                //   Accessing .Result can throw an exception, so we need to reset currentReadTask
                //   first, to set us up for the next read even if an exception is thrown.
                Task<int>? request = _currentReadTask;
                _currentReadTask = null;

                int bytesRead = request.Result; // (As mentioned above, this can throw an exception!)
                if (0 == bytesRead)
                    throw new SocketException(Convert.ToInt32(SocketError.Shutdown));

                return bytesRead;
            }

            return 0;
        }
        catch (AggregateException ex) // Timeout
        {
            _currentReadTask = null;
            IOException? ioException = ex.InnerException as IOException;
            SocketException? inner = ioException?.InnerException as SocketException;
            if (inner is not null && inner.SocketErrorCode == SocketError.TimedOut) {
                // Nothing read 
                return 0;
            }

            if (inner is not null) {
                throw inner; //rethrow SocketException part (which we have exception logic for)
            }

            throw; //rethrow original exception
        }
    }

    private void OnMessageFound(string msg)
    {
        try
        {
            if (_qfSession is null)
            {
                _qfSession = Session.LookupSession(Message.GetReverseSessionId(msg));
                if (_qfSession is null || IsUnknownSession(_qfSession.SessionID))
                {
                    _qfSession = null;
                    _nonSessionLog.Log(LogLevel.Error,
                        "ERROR: Disconnecting; received message for unknown session: {Message}", msg);
                    DisconnectClient();
                    return;
                }

                if (_qfSession.HasResponder)
                {
                    _qfSession.Log.Log(LogLevel.Information, LogEventIds.IncomingMessage, "{Message}", msg);
                    _qfSession.Log.Log(LogLevel.Error,
                        "Multiple logons/connections for this session are not allowed ({Endpoint})",
                        _tcpClient.Client.RemoteEndPoint);
                    _qfSession = null;
                    DisconnectClient();
                    return;
                }

                _qfSession.Log.Log(LogLevel.Debug,
                    "{SessionId} Socket Reader {ReaderId} accepting session {AcceptedSessionId} from {Endpoint}",
                    _qfSession.SessionID, GetHashCode(), _qfSession.SessionID, _tcpClient.Client.RemoteEndPoint);
                _qfSession.SetResponder(_responder);
            }

            try
            {
                _qfSession.Next(msg);
            }
            catch (Exception e)
            {
                _qfSession.Log.Log(LogLevel.Error, e, "Error on Session '{SessionId}': {Exception}",
                    _qfSession.SessionID, e);
            }
        }
        /*
         * TODO: Are these catches reachable?  I don't think they are!
         *       The only line that could throw them is _qfSession.Next above,
         *       but it has its own catch.
         */
        catch (InvalidMessage e)
        {
            HandleBadMessage(msg, e);
        }
        catch (MessageParseError e)
        {
            HandleBadMessage(msg, e);
        }
    }

    protected void HandleBadMessage(string msg, Exception e)
    {
        try
        {
            if (Fields.MsgType.LOGON.Equals(Message.GetMsgType(msg)))
            {
                UnconditionalLogger.Log(LogLevel.Error, e, "ERROR: Invalid LOGON message, disconnecting: {Message}",
                    e.Message);
                DisconnectClient();
            }
            else
            {
                UnconditionalLogger.Log(LogLevel.Error, e, "ERROR: Invalid message: {Message}", e.Message);
            }
        }
        catch (InvalidMessage)
        { }
    }

    protected bool ReadMessage(out string msg)
    {
        try
        {
            return _parser.ReadFixMessage(out msg);
        }
        catch (MessageParseError)
        {
            msg = "";
            throw;
        }
    }

    protected void ProcessStream()
    {
        while (ReadMessage(out var msg))
            OnMessageFound(msg);
    }

    protected void DisconnectClient()
    {
        Dispose();
    }

    private bool IsUnknownSession(SessionID sessionId)
    {
        return _acceptorDescriptor is not null
            && !_acceptorDescriptor.GetAcceptedSessions().Any(kv => kv.Key.Equals(sessionId));
    }

    private void HandleExceptionInternal(Session? quickFixSession, Exception cause) {
        bool disconnectNeeded = false;

        Exception realCause = cause;

        // Unwrap socket exceptions from IOException in order for code below to work
        if (realCause is IOException && realCause.InnerException is SocketException)
            realCause = realCause.InnerException;

        string? reason;
        switch (realCause) {
            case SocketException:
            {
                if (quickFixSession is not null && quickFixSession.IsEnabled)
                    reason = "Socket exception (" + _tcpClient.Client.RemoteEndPoint + "): " + cause.Message;
                else
                    reason = "Socket (" + _tcpClient.Client.RemoteEndPoint + "): " + cause.Message;
                disconnectNeeded = true;
                break;
            }
            case MessageParseError:
            {
                reason = "Protocol handler exception: " + cause;
                if (quickFixSession is null)
                    disconnectNeeded = true;
                break;
            }
            default:
                reason = cause.ToString();
                break;
        }

        UnconditionalLogger.Log(LogLevel.Error, realCause, "SocketReader Error: {Reason}", reason);

        if (disconnectNeeded)
        {
            if (quickFixSession is not null && quickFixSession.HasResponder)
                quickFixSession.Disconnect(reason);
            else
                DisconnectClient();
        }
    }

    public int Send(string data)
    {
        using ValueDisposable _ = CharEncoding.GetBytes(data, out ReadOnlySpan<byte> rawData);
        _stream.Write(rawData);

        return rawData.Length;
    }

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
            _readCancellationTokenSource.Cancel();
            _readCancellationTokenSource.Dispose();

            // just wait when read task will be cancelled
            _currentReadTask?.ContinueWith(_ => { }).Wait(1000);
            _currentReadTask?.Dispose();

            _stream.Dispose();
            _tcpClient.Close();
        }
        _disposed = true;
    }
    ~SocketReader() => Dispose(false);
}

