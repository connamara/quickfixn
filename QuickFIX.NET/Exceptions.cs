
namespace QuickFIX.NET
{
    class QuickFIXException : System.Exception
    {
        public QuickFIXException(string msg)
            : base(msg)
        { }
    }

    /// <summary>
    /// Application is not configured correctly
    /// </summary>
    class ConfigError : QuickFIXException
    {
        public ConfigError(string msg)
            : base("Configuration failed: " + msg)
        { }
    }

    /// <summary>
    /// Unable to convert field into its native format
    /// </summary>
    class FieldConvertError : QuickFIXException
    {
        public FieldConvertError(string msg)
            : base("Could not convert field: " + msg)
        { }
    }
}
