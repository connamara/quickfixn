using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFIX.NET
{
    public class MessageParseException : ApplicationException
    {
        public MessageParseException() { }
        public MessageParseException(string message)
            : base(message) { }
        public MessageParseException(string message, System.Exception inner)
            : base(message, inner) { }
        protected MessageParseException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
