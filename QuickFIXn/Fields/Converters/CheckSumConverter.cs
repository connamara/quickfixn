namespace QuickFix.Fields.Converters
{
    public static class CheckSumConverter
    {
        /// <summary>
        /// Convert input string to int
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Convert(string i)
        {
            return IntConverter.Convert(i);
        }

        /// <summary>
        /// Convert input int to 3-character string
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string Convert(int i)
        {
            return i.ToString("000");
        }
    }
}
