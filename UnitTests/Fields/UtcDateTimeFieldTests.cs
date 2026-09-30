using System;
using NUnit.Framework;
using QuickFix.Fields;

namespace UnitTests.Fields;

[TestFixture]
public class UtcDateTimeFieldTests
{
    [Test]
    public void DefaultCtorTest()
    {
        UtcDateTimeField f = new(Tags.SendingTime);
        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
    }

    [TestCase(DateTimeKind.Unspecified)]
    [TestCase(DateTimeKind.Utc)]
    public void CtorWithKindUtcOrUnspecifiedTest(DateTimeKind kind)
    {
        // Unspecified is assumed to be UTC
        DateTime dt = new(2025, 10, 31, 17, 30, 59, kind);
        UtcDateTimeField f = new(Tags.SendingTime, dt, TimePrecision.Millisecond);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.ToString(), Is.EqualTo("20251031-17:30:59.000"));
    }

    [Test]
    public void CtorWithLocalKindTest()
    {
        DateTime local = DateTime.SpecifyKind(new DateTime(2025, 10, 31, 17, 30, 59), DateTimeKind.Local);
        UtcDateTimeField f = new(Tags.SendingTime, local, TimePrecision.Millisecond);

        // derive the expectation from TimeZoneInfo, not from ToUniversalTime, so this isn't just a
        // restatement of the implementation
        TimeSpan offset = TimeZoneInfo.Local.GetUtcOffset(local);
        DateTime expectedUtc = DateTime.SpecifyKind(local - offset, DateTimeKind.Utc);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.Value == expectedUtc, Is.True);
        if (offset != TimeSpan.Zero) // this will fail if CI is in UTC, of course
            Assert.That(f.ToString(), Is.Not.EqualTo("20251031-17:30:59.000")); // because it got shifted from local
    }

    [TestCase(DateTimeKind.Unspecified)]
    [TestCase(DateTimeKind.Utc)]
    public void ValueSetterUtcOrUnspecifiedTest(DateTimeKind kind)
    {
        UtcDateTimeField f = new(Tags.SendingTime);
        f.Value = new DateTime(2025, 10, 31, 17, 30, 59, kind);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.ToString(), Is.EqualTo("20251031-17:30:59.000"));
    }

    [Test]
    public void ValueSetterForcesUtcViaBaseTypedReferenceTest()
    {
        DateTimeField f = new SendingTime();
        DateTime local = DateTime.SpecifyKind(new DateTime(2025, 10, 31, 17, 30, 59), DateTimeKind.Local);
        f.Value = local;

        TimeSpan offset = TimeZoneInfo.Local.GetUtcOffset(local);
        DateTime expectedUtc = DateTime.SpecifyKind(local - offset, DateTimeKind.Utc);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.Value == expectedUtc, Is.True);
        if (offset != TimeSpan.Zero) // this will fail if CI is in UTC, of course
            Assert.That(f.ToString(), Is.Not.EqualTo("20251031-17:30:59.000")); // because it got shifted from local
    }

    [Test]
    public void DateTimeKindHasNoUnhandledMembers()
    {
        // UtcDateTimeField.ToUtc treats anything that isn't Utc/Local as Unspecified;
        // fail loudly if a future runtime adds a new DateTimeKind member, which this impl would silently swallow
        Assert.That(Enum.GetValues<DateTimeKind>(), Is.EquivalentTo(new[]
            { DateTimeKind.Unspecified, DateTimeKind.Utc, DateTimeKind.Local }));
    }

    [Test]
    public void ToStringTest()
    {
        UtcDateTimeField f = new(Tags.SendingTime, new DateTime(2009, 9, 4, 3, 44, 1, DateTimeKind.Unspecified));
        Assert.That(f.ToString(), Is.EqualTo("20090904-03:44:01.000"));
        Assert.That(f.ToStringField(), Is.EqualTo("52=20090904-03:44:01.000"));
    }

    [Test]
    public void LegacyCtorThatTakesShowMillisecondsTest()
    {
        DateTime dt = new(2025, 10, 31, 17, 30, 59, DateTimeKind.Unspecified);
        UtcDateTimeField f = new(Tags.SendingTime, dt, false);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.ToString(), Is.EqualTo("20251031-17:30:59"));
    }

    [Test]
    public void CtorWithTimePrecisionTest()
    {
        DateTime dt = new(2025, 10, 31, 17, 30, 59, DateTimeKind.Unspecified);
        UtcDateTimeField f = new(Tags.SendingTime, dt, TimePrecision.Second);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.ToString(), Is.EqualTo("20251031-17:30:59"));
    }
}
