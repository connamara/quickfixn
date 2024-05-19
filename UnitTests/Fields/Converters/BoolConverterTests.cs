using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class BoolConverterTests {

    [Test]
    public void Convert()
    {
        Assert.That(BoolConverter.Convert("Y"), Is.EqualTo(true));
        Assert.That(BoolConverter.Convert("N"), Is.EqualTo(false));
        Assert.That(BoolConverter.Convert(true), Is.EqualTo("Y"));
        Assert.That(BoolConverter.Convert(false), Is.EqualTo("N"));
        Assert.Throws(typeof(FieldConvertError),
            delegate { BoolConverter.Convert("Z"); });
    }
}
