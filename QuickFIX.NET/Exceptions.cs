
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
}
