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
        [Test]
        public void CanConvertFromDateTimeStringWithNanosecondsToValidDateTimeObject()
        {
            //GIVEN - a datetime string with nanoseconds
            var dateTimeStringWithNanoseconds = "20170305-13:22:12.123456789";
            var dateTimeStringWithNanosecondsTruncated = "20170305-13:22:12.123456700";

            //WHEN - it is converted to a date time
            var convertedDateTime = DateTimeConverter.ConvertToDateTime(dateTimeStringWithNanoseconds);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(2017, convertedDateTime.Year);
            Assert.AreEqual(3, convertedDateTime.Month);
            Assert.AreEqual(5, convertedDateTime.Day);
            Assert.AreEqual(13, convertedDateTime.Hour);
            Assert.AreEqual(22, convertedDateTime.Minute);
            Assert.AreEqual(12, convertedDateTime.Second);
            Assert.AreEqual(123, convertedDateTime.Millisecond);
            Assert.AreEqual(456700, convertedDateTime.Nanosecond()); //100 Nanosecond Truncated Resolution
            Assert.AreEqual(dateTimeStringWithNanosecondsTruncated, DateTimeConverter.Convert(convertedDateTime, TimeStampPrecision.Nanosecond));
        }

        [Test]
        [TestCaseSource(nameof(DateTimeData))]
        public void DateTimeTests(DateTimeTest t)
        {
            DateTime actualDateTime = DateTimeConverter.ConvertToDateTime(t.InputString, out DateTimeOffset? actualDateTimeOffset);
            AssertEqual(t.ExpectedDateTime, actualDateTime);
            AssertEqual(t.ExpectedDateTimeOffset, actualDateTimeOffset);
            Assert.AreEqual(t.ExpectedStringSeconds, DateTimeConverter.Convert(actualDateTime, TimeStampPrecision.Second));
            Assert.AreEqual(t.ExpectedStringSeconds, DateTimeConverter.Convert(actualDateTime, includeMilliseconds: false));
            Assert.AreEqual(t.ExpectedStringMillis, DateTimeConverter.Convert(actualDateTime, TimeStampPrecision.Millisecond));
            Assert.AreEqual(t.ExpectedStringMillis, DateTimeConverter.Convert(actualDateTime, includeMilliseconds: true));
            Assert.AreEqual(t.ExpectedStringMillis, DateTimeConverter.Convert(actualDateTime));
            Assert.AreEqual(t.ExpectedStringMicros, DateTimeConverter.Convert(actualDateTime, TimeStampPrecision.Microsecond));
            Assert.AreEqual(t.ExpectedStringNanos, DateTimeConverter.Convert(actualDateTime, TimeStampPrecision.Nanosecond));
        }

        /// <summary>
        /// Verifies that two <see cref="DateTime"/> objects are equal, including their
        /// <see cref="DateTime.Kind"/> properties which is not covered by <see cref="DateTime.Equals(DateTime)"/>
        /// </summary>
        private static void AssertEqual(DateTime expected, DateTime actual)
        {
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.Kind, actual.Kind);
        }

        /// <summary>
        /// Verifies that two <see cref="DateTimeOffset"/> objects are equal, including their
        /// <see cref="DateTimeOffset.Offset"/> properties by calling <see cref="DateTimeOffset.EqualsExact(DateTimeOffset)"/>
        /// </summary>
        private static void AssertEqual(DateTimeOffset? expected, DateTimeOffset? actual)
        {
            Assert.AreEqual(expected, actual);
            if (expected != null)
            {
                Assert.True(expected.Value.EqualsExact(actual.Value));
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
            Assert.Throws<FieldConvertError>(() => DateTimeConverter.ConvertToDateTime(inputString, out _));
        }

        [Test]
        public void DateOnlyTests()
        {
            DateOnly date = new(1800, 1, 1);
            DateOnly maxDate = new(2200, 1, 1);

            while (date < maxDate)
            {
                string expectedString = date.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                string actualString = DateTimeConverter.ConvertDateOnly(date);

                Assert.AreEqual(expectedString, actualString);

                DateOnly actualDate = DateTimeConverter.ConvertToDateOnly((ReadOnlySpan<char>)actualString);

                Assert.AreEqual(date, actualDate);

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
            Assert.Throws<FieldConvertError>(() => DateTimeConverter.ConvertToDateOnly((ReadOnlySpan<char>)inputString));
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
            TimeOnly actualTimeOnly = DateTimeConverter.ConvertToTimeOnly(t.InputString, out TimeSpan? actualOffset);
            Assert.AreEqual(t.ExpectedTimeOnly, actualTimeOnly);
            Assert.AreEqual(t.ExpectedOffset, actualOffset);
            Assert.AreEqual(t.ExpectedStringSeconds, DateTimeConverter.ConvertTimeOnly(actualTimeOnly, TimeStampPrecision.Second));
            Assert.AreEqual(t.ExpectedStringSeconds, DateTimeConverter.ConvertTimeOnly(actualTimeOnly, includeMilliseconds: false));
            Assert.AreEqual(t.ExpectedStringMillis, DateTimeConverter.ConvertTimeOnly(actualTimeOnly, TimeStampPrecision.Millisecond));
            Assert.AreEqual(t.ExpectedStringMillis, DateTimeConverter.ConvertTimeOnly(actualTimeOnly, includeMilliseconds: true));
            Assert.AreEqual(t.ExpectedStringMillis, DateTimeConverter.ConvertTimeOnly(actualTimeOnly));
            Assert.AreEqual(t.ExpectedStringMicros, DateTimeConverter.ConvertTimeOnly(actualTimeOnly, TimeStampPrecision.Microsecond));
            Assert.AreEqual(t.ExpectedStringNanos, DateTimeConverter.ConvertTimeOnly(actualTimeOnly, TimeStampPrecision.Nanosecond));
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
            Assert.Throws<FieldConvertError>(() => DateTimeConverter.ConvertToTimeOnly(inputString, out _));
        }


        [Test]
        public void CanConvertTimeWithMicroSecondsToDateTimeObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMicroseconds = "13:22:12.123456";

            //WHEN - it is converted to a date timeobject
            var convertedDateTime = DateTimeConverter.ConvertToTimeOnly(timeStringWithMicroseconds);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(1980, convertedDateTime.Year);
            Assert.AreEqual(1, convertedDateTime.Month);
            Assert.AreEqual(1, convertedDateTime.Day);
            Assert.AreEqual(13, convertedDateTime.Hour);
            Assert.AreEqual(22, convertedDateTime.Minute);
            Assert.AreEqual(12, convertedDateTime.Second);
            Assert.AreEqual(123, convertedDateTime.Millisecond);
            Assert.AreEqual(timeStringWithMicroseconds, DateTimeConverter.ConvertTimeOnly(convertedDateTime, TimeStampPrecision.Microsecond));
        }

        [Test]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithMicroseconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan( 13, 22, 12 ) + new TimeSpan( 1234560 );
            var dateTimeWithMicroseconds = new DateTime( timeWithMicroSeconds.Ticks, DateTimeKind.Utc );

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ConvertTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Microsecond );

            //THEN - the serialised time contains microseconds
            Assert.AreEqual("13:22:12.123456", serialisedDateTime);
        }

        [Test]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithSeconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1234560);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ConvertTimeOnly(dateTimeWithMicroseconds, false);

            //THEN - the serialised time contains microseconds
            Assert.AreEqual("13:22:12", serialisedDateTime);
        }

        [Test]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithMilliSeconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1234560);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ConvertTimeOnly(dateTimeWithMicroseconds);

            //THEN - the serialised time contains microseconds
            Assert.AreEqual("13:22:12.123", serialisedDateTime);
        }

        [Test]
        public void CanConvertTimeSpanWithMilliSecondsToStringWithMicroseconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1230000);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ConvertTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Microsecond);

            //THEN - the serialised time contains microseconds
            Assert.AreEqual("13:22:12.123000", serialisedDateTime);
        }


        [Test]
        public void CanConvertTimeWithMilliSecondsToDateTimeObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMilliseconds = "13:22:12.123";

            //WHEN - it is converted to a date timeobject
            var convertedDateTime = DateTimeConverter.ConvertToTimeOnly(timeStringWithMilliseconds);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(1980, convertedDateTime.Year);
            Assert.AreEqual(1, convertedDateTime.Month);
            Assert.AreEqual(1, convertedDateTime.Day);
            Assert.AreEqual(13, convertedDateTime.Hour);
            Assert.AreEqual(22, convertedDateTime.Minute);
            Assert.AreEqual(12, convertedDateTime.Second);
            Assert.AreEqual(123, convertedDateTime.Millisecond);
            Assert.AreEqual(timeStringWithMilliseconds + "000", DateTimeConverter.ConvertTimeOnly(convertedDateTime, TimeStampPrecision.Microsecond));
        }

        [Test]
        public void CanConvertTimeWithMicroSecondsToTimeSpanObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMicroseconds = "13:22:12.123456";

            //WHEN - it is converted to a  timespan object
            var convertedTime = DateTimeConverter.ConvertToTimeSpan(timeStringWithMicroseconds);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(13, convertedTime.Hours);
            Assert.AreEqual(22, convertedTime.Minutes);
            Assert.AreEqual(12, convertedTime.Seconds);
            Assert.AreEqual(123, convertedTime.Milliseconds);
            Assert.AreEqual(timeStringWithMicroseconds, DateTimeConverter.ConvertTimeOnly(TimeOnly.FromTimeSpan(convertedTime), TimeStampPrecision.Microsecond));
        }

        [Test]
        public void CanConvertTimeWithMilliSecondsToTimeSpanObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMilliseconds = "13:22:12.123";

            //WHEN - it is converted to a timespan object
            var convertedTime = DateTimeConverter.ConvertToTimeSpan(timeStringWithMilliseconds);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(13, convertedTime.Hours);
            Assert.AreEqual(22, convertedTime.Minutes);
            Assert.AreEqual(12, convertedTime.Seconds);
            Assert.AreEqual(123, convertedTime.Milliseconds);
            Assert.AreEqual(timeStringWithMilliseconds + "000", DateTimeConverter.ConvertTimeOnly(TimeOnly.FromTimeSpan(convertedTime), TimeStampPrecision.Microsecond));
        }


        [Test]
        public void Invalid_TimeStampPrecision_ThrowsArgumentOutOfRangeException()
        {
            var invalidPrecision = (TimeStampPrecision)(-1);
            Assert.False(Enum.IsDefined(invalidPrecision));
            Assert.Throws<ArgumentOutOfRangeException>(() => DateTimeConverter.Convert(new DateTime(2017, 03, 05, 13, 22, 12), invalidPrecision));
            Assert.Throws<ArgumentOutOfRangeException>(() => DateTimeConverter.ConvertTimeOnly(new TimeOnly(13, 22, 12), invalidPrecision));
        }
    }
}
