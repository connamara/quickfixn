using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Fields.Converters
{
    /// <summary>
    /// Converts Boolean to/from string
    /// </summary>
    public static class BoolConverter
    {
        /// <summary>
        /// Converts boolean to string
        /// </summary>
        /// <param name="b"></param>
        /// <returns>"Y" for true, "N" for false</returns>
        public static string Convert(Boolean b)
        {
            return b ? "Y" : "N";
        }

        /// <summary>
        /// converts string to boolean
        /// </summary>
        /// <param name="boolstr"></param>
        /// <returns>true for "Y", false for "N"</returns>
        /// <exception cref="BadConversionException"/>
        public static Boolean Convert(string boolstr)
        {
            switch (boolstr)
            {
                case "Y": return true;
                case "N": return false;
                default: throw new FieldConvertError("Cannot convert string to boolean");
            }
        }
    }
}
