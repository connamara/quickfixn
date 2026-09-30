using DDTool.Structures;
using DDTool.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Validations;

[TestClass]
public class FieldTypeInfoTests {

    [TestMethod]
    public void UtcTimestampResolvesToUtcDateTimeFieldClass() {
        var field = new DDField(52, "SendingTime", [], "UTCTIMESTAMP");

        Assert.AreEqual(QfnFieldClass.UtcDateTimeField, FieldTypeInfo.GetQfnFieldClass(field));
        Assert.AreEqual("DateTime", FieldTypeInfo.GetBaseType(field));
    }

    [TestMethod]
    public void TzTimestampResolvesToDateTimeFieldClass() {
        var field = new DDField(1132, "TZTransactTime", [], "TZTIMESTAMP");

        Assert.AreEqual(QfnFieldClass.DateTimeField, FieldTypeInfo.GetQfnFieldClass(field));
        Assert.AreEqual("DateTime", FieldTypeInfo.GetBaseType(field));
    }

    [TestMethod]
    public void TimeResolvesToDateTimeFieldClass() {
        var field = new DDField(273, "MDEntryTime", [], "TIME");

        Assert.AreEqual(QfnFieldClass.DateTimeField, FieldTypeInfo.GetQfnFieldClass(field));
        Assert.AreEqual("DateTime", FieldTypeInfo.GetBaseType(field));
    }
}
