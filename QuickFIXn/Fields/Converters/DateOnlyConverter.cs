using System;
using System.Globalization;

namespace QuickFix.Fields.Converters;

/// <summary>
/// Convert DateOnly to/from string
/// </summary>
public class DateOnlyConverter
{
    public static DateOnly Convert(string str)
    {
        try
        {
            return DateOnly.ParseExact(str, "yyyyMMdd", CultureInfo.InvariantCulture);
        }
        catch (FormatException e)
        {
            throw new FieldConvertError($"Could not convert string to DateOnly ({str})", e);
        }
        catch (ArgumentNullException e)
        {
            throw new FieldConvertError("Could not convert null string to decimal", e);
        }
    }

    public static string Convert(DateOnly dateOnly)
    {
        return dateOnly.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
    }
}
