using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System;
using System.Diagnostics;

namespace QuickFix
{
    /// <summary>
    /// Handles a connection with an acceptor.
    /// </summary>
    public class SocketInitiatorThread : IResponder
    {
        public Session Session { get { return session_; } }
        public Transport.SocketInitiator Initiator { get { return initiator_; } }

        public const int BUF_SIZE = 512;

        private Thread thread_ = null;
        private byte[] readBuffer_ = new byte[BUF_SIZE];
        private Parser parser_;
        protected Stream stream_;
        private Transport.SocketInitiator initiator_;
        private Session session_;
        private IPEndPoint socketEndPoint_;
        protected SocketSettings socketSettings_;
        private bool isDisconnectRequested_ = false;

        public SocketInitiatorThread(Transport.SocketInitiator initiator, Session session, IPEndPoint socketEndPoint, SocketSettings socketSettings)
        {
            isDisconnectRequested_ = false;
            initiator_ = initiator;
            session_ = session;
            socketEndPoint_ = socketEndPoint;
            parser_ = new Parser(socketSettings.Encoding);
            session_ = session;
            socketSettings_ = socketSettings;
        }

        public void Start()
        {
            isDisconnectRequested_ = false;
            thread_ = new Thread(new ParameterizedThreadStart(Transport.SocketInitiator.SocketInitiatorThreadStart));
            thread_.Start(this);
        }

        public void Join()
        {
            if (null == thread_)
                return;
            Disconnect();
            // Make sure session's socket reader thread doesn't try to do a Join on itself!
            if (Thread.CurrentThread.ManagedThreadId != thread_.ManagedThreadId)
                thread_.Join(2000);
            thread_ = null;
        }

        public void Connect()
        {
            Debug.Assert(stream_ == null);

            stream_ = SetupStream();
            session_.SetResponder(this);
        }

        /// <summary>
        /// Setup/Connect to the other party.
        /// Override this in order to setup other types of streams with other settings
        /// </summary>
        /// <returns>Stream representing the (network)connection to the other party</returns>
        protected virtual Stream SetupStream()
        {
            return QuickFix.Transport.StreamFactory.CreateClientStream(socketEndPoint_, socketSettings_, session_.Log);
        }


        public bool Read()
        {
            try
            {
                int bytesRead = ReadSome(readBuffer_, 1000);
                if (bytesRead > 0)
                    parser_.AddToStream(socketSettings_.Encoding.GetString(readBuffer_, 0, bytesRead));
                else if (null != session_)
                {
                    session_.Next();
                }
                else
                {
                    throw new QuickFIXException("Initiator timed out while reading socket");
                }

                ProcessStream();
                return true;
            }
            catch (System.ObjectDisposedException e)
            {
                // this exception means socket_ is already closed when poll() is called
                if (isDisconnectRequested_ == false)
                {
                    // for lack of a better idea, do what the general exception does
                    if (null != session_)
                        session_.Disconnect(e.ToString());
                    else
                        Disconnect();
                }
                return false;                    
            }
            catch (System.Exception e)
            {
                if (null != session_)
                    session_.Disconnect(e.ToString());
                else
                    Disconnect();
            }
            return false;
        }

        /// <summary>
        /// Keep a handle to the current outstanding read request (if any)
        /// </summary>
        private IAsyncResult currentReadRequest_;
        /// <summary>
        /// Reads data from the network into the specified buffer.
        /// It will wait up to the specified number of milliseconds for data to arrive,
        /// if no data has arrived after the specified number of milliseconds then the function returns 0
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="timeoutMilliseconds">The timeout milliseconds.</param>
        /// <returns>The number of bytes read into the buffer</returns>
        /// <exception cref="System.Net.Sockets.SocketException">On connection reset</exception>
        protected int ReadSome(byte[] buffer, int timeoutMilliseconds)
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

        private void ProcessStream()
        {
            string msg;
            while (parser_.ReadFixMessage(out msg))
            {
                session_.Next(msg);
            }
        }

        #region Responder Members

        public bool Send(string data)
        {
            byte[] rawData = socketSettings_.Encoding.GetBytes(data);
            stream_.Write(rawData, 0, rawData.Length);
            return true;
        }

        public void Disconnect()
        {
            isDisconnectRequested_ = true;
            if (stream_ != null)
                stream_.Close();
        }

        #endregion
    }
}
