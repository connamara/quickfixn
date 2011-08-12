
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
    /// Not a known message type
    /// </summary>
    public class InvalidMessageType : QuickFIXException
    {
        string msgType = "";

        public InvalidMessageType()
            : base("Invalid Message Type")
        { }

        public InvalidMessageType(string msgType)
            : base("Invalid Message Type")
        {
            this.msgType = msgType;
        }
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

    #region Tag Exceptions

    /// <summary>
    /// Base class for tag-related errors
    /// </summary>
    public abstract class TagException : QuickFIXException
    {
        public int field;
        public FixValues.SessionRejectReason sessionRejectReason;

        public TagException(string msg, int field)
            : base(msg)
        {
            this.field = field;
            this.sessionRejectReason = new QuickFix.FixValues.SessionRejectReason(FixValues.SessionRejectReason.OTHER.Value, msg);
        }
        public TagException(int field, FixValues.SessionRejectReason reason)
            : base(reason.Description)
        {
            this.field = field;
            this.sessionRejectReason = reason;
        }
    }
    /// <summary>
    /// Tag is not in the correct order
    /// </summary>
    public class TagOutOfOrder : TagException
    {
        public TagOutOfOrder(int field) : base(field, FixValues.SessionRejectReason.TAG_SPECIFIED_OUT_OF_REQUIRED_ORDER) { }
    }
    /// <summary>
    /// Tag number does not exist in specification
    /// </summary>
    public class InvalidTagNumber : TagException
    {
        public InvalidTagNumber(int field) : base(field, FixValues.SessionRejectReason.INVALID_TAG_NUMBER) { }
    }
    /// <summary>
    /// Required field is not in message
    /// </summary>
    public class RequiredTagMissing : TagException
    {
        public RequiredTagMissing(int field) : base(field, FixValues.SessionRejectReason.REQUIRED_TAG_MISSING) { }
    }
    /// <summary>
    /// Field does not belong to message
    /// </summary>
    public class TagNotDefinedForMessage : TagException
    {
        public TagNotDefinedForMessage(int field) : base(field, FixValues.SessionRejectReason.TAG_NOT_DEFINED_FOR_THIS_MESSAGE_TYPE) { }
    }
    /// <summary>
    /// Field exists in message without a value
    /// </summary>
    public class NoTagValue : TagException
    {
        public NoTagValue(int field) : base(field, FixValues.SessionRejectReason.TAG_SPECIFIED_WITHOUT_A_VALUE) { }
    }
    /// <summary>
    /// Field has a value that is out of range
    /// </summary>
    public class IncorrectTagValue : TagException
    {
        public IncorrectTagValue(int field) : base(field, FixValues.SessionRejectReason.VALUE_IS_INCORRECT) { }
    }
    /// <summary>
    /// Repeated tag not part of repeating group
    /// </summary>
    public class RepeatedTag : TagException
    {
        public RepeatedTag(int field) : base(field, FixValues.SessionRejectReason.TAG_APPEARS_MORE_THAN_ONCE) { }
    }
    #endregion
}
