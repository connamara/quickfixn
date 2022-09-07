using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class MessageToXmlTests
    {
        private readonly IMessageFactory _defaultMsgFactory = new DefaultMessageFactory();

        [Test]
        public void ToXMLTest()
        {
            string str1 = "8=FIX.4.2\x01" + "9=55\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" +
                "52=20000426-12:05:06\x01" + "56=ISLD\x01" + "1=acct123\x01" + "10=123\x01";
            Message msg = new Message();
            msg.FromString(str1, true, null, null, _defaultMsgFactory);

            string expected = @"<message><header><field number=""8""><![CDATA[FIX.4.2]]></field><field number=""9""><![CDATA[55]]></field><field number=""34""><![CDATA[3]]></field><field number=""35""><![CDATA[0]]></field><field number=""49""><![CDATA[TW]]></field><field number=""52""><![CDATA[20000426-12:05:06]]></field><field number=""56""><![CDATA[ISLD]]></field></header><body><field number=""1""><![CDATA[acct123]]></field></body><trailer><field number=""10""><![CDATA[123]]></field></trailer></message>";
            Assert.AreEqual(expected, msg.ToXML());
        }


        [Test]
        public void ToXMLWithGroupsTest()
        {
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(Path.Combine(TestContext.CurrentContext.TestDirectory, "spec", "fix", "FIX44.xml"));

            string[] msgFields = {
                // header
                "8=FIX.4.4","9=638", "35=8", "34=360", "49=BLPTSOX", "52=20130321-15:21:23", "56=THINKTSOX", "57=6804469", "128=ZERO",
                // non-group body fields
                "6=122.255", "11=61101189", "14=1990000", "15=GBP", "17=VCON:20130321:50018:5:12", "22=4", "31=122.255", "32=1990000",
                "37=116", "38=1990000", "39=2", "48=GB0032452392", "54=1", "55=[N/A]", "60=20130321-15:21:23", "64=20130322", "75=20130321",
                "106=UK TSY 4 1/4% 2036", "118=2436321.85", "150=F", "151=0", "157=15", "159=3447.35", "192=0", "198=3739:20130321:50018:5",
                "223=0.0425", "228=1", "236=0.0291371041", "238=0", "381=2432874.5", "423=1", "470=GB", "541=20360307",
                // NoPartyIDs
                "453=6",
                "448=VCON", "447=D", "452=1", "802=1", "523=14", "803=4",
                "448=TFOLIO:6804469", "447=D", "452=12",
                "448=TFOLIO", "447=D", "452=11",
                "448=THINKFOLIO LTD", "447=D", "452=13",
                "448=SXT", "447=D", "452=16",
                "448=TFOLIO:6804469", "447=D", "452=36",
                "10=152"
            };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            QuickFix.FIX44.ExecutionReport msg = new QuickFix.FIX44.ExecutionReport();
            msg.FromString(msgStr, true, dd, dd, null); // <-- null factory!

            string expected = @"<message><header><field name=""BeginString"" number=""8""><![CDATA[FIX.4.4]]></field><field name=""BodyLength"" number=""9""><![CDATA[638]]></field><field name=""MsgSeqNum"" number=""34""><![CDATA[360]]></field><field name=""MsgType"" number=""35""><![CDATA[8]]></field><field name=""SenderCompID"" number=""49""><![CDATA[BLPTSOX]]></field><field name=""SendingTime"" number=""52""><![CDATA[20130321-15:21:23]]></field><field name=""TargetCompID"" number=""56""><![CDATA[THINKTSOX]]></field><field name=""TargetSubID"" number=""57""><![CDATA[6804469]]></field><field name=""DeliverToCompID"" number=""128""><![CDATA[ZERO]]></field></header><body><field name=""AvgPx"" number=""6""><![CDATA[122.255]]></field><field name=""ClOrdID"" number=""11""><![CDATA[61101189]]></field><field name=""CumQty"" number=""14""><![CDATA[1990000]]></field><field name=""Currency"" number=""15""><![CDATA[GBP]]></field><field name=""ExecID"" number=""17""><![CDATA[VCON:20130321:50018:5:12]]></field><field name=""SecurityIDSource"" number=""22""><![CDATA[4]]></field><field name=""LastPx"" number=""31""><![CDATA[122.255]]></field><field name=""LastQty"" number=""32""><![CDATA[1990000]]></field><field name=""OrderID"" number=""37""><![CDATA[116]]></field><field name=""OrderQty"" number=""38""><![CDATA[1990000]]></field><field name=""OrdStatus"" number=""39""><![CDATA[2]]></field><field name=""SecurityID"" number=""48""><![CDATA[GB0032452392]]></field><field name=""Side"" number=""54""><![CDATA[1]]></field><field name=""Symbol"" number=""55""><![CDATA[[N/A]]]></field><field name=""TransactTime"" number=""60""><![CDATA[20130321-15:21:23]]></field><field name=""SettlDate"" number=""64""><![CDATA[20130322]]></field><field name=""TradeDate"" number=""75""><![CDATA[20130321]]></field><field name=""Issuer"" number=""106""><![CDATA[UK TSY 4 1/4% 2036]]></field><field name=""NetMoney"" number=""118""><![CDATA[2436321.85]]></field><field name=""ExecType"" number=""150""><![CDATA[F]]></field><field name=""LeavesQty"" number=""151""><![CDATA[0]]></field><field name=""NumDaysInterest"" number=""157""><![CDATA[15]]></field><field name=""AccruedInterestAmt"" number=""159""><![CDATA[3447.35]]></field><field name=""OrderQty2"" number=""192""><![CDATA[0]]></field><field name=""SecondaryOrderID"" number=""198""><![CDATA[3739:20130321:50018:5]]></field><field name=""CouponRate"" number=""223""><![CDATA[0.0425]]></field><field name=""Factor"" number=""228""><![CDATA[1]]></field><field name=""Yield"" number=""236""><![CDATA[0.0291371041]]></field><field name=""Concession"" number=""238""><![CDATA[0]]></field><field name=""GrossTradeAmt"" number=""381""><![CDATA[2432874.5]]></field><field name=""PriceType"" number=""423""><![CDATA[1]]></field><field name=""NoPartyIDs"" number=""453""><![CDATA[6]]></field><field name=""CountryOfIssue"" number=""470""><![CDATA[GB]]></field><field name=""MaturityDate"" number=""541""><![CDATA[20360307]]></field><group><field name=""PartyIDSource"" number=""447""><![CDATA[D]]></field><field name=""PartyID"" number=""448""><![CDATA[VCON]]></field><field name=""PartyRole"" number=""452""><![CDATA[1]]></field><field name=""NoPartySubIDs"" number=""802""><![CDATA[1]]></field><group><field name=""PartySubID"" number=""523""><![CDATA[14]]></field><field name=""PartySubIDType"" number=""803""><![CDATA[4]]></field></group></group><group><field name=""PartyIDSource"" number=""447""><![CDATA[D]]></field><field name=""PartyID"" number=""448""><![CDATA[TFOLIO:6804469]]></field><field name=""PartyRole"" number=""452""><![CDATA[12]]></field></group><group><field name=""PartyIDSource"" number=""447""><![CDATA[D]]></field><field name=""PartyID"" number=""448""><![CDATA[TFOLIO]]></field><field name=""PartyRole"" number=""452""><![CDATA[11]]></field></group><group><field name=""PartyIDSource"" number=""447""><![CDATA[D]]></field><field name=""PartyID"" number=""448""><![CDATA[THINKFOLIO LTD]]></field><field name=""PartyRole"" number=""452""><![CDATA[13]]></field></group><group><field name=""PartyIDSource"" number=""447""><![CDATA[D]]></field><field name=""PartyID"" number=""448""><![CDATA[SXT]]></field><field name=""PartyRole"" number=""452""><![CDATA[16]]></field></group><group><field name=""PartyIDSource"" number=""447""><![CDATA[D]]></field><field name=""PartyID"" number=""448""><![CDATA[TFOLIO:6804469]]></field><field name=""PartyRole"" number=""452""><![CDATA[36]]></field></group></body><trailer><field name=""CheckSum"" number=""10""><![CDATA[152]]></field></trailer></message>";
            Assert.AreEqual(expected, msg.ToXML());
        }

        [Test]
        public void ToJSONWithGroupsTest()
        {
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(Path.Combine(TestContext.CurrentContext.TestDirectory, "spec", "fix", "FIX44.xml"));

            string[] msgFields = {
                // header
                "8=FIX.4.4","9=638", "35=8", "34=360", "49=BLPTSOX", "52=20130321-15:21:23", "56=THINKTSOX", "57=6804469", "128=ZERO",
                // non-group body fields
                "6=122.255", "11=61101189", "14=1990000", "15=GBP", "17=VCON:20130321:50018:5:12", "22=4", "31=122.255", "32=1990000",
                "37=116", "38=1990000", "39=2", "48=GB0032452392", "54=1", "55=[N/A]", "60=20130321-15:21:23", "64=20130322", "75=20130321",
                "106=UK TSY 4 1/4% 2036", "118=2436321.85", "150=F", "151=0", "157=15", "159=3447.35", "192=0", "198=3739:20130321:50018:5",
                "223=0.0425", "228=1", "236=0.0291371041", "238=0", "381=2432874.5", "423=1", "470=GB", "541=20360307",
                // NoPartyIDs
                "453=6",
                "448=VCON", "447=D", "452=1", "802=1", "523=14", "803=4",
                "448=TFOLIO:6804469", "447=D", "452=12",
                "448=TFOLIO", "447=D", "452=11",
                "448=THINKFOLIO LTD", "447=D", "452=13",
                "448=SXT", "447=D", "452=16",
                "448=TFOLIO:6804469", "447=D", "452=36",
                "10=152"
            };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            QuickFix.FIX44.ExecutionReport msg = new QuickFix.FIX44.ExecutionReport();
            msg.FromString(msgStr, true, dd, dd, null); // <-- null factory!

            string expected = "{\"Header\":{\"BeginString\":\"FIX.4.4\",\"BodyLength\":\"638\",\"MsgSeqNum\":\"360\",\"MsgType\":\"8\",\"SenderCompID\":\"BLPTSOX\",\"SendingTime\":\"20130321-15:21:23\",\"TargetCompID\":\"THINKTSOX\",\"TargetSubID\":\"6804469\",\"DeliverToCompID\":\"ZERO\"},\"Body\":{\"AvgPx\":\"122.255\",\"ClOrdID\":\"61101189\",\"CumQty\":\"1990000\",\"Currency\":\"GBP\",\"ExecID\":\"VCON:20130321:50018:5:12\",\"SecurityIDSource\":\"4\",\"LastPx\":\"122.255\",\"LastQty\":\"1990000\",\"OrderID\":\"116\",\"OrderQty\":\"1990000\",\"OrdStatus\":\"2\",\"SecurityID\":\"GB0032452392\",\"Side\":\"1\",\"Symbol\":\"[N/A]\",\"TransactTime\":\"20130321-15:21:23\",\"SettlDate\":\"20130322\",\"TradeDate\":\"20130321\",\"Issuer\":\"UK TSY 4 1/4% 2036\",\"NetMoney\":\"2436321.85\",\"ExecType\":\"F\",\"LeavesQty\":\"0\",\"NumDaysInterest\":\"15\",\"AccruedInterestAmt\":\"3447.35\",\"OrderQty2\":\"0\",\"SecondaryOrderID\":\"3739:20130321:50018:5\",\"CouponRate\":\"0.0425\",\"Factor\":\"1\",\"Yield\":\"0.0291371041\",\"Concession\":\"0\",\"GrossTradeAmt\":\"2432874.5\",\"PriceType\":\"1\",\"CountryOfIssue\":\"GB\",\"MaturityDate\":\"20360307\",\"NoPartyIDs\":[{\"PartyIDSource\":\"D\",\"PartyID\":\"VCON\",\"PartyRole\":\"1\",\"NoPartySubIDs\":[{\"PartySubID\":\"14\",\"PartySubIDType\":\"4\"}]},{\"PartyIDSource\":\"D\",\"PartyID\":\"TFOLIO:6804469\",\"PartyRole\":\"12\"},{\"PartyIDSource\":\"D\",\"PartyID\":\"TFOLIO\",\"PartyRole\":\"11\"},{\"PartyIDSource\":\"D\",\"PartyID\":\"THINKFOLIO LTD\",\"PartyRole\":\"13\"},{\"PartyIDSource\":\"D\",\"PartyID\":\"SXT\",\"PartyRole\":\"16\"},{\"PartyIDSource\":\"D\",\"PartyID\":\"TFOLIO:6804469\",\"PartyRole\":\"36\"}]},\"Trailer\":{}}";
            Assert.AreEqual(expected, msg.ToJSON());
        }
    }
}
