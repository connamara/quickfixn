using System.Net.Sockets;

namespace QuickFix
{
    /// <summary>
    /// TODO merge with SocketInitiatorThread
    /// </summary>
    public class SocketReader
    {
        public const int BUF_SIZE = 4096;
        private byte[] readBuffer_ = new byte[BUF_SIZE];
        private Session qfSession_ = null;
        private TcpClient tcpClient_;
        private Responder responder_;

        public SocketReader(TcpClient tcpClient, Responder responder)
        {
            tcpClient_ = tcpClient;
            responder_ = responder;
        }

        /// <summary>
        /// FIXME
        /// </summary>
        public void Read()
        {
            try
            {
                if (tcpClient_.Client.Poll(1000000, SelectMode.SelectRead)) // one-second timeout
                {
                    int bytesRead = tcpClient_.Client.Receive(readBuffer_);
                    if (0 == bytesRead)
                        throw new SocketException(System.Convert.ToInt32(SocketError.ConnectionReset));
                    OnMessageFound(System.Text.Encoding.UTF8.GetString(readBuffer_, 0, bytesRead));
                    //parser_.AddToStream(System.Text.Encoding.UTF8.GetString(readBuffer_, 0, bytesRead));
                }
                else if (null != qfSession_)
                {
                    qfSession_.Next();
                }

                //ProcessStream();
                //return true;
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
                        DisconnectClient();
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
                        DisconnectClient();
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

        protected void DisconnectClient()
        {
            tcpClient_.Client.Close();
            tcpClient_.Close();
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
                    DisconnectClient();
				    return false;
			    }
			    qfSession_.Log.OnEvent(qfSession_.SessionID + " Socket Reader " + GetHashCode() + " accepting session " + qfSession_.SessionID + " from " + tcpClient_.Client.RemoteEndPoint);
                //qfSession_.HeartBtInt = QuickFix.Fields.Converters.IntConverter.Convert(message.GetField(Fields.Tags.HeartBtInt)); /// FIXME
			    qfSession_.Log.OnEvent(qfSession_.SessionID +" Acceptor heartbeat set to " + qfSession_.HeartBtInt + " seconds");
			    qfSession_.SetResponder(responder_);
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