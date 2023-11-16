using System;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Parsers;

[TestClass]
public class MessageParserTests {

    [TestMethod]
    public void Empty() {
        var xml = new StringBuilder();
        xml.AppendLine("<fix><messages>");
        xml.AppendLine("  <message name='Heartbeat' msgtype='0' msgcat='admin'>");
        xml.AppendLine("  </message>");
        xml.AppendLine("  <message name='News' msgtype='B' msgcat='app'>");
        xml.AppendLine("  </message>");
        xml.AppendLine("</messages></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Messages);
        Assert.AreEqual(2, dd.Messages.Count);

        var msg = dd.Messages["0"];
        Assert.AreEqual("0:Heartbeat:admin", $"{msg.MsgType}:{msg.Name}:{msg.Cat}");
        msg = dd.Messages["B"];
        Assert.AreEqual("B:News:app", $"{msg.MsgType}:{msg.Name}:{msg.Cat}");
    }

    [TestMethod]
    public void JustFields() {
        var xml = new StringBuilder();
        xml.AppendLine("<fix><messages>");
        xml.AppendLine("  <message name='News' msgtype='B' msgcat='app'>");
        xml.AppendLine("    <field name='OrigTime' required='N' />");
        xml.AppendLine("    <field name='Urgency' required='N' />");
        xml.AppendLine("    <field name='Headline' required='Y' />");
        xml.AppendLine("  </message>");
        xml.AppendLine("  <fields>");
        xml.AppendLine("    <field number='42' name='OrigTime' type='UTCTIMESTAMP' />");
        xml.AppendLine("    <field number='61' name='Urgency' type='CHAR' />");
        xml.AppendLine("    <field number='148' name='Headline' type='STRING' />");
        xml.AppendLine("  </fields>");
        xml.AppendLine("</messages></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Messages);
        Assert.AreEqual(1, dd.Messages.Count);

        var msg = dd.Messages["B"];
        Assert.AreEqual(3, msg.Elements.Count);

        CollectionAssert.AreEqual(new int[] { 42, 61, 148 }, msg.TagOrder.ToArray());
        CollectionAssert.AreEqual(new int[] { 148 }, msg.RequiredTags.OrderBy(x => x).ToArray());
    }

    [TestMethod]
    public void FlatGroups() {
        var xml = new StringBuilder();
        xml.AppendLine("<fix><messages>");
        xml.AppendLine("  <message name='News' msgtype='B' msgcat='app'>");
        xml.AppendLine("    <field name='Headline' required='Y' />");
        xml.AppendLine("    <group name='LinesOfText' required='Y'>");
        xml.AppendLine("       <field name='Text' required='Y' />");
        xml.AppendLine("       <field name='Wahwah' required='Y' />");
        xml.AppendLine("       <field name='EncodedTextLen' required='N' />");
        xml.AppendLine("       <field name='EncodedText' required='N' />");
        xml.AppendLine("    </group>");
        xml.AppendLine("    <group name='NoDoots' required='N'>");
        xml.AppendLine("       <field name='Doot' required='Y' />");
        xml.AppendLine("    </group>");
        xml.AppendLine("  </message>");
        xml.AppendLine("  <fields>");
        xml.AppendLine("    <field number='33' name='LinesOfText' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='58' name='Text' type='STRING' />");
        xml.AppendLine("    <field number='148' name='Headline' type='STRING' />");
        xml.AppendLine("    <field number='354' name='EncodedTextLen' type='LENGTH' />");
        xml.AppendLine("    <field number='355' name='EncodedText' type='DATA' />");
        xml.AppendLine("    <field number='500' name='NoDoots' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='501' name='Doot' type='STRING' />");
        xml.AppendLine("    <field number='999' name='Wahwah' type='INT' />");
        xml.AppendLine("  </fields>");
        xml.AppendLine("</messages></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Messages);
        Assert.AreEqual(1, dd.Messages.Count);

        var msg = dd.Messages["B"];
        Assert.AreEqual(3, msg.Elements.Count);
        CollectionAssert.AreEqual(new int[] { 148, 33, 500 }, msg.TagOrder.ToArray());
        CollectionAssert.AreEqual(new int[] { 33, 148 }, msg.RequiredTags.OrderBy(x => x).ToArray());

        var headline = msg.Elements[148];
        Assert.IsInstanceOfType(headline, typeof(DDTool.Structures.DDField));

        var linesOfText = (DDTool.Structures.DDGroup)msg.Elements[33];
        Assert.AreEqual(4, linesOfText.Elements.Count);
        Assert.AreEqual(33, linesOfText.CounterField.Tag);
        Assert.AreEqual(58, linesOfText.Delimiter.Tag);
        CollectionAssert.AreEqual(new int[] { 58, 999, 354, 355 }, linesOfText.TagOrder.ToArray());
        CollectionAssert.AreEqual(new int[] { 58, 999 }, linesOfText.RequiredTags.OrderBy(x => x).ToArray());

        var noDoots = (DDTool.Structures.DDGroup)msg.Elements[500];
        Assert.AreEqual(1, noDoots.Elements.Count);
        Assert.AreEqual(500, noDoots.CounterField.Tag);
        Assert.AreEqual(501, noDoots.Delimiter.Tag);
        Assert.AreEqual(1, noDoots.TagOrder.Count);
        Assert.AreEqual(1, noDoots.RequiredTags.Count);
    }

    [TestMethod]
    public void NestedGroup() {
        var xml = new StringBuilder();
        xml.AppendLine("<fix><messages>");
        xml.AppendLine("  <message name='News' msgtype='B' msgcat='app'>");
        xml.AppendLine("    <field name='Headline' required='Y' />");
        xml.AppendLine("    <group name='LinesOfText' required='Y'>");
        xml.AppendLine("      <field name='Text' required='Y' />");
        xml.AppendLine("      <group name='FooNest' required='N'>");
        xml.AppendLine("        <field name='FooDelim' required='Y' />");
        xml.AppendLine("        <field name='FooField' required='Y' />");
        xml.AppendLine("      </group>");
        xml.AppendLine("      <group name='BarNest' required='Y'>");
        xml.AppendLine("        <field name='BarDelim' required='Y' />");
        xml.AppendLine("        <field name='BarField' required='N' />");
        xml.AppendLine("      </group>");
        xml.AppendLine("    </group>");
        xml.AppendLine("  </message>");
        xml.AppendLine("  <fields>");
        xml.AppendLine("    <field number='33' name='LinesOfText' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='58' name='Text' type='STRING' />");
        xml.AppendLine("    <field number='148' name='Headline' type='STRING' />");
        xml.AppendLine("    <field number='200' name='FooNest' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='201' name='FooDelim' type='STRING' />");
        xml.AppendLine("    <field number='202' name='FooField' type='STRING' />");
        xml.AppendLine("    <field number='300' name='BarNest' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='301' name='BarDelim' type='STRING' />");
        xml.AppendLine("    <field number='302' name='BarField' type='STRING' />");
        xml.AppendLine("  </fields>");
        xml.AppendLine("</messages></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Messages);
        Assert.AreEqual(1, dd.Messages.Count);

        var linesOfText = (DDTool.Structures.DDGroup)dd.Messages["B"].Elements[33];
        Assert.AreEqual(3, linesOfText.Elements.Count);
        CollectionAssert.AreEqual(new int[] { 58, 200, 300 }, linesOfText.TagOrder.ToArray());
        CollectionAssert.AreEqual(new int[] { 58, 300 }, linesOfText.RequiredTags.OrderBy(x => x).ToArray());

        var fooNest = (DDTool.Structures.DDGroup)linesOfText.Elements[200];
        Assert.AreEqual(200, fooNest.CounterField.Tag);
        Assert.AreEqual(201, fooNest.Delimiter.Tag);
        CollectionAssert.AreEqual(new int[] { 201, 202 }, fooNest.TagOrder.ToArray());
        CollectionAssert.AreEqual(new int[] { 201, 202 }, fooNest.RequiredTags.OrderBy(x => x).ToArray());

        var barNest = (DDTool.Structures.DDGroup)linesOfText.Elements[300];
        Assert.AreEqual(300, barNest.CounterField.Tag);
        Assert.AreEqual(301, barNest.Delimiter.Tag);
        CollectionAssert.AreEqual(new int[] { 301, 302 }, barNest.TagOrder.ToArray());
        CollectionAssert.AreEqual(new int[] { 301 }, barNest.RequiredTags.OrderBy(x => x).ToArray());
        Assert.AreEqual(1, barNest.RequiredTags.Count);
    }

    [TestMethod]
    public void DelimiterIsNestedGroup() {
        var xml = new StringBuilder();
        xml.AppendLine("<fix><messages>");
        xml.AppendLine("  <message name='News' msgtype='B' msgcat='app'>");
        xml.AppendLine("    <field name='Headline' required='Y' />");
        xml.AppendLine("    <group name='Group11' required='Y'>");
        xml.AppendLine("      <group name='Group12' required='N'>");
        xml.AppendLine("        <group name='Group13' required='N'>");
        xml.AppendLine("          <field name='Delim100' required='Y' />");
        xml.AppendLine("          <field name='Field101' required='Y' />");
        xml.AppendLine("        </group>");
        xml.AppendLine("      </group>");
        xml.AppendLine("    </group>");
        xml.AppendLine("  </message>");
        xml.AppendLine("  <fields>");
        xml.AppendLine("    <field number='148' name='Headline' type='STRING' />");
        xml.AppendLine("    <field number='11' name='Group11' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='12' name='Group12' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='13' name='Group13' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='100' name='Delim100' type='STRING' />");
        xml.AppendLine("    <field number='101' name='Field101' type='STRING' />");
        xml.AppendLine("  </fields>");
        xml.AppendLine("</messages></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Messages);

        var group11 = (DDTool.Structures.DDGroup)dd.Messages["B"].Elements[11];
        Assert.AreEqual(1, group11.Elements.Count);
        Assert.AreEqual(12, group11.Delimiter.Tag);

        var group12 = (DDTool.Structures.DDGroup)group11.Delimiter;
        Assert.AreEqual(1, group12.Elements.Count);
        Assert.AreEqual(13, group12.Delimiter.Tag);

        var group13 = (DDTool.Structures.DDGroup)group12.Delimiter;
        Assert.AreEqual(2, group13.Elements.Count);
        Assert.AreEqual(100, group13.Delimiter.Tag);
    }

    [TestMethod]
    public void FlatComponents() {
        // required=Y is ignored on component fields if component is not required in message

        var xml = new StringBuilder();
        xml.AppendLine("<fix><messages>");
        xml.AppendLine("  <message name='News' msgtype='B' msgcat='app'>");
        xml.AppendLine("    <component name='XComponent'/>");
        xml.AppendLine("    <component name='YComponent'/>");
        xml.AppendLine("  </message>");
        xml.AppendLine("  <components>");
        xml.AppendLine("    <component name='XComponent'>");
        xml.AppendLine("      <field name='Field66' required='Y' />");
        xml.AppendLine("      <field name='Field67' required='N' />");
        xml.AppendLine("    </component>");
        xml.AppendLine("    <component name='YComponent'>");
        xml.AppendLine("      <field name='Field77' required='N' />");
        xml.AppendLine("      <field name='Field78' required='Y' />");
        xml.AppendLine("    </component>");
        xml.AppendLine("  </components>");
        xml.AppendLine("  <fields>");
        xml.AppendLine("    <field number='66' name='Field66' type='STRING' />");
        xml.AppendLine("    <field number='67' name='Field67' type='STRING' />");
        xml.AppendLine("    <field number='77' name='Field77' type='STRING' />");
        xml.AppendLine("    <field number='78' name='Field78' type='STRING' />");
        xml.AppendLine("  </fields>");
        xml.AppendLine("</messages></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Messages);
        var msg = dd.Messages["B"];
        Assert.AreEqual(4, msg.Elements.Count);
        CollectionAssert.AreEqual(new int[] { 66, 67, 77, 78 }, msg.TagOrder.ToArray());
        Assert.AreEqual(0, msg.RequiredTags.Count);
    }

    [TestMethod]
    public void FlatRequiredComponents() {
        var xml = new StringBuilder();
        xml.AppendLine("<fix><messages>");
        xml.AppendLine("  <message name='News' msgtype='B' msgcat='app'>");
        xml.AppendLine("    <component name='XComponent' required='Y'/>");
        xml.AppendLine("    <component name='YComponent' required='Y'/>");
        xml.AppendLine("  </message>");
        xml.AppendLine("  <components>");
        xml.AppendLine("    <component name='XComponent'>");
        xml.AppendLine("      <field name='Field66' required='Y' />");
        xml.AppendLine("      <field name='Field67' required='N' />");
        xml.AppendLine("    </component>");
        xml.AppendLine("    <component name='YComponent'>");
        xml.AppendLine("      <field name='Field77' required='N' />");
        xml.AppendLine("      <field name='Field78' required='Y' />");
        xml.AppendLine("    </component>");
        xml.AppendLine("  </components>");
        xml.AppendLine("  <fields>");
        xml.AppendLine("    <field number='66' name='Field66' type='STRING' />");
        xml.AppendLine("    <field number='67' name='Field67' type='STRING' />");
        xml.AppendLine("    <field number='77' name='Field77' type='STRING' />");
        xml.AppendLine("    <field number='78' name='Field78' type='STRING' />");
        xml.AppendLine("  </fields>");
        xml.AppendLine("</messages></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Messages);
        var msg = dd.Messages["B"];
        Assert.AreEqual(4, msg.Elements.Count);
        CollectionAssert.AreEqual(new int[] { 66, 67, 77, 78 }, msg.TagOrder.ToArray());
        CollectionAssert.AreEqual(new int[] { 66, 78 }, msg.RequiredTags.OrderBy(x => x).ToArray());
    }

    [TestMethod]
    public void ComponentIsGroup() {
        var xml = new StringBuilder();
        xml.AppendLine("<fix><messages>");
        xml.AppendLine("  <message name='News' msgtype='B' msgcat='app'>");
        xml.AppendLine("    <field name='Headline' required='Y' />");
        xml.AppendLine("    <component name='Doots' />");
        xml.AppendLine("  </message>");
        xml.AppendLine("  <components>");
        xml.AppendLine("    <component name='Doots'>");
        xml.AppendLine("      <group name='NoDoots' required='N'>");
        xml.AppendLine("        <field name='Field66' required='Y' />");
        xml.AppendLine("        <field name='Field67' required='N' />");
        xml.AppendLine("      </group>");
        xml.AppendLine("    </component>");
        xml.AppendLine("  </components>");
        xml.AppendLine("  <fields>");
        xml.AppendLine("    <field number='148' name='Headline' type='STRING' />");
        xml.AppendLine("    <field number='900' name='NoDoots' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='66' name='Field66' type='STRING' />");
        xml.AppendLine("    <field number='67' name='Field67' type='STRING' />");
        xml.AppendLine("  </fields>");
        xml.AppendLine("</messages></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Messages);
        var msg = dd.Messages["B"];
        Assert.AreEqual(2, msg.Elements.Count);
        CollectionAssert.AreEqual(new int[] { 148, 900 }, msg.TagOrder.ToArray());
        CollectionAssert.AreEqual(new int[] { 148 }, msg.RequiredTags.OrderBy(x => x).ToArray());

        var group = (DDTool.Structures.DDGroup)msg.Elements[900];
        Assert.AreEqual(2, group.Elements.Count);
        CollectionAssert.AreEqual(new int[] { 66, 67 }, group.TagOrder.ToArray());
    }

    [TestMethod]
    public void ComponentContentIsGroup() {
        var xml = new StringBuilder();
        xml.AppendLine("<fix><messages>");
        xml.AppendLine("  <message name='News' msgtype='B' msgcat='app'>");
        xml.AppendLine("    <field name='Headline' required='Y' />");
        xml.AppendLine("    <group name='NoDoots' required='N' >");
        xml.AppendLine("      <component name='Doot' />");
        xml.AppendLine("    </group>");
        xml.AppendLine("  </message>");
        xml.AppendLine("  <components>");
        xml.AppendLine("    <component name='Doot'>");
        xml.AppendLine("      <field name='Field66' required='N' />");
        xml.AppendLine("      <field name='Field67' required='Y' />");
        xml.AppendLine("    </component>");
        xml.AppendLine("  </components>");
        xml.AppendLine("  <fields>");
        xml.AppendLine("    <field number='148' name='Headline' type='STRING' />");
        xml.AppendLine("    <field number='900' name='NoDoots' type='NUMINGROUP' />");
        xml.AppendLine("    <field number='66' name='Field66' type='STRING' />");
        xml.AppendLine("    <field number='67' name='Field67' type='STRING' />");
        xml.AppendLine("  </fields>");
        xml.AppendLine("</messages></fix>");

        var dd = ParserTestUtil.ReadDD(xml.ToString(), ParserTask.Messages);
        var msg = dd.Messages["B"];
        Assert.AreEqual(2, msg.Elements.Count);
        CollectionAssert.AreEqual(new int[] { 148, 900 }, msg.TagOrder.ToArray());
        CollectionAssert.AreEqual(new int[] { 148 }, msg.RequiredTags.OrderBy(x => x).ToArray());

        var group = (DDTool.Structures.DDGroup)msg.Elements[900];
        Assert.AreEqual(2, group.Elements.Count);
        CollectionAssert.AreEqual(new int[] { 66, 67 }, group.TagOrder.ToArray());
    }
}
