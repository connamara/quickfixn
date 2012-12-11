using System.Text;
using System.Globalization;

namespace QuickFix.Fields.Converters
{
    /// <summary>
    /// Convert DateTime to/from String
    /// </summary>
    public static class DateTimeConverter
    {
        public const string DATE_TIME_FORMAT_WITH_MILLISECONDS = "{0:yyyyMMdd-HH:mm:ss.fff}";
        public const string DATE_TIME_FORMAT_WITHOUT_MILLISECONDS = "{0:yyyyMMdd-HH:mm:ss}";
        public const string DATE_ONLY_FORMAT = "{0:yyyyMMdd}";
        public const string TIME_ONLY_FORMAT_WITH_MILLISECONDS = "{0:HH:mm:ss.fff}";
        public const string TIME_ONLY_FORMAT_WITHOUT_MILLISECONDS = "{0:HH:mm:ss}";
        public static string[] DATE_TIME_FORMATS = { "yyyyMMdd-HH:mm:ss.fff", "yyyyMMdd-HH:mm:ss" };
        public static string[] DATE_ONLY_FORMATS = { "yyyyMMdd" };
        public static string[] TIME_ONLY_FORMATS = { "HH:mm:ss.fff", "HH:mm:ss" };
        public static DateTimeStyles DATE_TIME_STYLES = DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal;
        public static CultureInfo DATE_TIME_CULTURE_INFO = CultureInfo.InvariantCulture;

        /// <summary>
        /// Convert string to DateTime
        /// </summary>
        /// <exception cref="FieldConvertError"/>
        public static System.DateTime ConvertToDateTime(string str)
        {
            try
            {
                return System.DateTime.ParseExact(str, DATE_TIME_FORMATS, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES);
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
        /// Check if string is TimeOnly and, if yes, convert to DateTime
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <exception cref="FieldConvertError"/>
        public static System.DateTime ConvertToTimeOnly(string str)
        {
            try
            {
                System.DateTime d = System.DateTime.ParseExact(str, TIME_ONLY_FORMATS, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES);
                return new System.DateTime(1980, 1, 1, d.Hour, d.Minute, d.Second, d.Millisecond);
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
                return new System.TimeSpan(d.Hour, d.Minute, d.Second, d.Millisecond);
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
        public static string Convert(System.DateTime dt, bool includeMilliseconds)
        {
            if(includeMilliseconds)
                return string.Format(DATE_TIME_FORMAT_WITH_MILLISECONDS, dt);
            return string.Format(DATE_TIME_FORMAT_WITHOUT_MILLISECONDS, dt);
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

        public static string ConvertTimeOnly(System.DateTime dt, bool includeMilliseconds)
        {
            if (includeMilliseconds)
                return string.Format(TIME_ONLY_FORMAT_WITH_MILLISECONDS, dt);
            return string.Format(TIME_ONLY_FORMAT_WITHOUT_MILLISECONDS, dt);
        }
    }
}
