
namespace QuickFix.Fields.Converters
{
    /// <summary>
    ///  convert UInt64 to/from string
    /// </summary>
    public static class SequenceConverter
    {
        /// <summary>
        /// Converts sequence number string to ulong.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static ulong Convert(string i)
        {
            try
            {
                if ((null == i) || (i.Length < 1))
                    throw new FieldConvertError("The argument string cannot be null or empty");

                return System.Convert.ToUInt64(i);
            }
            catch (System.FormatException e)
            {
                throw new FieldConvertError("Could not convert string to unsigned long (" + i + ")", e);
            }
            catch (System.OverflowException e)
            {
                throw new FieldConvertError("Could not convert string to unsigned long (" + i + ")", e);
            }
        }

        /// <summary>
        /// convert integer to string
        /// </summary>
        public static string Convert(System.UInt64 i)
        {
            return i.ToString();
        }
    }
}
