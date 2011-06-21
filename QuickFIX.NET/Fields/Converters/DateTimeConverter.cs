using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Fields.Converters
{
    /// <summary>
    /// Convert DateTime to/from String
    /// </summary>
    public static class DateTimeConverter
    {
        /// <summary>
        /// Convert string to DateTime
        /// </summary>
        /// <exception cref="BadConversionException"/>
        public static DateTime Convert(string str)
        {
            try
            {
                return System.Convert.ToDateTime(str);
            }
            catch (FormatException e)
            {
                throw new FieldConvertError("could not convert string to DateTime, str=" + str, e);
            }

        }

        /// <summary>
        /// Convert DateTime to String in FIX Format
        /// </summary>
        /// <returns>yyyyMMdd-HH:mm:ss</returns>
        public static string Convert(DateTime dt)
        {
            return String.Format("{0:yyyyMMdd-HH:mm:ss}", dt);
        }
    }
}
