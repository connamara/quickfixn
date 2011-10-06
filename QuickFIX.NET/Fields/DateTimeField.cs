using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Fields
{
    public class DateTimeField : FieldBase<DateTime>
    {
        protected readonly bool showMilliseconds = true;
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

    public class DateOnlyField : DateTimeField
    {
        public DateOnlyField(int tag)
            : base(tag, new DateTime()) { }

        public DateOnlyField(int tag, DateTime dt)
            : base(tag, dt) { }

        public DateOnlyField(int tag, DateTime dt, bool showMilliseconds)
            : base(tag, dt, showMilliseconds) { }
        protected override string makeString()
        {
            return Converters.DateTimeConverter.ConvertDateOnly(Obj);
        }
    }

    public class TimeOnlyField : DateTimeField
    {
        public TimeOnlyField(int tag)
            : base(tag, new DateTime()) { }

        public TimeOnlyField(int tag, DateTime dt)
            : base(tag, dt) { }

        public TimeOnlyField(int tag, DateTime dt, bool showMilliseconds)
            : base(tag, dt, showMilliseconds) { }
        protected override string makeString()
        {
            return Converters.DateTimeConverter.ConvertTimeOnly(Obj, base.showMilliseconds); 
        }
    }
}
