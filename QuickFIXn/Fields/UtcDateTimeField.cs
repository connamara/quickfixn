using System;

namespace QuickFix.Fields;

/// <summary>
/// Base class for UTCTIMESTAMP fields (e.g. SendingTime, TransactTime). Per the FIX spec, UTCTIMESTAMP
/// values are always UTC; this class normalizes <see cref="Value"/> to <see cref="DateTimeKind.Utc"/>
/// on every assignment instead of leaving it <see cref="DateTimeKind.Unspecified"/>.
/// </summary>
/// <remarks>
/// Note that <see cref="QuickFix.FieldMap.GetDateTime(int)"/> still returns
/// <see cref="DateTimeKind.Unspecified"/> for a wire-parsed value, because a bare tag lookup has no
/// DataDictionary context to know the field is a UTCTIMESTAMP. Use the typed <c>GetField</c> overloads
/// or <see cref="QuickFix.FieldMap.GetUtcDateTime(int)"/> to obtain a normalized value.
/// </remarks>
public class UtcDateTimeField : DateTimeField
{
    public UtcDateTimeField(int tag)
        : base(tag, DateTime.SpecifyKind(default, DateTimeKind.Utc)) {}

    /// <summary>
    /// IMPORTANT: If <c>dt.Kind</c> is <c>Local</c>, then dt
    /// will be converted to UTC and this UTC-adjusted time will be in the FIX string
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="dt"></param>
    public UtcDateTimeField(int tag, DateTime dt)
        : base(tag, ToUtc(dt)) {}

    // Not [Obsolete] here, matching DateTimeField; the deprecation is applied to the generated field classes.
    /// <summary>
    /// IMPORTANT: If <c>dt.Kind</c> is <c>Local</c>, then dt
    /// will be converted to UTC and this UTC-adjusted time will be in the FIX string
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="dt"></param>
    /// <param name="showMilliseconds"></param>
    public UtcDateTimeField(int tag, DateTime dt, bool showMilliseconds)
        : base(tag, ToUtc(dt), showMilliseconds) {}

    /// <summary>
    /// IMPORTANT: If <c>dt.Kind</c> is <c>Local</c>, then dt
    /// will be converted to UTC and this UTC-adjusted time will be in the FIX string
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="dt"></param>
    /// <param name="timeFormatPrecision"></param>
    public UtcDateTimeField(int tag, DateTime dt, TimePrecision timeFormatPrecision)
        : base(tag, ToUtc(dt), timeFormatPrecision) {}

    /// <summary>
    /// IMPORTANT: If the setter's Value param has <c>dt.Kind=Local</c>, then Value
    /// will be converted to UTC and this UTC-adjusted time will be in the FIX string
    /// </summary>
    public override DateTime Value
    {
        get => base.Value;
        set => base.Value = ToUtc(value);
    }

    /// <summary>
    /// The return value will have <c>Kind=UTC</c>.  If <c>dt.Kind</c> was local, shift the time value to UTC.
    /// </summary>
    /// <param name="dt"></param>
    /// <returns></returns>
    private static DateTime ToUtc(DateTime dt) => dt.Kind switch
    {
        DateTimeKind.Utc => dt,
        DateTimeKind.Local => dt.ToUniversalTime(),
        // Unspecified: per FIX spec a UTCTIMESTAMP is already UTC, so relabel without shifting.
        // Used as the discard arm because DateTime.Kind cannot return an undeclared value
        // (see UtcDateTimeFieldTests.DateTimeKindHasNoUnhandledMembers).
        _ => DateTime.SpecifyKind(dt, DateTimeKind.Utc)
    };
}
