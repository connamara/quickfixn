using NUnit.Framework;
using QuickFix.Fields.Converters;

namespace UnitTests.Fields.Converters;

[TestFixture]
public class CheckSumConverterTests {
    [Test]
    public void ConvertStringToInt() {
        Assert.AreEqual(1, CheckSumConverter.Convert("1"));
        Assert.AreEqual(123, CheckSumConverter.Convert("123"));
        Assert.AreEqual(12, CheckSumConverter.Convert("012"));
    }

    [Test]
    public void ConvertIntToString() {
        Assert.AreEqual("001", CheckSumConverter.Convert(1));
        Assert.AreEqual("012", CheckSumConverter.Convert(12));
        Assert.AreEqual("123", CheckSumConverter.Convert(123));
        Assert.AreEqual("1234", CheckSumConverter.Convert(1234));
    }
}
