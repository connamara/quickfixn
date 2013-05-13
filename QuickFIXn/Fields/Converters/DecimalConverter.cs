using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Fields.Converters
{
    /// <summary>
    /// convert Decimal to/from string
    /// </summary>
    public static class DecimalConverter
    {
        private const int ASCII_DECIMALPOINT = 46;

        /// <summary>
        /// convert string to decimal
        /// </summary>
        /// <exception cref="BadConversionException"/>
        public static Decimal Convert(string d)
        {
            try
            {
                if((null == d) || (d.Length < 1))
                    throw new FieldConvertError("The argument string cannot be null or empty");
                int asciiValOfFirstChar = System.Convert.ToInt32(d[0]);
                if ((asciiValOfFirstChar < IntConverter.ASCII_ZERO) || (asciiValOfFirstChar > IntConverter.ASCII_NINE))
                    if (asciiValOfFirstChar != IntConverter.ASCII_MINUS && asciiValOfFirstChar != ASCII_DECIMALPOINT)
                        throw new FieldConvertError("Could not convert string to decimal (" + d + "): The first character must be a digit, decimal point, or minus sign");
                return System.Convert.ToDecimal( d, System.Globalization.CultureInfo.InvariantCulture );
            }
            catch (System.OverflowException e)
            {
                throw new FieldConvertError("Could not convert string to decimal (" + d + ")", e);
            }
            catch (System.FormatException e)
            {
                throw new FieldConvertError("Could not convert string to decimal (" + d + ")", e);
            }
            catch (System.ArgumentNullException e)
            {
                throw new FieldConvertError("Could not convert string to decimal (" + d + ")", e);
            }
        }

        /// <summary>
        /// convert Decimal to string
        /// </summary>
        public static string Convert(Decimal d)
        {
            return d.ToString( System.Globalization.CultureInfo.InvariantCulture );
        }

    }
}
