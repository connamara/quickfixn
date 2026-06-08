using System;

namespace QuickFix.Fields.Converters;

/// <summary>
/// convert Decimal to/from string
/// </summary>
public static class DecimalConverter
{
    private const int ASCII_DECIMALPOINT = 46;

    /// <summary>
    /// convert string to decimal
    /// </summary>
    /// <exception cref="FieldConvertError"/>
    public static decimal Convert(string d)
    {
        try
        {
            if((null == d) || (d.Length < 1))
                throw new FieldConvertError("The argument string cannot be null or empty");
            int asciiValOfFirstChar = System.Convert.ToInt32(d[0]);
            if ((asciiValOfFirstChar < AsciiValidator.ASCII_ZERO) || (asciiValOfFirstChar > AsciiValidator.ASCII_NINE))
                if (asciiValOfFirstChar != AsciiValidator.ASCII_MINUS && asciiValOfFirstChar != ASCII_DECIMALPOINT)
                    throw new FieldConvertError($"Could not convert string to decimal ({d}): The first character must be a digit, decimal point, or minus sign");
            return decimal.Parse(d, System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowLeadingSign | System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture);
        }
        catch (System.OverflowException e)
        {
            throw new FieldConvertError($"Could not convert string to decimal ({d})", e);
        }
        catch (System.FormatException e)
        {
            throw new FieldConvertError($"Could not convert string to decimal ({d})", e);
        }
        catch (System.ArgumentNullException e)
        {
            throw new FieldConvertError("Could not convert null string to decimal", e);
        }
    }

    /// <summary>
    /// convert Decimal to string
    /// </summary>
    public static string Convert(decimal d)
    {
        return d.ToString( System.Globalization.CultureInfo.InvariantCulture );
    }
}
