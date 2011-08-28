using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    public class UnsupportedMessageType : Exception
    {
        public UnsupportedMessageType()
            : base()
        { }
    }
}
