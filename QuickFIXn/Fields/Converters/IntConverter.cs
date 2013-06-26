
namespace QuickFix.Fields.Converters
{
    /// <summary>
    ///  convert Int64 to/from string
    /// </summary>
    public static class IntConverter
    {
        public const int ASCII_ZERO = 48;
        public const int ASCII_NINE = 57;
        public const int ASCII_MINUS = 45;

        /// <summary>
        /// TODO can we use NumberFormatInfo or NumberStyles to avoid this bit of ASCII hackery?
        /// Converts string to int.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Convert(string i)
        {
            try
            {
                if ((null == i) || (i.Length < 1))
                    throw new FieldConvertError("The argument string cannot be null or empty");
                int asciiValOfFirstChar = System.Convert.ToInt32(i[0]);
                if ((asciiValOfFirstChar < ASCII_ZERO) || (asciiValOfFirstChar > ASCII_NINE))
                    if (asciiValOfFirstChar != ASCII_MINUS)
                        throw new FieldConvertError("Could not convert string to int (" + i + "): The first character must be a digit or a minus sign");
                return System.Convert.ToInt32(i);
            }
            catch (System.FormatException e)
            {
                throw new FieldConvertError("Could not convert string to int (" + i + ")", e);
            }
            catch (System.OverflowException e)
            {
                throw new FieldConvertError("Could not convert string to int(" + i + ")", e);
            }
        }

        /// <summary>
        /// convert integer to string
        /// </summary>
        public static string Convert(System.Int64 i)
        {
            return i.ToString();
        }
    }
}
