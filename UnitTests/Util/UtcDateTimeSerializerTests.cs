using System;
using NUnit.Framework;
using QuickFix.Util;


namespace UnitTests.Util
{
    [TestFixture]
    public class UtcDateTimeSerializerTests
    {
        /// <summary>
        /// A little precision is lost in the serialization, so exact equality doesn't happen.
        /// This is an adequate test kludge.
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        static public void AssertHackyDateTimeEquality(DateTime d1, DateTime d2)
        {
            Assert.That(d2.Kind, Is.EqualTo(d1.Kind), "kind");
            Assert.That(d2.Date, Is.EqualTo(d1.Date), "date");
            Assert.That(d2.Hour, Is.EqualTo(d1.Hour), "hours");
            Assert.That(d2.Minute, Is.EqualTo(d1.Minute), "minutes");
            Assert.That(d2.Second, Is.EqualTo(d1.Second), "seconds");
            Assert.That(d2.Millisecond, Is.EqualTo(d1.Millisecond), "milliseconds");
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
