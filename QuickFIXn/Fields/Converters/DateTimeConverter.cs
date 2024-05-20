#nullable enable
using System;
using System.Collections.Generic;
using System.Globalization;

namespace QuickFix.Fields.Converters;

/// <summary>
/// Functions for converting DateTime to/from FIX String
/// </summary>
public static class DateTimeConverter
{
    public const int MicrosPerMillis = 1000;
    public const int NanosPerMicro = 1000;
    public const int TicksPerMicrosecond = 10;
    public const int NanosecondsPerTick = 100;
    public const string DATE_TIME_FORMAT_WITH_NANOSECONDS = "{0:yyyyMMdd-HH:mm:ss}.{1:D9}";
    public const string DATE_TIME_FORMAT_WITH_MICROSECONDS = "{0:yyyyMMdd-HH:mm:ss.ffffff}";
    public const string DATE_TIME_FORMAT_WITH_MILLISECONDS = "{0:yyyyMMdd-HH:mm:ss.fff}";
    public const string DATE_TIME_FORMAT_WITHOUT_MILLISECONDS = "{0:yyyyMMdd-HH:mm:ss}";
    public const string DATE_ONLY_FORMAT = "{0:yyyyMMdd}";
    public const string TIME_ONLY_FORMAT_WITH_NANOSECONDS = "{0:HH:mm:ss}.{1:D9}";
    public const string TIME_ONLY_FORMAT_WITH_MICROSECONDS = "{0:HH:mm:ss.ffffff}";
    public const string TIME_ONLY_FORMAT_WITH_MILLISECONDS = "{0:HH:mm:ss.fff}";
    public const string TIME_ONLY_FORMAT_WITHOUT_MILLISECONDS = "{0:HH:mm:ss}";

    public const string DATE_TIME_WITH_MICROSECONDS = "yyyyMMdd-HH:mm:ss.ffffff";
    public static int DATE_TIME_MAXLENGTH_WITHOUT_NANOSECONDS = DATE_TIME_WITH_MICROSECONDS.Length;
    public const string TIME_ONLY_WITH_MICROSECONDS = "HH:mm:ss.ffffff";
    public static int TIME_ONLY_MAXLENGTH_WITHOUT_NANOSECONDS = TIME_ONLY_WITH_MICROSECONDS.Length;

    public static string[] DATE_TIME_FORMATS = { DATE_TIME_WITH_MICROSECONDS, "yyyyMMdd-HH:mm:ss.fff", "yyyyMMdd-HH:mm:ss" };
    public static string[] DATE_ONLY_FORMATS = { "yyyyMMdd" };
    public static string[] TIME_ONLY_FORMATS = { TIME_ONLY_WITH_MICROSECONDS, "HH:mm:ss.fff", "HH:mm:ss" };
    public static DateTimeStyles DATE_TIME_STYLES = DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal;
    public static CultureInfo DATE_TIME_CULTURE_INFO = CultureInfo.InvariantCulture;

    private static IDictionary<TimeStampPrecision, string> DATE_TIME_PRECISION_TO_FORMAT = new Dictionary<TimeStampPrecision, string>
    {
        {TimeStampPrecision.Second, DATE_TIME_FORMAT_WITHOUT_MILLISECONDS},
        {TimeStampPrecision.Millisecond, DATE_TIME_FORMAT_WITH_MILLISECONDS},
        {TimeStampPrecision.Microsecond, DATE_TIME_FORMAT_WITH_MICROSECONDS},
    };

    private static IDictionary<TimeStampPrecision, string> TIME_ONLY_PRECISION_TO_FORMAT = new Dictionary<TimeStampPrecision, string>
    {
        {TimeStampPrecision.Second, TIME_ONLY_FORMAT_WITHOUT_MILLISECONDS},
        {TimeStampPrecision.Millisecond, TIME_ONLY_FORMAT_WITH_MILLISECONDS},
        {TimeStampPrecision.Microsecond, TIME_ONLY_FORMAT_WITH_MICROSECONDS},
    };

    private static DateTime TimeOnlyFromNanoString(string str)
    {
        return ConvertFromNanoString(str, TIME_ONLY_FORMATS);
    }

    private static DateTime DateTimeFromNanoString(string str)
    {
        return ConvertFromNanoString(str, DATE_TIME_FORMATS);
    }

    private static DateTime ConvertFromNanoString(string str, string[] formats)
    {
        int i = str.IndexOf('.');
        string dec = str.Substring(i+1);
        DateTimeKind kind;
        int offsetMinutes = 0;

        if (dec.EndsWith('Z'))
        {
            // UTC
            dec = dec.Substring(0, dec.Length - 1);
            kind = DateTimeKind.Utc;
        }
        else if (dec.Contains('+') || dec.Contains('-'))
        {
            // GMT offset
            int n = dec.Contains('+') ? dec.IndexOf('+') : dec.IndexOf('-');
            kind = DateTimeKind.Unspecified;

            var offsetParts = dec.Substring(n).Split(":");
            offsetMinutes = int.Parse(offsetParts[0]) * 60;
            if (offsetParts.Length > 1) {
                var mins = int.Parse(offsetParts[1]);
                offsetMinutes += (offsetMinutes >= 0) ? mins : -mins;
            }

            dec = dec.Substring(0, n);
        }
        else
        {
            // local time
            kind = DateTimeKind.Local;
        }
        long frac = long.Parse(dec);
        string tm = str.Substring(0, i);
        DateTime d = DateTime.SpecifyKind(DateTime.ParseExact(tm, formats, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES), kind);

        // apply GMT offset
        if (offsetMinutes != 0)
        {
            d = new DateTimeOffset(d, TimeSpan.FromMinutes(offsetMinutes)).UtcDateTime;
        }

        long ticks = frac / NanosecondsPerTick;
        return d.AddTicks(ticks);
    }

    /// <summary>
    /// Convert string to DateTime
    /// </summary>
    /// <exception cref="FieldConvertError"/>
    public static DateTime ParseToDateTime(string str)
    {
        try
        {
            return (str.Length > DATE_TIME_MAXLENGTH_WITHOUT_NANOSECONDS)
                ? DateTimeFromNanoString(str)
                : DateTime.ParseExact(str, DATE_TIME_FORMATS, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES);
        }
        catch (Exception e)
        {
            throw new FieldConvertError("Could not convert string (" + str + ") to DateTime: " + e.Message, e);
        }
    }

    /// <summary>
    /// Check if string is DateOnly and, if yes, convert to DateTime
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    /// <exception cref="FieldConvertError"/>
    public static DateTime ParseToDateOnly(string str)
    {
        try
        {
            return DateTime.ParseExact(str, DATE_ONLY_FORMATS, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES);
        }
        catch (Exception e)
        {
            throw new FieldConvertError("Could not convert string (" + str + ") to DateOnly: " + e.Message, e);
        }
    }

    /// <summary>
    /// Check if string is TimeOnly and, if yes, convert to DateTime.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    /// <exception cref="FieldConvertError"/>
    public static DateTime ParseToTimeOnly(string str)
    {
        try {
            DateTime d = (str.Length > TIME_ONLY_MAXLENGTH_WITHOUT_NANOSECONDS)
                ? TimeOnlyFromNanoString(str)
                : DateTime.ParseExact(str, TIME_ONLY_FORMATS, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES);

            return new DateTime(1980, 1, 1) + d.TimeOfDay;
        }
        catch (Exception e)
        {
            throw new FieldConvertError("Could not convert string (" + str + ") to TimeOnly: " + e.Message, e);
        }
    }

    /// <summary>
    /// Gets the nanoseconds component of the date represented by this instance truncated to 100 nanosecond resolution
    /// </summary>
    /// <param name="dt"></param>
    /// <returns>The nanoseconds component, expressed as a value between 0 and 99900.</returns>
    private static int Nanosecond(this DateTime dt)
    {
        int ns = (int)(dt.Ticks % TimeSpan.TicksPerMillisecond % (double)TicksPerMicrosecond) * NanosecondsPerTick;
        int us = (int)Math.Floor((dt.Ticks % TimeSpan.TicksPerMillisecond) / (double)TicksPerMicrosecond);
        return (us * NanosPerMicro) + ns;
    }

    private static long SubsecondAsNanoseconds(this DateTime dt)
    {
        int ns = dt.Nanosecond();
        int ms = dt.Millisecond;
        return (ms * NanosPerMicro * MicrosPerMillis) + ns;
    }

    public static string ToFIX(DateTime dt, TimeStampPrecision precision)
    {
        return (precision == TimeStampPrecision.Nanosecond)
            ? string.Format(DATE_TIME_FORMAT_WITH_NANOSECONDS, dt, dt.SubsecondAsNanoseconds())
            : string.Format(DATE_TIME_PRECISION_TO_FORMAT[precision], dt);
    }

    public static string ToFIXDateOnly(DateTime dt)
    {
        return string.Format(DATE_ONLY_FORMAT, dt);
    }

    public static string ToFIXTimeOnly(DateTime dt, TimeStampPrecision precision)
    {
        return (precision == TimeStampPrecision.Nanosecond)
            ? string.Format(TIME_ONLY_FORMAT_WITH_NANOSECONDS, dt, dt.SubsecondAsNanoseconds())
            : string.Format(TIME_ONLY_PRECISION_TO_FORMAT[precision], dt);
    }

    [Obsolete("Use ParseToTimeOnly(str).  The 'precision' parameter is unnecessary.")]
    public static DateTime ParseToTimeOnly(string str, TimeStampPrecision precision = TimeStampPrecision.Millisecond) {
        return ParseToTimeOnly(str);
    }

    [Obsolete("Renamed to ParseToDateTime(str) - the precision parameter was unused internally, so discard it")]
    public static DateTime ConvertToDateTime(string str, TimeStampPrecision precision = TimeStampPrecision.Millisecond) {
        return ParseToDateTime(str);
    }

    [Obsolete("Renamed to ParseToDateOnly(str)")]
    public static DateTime ConvertToDateOnly(string str) {
        return ParseToDateOnly(str);
    }

    [Obsolete("Renamed to ParseToTimeOnly(str, precision)")]
    public static DateTime ConvertToTimeOnly(string str, TimeStampPrecision precision = TimeStampPrecision.Millisecond) {
        return ParseToTimeOnly(str, precision);
    }

    /// <summary>
    /// Check if string is TimeOnly and, if yes, convert to TimeSpan
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    /// <exception cref="FieldConvertError"/>
    [Obsolete("QF/n doesn't use this, so it will be deleted.  Copy it into your own application if you need it.")]
    public static TimeSpan ConvertToTimeSpan(string str)
    {
        try
        {
            DateTime d = ParseToTimeOnly(str);
            return d.TimeOfDay;
        }
        catch (Exception e)
        {
            throw new FieldConvertError("Could not convert string (" + str + ") to TimeSpan: " + e.Message, e);
        }
    }

    [Obsolete("Use ToFIX(dt, precision) instead")]
    public static string Convert(DateTime dt, bool includeMilliseconds = true) {
        return includeMilliseconds
            ? ToFIX(dt, TimeStampPrecision.Millisecond)
            : ToFIX(dt, TimeStampPrecision.Second);
    }

    [Obsolete("Renamed to ToFIX(dt, precision)")]
    public static string Convert(DateTime dt, TimeStampPrecision precision) {
        return ToFIX(dt, precision);
    }

    [Obsolete("Renamed to ToFIXDateOnly(dt)")]
    public static string ConvertDateOnly(DateTime dt) {
        return ToFIXDateOnly(dt);
    }

    [Obsolete("Renamed to DateTimeToFixTimeOnly(dt, precision)")]
    public static string ConvertTimeOnly(DateTime dt, TimeStampPrecision precision) {
        return ToFIXTimeOnly(dt, precision);
    }

    [Obsolete("Use ToFIXTimeOnly(dt, precision) instead")]
    public static string ConvertTimeOnly(DateTime dt, bool includeMilliseconds = true) {
        return includeMilliseconds
            ? ToFIXTimeOnly(dt, TimeStampPrecision.Millisecond)
            : ToFIXTimeOnly(dt, TimeStampPrecision.Second);
    }
}
