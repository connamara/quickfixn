using System;

namespace QuickFix.Util
{
    internal static class ExceptionExtensions
    {
        public static string GetFullMessage(this Exception ex)
        {
            return ex.InnerException == null
                ? ex.Message
                : ex.Message + " --> " + ex.InnerException.GetFullMessage();
        }
    }
}
