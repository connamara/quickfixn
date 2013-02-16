
namespace QuickFix.Fields.Converters
{
    public static class CheckSumConverter
    {
        public static int Convert(string i)
        {
            return IntConverter.Convert(i);
        }

        public static string Convert(int i)
        {
            return i.ToString("000");
        }
    }
}
