using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class IntConverterTests {

    [Test]
    public void Convert()
    {
        Assert.That(IntConverter.Convert(233), Is.EqualTo("233"));
        Assert.That(IntConverter.Convert(-233), Is.EqualTo("-233"));
        Assert.That(IntConverter.Convert("444556"), Is.EqualTo(444556));

        Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert("+100"); });
        Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert("(100)"); });
        Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert("AB"); });
        Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert("2.3234"); });
        Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert(""); });
        Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert(null); });
    }
}
