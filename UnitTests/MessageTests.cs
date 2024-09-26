using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;
using UnitTests.TestHelpers;
using Message = QuickFix.Message;

namespace UnitTests
{
    [TestFixture]
    public class MessageTests
    {
        private readonly IMessageFactory _defaultMsgFactory = new DefaultMessageFactory();

        [Test]
        public void IdentifyTypeTest()
        {
            string msg1 = "|35=A|".Replace('|', Message.SOH);
            Assert.That(Message.IdentifyType(msg1).Value, Is.EqualTo(new MsgType("A").Value));
            string msg2 = "a;sldkfjadls;k|35=A|a;sldkfja;sdlfk".Replace('|', Message.SOH);
            Assert.That(Message.IdentifyType(msg2).Value, Is.EqualTo(new MsgType("A").Value));
            string msg3 = "8=FIX4.2|9=12||35=B|10=031|".Replace('|', Message.SOH);
            Assert.That(Message.IdentifyType(msg3).Value, Is.EqualTo(new MsgType("B").Value));

            // no 35
            string err1 = "8=FIX.4.4|49=Sender|".Replace('|', Message.SOH);
            Assert.Throws<MessageParseError>(delegate { Message.IdentifyType(err1); });
            // no SOH at end of 35
            string err2 = "8=FIX.4.4|35=A".Replace('|', Message.SOH);
            Assert.Throws<MessageParseError>(delegate { Message.IdentifyType(err2); });
        }

        [Test]
        public void ExtractStringTest()
        {
            string str1 = "8=FIX.4.2|9=46|35=0|34=3|49=TW|".Replace('|', Message.SOH);
            int pos = 0;
            StringField sf1 = Message.ExtractField(str1, ref pos);
            Assert.That(pos, Is.EqualTo(10));
            Assert.That(sf1.Tag, Is.EqualTo(8));
            Assert.That(sf1.Value, Is.EqualTo("FIX.4.2"));
            StringField sf2 = Message.ExtractField(str1, ref pos);
            Assert.That(pos, Is.EqualTo(15));
            Assert.That(sf2.Tag, Is.EqualTo(9));
            Assert.That(sf2.Value, Is.EqualTo("46"));
        }

        [Test]
        public void ExtractStringErrorsTest()
        {
            int pos = 0;
            Assert.Throws(typeof(MessageParseError),
                delegate { Message.ExtractField("=", ref pos); });
            Assert.Throws(typeof(MessageParseError),
                delegate { Message.ExtractField("35=A", ref pos); });
            Assert.Throws(typeof(MessageParseError),
                delegate { Message.ExtractField("\x01" + "35=A", ref pos); });
            Assert.Throws(typeof(MessageParseError),
                delegate { Message.ExtractField("35=\x01", ref pos); });
        }


        [Test]
        public void CheckSumTest()
        {
            string str1 = "8=FIX.4.2|9=45|35=0|34=3|49=TW|52=20000426-12:05:06|56=ISLD|".Replace('|', Message.SOH);

            int chksum = 0;
            foreach (char c in str1)
                chksum += c;
            chksum %= 256;

            str1 += "10=218\x01";  // checksum field
            Message msg = new Message();
            try
            {
                msg.FromString(str1, true, null, null, _defaultMsgFactory);
            }
            catch (InvalidMessage e)
            {
                Assert.Fail("Unexpected exception (InvalidMessage): " + e.Message);
            }
            Assert.That(msg.CheckSum(), Is.EqualTo(chksum));
        }

        [Test]
        public void FromStringTestWithNoDataDictionary()
        {
            string str1 = "8=FIX.4.2|9=55|35=0|34=3|49=TW|52=20000426-12:05:06|56=ISLD|1=acct123|10=123|"
                .Replace('|', Message.SOH);

            Message msg = new();
            try
            {
                msg.FromString(str1, true, null, null, _defaultMsgFactory);
            }
            catch (InvalidMessage e)
            {
                Assert.Fail("Unexpected exception (InvalidMessage): " + e.Message);
            }
            StringField f1 = new StringField(8);
            StringField f2 = new StringField(9);
            StringField f3 = new StringField(35);
            StringField f4 = new StringField(34);
            StringField f5 = new StringField(49);
            StringField f6 = new StringField(52);
            StringField f7 = new StringField(56);
            StringField f8 = new StringField(10);
            StringField f9 = new StringField(1);
            msg.Header.GetField(f1);
            msg.Header.GetField(f2);
            msg.Header.GetField(f3);
            msg.Header.GetField(f4);
            msg.Header.GetField(f5);
            msg.Header.GetField(f6);
            msg.Header.GetField(f7);
            msg.GetField(f9);
            msg.Trailer.GetField(f8);
            Assert.That(f1.Value, Is.EqualTo("FIX.4.2"));
            Assert.That(f2.Value, Is.EqualTo("55"));
            Assert.That(f3.Value, Is.EqualTo("0"));
            Assert.That(f4.Value, Is.EqualTo("3"));
            Assert.That(f5.Value, Is.EqualTo("TW"));
            Assert.That(f6.Value, Is.EqualTo("20000426-12:05:06"));
            Assert.That(f7.Value, Is.EqualTo("ISLD"));
            Assert.That(f8.Value, Is.EqualTo("123"));
            Assert.That(f9.Value, Is.EqualTo("acct123"));
        }

        [Test]
        public void FromString_Groups_NoFactory()
        {
            // issue 179
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");

            string msgStr =
                ("8=FIX.4.4|9=638|35=8|34=360|49=BLPTSOX|52=20130321-15:21:23|56=THINKTSOX|57=6804469|128=ZERO|"
                 // non-group body fields
                 + "6=122.255|11=61101189|14=1990000|15=GBP|17=VCON:20130321:50018:5:12|22=4|31=122.255|32=1990000|"
                 + "37=116|38=1990000|39=2|48=GB0032452392|54=1|55=[N/A]|60=20130321-15:21:23|64=20130322|75=20130321|"
                 + "106=UK TSY 4 1/4% 2036|118=2436321.85|150=F|151=0|157=15|159=3447.35|192=0|198=3739:20130321:50018:5|"
                 + "223=0.0425|228=1|236=0.0291371041|238=0|381=2432874.5|423=1|470=GB|541=20360307|"
                 // NoPartyIDs
                 + "453=6|"
                 + "448=VCON|447=D|452=1|802=1|523=14|803=4|"
                 + "448=TFOLIO:6804469|447=D|452=12|"
                 + "448=TFOLIO|447=D|452=11|"
                 + "448=THINKFOLIO LTD|447=D|452=13|"
                 + "448=SXT|447=D|452=16|"
                 + "448=TFOLIO:6804469|447=D|452=36|"
                 + "10=152|").Replace('|', Message.SOH);

            QuickFix.FIX44.ExecutionReport msg = new QuickFix.FIX44.ExecutionReport();
            msg.FromString(msgStr, true, dd, dd, null); // <-- null factory!

            //Console.WriteLine(msg.ToString());

            QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup partyGroup = new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup();
            msg.GetGroup(2, partyGroup);

            Assert.False(partyGroup.IsSetNoPartySubIDs());
        }

        [Test]
        public void FromString_DoNotCorrectCounter()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX42");

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string s = ("8=FIX.4.2|9=148|35=D|34=2|49=TW|52=20111011-15:06:23.103|56=ISLD|"
                        + "11=ID|21=1|40=1|54=1|38=200.00|55=INTC|"
                        + "386=3|336=PRE-OPEN|336=AFTER-HOURS|"
                        + "60=20111011-15:06:23.103|"
                        + "10=35|").Replace('|', Message.SOH);

            n.FromString(s, true, dd, dd, _defaultMsgFactory);
            Assert.AreEqual("386=3", n.NoTradingSessions.ToStringField());
            StringAssert.Contains("386=3", n.ConstructString()); //should not be "corrected" to 2!
        }

        [Test]
        public void FromString_GroupDelimiterIssue()
        {
            // 349
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX42");

            QuickFix.FIX42.News n = new QuickFix.FIX42.News();

            string s = ("8=FIX.4.2|9=91|35=B|34=2|49=TW|52=20111011-15:06:23.103|56=ISLD|"
                        + "148=headline|33=3|"
                        + "58=line1|354=3|355=uno|" // first group, has delimiter
                        + "354=3|355=dos|" // second group, missing delimiter
                        + "354=4|355=tres|" // third group, also missing delimiter
                        + "10=193|").Replace('|', Message.SOH);

            Assert.Throws<RepeatedTagWithoutGroupDelimiterTagException>(delegate { n.FromString(s, true, dd, dd, _defaultMsgFactory); });
        }

        [Test]
        public void ConstructStringFieldOrder()
        {
            Message msg = new Message();
            msg.Header.SetField(new MsgType("A"));
            msg.Header.SetField(new BeginString("FIX.4.2"));
            msg.Header.SetField(new SenderCompID("SENDER"));
            msg.Header.SetField(new TargetCompID("TARGET"));
            msg.Header.SetField(new MsgSeqNum(42));
            string expect = "8=FIX.4.2|9=31|35=A|34=42|49=SENDER|56=TARGET|10=200|".Replace('|', Message.SOH);
            Assert.That(msg.ConstructString(), Is.EqualTo(expect));
        }

        [Test]
        public void IsHeaderFieldTest()
        {
            Assert.That(Message.IsHeaderField(Tags.BeginString), Is.EqualTo(true));
            Assert.That(Message.IsHeaderField(Tags.TargetCompID), Is.EqualTo(true));
            Assert.That(Message.IsHeaderField(Tags.Account), Is.EqualTo(false));
        }

        [Test]
        public void IsTrailerFieldTest()
        {
            Assert.That(Message.IsTrailerField(Tags.CheckSum), Is.EqualTo(true));
            Assert.That(Message.IsTrailerField(Tags.Price), Is.EqualTo(false));
        }

        [Test]
        public void EnumeratorTest()
        {
            string msgStr = "8=FIX.4.2|9=55|35=0|34=3|49=TW|52=20000426-12:05:06|56=ISLD|1=acct123|10=123|"
                .Replace('|', Message.SOH);
            Message msg = new Message(msgStr);

            int numHeaderFields = 0;
            foreach (KeyValuePair<int, IField> unused in msg.Header)
                ++numHeaderFields;
            Assert.AreEqual(7, numHeaderFields);

            int numTrailerFields = 0;
            foreach (KeyValuePair<int, IField> unused in msg.Trailer)
                ++numTrailerFields;
            Assert.AreEqual(1, numTrailerFields);

            int numBodyFields = 0;
            foreach (KeyValuePair<int, IField> unused in msg)
                ++numBodyFields;
            Assert.AreEqual(1, numBodyFields);
        }

        [Test]
        public void RepeatedTagDetection()
        {
            string msgStr = ("8=FIX.4.2|9=72|35=0|34=3|49=TW|49=BOGUS|52=20000426-12:05:06|56=ISLD|"
                             + "1=acct123|1=bogus|10=052|10=000|").Replace('|', Message.SOH);
            Message msg = new Message(msgStr);
            Assert.AreEqual(1, msg.Header.RepeatedTags.Count);
            Assert.AreEqual(49, msg.Header.RepeatedTags[0].Tag);

            Assert.AreEqual(1, msg.Trailer.RepeatedTags.Count);
            Assert.AreEqual(10, msg.Trailer.RepeatedTags[0].Tag);

            Assert.AreEqual(1, msg.RepeatedTags.Count);
            Assert.AreEqual(1, msg.RepeatedTags[0].Tag);
        }

        [Test]
        public void AddGroupGetGroupTest()
        {
            var nos = new QuickFix.FIX42.NewOrderSingle();
            var noTradingSessions = new QuickFix.FIX42.NewOrderSingle.NoTradingSessionsGroup();
            noTradingSessions.SetField(new StringField(336, "OHHAI"));
            nos.AddGroup(noTradingSessions);
            var noTradingSessionsRE = nos.GetGroup(1, Tags.NoTradingSessions);
            Assert.That(noTradingSessionsRE.GetString(336), Is.EqualTo("OHHAI"));

            var nos2 = new QuickFix.FIX42.NewOrderSingle();
            var grp = new Group(200, 300);
            grp.SetField(new StringField(300, "Dude"));
            nos2.AddGroup(grp);
            Assert.That(nos2.GetGroup(1, 200).GetString(300), Is.EqualTo("Dude"));
        }

        [Test]
        public void RepeatingGroupParseGroupTest() {
            string data = ("8=FIX.4.4|9=309|35=8|49=ASX|56=CL1_FIX44|34=4|52=20060324-01:05:58|"
                           + "17=X-B-WOW-1494E9A0:58BD3F9D-1109|150=D|39=0|11=184271|38=200|198=1494E9A0:58BD3F9D|"
                           + "526=4324|37=B-WOW-1494E9A0:58BD3F9D|55=WOW|54=1|151=200|14=0|40=2|44=15|59=1|6=0|"
                           + "453=3|"
                           + "448=AAA35791|447=D|452=3|802=1|523=OHAI123|"
                           + "448=8|447=D|452=4|448=FIX11|447=D|452=36|"
                           + "60=20060320-03:34:29|10=169|").Replace('|', Message.SOH);
            var msg = new QuickFix.FIX44.ExecutionReport();
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            msg.FromString(data, false, dd, dd, _defaultMsgFactory);

            var grp = msg.GetGroup(1, Tags.NoPartyIDs);
            Assert.That(grp.GetString(Tags.PartyID), Is.EqualTo("AAA35791"));
            grp = msg.GetGroup(3, Tags.NoPartyIDs);
            Assert.That(grp.GetString(Tags.PartyID), Is.EqualTo("FIX11"));
        }

        [Test]
        public void NestedRepeatingGroupParseGroupTest() {
            String data = ("8=FIX.4.4|9=309|35=8|49=ASX|56=CL1_FIX44|34=4|52=20060324-01:05:58|"
                           + "17=X-B-WOW-1494E9A0:58BD3F9D-1109|150=D|39=0|11=184271|38=200|198=1494E9A0:58BD3F9D|"
                           + "526=4324|37=B-WOW-1494E9A0:58BD3F9D|55=WOW|54=1|151=200|14=0|40=2|44=15|59=1|6=0|"
                           + "453=3|"
                           + "448=AAA35791|447=D|452=3|802=1|523=OHAI123|"
                           + "448=8|447=D|452=4|"
                           + "448=FIX11|447=D|452=36|"
                           + "60=20060320-03:34:29|10=169|").Replace('|', Message.SOH);
            var msg = new QuickFix.FIX44.ExecutionReport();
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            msg.FromString(data, false, dd, dd, _defaultMsgFactory);

            var subGrp = msg.GetGroup(1, Tags.NoPartyIDs).GetGroup(1, Tags.NoPartySubIDs);
            Assert.That(subGrp.GetString(Tags.PartySubID), Is.EqualTo("OHAI123"));
        }

        [Test]
        public void ReadXmlDataTest() {
            // Use tag 212/XmlDataLen to properly read 213/XmlData

            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX42");

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string s = ("8=FIX.4.2|9=495|35=n|34=31420|369=1003|"
                        + "52=20200701-20:34:33.978|49=CME|50=84|"
                        + "56=DUMMY11|57=SID1|143=US,IL|212=392|"
                        + "213=<RTRF>8=FIX.4.2|9=356|35=8|34=36027|"
                        + "369=18623|52=20200701-20:34:33.977|49=CME|50=84|"
                        + "56=M2L000N|57=DUMMY|143=US,IL|1=00331|"
                        + "6=0|11=ACP1593635673935|14=0|17=84618:1342652|20=0|"
                        + "37=84778833500|38=10|39=0|40=2|"
                        + "41=0|44=139.203125|48=204527|54=1|55=ZN|"
                        + "59=0|60=20200701-20:34:33.976|107=ZNH1|150=0|"
                        + "151=10|167=FUT|432=20200701|1028=Y|1031=Y|"
                        + "5979=1593635673976364291|9717=ACP1593635673935|10=124|</RTRF>|"
                        + "10=028|").Replace('|', Message.SOH);

            n.FromString(s, true, dd, dd, _defaultMsgFactory);

            //verify that the data field was read correctly
            Assert.AreEqual(n.Header.GetInt(212), n.Header.GetString(213).Length);
        }

        [Test]
        public void XmlDataWithoutLengthTest() {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX42");

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string s = ("8=FIX.4.2|9=495|35=n|34=31420|369=1003|"
                        + "52=20200701-20:34:33.978|49=CME|50=84|"
                        + "56=DUMMY11|57=SID1|143=US,IL|"
                        + "213=oops my length field 212 is missing|"
                        + "10=028|").Replace('|', Message.SOH);

            FieldNotFoundException ex =
                Assert.Throws<FieldNotFoundException>(delegate { n.FromString(s, true, dd, dd, _defaultMsgFactory); })!;
            Assert.AreEqual("field not found for tag: 212", ex.Message);
        }

        [Test]
        public void HeaderGroupParsingTest()
        {
            string data = "8=FIX.4.4|9=40|35=A|627=2|628=FOO|628=BAR|98=0|384=2|372=D|385=R|372=8|385=S|10=228|"
                .Replace('|', Message.SOH);

            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            var nos = new QuickFix.FIX44.Logon();
            nos.FromString(data, false, dd, dd, _defaultMsgFactory);
            Group hops = nos.Header.GetGroup(1, Tags.NoHops);
            Assert.That(hops.GetString(Tags.HopCompID), Is.EqualTo("FOO"));
            hops = nos.Header.GetGroup(2, Tags.NoHops);
            Assert.That(hops.GetString(Tags.HopCompID), Is.EqualTo("BAR"));
        }

        [Test]
        public void MsgType()
        {
            Assert.AreEqual("B", QuickFix.FIX42.News.MsgType);
        }

        [Test]
        public void ExtractBeginString()
        {
            string m1 = "8=FIX4.2|9999=99999|".Replace('|', Message.SOH);;
            string m2 = "987=pants|xxxxxxxxxxxxxxxxxxxxxx".Replace('|', Message.SOH);;

            Assert.AreEqual("FIX4.2", Message.ExtractBeginString(m1));
            Assert.AreEqual("pants", Message.ExtractBeginString(m2));
        }

        [Test]
        public void ExtractFieldTypes()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX42");

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string s = ("8=FIX.4.2|9=137|35=D|34=3|49=CLIENT1|"
                        + "52=20110901-18:41:56.917|56=EXECUTOR|11=asdf|21=1|"
                        + "38=5.5|40=1|54=1|55=ibm|59=1|60=20110901-13:41:31.804|"
                        + "377=Y|201=1|"
                        + "10=63|").Replace('|', Message.SOH);
            n.FromString(s, true, dd, dd, _defaultMsgFactory);

            // string values are good?
            Assert.AreEqual("Y", n.SolicitedFlag.ToString()); //bool, 377
            Assert.AreEqual("1", n.Side.ToString()); //char, 54
            Assert.AreEqual("20110901-13:41:31.804", n.TransactTime.ToString()); //datetime, 60
            Assert.AreEqual("5.5", n.OrderQty.ToString()); //decimal, 38
            Assert.AreEqual("1", n.PutOrCall.ToString()); //int, 201
            Assert.AreEqual("asdf", n.ClOrdID.ToString()); //string, 11

            // type-converted values are good?
            Assert.AreEqual(true, n.SolicitedFlag.Value);
            Assert.AreEqual('1', n.Side.Value);
            Assert.AreEqual(DateTime.Parse("2011-09-01 13:41:31.804"), n.TransactTime.Value);
            Assert.AreEqual(5.5m, n.OrderQty.Value);
            Assert.AreEqual(1, n.PutOrCall.Value);
            Assert.AreEqual("asdf", n.ClOrdID.Value);
        }

        [Test]
        public void ExtractFieldTest()
        {
            string msgstr = "100=200|300=400|500=600|".Replace('|', Message.SOH);
            int n = 0;

            var x = QuickFix.Message.ExtractField(msgstr, ref n);
            Assert.AreEqual(8, n);
            Assert.AreEqual("100=200", x.ToStringField());

            x = QuickFix.Message.ExtractField(msgstr, ref n);
            Assert.AreEqual(16, n);
            Assert.AreEqual("300=400", x.ToStringField());

            x = QuickFix.Message.ExtractField(msgstr, ref n);
            Assert.AreEqual(24, n);
            Assert.AreEqual("500=600", x.ToStringField());
        }

        [Test]
        public void RepeatingGroup()
        {
            QuickFix.DataDictionary.DataDictionary dd = new();
            dd.LoadFIXSpec("FIX42");

            QuickFix.FIX42.News news = new QuickFix.FIX42.News(new Headline("Foo headline"));

            QuickFix.FIX42.News.LinesOfTextGroup group1 = new();
            group1.Text = new Text("line1");
            group1.EncodedTextLen = new EncodedTextLen(3);
            group1.EncodedText = new EncodedText("aaa");
            news.AddGroup(group1);

            QuickFix.FIX42.News.LinesOfTextGroup group2 = new();
            group2.Text = new Text("line2");
            group2.EncodedText = new EncodedText("bbb");
            news.AddGroup(group2);

            string raw = news.ConstructString();

            StringAssert.Contains("33=2|58=line1|354=3|355=aaa|58=line2|355=bbb|", raw.Replace(Message.SOH, '|'));
        }

        [Test]
        public void RepeatingGroup_ReuseObject()
        {
            QuickFix.DataDictionary.DataDictionary dd = new();
            dd.LoadFIXSpec("FIX42");

            QuickFix.FIX42.News news = new QuickFix.FIX42.News(new Headline("Foo headline"));

            QuickFix.FIX42.News.LinesOfTextGroup group = new();
            group.Text = new Text("line1");
            news.AddGroup(group);
            group.Text = new Text("line2");
            news.AddGroup(group);

            string raw = news.ConstructString();
            StringAssert.Contains("|33=2|58=line1|58=line2|", raw.Replace(Message.SOH, '|'));
        }

        [Test]
        public void ReverseRoute()
        {
            string str1 = "8=FIX.4.2|9=55|35=0|34=3|49=TW|52=20000426-12:05:06|56=ISLD|1=acct123|10=123|"
                .Replace('|', Message.SOH);

            Message msg = new Message();
            try
            {
                msg.FromString(str1, true, null, null, _defaultMsgFactory);
            }
            catch (InvalidMessage e)
            {
                Assert.Fail("Unexpected exception (InvalidMessage): " + e.Message);
            }
            Header header = new Header();
            header.SetField(new BeginString("FIX.4.2"));
            header.SetField(new SenderCompID("SENDER"));
            header.SetField(new SenderSubID("SENDERSUB"));
            header.SetField(new SenderLocationID("SENDERLOC"));
            header.SetField(new TargetCompID("TARGET"));
            header.SetField(new TargetSubID("TARGETSUB"));
            header.SetField(new TargetLocationID("TARGETLOC"));

            msg.ReverseRoute(header);

            Assert.That(msg.Header.GetString(Tags.BeginString), Is.EqualTo("FIX.4.2"));
            Assert.That(msg.Header.GetString(Tags.TargetCompID), Is.EqualTo("SENDER"));
            Assert.That(msg.Header.GetString(Tags.TargetSubID), Is.EqualTo("SENDERSUB"));
            Assert.That(msg.Header.GetString(Tags.TargetLocationID), Is.EqualTo("SENDERLOC"));
            Assert.That(msg.Header.GetString(Tags.SenderCompID), Is.EqualTo("TARGET"));
            Assert.That(msg.Header.GetString(Tags.SenderSubID), Is.EqualTo("TARGETSUB"));
            Assert.That(msg.Header.GetString(Tags.SenderLocationID), Is.EqualTo("TARGETLOC"));
        }

        [Test]
        public void TestGetSetSessionId()
        {
            SessionID sessionId = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "SENDERLOC", "TARGET", "TARGETSUB", "TARGETLOC");
            Message msg = new Message();

            msg.SetSessionID(sessionId);

            Assert.That(msg.Header.GetString(Tags.BeginString), Is.EqualTo("FIX.4.2"));
            Assert.That(msg.Header.GetString(Tags.SenderCompID), Is.EqualTo("SENDER"));
            Assert.That(msg.Header.GetString(Tags.SenderSubID), Is.EqualTo("SENDERSUB"));
            Assert.That(msg.Header.GetString(Tags.SenderLocationID), Is.EqualTo("SENDERLOC"));
            Assert.That(msg.Header.GetString(Tags.TargetCompID), Is.EqualTo("TARGET"));
            Assert.That(msg.Header.GetString(Tags.TargetSubID), Is.EqualTo("TARGETSUB"));
            Assert.That(msg.Header.GetString(Tags.TargetLocationID), Is.EqualTo("TARGETLOC"));

            SessionID getSessionId = msg.GetSessionID(msg);
            Assert.That(getSessionId.BeginString, Is.EqualTo("FIX.4.2"));
            Assert.That(getSessionId.SenderCompID, Is.EqualTo("SENDER"));
            Assert.That(getSessionId.SenderSubID, Is.EqualTo("SENDERSUB"));
            Assert.That(getSessionId.SenderLocationID, Is.EqualTo("SENDERLOC"));
            Assert.That(getSessionId.TargetCompID, Is.EqualTo("TARGET"));
            Assert.That(getSessionId.TargetSubID, Is.EqualTo("TARGETSUB"));
            Assert.That(getSessionId.TargetLocationID, Is.EqualTo("TARGETLOC"));

            ////
            sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
            msg = new Message();

            msg.SetSessionID(sessionId);

            Assert.That(msg.Header.GetString(Tags.BeginString), Is.EqualTo("FIX.4.2"));
            Assert.That(msg.Header.GetString(Tags.SenderCompID), Is.EqualTo("SENDER"));
            Assert.That(msg.Header.IsSetField(Tags.SenderSubID), Is.False);
            Assert.That(msg.Header.IsSetField(Tags.SenderLocationID), Is.False);
            Assert.That(msg.Header.GetString(Tags.TargetCompID), Is.EqualTo("TARGET"));
            Assert.That(msg.Header.IsSetField(Tags.TargetSubID), Is.False);
            Assert.That(msg.Header.IsSetField(Tags.TargetLocationID), Is.False);

            getSessionId = msg.GetSessionID(msg);
            Assert.That(getSessionId.BeginString, Is.EqualTo("FIX.4.2"));
            Assert.That(getSessionId.SenderCompID, Is.EqualTo("SENDER"));
            Assert.That(getSessionId.SenderSubID, Is.EqualTo(""));
            Assert.That(getSessionId.SenderLocationID, Is.EqualTo(""));
            Assert.That(getSessionId.TargetCompID, Is.EqualTo("TARGET"));
            Assert.That(getSessionId.TargetSubID, Is.EqualTo(""));
            Assert.That(getSessionId.TargetLocationID, Is.EqualTo(""));
        }

        [Test]
        public void GetMsgTypeTest() {
            string msgStr = ("8=FIX.4.4|9=104|35=W|34=3|49=sender|52=20110909-09:09:09.999|56=target"
                             + "55=sym|268=1|269=0|272=20111012|273=22:15:30.444|10=19|").Replace('|', Message.SOH);
            Assert.AreEqual("W", Message.GetMsgType(msgStr));

            // invalid 35 value, let it ride
            string msgStr2 = ("8=FIX.4.4|9=68|35=*|34=3|49=sender|52=20110909-09:09:09.999|56=target"
                              + "55=sym|268=0|10=9|").Replace('|', Message.SOH);
            Assert.AreEqual("*", Message.GetMsgType(msgStr2));
        }

        [Test]
        public void RepeatingGroup_DelimiterFieldFirst()
        {
            QuickFix.FIX44.MarketDataRequest msg = new();
            msg.MDReqID = new MDReqID("fooMdReqID");
            msg.SubscriptionRequestType = new SubscriptionRequestType('1');
            msg.MarketDepth = new MarketDepth(0);

            // this group is irrelevant to the test, but it's required in the message
            QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup entryTypesGroup = new();
            entryTypesGroup.MDEntryType = new MDEntryType('0');
            msg.AddGroup(entryTypesGroup);
            entryTypesGroup.MDEntryType = new MDEntryType('1');
            msg.AddGroup(entryTypesGroup);

            QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup symGroup = new();
            symGroup.Symbol = new Symbol("FOO1");
            symGroup.SecurityID = new SecurityID("secid1");
            msg.AddGroup(symGroup);
            symGroup.Symbol = new Symbol("FOO2");
            symGroup.SecurityID = new SecurityID("secid2");
            msg.AddGroup(symGroup);

            string msgString = msg.ConstructString();
            string expected = "146=2|55=FOO1|48=secid1|55=FOO2|48=secid2|".Replace('|', Message.SOH);

            StringAssert.Contains(expected, msgString);
        }

        [Test]
        public void RepeatingGroup_FieldOrder()
        {
            QuickFix.FIX44.MarketDataRequest msg = new();
            msg.MDReqID = new MDReqID("fooMdReqID");
            msg.SubscriptionRequestType = new SubscriptionRequestType('1');
            msg.MarketDepth = new MarketDepth(0);

            // this group is irrelevant to the test, but it's required in the message
            QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup entryTypesGroup = new();
            entryTypesGroup.MDEntryType = new MDEntryType('0');
            msg.AddGroup(entryTypesGroup);
            entryTypesGroup.MDEntryType = new MDEntryType('1');
            msg.AddGroup(entryTypesGroup);

            QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup symGroup = new();
            // spec order of fields is 55,65,48,22
            symGroup.Symbol = new Symbol("FOO1");
            symGroup.SymbolSfx = new SymbolSfx("sfx1");
            symGroup.SecurityID = new SecurityID("secid1");
            symGroup.SecurityIDSource = new SecurityIDSource("src1");
            msg.AddGroup(symGroup);
            symGroup.Symbol = new Symbol("FOO2");
            symGroup.SymbolSfx = new SymbolSfx("sfx2");
            symGroup.SecurityID = new SecurityID("secid2");
            symGroup.SecurityIDSource = new SecurityIDSource("src2");
            msg.AddGroup(symGroup);

            string msgString = msg.ConstructString();
            string expected = "146=2|55=FOO1|65=sfx1|48=secid1|22=src1|55=FOO2|65=sfx2|48=secid2|22=src2|"
                .Replace('|', Message.SOH);

            StringAssert.Contains(expected, msgString);
        }

        [Test]
        public void ConstructString_FIX50()
        {
            QuickFix.FIX50.News msg = new();
            msg.Headline = new Headline("FOO");

            StringAssert.StartsWith("8=FIXT.1.1" + Message.SOH, msg.ConstructString());
        }

        [Test]
        public void RepeatingGroup_SubgroupCounterTagAppearsOnlyOnce()
        {
            // issue #11 bug, as reported by karabiberoglu's further-down post

            QuickFix.FIX44.CollateralInquiry ci = new();
            ci.CollInquiryID = new CollInquiryID("CollateralInquiry");

            // group
            QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup noParty = new();
            noParty.PartyID = new PartyID("ABC");
            noParty.PartyIDSource = new PartyIDSource(PartyIDSource.PROPRIETARY_CUSTOM_CODE);
            noParty.PartyRole = new PartyRole(PartyRole.CLEARING_FIRM);

            // group in group
            QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup noPartySub = new();
            noPartySub.PartySubID = new PartySubID("subABC");
            noPartySub.PartySubIDType = new PartySubIDType(PartySubIDType.FIRM);
            noParty.AddGroup(noPartySub);
            noPartySub.PartySubID = new PartySubID("subDEF");
            noPartySub.PartySubIDType = new PartySubIDType(PartySubIDType.LOCATION);
            noParty.AddGroup(noPartySub);

            ci.AddGroup(noParty);

            string msgString = ci.ConstructString();
            string expected = String.Join(Message.SOH, new string[] {
                "909=CollateralInquiry", // top-level fields (non-header)
                "453=1", //NoPartyIDs
                    "448=ABC","447=D","452=4",
                    "802=2", //NoPartySubIDs
                        "523=subABC","803=1",
                        "523=subDEF","803=31",
                "10="
            });

            //Console.WriteLine(ci.ToString());
            StringAssert.Contains(expected, msgString);
        }

        [Test]
        public void Issue56_GetGroup_by_tag_and_return()
        {
            // setup
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");

            string msgStr = ("8=FIX.4.2|9=87|35=B|34=3|49=CLIENT1|52=20111012-22:15:55.474|56=EXECUTOR|"
                             + "148=AAAAAAA|33=2|58=L1|58=L2|10=016|").Replace('|', Message.SOH);
            QuickFix.FIX42.News msg = new QuickFix.FIX42.News();
            msg.FromString(msgStr, false, dd, dd, _defaultMsgFactory);
            Assert.AreEqual(2, msg.GroupCount(Tags.LinesOfText)); // for sanity

            // the test
            var grp1 = msg.GetGroup(1, Tags.LinesOfText);
            Assert.IsInstanceOf<QuickFix.FIX42.News.LinesOfTextGroup>(grp1);
            Assert.AreEqual("L1", (grp1 as QuickFix.FIX42.News.LinesOfTextGroup)!.Text.Value);

            var grp2 = msg.GetGroup(2, Tags.LinesOfText);
            Assert.IsInstanceOf<QuickFix.FIX42.News.LinesOfTextGroup>(grp2);
            Assert.AreEqual("L2", (grp2 as QuickFix.FIX42.News.LinesOfTextGroup)!.Text.Value);
        }

        [Test]
        public void Issue56_GetGroup_by_reference()
        {
            // setup
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");

            string msgStr = ("8=FIX.4.2|9=87|35=B|34=3|49=CLIENT1|52=20111012-22:15:55.474|56=EXECUTOR|"
                             + "148=AAAAAAA|33=2|58=L1|58=L2|10=016|").Replace('|', Message.SOH);
            QuickFix.FIX42.News msg = new QuickFix.FIX42.News();
            msg.FromString(msgStr, false, dd, dd, _defaultMsgFactory);
            Assert.AreEqual(2, msg.GroupCount(Tags.LinesOfText)); // for sanity

            // the test
            QuickFix.FIX42.News.LinesOfTextGroup grp = new QuickFix.FIX42.News.LinesOfTextGroup(); // for return value

            msg.GetGroup(1, grp);
            Assert.AreEqual("L1", grp.Text.Value);

            msg.GetGroup(2, grp);
            Assert.AreEqual("L2", grp.Text.Value);
        }

        [Test]
        public void MissingDelimiterField()
        {
            // issue 101

            QuickFix.DataDictionary.DataDictionary dd = new();
            dd.LoadFIXSpec("FIX44");

            // message is missing 703
            string msgStr = ("8=FIX.4.4|9=230|35=AP|34=3|49=XXXXX|52=20120731-14:06:37.848|56=FixKevindemo"
                             + "1=20050500001|55=EURUSD|453=0|581=1|702=1|704=0|705=20000|710=634792896000000000|715=20120802"
                             + "721=P-DEA30E1PHC0IW7V|730=1.22608|731=1|734=1.22608|753=1|708=20000|10=030|")
                .Replace('|', Message.SOH);

            QuickFix.FIX44.PositionReport msg = new();

            GroupDelimiterTagException ex =
                Assert.Throws<GroupDelimiterTagException>(delegate { msg.FromString(msgStr, true, dd, dd, _defaultMsgFactory); })!;
            Assert.AreEqual(702, ex.Field);
            Assert.AreEqual("Group 702's first entry does not start with delimiter 703", ex.Message);
        }

        [Test]
        public void DateOnlyTimeOnlyConvertProblem()
        {
            // issue 135

            QuickFix.DataDictionary.DataDictionary dd = new();
            dd.LoadFIXSpec("FIX44");

            string msgStr = ("8=FIX.4.4|9=332|35=W|34=2|49=MA|52=20121024-12:21:42.170|56=xxxx|"
                             + "22=4|48=BE0932900518|55=[N/A]|262=1b145288-9c9a-4911-a084-7341c69d3e6b|762=EURO_EUR|268=2|"
                             + "269=0|270=97.625|15=EUR|271=1246000|272=20121024|273=07:30:47|276=I|282=BEARGB21XXX|299=15478575|"
                             + "269=1|270=108.08|15=EUR|271=884000|272=20121024|273=07:30:47|276=I|282=BEARGB21XXX|299=15467902|10=77|")
                .Replace('|', Message.SOH);

            QuickFix.FIX44.MarketDataSnapshotFullRefresh msg = new();

            msg.FromString(msgStr, true, dd, dd, _defaultMsgFactory);
            QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup gentry1 = new();
            msg.GetGroup(1, gentry1);
            Assert.AreEqual(new DateTime(2012, 10, 24), gentry1.MDEntryDate.Value);
            Assert.AreEqual(new DateTime(2012, 10, 24, 7, 30, 47).TimeOfDay, gentry1.MDEntryTime.Value.TimeOfDay);
            Assert.AreEqual(new DateTime(2012, 10, 24, 7, 30, 47), gentry1.MDEntryDate.Value + gentry1.MDEntryTime.Value.TimeOfDay);
        }

        [Test]
        public void SendDateOnlyTimeOnlyConvertProblem()
        {
            // issue 135
            QuickFix.FIX44.MarketDataSnapshotFullRefresh msg = new();
            msg.MDReqID = new MDReqID("1b145288-9c9a-4911-a084-7341c69d3e6b");
            msg.Symbol = new Symbol("[N/A]");
            msg.SecurityIDSource = new SecurityIDSource(SecurityIDSource.ISIN_NUMBER);
            msg.SecurityID = new SecurityID("BE0932900518");
            msg.SecuritySubType = new SecuritySubType("EURO_EUR");
            msg.NoMDEntries = new NoMDEntries(2);
            QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup grp = new();
            grp.MDEntryType = new MDEntryType(MDEntryType.BID);
            grp.MDEntryPx = new MDEntryPx((decimal)97.625);
            grp.Currency = new Currency("EUR");
            grp.MDEntrySize = new MDEntrySize(1246000);
            grp.MDEntryDate = new MDEntryDate(new DateTime(2012, 10, 24));
            grp.MDEntryTime = new MDEntryTime(new DateTime(1, 1, 1, 7, 30, 47), false);
            grp.QuoteCondition = new QuoteCondition(QuoteCondition.NON_FIRM);
            grp.MDEntryOriginator = new MDEntryOriginator("BEARGB21XXX");
            grp.QuoteEntryID = new QuoteEntryID("15478575");
            msg.AddGroup(grp);

            grp = new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup();
            grp.MDEntryType = new MDEntryType(MDEntryType.OFFER);
            grp.MDEntryPx = new MDEntryPx((decimal)108.08);
            grp.Currency = new Currency("EUR");
            grp.MDEntrySize = new MDEntrySize(884000);
            grp.MDEntryDate = new MDEntryDate(new DateTime(2012, 10, 24));
            grp.MDEntryTime = new MDEntryTime(new DateTime(1, 1, 1, 7, 30, 47), false);
            grp.QuoteCondition = new QuoteCondition(QuoteCondition.NON_FIRM);
            grp.MDEntryOriginator = new MDEntryOriginator("BEARGB21XXX");
            grp.QuoteEntryID = new QuoteEntryID("15467902");
            msg.AddGroup(grp);

            string msgString = msg.ConstructString();

            string expected =
                ("35=W|22=4|48=BE0932900518|55=[N/A]|262=1b145288-9c9a-4911-a084-7341c69d3e6b|762=EURO_EUR|268=2|"
                 + "269=0|270=97.625|15=EUR|271=1246000|272=20121024|273=07:30:47|276=I|282=BEARGB21XXX|299=15478575|"
                 + "269=1|270=108.08|15=EUR|271=884000|272=20121024|273=07:30:47|276=I|282=BEARGB21XXX|299=15467902|")
                .Replace('|', Message.SOH);

            StringAssert.Contains(expected, msgString);
        }

        [Test]
        public void MessageHasDecimalWithNoLeadingZero()
        {
            // issue 160
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");

            string msgStr = ("8=FIX.4.4|9=122|35=8|34=2|49=sender|52=20121024-12:21:42.170|56=target|"
                             + "37=orderid|17=execid|150=0|39=0|"
                             + "55=ibm|228=.23|" // Instrument component; 228 is a float type in the spec
                             + "54=1|151=1|14=1|6=1|10=45|").Replace('|', Message.SOH);

            QuickFix.FIX44.ExecutionReport msg = new QuickFix.FIX44.ExecutionReport();
            msg.FromString(msgStr, true, dd, dd, _defaultMsgFactory);

            Assert.AreEqual(0.23, msg.Factor.Value);
        }

        [Test]
        public void IsAdmin_IsApp()
        {
            // issue 173
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX42");

            string newsStr = "8=FIX4.2|9=5|35=B|10=133|".Replace('|', Message.SOH);
            QuickFix.FIX42.News news = new QuickFix.FIX42.News();
            news.FromString(newsStr, true, dd, dd, _defaultMsgFactory);

            string hbStr = "8=FIX.4.2|9=16|35=0|34=3|49=TW|10=1|".Replace('|', Message.SOH);
            QuickFix.FIX42.Heartbeat heartbeat = new QuickFix.FIX42.Heartbeat();
            heartbeat.FromString(hbStr, true, dd, dd, _defaultMsgFactory);

            Assert.False(news.IsAdmin());
            Assert.True(news.IsApp());

            Assert.True(heartbeat.IsAdmin());
            Assert.False(heartbeat.IsApp());
        }

        [Test]
        public void TripleNestedGroups_Issue95()
        {
            // Parser screws up on triple-nested groups.  Contributes to ResendRequest failures.
            string msgStr = ("8=FIX.4.4|9=999|35=R|34=6|49=sendercompid|52=20130225-10:44:59.149|56=targetcompid|"
                             + "131=quotereqid|"
                             + "146=1|" // NoRelatedSym
                             + "55=ABC|65=CD|48=securityid|22=1|" // group
                             + "711=1|" // NoUnderlyings
                             + "311=underlyingsymbol|312=WI|309=underlyingsecurityid|305=1|"
                             + "10=999|").Replace('|', Message.SOH);

            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");

            Message msg = new Message();
            msg.FromString(msgStr, false, dd, dd, _defaultMsgFactory);

            // make sure no fields were dropped in parsing
            Assert.AreEqual(msgStr.Length, msg.ConstructString().Length);

            // make sure repeating groups are not rearranged
            // 1 level deep
            StringAssert.Contains("55=ABC|65=CD|48=securityid|22=1|".Replace('|', Message.SOH), msg.ConstructString());
            // 2 levels deep
            StringAssert.Contains(
                "311=underlyingsymbol|312=WI|309=underlyingsecurityid|305=1|".Replace('|', Message.SOH),
                msg.ConstructString());
        }

        [Test]
        public void SetFieldsTest()
        {
            var message = new Message();
            var allocId = new AllocID("123456");
            var allocAccount = new AllocAccount("QuickFixAccount");
            var allocAccountType = new AllocAccountType(AllocAccountType.HOUSE_TRADER);
            message.SetFields(new IField[] { allocAccount, allocAccountType, allocId });

            Assert.AreEqual(true, message.IsSetField(Tags.AllocID));
            Assert.AreEqual("123456", message.GetString(Tags.AllocID));

            Assert.AreEqual(true, message.IsSetField(Tags.AllocAccount));
            Assert.AreEqual("QuickFixAccount", message.GetString(Tags.AllocAccount));

            Assert.AreEqual(true, message.IsSetField(Tags.AllocAccountType));
            Assert.AreEqual(AllocAccountType.HOUSE_TRADER, message.GetInt(Tags.AllocAccountType));
        }

        [Test]
        public void ChecksumIsLastFieldOfTrailer()
        {
            // issue 473
            QuickFix.FIX42.News msg = new QuickFix.FIX42.News(new Headline("foobar"));
            msg.LinesOfText = new LinesOfText(0);

            msg.Trailer.SetField(new Signature("woot"));
            msg.Trailer.SetField(new SignatureLength(4));

            string foo = msg.ConstructString().Replace(Message.SOH, '|');
            StringAssert.EndsWith("|10=099|", foo);
        }

        [Test]
        [Category("JSON")]
        public void JsonNestedRepeatingGroupParseGroupTest()
        {
            // Given the following string in FIX JSON Encoding:
            string json = @"
                {
                    ""Header"": {
                        ""BeginString"":""FIX.4.4"",
                        ""MsgSeqNum"":""360"",
                        ""MsgType"":""8"",
                        ""SenderCompID"":""BLPTSOX"",
                        ""SendingTime"":""20130321-15:21:23"",
                        ""TargetCompID"":""THINKTSOX""
                    },
                    ""Body"": {
                        ""31337"":""custom body field"",
                        ""AvgPx"":""122.255"",
                        ""ClOrdID"":""61101189"",
                        ""CumQty"":""1990000"",
                        ""ExecID"":""VCON:20130321:50018:5:12"",
                        ""LastPx"":""122.255"",
                        ""LastQty"":""1990000"",
                        ""OrderID"":""116"",
                        ""OrderQty"":""1990000"",
                        ""OrdStatus"":""2"",
                        ""Side"":""1"",
                        ""Symbol"":""[N/A]"",
                        ""TransactTime"":""20130321-15:21:23"",
                        ""ExecType"":""F"",
                        ""LeavesQty"":""0"",
                        ""NoPartyIDs"": [
                            {
                                ""PartyIDSource"":""D"",
                                ""PartyID"":""OHAI"",
                                ""PartyRole"":""1"",
                                ""NoPartySubIDs"": [
                                    {
                                        ""PartySubID"":""14"",
                                        ""PartySubIDType"":""4"",
                                        ""31338"":""custom group field""
                                    }
                                ]
                            },
                            { ""PartyIDSource"":""D"", ""PartyID"":""TFOLIO:6804469"", ""PartyRole"":""12"" },
                            { ""PartyIDSource"":""D"", ""PartyID"":""TFOLIO"",         ""PartyRole"":""11"" },
                            { ""PartyIDSource"":""D"", ""PartyID"":""THINKFOLIO LTD"", ""PartyRole"":""13"" },
                            { ""PartyIDSource"":""D"", ""PartyID"":""SXT"",            ""PartyRole"":""16"" },
                            { ""PartyIDSource"":""D"", ""PartyID"":""TFOLIO:6804469"", ""PartyRole"":""36"" }
                        ]
                    },
                    ""Trailer"": {
                    }
                }
            ";

            // When the JSON is parsed into a QuickFIX Message
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            var msg = new Message();
            msg.FromJson(json, true, dd, dd, _defaultMsgFactory);
            //TestContext.Out.WriteLine(msg.ToString().Replace(Message.SOH, "|"));

            // Then the Header of the Message should contain:
            Assert.That(msg.Header.GetString(Tags.BeginString), Is.EqualTo("FIX.4.4"));
            Assert.That(msg.Header.GetString(Tags.MsgSeqNum),   Is.EqualTo("360"));
            Assert.That(msg.Header.GetString(Tags.BodyLength),  Is.EqualTo("446"));

            // And the Body of the Message should contain:
            Assert.That(msg.GetString(31337), Is.EqualTo("custom body field"));
            Assert.That(msg.GetString(Tags.AvgPx), Is.EqualTo("122.255"));
            Assert.That(msg.GetString(Tags.Symbol), Is.EqualTo("[N/A]"));
            Assert.That(msg.GetString(Tags.OrdStatus), Is.EqualTo("2"));
            Assert.That(msg.GetString(Tags.TransactTime), Is.EqualTo("20130321-15:21:23"));

            // And the NoPartyIDs Group should contain:
            Assert.That(msg.GetString(Tags.NoPartyIDs), Is.EqualTo("6"));

            var noPartyGrp = msg.GetGroup(1, Tags.NoPartyIDs);
            Assert.That(noPartyGrp.GetString(Tags.PartyID), Is.EqualTo("OHAI"));
            Assert.That(noPartyGrp.GetString(Tags.PartyIDSource), Is.EqualTo("D"));
            Assert.That(noPartyGrp.GetString(Tags.NoPartySubIDs), Is.EqualTo("1"));

            var noPartySubGrp = noPartyGrp.GetGroup(1, Tags.NoPartySubIDs);
            Assert.That(noPartySubGrp.GetString(Tags.PartySubID), Is.EqualTo("14"));
            Assert.That(noPartySubGrp.GetString(Tags.PartySubIDType), Is.EqualTo("4"));
            Assert.That(noPartySubGrp.GetString(31338), Is.EqualTo("custom group field"));
        }

        private QuickFix.FIX44.News CreateStringResultInput() {
            QuickFix.FIX44.News msg = new();
            msg.Header.SetField(new BeginString(QuickFix.FixValues.BeginString.FIX44));
            msg.Header.SetField(new MsgType("B"));
            msg.SetField(new Headline("myHeadline"));

            QuickFix.FIX44.News.LinesOfTextGroup grp1 = new() { Text = new Text("line1") };
            QuickFix.FIX44.News.LinesOfTextGroup grp2 = new() { Text = new Text("line2") };
            msg.AddGroup(grp1);
            msg.AddGroup(grp2);
            return msg;
        }

        [Test]
        public void ToStringTest() {
            QuickFix.FIX44.News msg = CreateStringResultInput();
            // ToString() does not add BodyLength or CheckSum -- it does not change object state
            string expected = "8=FIX.4.4|35=B|148=myHeadline|33=2|58=line1|58=line2|";
            Assert.AreEqual(expected, msg.ToString().Replace(Message.SOH, '|'));
        }

        [Test]
        public void ConstructStringTest() {
            QuickFix.FIX44.News msg = CreateStringResultInput();
            // ConstructString() adds BodyLength and CheckSum
            string expected = "8=FIX.4.4|9=43|35=B|148=myHeadline|33=2|58=line1|58=line2|10=161|";
            Assert.AreEqual(expected, msg.ConstructString().Replace(Message.SOH, '|'));

            // the object state is changed
            Assert.AreEqual(expected, msg.ToString().Replace(Message.SOH, '|'));
        }
    }
}
