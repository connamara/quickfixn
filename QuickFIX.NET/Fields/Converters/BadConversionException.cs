using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET.Fields.Converters
{
    /// <summary>
    /// Thrown when a bad conversion occurs
    /// </summary>
    public class BadConversionException : ApplicationException
    {
        public BadConversionException() {}
        public BadConversionException(string message) 
            :base(message) {}
        public BadConversionException(string message, System.Exception inner) 
            :base(message,inner) {}
        protected BadConversionException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) {}
    }
}
