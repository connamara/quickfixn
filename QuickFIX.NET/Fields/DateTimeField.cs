using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET.Fields
{
    public class DateTimeField : FieldBase<FIXDateTime>
    {
        public DateTimeField(int tag, FIXDateTime dt)
            : base(tag, dt) { }

        // quickfix compat
        public FIXDateTime getValue()
        { return Obj; }

        public void setValue(FIXDateTime dt)
        { Obj = dt; }
    }
}
