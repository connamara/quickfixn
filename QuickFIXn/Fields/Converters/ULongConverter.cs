
namespace QuickFix.Fields.Converters
{
    /// <summary>
    ///  convert UInt64 to/from string
    /// </summary>
    public static class ULongConverter
    {
        /// <summary>
        /// Converts string to ulong.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static ulong Convert(string i)
        {
            try
            {
                AsciiValidator.Validate(i);
                return System.Convert.ToUInt64(i);
            }
            catch (System.FormatException e)
            {
                throw new FieldConvertError("Could not convert string to ulong (" + i + ")", e);
            }
            catch (System.OverflowException e)
            {
                throw new FieldConvertError("Could not convert string to ulong (" + i + ")", e);
            }
        }

        /// <summary>
        /// convert ulong to string
        /// </summary>
        public static string Convert(System.UInt64 i)
        {
            return i.ToString();
        }
    }
}
