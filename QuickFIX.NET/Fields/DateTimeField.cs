using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Fields
{
    public class DateTimeField : FieldBase<DateTime>
    {
        public DateTimeField(int tag)
            :base(tag, new DateTime()) {}

        public DateTimeField(int tag, DateTime dt)
            : base(tag, dt) { }

        // quickfix compat
        public DateTime getValue()
        { return Obj; }

        public void setValue(DateTime dt)
        { Obj = dt; }

        protected override string makeString()
        {
            return Converters.DateTimeConverter.Convert(Obj);
        }
    }
}
