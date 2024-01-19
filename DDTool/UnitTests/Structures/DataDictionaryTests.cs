using DDTool.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Structures;

[TestClass]
public class DataDictionaryTests {

    [TestMethod]
    public void Identifier() {
        var dd = new DataDictionary("whatev");
        Assert.AreEqual("FIX..", dd.Identifier);

        dd.MajorVersion = 9;
        dd.MinorVersion = 8;
        Assert.AreEqual("FIX.9.8", dd.Identifier);

        dd.ServicePack = 7;
        Assert.AreEqual("FIX.9.8SP7", dd.Identifier);

        dd.IsFIXT = true;
        Assert.AreEqual("FIXT.9.8SP7", dd.Identifier);
    }

    [TestMethod]
    public void IdentifierNoDots() {
        var dd = new DataDictionary("whatev");
        Assert.AreEqual("FIX", dd.IdentifierNoDots);
        dd.MajorVersion = 9;
        dd.MinorVersion = 8;
        dd.ServicePack = 7;
        dd.IsFIXT = true;
        Assert.AreEqual("FIXT98SP7", dd.IdentifierNoDots);
    }
}
