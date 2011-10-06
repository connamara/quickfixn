using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
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
