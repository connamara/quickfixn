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
        /// <summary>
        /// convert string to decimal
        /// </summary>
        /// <exception cref="BadConversionException"/>
        public static Decimal Convert(string stringVal)
        {
            try
            {
                return System.Convert.ToDecimal(stringVal);
            }
            catch (System.OverflowException e)
            {
                throw new FieldConvertError(
                    "could not convert string to decimal, str=" + stringVal, e);
            }
            catch (System.FormatException e)
            {
                throw new FieldConvertError(
                    "could not convert string to decimal, str=" + stringVal, e);
            }
            catch (System.ArgumentNullException e)
            {
                throw new FieldConvertError(
                    "could not convert string to decimal, str=" + stringVal, e);
            }
        }

        /// <summary>
        /// convert Decimal to string
        /// </summary>
        public static string Convert(Decimal d)
        {
            return d.ToString();
        }

    }
}
