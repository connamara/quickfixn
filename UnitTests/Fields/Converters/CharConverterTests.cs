using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class CharConverterTests {

    [Test]
    public void Convert()
    {
        Assert.That(CharConverter.Convert('A'), Is.EqualTo("A"));
        Assert.That(CharConverter.Convert("B"), Is.EqualTo('B'));
        Assert.Throws(typeof(FieldConvertError),
            delegate { CharConverter.Convert("AB"); });
    }
}
