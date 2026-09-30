using System.Collections.Generic;
using DDTool.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Structures;

[TestClass]
public class DDFieldTests {

    [TestMethod]
    public void UtcTimestampMapsToUtcDateTimeField() {
        var field = new DDField(52, "SendingTime", [], "UTCTIMESTAMP");

        Assert.AreEqual("UtcDateTimeField", field.CsClass);
        Assert.AreEqual("DateTime", field.BaseType);
    }

    [TestMethod]
    public void TzTimestampMapsToDateTimeField() {
        var field = new DDField(1132, "TZTransactTime", [], "TZTIMESTAMP");

        Assert.AreEqual("DateTimeField", field.CsClass);
        Assert.AreEqual("DateTime", field.BaseType);
    }

    [TestMethod]
    public void TimeMapsToDateTimeField() {
        var field = new DDField(273, "MDEntryTime", [], "TIME");

        Assert.AreEqual("DateTimeField", field.CsClass);
        Assert.AreEqual("DateTime", field.BaseType);
    }
}
