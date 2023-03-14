using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix.Fields
{
    /// <summary>
    /// An integer message field
    /// </summary>
    public class SequenceField : FieldBase<ulong>
    {
        public SequenceField(int tag)
            : base(tag, 0) { }

        public SequenceField(int tag, ulong val)
            : base(tag, val) {}

        // quickfix compat
        public ulong getValue()
        { return Obj; }

        public void setValue(ulong v)
        { Obj = v; }

        protected override string makeString()
        {
            return Converters.SequenceConverter.Convert(Obj);
        }
    }
}
