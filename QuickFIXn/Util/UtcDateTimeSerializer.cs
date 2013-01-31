using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Util
{
    /// <summary>
    /// Utility class for serializing/deserializing a date (which is strangely not-trivial in C#).
    /// Don't use these in your client app.
    /// </summary>
    public static class UtcDateTimeSerializer
    {
        private const string FORMAT = "yyyyMMdd-HH:mm:ss.ffffff K";

        /// <summary>
        /// Not for use by client apps.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        static public string ToString(DateTime d)
        {
            return d.ToString(FORMAT);
        }

        /// <summary>
        /// Not for use by client apps.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static public DateTime FromString(string s)
        {
            try
            {
                DateTime d = DateTime.ParseExact(s, FORMAT,
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.AdjustToUniversal);
                return d;
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }
    }
}
