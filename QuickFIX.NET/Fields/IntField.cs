using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFIX.NET.Fields
{
    public class IntField : FieldBase<int>
    {
        public IntField(int tag, int val)
            : base(tag, val) {}

        // quickfix compat
        public int getValue()
        { return Obj; }

        public void setValue(int v)
        { Obj = v; }

        protected override string makeString()
        {
            return Converters.IntConverter.Convert(Obj);
        }
    }
}
