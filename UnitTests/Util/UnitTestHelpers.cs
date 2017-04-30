using System;
using QuickFix;

namespace UnitTests.Util
{
	internal class UnitTestHelpers
	{
		public static string CreateMessageStringFromParts(string[] fields)
		{
			return String.Join(Message.SOH, fields) + Message.SOH;
		}
	}
}
