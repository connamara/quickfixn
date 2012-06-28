using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public class InvalidMessageTypeException : ApplicationException
    {
        public InvalidMessageTypeException() { }
        public InvalidMessageTypeException(string message)
            : base(message) { }
        public InvalidMessageTypeException(string message, System.Exception inner)
            : base(message, inner) { }
        protected InvalidMessageTypeException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
