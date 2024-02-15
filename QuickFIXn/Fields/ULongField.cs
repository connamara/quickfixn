using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix.Fields
{
    /// <summary>
    /// A ulong (System.UInt64) message field
    /// </summary>
    public class ULongField: FieldBase<ulong>
    {
        public ULongField(int tag)
            : base(tag, 0L) { }

        public ULongField(int tag, ulong val)
            : base(tag, val) {}

        // quickfix compat
        public ulong getValue()
        { return Obj; }

        public void setValue(ulong v)
        { Obj = v; }

        protected override string makeString()
        {
            return Converters.ULongConverter.Convert(Obj);
        }
    }
}
