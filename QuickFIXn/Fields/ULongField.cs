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

        protected override string MakeString()
        {
            return Converters.ULongConverter.Convert(Value);
        }
    }
}
