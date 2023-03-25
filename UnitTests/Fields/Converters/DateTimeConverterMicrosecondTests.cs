using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields.Converters
{
    [TestFixture]
    public class DateTimeConverterMicrosecondTests
    {
        public static DateTime makeDateTime(int y, int m, int d, int h, int min, int s, int ms, int us, int ns)
        {
            // already includes ms
            DateTime dt = new DateTime(y, m, d, h, min, s, ms);

            const int TicksPerMicrosecond = 10;
            const int NanosecondsPerTick = 100;

            return dt.AddTicks((us * TicksPerMicrosecond) + (ns / NanosecondsPerTick));
        }

        public static DateTime makeTimeOnly(int h, int m, int s, int ms, int us, int ns)
        {
            return makeDateTime(1980, 1, 1, h, m, s, ms, us, ns);
        }
        
        [Test]
        public void TestNanosecondPrecision()
        {
            // seeded DateTime
            DateTime dt = DateTime.SpecifyKind(makeDateTime(2002, 12, 01, 11, 03, 05, 231, 116, 500), DateTimeKind.Utc);

            // convert nanosecond DateTime to string with option
            Assert.That(DateTimeConverter.ToFIX(dt, TimeStampPrecision.Nanosecond), Is.EqualTo("20021201-11:03:05.231116500"));

            // convert nanosecond DateTime to time-only string
            Assert.That(DateTimeConverter.ToFIXTimeOnly(dt, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.231116500"));

            // convert nanosecond time string to DateTime time portion only
            DateTime timeOnly = makeTimeOnly(11, 03, 05, 231, 116, 500);
            Assert.That(DateTimeConverter.ParseToTimeOnly("11:03:05.231116500"), Is.EqualTo(timeOnly));

            // convert nanosecond time string to full DateTime
            Assert.That(DateTimeConverter.ParseToDateTime("20021201-11:03:05.231116500"), Is.EqualTo(dt));

            // convert nanosecond time with UTC time zone to full DateTime
            Assert.That(DateTimeConverter.ParseToDateTime("20021201-11:03:05.231116500Z"), Is.EqualTo(dt));

            // convert nanosecond time with non-UTC positive offset time zone to full DateTime
            Assert.That(DateTimeConverter.ParseToDateTime("20021201-16:03:05.231116500+05"), Is.EqualTo(dt));

            // convert nanosecond time with non-UTC negative offset time zone to full DateTime
            Assert.That(DateTimeConverter.ParseToDateTime("20021201-08:03:05.231116500-03"), Is.EqualTo(dt));

            // convert nanosecond time in local time (no time zone) to full DateTime
            DateTime local = DateTime.SpecifyKind(makeDateTime(2002, 12, 01, 11, 03, 05, 231, 116, 500), DateTimeKind.Local);
            Assert.That(DateTimeConverter.ParseToDateTime("20021201-11:03:05.231116500"), Is.EqualTo(local));
        }
        
        [Test]
        public void CanConvertFromDateTimeStringWithNanosecondsToValidDateTimeObject()
        {
            //GIVEN - a datetime string with nanoseconds
            var dateTimeStringWithNanoseconds = "20170305-13:22:12.123456789";
            var dateTimeStringWithNanosecondsTruncated = "20170305-13:22:12.123456700";

            //WHEN - it is converted to a date time
            var convertedDateTime = DateTimeConverter.ParseToDateTime(dateTimeStringWithNanoseconds);

            //THEN - the date time object is setup correctly
            Assert.That(2017, Is.EqualTo(convertedDateTime.Year));
            Assert.That(3, Is.EqualTo(convertedDateTime.Month));
            Assert.That(5, Is.EqualTo(convertedDateTime.Day));
            Assert.That(13, Is.EqualTo(convertedDateTime.Hour));
            Assert.That(22, Is.EqualTo(convertedDateTime.Minute));
            Assert.That(12, Is.EqualTo(convertedDateTime.Second));
            Assert.That(123, Is.EqualTo(convertedDateTime.Millisecond));
            Assert.That(456700, Is.EqualTo(convertedDateTime.Nanosecond())); //100 Nanosecond Truncated Resolution
            Assert.That(dateTimeStringWithNanosecondsTruncated, Is.EqualTo(DateTimeConverter.ToFIX(convertedDateTime, TimeStampPrecision.Nanosecond)));
        }

        [Test]
        [TestCaseSource(nameof(DateTimeData))]
        public void DateTimeTests(DateTimeTest t)
        {
            DateTime actualDateTime = DateTimeConverter.ParseToDateTime(t.InputString, out DateTimeOffset? actualDateTimeOffset);
            AssertEqual(t.ExpectedDateTime, actualDateTime);
            AssertEqual(t.ExpectedDateTimeOffset, actualDateTimeOffset);
            Assert.That(t.ExpectedStringSeconds, Is.EqualTo(DateTimeConverter.ToFIX(actualDateTime, TimeStampPrecision.Second)));
            Assert.That(t.ExpectedStringSeconds, Is.EqualTo(DateTimeConverter.ToFIX(actualDateTime, includeMilliseconds: false)));
            Assert.That(t.ExpectedStringMillis, Is.EqualTo(DateTimeConverter.ToFIX(actualDateTime, TimeStampPrecision.Millisecond)));
            Assert.That(t.ExpectedStringMillis, Is.EqualTo(DateTimeConverter.ToFIX(actualDateTime, includeMilliseconds: true)));
            Assert.That(t.ExpectedStringMillis, Is.EqualTo(DateTimeConverter.ToFIX(actualDateTime)));
            Assert.That(t.ExpectedStringMicros, Is.EqualTo(DateTimeConverter.ToFIX(actualDateTime, TimeStampPrecision.Microsecond)));
            Assert.That(t.ExpectedStringNanos, Is.EqualTo(DateTimeConverter.ToFIX(actualDateTime, TimeStampPrecision.Nanosecond)));
        }

        /// <summary>
        /// Verifies that two <see cref="DateTime"/> objects are equal, including their
        /// <see cref="DateTime.Kind"/> properties which is not covered by <see cref="DateTime.Equals(DateTime)"/>
        /// </summary>
        private static void AssertEqual(DateTime expected, DateTime actual)
        {
            Assert.That(expected, Is.EqualTo(actual));
            Assert.That(expected.Kind, Is.EqualTo(actual.Kind));
        }

        /// <summary>
        /// Verifies that two <see cref="DateTimeOffset"/> objects are equal, including their
        /// <see cref="DateTimeOffset.Offset"/> properties by calling <see cref="DateTimeOffset.EqualsExact(DateTimeOffset)"/>
        /// </summary>
        private static void AssertEqual(DateTimeOffset? expected, DateTimeOffset? actual)
        {
            Assert.That(expected, Is.EqualTo(actual));
            if (expected != null && actual != null)
            {
                Assert.That(expected.Value.EqualsExact(actual.Value), Is.EqualTo(true));
            }
        }

        public record DateTimeTest(
            string InputString,
            DateTime ExpectedDateTime,
            DateTimeOffset? ExpectedDateTimeOffset,
            string ExpectedStringSeconds,
            string ExpectedStringMillis,
            string ExpectedStringMicros,
            string ExpectedStringNanos);

        private static IEnumerable<DateTimeTest> DateTimeData()
        {
            yield return new ("20170305-13:22:12",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(0), null,
                "20170305-13:22:12", "20170305-13:22:12.000", "20170305-13:22:12.000000", "20170305-13:22:12.000000000");

            yield return new("20170305-13:22:12.1",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_000_000), null,
                "20170305-13:22:12", "20170305-13:22:12.100", "20170305-13:22:12.100000", "20170305-13:22:12.100000000");

            yield return new("20170305-13:22:12.12",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_200_000), null,
                "20170305-13:22:12", "20170305-13:22:12.120", "20170305-13:22:12.120000", "20170305-13:22:12.120000000");

            yield return new("20170305-13:22:12.123",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_230_000), null,
                "20170305-13:22:12", "20170305-13:22:12.123", "20170305-13:22:12.123000", "20170305-13:22:12.123000000");

            yield return new("20170305-13:22:12.1234",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_234_000), null,
                "20170305-13:22:12", "20170305-13:22:12.123", "20170305-13:22:12.123400", "20170305-13:22:12.123400000");

            yield return new("20170305-13:22:12.12345",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_234_500), null,
                "20170305-13:22:12", "20170305-13:22:12.123", "20170305-13:22:12.123450", "20170305-13:22:12.123450000");

            yield return new("20170305-13:22:12.123456",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_234_560), null,
                "20170305-13:22:12", "20170305-13:22:12.123", "20170305-13:22:12.123456", "20170305-13:22:12.123456000");

            yield return new("20170305-13:22:12.1234567",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_234_567), null,
                "20170305-13:22:12", "20170305-13:22:12.123", "20170305-13:22:12.123456", "20170305-13:22:12.123456700");

            yield return new("20170305-13:22:12.12345678",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_234_567), null,
                "20170305-13:22:12", "20170305-13:22:12.123", "20170305-13:22:12.123456", "20170305-13:22:12.123456700");

            yield return new("20170305-13:22:12.123456789",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_234_567), null,
                "20170305-13:22:12", "20170305-13:22:12.123", "20170305-13:22:12.123456", "20170305-13:22:12.123456700");

            yield return new("20170305-13:22:12.12345678912345",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(1_234_567), null,
                "20170305-13:22:12", "20170305-13:22:12.123", "20170305-13:22:12.123456", "20170305-13:22:12.123456700");

            yield return new("20170305-13:22:12.000001",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Unspecified).AddTicks(10), null,
                "20170305-13:22:12", "20170305-13:22:12.000", "20170305-13:22:12.000001", "20170305-13:22:12.000001000");

            yield return new("20170305-13:22:12Z",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Utc).AddTicks(0),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(0), TimeSpan.Zero),
                "20170305-13:22:12", "20170305-13:22:12.000", "20170305-13:22:12.000000", "20170305-13:22:12.000000000");

            yield return new("20170305-13:22:12.12345678Z",
                new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Utc).AddTicks(1_234_567),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(1_234_567), TimeSpan.Zero),
                "20170305-13:22:12", "20170305-13:22:12.123", "20170305-13:22:12.123456", "20170305-13:22:12.123456700");

            yield return new("20170305-13:22:12+05",
                new DateTime(2017, 03, 05, 08, 22, 12, DateTimeKind.Utc).AddTicks(0),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(0), TimeSpan.FromHours(5)),
                // Testing the conversion back to string is a bit nonsensical (and already covered above)
                // but we do it anyway
                "20170305-08:22:12", "20170305-08:22:12.000", "20170305-08:22:12.000000", "20170305-08:22:12.000000000");

            yield return new("20170305-13:22:12.12345678+05",
                new DateTime(2017, 03, 05, 08, 22, 12, DateTimeKind.Utc).AddTicks(1_234_567),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(1_234_567), TimeSpan.FromHours(5)),
                "20170305-08:22:12", "20170305-08:22:12.123", "20170305-08:22:12.123456", "20170305-08:22:12.123456700");

            yield return new("20170305-13:22:12+5",
                new DateTime(2017, 03, 05, 08, 22, 12, DateTimeKind.Utc).AddTicks(0),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(0), TimeSpan.FromHours(5)),
                "20170305-08:22:12", "20170305-08:22:12.000", "20170305-08:22:12.000000", "20170305-08:22:12.000000000");

            yield return new("20170305-13:22:12.12345678+5",
                new DateTime(2017, 03, 05, 08, 22, 12, DateTimeKind.Utc).AddTicks(1_234_567),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(1_234_567), TimeSpan.FromHours(5)),
                "20170305-08:22:12", "20170305-08:22:12.123", "20170305-08:22:12.123456", "20170305-08:22:12.123456700");

            yield return new("20170305-13:22:12+5:30",
                new DateTime(2017, 03, 05, 07, 52, 12, DateTimeKind.Utc).AddTicks(0),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(0), new TimeSpan(05, 30, 0)),
                "20170305-07:52:12", "20170305-07:52:12.000", "20170305-07:52:12.000000", "20170305-07:52:12.000000000");

            yield return new("20170305-13:22:12.12345678+5:30",
                new DateTime(2017, 03, 05, 07, 52, 12, DateTimeKind.Utc).AddTicks(1_234_567),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(1_234_567), new TimeSpan(05, 30, 0)),
                "20170305-07:52:12", "20170305-07:52:12.123", "20170305-07:52:12.123456", "20170305-07:52:12.123456700");

            yield return new("20170305-13:22:12 +05:30",
                new DateTime(2017, 03, 05, 07, 52, 12, DateTimeKind.Utc).AddTicks(0),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(0), new TimeSpan(05, 30, 0)),
                "20170305-07:52:12", "20170305-07:52:12.000", "20170305-07:52:12.000000", "20170305-07:52:12.000000000");

            yield return new("20170305-13:22:12.12345678 +05:30",
                new DateTime(2017, 03, 05, 07, 52, 12, DateTimeKind.Utc).AddTicks(1_234_567),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(1_234_567), new TimeSpan(05, 30, 0)),
                "20170305-07:52:12", "20170305-07:52:12.123", "20170305-07:52:12.123456", "20170305-07:52:12.123456700");

            yield return new("20170305-13:22:12-11",
                new DateTime(2017, 03, 06, 00, 22, 12, DateTimeKind.Utc).AddTicks(0),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(0), TimeSpan.FromHours(-11)),
                "20170306-00:22:12", "20170306-00:22:12.000", "20170306-00:22:12.000000", "20170306-00:22:12.000000000");

            yield return new("20170305-13:22:12.12345678-11",
                new DateTime(2017, 03, 06, 00, 22, 12, DateTimeKind.Utc).AddTicks(1_234_567),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(1_234_567), TimeSpan.FromHours(-11)),
                "20170306-00:22:12", "20170306-00:22:12.123", "20170306-00:22:12.123456", "20170306-00:22:12.123456700");

            yield return new("20170305-13:22:12-11:45",
                new DateTime(2017, 03, 06, 01, 07, 12, DateTimeKind.Utc).AddTicks(0),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(0), -new TimeSpan(11, 45, 0)),
                "20170306-01:07:12", "20170306-01:07:12.000", "20170306-01:07:12.000000", "20170306-01:07:12.000000000");

            yield return new("20170305-13:22:12.12345678-11:45",
                new DateTime(2017, 03, 06, 01, 07, 12, DateTimeKind.Utc).AddTicks(1_234_567),
                new DateTimeOffset(new DateTime(2017, 03, 05, 13, 22, 12).AddTicks(1_234_567), -new TimeSpan(11, 45, 0)),
                "20170306-01:07:12", "20170306-01:07:12.123", "20170306-01:07:12.123456", "20170306-01:07:12.123456700");
        }

        [Test]
        [TestCaseSource(nameof(InvalidStrings))]
        [TestCase("20021201")]
        [TestCase("02:12:01")]
        [TestCase("02:12:01.123")]
        [TestCase("02:12:01-01")]
        [TestCase("02:12:01.123-01")]
        public void InvalidDateTimeString_ThrowsFieldConvertError(string inputString)
        {
            Assert.Throws<FieldConvertError>(() => DateTimeConverter.ParseToDateTime(inputString, out _));
        }

        [Test]
        public void DateOnlyTests()
        {
            DateOnly date = new(1800, 1, 1);
            DateOnly maxDate = new(2200, 1, 1);

            while (date < maxDate)
            {
                string expectedString = date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                string actualString = DateTimeConverter.ToFIXDateOnly(date);

                Assert.That(expectedString, Is.EqualTo(actualString));

                DateOnly actualDate = DateTimeConverter.ParseToDateOnly((ReadOnlySpan<char>)actualString);

                Assert.That(date, Is.EqualTo(actualDate));

                date = date.AddDays(1);
            }
        }

        [Test]
        [TestCaseSource(nameof(InvalidStrings))]
        [TestCase("20021201-11:03:12")]
        [TestCase("20021201-11:03:12.123")]
        [TestCase("20021201-11:03:12-01")]
        [TestCase("20021201-11:03:12.123-01")]
        [TestCase("11:03:12")]
        [TestCase("11:03:12.123")]
        [TestCase("11:03:12-01")]
        [TestCase("11:03:12.123-01")]
        public void InvalidDateOnlyString_ThrowsFieldConvertError(string inputString)
        {
            Assert.Throws<FieldConvertError>(() => DateTimeConverter.ParseToDateOnly((ReadOnlySpan<char>)inputString));
        }

        /// <summary>
        /// Strings which should not be parseable to any of <see cref="DateTime"/>, <see cref="DateOnly"/>, <see cref="TimeOnly"/>.
        /// </summary>
        private static IEnumerable<string> InvalidStrings()
        {
            yield return "";
            yield return " ";
            yield return "00000000";
            yield return "20170100";
            yield return "20170001";
            yield return "20170305 ";
            yield return " 20170305";
            yield return "-20170305";
            yield return "2017030X";
            yield return "20170305Z";
            yield return "20170305+05";
            yield return "2017";
            yield return "201703";
            yield return "201703-05";
            yield return "2017-0305";
            yield return "05032017";
            yield return "20230229";
            yield return "170305";
            yield return "20021201-11"; yield return "11";
            yield return "20021201-11:"; yield return "11:";
            yield return "20021201-11:03"; yield return "11:03";
            yield return "20021201-11:03+11:03"; yield return "11:03+11:03";
            yield return "20021201-11:03:00-11:03:00"; yield return "11:03:00-11:03:00";
            yield return "20021201-11:03:00-11:03.00"; yield return "11:03:00-11:03.00";
            yield return "20021201-11:03.00"; yield return "11:03.00";
            yield return "20021201-11:03::0"; yield return "11:03::0";
            yield return " 20170305-13:22:12"; yield return " 13:22:12";
            yield return "-20170305-13:22:12"; yield return "-13:22:12";
            yield return "20170305+13:22:12"; yield return "+13:22:12";
            yield return "20171305-13:22:12"; yield return "20171305";
            yield return "20170335-13:22:12"; yield return "20170335";
            yield return "20170305-24:22:12"; yield return "24:22:12";
            yield return "20170305-13:62:12"; yield return "13:62:12";
            yield return "20170305-13:22:62"; yield return "13:22:62";
            yield return "20170305-13:22:12 "; yield return "13:22:12 ";
            yield return "20170305-13:22:12+"; yield return "13:22:12+";
            yield return "20170305-13:22:12-"; yield return "13:22:12-";
            yield return "20170305-13:22:12."; yield return "13:22:12.";
            yield return "20170305-13:22:12+ "; yield return "13:22:12+ ";
            yield return "20170305-13:22:12.4 "; yield return "13:22:12.4 ";
            yield return "20170305-13:22:12+05 "; yield return "13:22:12+05 ";
            yield return "20170305-13:22:12+05-"; yield return "13:22:12+05-";
            yield return "20170305-13:22:12+05:00:"; yield return "13:22:12+05:00:";
            yield return "20170305-13:22:12+05:"; yield return "13:22:12+05:";
            yield return "20170305-13:22:12-05+"; yield return "13:22:12-05+";
            yield return "20170305-13:22:12+05+"; yield return "13:22:12+05+";
            yield return "20170305-13:22:12+05:0"; yield return "13:22:12+05:0";
            yield return "20170305-13:22:12+05::00"; yield return "13:22:12+05::00";
            yield return "20170305-13:22:12+05:00:00"; yield return "13:22:12+05:00:00";
            yield return "20170305-13:22:12+05: 4"; yield return "13:22:12+05: 4";
            yield return "20170305-13:22:12+05: 40"; yield return "13:22:12+05: 40";
            yield return "20170305-13:22:12+05:-40"; yield return "13:22:12+05:-40";
            yield return "20170305-13:22:12+05:60"; yield return "13:22:12+05:60";
            yield return "20170305-13:22:12 .123"; yield return "13:22:12 .123";
            yield return "20170305-13:22:12..123"; yield return "13:22:12..123";
            yield return "20170305-13:22:12:34"; yield return "13:22:12:34";
            yield return "20170305-13:22:12+ 5"; yield return "13:22:12+ 5";
            yield return "20170305-13:22:12+05:5"; yield return "13:22:12+05:5";
            yield return "20170305-13:22:12.123X5"; yield return "13:22:12.123X5";
            yield return "20170305-13:22:12.123X+5"; yield return "13:22:12.123X+5";
            yield return "20170305-13:22:12+-05"; yield return "13:22:12+-05";
            yield return "20170305-13:22:12-+05"; yield return "13:22:12-+05";
            yield return "20170305-13:22:12Z+05"; yield return "13:22:12Z+05";
            yield return "20170305-13:22:12+5:005"; yield return "13:22:12+5:005";
            yield return "20170305-13:22:12+005"; yield return "13:22:12+005";
            yield return "20170305-13:22:12-15"; yield return "13:22:12-15";
            yield return "20170305-13:22:12+15"; yield return "13:22:12+15";
            yield return "20170305-13:22:12K"; yield return "13:22:12K";
            yield return "20170305-13:22:12+Z"; yield return "13:22:12+Z";
            yield return "20170305-13:22:12+05Z"; yield return "13:22:12+05Z";
            yield return "00010101-00:00:00+1"; yield return "99991231-23:59:00-1";
        }

        [Test]
        [TestCaseSource(nameof(TimeOnlyData))]
        public void TimeOnlyTests(TimeOnlyTest t)
        {
            TimeOnly actualTimeOnly = DateTimeConverter.ParseToTimeOnly(t.InputString, out TimeSpan? actualOffset);
            Assert.That(t.ExpectedTimeOnly, Is.EqualTo(actualTimeOnly));
            Assert.That(t.ExpectedOffset, Is.EqualTo(actualOffset));
            Assert.That(t.ExpectedStringSeconds, Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(actualTimeOnly, TimeStampPrecision.Second)));
            Assert.That(t.ExpectedStringSeconds, Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(actualTimeOnly, includeMilliseconds: false)));
            Assert.That(t.ExpectedStringMillis, Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(actualTimeOnly, TimeStampPrecision.Millisecond)));
            Assert.That(t.ExpectedStringMillis, Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(actualTimeOnly, includeMilliseconds: true)));
            Assert.That(t.ExpectedStringMillis, Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(actualTimeOnly)));
            Assert.That(t.ExpectedStringMicros, Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(actualTimeOnly, TimeStampPrecision.Microsecond)));
            Assert.That(t.ExpectedStringNanos, Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(actualTimeOnly, TimeStampPrecision.Nanosecond)));
        }

        public record TimeOnlyTest(
            string InputString,
            TimeOnly ExpectedTimeOnly,
            TimeSpan? ExpectedOffset,
            string ExpectedStringSeconds,
            string ExpectedStringMillis,
            string ExpectedStringMicros,
            string ExpectedStringNanos);

        private static IEnumerable<TimeOnlyTest> TimeOnlyData()
        {
            yield return new("13:22:12",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(0)), null,
                "13:22:12", "13:22:12.000", "13:22:12.000000", "13:22:12.000000000");

            yield return new("13:22:12.1",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_000_000)), null,
                "13:22:12", "13:22:12.100", "13:22:12.100000", "13:22:12.100000000");

            yield return new("13:22:12.12",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_200_000)), null,
                "13:22:12", "13:22:12.120", "13:22:12.120000", "13:22:12.120000000");

            yield return new("13:22:12.123",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_230_000)), null,
                "13:22:12", "13:22:12.123", "13:22:12.123000", "13:22:12.123000000");

            yield return new("13:22:12.1234",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_000)), null,
                "13:22:12", "13:22:12.123", "13:22:12.123400", "13:22:12.123400000");

            yield return new("13:22:12.12345",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_500)), null,
                "13:22:12", "13:22:12.123", "13:22:12.123450", "13:22:12.123450000");

            yield return new("13:22:12.123456",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_560)), null,
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456000");

            yield return new("13:22:12.1234567",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), null,
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12.12345678",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), null,
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12.123456789",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), null,
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12.12345678912345",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), null,
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12.000001",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(10)), null,
                "13:22:12", "13:22:12.000", "13:22:12.000001", "13:22:12.000001000");

            yield return new("13:22:12Z",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(0)), TimeSpan.Zero,
                "13:22:12", "13:22:12.000", "13:22:12.000000", "13:22:12.000000000");

            yield return new("13:22:12.12345678Z",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), TimeSpan.Zero,
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12+05",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(0)), TimeSpan.FromHours(5),
                "13:22:12", "13:22:12.000", "13:22:12.000000", "13:22:12.000000000");

            yield return new("13:22:12.12345678+05",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), TimeSpan.FromHours(5),
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12+5",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(0)), TimeSpan.FromHours(5),
                "13:22:12", "13:22:12.000", "13:22:12.000000", "13:22:12.000000000");

            yield return new("13:22:12.12345678+5",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), TimeSpan.FromHours(5),
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12+5:30",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(0)), new TimeSpan(05, 30, 0),
                "13:22:12", "13:22:12.000", "13:22:12.000000", "13:22:12.000000000");

            yield return new("13:22:12.12345678+5:30",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), new TimeSpan(05, 30, 0),
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12 +05:30",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(0)), new TimeSpan(05, 30, 0),
                "13:22:12", "13:22:12.000", "13:22:12.000000", "13:22:12.000000000");

            yield return new("13:22:12.12345678 +05:30",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), new TimeSpan(05, 30, 0),
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12-11",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(0)), TimeSpan.FromHours(-11),
                "13:22:12", "13:22:12.000", "13:22:12.000000", "13:22:12.000000000");

            yield return new("13:22:12.12345678-11",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), TimeSpan.FromHours(-11),
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");

            yield return new("13:22:12-11:45",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(0)), -new TimeSpan(11, 45, 0),
                "13:22:12", "13:22:12.000", "13:22:12.000000", "13:22:12.000000000");

            yield return new("13:22:12.12345678-11:45",
                new TimeOnly(13, 22, 12).Add(TimeSpan.FromTicks(1_234_567)), -new TimeSpan(11, 45, 0),
                "13:22:12", "13:22:12.123", "13:22:12.123456", "13:22:12.123456700");
        }

        [Test]
        [TestCaseSource(nameof(InvalidStrings))]
        [TestCase("20021201")]
        [TestCase("20021201-11:03:12")]
        [TestCase("20021201-11:03:12.123")]
        [TestCase("20021201-11:03:12-01")]
        [TestCase("20021201-11:03:12.123-01")]
        public void InvalidTimeOnlyString_ThrowsFieldConvertError(string inputString)
        {
            Assert.Throws<FieldConvertError>(() => DateTimeConverter.ParseToTimeOnly(inputString, out _));
        }


        [Test]
        public void CanConvertTimeWithMicroSecondsToDateTimeObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMicroseconds = "13:22:12.123456";

            //WHEN - it is converted to a date timeobject
            var convertedDateTime = DateTimeConverter.ParseToTimeOnly(timeStringWithMicroseconds);

            //THEN - the date time object is setup correctly
            Assert.That(1980, Is.EqualTo(convertedDateTime.Year));
            Assert.That(1, Is.EqualTo(convertedDateTime.Month));
            Assert.That(1, Is.EqualTo(convertedDateTime.Day));
            Assert.That(13, Is.EqualTo(convertedDateTime.Hour));
            Assert.That(22, Is.EqualTo(convertedDateTime.Minute));
            Assert.That(12, Is.EqualTo(convertedDateTime.Second));
            Assert.That(123, Is.EqualTo(convertedDateTime.Millisecond));
            Assert.That(timeStringWithMicroseconds, Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(convertedDateTime, TimeStampPrecision.Microsecond)));
        }

        [Test]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithMicroseconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan( 13, 22, 12 ) + new TimeSpan( 1234560 );
            var dateTimeWithMicroseconds = new DateTime( timeWithMicroSeconds.Ticks, DateTimeKind.Utc );

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ToFIXTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Microsecond );

            //THEN - the serialised time contains microseconds
            Assert.That("13:22:12.123456", Is.EqualTo(serialisedDateTime));
        }

        [Test]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithSeconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1234560);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ToFIXTimeOnly(dateTimeWithMicroseconds, false);

            //THEN - the serialised time contains microseconds
            Assert.That("13:22:12", Is.EqualTo(serialisedDateTime));
        }

        [Test]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithMilliSeconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1234560);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ToFIXTimeOnly(dateTimeWithMicroseconds);

            //THEN - the serialised time contains microseconds
            Assert.That("13:22:12.123", Is.EqualTo(serialisedDateTime));
        }

        [Test]
        public void CanConvertTimeSpanWithMilliSecondsToStringWithMicroseconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1230000);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ToFIXTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Microsecond);

            //THEN - the serialised time contains microseconds
            Assert.That("13:22:12.123000", Is.EqualTo(serialisedDateTime));
        }


        [Test]
        public void CanConvertTimeWithMilliSecondsToDateTimeObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMilliseconds = "13:22:12.123";

            //WHEN - it is converted to a date timeobject
            var convertedDateTime = DateTimeConverter.ParseToTimeOnly(timeStringWithMilliseconds);

            //THEN - the date time object is setup correctly
            Assert.That(1980, Is.EqualTo(convertedDateTime.Year));
            Assert.That(1, Is.EqualTo(convertedDateTime.Month));
            Assert.That(1, Is.EqualTo(convertedDateTime.Day));
            Assert.That(13, Is.EqualTo(convertedDateTime.Hour));
            Assert.That(22, Is.EqualTo(convertedDateTime.Minute));
            Assert.That(12, Is.EqualTo(convertedDateTime.Second));
            Assert.That(123, Is.EqualTo(convertedDateTime.Millisecond));
            Assert.That(timeStringWithMilliseconds + "000", Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(convertedDateTime, TimeStampPrecision.Microsecond)));
        }

        [Test]
        public void CanConvertTimeWithMicroSecondsToTimeSpanObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMicroseconds = "13:22:12.123456";

            //WHEN - it is converted to a  timespan object
#pragma warning disable CS0618 // obsolete warning
            var convertedTime = DateTimeConverter.ConvertToTimeSpan(timeStringWithMicroseconds);
#pragma warning disable CS0618
            //THEN - the date time object is setup correctly
            Assert.That(13, Is.EqualTo(convertedTime.Hours));
            Assert.That(22, Is.EqualTo(convertedTime.Minutes));
            Assert.That(12, Is.EqualTo(convertedTime.Seconds));
            Assert.That(123, Is.EqualTo(convertedTime.Milliseconds));
            Assert.That(timeStringWithMicroseconds, Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(TimeOnly.FromTimeSpan(convertedTime), TimeStampPrecision.Microsecond)));
        }

        [Test]
        public void CanConvertTimeWithMilliSecondsToTimeSpanObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMilliseconds = "13:22:12.123";

            //WHEN - it is converted to a timespan object
#pragma warning disable CS0618 // obsolete warning
            var convertedTime = DateTimeConverter.ConvertToTimeSpan(timeStringWithMilliseconds);
#pragma warning disable CS0618
            //THEN - the date time object is setup correctly
            Assert.That(13, Is.EqualTo(convertedTime.Hours));
            Assert.That(22, Is.EqualTo(convertedTime.Minutes));
            Assert.That(12, Is.EqualTo(convertedTime.Seconds));
            Assert.That(123, Is.EqualTo(convertedTime.Milliseconds));
            Assert.That(timeStringWithMilliseconds + "000", Is.EqualTo(DateTimeConverter.ToFIXTimeOnly(TimeOnly.FromTimeSpan(convertedTime), TimeStampPrecision.Microsecond)));
        }


        [Test]
        public void Invalid_TimeStampPrecision_ThrowsArgumentOutOfRangeException()
        {
            var invalidPrecision = (TimeStampPrecision)(-1);
            Assert.That(Enum.IsDefined(invalidPrecision), Is.EqualTo(false));
            Assert.Throws<ArgumentOutOfRangeException>(() => DateTimeConverter.ToFIX(new DateTime(2017, 03, 05, 13, 22, 12), invalidPrecision));
            Assert.Throws<ArgumentOutOfRangeException>(() => DateTimeConverter.ToFIXTimeOnly(new TimeOnly(13, 22, 12), invalidPrecision));
        }
    }
}
