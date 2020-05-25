using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace QuickFix.Fields.Converters
{
    /// <summary>
    /// Convert DateTime to/from String
    /// </summary>
    public static class DateTimeConverter
    {
        public const int MicrosPerMillis = 1000;
        public const int NanosPerMicro = 1000;
        public const int TicksPerMicrosecond = 10;
        public const int NanosecondsPerTick = 100;
        public const string DATE_TIME_FORMAT_WITH_NANOSECONDS = "{0:yyyyMMdd-HH:mm:ss}.{1}";
        public const string DATE_TIME_FORMAT_WITH_MICROSECONDS = "{0:yyyyMMdd-HH:mm:ss.ffffff}";
        public const string DATE_TIME_FORMAT_WITH_MILLISECONDS = "{0:yyyyMMdd-HH:mm:ss.fff}";
        public const string DATE_TIME_FORMAT_WITHOUT_MILLISECONDS = "{0:yyyyMMdd-HH:mm:ss}";
        public const string DATE_ONLY_FORMAT = "{0:yyyyMMdd}";
        public const string TIME_ONLY_FORMAT_WITH_NANOSECONDS = "{0:HH:mm:ss}.{1}";
        public const string TIME_ONLY_FORMAT_WITH_MICROSECONDS = "{0:HH:mm:ss.ffffff}";
        public const string TIME_ONLY_FORMAT_WITH_MILLISECONDS = "{0:HH:mm:ss.fff}";
        public const string TIME_ONLY_FORMAT_WITHOUT_MILLISECONDS = "{0:HH:mm:ss}";
        
        public const string DATE_TIME_WITH_MICROSECONDS = "yyyyMMdd-HH:mm:ss.ffffff";
        public static int DATE_TIME_MAXLENGTH_WITHOUT_NANOSECONDS = DATE_TIME_WITH_MICROSECONDS.Length;
        public static string[] DATE_TIME_FORMATS = { DATE_TIME_WITH_MICROSECONDS, "yyyyMMdd-HH:mm:ss.fff", "yyyyMMdd-HH:mm:ss" };
        public static string[] DATE_ONLY_FORMATS = { "yyyyMMdd" };
        public static string[] TIME_ONLY_FORMATS = { "HH:mm:ss.ffffff", "HH:mm:ss.fff", "HH:mm:ss" };
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

        private static System.DateTime TimeOnlyFromNanoString(string str)
        {
            return ConvertFromNanoString(str, TIME_ONLY_FORMATS);
        }

        private static System.DateTime DateTimeFromNanoString(string str)
        {
            return ConvertFromNanoString(str, DATE_TIME_FORMATS);
        }

        private static System.DateTime ConvertFromNanoString(string str, string[] formats)
        {
            int i = str.IndexOf('.');
            string dec = str.Substring(i+1);
            System.DateTimeKind kind;
            int offset = 0;

            if (dec.EndsWith("Z"))
            {
                // UTC
                dec = dec.Substring(0, dec.Length - 1);
                kind = System.DateTimeKind.Utc;
            }
            else if (dec.Contains("+") || dec.Contains("-"))
            {
                // GMT offset
                int n = dec.Contains("+") ? dec.IndexOf('+') : dec.IndexOf('-');
                kind = System.DateTimeKind.Utc;
                offset = int.Parse(dec.Substring(n + 1));
                dec = dec.Substring(0, n);
            }
            else
            {
                // local time
                kind = System.DateTimeKind.Local;
            }
            long frac = long.Parse(dec);
            string tm = str.Substring(0, i);
            System.DateTime d = System.DateTime.SpecifyKind(System.DateTime.ParseExact(tm, formats, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES), kind);

            // apply GMT offset
            if (offset != 0)
            {
                d = new System.DateTimeOffset(d).ToOffset(System.TimeSpan.FromHours(offset)).DateTime;
            }

            long ticks = frac / NanosecondsPerTick;
            return d.AddTicks(ticks);
        }

        /// <summary>
        /// Convert string to DateTime
        /// </summary>
        /// <exception cref="FieldConvertError"/>
        public static System.DateTime ConvertToDateTime(string str)
        {
            return ConvertToDateTime(str, TimeStampPrecision.Millisecond);
        }

        /// <summary>
        /// Convert string to DateTime
        /// </summary>
        /// <exception cref="FieldConvertError"/>
        public static System.DateTime ConvertToDateTime(string str, TimeStampPrecision precision)
        {
            try
            {
                //Avoid NanoString Path parsing if not possible from string length
                if (str.Length > DATE_TIME_MAXLENGTH_WITHOUT_NANOSECONDS)
                {
                    return DateTimeFromNanoString(str);
                }
                else
                {
                    return System.DateTime.ParseExact(str, DATE_TIME_FORMATS, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES);
                }
            }
            catch (System.Exception e)
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
        public static System.DateTime ConvertToDateOnly(string str)
        {
            try
            {
                return System.DateTime.ParseExact(str, DATE_ONLY_FORMATS, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES);
            }
            catch (System.Exception e)
            {
                throw new FieldConvertError("Could not convert string (" + str + ") to DateOnly: " + e.Message, e);
            }
        }

        /// <summary>
        /// Check if string is TimeOnly and, if yes, convert to DateTime.  Time stamp precision defaults to milliseconds.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <exception cref="FieldConvertError"/>
        public static System.DateTime ConvertToTimeOnly(string str)
        {
            return ConvertToTimeOnly(str, TimeStampPrecision.Millisecond);
        }

        /// <summary>
        /// Check if string is TimeOnly and, if yes, convert to DateTime.  Optional time stamp precision up to 
        /// </summary>
        /// <param name="str"></param>
        /// /// <param name="precision"></param>
        /// <returns></returns>
        /// <exception cref="FieldConvertError"/>
        public static System.DateTime ConvertToTimeOnly(string str, TimeStampPrecision precision)
        {
            try
            {
                System.DateTime d;
                if (precision == TimeStampPrecision.Nanosecond)
                {
                    d = TimeOnlyFromNanoString(str);
                }
                else
                {
                    d = System.DateTime.ParseExact(str, TIME_ONLY_FORMATS, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES);
                }
                return new System.DateTime(1980, 1, 1) + d.TimeOfDay;
            }
            catch (System.Exception e)
            {
                throw new FieldConvertError("Could not convert string (" + str + ") to TimeOnly: " + e.Message, e);
            }
        }

        /// <summary>
        /// Check if string is TimeOnly and, if yes, convert to TimeSpan
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <exception cref="FieldConvertError"/>
        public static System.TimeSpan ConvertToTimeSpan(string str)
        {
            try
            {
                System.DateTime d = ConvertToTimeOnly(str);
                return d.TimeOfDay;
            }
            catch (System.Exception e)
            {
                throw new FieldConvertError("Could not convert string (" + str + ") to TimeSpan: " + e.Message, e);
            }
        }

        /// <summary>
        /// Convert DateTime to string in FIX Format
        /// </summary>
        /// <param name="dt">the DateTime to convert</param>
        /// <param name="includeMilliseconds">if true, include milliseconds in the result</param>
        /// <returns>FIX-formatted DataTime</returns>
        public static string Convert( System.DateTime dt, bool includeMilliseconds )
        {
            return includeMilliseconds ? Convert(dt, TimeStampPrecision.Millisecond): Convert( dt, TimeStampPrecision.Second );
        }
        
        /// <summary>
        /// Gets the nanoseconds component of the date represented by this instance truncated to 100 nanosecond resolution
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>The nanoseconds component, expressed as a value between 0 and 99900.</returns>
        public static int Nanosecond(this System.DateTime dt)
        {
            int ns = (int)(dt.Ticks % System.TimeSpan.TicksPerMillisecond % (double)TicksPerMicrosecond) * NanosecondsPerTick;
            int us = (int)System.Math.Floor((dt.Ticks % System.TimeSpan.TicksPerMillisecond) / (double)TicksPerMicrosecond);
            return (us * NanosPerMicro) + ns;
        }

        private static long SubsecondAsNanoseconds(this System.DateTime dt)
        {
            int ns = dt.Nanosecond();
            int ms = dt.Millisecond;
            return (ms * NanosPerMicro * MicrosPerMillis) + ns;
        }

        /// <summary>
        /// Converts the specified dt.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="precision">The precision.</param>
        /// <returns></returns>
        public static string Convert(System.DateTime dt, TimeStampPrecision precision )
        {
            if (precision == TimeStampPrecision.Nanosecond)
            {
                return string.Format(DATE_TIME_FORMAT_WITH_NANOSECONDS, dt, dt.SubsecondAsNanoseconds());
            }
            else
            {
                var format = DATE_TIME_PRECISION_TO_FORMAT[precision];
                return string.Format(format, dt);
            }
        }

        /// <summary>
        /// Convert DateTime to string in FIX Format, with milliseconds
        /// </summary>
        /// <param name="dt">the DateTime to convert</param>
        /// <returns>FIX-formatted DateTime</returns>
        public static string Convert(System.DateTime dt)
        {
            return DateTimeConverter.Convert(dt, true);
        }

        public static string ConvertDateOnly(System.DateTime dt)
        {
            return string.Format(DATE_ONLY_FORMAT, dt);
        }

        public static string ConvertTimeOnly(System.DateTime dt)
        {
            return DateTimeConverter.ConvertTimeOnly(dt, true);
        }

        public static string ConvertTimeOnly( System.DateTime dt, bool includeMilliseconds )
        {
            return includeMilliseconds ? ConvertTimeOnly( dt, TimeStampPrecision.Millisecond ) : ConvertTimeOnly( dt, TimeStampPrecision.Second );
        }

        public static string ConvertTimeOnly(System.DateTime dt, TimeStampPrecision precision)
        {
            if (precision == TimeStampPrecision.Nanosecond)
            {
                return string.Format(TIME_ONLY_FORMAT_WITH_NANOSECONDS, dt, dt.SubsecondAsNanoseconds());
            }
            else
            {
                var format = TIME_ONLY_PRECISION_TO_FORMAT[precision];
                return string.Format(format, dt);
            }
        }
    }
}
