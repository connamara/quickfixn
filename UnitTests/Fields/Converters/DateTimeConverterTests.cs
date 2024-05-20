using System;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;
using UnitTests.TestHelpers;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class DateTimeConverterTests {

    [SetUp]
    public void SetUp() {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
    }

    [TearDown]
    public void TearDown() {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
    }

    [Test]
    public void ParseToDateTimeTest() {
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 0, 0, 0)));
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 0, 0)));
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 456, 0)));

        // DateTime only supports tick resolution, which is 100ns
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456789"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 456, 700)));
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456789Z"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 456, 700)));

        // Timezones
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456789+01:30"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 2, 52, 1, 123, 456, 700)));
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456789-01:30"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 5, 52, 1, 123, 456, 700)));
    }

    [Test]
    public void ParseToDateTimeTest_Exceptions() {
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateTime(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateTime("20021201"); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateTime("20021201-11:03"); });
    }

    [Test]
    public void ParseToDateOnlyTest() {
        Assert.That(DateTimeConverter.ParseToDateOnly("20100912"), Is.EqualTo(new DateTime(2010, 9, 12, 0, 0, 0, DateTimeKind.Utc)));
    }

    [Test]
    public void ParseToDateOnlyTest_Exceptions() {
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateOnly(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateOnly("20021201-11:03:00"); });
    }

    [Test]
    public void ParseToTimeOnlyTest() {
        var targetTicks = new DateTime(1980, 1, 1, 4, 22, 1, 0, DateTimeKind.Utc).Ticks;
        Assert.That(targetTicks, Is.EqualTo(624511453210000000)); // for human reader reference

        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01").Ticks, Is.EqualTo(targetTicks));
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123").Ticks, Is.EqualTo(targetTicks + 1230000));
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123456").Ticks, Is.EqualTo(targetTicks + 1234560));
    }

    [Test]
    public void ParseToTimeOnlyTest_Nano() {
        var targetTicks = new DateTime(1980, 1, 1, 4, 22, 1, 0, DateTimeKind.Utc).Ticks;
        Assert.That(targetTicks, Is.EqualTo(624511453210000000)); // for human reader reference

        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123456700").Ticks, Is.EqualTo(targetTicks + 1234567));
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123456700Z").Ticks, Is.EqualTo(targetTicks + 1234567));

        var ticksInHour = 36000000000;
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123456700+01").Ticks, Is.EqualTo(targetTicks + 1234567 - ticksInHour));
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123456700-01").Ticks, Is.EqualTo(targetTicks + 1234567 + ticksInHour));

        var ticksIn90mins = 54000000000;
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123456700+01:30").Ticks, Is.EqualTo(targetTicks + 1234567 - ticksIn90mins));
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123456700-01:30").Ticks, Is.EqualTo(targetTicks + 1234567 + ticksIn90mins));
    }

    [Test]
    public void ParseToTimeOnlyTest_Exceptions() {
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToTimeOnly(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToTimeOnly("20021201-11:03:00"); });
    }

    [Test]
    public void ToFIXTest() {
        var dtSec = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 0, 0, 0), DateTimeKind.Utc);
        var dtMs = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 0, 0), DateTimeKind.Utc);
        var dtMicro = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 0, 654, 0), DateTimeKind.Utc);
        var dtNanoFull = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 654, 700), DateTimeKind.Utc);
        var dtNano100 = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 000, 000, 100), DateTimeKind.Utc);

        Assert.That(DateTimeConverter.ToFIX(dtSec, TimeStampPrecision.Second), Is.EqualTo("20021201-11:03:05"));
        Assert.That(DateTimeConverter.ToFIX(dtMs, TimeStampPrecision.Second), Is.EqualTo("20021201-11:03:05"));
        Assert.That(DateTimeConverter.ToFIX(dtMicro, TimeStampPrecision.Second), Is.EqualTo("20021201-11:03:05"));
        Assert.That(DateTimeConverter.ToFIX(dtNanoFull, TimeStampPrecision.Second), Is.EqualTo("20021201-11:03:05"));
        Assert.That(DateTimeConverter.ToFIX(dtNano100, TimeStampPrecision.Second), Is.EqualTo("20021201-11:03:05"));

        Assert.That(DateTimeConverter.ToFIX(dtSec, TimeStampPrecision.Millisecond), Is.EqualTo("20021201-11:03:05.000"));
        Assert.That(DateTimeConverter.ToFIX(dtMs, TimeStampPrecision.Millisecond), Is.EqualTo("20021201-11:03:05.123"));
        Assert.That(DateTimeConverter.ToFIX(dtMicro, TimeStampPrecision.Millisecond), Is.EqualTo("20021201-11:03:05.000"));
        Assert.That(DateTimeConverter.ToFIX(dtNanoFull, TimeStampPrecision.Millisecond), Is.EqualTo("20021201-11:03:05.123"));
        Assert.That(DateTimeConverter.ToFIX(dtNano100, TimeStampPrecision.Millisecond), Is.EqualTo("20021201-11:03:05.000"));

        Assert.That(DateTimeConverter.ToFIX(dtSec, TimeStampPrecision.Microsecond), Is.EqualTo("20021201-11:03:05.000000"));
        Assert.That(DateTimeConverter.ToFIX(dtMs, TimeStampPrecision.Microsecond), Is.EqualTo("20021201-11:03:05.123000"));
        Assert.That(DateTimeConverter.ToFIX(dtMicro, TimeStampPrecision.Microsecond), Is.EqualTo("20021201-11:03:05.000654"));
        Assert.That(DateTimeConverter.ToFIX(dtNanoFull, TimeStampPrecision.Microsecond), Is.EqualTo("20021201-11:03:05.123654"));
        Assert.That(DateTimeConverter.ToFIX(dtNano100, TimeStampPrecision.Microsecond), Is.EqualTo("20021201-11:03:05.000000"));

        Assert.That(DateTimeConverter.ToFIX(dtSec, TimeStampPrecision.Nanosecond), Is.EqualTo("20021201-11:03:05.000000000"));
        Assert.That(DateTimeConverter.ToFIX(dtMs, TimeStampPrecision.Nanosecond), Is.EqualTo("20021201-11:03:05.123000000"));
        Assert.That(DateTimeConverter.ToFIX(dtMicro, TimeStampPrecision.Nanosecond), Is.EqualTo("20021201-11:03:05.000654000"));
        Assert.That(DateTimeConverter.ToFIX(dtNanoFull, TimeStampPrecision.Nanosecond), Is.EqualTo("20021201-11:03:05.123654700"));
        Assert.That(DateTimeConverter.ToFIX(dtNano100, TimeStampPrecision.Nanosecond), Is.EqualTo("20021201-11:03:05.000000100"));
    }

    [Test]
    public void ToFIXDateOnlyTest() {
        var dt = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 654, 700), DateTimeKind.Utc);
        Assert.That(DateTimeConverter.ToFIXDateOnly(dt), Is.EqualTo("20021201"));
    }

    [Test]
    public void ToFIXTimeOnlyTest() {
        var dtSec = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 0, 0, 0), DateTimeKind.Utc);
        var dtMs = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 0, 0), DateTimeKind.Utc);
        var dtMicro = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 0, 654, 0), DateTimeKind.Utc);
        var dtNanoFull = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 654, 700), DateTimeKind.Utc);
        var dtNano100 = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 000, 000, 100), DateTimeKind.Utc);

        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtSec, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtMs, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtMicro, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtNanoFull, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtNano100, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));

        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtSec, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtMs, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.123"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtMicro, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtNanoFull, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.123"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtNano100, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.000"));

        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtSec, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.000000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtMs, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.123000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtMicro, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.000654"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtNanoFull, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.123654"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtNano100, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.000000"));

        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtSec, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.000000000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtMs, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.123000000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtMicro, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.000654000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtNanoFull, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.123654700"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(dtNano100, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.000000100"));
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
