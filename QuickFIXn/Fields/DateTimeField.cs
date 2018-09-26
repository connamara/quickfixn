using System;
using QuickFix.Fields.Converters;

namespace QuickFix.Fields
{
    public class DateTimeField : FieldBase<DateTime>
    {
        protected readonly TimeStampPrecision timePrecision = TimeStampPrecision.Millisecond;
        public DateTimeField(int tag)
            : base(tag, new DateTime()) {}

        public DateTimeField(int tag, DateTime dt)
            : base(tag, dt) {}

        public DateTimeField(int tag, DateTime dt, bool showMilliseconds)
            : this(tag, dt, showMilliseconds ? TimeStampPrecision.Millisecond : TimeStampPrecision.Second ) { }

        public DateTimeField(int tag, DateTime dt, TimeStampPrecision timeFormatPrecision)
            : base(tag, dt )
        {
            timePrecision = timeFormatPrecision;
        }


        // quickfix compat
        public DateTime getValue()
        { return Obj; }

        public void setValue(DateTime dt)
        { Obj = dt; }

        protected override string makeString()
        {
            return Converters.DateTimeConverter.Convert(Obj, timePrecision);
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

        public DateOnlyField(int tag, DateTime dt, TimeStampPrecision timeFormatPrecision)
    : base(tag, dt, timeFormatPrecision) { }

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

        public TimeOnlyField(int tag, DateTime dt, TimeStampPrecision timeFormatPrecision)
            : base(tag, dt, timeFormatPrecision) { }

        protected override string makeString()
        {
            return Converters.DateTimeConverter.ConvertTimeOnly(Obj, base.timePrecision); 
        }
    }
}
