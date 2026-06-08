using System;
using NUnit.Framework;
using QuickFix.Fields;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields;

[TestFixture]
public class TimeOnlyFieldTests
{
    [Test]
    public void DefaultCtorTest()
    {
        TimeOnlyField tof = new(Tags.MDEntryTime);
        Assert.That(tof.ToString(), Is.EqualTo("00:00:00.000"));
        Assert.That(tof.ToStringField(), Is.EqualTo("273=00:00:00.000"));
    }

    [Test]
    public void LegacyTest()
    {
        DateTime dt = new(2025, 10, 31, 17, 30, 59, 333, DateTimeKind.Utc);
        TimeOnlyField tof = new(Tags.MDEntryTime, dt);

        // This will break after change
        Assert.That(tof.Value.ToString("yyyyMMdd-HH:mm:ss.fff"), Is.EqualTo("20251031-17:30:59.333"));

        Assert.That(tof.ToString(), Is.EqualTo("17:30:59.333"));
        Assert.That(tof.ToStringField(), Is.EqualTo("273=17:30:59.333"));

        tof = new(273, dt, false);
        Assert.That(tof.ToString(), Is.EqualTo("17:30:59"));
        Assert.That(tof.ToStringField(), Is.EqualTo("273=17:30:59"));

        tof = new(273, dt, true);
        Assert.That(tof.ToString(), Is.EqualTo("17:30:59.333"));
        Assert.That(tof.ToStringField(), Is.EqualTo("273=17:30:59.333"));

        tof = new(273, dt, TimeStampPrecision.Second);
        Assert.That(tof.ToString(), Is.EqualTo("17:30:59"));
        Assert.That(tof.ToStringField(), Is.EqualTo("273=17:30:59"));

        tof = new(273, dt, TimeStampPrecision.Millisecond);
        Assert.That(tof.ToString(), Is.EqualTo("17:30:59.333"));
        Assert.That(tof.ToStringField(), Is.EqualTo("273=17:30:59.333"));

        tof = new(273, dt, TimeStampPrecision.Nanosecond);
        Assert.That(tof.ToString(), Is.EqualTo("17:30:59.333000000"));
        Assert.That(tof.ToStringField(), Is.EqualTo("273=17:30:59.333000000"));
    }
}
