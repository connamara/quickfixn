using System;
using QuickFix.Fields.Converters;

namespace QuickFix.Fields;

public class DateOnlyField : FieldBase<DateOnly>
{
    public DateOnlyField(int tag)
        : this(tag, new DateOnly()) { }

    public DateOnlyField(int tag, DateOnly dateOnly)
        : base(tag, dateOnly) { }

    /// <summary>
    /// This convert the dt parameter into a DateTime, losing any time info.
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="dt"></param>
    public DateOnlyField(int tag, DateTime dt)
        : this(tag, DateOnly.FromDateTime(dt)) { }

    protected override string MakeString()
    {
        return DateTimeConverter.ToFIXDateOnly(Value);
    }


    [Obsolete("This ctor will be removed in 1.16 because it's unused (and doesn't even make sense)")]
    public DateOnlyField(int tag, DateTime dt, bool showMilliseconds)
        : this(tag, dt) { }

    [Obsolete("This ctor will be removed in 1.16 because it's unused (and doesn't even make sense)")]
    public DateOnlyField(int tag, DateTime dt, TimeStampPrecision timeFormatPrecision)
        : this(tag, dt) { }
}
