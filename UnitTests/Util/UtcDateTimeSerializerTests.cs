using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFix.Util;


namespace UnitTests.Util
{
    [TestFixture]
    class UtcDateTimeSerializerTests
    {
        /// <summary>
        /// A little precision is lost in the serialization, so exact equality doesn't happen.
        /// This is an adequate test kludge.
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        static public void AssertHackyDateTimeEquality(DateTime d1, DateTime d2)
        {
            Assert.AreEqual(d1.Kind, d2.Kind);
            Assert.AreEqual(d1.Date, d2.Date);
            Assert.AreEqual(d1.Hour, d2.Hour);
            Assert.AreEqual(d1.Minute, d2.Minute);
            Assert.AreEqual(d1.Second, d2.Second);
            Assert.AreEqual(d1.Millisecond, d2.Millisecond);
        }

        [Test]
        public void BackAndForth()
        {
            DateTime d1 = DateTime.UtcNow;
            DateTime d2 = UtcDateTimeSerializer.FromString(
                UtcDateTimeSerializer.ToString(d1));

            AssertHackyDateTimeEquality(d1, d2);
        }

        [Test]
        public void SomeDates()
        {
            DateTime d1 = new DateTime(2013, 1, 1, 1, 1, 1, 1, DateTimeKind.Utc);
            DateTime d6 = new DateTime(2013, 6, 6, 6, 6, 6, 6, DateTimeKind.Utc);

            DateTime d1b = UtcDateTimeSerializer.FromString(
                UtcDateTimeSerializer.ToString(d1));
            DateTime d6b = UtcDateTimeSerializer.FromString(
                UtcDateTimeSerializer.ToString(d6));

            AssertHackyDateTimeEquality(d1b, d1b);
            AssertHackyDateTimeEquality(d6b, d6b);
        }
    }
}
