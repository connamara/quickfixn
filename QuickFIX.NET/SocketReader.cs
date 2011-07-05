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
            int bytesRead = tcpClientStream_.Read(buf_, 0, BUF_SIZE);
            if (0 == bytesRead)
                throw new ConnectionResetByPeerException();
            OnMessageFound(System.Text.Encoding.UTF8.GetString(buf_, 0, bytesRead));
        }

        public void OnMessageFound(string msg)
        {
            Message fixMessage = null;

            try
            {
                if (null != qfSession_)
                {
                    System.Console.WriteLine("SocketReader.OnMessageFound: " + msg.ToString());
                }
                else
                {
                    qfSession_ = Session.LookupSession(Message.GetReverseSessionID(msg));
                    if (null == qfSession_)
                    {
                        this.Log("ERROR: Disconnecting; received message for unknown session: " + msg.ToString());
                        tcpClient_.Close();
                        return;
                    }

                    qfSession_.Log.OnIncoming(msg.ToString());
                    fixMessage = new Message(msg);

                    if (!HandleNewSession(fixMessage))
                        return;
                }

                try
                {
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
                qfSession_.HeartBtInt = QuickFix.Fields.Converters.IntConverter.Convert(message.GetField(Fields.Tags.HeartBtInt)); /// FIXME
			    qfSession_.Log.OnEvent(qfSession_.SessionID +" Acceptor heartbeat set to " + qfSession_.HeartBtInt + " seconds");
			    qfSession_.Responder = responder_;
			    return true;
		    }
		    catch(QuickFix.FieldNotFoundException e)
		    {
			    throw new InvalidMessage(e.Message, e);
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