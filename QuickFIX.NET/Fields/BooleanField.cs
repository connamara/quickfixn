using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET.Fields
{
    public class BooleanField : FieldBase<Boolean>
    {
        public BooleanField(int tag, Boolean b)
            : base(tag, b) { }

        // quickfix compat
        public Boolean getValue()
        { return Obj; }

        public void setValue(Boolean b)
        { Obj = b; }
    }
}
