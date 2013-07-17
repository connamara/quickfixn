﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

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
        private Socket socket_;
        private Transport.SocketInitiator initiator_;
        private Session session_;
        private IPEndPoint socketEndPoint_;
        private bool isDisconnectRequested_ = false;

		/// <summary>
		/// The encoding to use for encoding outgoing and decode incoming FIX messages.
		/// </summary>
	    private readonly Encoding messageEncoding_;

		/// <summary>
		/// </summary>
		/// <param name="initiator"></param>
		/// <param name="session"></param>
		/// <param name="socketEndPoint"></param>
		/// <param name="socketSettings"></param>
		[Obsolete("Use the version that takes an encoding as well.")]
		public SocketInitiatorThread(Transport.SocketInitiator initiator, Session session, IPEndPoint socketEndPoint, SocketSettings socketSettings)
			: this(initiator, session, socketEndPoint, socketSettings, Encoding.UTF8)
		{
		}

		/// <summary>
		/// </summary>
		/// <param name="initiator"></param>
		/// <param name="session"></param>
		/// <param name="socketEndPoint"></param>
		/// <param name="socketSettings"></param>
		/// <param name="messageEncoding">The encoding to use for encoding outgoing and decoding incoming FIX messages.</param>
        public SocketInitiatorThread(Transport.SocketInitiator initiator, Session session, IPEndPoint socketEndPoint, SocketSettings socketSettings, Encoding messageEncoding)
        {
            isDisconnectRequested_ = false;
            initiator_ = initiator;
            session_ = session;
            socketEndPoint_ = socketEndPoint;
			parser_ = new Parser(messageEncoding);
            socket_ = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket_.NoDelay = socketSettings.SocketNodelay;
            session_ = session;
	        messageEncoding_ = messageEncoding;
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
            socket_.Connect(socketEndPoint_);
            session_.SetResponder(this);
        }

        public bool Read()
        {
            try
            {
                if (socket_.Poll(1000000, SelectMode.SelectRead)) // one-second timeout
                {
                    int bytesRead = socket_.Receive(readBuffer_);
                    if (0 == bytesRead)
                        throw new SocketException(System.Convert.ToInt32(SocketError.ConnectionReset));
                    parser_.AddToStream(ref readBuffer_, bytesRead);
                }
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
            byte[] rawData = messageEncoding_.GetBytes(data);
            int bytesSent = socket_.Send(rawData);
            return bytesSent > 0;
        }

        public void Disconnect()
        {
            isDisconnectRequested_ = true;
            socket_.Close();
        }

        #endregion
    }
}
