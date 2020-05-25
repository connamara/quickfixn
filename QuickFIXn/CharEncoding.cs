namespace QuickFix
{
    public static class CharEncoding
    {
        public static System.Text.Encoding DefaultEncoding;

        static CharEncoding()
        {
            DefaultEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
        }
    }
}
