using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET.Fields
{
    public class BooleanField : FieldBase<Boolean>
    {
        /// <summary>
        /// FIX boolean field
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="b"></param>
        public BooleanField(int tag, Boolean b)
            : base(tag, b) { }

        // quickfix compat
        public Boolean getValue()
        { return Obj; }

        public void setValue(Boolean b)
        { Obj = b; }

        protected override string makeString()
        {
            return Converters.BoolConverter.Convert(Obj);
        }
    }
}
