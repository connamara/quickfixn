using System;
using Xunit;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields.Converters
{
    public class DateTimeConverterMicrosecondTests
    {
        [Fact]
        public void CanConvertFromDateTimeStringWithMicrosecondsToValidDateTimeObject()
        {
            //GIVEN - a datetime string with microseconds
            var dateTimeStringWithMicroseconds = "20170305-13:22:12.123456";

            //WHEN - it is converted to a date time
            var convertedDateTime = DateTimeConverter.ConvertToDateTime( dateTimeStringWithMicroseconds );

            //THEN - the date time object is setup correctly
            Assert.Equal( 2017, convertedDateTime.Year );
            Assert.Equal(3, convertedDateTime.Month);
            Assert.Equal(5, convertedDateTime.Day);
            Assert.Equal( 13, convertedDateTime.Hour );
            Assert.Equal(22, convertedDateTime.Minute);
            Assert.Equal(12, convertedDateTime.Second);
            Assert.Equal(123, convertedDateTime.Millisecond);
            Assert.Equal( dateTimeStringWithMicroseconds, string.Format( DateTimeConverter.DATE_TIME_FORMAT_WITH_MICROSECONDS, convertedDateTime ) );
        }


        [Fact]
        public void CanConvertFromDateTimeStringWithMillisecondsToValidDateTimeObject()
        {
            //GIVEN - a datetime string with millisecond precision
            var dateTimeStringWithMillisecond = "20170305-13:22:12.123";

            //WHEN - it is converted to a date time
            var convertedDateTime = DateTimeConverter.ConvertToDateTime(dateTimeStringWithMillisecond);

            //THEN - the date time object is setup correctly
            Assert.Equal(2017, convertedDateTime.Year);
            Assert.Equal(3, convertedDateTime.Month);
            Assert.Equal(5, convertedDateTime.Day);
            Assert.Equal(13, convertedDateTime.Hour);
            Assert.Equal(22, convertedDateTime.Minute);
            Assert.Equal(12, convertedDateTime.Second);
            Assert.Equal(123, convertedDateTime.Millisecond);
        }

        [Fact]
        public void CanConvertFromDateTimeStringWithSecondsToValidDateTimeObject()
        {
            //GIVEN - a datetime string with second precision
            var dateTimeStringWithMillisecond = "20170305-13:22:12";

            //WHEN - it is converted to a date time
            var convertedDateTime = DateTimeConverter.ConvertToDateTime(dateTimeStringWithMillisecond);

            //THEN - the date time object is setup correctly
            Assert.Equal(2017, convertedDateTime.Year);
            Assert.Equal(3, convertedDateTime.Month);
            Assert.Equal(5, convertedDateTime.Day);
            Assert.Equal(13, convertedDateTime.Hour);
            Assert.Equal(22, convertedDateTime.Minute);
            Assert.Equal(12, convertedDateTime.Second);
            Assert.Equal(0, convertedDateTime.Millisecond);
        }

        [Fact]
        public void CanConvertFromDateTimeWithSecondsToValidStringWithMicroSecondPrecision()
        {
            //GIVEN - a datetime object with seconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, DateTimeKind.Utc);

            //WHEN - it is serialised to a string with microsecond precision
            var serialisedDateTime = DateTimeConverter.Convert(dateTime, TimeStampPrecision.Microsecond);

            //THEN - the serialised string contains microseconds
            Assert.Equal("20170305-13:22:12.000000", serialisedDateTime);
        }

        [Fact]
        public void CanConvertFromDateTimeWithMillisecondsToValidStringWithMicroSecondPrecision()
        {
            //GIVEN - a datetime object with milliseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc);

            //WHEN - it is serialised to a string with microsecond precision
            var serialisedDateTime = DateTimeConverter.Convert(dateTime, TimeStampPrecision.Microsecond);

            //THEN - the serialised string contains microseconds
            Assert.Equal("20170305-13:22:12.123000", serialisedDateTime);
        }

        [Fact]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithMicroSecondPrecision()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime( 2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc ) + new TimeSpan( 4560 );

            //WHEN - it is serialised to a string with microsecond precision
            var serialisedDateTime = DateTimeConverter.Convert( dateTime, TimeStampPrecision.Microsecond );

            //THEN - the serialised string contains microseconds
            Assert.Equal("20170305-13:22:12.123456", serialisedDateTime);
        }

        [Fact]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithMilliSecondPrecision()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc) + new TimeSpan(4560);

            //WHEN - it is serialised to a string with millisecond precision
            var serialisedDateTime = DateTimeConverter.Convert(dateTime, TimeStampPrecision.Millisecond);

            //THEN - the serialised string contains milliseconds
            Assert.Equal("20170305-13:22:12.123", serialisedDateTime);
        }

        [Fact]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithMilliSecondPrecisionUsingOriginalMethod()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc) + new TimeSpan(4560);

            //WHEN - it is serialised to a string with millisecond precision
            var serialisedDateTime = DateTimeConverter.Convert(dateTime);

            //THEN - the serialised string contains milliseconds
            Assert.Equal("20170305-13:22:12.123", serialisedDateTime);
        }

        [Fact]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithSecondPrecision()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc) + new TimeSpan(4560);

            //WHEN - it is serialised to a string with second precision
            var serialisedDateTime = DateTimeConverter.Convert(dateTime, TimeStampPrecision.Second);

            //THEN - the serialised string contains seconds
            Assert.Equal("20170305-13:22:12", serialisedDateTime);
        }

        [Fact]
        public void CanConvertFromDateTimeWithMicrosecondsToValidStringWithSecondPrecisionUsingOriginalMethod()
        {
            //GIVEN - a datetime object with microseconds
            var dateTime = new DateTime(2017, 03, 05, 13, 22, 12, 123, DateTimeKind.Utc) + new TimeSpan(4560);

            //WHEN - it is serialised to a string with second precision
            var serialisedDateTime = DateTimeConverter.Convert(dateTime, false);

            //THEN - the serialised string contains seconds
            Assert.Equal("20170305-13:22:12", serialisedDateTime);
        }


        [Fact]
        public void CanConvertTimeWithMicroSecondsToDateTimeObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMicroseconds = "13:22:12.123456";

            //WHEN - it is converted to a date timeobject
            var convertedDateTime = DateTimeConverter.ConvertToTimeOnly(timeStringWithMicroseconds);

            //THEN - the date time object is setup correctly
            Assert.Equal(1980, convertedDateTime.Year);
            Assert.Equal(1, convertedDateTime.Month);
            Assert.Equal(1, convertedDateTime.Day);
            Assert.Equal(13, convertedDateTime.Hour);
            Assert.Equal(22, convertedDateTime.Minute);
            Assert.Equal(12, convertedDateTime.Second);
            Assert.Equal(123, convertedDateTime.Millisecond);
            Assert.Equal(timeStringWithMicroseconds, string.Format(DateTimeConverter.TIME_ONLY_FORMAT_WITH_MICROSECONDS, convertedDateTime));
        }

        [Fact]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithMicroseconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan( 13, 22, 12 ) + new TimeSpan( 1234560 );
            var dateTimeWithMicroseconds = new DateTime( timeWithMicroSeconds.Ticks, DateTimeKind.Utc );

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ConvertTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Microsecond );

            //THEN - the serialised time contains microseconds
            Assert.Equal("13:22:12.123456", serialisedDateTime);
        }

        [Fact]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithSeconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1234560);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ConvertTimeOnly(dateTimeWithMicroseconds, false);

            //THEN - the serialised time contains microseconds
            Assert.Equal("13:22:12", serialisedDateTime);
        }

        [Fact]
        public void CanConvertTimeSpanWithMicroSecondsToStringWithMilliSeconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1234560);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ConvertTimeOnly(dateTimeWithMicroseconds);

            //THEN - the serialised time contains microseconds
            Assert.Equal("13:22:12.123", serialisedDateTime);
        }

        [Fact]
        public void CanConvertTimeSpanWithMilliSecondsToStringWithMicroseconds()
        {
            //GIVEN - a time string with microseconds
            var timeWithMicroSeconds = new TimeSpan(13, 22, 12) + new TimeSpan(1230000);
            var dateTimeWithMicroseconds = new DateTime(timeWithMicroSeconds.Ticks, DateTimeKind.Utc);

            //WHEN - it is seralised with Microseconds
            var serialisedDateTime = DateTimeConverter.ConvertTimeOnly(dateTimeWithMicroseconds, TimeStampPrecision.Microsecond);

            //THEN - the serialised time contains microseconds
            Assert.Equal("13:22:12.123000", serialisedDateTime);
        }


        [Fact]
        public void CanConvertTimeWithMilliSecondsToDateTimeObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMilliseconds = "13:22:12.123";

            //WHEN - it is converted to a date timeobject
            var convertedDateTime = DateTimeConverter.ConvertToTimeOnly(timeStringWithMilliseconds);

            //THEN - the date time object is setup correctly
            Assert.Equal(1980, convertedDateTime.Year);
            Assert.Equal(1, convertedDateTime.Month);
            Assert.Equal(1, convertedDateTime.Day);
            Assert.Equal(13, convertedDateTime.Hour);
            Assert.Equal(22, convertedDateTime.Minute);
            Assert.Equal(12, convertedDateTime.Second);
            Assert.Equal(123, convertedDateTime.Millisecond);
            Assert.Equal(timeStringWithMilliseconds + "000", string.Format(DateTimeConverter.TIME_ONLY_FORMAT_WITH_MICROSECONDS, convertedDateTime));
        }

        [Fact]
        public void CanConvertTimeWithMicroSecondsToTimeSpanObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMicroseconds = "13:22:12.123456";

            //WHEN - it is converted to a  timespan object
            var convertedTime = DateTimeConverter.ConvertToTimeSpan(timeStringWithMicroseconds);

            //THEN - the date time object is setup correctly
            Assert.Equal(13, convertedTime.Hours);
            Assert.Equal(22, convertedTime.Minutes);
            Assert.Equal(12, convertedTime.Seconds);
            Assert.Equal(123, convertedTime.Milliseconds);
            Assert.Equal(timeStringWithMicroseconds, string.Format(DateTimeConverter.TIME_ONLY_FORMAT_WITH_MICROSECONDS, new DateTime(convertedTime.Ticks)));
        }

        [Fact]
        public void CanConvertTimeWithMilliSecondsToTimeSpanObject()
        {
            //GIVEN - a time string with microseconds
            var timeStringWithMilliseconds = "13:22:12.123";

            //WHEN - it is converted to a timespan object
            var convertedTime = DateTimeConverter.ConvertToTimeSpan(timeStringWithMilliseconds);

            //THEN - the date time object is setup correctly
            Assert.Equal(13, convertedTime.Hours);
            Assert.Equal(22, convertedTime.Minutes);
            Assert.Equal(12, convertedTime.Seconds);
            Assert.Equal(123, convertedTime.Milliseconds);
            Assert.Equal(timeStringWithMilliseconds + "000", string.Format(DateTimeConverter.TIME_ONLY_FORMAT_WITH_MICROSECONDS, new DateTime(convertedTime.Ticks)));
        }
    }
}
