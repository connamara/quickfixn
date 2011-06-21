using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public class FieldNotFoundException : ApplicationException
    {
        public FieldNotFoundException() { }

        public FieldNotFoundException(int tag)
            : base("field not found for tag: " + tag.ToString()) {}

        public FieldNotFoundException(string message)
            : base(message) { }

        public FieldNotFoundException(string message, System.Exception inner)
            : base(message, inner) { }

        protected FieldNotFoundException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
