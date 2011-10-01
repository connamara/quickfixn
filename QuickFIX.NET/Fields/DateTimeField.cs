using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Fields
{
    public class DateTimeField : FieldBase<DateTime>
    {
        private readonly bool showMilliseconds = true;
        public DateTimeField(int tag)
            : base(tag, new DateTime()) {}

        public DateTimeField(int tag, DateTime dt)
            : base(tag, dt) {}

        public DateTimeField(int tag, DateTime dt, bool showMilliseconds)
            : base(tag, dt) { this.showMilliseconds = showMilliseconds; }

        // quickfix compat
        public DateTime getValue()
        { return Obj; }

        public void setValue(DateTime dt)
        { Obj = dt; }

        protected override string makeString()
        {
            return Converters.DateTimeConverter.Convert(Obj, showMilliseconds);
        }
    }
}
