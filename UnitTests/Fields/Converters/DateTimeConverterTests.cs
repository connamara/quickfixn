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
        Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05)), Is.EqualTo("20021201-11:03:05.000"));
        Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("20021201-11:03:05.321"));
        Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321), false), Is.EqualTo("20021201-11:03:05"));
        Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321), true), Is.EqualTo("20021201-11:03:05.321"));

        // 2 valid string-to-DateTime formats
        Assert.That(DateTimeConverter.ConvertToDateTime("20100912-04:22:01"), Is.EqualTo(new DateTime(2010, 9, 12, 4, 22, 01, DateTimeKind.Utc)));
        Assert.That(DateTimeConverter.ConvertToDateTime("20100912-04:22:01.123"), Is.EqualTo(new DateTime(2010, 9, 12, 4, 22, 01, 123, DateTimeKind.Utc)));

        // invalid string-to-DateTime formats
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateTime(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateTime("20021201"); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateTime("20021201-11:03"); });
    }

    [Test]
    public void DateOnlyConverterTest()
    {
        // DateTime types to string
        Assert.That(DateTimeConverter.ConvertDateOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("20021201"));

        // string-to-DateTime but time is zero
        Assert.That(DateTimeConverter.ConvertToDateOnly("20100912"), Is.EqualTo(new DateTime(2010, 9, 12, 0, 0, 0, DateTimeKind.Utc)));

        // invalid string-to-DateTime formats
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateOnly(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateOnly("20021201-11:03:00"); });
    }

    [Test]
    public void TimeOnlyConverterTest()
    {
        // DateTime types to string
        Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05)), Is.EqualTo("11:03:05.000"));
        Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("11:03:05.321"));
        Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), false), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), true), Is.EqualTo("11:03:05.321"));

        // 2 valid string-to-DateTime formats, set date to Jan 1
        Assert.That(DateTimeConverter.ConvertToTimeOnly("04:22:01"), Is.EqualTo(new DateTime(1980, 1, 1, 4, 22, 01, DateTimeKind.Utc)));
        Assert.That(DateTimeConverter.ConvertToTimeOnly("04:22:01.123"), Is.EqualTo(new DateTime(1980, 1, 1, 4, 22, 01, 123, DateTimeKind.Utc)));

        // invalid string-to-DateTime formats
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToTimeOnly(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToTimeOnly("20021201-11:03:00"); });
    }

    [Test]
    public void TestNanosecondPrecision()
    {
        // seeded DateTime
        DateTime dt = DateTime.SpecifyKind(TimeHelper.makeDateTime(2002, 12, 01, 11, 03, 05, 231, 116, 500), DateTimeKind.Utc);

        // convert nanosecond DateTime to string with option
        Assert.That(DateTimeConverter.Convert(dt, TimeStampPrecision.Nanosecond), Is.EqualTo("20021201-11:03:05.231116500"));

        /*
        // convert nanosecond DateTime to string with option
        DateTime dt4 = DateTime.SpecifyKind(TimeHelper.makeDateTime(2002, 12, 01, 11, 03, 05, 0, 0, 100), DateTimeKind.Utc);
        Console.WriteLine(dt4);
        Console.WriteLine(dt4.Millisecond);
        Console.WriteLine(dt4.Nanosecond());
        Console.WriteLine(dt4.Ticks);
        Assert.That(DateTimeConverter.Convert(dt4, TimeStampPrecision.Nanosecond), Is.EqualTo("20021201-11:03:05.000000001"));
        */

        // convert nanosecond DateTime to time-only string
        Assert.That(DateTimeConverter.ConvertTimeOnly(dt, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.231116500"));

        // convert nanosecond time string to DateTime time portion only
        DateTime timeOnly = TimeHelper.makeTimeOnly(11, 03, 05, 231, 116, 500);
        Assert.That(DateTimeConverter.ConvertToTimeOnly("11:03:05.231116500", TimeStampPrecision.Nanosecond), Is.EqualTo(timeOnly));

        // convert nanosecond time string to full DateTime
        Assert.That(DateTimeConverter.ConvertToDateTime("20021201-11:03:05.231116500", TimeStampPrecision.Nanosecond), Is.EqualTo(dt));

        // convert nanosecond time with UTC time zone to full DateTime
        Assert.That(DateTimeConverter.ConvertToDateTime("20021201-11:03:05.231116500Z", TimeStampPrecision.Nanosecond), Is.EqualTo(dt));

        // convert nanosecond time with non-UTC positive offset time zone to full DateTime
        Assert.That(DateTimeConverter.ConvertToDateTime("20021201-16:03:05.231116500+05", TimeStampPrecision.Nanosecond), Is.EqualTo(dt));

        // convert nanosecond time with non-UTC negative offset time zone to full DateTime
        Assert.That(DateTimeConverter.ConvertToDateTime("20021201-08:03:05.231116500-03", TimeStampPrecision.Nanosecond), Is.EqualTo(dt));

        // convert nanosecond time in local time (no time zone) to full DateTime
        DateTime local = DateTime.SpecifyKind(TimeHelper.makeDateTime(2002, 12, 01, 11, 03, 05, 231, 116, 500), DateTimeKind.Local);
        Assert.That(DateTimeConverter.ConvertToDateTime("20021201-11:03:05.231116500", TimeStampPrecision.Nanosecond), Is.EqualTo(local));
    }
}
