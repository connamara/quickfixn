using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 0628 // Suppress "new protected member declared in sealed class" warning.

namespace QuickFix
{
    public sealed class MissingRequiredFieldException : ApplicationException
    {
        public MissingRequiredFieldException() { }
        public MissingRequiredFieldException(int field)
            : base("Missing required field: " + field.ToString()) { }
        public MissingRequiredFieldException(string message)
            : base(message) { }
        public MissingRequiredFieldException(string message, System.Exception inner)
            : base(message, inner) { }
        protected MissingRequiredFieldException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
