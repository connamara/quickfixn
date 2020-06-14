using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NUnit.Framework;
using QuickFix;
using UnitTests.TestHelpers;

namespace UnitTests
{
    [TestFixture]
    public class DataDictionaryTests
    {
        private QuickFix.IMessageFactory _defaultMsgFactory = new QuickFix.DefaultMessageFactory();

        [Test]
        public void VersionTest()
        {
            QuickFix.DataDictionary.DataDictionary dd44 = new QuickFix.DataDictionary.DataDictionary();
            dd44.LoadFIXSpec("FIX44");
            Assert.That(dd44.MajorVersion, Is.EqualTo("4"));
            Assert.That(dd44.MinorVersion, Is.EqualTo("4"));
            Assert.That(dd44.Version, Is.EqualTo("FIX.4.4"));
        }

        [Test]
        public void LoadFieldsTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.FieldsByTag[1].Name, Is.EqualTo("Account"));
            Assert.That(dd.FieldsByName["Account"].Tag, Is.EqualTo(1));
            Assert.That(dd.FieldsByTag[1].EnumDict.Count, Is.EqualTo(0));
            Assert.That(dd.FieldsByTag[QuickFix.Fields.Tags.StatusValue].EnumDict.Count, Is.EqualTo(4));
        }

		[Test]
		public void LoadFieldsFromStreamTest()
		{
			QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
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
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "1"), Is.EqualTo(true));
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "CONNECTED"), Is.EqualTo(false));
            Assert.False(dd.FieldsByTag[1].HasEnums());
            Assert.True(dd.FieldsByTag[945].HasEnums());
        }

        [Test]
        public void FieldHasDescriptionTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.AreEqual(typeof (Dictionary<string, string>), dd.FieldsByTag[945].EnumDict.GetType());
            Assert.That("COMPLETED", Is.EqualTo(dd.FieldsByTag[945].EnumDict["2"]));
            Assert.AreNotEqual("HEARTBEAT", dd.FieldsByTag[35].EnumDict["A"]);
        }

        [Test]
        public void BasicMessageTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.That(dd.Messages["3"].Fields.Count, Is.EqualTo(7));
        }

        [Test]
        public void ComponentSmokeTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.DataDictionary.DDMap tcr = dd.Messages["AE"];
            Assert.True(tcr.Fields.ContainsKey(55));
            Assert.False(tcr.Fields.ContainsKey(5995));
        }

        [Test]
        public void GroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.DataDictionary.DDMap tcrr = dd.Messages["AD"];
            Assert.True(tcrr.IsGroup(711));
            Assert.True(tcrr.IsField(711));  // No Field also a field
            Assert.True(tcrr.GetGroup(711).IsField(311));
            Assert.That(tcrr.Groups[711].Fields[311].Name, Is.EqualTo("UnderlyingSymbol"));
            Assert.That(tcrr.Groups[711].Delim, Is.EqualTo(311));
            QuickFix.DataDictionary.DDMap tcr = dd.Messages["AE"];
            Assert.That(tcr.Groups[711].Groups[457].Fields[458].Name, Is.EqualTo("UnderlyingSecurityAltID"));
        }

        [Test]
        public void NestedGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.DataDictionary.DDMap msgJ = dd.Messages["J"];

            Assert.True(msgJ.IsGroup(73));
            Assert.False(msgJ.IsGroup(756));
            Assert.True(msgJ.GetGroup(73).IsGroup(756));
        }

        [Test]
        public void GroupBeginsGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadTestFIXSpec("group_begins_group");
            QuickFix.DataDictionary.DDMap msg = dd.Messages["magic"];
            Assert.True(msg.IsGroup(6660)); // NoMagics group
            Assert.True(msg.GetGroup(6660).IsGroup(7770)); // NoMagics/NoRabbits
            Assert.True(msg.GetGroup(6660).IsField(6661)); // NoMagics/MagicWord
            Assert.True(msg.GetGroup(6660).GetGroup(7770).IsField(7711)); // NoMagics/NoRabbits/RabbitName
            Assert.AreEqual(7770, msg.GetGroup(6660).Delim); // NoMagics delim is NoRabbits counter
            Assert.AreEqual(7711, msg.GetGroup(6660).GetGroup(7770).Delim); // NoRabbits delim is RabbitName
        }

        [Test]
        public void HeaderGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.DataDictionary.DDMap headerMap = dd.Header;
            Assert.True(headerMap.IsGroup(627));
            QuickFix.DataDictionary.DDGrp grpMap = headerMap.GetGroup(627);
            Assert.True(dd.Header.GetGroup(627).IsField(628));
            Assert.True(grpMap.IsField(628));
        }

        [Test]
        public void ReqFldTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.True(dd.Messages["AE"].ReqFields.Contains(571));
            Assert.False(dd.Messages["AE"].ReqFields.Contains(828));
        }

        [Test]
        public void HeaderTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.True(dd.Header.ReqFields.Contains(9));
            Assert.That(dd.Header.Fields.Count, Is.EqualTo(27));
        }

        [Test]
        public void TrailerTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.True(dd.Trailer.ReqFields.Contains(10));
            Assert.That(dd.Trailer.Fields.Count, Is.EqualTo(3));
        }

        [Test]
        public void CheckValidFormat()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            dd.CheckFieldsHaveValues = true;

            var goodFields = new QuickFix.Fields.StringField[] {
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.Symbol, "foo"), // string
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.Side, "2"), // char
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.LastQty, "123"), // int
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.AvgPx, "1.23"), // decimal
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.ReportToExch, "Y"), // bool
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.ContraTradeTime, "20011217-09:30:47.123"), // datetime
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.MDEntryDate, "20030910"), // dateonly
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.MDEntryTime, "13:20:00.123"), // timeonly

                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.Symbol, "") // string
            };

            foreach (var datum in goodFields)
            {
                Assert.DoesNotThrow(delegate { dd.CheckValidFormat(datum); });
            }

            var badFields = new QuickFix.Fields.StringField[]
            {
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.Side, "toolong"), // char
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.LastQty, "notint"), // int
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.AvgPx, "notdec"), // decimal
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.ReportToExch, "notbool"), // bool
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.ContraTradeTime, "notdatetime"), // datetime
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.MDEntryDate, "notdate"), // dateonly
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.MDEntryTime, "nottime") // timeonly
            };

            foreach (var datum in badFields)
            {
                Assert.Throws(typeof(IncorrectDataFormat), delegate { dd.CheckValidFormat(datum); });
            }

            var emptyFields = new QuickFix.Fields.StringField[]
            {
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.Side, ""), // char
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.LastQty, ""), // int
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.AvgPx, ""), // decimal
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.ReportToExch, ""), // bool
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.ContraTradeTime, ""), // datetime
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.MDEntryDate, ""), // dateonly
                new QuickFix.Fields.StringField(QuickFix.Fields.Tags.MDEntryTime, "") // timeonly
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
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");

            Assert.DoesNotThrow(delegate { dd.CheckValidTagNumber(35); });

            Assert.Throws(typeof(InvalidTagNumber),
                delegate { dd.CheckValidTagNumber(999); });

            dd.AllowUnknownMessageFields = true;
            Assert.DoesNotThrow(delegate { dd.CheckValidTagNumber(999); });
        }

        [Test]
        public void CheckIsInMessageTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
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
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.DataDictionary.DDGrp g = dd.Messages["B"].GetGroup(33);

            QuickFix.Fields.Text textField = new QuickFix.Fields.Text("woot");
            QuickFix.Fields.ClOrdID clOrdIdField = new QuickFix.Fields.ClOrdID("not woot");

            Assert.DoesNotThrow(delegate() { dd.CheckIsInGroup(textField, g, "B"); });
            Assert.Throws(typeof(TagNotDefinedForMessage), delegate { dd.CheckIsInGroup(clOrdIdField, g, "B"); });
        }

        [Test]
        public void CheckGroupCountTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX42");

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string nul = Message.SOH;
            string s = "8=FIX.4.2" + nul + "9=148" + nul + "35=D" + nul + "34=2" + nul + "49=TW" + nul + "52=20111011-15:06:23.103" + nul + "56=ISLD" + nul
                + "11=ID" + nul + "21=1" + nul + "40=1" + nul + "54=1" + nul + "38=200.00" + nul + "55=INTC" + nul
                + "386=3" + nul + "336=PRE-OPEN" + nul + "336=AFTER-HOURS" + nul
                + "60=20111011-15:06:23.103" + nul
                + "10=35" + nul;

            n.FromString(s, true, dd, dd, _defaultMsgFactory);

            //verify that FromString didn't correct the counter
            //HEY YOU, READ THIS NOW: if these fail, first check if MessageTests::FromString_DoNotCorrectCounter() passes
            Assert.AreEqual("386=3", n.NoTradingSessions.toStringField());  
            StringAssert.Contains("386=3", n.ToString());

            Assert.Throws<QuickFix.RepeatingGroupCountMismatch>(delegate { dd.CheckGroupCount(n.NoTradingSessions, n, "D"); });
        }

        [Test]
        public void ValidateWrongType()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = {"8=FIX.4.4", "9=120", "35=D", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                   "11=clordid", "55=sym", "54=1", "60=20110909-09:09:09.999", "40=1", 
                                   "38=failboat", // should be a decimal
                                   "10=64"};
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "D";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            Assert.That(() => dd.Validate(message, beginString, msgType), Throws.TypeOf<QuickFix.IncorrectDataFormat>());
        }

        [Test]
        public void ValidateWithRepeatingGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX42");
            QuickFix.FIX42.MessageFactory f = new QuickFix.FIX42.MessageFactory();
            
            string nul = Message.SOH;
            string msgStr = "8=FIX.4.2" + nul + "9=87" + nul + "35=B" + nul + "34=3" + nul + "49=CLIENT1" + nul
                + "52=20111012-22:15:55.474" + nul + "56=EXECUTOR" + nul + "148=AAAAAAA" + nul
                + "33=2" + nul + "58=L1" + nul + "58=L2" + nul + "10=016" + nul;

            QuickFix.Fields.MsgType msgType = Message.IdentifyType(msgStr);
            string beginString = Message.ExtractBeginString(msgStr);

            Message message = f.Create(beginString, msgType.Obj);
            message.FromString(msgStr, true, dd, dd, f);

            dd.Validate(message, beginString, msgType.Obj);
        }

        [Test]
        public void ValidateGroupBeginsGroup()
        {
            // TODO: In a future version, change this so that
            //       1) generator will generate source for our test DD
            //       2) this test will use proper type-safe methods and not generics
            // Probably some or all of this would then move to MessageTests.cs

            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadTestFIXSpec("group_begins_group");

            string pipedStr = "8=FIX.9.9|9=167|35=magic|34=3|49=CLIENT1|52=20111012-22:15:55.474|56=EXECUTOR|"
                + "1111=mundane|5555=magicfield|6660=1|7770=2|7711=Hoppy|7712=brown|"
                + "7711=Floppy|7712=white|6661=abracadabra|10=48|";
            // note: length and checksum might be garbage
            string msgStr = pipedStr.Replace("|", Message.SOH);

            string beginString = Message.ExtractBeginString(msgStr);
            Message msg = new Message(msgStr, dd, false);

            // true param means body-only, i.e. don't validate length/checksum
            dd.Validate(msg, true, beginString, "magic");

            // Verify can retrieve one of the inner groups.
            // (Gotta use generic methods because code isn't generated for this DD)
            Group magicGroup = new Group(6660, 7770, new[] { 7770, 6661 });
            msg.GetGroup(1, magicGroup);
            Group rabbitGroup = new Group(7770, 7711, new[] { 7711, 7722 });
            magicGroup.GetGroup(2, rabbitGroup);

            Assert.AreEqual("abracadabra", magicGroup.GetString(6661));
            Assert.AreEqual("Floppy", rabbitGroup.GetString(7711));
            Assert.AreEqual("white", rabbitGroup.GetString(7712));
        }

        [Test]
        public void ValidateWrongTypeInRepeatingGroup()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = {"8=FIX.4.4", "9=111", "35=V", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                      "262=mdreqid", "263=0", "264=5",
                                      "267=1", // MDReqGrp
                                        "269=failboat", // should be a char
                                      "146=1", // InstrmtMDReqGrp
                                        "55=sym",
                                      "10=91"};
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "V";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            Assert.That(() => dd.Validate(message, beginString, msgType), Throws.TypeOf<QuickFix.IncorrectDataFormat>());
        }

        [Test]
        public void ValidateWrongTypeInNestedRepeatingGroup()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = {"8=FIX.4.4", "9=185", "35=J", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "70=AllocID", "71=0", "626=1", "857=0", "54=1", "55=sym", "53=1", "6=5.5", "75=20110909-09:09:09.999",
                                     "73=1", // NoOrders
                                       "11=clordid",
                                       "756=1", // NoNested2PartyIDs
                                         "757=nested2partyid",
                                         "759=failboat", // supposed to be a int
                                     "10=48"};
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "J";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            Assert.That(() => dd.Validate(message, beginString, msgType), Throws.TypeOf<QuickFix.IncorrectDataFormat>());
        }

        [Test]
        public void ValidateDateAndTimeFields()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = { "8=FIX.4.4", "9=104", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012", "273=22:15:30.444", "10=19" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            try
            {
                dd.Validate(message, beginString, msgType);
            }
            catch (QuickFix.TagException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Field);
                throw;
            }
        }

        [Test]
        public void ValidateDateTime_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            // intentionally invalid SendingTime (52/DateTime)
            string[] msgFields = { "8=FIX.4.4", "9=91", "35=W", "34=3", "49=sender", "52=20110909", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012", "273=22:15:30.444", "10=51" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            Assert.That(() => dd.Validate(message, beginString, msgType), Throws.TypeOf<QuickFix.IncorrectDataFormat>());
        }

        [Test]
        public void ValidateDateOnly_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            // intentionally invalid MDEntryDate (272/DateOnly)
            string[] msgFields = { "8=FIX.4.4", "9=117", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012-22:15:30.444", "273=22:15:30.444", "10=175" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            Assert.That(() => dd.Validate(message, beginString, msgType), Throws.TypeOf<QuickFix.IncorrectDataFormat>());
        }

        [Test]
        public void ValidateTimeOnly_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            // intentionally invalid MDEntryTime (272/TimeOnly)
            string[] msgFields = { "8=FIX.4.4", "9=113", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012", "273=20111012-22:15:30.444", "10=200" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            Assert.That(() => dd.Validate(message, beginString, msgType), Throws.TypeOf<QuickFix.IncorrectDataFormat>());
        }

        [Test]
        public void DuplicateEnumsDoesNotThrow()
        {
            // If this test throws, it failed.
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadTestFIXSpec("FIX43_dup_enum");
        }

        [Test]
        public void OptionalComponentRequiredField()
        {
            // issue #98 - message erroneously rejected because DD says that
            //   component-required field is missing even though component is not present

            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = { "8=FIX.4.4", "9=77", "35=AD", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "568=tradereqid", "569=0", "10=109" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "AD";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            dd.Validate(message, beginString, msgType);
        }

        [Test]
        public void RequiredComponentRequiredField()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = { "8=FIX.4.4", "9=76", "35=7", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "2=AdvId", "5=N", "4=B", "53=1", "10=138" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "7";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            var ex = Assert.Throws<QuickFix.RequiredTagMissing>(delegate { dd.Validate(message, beginString, msgType); });
            Assert.AreEqual(55, ex.Field);
        }

        [Test]
        public void ComponentFieldsRequirements()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            Assert.False(dd.Messages["AD"].ReqFields.Contains(55));
            Assert.True(dd.Messages["7"].ReqFields.Contains(55));
        }

        [Test]
        public void Issue134_RequiredIsOptional()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadTestFIXSpec("required_is_optional");
            Assert.True(dd.Messages["magic"].ReqFields.Contains(1111));  //base required field
            Assert.False(dd.Messages["magic"].ReqFields.Contains(5555)); //base optional field
            Assert.False(dd.Messages["magic"].ReqFields.Contains(5556)); //component optional field

            Assert.False(dd.Messages["magic"].Groups[6660].Required); // group isn't required
            Assert.False(dd.Messages["magic"].Groups[6660].ReqFields.Contains(6662)); // group optional field
        }

        [Test] // Issue #66
        public void ValidateMultipleValueStringType()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = {"8=FIX.4.4", "9=99", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                   "55=sym",
                                   "268=1", "269=0", "270=123.23", "271=2", "277=A B", 
                                   "10=213"};
            string msgStr = String.Join( Message.SOH, msgFields ) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create( beginString, msgType );
            message.FromString( msgStr, true, dd, dd );

            dd.Validate( message, beginString, msgType );
        }

        [Test] // Issue #66
        public void ValidateMultipleValueStringType_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = {"8=FIX.4.4", "9=99", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                   "55=sym",
                                   "268=1", "269=0", "270=123.23", "271=2", "277=A 1", 
                                   "10=196"};
            string msgStr = String.Join( Message.SOH, msgFields ) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create( beginString, msgType );
            message.FromString( msgStr, true, dd, dd );

            Assert.That(() => dd.Validate(message, beginString, msgType), Throws.TypeOf<QuickFix.IncorrectTagValue>());
        }

        [Test] // Issue #282
        public void ValidateTagSpecifiedWithoutAValue()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX42");
            QuickFix.FIX42.MessageFactory f = new QuickFix.FIX42.MessageFactory();

            string[] msgFields = {"8=FIX.4.2", "9=70", "35=B", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                   "358=", "148=", "33=0", "10=150"};
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "B";
            string beginString = "FIX.4.2";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd);

            dd.CheckFieldsHaveValues = true;
            Assert.Throws<QuickFix.NoTagValue>(delegate { dd.Validate(message, beginString, msgType); });

            dd.CheckFieldsHaveValues = false;
            Assert.DoesNotThrow(delegate { dd.Validate(message, beginString, msgType); });
        }

        [Test] // Issue #493
        public void ParseThroughComments()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadTestFIXSpec("comments");

            // The fact that it doesn't throw is sufficient, but we'll do some other checks anyway.

            var logon = dd.GetMapForMessage("A");
            Assert.True(logon.IsField(108)); // HeartBtInt
            Assert.True(logon.IsField(9000)); // CustomField

            var news = dd.GetMapForMessage("B");
            Assert.True(news.IsField(148)); // Headline
            Assert.True(news.IsGroup(33)); // LinesOfText
            Assert.True(news.GetGroup(33).IsField(355)); // EncodedText
        }


        XmlNode MakeNode(string xmlString)
        {
            XmlDocument doc = new XmlDocument();
            if (xmlString.StartsWith("<"))
            {
                doc.LoadXml(xmlString);
                return doc.DocumentElement;
            }
            else
            {
                return doc.CreateTextNode(xmlString);
            }
        }

        [Test]
        public void VerifyChildNode()
        {
            XmlNode parentNode = MakeNode("<message name='Daddy'/>");

            Assert.DoesNotThrow(
                delegate { QuickFix.DataDictionary.DataDictionary.VerifyChildNode(MakeNode("<field name='qty'/>"), parentNode); });

            DictionaryParseException dpx = Assert.Throws<DictionaryParseException>(
                delegate { QuickFix.DataDictionary.DataDictionary.VerifyChildNode(MakeNode("foo"), parentNode); });
            Assert.AreEqual("Malformed data dictionary: Found text-only node containing 'foo'", dpx.Message);

            dpx = Assert.Throws<DictionaryParseException>(
                delegate { QuickFix.DataDictionary.DataDictionary.VerifyChildNode(MakeNode("<field>qty</field>"), parentNode); });
            Assert.AreEqual("Malformed data dictionary: Found 'field' node without 'name' within parent 'message/Daddy'", dpx.Message);
        }
    }
}
