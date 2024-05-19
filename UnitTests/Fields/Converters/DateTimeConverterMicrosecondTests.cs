using System;
using NUnit.Framework;
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
            var convertedDateTime = DateTimeConverter.ParseToDateTime(dateTimeStringWithNanoseconds);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(2017, convertedDateTime.Year);
            Assert.AreEqual(3, convertedDateTime.Month);
            Assert.AreEqual(5, convertedDateTime.Day);
            Assert.AreEqual(13, convertedDateTime.Hour);
            Assert.AreEqual(22, convertedDateTime.Minute);
            Assert.AreEqual(12, convertedDateTime.Second);
            Assert.AreEqual(123, convertedDateTime.Millisecond);
            Assert.AreEqual(456700, convertedDateTime.Nanosecond()); //100 Nanosecond Truncated Resolution
            Assert.AreEqual(dateTimeStringWithNanosecondsTruncated, DateTimeConverter.ToFIX(convertedDateTime, TimeStampPrecision.Nanosecond));
        }
        
        [Test]
        public void CanConvertFromDateTimeStringWithMicrosecondsToValidDateTimeObject()
        {
            //GIVEN - a datetime string with microseconds
            var dateTimeStringWithMicroseconds = "20170305-13:22:12.123456";

            //WHEN - it is converted to a date time
            var convertedDateTime = DateTimeConverter.ParseToDateTime( dateTimeStringWithMicroseconds );

            //THEN - the date time object is setup correctly
            Assert.AreEqual( 2017, convertedDateTime.Year );
            Assert.AreEqual(3, convertedDateTime.Month);
            Assert.AreEqual(5, convertedDateTime.Day);
            Assert.AreEqual( 13, convertedDateTime.Hour );
            Assert.AreEqual(22, convertedDateTime.Minute);
            Assert.AreEqual(12, convertedDateTime.Second);
            Assert.AreEqual(123, convertedDateTime.Millisecond);
            Assert.AreEqual( dateTimeStringWithMicroseconds, string.Format( DateTimeConverter.DATE_TIME_FORMAT_WITH_MICROSECONDS, convertedDateTime ) );
        }


        [Test]
        public void CanConvertFromDateTimeStringWithMillisecondsToValidDateTimeObject()
        {
            //GIVEN - a datetime string with millisecond precision
            var dateTimeStringWithMillisecond = "20170305-13:22:12.123";

            //WHEN - it is converted to a date time
            var convertedDateTime = DateTimeConverter.ParseToDateTime(dateTimeStringWithMillisecond);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(2017, convertedDateTime.Year);
            Assert.AreEqual(3, convertedDateTime.Month);
            Assert.AreEqual(5, convertedDateTime.Day);
            Assert.AreEqual(13, convertedDateTime.Hour);
            Assert.AreEqual(22, convertedDateTime.Minute);
            Assert.AreEqual(12, convertedDateTime.Second);
            Assert.AreEqual(123, convertedDateTime.Millisecond);
        }

        [Test]
        public void CanConvertFromDateTimeStringWithSecondsToValidDateTimeObject()
        {
            //GIVEN - a datetime string with second precision
            var dateTimeStringWithMillisecond = "20170305-13:22:12";

            //WHEN - it is converted to a date time
            var convertedDateTime = DateTimeConverter.ParseToDateTime(dateTimeStringWithMillisecond);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(2017, convertedDateTime.Year);
            Assert.AreEqual(3, convertedDateTime.Month);
            Assert.AreEqual(5, convertedDateTime.Day);
            Assert.AreEqual(13, convertedDateTime.Hour);
            Assert.AreEqual(22, convertedDateTime.Minute);
            Assert.AreEqual(12, convertedDateTime.Second);
            Assert.AreEqual(0, convertedDateTime.Millisecond);
        }

        [Test]
        public void CanConvertFromDateTimeWithSecondsToValidStringWithMicroSecondPrecision()
        {
            //GIVEN - a datetime object with seconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Utc);

            //WHEN - it is serialized to a string with microsecond precision
            var serializedDateTime = DateTimeConverter.ToFIX(dateTime, TimeStampPrecision.Microsecond);

            //THEN - the serialized string contains microseconds
            Assert.AreEqual("20170305-13:22:12.000000", serializedDateTime);
        }

        [Test]
        public void CanConvertFromDateTimeWithMillisecondsToValidStringWithMicroSecondPrecision()
        {
            //GIVEN - a datetime object with milliseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc);

            //WHEN - it is serialized to a string with microsecond precision
            var serializedDateTime = DateTimeConverter.ToFIX(dateTime, TimeStampPrecision.Microsecond);

            //THEN - the serialized string contains microseconds
            Assert.AreEqual("20170305-13:22:12.123000", serializedDateTime);
        }

        [Test]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithMicroSecondPrecision()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime( 2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc ) + new TimeSpan( 4560 );

            //WHEN - it is serialized to a string with microsecond precision
            var serializedDateTime = DateTimeConverter.ToFIX( dateTime, TimeStampPrecision.Microsecond );

            //THEN - the serialized string contains microseconds
            Assert.AreEqual("20170305-13:22:12.123456", serializedDateTime);
        }

        [Test]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithMilliSecondPrecision()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc) + new TimeSpan(4560);

            //WHEN - it is serialized to a string with millisecond precision
            var serializedDateTime = DateTimeConverter.ToFIX(dateTime, TimeStampPrecision.Millisecond);

            //THEN - the serialized string contains milliseconds
            Assert.AreEqual("20170305-13:22:12.123", serializedDateTime);
        }

        [Test]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithMilliSecondPrecisionUsingOriginalMethod()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc) + new TimeSpan(4560);

            //WHEN - it is serialized to a string with millisecond precision
            var serializedDateTime = DateTimeConverter.ToFIX(dateTime, TimeStampPrecision.Millisecond);

            //THEN - the serialized string contains milliseconds
            Assert.AreEqual("20170305-13:22:12.123", serializedDateTime);
        }

        [Test]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithSecondPrecision()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc) + new TimeSpan(4560);

            //WHEN - it is serialized to a string with second precision
            var serializedDateTime = DateTimeConverter.ToFIX(dateTime, TimeStampPrecision.Second);

            //THEN - the serialized string contains seconds
            Assert.AreEqual("20170305-13:22:12", serializedDateTime);
        }

        [Test]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithSecondPrecisionUsingOriginalMethod()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc) + new TimeSpan(4560);

            //WHEN - it is serialized to a string with second precision
            var serializedDateTime = DateTimeConverter.ToFIX(dateTime, TimeStampPrecision.Second);

            //THEN - the serialized string contains seconds
            Assert.AreEqual("20170305-13:22:12", serializedDateTime);
        }

        [Test]
        public void CanConvertTimeWithMicroSecondsToDateTimeObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMicroseconds = "13:22:12.123456";

            //WHEN - it is converted to a date timeobject
            var convertedDateTime = DateTimeConverter.ParseToTimeOnly(timeStringWithMicroseconds);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(1980, convertedDateTime.Year);
            Assert.AreEqual(1, convertedDateTime.Month);
            Assert.AreEqual(1, convertedDateTime.Day);
            Assert.AreEqual(13, convertedDateTime.Hour);
            Assert.AreEqual(22, convertedDateTime.Minute);
            Assert.AreEqual(12, convertedDateTime.Second);
            Assert.AreEqual(123, convertedDateTime.Millisecond);
            Assert.AreEqual(timeStringWithMicroseconds, string.Format(DateTimeConverter.TIME_ONLY_FORMAT_WITH_MICROSECONDS, convertedDateTime));
        }

        [Test]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithMicroseconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan( 13, 22, 12 ) + new TimeSpan( 1234560 );
            var dateTimeWithMicroseconds = new DateTime( timeWithMicroSeconds.Ticks, DateTimeKind.Utc );

            //WHEN - it is serialized with Microseconds
            var serializedDateTime = DateTimeConverter.ToFIXTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Microsecond );

            //THEN - the serialized time contains microseconds
            Assert.AreEqual("13:22:12.123456", serializedDateTime);
        }

        [Test]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithSeconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1234560);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is serialized with Seconds
            var serializedDateTime = DateTimeConverter.ToFIXTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Second);

            //THEN - the serialized time does not contain microseconds
            Assert.AreEqual("13:22:12", serializedDateTime);
        }

        [Test]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithMilliSeconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1234560);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is serialized with Milliseconds
            var serializedDateTime = DateTimeConverter.ToFIXTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Millisecond);

            //THEN - the serialized time contains milliseconds
            Assert.AreEqual("13:22:12.123", serializedDateTime);
        }

        [Test]
        public void CanConvertTimeSpanWithMilliSecondsToStringWithMicroseconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1230000);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is serialized with Microseconds
            var serializedDateTime = DateTimeConverter.ToFIXTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Microsecond);

            //THEN - the serialized time contains microseconds
            Assert.AreEqual("13:22:12.123000", serializedDateTime);
        }

        [Test]
        public void CanConvertTimeWithMilliSecondsToDateTimeObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMilliseconds = "13:22:12.123";

            //WHEN - it is converted to a date timeobject
            var convertedDateTime = DateTimeConverter.ParseToTimeOnly(timeStringWithMilliseconds);

            //THEN - the date time object is setup correctly
            Assert.AreEqual(1980, convertedDateTime.Year);
            Assert.AreEqual(1, convertedDateTime.Month);
            Assert.AreEqual(1, convertedDateTime.Day);
            Assert.AreEqual(13, convertedDateTime.Hour);
            Assert.AreEqual(22, convertedDateTime.Minute);
            Assert.AreEqual(12, convertedDateTime.Second);
            Assert.AreEqual(123, convertedDateTime.Millisecond);
            Assert.AreEqual(timeStringWithMilliseconds + "000", string.Format(DateTimeConverter.TIME_ONLY_FORMAT_WITH_MICROSECONDS, convertedDateTime));
        }

        [Test]
        public void CanConvertTimeWithMicroSecondsToTimeSpanObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMicroseconds = "13:22:12.123456";

            //WHEN - it is converted to a  timespan object
            #pragma warning disable CS0618 // obsolete warning
            var convertedTime = DateTimeConverter.ConvertToTimeSpan(timeStringWithMicroseconds);
            #pragma warning restore CS0618

            //THEN - the date time object is setup correctly
            Assert.AreEqual(13, convertedTime.Hours);
            Assert.AreEqual(22, convertedTime.Minutes);
            Assert.AreEqual(12, convertedTime.Seconds);
            Assert.AreEqual(123, convertedTime.Milliseconds);
            Assert.AreEqual(timeStringWithMicroseconds, string.Format(DateTimeConverter.TIME_ONLY_FORMAT_WITH_MICROSECONDS, new DateTime(convertedTime.Ticks)));
        }

        [Test]
        public void CanConvertTimeWithMilliSecondsToTimeSpanObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMilliseconds = "13:22:12.123";

            //WHEN - it is converted to a timespan object
            #pragma warning disable CS0618 // obsolete warning
            var convertedTime = DateTimeConverter.ConvertToTimeSpan(timeStringWithMilliseconds);
            #pragma warning restore CS0618

            //THEN - the date time object is setup correctly
            Assert.AreEqual(13, convertedTime.Hours);
            Assert.AreEqual(22, convertedTime.Minutes);
            Assert.AreEqual(12, convertedTime.Seconds);
            Assert.AreEqual(123, convertedTime.Milliseconds);
            Assert.AreEqual(timeStringWithMilliseconds + "000", string.Format(DateTimeConverter.TIME_ONLY_FORMAT_WITH_MICROSECONDS, new DateTime(convertedTime.Ticks)));
        }
    }
}
