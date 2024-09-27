
namespace QuickFix.Fields.Converters
{
    /// <summary>
    ///  convert Int64 to/from string
    /// </summary>
    public static class AsciiValidator
    {
        public const int ASCII_ZERO = 48;
        public const int ASCII_NINE = 57;
        public const int ASCII_MINUS = 45;

        /// TODO can we use NumberFormatInfo or NumberStyles to avoid this bit of ASCII hackery?
        /// <summary>
        /// Validates that a string looks like a number (for use before conversion to an int, ulong, etc.).
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static void Validate(string i)
        {
            if (i is null || i.Length < 1)
                throw new FieldConvertError("The argument string cannot be null or empty");
            int asciiValOfFirstChar = System.Convert.ToInt32(i[0]);
            if (asciiValOfFirstChar < ASCII_ZERO || asciiValOfFirstChar > ASCII_NINE)
                if (asciiValOfFirstChar != ASCII_MINUS)
                    throw new FieldConvertError("Could not convert string to int (" + i + "): The first character must be a digit or a minus sign");
        }
    }
}
