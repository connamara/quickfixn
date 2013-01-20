using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

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
            parser_ = new Parser();
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
            thread_.Join(5000);
            thread_ = null;
        }

        public void Connect()
        {
            stream_ = SetupStream();
            session_.SetResponder(this);
        }

        /// <summary>
        /// Setups/Connect to the other party.
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
                stream_.ReadTimeout = 1000; // one-second timeout
                int maxCount = readBuffer_.Length;

                try
                {
                    int bytesRead = stream_.Read(readBuffer_, 0, maxCount);
                    if (0 == bytesRead)
                        throw new SocketException(System.Convert.ToInt32(SocketError.ConnectionReset));
                    parser_.AddToStream(System.Text.Encoding.UTF8.GetString(readBuffer_, 0, bytesRead));
                }
                catch (System.IO.IOException ex) // Timeout
                {
                    var inner = ex.InnerException as SocketException;
                    if (null != session_ && inner != null && inner.SocketErrorCode == SocketError.TimedOut)
                    {
                        session_.Next();
                    }
                    else
                    {
                        throw new QuickFIXException("Initiator timed out while reading socket", ex);
                    }
                }
            
                ProcessStream();
                return true;
            }
            catch(System.ObjectDisposedException e)
            {
                // this exception means socket_ is already closed when poll() is called
                if(isDisconnectRequested_==false)
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
                return false;
            }
        }

        private void ProcessStream()
        {
            string msg;
            while (parser_.ReadFixMessage(out msg))
                session_.Next(msg);
        }

        #region Responder Members

        public bool Send(string data)
        {
            byte[] rawData = System.Text.Encoding.UTF8.GetBytes(data);
            stream_.Write(rawData, 0, rawData.Length);
            return true;
        }

        public void Disconnect()
        {
            isDisconnectRequested_ = true;
            stream_.Close();
        }

        #endregion
    }
}
