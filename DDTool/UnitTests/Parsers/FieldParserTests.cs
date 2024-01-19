using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Parsers;

[TestClass]
public class FieldParserTests {

    [TestMethod]
    public void ParseFields() {
        var xml = new StringBuilder();
        xml.AppendLine("<fix><fields>");
        xml.AppendLine("  <field number='1' name='Account' type='sTRING'/>");
        xml.AppendLine("  <field number='4' name='AdvSide' type='CHaR'>");
        xml.AppendLine("    <value enum='B' description='BUY'/>");
        xml.AppendLine("    <value enum='S' description='Sell'/>");
        xml.AppendLine("  </field>");
        xml.AppendLine("  <field number='14' name='CumQty' type='QTY' />");
        xml.AppendLine("</fields></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Fields);

        Assert.AreEqual(3, dd.FieldsByTag.Count);
        Assert.AreEqual(3, dd.FieldsByName.Count);

        Assert.AreEqual(dd.FieldsByTag[1], dd.FieldsByName["Account"]);
        Assert.AreEqual(dd.FieldsByTag[4], dd.FieldsByName["AdvSide"]);
        Assert.AreEqual(dd.FieldsByTag[14], dd.FieldsByName["CumQty"]);

        var fld = dd.FieldsByTag[1];
        Assert.AreEqual("1:Account:STRING", $"{fld.Tag}:{fld.Name}:{fld.TypeFromXml}");
        fld = dd.FieldsByTag[14];
        Assert.AreEqual("14:CumQty:QTY", $"{fld.Tag}:{fld.Name}:{fld.TypeFromXml}");

        fld = dd.FieldsByTag[4];
        Assert.AreEqual("4:AdvSide:CHAR", $"{fld.Tag}:{fld.Name}:{fld.TypeFromXml}");
        Assert.AreEqual(2, fld.Enums.Count);
        Assert.AreEqual("BUY|B", $"{fld.Enums[0].Desc}|{fld.Enums[0].Val}");
        Assert.AreEqual("Sell|S", $"{fld.Enums[1].Desc}|{fld.Enums[1].Val}");
    }
}
