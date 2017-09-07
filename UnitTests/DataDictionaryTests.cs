using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using QuickFix;

namespace UnitTests
{
    public class DataDictionaryTests
    {
        private QuickFix.IMessageFactory _defaultMsgFactory = new QuickFix.DefaultMessageFactory();

        private readonly string specDirectory;
        private readonly string FIX42;
        private readonly string FIX44;

        public DataDictionaryTests()
        {
            specDirectory = Path.GetFullPath("../../../../spec");
            FIX42 = Path.Combine(specDirectory, "fix/FIX42.xml");
            FIX44 = Path.Combine(specDirectory, "fix/FIX44.xml");
        }

        [Fact]
        public void VersionTest()
        {
            QuickFix.DataDictionary.DataDictionary dd44 = new QuickFix.DataDictionary.DataDictionary();
            dd44.Load(FIX44);
            Assert.Equal("4", dd44.MajorVersion);
            Assert.Equal("4", dd44.MinorVersion);
            Assert.Equal("FIX.4.4", dd44.Version);
        }

        [Fact]
        public void LoadFieldsTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            Assert.Equal("Account", dd.FieldsByTag[1].Name);
            Assert.Equal(1, dd.FieldsByName["Account"].Tag);
            Assert.Equal(0, dd.FieldsByTag[1].EnumDict.Count);
            Assert.Equal(4, dd.FieldsByTag[QuickFix.Fields.Tags.StatusValue].EnumDict.Count);
        }

		[Fact]
		public void LoadFieldsFromStreamTest()
		{
			QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
		    using (Stream stream = new FileStream(FIX44, FileMode.Open, FileAccess.Read))
		    {
		        dd.Load(stream);
		    }
		    Assert.Equal("Account", dd.FieldsByTag[1].Name);
			Assert.Equal(1, dd.FieldsByName["Account"].Tag);
			Assert.Equal(0, dd.FieldsByTag[1].EnumDict.Count);
			Assert.Equal(4, dd.FieldsByTag[QuickFix.Fields.Tags.StatusValue].EnumDict.Count);
		}

        [Fact]
        public void FieldHasValueTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            Assert.True(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "1"));
            Assert.False(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "CONNECTED"));
            Assert.False(dd.FieldsByTag[1].HasEnums());
            Assert.True(dd.FieldsByTag[945].HasEnums());
        }

        [Fact]
        public void FieldHasDescriptionTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            Assert.Equal(typeof (Dictionary<string, string>), dd.FieldsByTag[945].EnumDict.GetType());
            Assert.Equal("COMPLETED", dd.FieldsByTag[945].EnumDict["2"]);
            Assert.NotEqual("HEARTBEAT", dd.FieldsByTag[35].EnumDict["A"]);
        }

        [Fact]
        public void BasicMessageTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            Assert.Equal(7, dd.Messages["3"].Fields.Count);
        }

        [Fact]
        public void ComponentSmokeTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            QuickFix.DataDictionary.DDMap tcr = dd.Messages["AE"];
            Assert.True(tcr.Fields.ContainsKey(55));
            Assert.False(tcr.Fields.ContainsKey(5995));
        }

        [Fact]
        public void GroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            QuickFix.DataDictionary.DDMap tcrr = dd.Messages["AD"];
            Assert.True(tcrr.IsGroup(711));
            Assert.True(tcrr.IsField(711));  // No Field also a field
            Assert.True(tcrr.GetGroup(711).IsField(311));
            Assert.Equal("UnderlyingSymbol", tcrr.Groups[711].Fields[311].Name);
            Assert.Equal(311, tcrr.Groups[711].Delim);
            QuickFix.DataDictionary.DDMap tcr = dd.Messages["AE"];
            Assert.Equal("UnderlyingSecurityAltID", tcr.Groups[711].Groups[457].Fields[458].Name);
        }

        [Fact]
        public void NestedGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            QuickFix.DataDictionary.DDMap msgJ = dd.Messages["J"];

            Assert.True(msgJ.IsGroup(73));
            Assert.False(msgJ.IsGroup(756));
            Assert.True(msgJ.GetGroup(73).IsGroup(756));
        }

        [Fact]
        public void HeaderGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            QuickFix.DataDictionary.DDMap headerMap = dd.Header;
            Assert.True(headerMap.IsGroup(627));
            QuickFix.DataDictionary.DDGrp grpMap = headerMap.GetGroup(627);
            Assert.True(dd.Header.GetGroup(627).IsField(628));
            Assert.True(grpMap.IsField(628));
        }

        [Fact]
        public void ReqFldTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            Assert.Contains(571, dd.Messages["AE"].ReqFields);
            Assert.DoesNotContain(828, dd.Messages["AE"].ReqFields);
        }

        [Fact]
        public void HeaderTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            Assert.Contains(9, dd.Header.ReqFields);
            Assert.Equal(27, dd.Header.Fields.Count);
        }

        [Fact]
        public void TrailerTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            Assert.Contains(10, dd.Trailer.ReqFields);
            Assert.Equal(3, dd.Trailer.Fields.Count);
        }

        [Fact]
        public void CheckValidTagTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            Assert.Throws<InvalidTagNumber>(delegate { dd.CheckValidTagNumber(999); });
        }

        [Fact]
        public void CheckIsInGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            QuickFix.DataDictionary.DDGrp g = dd.Messages["B"].GetGroup(33);

            QuickFix.Fields.Text textField = new QuickFix.Fields.Text("woot");
            QuickFix.Fields.ClOrdID clOrdIdField = new QuickFix.Fields.ClOrdID("not woot");

            dd.CheckIsInGroup(textField, g, "B");
            Assert.Throws<TagNotDefinedForMessage>(delegate { dd.CheckIsInGroup(clOrdIdField, g, "B"); });
        }

        [Fact]
        public void CheckGroupCountTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX42);

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
            Assert.Equal("386=3", n.NoTradingSessions.toStringField());
            Assert.Contains("386=3", n.ToString());

            Assert.Throws<QuickFix.RepeatingGroupCountMismatch>(delegate { dd.CheckGroupCount(n.NoTradingSessions, n, "D"); });
        }

        [Fact]
        public void ValidateWrongType()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
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

            Assert.Throws<IncorrectDataFormat>(() => dd.Validate(message, beginString, msgType));
        }

        [Fact]
        public void ValidateWithRepeatingGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX42);
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

        [Fact]
        public void ValidateWrongTypeInRepeatingGroup()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
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

            Assert.Throws<IncorrectDataFormat>(() => dd.Validate(message, beginString, msgType));
        }

        [Fact]
        public void ValidateWrongTypeInNestedRepeatingGroup()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
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

            Assert.Throws<IncorrectDataFormat>(() => dd.Validate(message, beginString, msgType));
        }

        [Fact]
        public void ValidateDateAndTimeFields()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
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

        [Fact]
        public void ValidateDateTime_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            // intentionally invalid SendingTime (52/DateTime)
            string[] msgFields = { "8=FIX.4.4", "9=91", "35=W", "34=3", "49=sender", "52=20110909", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012", "273=22:15:30.444", "10=51" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            Assert.Throws<IncorrectDataFormat>(() => dd.Validate(message, beginString, msgType));
        }

        [Fact]
        public void ValidateDateOnly_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            // intentionally invalid MDEntryDate (272/DateOnly)
            string[] msgFields = { "8=FIX.4.4", "9=117", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012-22:15:30.444", "273=22:15:30.444", "10=175" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            Assert.Throws<IncorrectDataFormat>(() => dd.Validate(message, beginString, msgType));
        }

        [Fact]
        public void ValidateTimeOnly_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            // intentionally invalid MDEntryTime (272/TimeOnly)
            string[] msgFields = { "8=FIX.4.4", "9=113", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012", "273=20111012-22:15:30.444", "10=200" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "W";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            Assert.Throws<IncorrectDataFormat>(() => dd.Validate(message, beginString, msgType));
        }

        [Fact]
        public void DuplicateEnumsDoesNotThrow()
        {
            // If this test throws, it failed.
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(Path.Combine(specDirectory, "test/FIX43_dup_enum.xml"));
        }

        [Fact]
        public void OptionalComponentRequiredField()
        {
            // issue #98 - message erroneously rejected because DD says that
            //   component-required field is missing even though component is not present

            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
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

        [Fact]
        public void RequiredComponentRequiredField()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = { "8=FIX.4.4", "9=76", "35=7", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "2=AdvId", "5=N", "4=B", "53=1", "10=138" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "7";
            string beginString = "FIX.4.4";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd, f);

            var ex = Assert.Throws<QuickFix.RequiredTagMissing>(delegate { dd.Validate(message, beginString, msgType); });
            Assert.Equal(55, ex.Field);
        }

        [Fact]
        public void ComponentFieldsRequirements()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX44);
            Assert.DoesNotContain(55, dd.Messages["AD"].ReqFields);
            Assert.Contains(55, dd.Messages["7"].ReqFields);
        }

        [Fact]
        public void Issue134_RequiredIsOptional()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(Path.Combine(specDirectory,"test/required_is_optional.xml"));
            Assert.Contains(1111, dd.Messages["magic"].ReqFields);  //base required field
            Assert.DoesNotContain(5555, dd.Messages["magic"].ReqFields); //base optional field
            Assert.DoesNotContain(5556, dd.Messages["magic"].ReqFields); //component optional field

            Assert.False(dd.Messages["magic"].Groups[6660].Required); // group isn't required
            Assert.DoesNotContain(6662, dd.Messages["magic"].Groups[6660].ReqFields); // group optional field
        }

        [Fact] // Issue #66
        public void ValidateMultipleValueStringType()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary( FIX44 );
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

        [Fact] // Issue #66
        public void ValidateMultipleValueStringType_Invalid()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary( FIX44 );
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

            Assert.Throws<IncorrectTagValue>(() => dd.Validate(message, beginString, msgType));
        }

        [Fact] // Issue #282 investigation
        public void ValidateTagSpecifiedWithoutAValue()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX42);
            QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

            string[] msgFields = {"8=FIX.4.2", "9=65", "35=B", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                   "148=", "33=0", "10=188"};
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            string msgType = "B";
            string beginString = "FIX.4.2";

            Message message = f.Create(beginString, msgType);
            message.FromString(msgStr, true, dd, dd);

            dd.CheckFieldsHaveValues = true;
            Assert.Throws<QuickFix.NoTagValue>(delegate { dd.Validate(message, beginString, msgType); });

            dd.CheckFieldsHaveValues = false;
            dd.Validate(message, beginString, msgType);
        }
    }
}
