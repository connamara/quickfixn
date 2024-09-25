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

        protected override string MakeString()
        {
            return Converters.DecimalConverter.Convert(Value);
        }
    }
}
