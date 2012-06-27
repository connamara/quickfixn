using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public class DictionaryParseException : ApplicationException
    {
        public DictionaryParseException() { }
        public DictionaryParseException(string message)
            : base(message) { }
        public DictionaryParseException(string message, System.Exception inner)
            : base(message, inner) { }
        protected DictionaryParseException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
