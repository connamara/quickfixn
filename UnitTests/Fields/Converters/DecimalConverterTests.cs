using System;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class DecimalConverterTests {

    [Test]
    public void Convert()
    {
        Assert.That(DecimalConverter.Convert(4.23322m), Is.EqualTo("4.23322"));
        Assert.That(DecimalConverter.Convert(-4.23322m), Is.EqualTo("-4.23322"));
        Assert.That(DecimalConverter.Convert("4332.33"), Is.EqualTo(new Decimal(4332.33)));
        Assert.That(DecimalConverter.Convert("3.000000000021874E-4"), Is.EqualTo(0.0003000000000021874M));
        Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert("2.32a34"); });
        Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert("+1.2"); });
        Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert("(1.2)"); });
        Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert(null!); });

        // check for a different culture than en-XX
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
        Assert.That(DecimalConverter.Convert("4332.33"), Is.EqualTo(4332.33m));
        Assert.That(DecimalConverter.Convert("-2.33"), Is.EqualTo(-2.33m));
        Assert.That(DecimalConverter.Convert(4.23322m), Is.EqualTo("4.23322"));
        Assert.That(DecimalConverter.Convert(-4.23322m), Is.EqualTo("-4.23322"));
    }

    [Test]
    public void Convert_WithoutLeadingTrailingZeros()
    {
        Assert.That(DecimalConverter.Convert("23."), Is.EqualTo(23m));
        Assert.That(DecimalConverter.Convert(".23"), Is.EqualTo(0.23m));
        Assert.That(DecimalConverter.Convert("-.23"), Is.EqualTo(-0.23m));
    }
}
