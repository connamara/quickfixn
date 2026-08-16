using System.Collections.Generic;
using DDTool.Structures;
using DDTool.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Validations;

[TestClass]
public class BrokerProjectValidatorTests {

    [TestMethod]
    public void Check_RequiresCustomName() {
        var dd = new DataDictionary("a.xml") { MajorVersion = 4, MinorVersion = 4 };
        var errors = BrokerProjectValidator.Check(new List<DataDictionary> { dd });
        Assert.AreEqual(1, errors.Count);
        StringAssert.Contains(errors[0], "customname");
        StringAssert.Contains(errors[0], "a.xml");
    }

    [TestMethod]
    public void Check_RejectsWhitespaceCustomName() {
        var dd = new DataDictionary("a.xml") {
            MajorVersion = 4, MinorVersion = 4, CustomName = "   "
        };
        var errors = BrokerProjectValidator.Check(new List<DataDictionary> { dd });
        Assert.AreEqual(1, errors.Count);
        StringAssert.Contains(errors[0], "customname");
    }

    [TestMethod]
    public void Check_RequiresUniqueCustomNames() {
        var a = new DataDictionary("a.xml") { CustomName = "SAME" };
        var b = new DataDictionary("b.xml") { CustomName = "SAME" };
        var errors = BrokerProjectValidator.Check(new List<DataDictionary> { a, b });
        Assert.AreEqual(1, errors.Count);
        StringAssert.Contains(errors[0], "Duplicate customname");
        StringAssert.Contains(errors[0], "SAME");
        StringAssert.Contains(errors[0], "a.xml");
        StringAssert.Contains(errors[0], "b.xml");
    }

    [TestMethod]
    public void Check_AcceptsUniqueCustomNames() {
        var a = new DataDictionary("a.xml") { CustomName = "Alpha" };
        var b = new DataDictionary("b.xml") { CustomName = "Beta" };
        var errors = BrokerProjectValidator.Check(new List<DataDictionary> { a, b });
        Assert.AreEqual(0, errors.Count);
    }
}
