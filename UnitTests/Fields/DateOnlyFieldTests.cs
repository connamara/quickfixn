using System;
using NUnit.Framework;
using QuickFix.Fields;

namespace UnitTests.Fields;

[TestFixture]
public class DateOnlyFieldTests
{
    [Test]
    public void DefaultCtorTest()
    {
        DateOnlyField dof = new(Tags.MDEntryDate);
        Assert.That(dof.ToString(), Is.EqualTo("00010101"));
        Assert.That(dof.ToStringField(), Is.EqualTo("272=00010101"));
    }

    [Test]
    public void LegacyTest()
    {
        DateTime dt = new(2025, 10, 31, 17, 30, 59);
        DateOnlyField dof = new(Tags.MDEntryDate, dt);

        // This will break after change
        Assert.That(dof.Value.ToString("yyyyMMdd-HH:mm:ss"), Is.EqualTo("20251031-17:30:59"));

        Assert.That(dof.ToString(), Is.EqualTo("20251031"));
        Assert.That(dof.ToStringField(), Is.EqualTo("272=20251031"));
    }
}
