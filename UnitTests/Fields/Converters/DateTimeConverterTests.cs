using System;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;
using UnitTests.TestHelpers;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class DateTimeConverterTests {
    
    private const string TimeOnlyFormatWithMicroseconds = "{0:HH:mm:ss.ffffff}";

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
        DateTimeOffset? dto;

        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 0, 0, 0)));
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 0, 0)));
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456", out dto),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 456, 0)));
        Assert.That(dto, Is.Null); // no timezone info

        // DateTime only supports tick resolution, which is 100ns
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456789", out dto),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 456, 700)));
        Assert.That(dto, Is.Null); // no timezone info

        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456789Z", out dto),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 456, 700)));
        Assert.That(dto?.DateTime, Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 456, 700)));
        Assert.That(dto?.Offset, Is.EqualTo(new TimeSpan(hours: 0, minutes: 0, seconds: 0))); // timezone is UTC

        // Timezones
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456789+01:30"),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 2, 52, 1, 123, 456, 700)));
        Assert.That(DateTimeConverter.ParseToDateTime("20100912-04:22:01.123456789-01:30", out dto),
            Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 5, 52, 1, 123, 456, 700)));

        Assert.That(dto?.DateTime, Is.EqualTo(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 456, 700)));
        Assert.That(dto?.Offset, Is.EqualTo(new TimeSpan(hours: 0, minutes: -90, seconds: 0)));
    }

    [Test]
    public void ParseToDateTimeTest_Exceptions() {
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateTime(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateTime("20021201"); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateTime("20021201-11:03"); });
    }

    [Test]
    public void ParseToDateOnlyTest_ReturnsDateOnly() {
        ReadOnlySpan<char> ros = "20100912";
        DateOnly rv = DateTimeConverter.ParseToDateOnly(ros);
        Assert.That(rv, Is.EqualTo(new DateOnly(2010, 9, 12)));
    }

    [Test]
    public void ParseToDateOnlyTest_ReturnsDateTime() {
        DateTime rv = DateTimeConverter.ParseToDateOnly("20100912");
        Assert.That(rv, Is.EqualTo(new DateTime(2010, 9, 12, 0, 0, 0, DateTimeKind.Utc)));
    }

    [Test]
    public void ParseToDateOnlyTest_Exceptions() {
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateOnly(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToDateOnly("20021201-11:03:00"); });
    }

    [Test]
    public void ParseToTimeOnlyTest_ReturnsTimeOnly() {
        var targetTicks = new TimeSpan(4, 22, 1).Ticks;
        Assert.That(targetTicks, Is.EqualTo(157210000000)); // for human reader reference

        TimeSpan? timeSpan;

        TimeOnly rv = DateTimeConverter.ParseToTimeOnly("04:22:01", out timeSpan);
        Assert.That(rv.Ticks, Is.EqualTo(targetTicks));
        Assert.That(timeSpan, Is.Null);

        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123", out _).Ticks, Is.EqualTo(targetTicks + 1230000));
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123456", out _).Ticks, Is.EqualTo(targetTicks + 1234560));

        rv = DateTimeConverter.ParseToTimeOnly("04:22:01-03:00", out timeSpan);
        Assert.That(rv.Ticks, Is.EqualTo(targetTicks));
        Assert.That(timeSpan, Is.EqualTo(new TimeSpan(-3, 0, 0)));
    }

    [Test]
    public void ParseToTimeOnlyTest_ReturnsDateTime() {
        var targetTicks = new DateTime(1980, 1, 1, 4, 22, 1, 0, DateTimeKind.Utc).Ticks;
        Assert.That(targetTicks, Is.EqualTo(624511453210000000)); // for human reader reference

        DateTime rv = DateTimeConverter.ParseToTimeOnly("04:22:01");

        Assert.That(rv.Ticks, Is.EqualTo(targetTicks));
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123").Ticks, Is.EqualTo(targetTicks + 1230000));
        Assert.That(DateTimeConverter.ParseToTimeOnly("04:22:01.123456").Ticks, Is.EqualTo(targetTicks + 1234560));
    }

    [Test]
    public void ParseToTimeOnlyTest_Exceptions() {
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToTimeOnly(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ParseToTimeOnly("20021201-11:03:00"); });
    }

    [Test]
    public void NanosecondTest() {
        Assert.That(new DateTime(2000, 12, 31).Nanosecond, Is.EqualTo(0));
        Assert.That(TimeHelper.MakeDateTime(2010, 9, 12, 4, 22, 1, 123, 456, 700).Nanosecond, Is.EqualTo(700));
    }

    [Test]
    public void ToFIXTest() {
        var dtSec = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 0, 0, 0), DateTimeKind.Utc);
        var dtMs = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 0, 0), DateTimeKind.Utc);
        var dtMicro = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 0, 654, 0), DateTimeKind.Utc);
        var dtNanoFull = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 654, 700), DateTimeKind.Utc);
        var dtNano100 = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 000, 000, 100), DateTimeKind.Utc);

        // ToFIX(DateTime dt, TimeStampPrecision precision)
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
        // ToFIXDateOnly(DateOnly)
        Assert.That(DateTimeConverter.ToFIXDateOnly(new DateOnly(2002, 12, 01)), Is.EqualTo("20021201"));

        // ToFIXDateOnly(DateTime)
        var dt = DateTime.SpecifyKind(
            TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 654, 700),
            DateTimeKind.Utc);
        Assert.That(DateTimeConverter.ToFIXDateOnly(dt), Is.EqualTo("20021201"));
    }

    [Test]
    public void ToFIXTimeOnlyTest_TimeOnlyParam() {
        var tSec = TimeHelper.MakeTimeOnly(11, 03, 05, 0, 0, 0);
        var tMs = TimeHelper.MakeTimeOnly(11, 03, 05, 123, 0, 0);
        var tMicro = TimeHelper.MakeTimeOnly(11, 03, 05, 0, 654, 0);
        var tNanoFull = TimeHelper.MakeTimeOnly(11, 03, 05, 123, 654, 700);
        var tNano100 = TimeHelper.MakeTimeOnly(11, 03, 05, 000, 000, 100);

        // ToFIXTimeOnly(TimeOnly time, TimeStampPrecision precision)
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tSec, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tMs, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tMicro, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tNanoFull, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tNano100, TimeStampPrecision.Second), Is.EqualTo("11:03:05"));

        Assert.That(DateTimeConverter.ToFIXTimeOnly(tSec, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tMs, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.123"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tMicro, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tNanoFull, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.123"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tNano100, TimeStampPrecision.Millisecond), Is.EqualTo("11:03:05.000"));

        Assert.That(DateTimeConverter.ToFIXTimeOnly(tSec, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.000000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tMs, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.123000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tMicro, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.000654"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tNanoFull, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.123654"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tNano100, TimeStampPrecision.Microsecond), Is.EqualTo("11:03:05.000000"));

        Assert.That(DateTimeConverter.ToFIXTimeOnly(tSec, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.000000000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tMs, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.123000000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tMicro, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.000654000"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tNanoFull, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.123654700"));
        Assert.That(DateTimeConverter.ToFIXTimeOnly(tNano100, TimeStampPrecision.Nanosecond), Is.EqualTo("11:03:05.000000100"));
    }

    [Test]
    public void ToFIXTimeOnlyTest_DateTimeParam() {
        var dtSec = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 0, 0, 0), DateTimeKind.Utc);
        var dtMs = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 0, 0), DateTimeKind.Utc);
        var dtMicro = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 0, 654, 0), DateTimeKind.Utc);
        var dtNanoFull = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 123, 654, 700), DateTimeKind.Utc);
        var dtNano100 = DateTime.SpecifyKind(TimeHelper.MakeDateTime(2002, 12, 01, 11, 03, 05, 000, 000, 100), DateTimeKind.Utc);

        // string ToFIXTimeOnly(DateTime dt, TimeStampPrecision precision)
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
}
