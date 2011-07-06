using System.Net.Sockets;

namespace QuickFix
{
    public class SocketReader
    {
        public const int BUF_SIZE = 4096;
        private byte[] buf_ = new byte[BUF_SIZE];
        private Session qfSession_ = null;
        private TcpClient tcpClient_;
        private NetworkStream tcpClientStream_;
        private Responder responder_;

        public SocketReader(TcpClient tcpClient, Responder responder)
        {
            tcpClient_ = tcpClient;
            tcpClientStream_ = tcpClient_.GetStream();
            responder_ = responder;
        }

        /// <summary>
        /// FIXME
        /// </summary>
        public void Read()
        {
            try
            {
                int bytesRead = tcpClientStream_.Read(buf_, 0, BUF_SIZE);
                if (0 == bytesRead)
                    throw new ConnectionResetByPeerException();
                OnMessageFound(System.Text.Encoding.UTF8.GetString(buf_, 0, bytesRead));
            }
            catch (System.Exception e)
            {
                HandleException(qfSession_, e, tcpClient_);
                throw e;
            }
        }

        public void OnMessageFound(string msg)
        {
            try
            {
                Message fixMessage = new Message(msg);

                if (null == qfSession_)
                {
                    qfSession_ = Session.LookupSession(Message.GetReverseSessionID(msg));
                    if (null == qfSession_)
                    {
                        this.Log("ERROR: Disconnecting; received message for unknown session: " + fixMessage.ToString());
                        tcpClient_.Close();
                        return;
                    }
                    else
                    {
                        if (!HandleNewSession(fixMessage))
                            return;
                    }
                }

                try
                {
                    qfSession_.Log.OnIncoming(fixMessage.ToString());
                    qfSession_.Next(fixMessage);
                }
                catch (System.Exception e)
                {
                    this.Log("Error on Session '" + qfSession_.SessionID + "': " + e.Message);
                }
            }
            catch(InvalidMessage e) 
            {
                try
                {
	                if("A".Equals(Message.GetMsgType(msg))) 
	                {
		                this.Log("ERROR: Invalid LOGON message, disconnecting: " + e.Message);
		                tcpClient_.Close();
	                }
	                else
	                {
		                this.Log("ERROR: Invalid message: " + e.Message);
	                }
                }
                catch(InvalidMessage)
                { }
            }
        }

        protected bool HandleNewSession(Message message)
	    {
		    try
		    {
			    if(!"A".Equals(message.Header.GetField(Fields.Tags.MsgType)))
			    {
				    this.Log("WARNING: Ignoring non-logon message before session establishment: " + message);
				    return false;
			    }
    	
			    if(qfSession_.HasResponder)
			    {
				    qfSession_.Log.OnEvent("Multiple logons/connections for this session are not allowed");
				    qfSession_ = null;
				    tcpClient_.Close();
				    return false;
			    }
			    qfSession_.Log.OnEvent(qfSession_.SessionID + " Socket Reader " + GetHashCode() + " accepting session " + qfSession_.SessionID + " from " + tcpClient_.Client.RemoteEndPoint);
                //qfSession_.HeartBtInt = QuickFix.Fields.Converters.IntConverter.Convert(message.GetField(Fields.Tags.HeartBtInt)); /// FIXME
			    qfSession_.Log.OnEvent(qfSession_.SessionID +" Acceptor heartbeat set to " + qfSession_.HeartBtInt + " seconds");
			    qfSession_.Responder = responder_;
			    return true;
		    }
		    catch(QuickFix.FieldNotFoundException e)
		    {
			    throw new InvalidMessage(e.Message, e);
		    }
	    }


        public void HandleException(Session quickFixSession, System.Exception cause, TcpClient client)
        {
            bool disconnectNeeded = true;
            string reason = cause.Message;

            /* TODO
            System.Exception realCause = cause;
            if(cause is FIXMessageDecoder.DecodeError && cause.getCause() != null)
                realCause = cause.getCause();

            if(realCause is System.IO.IOException)
            {
                if (quickFixSession != null && quickFixSession.IsEnabled)
                    reason = "Socket exception (" + client.Client.RemoteEndPoint + "): " + cause;
                else
                    reason = "Socket (" + client.Client.RemoteEndPoint + "): " + cause;
                disconnectNeeded = true;
            }
            else if(realCause is FIXMessageDecoder.CriticalDecodeError)
            {
                reason = "Critical protocol codec error: " + cause;
                disconnectNeeded = true;
            }
            else if(realCause is FIXMessageDecoder.DecodeError)
            {
                reason = "Protocol handler exception: " + cause;
                disconnectNeeded = false
            }
            else
            {
                reason = cause.ToString();
                disconnectNeeded = false
            }
            */

            this.Log("ERROR: " + reason);

            if (disconnectNeeded)
            {
                if (null != quickFixSession && quickFixSession.HasResponder)
                    quickFixSession.Disconnect(reason);
                else
                    client.Close();
            }
        }


        /// <summary>
        /// FIXME do proper logging
        /// </summary>
        /// <param name="s"></param>
        private void Log(string s)
        {
            System.Console.WriteLine(s);
        }
    }
}