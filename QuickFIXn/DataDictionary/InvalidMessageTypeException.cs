using System;

namespace QuickFix
{
    [Obsolete("This class will be removed in a future release (because it's unused)")]
    public class InvalidMessageTypeException : ApplicationException
    {
        [Obsolete("This class will be removed in a future release (because it's unused)")]
        public InvalidMessageTypeException() { }

        [Obsolete("This class will be removed in a future release (because it's unused)")]
        public InvalidMessageTypeException(string message)
            : base(message) { }

        [Obsolete("This class will be removed in a future release (because it's unused)")]
        public InvalidMessageTypeException(string message, System.Exception inner)
            : base(message, inner) { }
    }
}
