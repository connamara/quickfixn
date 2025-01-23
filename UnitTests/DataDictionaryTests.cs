using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NUnit.Framework;
using QuickFix;
using QuickFix.DataDictionary;
using UnitTests.TestHelpers;

namespace UnitTests
{
    [TestFixture]
    public class DataDictionaryTests
    {
        private readonly IMessageFactory _defaultMsgFactory = new DefaultMessageFactory();

        [Test]
        public void VersionTest()
        {
            DataDictionary dd44 = new DataDictionary();
            dd44.LoadFIXSpec("FIX44");
            Assert.That(dd44.MajorVersion, Is.EqualTo("4"));
            Assert.That(dd44.MinorVersion, Is.EqualTo("4"));
            Assert.That(dd44.Version, Is.EqualTo("FIX.4.4"));
        }

        [Test]
        public void LoadFieldsTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.FieldsByTag[1].Name, Is.EqualTo("Account"));
            Assert.That(dd.FieldsByName["Account"].Tag, Is.EqualTo(1));
            Assert.That(dd.FieldsByTag[1].EnumDict.Count, Is.EqualTo(0));
            Assert.That(dd.FieldsByTag[QuickFix.Fields.Tags.StatusValue].EnumDict.Count, Is.EqualTo(4));
        }

		[Test]
		public void LoadFieldsFromStreamTest()
		{
			DataDictionary dd = new DataDictionary();
		    Stream stream = new FileStream(Path.Combine(TestContext.CurrentContext.TestDirectory, "spec", "fix", "FIX44.xml"), FileMode.Open, FileAccess.Read);
			dd.Load(stream);
			Assert.That(dd.FieldsByTag[1].Name, Is.EqualTo("Account"));
			Assert.That(dd.FieldsByName["Account"].Tag, Is.EqualTo(1));
			Assert.That(dd.FieldsByTag[1].EnumDict.Count, Is.EqualTo(0));
			Assert.That(dd.FieldsByTag[QuickFix.Fields.Tags.StatusValue].EnumDict.Count, Is.EqualTo(4));
		}

        [Test]
        public void FieldHasValueTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "1"), Is.EqualTo(true));
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "CONNECTED"), Is.EqualTo(false));
            Assert.That(dd.FieldsByTag[1].HasEnums(), Is.False);
            Assert.That(dd.FieldsByTag[945].HasEnums(), Is.True);
        }

        [Test]
        public void FieldHasDescriptionTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.FieldsByTag[945].EnumDict.GetType(), Is.EqualTo(typeof(Dictionary<string, string>)));
            Assert.That("COMPLETED", Is.EqualTo(dd.FieldsByTag[945].EnumDict["2"]));
            Assert.That(dd.FieldsByTag[35].EnumDict["A"], Is.Not.EqualTo("HEARTBEAT"));
        }

        [Test]
        public void BasicMessageTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.Messages["3"].Fields.Count, Is.EqualTo(7));
        }

        [Test]
        public void ComponentSmokeTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            DDMap tcr = dd.Messages["AE"];
            Assert.That(tcr.Fields.ContainsKey(55), Is.True);
            Assert.That(tcr.Fields.ContainsKey(5995), Is.False);
        }

        [Test]
        public void GroupTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            DDMap tcrr = dd.Messages["AD"];
            Assert.That(tcrr.IsGroup(711), Is.True);
            Assert.That(tcrr.IsField(711), Is.True);  // No Field also a field
            Assert.That(tcrr.GetGroup(711).IsField(311), Is.True);
            Assert.That(tcrr.Groups[711].Fields[311].Name, Is.EqualTo("UnderlyingSymbol"));
            Assert.That(tcrr.Groups[711].Delim, Is.EqualTo(311));
            DDMap tcr = dd.Messages["AE"];
            Assert.That(tcr.Groups[711].Groups[457].Fields[458].Name, Is.EqualTo("UnderlyingSecurityAltID"));
        }

        [Test]
        public void NestedGroupTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            DDMap msgJ = dd.Messages["J"];

            Assert.That(msgJ.IsGroup(73), Is.True);
            Assert.That(msgJ.IsGroup(756), Is.False);
            Assert.That(msgJ.GetGroup(73).IsGroup(756), Is.True);
        }

        [Test]
        public void GroupBeginsGroupTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadTestFIXSpec("group_begins_group");
            DDMap msg = dd.Messages["magic"];
            Assert.That(msg.IsGroup(6660), Is.True); // NoMagics group
            Assert.That(msg.GetGroup(6660).IsGroup(7770), Is.True); // NoMagics/NoRabbits
            Assert.That(msg.GetGroup(6660).IsField(6661), Is.True); // NoMagics/MagicWord
            Assert.That(msg.GetGroup(6660).GetGroup(7770).IsField(7711), Is.True); // NoMagics/NoRabbits/RabbitName
            Assert.That(msg.GetGroup(6660).Delim, Is.EqualTo(7770)); // NoMagics delim is NoRabbits counter
            Assert.That(msg.GetGroup(6660).GetGroup(7770).Delim, Is.EqualTo(7711)); // NoRabbits delim is RabbitName
        }

        [Test]
        public void HeaderGroupTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            DDMap headerMap = dd.Header;
            Assert.That(headerMap.IsGroup(627), Is.True);
            DDGrp grpMap = headerMap.GetGroup(627);
            Assert.That(dd.Header.GetGroup(627).IsField(628), Is.True);
            Assert.That(grpMap.IsField(628), Is.True);
        }

        [Test]
        public void ReqFldTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.Messages["AE"].ReqFields.Contains(571), Is.True);
            Assert.That(dd.Messages["AE"].ReqFields.Contains(828), Is.False);
        }

        [Test]
        public void HeaderTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.Header.ReqFields.Contains(9), Is.True);
            Assert.That(dd.Header.Fields.Count, Is.EqualTo(27));
        }

        [Test]
        public void TrailerTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.Trailer.ReqFields.Contains(10), Is.True);
            Assert.That(dd.Trailer.Fields.Count, Is.EqualTo(3));
        }

        [Test]
        public void CheckValidFormat()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            dd.CheckFieldsHaveValues = true;

            var goodFields = new QuickFix.Fields.StringField[] {
                new(QuickFix.Fields.Tags.Symbol, "foo"), // string
                new(QuickFix.Fields.Tags.Side, "2"), // char
                new(QuickFix.Fields.Tags.LastQty, "123"), // int
                new(QuickFix.Fields.Tags.AvgPx, "1.23"), // decimal
                new(QuickFix.Fields.Tags.ReportToExch, "Y"), // bool
                new(QuickFix.Fields.Tags.ContraTradeTime, "20011217-09:30:47.123"), // datetime
                new(QuickFix.Fields.Tags.MDEntryDate, "20030910"), // dateonly
                new(QuickFix.Fields.Tags.MDEntryTime, "13:20:00.123"), // timeonly
                new(QuickFix.Fields.Tags.Symbol, "") // string
            };

            foreach (var datum in goodFields)
            {
                Assert.DoesNotThrow(delegate { dd.CheckValidFormat(datum); });
            }

            var badFields = new QuickFix.Fields.StringField[]
            {
                new(QuickFix.Fields.Tags.Side, "toolong"), // char
                new(QuickFix.Fields.Tags.LastQty, "notint"), // int
                new(QuickFix.Fields.Tags.AvgPx, "notdec"), // decimal
                new(QuickFix.Fields.Tags.ReportToExch, "notbool"), // bool
                new(QuickFix.Fields.Tags.ContraTradeTime, "notdatetime"), // datetime
                new(QuickFix.Fields.Tags.MDEntryDate, "notdate"), // dateonly
                new(QuickFix.Fields.Tags.MDEntryTime, "nottime") // timeonly
            };

            foreach (var datum in badFields)
            {
                Assert.Throws(typeof(IncorrectDataFormat), delegate { dd.CheckValidFormat(datum); });
            }

            var emptyFields = new QuickFix.Fields.StringField[]
            {
                new(QuickFix.Fields.Tags.Side, ""), // char
                new(QuickFix.Fields.Tags.LastQty, ""), // int
                new(QuickFix.Fields.Tags.AvgPx, ""), // decimal
                new(QuickFix.Fields.Tags.ReportToExch, ""), // bool
                new(QuickFix.Fields.Tags.ContraTradeTime, ""), // datetime
                new(QuickFix.Fields.Tags.MDEntryDate, ""), // dateonly
                new(QuickFix.Fields.Tags.MDEntryTime, "") // timeonly
            };

            foreach (var datum in emptyFields)
            {
                Assert.Throws(typeof(IncorrectDataFormat), delegate { dd.CheckValidFormat(datum); });
            }

            // Setting change!
            dd.CheckFieldsHaveValues = false;
            foreach (var datum in emptyFields)
            {
                Assert.DoesNotThrow(delegate { dd.CheckValidFormat(datum); });
            }
        }

        [Test]
        public void CheckValidTagNumberTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");

            Assert.DoesNotThrow(delegate { dd.CheckValidTagNumber(35); });

            Assert.Throws(typeof(InvalidTagNumber),
                delegate { dd.CheckValidTagNumber(999); });

            dd.AllowUnknownMessageFields = true;
            Assert.DoesNotThrow(delegate { dd.CheckValidTagNumber(999); });
        }

        [Test]
        public void CheckValue()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");

            // unknown field
            Assert.DoesNotThrow(delegate { dd.CheckValue(new QuickFix.Fields.CharField(20, '0')); });
            // not an enum
            Assert.DoesNotThrow(delegate { dd.CheckValue(new QuickFix.Fields.ListSeqNo(5)); });
            // regular enum, ok
            Assert.DoesNotThrow(delegate { dd.CheckValue(new QuickFix.Fields.TickDirection('2')); });
            // multiple-value field, ok
            Assert.DoesNotThrow(delegate { dd.CheckValue(new QuickFix.Fields.QuoteCondition("A C D")); });

            // regular enum, invalid value
            Assert.Throws(typeof(IncorrectTagValue),
                delegate { dd.CheckValue(new QuickFix.Fields.TickDirection('9')); });
            // multiple-value field, one value is invalid
            Assert.Throws(typeof(IncorrectTagValue),
               delegate { dd.CheckValue(new QuickFix.Fields.QuoteCondition("A @ D")); });

            // Disable some checks
            dd.AllowUnknownEnumValues = true;
            // regular enum, invalid value
            Assert.DoesNotThrow(delegate { dd.CheckValue(new QuickFix.Fields.TickDirection('9')); });
            // multiple-value field, one value is invalid
            Assert.DoesNotThrow(delegate { dd.CheckValue(new QuickFix.Fields.QuoteCondition("A @ D")); });
        }

        [Test]
        public void CheckIsInMessageTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");

            Assert.DoesNotThrow(delegate { dd.CheckIsInMessage(new QuickFix.Fields.MDReqID("foo"), "W"); });

            Assert.Throws(typeof(TagNotDefinedForMessage),
                delegate { dd.CheckIsInMessage(new QuickFix.Fields.EmailThreadID("foo"), "W"); });

            dd.AllowUnknownMessageFields = true;
            Assert.DoesNotThrow(delegate { dd.CheckIsInMessage(new QuickFix.Fields.EmailThreadID("foo"), "W"); });
        }

        [Test]
        public void CheckIsInGroupTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");
            DDGrp g = dd.Messages["B"].GetGroup(33);

            QuickFix.Fields.Text textField = new QuickFix.Fields.Text("woot");
            QuickFix.Fields.ClOrdID clOrdIdField = new QuickFix.Fields.ClOrdID("not woot");

            Assert.DoesNotThrow(delegate { DataDictionary.CheckIsInGroup(textField, g, "B"); });
            Assert.Throws(typeof(TagNotDefinedForMessage), delegate { DataDictionary.CheckIsInGroup(clOrdIdField, g, "B"); });
        }

        [Test]
        public void CheckGroupCountTest()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX42");

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string s = ("8=FIX.4.2|9=148|35=D|34=2|49=TW|52=20111011-15:06:23.103|56=ISLD|"
                        + "11=ID|21=1|40=1|54=1|38=200.00|55=INTC|"
                        + "386=3|336=PRE-OPEN|336=AFTER-HOURS|"
                        + "60=20111011-15:06:23.103|"
                        + "10=35|").Replace('|', Message.SOH);

            n.FromString(s, true, dd, dd, _defaultMsgFactory);

            //verify that FromString didn't correct the counter
            //HEY YOU, READ THIS NOW: if these fail, first check if MessageTests::FromString_DoNotCorrectCounter() passes
            Assert.That(n.NoTradingSessions.ToStringField(), Is.EqualTo("386=3"));
            Assert.That(n.ConstructString(), Does.Contain("386=3"));

            Assert.Throws<RepeatingGroupCountMismatch>(delegate { dd.CheckGroupCount(n.NoTradingSessions, n, "D"); });
        }


        [Test]
        public void DuplicateEnumsDoesNotThrow()
        {
            // If this test throws, it failed.
            DataDictionary dd = new DataDictionary();
            dd.LoadTestFIXSpec("FIX43_dup_enum");
        }

        [Test]
        public void ComponentFieldsRequirements()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadFIXSpec("FIX44");

            // AD => Instrument component (optional) => 55 (Symbol)
            Assert.That(dd.Messages["AD"].ReqFields.Contains(55), Is.False);
            // 7 => Instrument component (required) => 55 (Symbol)
            Assert.That(dd.Messages["7"].ReqFields.Contains(55), Is.True);
        }

        [Test]
        public void Issue134_RequiredIsOptional()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadTestFIXSpec("required_is_optional");
            Assert.That(dd.Messages["magic"].ReqFields.Contains(1111), Is.True);  //base required field
            Assert.That(dd.Messages["magic"].ReqFields.Contains(5555), Is.False); //base optional field
            Assert.That(dd.Messages["magic"].ReqFields.Contains(5556), Is.False); //component optional field

            Assert.That(dd.Messages["magic"].Groups[6660].Required, Is.False); // group isn't required
            Assert.That(dd.Messages["magic"].Groups[6660].ReqFields.Contains(6662), Is.False); // group optional field
        }

        [Test] // Issue #493
        public void ParseThroughComments()
        {
            DataDictionary dd = new DataDictionary();
            dd.LoadTestFIXSpec("comments");

            // The fact that it doesn't throw is sufficient, but we'll do some other checks anyway.

            DDMap logon = dd.GetMapForMessage("A")!;
            Assert.That(logon.IsField(108), Is.True); // HeartBtInt
            Assert.That(logon.IsField(9000), Is.True); // CustomField

            DDMap news = dd.GetMapForMessage("B")!;
            Assert.That(news.IsField(148), Is.True); // Headline
            Assert.That(news.IsGroup(33), Is.True); // LinesOfText
            Assert.That(news.GetGroup(33).IsField(355), Is.True); // EncodedText
        }

        [Test]
        public void TestCheckMsgType() {
            DataDictionary dd = new DataDictionary();
            dd.LoadTestFIXSpec("msg_type_test");

            Assert.Throws(typeof(InvalidMessageType), delegate { dd.CheckMsgType("foo"); });

            // True check, case 1: DD has a <message> definition for this one
            Assert.DoesNotThrow(delegate { dd.CheckMsgType("B"); });

            // True check, case 2: Type is in field 35, but there is no Message type
            Assert.That(dd.Messages, Does.Not.ContainKey("bar")); // Sanity check; if fails, fix the test.
            Assert.DoesNotThrow(delegate { dd.CheckMsgType("bar"); });
        }

        private static XmlNode MakeNode(string xmlString)
        {
            XmlDocument doc = new XmlDocument();
            if (xmlString.StartsWith('<'))
            {
                doc.LoadXml(xmlString);
                return doc.DocumentElement!;
            }
            return doc.CreateTextNode(xmlString);
        }

        [Test]
        public void VerifyChildNodeAndReturnNameAtt() {
            XmlNode parentNode = MakeNode("<parentnode name='Daddy'/>");

            Assert.That(DataDictionary.VerifyChildNodeAndReturnNameAtt(MakeNode("<sometag name='qty'/>"), parentNode),
                Is.EqualTo("qty"));

            DictionaryParseException dpx = Assert.Throws<DictionaryParseException>(
                delegate { DataDictionary.VerifyChildNodeAndReturnNameAtt(MakeNode("foo"), parentNode); })!;
            Assert.That(dpx.Message, Is.EqualTo("Malformed data dictionary: Found text-only node containing 'foo'"));

            dpx = Assert.Throws<DictionaryParseException>(
                delegate { DataDictionary.VerifyChildNodeAndReturnNameAtt(MakeNode("<field>qty</field>"), parentNode); })!;
            Assert.That(dpx.Message, Is.EqualTo("Malformed data dictionary: Found 'field' node without 'name' within parent 'parentnode/Daddy'"));

            // alt error message, where parent has no name
            parentNode = MakeNode("<parentnode/>");
            dpx = Assert.Throws<DictionaryParseException>(
                delegate { DataDictionary.VerifyChildNodeAndReturnNameAtt(MakeNode("<field>qty</field>"), parentNode); })!;
            Assert.That(dpx.Message, Is.EqualTo("Malformed data dictionary: Found 'field' node without 'name' within parent 'parentnode/parentnode'"));
        }
    }
}
