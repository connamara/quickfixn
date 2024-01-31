#nullable enable
using System.Net.Sockets;
using System.IO;
using System;
using System.Linq;

namespace QuickFix
{
    /// <summary>
    /// TODO merge with SocketInitiatorThread
    /// </summary>
    public class SocketReader : IDisposable
    {
        public const int BUF_SIZE = 4096;
        private readonly byte[] _readBuffer = new byte[BUF_SIZE];
        private readonly Parser _parser = new();
        private Session? _qfSession; //will be null when initialized
        private readonly Stream _stream;
        private readonly TcpClient _tcpClient;
        private readonly ClientHandlerThread _responder;
        private readonly AcceptorSocketDescriptor? _acceptorDescriptor;

        /// <summary>
        /// Keep a handle to the current outstanding read request (if any)
        /// </summary>
        private IAsyncResult? _currentReadRequest;

        internal SocketReader(
            TcpClient tcpClient,
            SocketSettings settings,
            ClientHandlerThread responder,
            AcceptorSocketDescriptor? acceptorDescriptor)
        {
            _tcpClient = tcpClient;
            _responder = responder;
            _acceptorDescriptor = acceptorDescriptor;
            _stream = Transport.StreamFactory.CreateServerStream(tcpClient, settings, responder.GetLog());
        }

        public void Read()
        {
            try
            {
                int bytesRead = ReadSome(_readBuffer, 1000);
                if (bytesRead > 0)
                    _parser.AddToStream(_readBuffer, bytesRead);
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
            // NOTE: THIS FUNCTION IS EXACTLY THE SAME AS THE ONE IN SocketInitiatorThread.
            // Any changes made here should also be made there.
            try
            {
                // Begin read if it is not already started
                _currentReadRequest ??= _stream.BeginRead(buffer, 0, buffer.Length, null, null);

                // Wait for it to complete (given timeout)
                _currentReadRequest.AsyncWaitHandle.WaitOne(timeoutMilliseconds);

                if (_currentReadRequest.IsCompleted)
                {
                    // Make sure to set _currentReadRequest to before retreiving result
                    // so a new read can be started next time even if an exception is thrown
                    var request = _currentReadRequest;
                    _currentReadRequest = null;

                    int bytesRead = _stream.EndRead(request);
                    if (0 == bytesRead)
                        throw new SocketException(System.Convert.ToInt32(SocketError.Shutdown));

                    return bytesRead;
                }

                return 0;
            }
            catch (IOException ex) // Timeout
            {
                var inner = ex.InnerException as SocketException;
                if (inner?.SocketErrorCode == SocketError.TimedOut)
                {
                    // Nothing read 
                    return 0;
                }
                else if (inner is not null)
                {
                    throw inner; //rethrow SocketException part (which we have exception logic for)
                }
                else
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
                    if (_qfSession is null || IsAssumedSession(_qfSession.SessionID))
                    {
                        Log("ERROR: Disconnecting; received message for unknown session: " + msg);
                        _qfSession = null;
                        DisconnectClient();
                        return;
                    }

                    if (_qfSession.HasResponder)
                    {
                        _qfSession.Log.OnIncoming(msg);
                        _qfSession.Log.OnEvent("Multiple logons/connections for this session are not allowed (" + _tcpClient.Client.RemoteEndPoint + ")");
                        _qfSession = null;
                        DisconnectClient();
                        return;
                    }

                    _qfSession.Log.OnEvent(_qfSession.SessionID + " Socket Reader " + GetHashCode() + " accepting session " + _qfSession.SessionID + " from " + _tcpClient.Client.RemoteEndPoint);
                    _qfSession.SetResponder(_responder);
                }

                try
                {
                    _qfSession.Next(msg);
                }
                catch (Exception e)
                {
                    Log($"Error on Session '{_qfSession.SessionID}': {e}");
                }
            }
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
                    Log("ERROR: Invalid LOGON message, disconnecting: " + e.Message);
                    DisconnectClient();
                }
                else
                {
                    Log("ERROR: Invalid message: " + e.Message);
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
            _stream.Close();
            _tcpClient.Close();
        }

        private bool IsAssumedSession(SessionID sessionId)
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

            Log($"SocketReader Error: {reason}");

            if (disconnectNeeded)
            {
                if (quickFixSession is not null && quickFixSession.HasResponder)
                    quickFixSession.Disconnect(reason);
                else
                    DisconnectClient();
            }
        }

        /// <summary>
        /// FIXME do proper logging
        /// </summary>
        /// <param name="s"></param>
        private void Log(string s)
        {
            _responder.Log(s);
        }

        public int Send(string data)
        {
            byte[] rawData = CharEncoding.DefaultEncoding.GetBytes(data);
            _stream.Write(rawData, 0, rawData.Length);
            return rawData.Length;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _stream.Dispose();
                _tcpClient.Close();
            }
        }
        ~SocketReader() => Dispose(false);
    }
}
