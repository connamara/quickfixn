using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace QuickFix.Fields.Converters;

/// <summary>
/// Functions for converting DateTime to/from FIX String
/// </summary>
public static class DateTimeConverter
{
    public const int NanosecondsPerTick = 100;
    
    /// <summary>
    /// Converts the specified span to a <see cref="DateTime"/> and, when the span contains 
    /// UTC offset information, a <see cref="DateTimeOffset"/> containing that information.
    /// The span must be in the format "yyyyMMdd-HH:mm:ss" optionally followed by fractional seconds
    /// and then optionally followed by UTC offset information.
    /// </summary>
    /// <param name="str">A span containing the characters that represent a date and time to convert.</param>
    /// <param name="dateTimeOffset">
    /// When <paramref name="str"/> is suffixed with UTC offset information (e.g. Z, +05, -01:30), this parameter
    /// is populated with a <see cref="DateTimeOffset"/> representing the date, time and offset information in
    /// <paramref name="str"/>. When <paramref name="str"/> does not contain UTC offset information, this parameter
    /// is <see langword="null"/>.
    /// </param>
    /// <returns>
    /// When <paramref name="str"/> does not contain UTC offset information, a value representing the date
    /// and time in <paramref name="str"/> with <see cref="DateTime.Kind"/> equal to
    /// <see cref="DateTimeKind.Unspecified"/>. When <paramref name="str"/> does contain offset information,
    /// then <paramref name="dateTimeOffset"/> is not <see langword="null"/> and the returned
    /// <see cref="DateTime"/> is equal to <see cref="DateTimeOffset.UtcDateTime"/>, that is, adjusted to UTC
    /// and with its <see cref="DateTime.Kind"/> equal to <see cref="DateTimeKind.Utc"/>.
    /// </returns>
    /// <remarks>
    /// This method supports parsing spans containing fractional seconds of arbitrary precision.
    /// However, the conversion can be lossy since <see cref="DateTime"/> objects can only retain
    /// fractional second precision to 100ns.
    /// </remarks>
    /// <exception cref="FieldConvertError">The conversion cannot be performed successfully.</exception>
    public static DateTime ParseToDateTime(ReadOnlySpan<char> str, out DateTimeOffset? dateTimeOffset)
    {
        dateTimeOffset = null;

        Debug.Assert("yyyyMMdd-HH:mm:ss".Length == 17);

        ReadOnlySpan<char> s = str;

        if (s.Length < 17 ||
            !DateTime.TryParseExact(s.Slice(0, 17), "yyyyMMdd-HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
        {
            return ThrowDateTime(str);
        }

        s = s.Slice(17);

        if (s.IsEmpty)
        {
            return dt;
        }

        if (s[0] == '.')
        {
            int fractionLength = ParseFraction(s.Slice(1), out double fraction);

            if (fractionLength == 0)
            {
                return ThrowDateTime(str);
            }

            dt = dt.AddTicks((long)(TimeSpan.TicksPerSecond * fraction));

            s = s.Slice(1 + fractionLength);

            if (s.IsEmpty)
            {
                return dt;
            }
        }

        Debug.Assert(!s.IsEmpty);

        if (s.IsWhiteSpace())
        {
            return ThrowDateTime(str);
        }

        if (s[0] == ' ')
        {
            // Allow a space before the offset
            s = s.Slice(1);
            Debug.Assert(!s.IsEmpty, "This should be covered by the IsWhiteSpace check");
        }

        int offsetLength = ParseOffset(s, out int sign, out int hours, out int minutes);

        if (!s.Slice(offsetLength).IsEmpty)
        {
            // Throw if there is something after the last valid offset part
            return ThrowDateTime(str);
        }

        Debug.Assert(offsetLength > 0, "Do not have an offset but going down the offset path");
        Debug.Assert(Math.Abs(sign) == 1, $"Bad {nameof(sign)} value returned from {nameof(ParseOffset)}");
        Debug.Assert((uint)hours <= 14, $"Bad {nameof(hours)} value returned from {nameof(ParseOffset)}");
        Debug.Assert((uint)minutes < 60, $"Bad {nameof(minutes)} value returned from {nameof(ParseOffset)}");

        TimeSpan offset = new(sign * hours, sign * minutes, 0);

        try
        {
            dateTimeOffset = new DateTimeOffset(dt, offset);
        }
        catch (ArgumentOutOfRangeException)
        {
            return ThrowDateTime(str);
        }

        return dateTimeOffset.Value.UtcDateTime;
    }
    
    /// <summary>
    /// Converts the specified string to a <see cref="DateTime"/>.
    /// The string must be in the format "yyyyMMdd-HH:mm:ss" optionally followed by fractional seconds
    /// and then optionally followed by UTC offset information.
    /// </summary>
    /// <param name="str">A <see cref="string"/> containing the characters that represent a date and time to convert.</param>
    /// <returns>
    /// When <paramref name="str"/> does not contain UTC offset information, a value representing the date
    /// and time in <paramref name="str"/> with <see cref="DateTime.Kind"/> equal to
    /// <see cref="DateTimeKind.Unspecified"/>. When <paramref name="str"/> does contain offset information,
    /// then the returned <see cref="DateTime"/> is equal to the date and time in <paramref name="str"/> adjusted to UTC
    /// and with its <see cref="DateTime.Kind"/> equal to <see cref="DateTimeKind.Utc"/>.
    /// </returns>
    /// <remarks>
    /// This method supports parsing spans containing fractional seconds of arbitrary precision.
    /// However, the conversion can be lossy since <see cref="DateTime"/> objects can only retain
    /// fractional second precision to 100ns.
    /// <br/><br/>
    /// This method calls <see cref="ParseToDateTime(ReadOnlySpan{char}, out DateTimeOffset?)"/>
    /// which also returns a <see cref="DateTimeOffset"/> when UTC offset information is present.
    /// Consider calling the latter for flexibility.
    /// </remarks>
    /// <exception cref="FieldConvertError">The conversion cannot be performed successfully.</exception>
    /// <seealso cref="ParseToDateTime(ReadOnlySpan{char}, out DateTimeOffset?)"/>
    public static DateTime ParseToDateTime(string str)
    {
        return ParseToDateTime(str, out _);
    }

    /// <summary>
    /// Converts the specified span to a <see cref="TimeOnly"/> and, when the span contains 
    /// UTC offset information, a <see cref="TimeSpan"/> containing that information.
    /// The span must be in the format "HH:mm:ss" optionally followed by fractional seconds
    /// and then optionally followed by UTC offset information.
    /// </summary>
    /// <param name="str">A span containing the characters that represent a time to convert.</param>
    /// <param name="offset">
    /// When <paramref name="str"/> is suffixed with UTC offset information (e.g. Z, +05, -01:30), this parameter
    /// is populated with a <see cref="TimeSpan"/> representing the offset information in
    /// <paramref name="str"/>. When <paramref name="str"/> does not contain UTC offset information, this parameter
    /// is <see langword="null"/>.
    /// </param>
    /// <returns>
    /// A value representing the time in <paramref name="str"/>. The value is unaffected by the value
    /// of <paramref name="offset"/>. For example, for the string "11:03:15 +05:30" the returned
    /// <see cref="TimeOnly"/> will be equivalent to 11:03:15. This behaviour differs to
    /// <see cref="ParseToDateTime(ReadOnlySpan{char}, out DateTimeOffset?)"/> where the returned
    /// <see cref="DateTime"/> is adjusted to UTC when offset information is present (with its
    /// <see cref="DateTime.Kind"/> equal to <see cref="DateTimeKind.Utc"/>).
    /// </returns>
    /// <remarks>
    /// This method supports parsing spans containing fractional seconds of arbitrary precision.
    /// However, the conversion can be lossy since <see cref="TimeOnly"/> objects can only retain
    /// fractional second precision to 100ns.
    /// </remarks>
    /// <exception cref="FieldConvertError">The conversion cannot be performed successfully.</exception>
    public static TimeOnly ParseToTimeOnly(ReadOnlySpan<char> str, out TimeSpan? offset)
    {
        offset = null;

        Debug.Assert("HH:mm:ss".Length == 8);

        ReadOnlySpan<char> s = str;

        if (s.Length < 8 ||
            !TimeOnly.TryParseExact(s.Slice(0, 8), "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out TimeOnly time))
        {
            return ThrowTimeOnly(str);
        }

        s = s.Slice(8);

        if (s.IsEmpty)
        {
            return time;
        }

        if (s[0] == '.')
        {
            int fractionLength = ParseFraction(s.Slice(1), out double fraction);

            if (fractionLength == 0)
            {
                return ThrowTimeOnly(str);
            }

            time = time.Add(TimeSpan.FromTicks((long)(TimeSpan.TicksPerSecond * fraction)));

            s = s.Slice(1 + fractionLength);

            if (s.IsEmpty)
            {
                return time;
            }
        }

        Debug.Assert(!s.IsEmpty);

        if (s.IsWhiteSpace())
        {
            return ThrowTimeOnly(str);
        }

        if (s[0] == ' ')
        {
            // Allow a space before the offset
            s = s.Slice(1);
            Debug.Assert(!s.IsEmpty, "This should be covered by the IsWhiteSpace check");
        }

        int offsetLength = ParseOffset(s, out int sign, out int hours, out int minutes);

        if (!s.Slice(offsetLength).IsEmpty)
        {
            // Throw if there is something after the last valid offset part
            return ThrowTimeOnly(str);
        }

        Debug.Assert(offsetLength > 0, "Do not have an offset but going down the offset path");
        Debug.Assert(Math.Abs(sign) == 1, $"Bad {nameof(sign)} value returned from {nameof(ParseOffset)}");
        Debug.Assert((uint)hours <= 14, $"Bad {nameof(hours)} value returned from {nameof(ParseOffset)}");
        Debug.Assert((uint)minutes < 60, $"Bad {nameof(minutes)} value returned from {nameof(ParseOffset)}");

        offset = new(sign * hours, sign * minutes, 0);

        return time;
    }
    
    /// <summary>
    /// Converts the specified string to a <see cref="DateTime"/>.
    /// The string must be in the format "HH:mm:ss" optionally followed by fractional seconds
    /// and then optionally followed by UTC offset information.
    /// </summary>
    /// <param name="str">A <see cref="string"/> containing the characters that represent a time to convert.</param>
    /// <returns>
    /// A value representing the time in <paramref name="str"/> with its date component equal to 1980-01-01.
    /// The value is unaffected by UTC offset information in <paramref name="str"/>.
    /// For example, for the string "11:03:15 +05:30" the returned <see cref="DateTime"/> will be equivalent
    /// to 1980-01-01 11:03:15 with its <see cref="DateTime.Kind"/> equal to <see cref="DateTimeKind.Unspecified"/>.
    /// </returns>
    /// <remarks>
    /// This method supports parsing spans containing fractional seconds of arbitrary precision.
    /// However, the conversion can be lossy since <see cref="DateTime"/> objects can only retain
    /// fractional second precision to 100ns.
    /// <br/><br/>
    /// This method calls <see cref="ParseToTimeOnly(ReadOnlySpan{char}, out TimeSpan?)"/> which returns a <see cref="TimeOnly"/>
    /// and, when UTC offset information is present, a <see cref="TimeSpan"/> containing that information.
    /// Consider calling the latter for flexibility.
    /// </remarks>
    /// <exception cref="FieldConvertError">The conversion cannot be performed successfully.</exception>
    public static DateTime ParseToTimeOnly(string str) => new DateOnly(1980, 1, 1).ToDateTime(ParseToTimeOnly(str, out _));
    // (^^Yes, it intentionally does return a DateTime.  For now.)

    /// <summary>
    /// For the given <paramref name="span"/>, read consecutive ASCII digits
    /// as a fraction until either a non-digit is found or the end of the span is reached.
    /// </summary>
    /// <param name="span">The <see cref="ReadOnlySpan{T}"/> to parse</param>
    /// <param name="fraction">
    /// The resulting decimal number greater than or equal to 0 and less than 1.
    /// For example, for the <paramref name="span"/> "0123X", <paramref name="fraction"/> will be 0.0123</param>
    /// <returns>
    /// The number of elements of the span consumed in parsing the fraction.
    /// For example, for the <paramref name="span"/> "0123X", the return value will be 4.
    /// </returns>
    private static int ParseFraction(ReadOnlySpan<char> span, out double fraction)
    {
        fraction = 0;
        double decimalBase = 0.1;
        for (int i = 0; i < span.Length; i++)
        {
            char c = span[i];
            if ((uint)(c - '0') > (uint)('9' - '0')) // if c is not an ascii digit
            {
                return i;
            }
            fraction += (c - '0') * decimalBase;
            decimalBase *= 0.1;
        }

        // If we are here then we've consumed the entire span as a fraction
        return span.Length;
    }

    /// <summary>
    /// For the given <paramref name="span"/>, read consecutive ASCII digits
    /// as an integer number until: a non-digit is found; the end of the span is reached;
    /// or <paramref name="maxDigits"/> digits have been read.
    /// </summary>
    /// <param name="span">The <see cref="ReadOnlySpan{T}"/> to parse.</param>
    /// <param name="maxDigits">
    /// The maximum number of digits to read.
    /// The caller is expected to specify a value between 1 and 8.
    /// </param>
    /// <param name="integer">
    /// The resulting integral number greater than or equal to 0.
    /// For example, for the <paramref name="span"/> "0123X", <paramref name="integer"/> will be 123</param>
    /// <returns>
    /// The number of elements of the span consumed in parsing the number.
    /// For example, for the <paramref name="span"/> "0123X", the return value will be 4.
    /// </returns>
    private static int ParseInteger(ReadOnlySpan<char> span, int maxDigits, out int integer)
    {
        Debug.Assert(maxDigits <= 8); // to avoid overflow
        maxDigits = Math.Min(maxDigits, span.Length);
        integer = 0;
        for (int i = 0; i < maxDigits; i++)
        {
            char c = span[i];
            if ((uint)(c - '0') > (uint)('9' - '0')) // if c is not an ascii digit
            {
                return i;
            }
            integer = 10 * integer + (c - '0');
        }

        // If we are here then we've consumed <maxDigits> digits as an integer from the span
        return maxDigits;
    }

    /// <summary>
    /// For the given <paramref name="span"/>, parse a UTC offset identifier
    /// until no valid part of the identifier can be parsed or the end of the span
    /// is reached.
    /// </summary>
    /// <param name="span">The <see cref="ReadOnlySpan{T}"/> to parse</param>
    /// <param name="sign">The direction of the offset. Either 1 or -1.</param>
    /// <param name="hours">The hours component of the offset</param>
    /// <param name="minutes">The minutes component of the offset</param>
    /// <returns>
    /// The number of elements from the start of the span which comprise a valid
    /// UTC offset identifier.
    /// For example:
    /// <list type="bullet">
    /// <item><description>For the <paramref name="span"/> "Z", the return value will be 1</description></item>
    /// <item><description>For the <paramref name="span"/> "+", the return value will be 0</description></item>
    /// <item><description>For the <paramref name="span"/> "+04:1", the return value will be 3</description></item>
    /// <item><description>For the <paramref name="span"/> "+04:12", the return value will be 6</description></item>
    /// </list>
    /// </returns>
    private static int ParseOffset(ReadOnlySpan<char> span, out int sign, out int hours, out int minutes)
    {
        Debug.Assert(span.Length > 0);

        sign = 1;

        switch (span[0])
        {
            case 'Z':
                hours = minutes = 0;
                return 1;
            case '+':
                break;
            case '-':
                sign = -1;
                break;
            default:
                hours = minutes = default;
                return 0;
        }

        Debug.Assert(span[0] == '+' || span[0] == '-');

        int numHourDigits = ParseInteger(span.Slice(1), maxDigits: 2, out hours);

        if (numHourDigits == 0 || hours > 14)
        {
            // Invalid hours part. We've consumed no valid offset part
            minutes = default;
            return 0;
        }

        Debug.Assert(numHourDigits == 1 || numHourDigits == 2);

        span = span.Slice(1 + numHourDigits);

        if (span.IsEmpty || span[0] != ':')
        {
            minutes = default;
            return 1 + numHourDigits;
        }

        int numMinuteDigits = ParseInteger(span.Slice(1), maxDigits: 2, out minutes);

        if (numMinuteDigits != 2 || minutes > 59)
        {
            // Invalid minutes part. We've only consumed a valid hours part
            return 1 + numHourDigits;
        }

        return 1 + numHourDigits + 1 + numMinuteDigits;
    }

    [DoesNotReturn]
    private static DateTime ThrowDateTime(ReadOnlySpan<char> s)
    {
        throw new FieldConvertError($"Could not convert string to DateTime: {s}");
    }

    [DoesNotReturn]
    private static TimeOnly ThrowTimeOnly(ReadOnlySpan<char> s)
    {
        throw new FieldConvertError($"Could not convert string to TimeOnly: {s}");
    }

    /// <summary>
    /// Converts the specified span to a <see cref="DateOnly"/>.
    /// The span must be in the format "yyyyMMdd".
    /// </summary>
    /// <param name="str">A span containing the characters that represent a date to convert.</param>
    /// <returns>
    /// A value representing the date in <paramref name="str"/>.
    /// </returns>
    /// <exception cref="FieldConvertError">The conversion cannot be performed successfully.</exception>
    public static DateOnly ParseToDateOnly(ReadOnlySpan<char> str)
    {
        if (!DateOnly.TryParseExact(str, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly dateOnly))
        {
            throw new FieldConvertError($"Could not convert string to DateOnly: {str}");
        }

        return dateOnly;
    }

    /// <summary>
    /// Converts the specified string to a <see cref="DateTime"/>.
    /// The string must be in the format "yyyyMMdd".
    /// </summary>
    /// <param name="str">A <see cref="string"/> containing the characters that represent a date to convert.</param>
    /// <returns>
    /// A value representing the date in <paramref name="str"/> with its time component equal to 00:00:00 and
    /// its <see cref="DateTime.Kind"/> equal to <see cref="DateTimeKind.Unspecified"/>.
    /// </returns>
    /// <remarks>
    /// This method calls <see cref="ParseToDateOnly(ReadOnlySpan{char})"/> which returns a <see cref="DateOnly"/>.
    /// Consider calling the latter for correctness.
    /// </remarks>
    /// <exception cref="FieldConvertError">The conversion cannot be performed successfully.</exception>
    public static DateTime ParseToDateOnly(string str) => ParseToDateOnly((ReadOnlySpan<char>)str).ToDateTime(default);

    /// <summary>
    /// Gets the nanoseconds component of the date represented by this instance truncated to 100 nanosecond resolution.
    /// </summary>
    /// <param name="dt"></param>
    /// <returns>The nanoseconds component, expressed as a value between 0 and 99900.</returns>
    public static int Nanosecond(this DateTime dt)
    {
        return (int)(dt.Ticks % TimeSpan.TicksPerMillisecond) * NanosecondsPerTick;
    }

    private static long SubsecondAsNanoseconds(DateTime dt)
    {
        return (dt.Ticks % TimeSpan.TicksPerSecond) * NanosecondsPerTick;
    }

    private static long SubsecondAsNanoseconds(TimeOnly time)
    {
        return (time.Ticks % TimeSpan.TicksPerSecond) * NanosecondsPerTick;
    }

    /// <summary>
    /// Converts the specified <see cref="DateTime"/> to a <see cref="string"/> in the format "yyyyMMdd-HH:mm:ss.fff".
    /// </summary>
    /// <param name="dt">The value to convert.</param>
    /// <returns>A value representing <paramref name="dt"/> in the format "yyyyMMdd-HH:mm:ss.fff".</returns>
    public static string ToFIX(DateTime dt)
    {
        return ToFIX(dt, TimeStampPrecision.Millisecond);
    }

    // TODO: deprecate - use ToFIX(dt,precision) instead
    /// <summary>
    /// Converts the specified <see cref="DateTime"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="dt">The value to convert.</param>
    /// <param name="includeMilliseconds">Whether fractional seconds (to the millisecond) should be in the returned value.</param>
    /// <returns>
    /// A value representing <paramref name="dt"/>. If <paramref name="includeMilliseconds"/>
    /// is <see langword="true"/>, the value will be in the format "yyyyMMdd-HH:mm:ss.fff". Otherwise, the value
    /// will be in the format "yyyyMMdd-HH:mm:ss".
    /// </returns>
    public static string ToFIX(DateTime dt, bool includeMilliseconds)
    {
        return ToFIX(dt, includeMilliseconds ? TimeStampPrecision.Millisecond : TimeStampPrecision.Second);
    }

    /// <summary>
    /// Converts the specified <see cref="DateTime"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="dt">The value to convert.</param>
    /// <param name="precision">The level of precision with which to format the
    /// fractional seconds component of <paramref name="dt"/>.</param>
    /// <returns>
    /// A value representing <paramref name="dt"/>. The value will begin in the format "yyyyMMdd-HH:mm:ss"
    /// and end in fractional seconds whose precision is determined by <paramref name="precision"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is an invalid value.</exception>
    public static string ToFIX(DateTime dt, TimeStampPrecision precision)
    {
        return precision switch
        {
            TimeStampPrecision.Second => dt.ToString("yyyyMMdd-HH:mm:ss"),
            TimeStampPrecision.Millisecond => dt.ToString("yyyyMMdd-HH:mm:ss.fff"),
            TimeStampPrecision.Microsecond => dt.ToString("yyyyMMdd-HH:mm:ss.ffffff"),
            TimeStampPrecision.Nanosecond => $"{dt:yyyyMMdd-HH:mm:ss}.{SubsecondAsNanoseconds(dt):000000000}",
            _ => throw new ArgumentOutOfRangeException(nameof(precision))
        };
    }

    /// <summary>
    /// Converts the specified <see cref="DateOnly"/> to a <see cref="string"/> in the format "yyyyMMdd".
    /// </summary>
    /// <param name="date">The value to convert.</param>
    /// <returns>A value representing <paramref name="date"/> in the format "yyyyMMdd".</returns>
    public static string ToFIXDateOnly(DateOnly date)
    {
        return date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// Converts the date component of the specified <see cref="DateTime"/> to a <see cref="string"/>
    /// in the format "yyyyMMdd".
    /// </summary>
    /// <param name="dt">The value to convert.</param>
    /// <returns>A value representing the date component of <paramref name="dt"/> in the format "yyyyMMdd".</returns>
    public static string ToFIXDateOnly(DateTime dt) => ToFIXDateOnly(DateOnly.FromDateTime(dt));

    /// <summary>
    /// Converts the specified <see cref="TimeOnly"/> to a <see cref="string"/> in the format "HH:mm:ss.fff".
    /// </summary>
    /// <param name="time">The value to convert.</param>
    /// <returns>A value representing <paramref name="time"/> in the format "HH:mm:ss.fff".</returns>
    public static string ToFIXTimeOnly(TimeOnly time)
    {
        return ToFIXTimeOnly(time, TimeStampPrecision.Millisecond);
    }

    /// <summary>
    /// Converts the time component of the specified <see cref="DateTime"/> to
    /// a <see cref="string"/> in the format "HH:mm:ss.fff".
    /// </summary>
    /// <param name="dt">The value to convert.</param>
    /// <returns>A value representing the time component of <paramref name="dt"/> in the format "HH:mm:ss.fff".</returns>
    public static string ToFIXTimeOnly(DateTime dt) => ToFIXTimeOnly(TimeOnly.FromDateTime(dt));

    /// <summary>
    /// Converts the specified <see cref="TimeOnly"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="time">The value to convert.</param>
    /// <param name="includeMilliseconds">Whether fractional seconds (to the millisecond)
    /// should be in the returned value.</param>
    /// <returns>
    /// A value representing <paramref name="time"/>. If <paramref name="includeMilliseconds"/>
    /// is <see langword="true"/>, the value will be in the format "HH:mm:ss.fff". Otherwise, the value
    /// will be in the format "HH:mm:ss".
    /// </returns>
    public static string ToFIXTimeOnly(TimeOnly time, bool includeMilliseconds)
    {
        return ToFIXTimeOnly(time, includeMilliseconds ? TimeStampPrecision.Millisecond : TimeStampPrecision.Second);
    }

    /// <summary>
    /// Converts the time component of the specified <see cref="DateTime"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="dt">The value to convert.</param>
    /// <param name="includeMilliseconds">Whether fractional seconds (to the millisecond) should
    /// be in the returned value.</param>
    /// <returns>
    /// A value representing the time component of <paramref name="dt"/>. If <paramref name="includeMilliseconds"/>
    /// is <see langword="true"/>, the value will be in the format "HH:mm:ss.fff". Otherwise, the value
    /// will be in the format "HH:mm:ss".
    /// </returns>
    public static string ToFIXTimeOnly(DateTime dt, bool includeMilliseconds)
        => ToFIXTimeOnly(TimeOnly.FromDateTime(dt), includeMilliseconds);

    /// <summary>
    /// Converts the specified <see cref="TimeOnly"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="time">The value to convert.</param>
    /// <param name="precision">The level of precision with which to format the fractional seconds
    /// component of <paramref name="time"/>.</param>
    /// <returns>
    /// A value representing <paramref name="time"/>. The value will begin in the format "yyyyMMdd-HH:mm:ss"
    /// and end in fractional seconds whose precision is determined by <paramref name="precision"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is an invalid value.</exception>
    public static string ToFIXTimeOnly(TimeOnly time, TimeStampPrecision precision)
    {
        return precision switch
        {
            TimeStampPrecision.Second => time.ToString("HH:mm:ss", CultureInfo.InvariantCulture),
            TimeStampPrecision.Millisecond => time.ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture),
            TimeStampPrecision.Microsecond => time.ToString("HH:mm:ss.ffffff", CultureInfo.InvariantCulture),
            TimeStampPrecision.Nanosecond => $"{time:HH:mm:ss}.{SubsecondAsNanoseconds(time):000000000}",
            _ => throw new ArgumentOutOfRangeException(nameof(precision))
        };
    }

    /// <summary>
    /// Converts the time component of the specified <see cref="DateTime"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="dt">The value to convert.</param>
    /// <param name="precision">The level of precision with which to format the fractional
    /// seconds component of <paramref name="dt"/>.</param>
    /// <returns>
    /// A value representing the time component of <paramref name="dt"/>.
    /// The value will begin in the format "yyyyMMdd-HH:mm:ss"
    /// and end in fractional seconds whose precision is determined by <paramref name="precision"/>.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="precision"/> is an invalid value.</exception>
    public static string ToFIXTimeOnly(DateTime dt, TimeStampPrecision precision)
        => ToFIXTimeOnly(TimeOnly.FromDateTime(dt), precision);

    [Obsolete("The 'precision' parameter is no longer needed.  This form of the function will be deleted in v1.15.")]
    public static DateTime ParseToTimeOnly(string str, TimeStampPrecision precision = TimeStampPrecision.Millisecond) {
        return ParseToTimeOnly(str);
    }

    [Obsolete("Use ParseToDateTime(string str) instead.  The 'precision' parameter is not needed.  This function will be deleted in v1.15.")]
    public static DateTime ConvertToDateTime(string str, TimeStampPrecision precision = TimeStampPrecision.Millisecond) {
        return ParseToDateTime(str);
    }

    [Obsolete("Renamed to ParseToDateOnly(str).  This is a legacy wrapper that will be deleted in v1.15.")]
    public static DateTime ConvertToDateOnly(string str) {
        return ParseToDateOnly(str);
    }

    [Obsolete("Renamed to ParseToTimeOnly(str, precision).  This is a legacy wrapper that will be deleted in v1.15.")]
    public static DateTime ConvertToTimeOnly(string str, TimeStampPrecision precision = TimeStampPrecision.Millisecond) {
        return ParseToTimeOnly(str, precision);
    }
    
    /// <summary>
    /// Converts the specified string to a <see cref="TimeSpan"/>.
    /// The string must be in the format "HH:mm:ss" optionally followed by fractional seconds
    /// and then optionally followed by UTC offset information.
    /// </summary>
    /// <param name="str">A <see cref="string"/> containing the characters that represent a time to convert.</param>
    /// <returns>
    /// A value representing the time in <paramref name="str"/>.
    /// The value is unaffected by UTC offset information in <paramref name="str"/>.
    /// For example, for the string "11:03:15 +05:30" the returned <see cref="TimeSpan"/> will be equivalent
    /// to 11:03:15.
    /// </returns>
    /// <remarks>
    /// This method supports parsing spans containing fractional seconds of arbitrary precision.
    /// However, the conversion can be lossy since <see cref="TimeSpan"/> objects can only retain
    /// fractional second precision to 100ns.
    /// <br/><br/>
    /// This method calls <see cref="ParseToTimeOnly(ReadOnlySpan{char}, out TimeSpan?)"/>
    /// which returns a <see cref="TimeOnly"/>
    /// and, when UTC offset information is present, a <see cref="TimeSpan"/> containing that information.
    /// Consider calling the latter for flexibility.
    /// </remarks>
    /// <exception cref="FieldConvertError">The conversion cannot be performed successfully.</exception>
    [Obsolete("QF/n doesn't use this, so it will be deleted in v1.15.  Copy it into your own application if you need it.")]
    public static TimeSpan ConvertToTimeSpan(string str) => ParseToTimeOnly(str, out _).ToTimeSpan();

    [Obsolete("Use ToFIX(dt, precision) instead.  This will be deleted in v1.15.")]
    public static string Convert(DateTime dt, bool includeMilliseconds = true) {
        return includeMilliseconds
            ? ToFIX(dt, TimeStampPrecision.Millisecond)
            : ToFIX(dt, TimeStampPrecision.Second);
    }

    [Obsolete("Renamed to ToFIX(dt, precision).  This is a legacy wrapper that will be deleted in v1.15.")]
    public static string Convert(DateTime dt, TimeStampPrecision precision) {
        return ToFIX(dt, precision);
    }

    [Obsolete("Renamed to ToFIXDateOnly(dt).  This is a legacy wrapper that will be deleted in v1.15.")]
    public static string ConvertDateOnly(DateTime dt) {
        return ToFIXDateOnly(dt);
    }

    [Obsolete("Renamed to ToFixTimeOnly(dt, precision).  This is a legacy wrapper that will be deleted in v1.15.")]
    public static string ConvertTimeOnly(DateTime dt, TimeStampPrecision precision) {
        return ToFIXTimeOnly(dt, precision);
    }

    [Obsolete("Use ToFIXTimeOnly(dt, precision) instead.  This function will be deleted in v1.15.")]
    public static string ConvertTimeOnly(DateTime dt, bool includeMilliseconds = true) {
        return includeMilliseconds
            ? ToFIXTimeOnly(dt, TimeStampPrecision.Millisecond)
            : ToFIXTimeOnly(dt, TimeStampPrecision.Second);
    }
}
