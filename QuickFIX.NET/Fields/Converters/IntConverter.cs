using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET.Fields.Converters
{
    /// <summary>
    ///  convert Int64 to/from string
    /// </summary>
    public static class IntConverter
    {
        /// <summary>
        /// Converts string to int
        /// </summary>
        /// <exception cref="BadConversionException"/>
        public static Int64 Convert(string i)
        {
            try
            {
                return System.Convert.ToInt64(i);
            }
            catch (FormatException e)
            {
                throw new BadConversionException("could not convert string to int", e);
            }
            catch (OverflowException e)
            {
                throw new BadConversionException("could not convert string to int", e);
            }
        }

        /// <summary>
        /// convert integer to string
        /// </summary>
        public static string Convert(Int64 i)
        {
            return i.ToString();
        }
    }
}
