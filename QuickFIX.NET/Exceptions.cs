
namespace QuickFix
{
    public class QuickFIXException : System.Exception
    {
        public QuickFIXException(string msg)
            : base(msg)
        { }

        public QuickFIXException(string msg, System.Exception innerException)
            : base(msg, innerException)
        { }

        public QuickFIXException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        { }
    }

    /// <summary>
    /// Application is not configured correctly
    /// </summary>
    public class ConfigError : QuickFIXException
    {
        public ConfigError(string msg)
            : base("Configuration failed: " + msg)
        { }

        public ConfigError(string msg, System.Exception innerException)
            : base("Configuration failed: " + msg, innerException)
        { }
    }

    /// <summary>
    /// Unable to convert field into its native format
    /// </summary>
    public class FieldConvertError : QuickFIXException
    {
        public FieldConvertError(string msg)
            : base("Could not convert field: " + msg)
        { }

        public FieldConvertError(string msg, System.Exception innerException)
            : base("Could not convert field: " + msg, innerException)
        { }
    }
    
    /// <summary>
    /// Session cannot be found for specified action
    /// </summary>
    public class SessionNotFound : QuickFIXException
    {
        public SessionNotFound(string msg)
            : base("Session Not Found: " + msg)
        { }

        public SessionNotFound(SessionID sessionID)
            : base("Session '" + sessionID + "' Not Found")
        { }

        public SessionNotFound(SessionID sessionID, string msg)
            : base("Session '" + sessionID + "' Not Found: " + msg)
        { }
    }

    /// <summary>
    /// Version of FIX is not supported
    /// </summary>
    public class UnsupportedVersion : QuickFIXException
    {
        public UnsupportedVersion()
            : base("Unsupported Version")
        { }

        public UnsupportedVersion(string msg)
            : base("Unsupported Version: " + msg)
        { }

        public UnsupportedVersion(string msg, System.Exception innerException) 
            : base("Unsupported Version: " + msg, innerException)
        { }
    }
    
    /// <summary>
    /// Not a recognizable message
    /// </summary>
    [System.Serializable]
    public class InvalidMessage : QuickFIXException
    {
        public InvalidMessage()
            : base("Invalid message")
        { }

        public InvalidMessage(string msg)
            : base("Invalid message: " + msg)
        { }

        public InvalidMessage(string msg, System.Exception innerException)
            : base("Invalid message: " + msg, innerException)
        { }

        public InvalidMessage(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        { }
    }

    /// <summary>
    /// Socket connection was reset by peer
    /// </summary>
    public class ConnectionResetByPeerException : QuickFIXException
    {
        public ConnectionResetByPeerException()
            : base("Connection reset by peer")
        { }

        public ConnectionResetByPeerException(System.Exception innerException)
            : base("Connection reset by peer", innerException)
        { }
    }

    public class MessageParseError : QuickFIXException
    {
        public MessageParseError()
            : base("Could not parse message")
        { }

        public MessageParseError(string msg)
            : base("Could not parse message: " + msg)
        { }

        public MessageParseError(string msg, System.Exception innerException)
            : base("Could not parse message: " + msg, innerException)
        { }
    }
}
