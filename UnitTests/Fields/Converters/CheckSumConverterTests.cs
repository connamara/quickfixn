using NUnit.Framework;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class CheckSumConverterTests {
    [Test]
    public void ConvertStringToInt() {
        Assert.That(CheckSumConverter.Convert("1"), Is.EqualTo(1));
        Assert.That(CheckSumConverter.Convert("123"), Is.EqualTo(123));
        Assert.That(CheckSumConverter.Convert("012"), Is.EqualTo(12));
    }

    [Test]
    public void ConvertIntToString() {
        Assert.That(CheckSumConverter.Convert(1), Is.EqualTo("001"));
        Assert.That(CheckSumConverter.Convert(12), Is.EqualTo("012"));
        Assert.That(CheckSumConverter.Convert(123), Is.EqualTo("123"));
        Assert.That(CheckSumConverter.Convert(1234), Is.EqualTo("1234"));
    }
}
