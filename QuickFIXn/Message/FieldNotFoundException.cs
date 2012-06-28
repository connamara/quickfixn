using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// An exception thrown when a field is not found in a message. If you see 
    /// this exception, be sure you are accessing the field in the correct
    /// section of the message (for example, a header field in message.Header)
    /// </summary>
    public class FieldNotFoundException : ApplicationException
    {
        public int Field { get; set; }
        public FieldNotFoundException() { }

        public FieldNotFoundException(int tag)
            : base("field not found for tag: " + tag.ToString()) { this.Field = tag; }

        public FieldNotFoundException(string message)
            : base(message) { Field = -1; }

        public FieldNotFoundException(string message, System.Exception inner)
            : base(message, inner) { Field = -1; }

        protected FieldNotFoundException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
