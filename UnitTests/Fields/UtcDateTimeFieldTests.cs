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

    [Test]
    public void CtorWithUnspecifiedKindTest()
    {
        DateTime dt = new(2025, 10, 31, 17, 30, 59, DateTimeKind.Unspecified);
        UtcDateTimeField f = new(Tags.SendingTime, dt);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.Value.ToString("HH:mm:ss"), Is.EqualTo("17:30:59"));
    }

    [Test]
    public void CtorWithLocalKindTest()
    {
        DateTime local = DateTime.SpecifyKind(new DateTime(2025, 10, 31, 17, 30, 59), DateTimeKind.Local);
        // derive the expectation from TimeZoneInfo, not from ToUniversalTime, so this isn't just a
        // restatement of the implementation
        TimeSpan offset = TimeZoneInfo.Local.GetUtcOffset(local);

        UtcDateTimeField f = new(Tags.SendingTime, local);

        DateTime expectedUtc = DateTime.SpecifyKind(local - offset, DateTimeKind.Utc);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.Value == expectedUtc, Is.True);
        if (offset != TimeSpan.Zero) // CI runs UTC, where a converted value is indistinguishable from a relabeled one
            Assert.That(f.Value == DateTime.SpecifyKind(local, DateTimeKind.Utc), Is.False);
    }

    [Test]
    public void CtorWithUtcKindTest()
    {
        DateTime dt = DateTime.SpecifyKind(new DateTime(2025, 10, 31, 17, 30, 59), DateTimeKind.Utc);
        UtcDateTimeField f = new(Tags.SendingTime, dt);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.Value, Is.EqualTo(dt));
    }

    [Test]
    public void ValueSetterForcesUtcTest()
    {
        UtcDateTimeField f = new(Tags.SendingTime);
        f.Value = new DateTime(2025, 10, 31, 17, 30, 59, DateTimeKind.Unspecified);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.Value.ToString("HH:mm:ss"), Is.EqualTo("17:30:59"));
    }

    [Test]
    public void ValueSetterForcesUtcViaBaseTypedReferenceTest()
    {
        // Value must be an override, not `new`-hiding, or a base-typed reference would write local
        // wall-clock time into a UTCTIMESTAMP field
        DateTimeField f = new SendingTime();
        DateTime local = DateTime.SpecifyKind(new DateTime(2025, 10, 31, 17, 30, 59), DateTimeKind.Local);
        TimeSpan offset = TimeZoneInfo.Local.GetUtcOffset(local);

        f.Value = local;

        DateTime expectedUtc = DateTime.SpecifyKind(local - offset, DateTimeKind.Utc);

        Assert.That(f.Value.Kind, Is.EqualTo(DateTimeKind.Utc));
        Assert.That(f.Value == expectedUtc, Is.True); // local was converted to UTC
    }

    [Test]
    public void DateTimeKindHasNoUnhandledMembers()
    {
        // UtcDateTimeField.ToUtc treats anything that isn't Utc/Local as Unspecified;
        // fail loudly if a future runtime adds a member that assumption would silently swallow
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
