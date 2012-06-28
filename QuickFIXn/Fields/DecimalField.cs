using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix.Fields
{
    /// <summary>
    /// A decimal FIX field
    /// </summary>
    public class DecimalField : FieldBase<Decimal>
    {
        public DecimalField(int tag)
            : base(tag, new Decimal(0.0)) {}

        public DecimalField(int tag, Decimal val)
            : base(tag, val) { }

        // quickfix compat
        public Decimal getValue()
        { return Obj; }

        public void setValue(Decimal d)
        { Obj = d; }

        protected override string makeString()
        {
            return Converters.DecimalConverter.Convert(Obj);
        }
    }
}
