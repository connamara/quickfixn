using System;
using System.Collections.Generic;
using System.Linq;
using DDTool.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Structures;

[TestClass]
public class DataDictionaryTests {

    [TestMethod]
    public void Identifier() {
        DataDictionary dd = new("whatev");
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
        DataDictionary dd = new("whatev");
        Assert.AreEqual("FIX", dd.IdentifierNoDots);
        dd.MajorVersion = 9;
        dd.MinorVersion = 8;
        dd.ServicePack = 7;
        dd.IsFIXT = true;
        Assert.AreEqual("FIXT98SP7", dd.IdentifierNoDots);
    }

    [TestMethod]
    public void Name() {
        DataDictionary dd = new("whatev");
        dd.MajorVersion = 9;
        dd.MinorVersion = 8;
        Assert.AreEqual("FIX98", dd.Name);
        dd.CustomName = "batman";
        Assert.AreEqual("batman", dd.Name);
    }
}
