using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Fields.Converters
{
    /// <summary>
    /// Converts char to/from string
    /// </summary>
    public static class CharConverter
    {
        /// <summary>
        /// Convert string to char
        /// </summary>
        /// <exception cref="BadConversionException"/>
        public static char Convert(string c)
        {
            if (c.Length != 1)
                throw new FieldConvertError("could not convert string to char, str=" + c);
            return c[0];
        }

        /// <summary>
        /// Converts char to string
        /// </summary>
        public static string Convert(char c)
        {
            return c.ToString();
        }
    }
}
