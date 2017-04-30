using System;
using System.Linq;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;
using QuickFix.Util;

namespace UnitTests.Util
{
	[TestFixture]
	class MessageComparerTests
	{
		private IMessageFactory _defaultMsgFactory = new DefaultMessageFactory();

		[Test]
		public void TwoNullsEqual()
		{
			// arrange
			Message m1 = null;
			Message m2 = null;
			var comparer = new MessageComparer();

			// act
			bool result = comparer.Equals(m1, m2);

			// assert
			Assert.AreEqual(true, result);
		}

		[Test]
		public void NullAndInstanceAreNotEqual()
		{
			// arrange
			Message m1 = null;
			Message m2 = new Message();
			var comparer = new MessageComparer();

			// act
			bool result1 = comparer.Equals(m1, m2);
			bool result2 = comparer.Equals(m2, m1);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}

		[Test]
		public void SameMessagesAreEqual()
		{
			// arrange
			string[] fields1 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=0", "34=3", "49=TW",
				"52=20000426-12:05:06", "56=ISLD", "1=acct123", "10=123"
			};
			string[] fields2 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=0", "34=3", "49=TW",
				"52=20000426-12:05:06", "56=ISLD", "1=acct123", "10=123"
			};
			
			Message m1 = new Message(UnitTestHelpers.CreateMessageStringFromParts(fields1));
			Message m2 = new Message(UnitTestHelpers.CreateMessageStringFromParts(fields2));
			var comparer = new MessageComparer();

			// act
			bool result1 = comparer.Equals(m1, m2);
			bool result2 = comparer.Equals(m2, m1);

			// assert
			Assert.AreEqual(true, result1);
			Assert.AreEqual(true, result2);
		}

		[Test]
		public void MessagesWithDifferentHeaderAreNotEqual()
		{
			// arrange
			string[] fields1 = new string[]
			{
				"8=FIX.4.3", "9=55", "35=0", "34=3", "49=TW",
				"52=20000426-12:05:06", "56=ISLD", "1=acct123", "10=124"
			};
			string[] fields2 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=1", "34=3", "49=TW",
				"52=20000426-12:05:06", "56=ISLD", "1=acct123", "10=124"
			};

			Message m1 = new Message(UnitTestHelpers.CreateMessageStringFromParts(fields1));
			Message m2 = new Message(UnitTestHelpers.CreateMessageStringFromParts(fields2));
			var comparer = new MessageComparer();

			// act
			bool result1 = comparer.Equals(m1, m2);
			bool result2 = comparer.Equals(m2, m1);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}

		[Test]
		public void MessagesWithDifferentContentAreNotEqual()
		{
			// arrange
			string[] fields1 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=0", "34=3", "49=TW",
				"52=20000426-12:05:06", "56=ISLD", "1=acct123", "10=123"
			};
			string[] fields2 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=0", "34=3", "49=TW",
				"52=20000426-12:05:06", "56=ISLD", "1=bbct123", "10=123"
			};

			Message m1 = new Message(UnitTestHelpers.CreateMessageStringFromParts(fields1));
			Message m2 = new Message(UnitTestHelpers.CreateMessageStringFromParts(fields2));
			var comparer = new MessageComparer();

			// act
			bool result1 = comparer.Equals(m1, m2);
			bool result2 = comparer.Equals(m2, m1);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}

		[Test]
		public void MessagesWithDifferentTrailerAreNotEqual()
		{
			// arrange
			string[] fields1 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=0", "34=3", "49=TW",
				"52=20000426-12:05:06", "56=ISLD", "1=acct123", "10=123"
			};
			string[] fields2 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=0", "34=3", "49=TW",
				"52=20000426-12:05:06", "56=ISLD", "1=acct123", "10=123"
			};

			Message m1 = new Message(UnitTestHelpers.CreateMessageStringFromParts(fields1));
			Message m2 = new Message(UnitTestHelpers.CreateMessageStringFromParts(fields2));
			m2.Trailer.SetField(new CheckSum("124"));
			var comparer = new MessageComparer();

			// act
			bool result1 = comparer.Equals(m1, m2);
			bool result2 = comparer.Equals(m2, m1);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}

		[Test]
		public void MessagesWithGroupsAreEqual()
		{
			// arrange
			String data = "8=FIX.4.4\x01" + "9=309\x01" + "35=8\x01" + "49=ASX\x01" + "56=CL1_FIX44\x01" + "34=4\x01" + "52=20060324-01:05:58\x01" + ""
		+ "17=X-B-WOW-1494E9A0:58BD3F9D-1109\x01" + "150=D\x01" + "39=0\x01" + "11=184271\x01" + "38=200\x01" + "198=1494E9A0:58BD3F9D\x01" + ""
		+ "526=4324\x01" + "37=B-WOW-1494E9A0:58BD3F9D\x01" + "55=WOW\x01" + "54=1\x01" + "151=200\x01" + "14=0\x01" + "40=2\x01" + "44=15\x01" + "59=1\x01" + "6=0\x01" + ""
		+ "453=3\x01"
			+ "448=AAA35791\x01" + "447=D\x01" + "452=3\x01" + "802=1\x01" + "523=OHAI123\x01"
			+ "448=8\x01" + "447=D\x01" + "452=4\x01"
			+ "448=FIX11\x01" + "447=D\x01" + "452=36\x01" + ""
		+ "60=20060320-03:34:29\x01" + "10=169\x01" + "";
			
			var dd = new QuickFix.DataDictionary.DataDictionary();
			dd.Load("../../../spec/fix/FIX44.xml");

			var m1 = new QuickFix.FIX44.ExecutionReport();
			var m2 = new QuickFix.FIX44.ExecutionReport();
			m1.FromString(data, false, dd, dd, _defaultMsgFactory);
			m2.FromString(data, false, dd, dd, _defaultMsgFactory);

			var comparer = new MessageComparer();

			// act
			bool result1 = comparer.Equals(m1, m2);
			bool result2 = comparer.Equals(m2, m1);

			// assert
			Assert.AreEqual(true, result1);
			Assert.AreEqual(true, result2);
		}

		[Test]
		public void MessagesWithDifferentGroupsContentAreNotEqual()
		{
			// arrange
			String data1 = "8=FIX.4.4\x01" + "9=309\x01" + "35=8\x01" + "49=ASX\x01" + "56=CL1_FIX44\x01" + "34=4\x01" + "52=20060324-01:05:58\x01" + ""
		+ "17=X-B-WOW-1494E9A0:58BD3F9D-1109\x01" + "150=D\x01" + "39=0\x01" + "11=184271\x01" + "38=200\x01" + "198=1494E9A0:58BD3F9D\x01" + ""
		+ "526=4324\x01" + "37=B-WOW-1494E9A0:58BD3F9D\x01" + "55=WOW\x01" + "54=1\x01" + "151=200\x01" + "14=0\x01" + "40=2\x01" + "44=15\x01" + "59=1\x01" + "6=0\x01" + ""
		+ "453=3\x01"
			+ "448=AAA35791\x01" + "447=D\x01" + "452=3\x01" + "802=1\x01" + "523=OHAI123\x01"
			+ "448=8\x01" + "447=D\x01" + "452=4\x01"
			+ "448=FIX11\x01" + "447=D\x01" + "452=36\x01" + ""
		+ "60=20060320-03:34:29\x01" + "10=169\x01" + "";
			String data2 = "8=FIX.4.4\x01" + "9=309\x01" + "35=8\x01" + "49=ASX\x01" + "56=CL1_FIX44\x01" + "34=4\x01" + "52=20060324-01:05:58\x01" + ""
		+ "17=X-B-WOW-1494E9A0:58BD3F9D-1109\x01" + "150=D\x01" + "39=0\x01" + "11=184271\x01" + "38=200\x01" + "198=1494E9A0:58BD3F9D\x01" + ""
		+ "526=4324\x01" + "37=B-WOW-1494E9A0:58BD3F9D\x01" + "55=WOW\x01" + "54=1\x01" + "151=200\x01" + "14=0\x01" + "40=2\x01" + "44=15\x01" + "59=1\x01" + "6=0\x01" + ""
		+ "453=3\x01"
			+ "448=AAA35791\x01" + "447=D\x01" + "452=3\x01" + "802=1\x01" + "523=OHAI123\x01"
			+ "448=7\x01" + "447=D\x01" + "452=5\x01" // here is the difference
			+ "448=FIX11\x01" + "447=D\x01" + "452=36\x01" + ""
		+ "60=20060320-03:34:29\x01" + "10=169\x01" + "";


			var dd = new QuickFix.DataDictionary.DataDictionary();
			dd.Load("../../../spec/fix/FIX44.xml");

			var m1 = new QuickFix.FIX44.ExecutionReport();
			var m2 = new QuickFix.FIX44.ExecutionReport();
			m1.FromString(data1, false, dd, dd, _defaultMsgFactory);
			m2.FromString(data2, false, dd, dd, _defaultMsgFactory);

			var comparer = new MessageComparer();

			// act
			bool result1 = comparer.Equals(m1, m2);
			bool result2 = comparer.Equals(m2, m1);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}

		[Test]
		public void MessagesWithDifferentNumberOfGroupsAreNotEqual()
		{
			// arrange
			String data1 = "8=FIX.4.4\x01" + "9=309\x01" + "35=8\x01" + "49=ASX\x01" + "56=CL1_FIX44\x01" + "34=4\x01" + "52=20060324-01:05:58\x01" + ""
		+ "17=X-B-WOW-1494E9A0:58BD3F9D-1109\x01" + "150=D\x01" + "39=0\x01" + "11=184271\x01" + "38=200\x01" + "198=1494E9A0:58BD3F9D\x01" + ""
		+ "526=4324\x01" + "37=B-WOW-1494E9A0:58BD3F9D\x01" + "55=WOW\x01" + "54=1\x01" + "151=200\x01" + "14=0\x01" + "40=2\x01" + "44=15\x01" + "59=1\x01" + "6=0\x01" + ""
		+ "453=3\x01"
			+ "448=AAA35791\x01" + "447=D\x01" + "452=3\x01" + "802=1\x01" + "523=OHAI123\x01"
			+ "448=8\x01" + "447=D\x01" + "452=4\x01"
			+ "448=FIX11\x01" + "447=D\x01" + "452=36\x01" + ""
		+ "60=20060320-03:34:29\x01" + "10=169\x01" + "";
			String data2 = "8=FIX.4.4\x01" + "9=309\x01" + "35=8\x01" + "49=ASX\x01" + "56=CL1_FIX44\x01" + "34=4\x01" + "52=20060324-01:05:58\x01" + ""
		+ "17=X-B-WOW-1494E9A0:58BD3F9D-1109\x01" + "150=D\x01" + "39=0\x01" + "11=184271\x01" + "38=200\x01" + "198=1494E9A0:58BD3F9D\x01" + ""
		+ "526=4324\x01" + "37=B-WOW-1494E9A0:58BD3F9D\x01" + "55=WOW\x01" + "54=1\x01" + "151=200\x01" + "14=0\x01" + "40=2\x01" + "44=15\x01" + "59=1\x01" + "6=0\x01" + ""
		+ "453=3\x01"
			+ "448=AAA35791\x01" + "447=D\x01" + "452=3\x01" + "802=1\x01" + "523=OHAI123\x01"
			// this is missing + "448=7\x01" + "447=D\x01" + "452=5\x01" 
			+ "448=FIX11\x01" + "447=D\x01" + "452=36\x01" + ""
		+ "60=20060320-03:34:29\x01" + "10=169\x01" + "";


			var dd = new QuickFix.DataDictionary.DataDictionary();
			dd.Load("../../../spec/fix/FIX44.xml");

			var m1 = new QuickFix.FIX44.ExecutionReport();
			var m2 = new QuickFix.FIX44.ExecutionReport();
			m1.FromString(data1, false, dd, dd, _defaultMsgFactory);
			m2.FromString(data2, false, dd, dd, _defaultMsgFactory);

			var comparer = new MessageComparer();

			// act
			bool result1 = comparer.Equals(m1, m2);
			bool result2 = comparer.Equals(m2, m1);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}
	}
}
