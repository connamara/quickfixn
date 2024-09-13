using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 0628 // Suppress "new protected member declared in sealed class" warning.

namespace QuickFix
{
    [Obsolete("This class will be removed in a future release (because it's unused)")]
    public sealed class MissingRequiredFieldException : ApplicationException
    {
        [Obsolete("This class will be removed in a future release (because it's unused)")]
        public MissingRequiredFieldException() { }

        [Obsolete("This class will be removed in a future release (because it's unused)")]
        public MissingRequiredFieldException(int field)
            : base("Missing required field: " + field.ToString()) { }

        [Obsolete("This class will be removed in a future release (because it's unused)")]
        public MissingRequiredFieldException(string message)
            : base(message) { }

        [Obsolete("This class will be removed in a future release (because it's unused)")]
        public MissingRequiredFieldException(string message, System.Exception inner)
            : base(message, inner) { }
    }
}
