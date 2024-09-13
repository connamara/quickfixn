using System;

namespace QuickFix
{
    public class DictionaryParseException : ApplicationException
    {
        public DictionaryParseException() { }
        public DictionaryParseException(string message)
            : base(message) { }
        public DictionaryParseException(string message, System.Exception inner)
            : base(message, inner) { }
    }
}
