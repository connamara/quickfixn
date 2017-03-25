using System.Net.Sockets;
using System.IO;
using System;
using System.Text;

namespace QuickFix
{

    /// <summary>
    /// TODO merge with SocketInitiatorThread
    /// </summary>
    public class SocketReader : IDisposable
    {
        public const int BUF_SIZE = 4096;
        byte[] readBuffer_ = new byte[BUF_SIZE];
        private Parser parser_;
        private Session qfSession_; //will be null when initialized
        private Stream stream_;     //will be null when initialized
        private TcpClient tcpClient_;
        private ClientHandlerThread responder_;
        private Encoding encoding_;

        /// <summary>
        /// Keep a handle to the current outstanding read request (if any)
        /// </summary>
        private IAsyncResult currentReadRequest_;

        [Obsolete("Use other constructor")]
        public SocketReader(TcpClient tcpClient, ClientHandlerThread responder)
            : this(tcpClient, new SocketSettings(), responder)
        {
        }

        public SocketReader(TcpClient tcpClient, SocketSettings settings, ClientHandlerThread responder)
        {
            parser_ = new Parser(settings.Encoding);
            encoding_ = settings.Encoding;
            tcpClient_ = tcpClient;
            responder_ = responder;
            stream_ = Transport.StreamFactory.CreateServerStream(tcpClient, settings, responder.GetLog());
        }

        /// <summary> FIXME </summary>
        public void Read()
        {
            try
            {
                int bytesRead = ReadSome(readBuffer_, 1000);
                if (bytesRead > 0)
                    parser_.AddToStream(encoding_.GetString(readBuffer_, 0, bytesRead));
                else if (null != qfSession_)
                {
                    qfSession_.Next();
                }

                ProcessStream();
            }
            catch (MessageParseError e)
            {
                HandleExceptionInternal(qfSession_, e);
            }
            catch (System.Exception e)
            {
                HandleExceptionInternal(qfSession_, e);
                throw e;
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
            // NOTE: THIS FUNCTION IS EXACTLY THE SAME AS THE ONE IN SocketReader any changes here should 
            // also be performed there
            try
            {
                // Begin read if it is not already started
                if (currentReadRequest_ == null)
                    currentReadRequest_ = stream_.BeginRead(buffer, 0, buffer.Length, null, null);

                // Wait for it to complete (given timeout)
                currentReadRequest_.AsyncWaitHandle.WaitOne(timeoutMilliseconds);

                if (currentReadRequest_.IsCompleted)
                {
                    // Make sure to set currentReadRequest_ to before retreiving result 
                    // so a new read can be started next time even if an exception is thrown
                    var request = currentReadRequest_;
                    currentReadRequest_ = null;

                    int bytesRead = stream_.EndRead(request);
                    if (0 == bytesRead)
                        throw new SocketException(System.Convert.ToInt32(SocketError.ConnectionReset));

                    return bytesRead;
                }
                else
                    return 0;
            }
            catch (System.IO.IOException ex) // Timeout
            {
                var inner = ex.InnerException as SocketException;
                if (inner != null && inner.SocketErrorCode == SocketError.TimedOut)
                {
                    // Nothing read 
                    return 0;
                }
                else if (inner != null)
                {
                    throw inner; //rethrow SocketException part (which we have exception logic for)
                }
                else
                    throw; //rethrow original exception
            }
        }

        [Obsolete("This should be made private")]
        public void OnMessageFound(string msg)
        {
            OnMessageFoundInternal(msg);
        }

        protected void OnMessageFoundInternal(string msg)
        {
            // Message fixMessage;

            try
            {
                if (null == qfSession_)
                {
                    qfSession_ = Session.LookupSession(Message.GetReverseSessionID(msg));
                    if (null == qfSession_)
                    {
                        this.Log("ERROR: Disconnecting; received message for unknown session: " + msg);
                        DisconnectClient();
                        return;
                    }
                    else
                    {
                        if (!HandleNewSession(msg))
                            return;
                    }
                }

                try
                {
                    qfSession_.Next(msg);
                }
                catch (System.Exception e)
                {
                    this.Log("Error on Session '" + qfSession_.SessionID + "': " + e.ToString());
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

        protected void HandleBadMessage(string msg, System.Exception e)
        {
            try
            {
                if (Fields.MsgType.LOGON.Equals(Message.GetMsgType(msg)))
                {
                    this.Log("ERROR: Invalid LOGON message, disconnecting: " + e.Message);
                    DisconnectClient();
                }
                else
                {
                    this.Log("ERROR: Invalid message: " + e.Message);
                }
            }
            catch (InvalidMessage)
            { }
        }

        protected bool ReadMessage(out string msg)
        {
            try
            {
                return parser_.ReadFixMessage(out msg);
            }
            catch (MessageParseError e)
            {
                msg = "";
                throw e;
            }
        }

        protected void ProcessStream()
        {
            string msg;
            while (ReadMessage(out msg))
                OnMessageFoundInternal(msg);
        }

        [Obsolete("Static function can't close stream properly")]
        protected static void DisconnectClient(TcpClient client)
        {
            client.Client.Close();
            client.Close();
        }

        protected void DisconnectClient()
        {
            stream_.Close();
            tcpClient_.Close();
        }

        protected bool HandleNewSession(string msg)
        {
            if (qfSession_.HasResponder)
            {
                qfSession_.Log.OnIncoming(msg);
                qfSession_.Log.OnEvent("Multiple logons/connections for this session are not allowed (" + tcpClient_.Client.RemoteEndPoint + ")");
                qfSession_ = null;
                DisconnectClient();
                return false;
            }
            qfSession_.Log.OnEvent(qfSession_.SessionID + " Socket Reader " + GetHashCode() + " accepting session " + qfSession_.SessionID + " from " + tcpClient_.Client.RemoteEndPoint);
            // FIXME do this here? qfSession_.HeartBtInt = QuickFix.Fields.Converters.IntConverter.Convert(message.GetField(Fields.Tags.HeartBtInt)); /// FIXME
            qfSession_.Log.OnEvent(qfSession_.SessionID + " Acceptor heartbeat set to " + qfSession_.HeartBtInt + " seconds");
            qfSession_.SetResponder(responder_);
            return true;
        }

        [Obsolete("This should be made private/protected")]
        public void HandleException(Session quickFixSession, System.Exception cause, TcpClient client)
        {
            HandleExceptionInternal(quickFixSession, cause);
        }

        private void HandleExceptionInternal(Session quickFixSession, System.Exception cause)
        {
            bool disconnectNeeded = true;
            string reason = cause.Message;

            System.Exception realCause = cause;

            // Unwrap socket exceptions from IOException in order for code below to work
            if (realCause is IOException && realCause.InnerException is SocketException)
                realCause = realCause.InnerException;

            /*
             TODO
            if(cause is FIXMessageDecoder.DecodeError && cause.InnerException != null)
                realCause = cause.getCause();
            */
            if (realCause is System.Net.Sockets.SocketException)
            {
                if (quickFixSession != null && quickFixSession.IsEnabled)
                    reason = "Socket exception (" + tcpClient_.Client.RemoteEndPoint + "): " + cause.Message;
                else
                    reason = "Socket (" + tcpClient_.Client.RemoteEndPoint + "): " + cause.Message;
                disconnectNeeded = true;
            }
            /*
             TODO
            else if(realCause is FIXMessageDecoder.CriticalDecodeError)
            {
                reason = "Critical protocol codec error: " + cause;
                disconnectNeeded = true;
            }
            */
            else if (realCause is MessageParseError)
            {
                reason = "Protocol handler exception: " + cause;
                if (quickFixSession == null)
                    disconnectNeeded = true;
                else
                    disconnectNeeded = false;
            }
            else
            {
                reason = cause.ToString();
                disconnectNeeded = false;
            }

            this.Log("SocketReader Error: " + reason);

            if (disconnectNeeded)
            {
                if (null != quickFixSession && quickFixSession.HasResponder)
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
            responder_.Log(s);
        }

        public int Send(string data)
        {
            byte[] rawData = encoding_.GetBytes(data);
            stream_.Write(rawData, 0, rawData.Length);
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
                stream_.Dispose();
                tcpClient_.Close();
            }
        }
    }
}
