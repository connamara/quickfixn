using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;

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
            dd44.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd44.MajorVersion, Is.EqualTo("4"));
            Assert.That(dd44.MinorVersion, Is.EqualTo("4"));
            Assert.That(dd44.Version, Is.EqualTo("FIX.4.4"));
        }

        [Test]
        public void LoadFieldsTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.FieldsByTag[1].Name, Is.EqualTo("Account"));
            Assert.That(dd.FieldsByName["Account"].Tag, Is.EqualTo(1));
            Assert.That(dd.FieldsByTag[1].EnumDict.Count, Is.EqualTo(0));
            Assert.That(dd.FieldsByTag[QuickFix.Fields.Tags.StatusValue].EnumDict.Count, Is.EqualTo(4));
        }

        [Test]
        public void FieldHasValueTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "1"), Is.EqualTo(true));
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "CONNECTED"), Is.EqualTo(false));
            Assert.False(dd.FieldsByTag[1].HasEnums());
            Assert.True(dd.FieldsByTag[945].HasEnums());
        }

        [Test]
        public void FieldHasDescriptionTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.AreEqual(typeof (Dictionary<string, string>), dd.FieldsByTag[945].EnumDict.GetType());
            Assert.That("COMPLETED", Is.EqualTo(dd.FieldsByTag[945].EnumDict["2"]));
            Assert.AreNotEqual("HEARTBEAT", dd.FieldsByTag[35].EnumDict["A"]);
        }

        [Test]
        public void BasicMessageTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.Messages["3"].Fields.Count, Is.EqualTo(7));
        }

        [Test]
        public void ComponentSmokeTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            QuickFix.DataDictionary.DDMap tcr = dd.Messages["AE"];
            Assert.True(tcr.Fields.ContainsKey(55));
            Assert.False(tcr.Fields.ContainsKey(5995));
        }

        [Test]
        public void GroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
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
            dd.Load("../../../spec/fix/FIX44.xml");
            QuickFix.DataDictionary.DDMap msgJ = dd.Messages["J"];

            Assert.True(msgJ.IsGroup(73));
            Assert.False(msgJ.IsGroup(756));
            Assert.True(msgJ.GetGroup(73).IsGroup(756));
        }

        [Test]
        public void HeaderGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            QuickFix.DataDictionary.DDMap headerMap = dd.Header;
            Assert.True(headerMap.IsGroup(627));
            QuickFix.DataDictionary.DDGrp grpMap = headerMap.GetGroup(627);
            Assert.True(dd.Header.GetGroup(627).IsField(628));
            Assert.True(grpMap.IsField(628));
        }

        [Test]
        public void ReqFldTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            Assert.True(dd.Messages["AE"].ReqFields.Contains(571));
            Assert.False(dd.Messages["AE"].ReqFields.Contains(828));
        }

        [Test]
        public void HeaderTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            Assert.True(dd.Header.ReqFields.Contains(9));
            Assert.That(dd.Header.Fields.Count, Is.EqualTo(27));
        }

        [Test]
        public void TrailerTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            Assert.True(dd.Trailer.ReqFields.Contains(10));
            Assert.That(dd.Trailer.Fields.Count, Is.EqualTo(3));
        }

        [Test]
        public void CheckValidTagTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            Assert.Throws(typeof(InvalidTagNumber),
                delegate { dd.CheckValidTagNumber(999); });
        }

        [Test]
        public void CheckIsInGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            QuickFix.DataDictionary.DDGrp g = dd.Messages["B"].GetGroup(33);

            QuickFix.Fields.Text textField = new QuickFix.Fields.Text("woot");
            QuickFix.Fields.ClOrdID clOrdIdField = new QuickFix.Fields.ClOrdID("not woot");

            Assert.DoesNotThrow(delegate() { dd.CheckIsInGroup(textField, g, "B"); });
            Assert.Throws(typeof(TagNotDefinedForMessage), delegate { dd.CheckIsInGroup(clOrdIdField, g, "B"); });
        }

        [Test]
        public void CheckGroupCountTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX42.xml");

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
        [ExpectedException(typeof(QuickFix.IncorrectDataFormat))]
        public void ValidateWrongType()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
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

            dd.Validate(message, beginString, msgType);
        }

        [Test]
        public void ValidateWithRepeatingGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX42.xml");
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
        [ExpectedException(typeof(QuickFix.IncorrectDataFormat))]
        public void ValidateWrongTypeInRepeatingGroup()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
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

            dd.Validate(message, beginString, msgType);
        }

        [Test]
        [ExpectedException(typeof(QuickFix.IncorrectDataFormat))]
        public void ValidateWrongTypeInNestedRepeatingGroup()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
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

            dd.Validate(message, beginString, msgType);
        }

        [Test]
        public void ValidateDateAndTimeFields()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
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
        [ExpectedException(typeof(QuickFix.IncorrectDataFormat))]
        public void ValidateDateTime_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            // intentionally invalid SendingTime (52/DateTime)
            string[] msgFields = { "8=FIX.4.4", "9=91", "35=W", "34=3", "49=sender", "52=20110909", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012", "273=22:15:30.444", "10=51" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            // this should throw
            dd.Validate(message, beginString, msgType);
        }

        [Test]
        [ExpectedException(typeof(QuickFix.IncorrectDataFormat))]
        public void ValidateDateOnly_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            // intentionally invalid MDEntryDate (272/DateOnly)
            string[] msgFields = { "8=FIX.4.4", "9=117", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012-22:15:30.444", "273=22:15:30.444", "10=175" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            // this should throw
            dd.Validate(message, beginString, msgType);
        }

        [Test]
        [ExpectedException(typeof(QuickFix.IncorrectDataFormat))]
        public void ValidateTimeOnly_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            // intentionally invalid MDEntryTime (272/TimeOnly)
            string[] msgFields = { "8=FIX.4.4", "9=113", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012", "273=20111012-22:15:30.444", "10=200" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            // this should throw
            dd.Validate(message, beginString, msgType);
        }

        [Test]
        public void DuplicateEnumsDoesNotThrow()
        {
            // If this test throws, it failed.
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/test/FIX43_dup_enum.xml");
        }

        [Test]
        public void OptionalComponentRequiredField()
        {
            // issue #98 - message erroneously rejected because DD says that
            //   component-required field is missing even though component is not present

            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
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
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
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
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            Assert.False(dd.Messages["AD"].ReqFields.Contains(55));
            Assert.True(dd.Messages["7"].ReqFields.Contains(55));
        }

        [Test]
        public void Issue134_RequiredIsOptional()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/test/required_is_optional.xml");
            Assert.True(dd.Messages["magic"].ReqFields.Contains(1111));  //base required field
            Assert.False(dd.Messages["magic"].ReqFields.Contains(5555)); //base optional field
            Assert.False(dd.Messages["magic"].ReqFields.Contains(5556)); //component optional field

            Assert.False(dd.Messages["magic"].Groups[6660].Required); // group isn't required
            Assert.False(dd.Messages["magic"].Groups[6660].ReqFields.Contains(6662)); // group optional field
        }
    }
}
