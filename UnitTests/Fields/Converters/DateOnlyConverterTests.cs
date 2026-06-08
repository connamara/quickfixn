using System;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class DateOnlyConverterTests
{
    [Test]
    public void ConvertToStringTest()
    {
        Assert.That(DateOnlyConverter.Convert(new DateOnly(2025, 3, 1)), Is.EqualTo("20250301"));
        Assert.That(DateOnlyConverter.Convert(new DateOnly(2025, 10, 31)), Is.EqualTo("20251031"));
    }

    [Test]
    public void CovertFromStringTest()
    {
        Assert.That(DateOnlyConverter.Convert("20251031"), Is.EqualTo(new DateOnly(2025, 10, 31)));

        Assert.Throws(typeof(FieldConvertError), delegate { DateOnlyConverter.Convert("2025-10-31"); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateOnlyConverter.Convert("2025"); });
        Assert.Throws(typeof(FieldConvertError), delegate { DateOnlyConverter.Convert("pants"); });
    }
}
