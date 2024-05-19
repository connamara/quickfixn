using System;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;
using UnitTests.TestHelpers;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class DatetimeConverterTests {

    [SetUp]
    public void SetUp()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
    }

    [TearDown]
    public void TearDown()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
    }

    [Test]
    public void DateTimeConverterTest()
    {
        // DateTime types to string
        Assert.That(DateTimeConverter.ToFIX(new DateTime(2002, 12, 01, 11, 03, 05), TimeStampPrecision.Millisecond), Is.EqualTo("20021201-11:03:05.000"));
        Assert.That(DateTimeConverter.ToFIX(new DateTime(2002, 12, 01, 11, 03, 05, 321), TimeStampPrecision.Second), Is.EqualTo("20021201-11:03:05"));
        Assert.That(DateTimeConverter.ToFIX(new DateTime(2002, 12, 01, 11, 03, 05, 321), TimeStampPrecision.Millisecond), Is.EqualTo("20021201-11:03:05.321"));

        // 2 valid string-to-DateTime formats
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01"), Is.EqualTo(new DateTime(2010, 9, 12, 4, 22, 01, DateTimeKind.Utc)));
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123"), Is.EqualTo(new DateTime(2010, 9, 12, 4, 22, 01, 123, DateTimeKind.Utc)));

        // invalid string-to-DateTime formats
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateTime(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateTime("20021201"); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateTime("20021201-11:03"); });
    }

    [Test]
    public void DateOnlyConverterTest()
    {
        // DateTime types to string
        Assert.That(DateTimeConverter.ToFIXDateOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("20021201"));

        // string-to-DateTime but time is zero
        Assert.That(DateTimeConverter.ParseToDateOnly("20100912"), Is.EqualTo(new DateTime(2010, 9, 12, 0, 0, 0, DateTimeKind.Utc)));

        // invalid string-to-DateTime formats
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateOnly(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateOnly("20021201-11:03:00"); });
    }

    [Test]
    public void TimeOnlyConverterTest()
    {
        // DateTime types to string
        Assert.That(DateTimeConverter.ToFIXTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05), TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), TimeStampPrecision.Second), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.321"));

        // 2 valid string-to-DateTime formats, set date to Jan 1
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01"), Is.EqualTo(new DateTime(1980, 1, 1, 4, 22, 01, DateTimeKind.Utc)));
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123"), Is.EqualTo(new DateTime(1980, 1, 1, 4, 22, 01, 123, DateTimeKind.Utc)));

        // invalid string-to-DateTime formats
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToTimeOnly(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToTimeOnly("20021201-11:03:00"); });
    }

    [Test]
    public void TestNanosecondPrecision()
    {
        // seeded DateTime
        DateTime dt = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 231, 116, 500), DateTimeKind.Utc);

        // convert nanosecond DateTime to string with option
        Assert.That(DateTimeConverter.ToFIX(dt, TimeStampPrecision.Nanosecond), Is.EqualTo("20021201-11:03:05.231116500"));

        // convert nanosecond DateTime to time-only string
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dt, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.231116500"));

        // convert nanosecond time string to DateTime time portion only
        DateTime timeOnly = TimeHelper.MakeTimeOnly(11, 03, 05, 231, 116, 500);
        Assert.That(DateTimeConverter.ParseToTimeOnly("11:03:05.231116500", TimeStampPrecision.Nanosecond), Is.EqualTo(timeOnly));

        // convert nanosecond time string to full DateTime
        Assert.That(DateTimeConverter.ParseToDateTime("20021201-11:03:05.231116500"), Is.EqualTo(dt));

        // convert nanosecond time with UTC time zone to full DateTime
        Assert.That(DateTimeConverter.ParseToDateTime("20021201-11:03:05.231116500Z"), Is.EqualTo(dt));

        // convert nanosecond time with non-UTC positive offset time zone to full DateTime
        Assert.That(DateTimeConverter.ParseToDateTime("20021201-16:03:05.231116500+05"), Is.EqualTo(dt));

        // convert nanosecond time with non-UTC negative offset time zone to full DateTime
        Assert.That(DateTimeConverter.ParseToDateTime("20021201-08:03:05.231116500-03"), Is.EqualTo(dt));

        // convert nanosecond time in local time (no time zone) to full DateTime
        DateTime local = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 231, 116, 500), DateTimeKind.Local);
        Assert.That(DateTimeConverter.ParseToDateTime("20021201-11:03:05.231116500"), Is.EqualTo(local));
    }

    [Test]
    public void Convert_NanosecondBug() {
        Assert.That(
            DateTimeConverter.ToFIX(
                DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 231, 116, 500), DateTimeKind.Utc),
                TimeStampPrecision.Nanosecond),
            Is.EqualTo("20021201-11:03:05.231116500"));

        // reported in #468 & #842
        Assert.That(
            DateTimeConverter.ToFIX(
                DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 000, 000, 500), DateTimeKind.Utc),
                TimeStampPrecision.Nanosecond),
            Is.EqualTo("20021201-11:03:05.000000500"));
    }

    [Test]
    public void ConvertTimeOnly_NanosecondBug() {
        Assert.That(
            DateTimeConverter.ToFIXTimeOnly(
                DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 231, 116, 500), DateTimeKind.Utc),
                TimeStampPrecision.Nanosecond),
            Is.EqualTo("11:03:05.231116500"));

        // reported in #468 & #842
        Assert.That(
            DateTimeConverter.ToFIXTimeOnly(
                DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 000, 000, 500), DateTimeKind.Utc),
                TimeStampPrecision.Nanosecond),
            Is.EqualTo("11:03:05.000000500"));
    }
}
