using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix.Fields
{
    /// <summary>
    /// An integer message field
    /// </summary>
    public class IntField : FieldBase<int>
    {
        public IntField(int tag)
            : base(tag, 0) { }

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
