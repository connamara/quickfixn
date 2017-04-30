using NUnit.Framework;
using QuickFix;
using QuickFix.Util;

namespace UnitTests.Util
{
	[TestFixture]
	class FieldMapComparerTests
	{
		[Test]
		public void TwoNullsEqual()
		{
			// arrange
			FieldMap m1 = null;
			FieldMap m2 = null;
			var comparer = new FieldMapComparer();

			// act
			bool result = comparer.Equals(m1, m2);

			// assert
			Assert.AreEqual(true, result);
		}

		[Test]
		public void NullAndInstanceAreNotEqual()
		{
			// arrange
			FieldMap m1 = null;
			FieldMap m2 = new FieldMap();
			var comparer = new FieldMapComparer();

			// act
			bool result1 = comparer.Equals(m1, m2);
			bool result2 = comparer.Equals(m2, m1);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}

		[Test]
		public void SameFieldsAndValuesAreEqual()
		{
			// arrange
			string[] fields1 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=0"
			};
			string[] fields2 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=0"
			};

			Message m1 = new Message();
			Message m2 = new Message();
			m1.FromStringHeader(UnitTestHelpers.CreateMessageStringFromParts(fields1));
			m2.FromStringHeader(UnitTestHelpers.CreateMessageStringFromParts(fields2));
			var comparer = new FieldMapComparer();

			// act
			bool result1 = comparer.Equals(m1.Header, m2.Header);
			bool result2 = comparer.Equals(m2.Header, m1.Header);

			// assert
			Assert.AreEqual(true, result1);
			Assert.AreEqual(true, result2);
		}

		[Test]
		public void SameFieldsButDifferentValuesAreNotEqual()
		{
			// arrange
			string[] fields1 = new string[]
			{
				"8=FIX.4.2", "9=55", "35=0"
			};
			string[] fields2 = new string[]
			{
				"8=FIX.4.3", "9=55", "35=0"
			};

			Message m1 = new Message();
			Message m2 = new Message();
			m1.FromStringHeader(UnitTestHelpers.CreateMessageStringFromParts(fields1));
			m2.FromStringHeader(UnitTestHelpers.CreateMessageStringFromParts(fields2));
			var comparer = new FieldMapComparer();

			// act
			bool result1 = comparer.Equals(m1.Header, m2.Header);
			bool result2 = comparer.Equals(m2.Header, m1.Header);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}

		[Test]
		public void MissingOrExtraFieldAreNotEqual()
		{
			// arrange
			string[] fields1 = new string[]
			{
				"8=FIX.4.3", "9=55", "35=0"
			};
			string[] fields2 = new string[]
			{
				"8=FIX.4.3", "35=0"
			};

			Message m1 = new Message();
			Message m2 = new Message();
			m1.FromStringHeader(UnitTestHelpers.CreateMessageStringFromParts(fields1));
			m2.FromStringHeader(UnitTestHelpers.CreateMessageStringFromParts(fields2));
			var comparer = new FieldMapComparer();

			// act
			bool result1 = comparer.Equals(m1.Header, m2.Header);
			bool result2 = comparer.Equals(m2.Header, m1.Header);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}

		[Test]
		public void FieldWithMissingValueCausesNotEqual()
		{
			// arrange
			string[] fields1 = new string[]
			{
				"8=FIX.4.3", "9=55", "35=0"
			};
			string[] fields2 = new string[]
			{
				"8=FIX.4.3", "9=55", "35="
			};

			Message m1 = new Message();
			Message m2 = new Message();
			m1.FromStringHeader(UnitTestHelpers.CreateMessageStringFromParts(fields1));
			m2.FromStringHeader(UnitTestHelpers.CreateMessageStringFromParts(fields2));
			var comparer = new FieldMapComparer();

			// act
			bool result1 = comparer.Equals(m1.Header, m2.Header);
			bool result2 = comparer.Equals(m2.Header, m1.Header);

			// assert
			Assert.AreEqual(false, result1);
			Assert.AreEqual(false, result2);
		}

	}
}
