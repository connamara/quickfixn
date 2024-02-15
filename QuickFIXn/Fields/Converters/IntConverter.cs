
namespace QuickFix.Fields.Converters
{
    /// <summary>
    ///  convert Int64 to/from string
    /// </summary>
    public static class IntConverter
    {
        /// <summary>
        /// Converts string to int.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Convert(string i)
        {
            try
            {
                AsciiValidator.Validate(i);
                return System.Convert.ToInt32(i);
            }
            catch (System.FormatException e)
            {
                throw new FieldConvertError("Could not convert string to int (" + i + ")", e);
            }
            catch (System.OverflowException e)
            {
                throw new FieldConvertError("Could not convert string to int (" + i + ")", e);
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
