using System.Collections.Generic;
using DDTool.Structures;
using DDTool.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Validations;

[TestClass]
public class BrokerProjectValidatorTests {

    [TestMethod]
    public void Check_RequiresCustomName() {
        DataDictionary dd = new("a.xml") { MajorVersion = 4, MinorVersion = 4 };
        List<string> errors = BrokerProjectValidator.Check([dd]);
        Assert.AreEqual(1, errors.Count);
        StringAssert.StartsWith(errors[0],
            "a.xml: --brokerproject requires a \"customname\" attribute on the root <fix> tag");
    }

    [TestMethod]
    public void Check_RejectsWhitespaceCustomName() {
        DataDictionary dd = new("a.xml") {
            MajorVersion = 4, MinorVersion = 4, CustomName = "   "
        };
        List<string> errors = BrokerProjectValidator.Check([dd]);
        Assert.AreEqual(1, errors.Count);
        StringAssert.StartsWith(errors[0],
            "a.xml: --brokerproject requires a \"customname\" attribute on the root <fix> tag");
    }

    [TestMethod]
    public void Check_RequiresUniqueCustomNames() {
        DataDictionary a = new("a.xml") { CustomName = "SAME" };
        DataDictionary b = new("b.xml") { CustomName = "SAME" };
        List<string> errors = BrokerProjectValidator.Check([a, b]);
        Assert.AreEqual(1, errors.Count);
        StringAssert.StartsWith(errors[0], "Duplicate customname \"SAME\"");
        StringAssert.EndsWith(errors[0], "Files: [a.xml, b.xml]");
    }

    [TestMethod]
    public void Check_AcceptsUniqueCustomNames() {
        DataDictionary a = new("a.xml") { CustomName = "Alpha" };
        DataDictionary b = new("b.xml") { CustomName = "Beta" };
        List<string> errors = BrokerProjectValidator.Check([a, b]);
        Assert.AreEqual(0, errors.Count);
    }
}
