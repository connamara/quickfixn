using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{
    [TestFixture]
    public class MessageTests
    {
        private IMessageFactory _defaultMsgFactory = new DefaultMessageFactory();

        [Test]
        public void IdentifyTypeTest()
        {
            string msg1 = "\x01" + "35=A\x01";
            Assert.That(Message.IdentifyType(msg1).Obj, Is.EqualTo(new MsgType("A").Obj));
            string msg2 = "a;sldkfjadls;k\x01" + "35=A\x01" + "a;sldkfja;sdlfk";
            Assert.That(Message.IdentifyType(msg2).Obj, Is.EqualTo(new MsgType("A").Obj));
            string msg3 = "8=FIX4.2\x01" + "9=12\x01\x01" + "35=B\x01" + "10=031\x01";
            Assert.That(Message.IdentifyType(msg3).Obj, Is.EqualTo(new MsgType("B").Obj));

            // no 35
            string err1 = String.Join(Message.SOH, new string[] { "8=FIX.4.4", "49=Sender", "" });
            Assert.Throws<MessageParseError>(delegate { Message.IdentifyType(err1); });
            // no SOH at end of 35
            string err2 = String.Join(Message.SOH, new string[] { "8=FIX.4.4", "35=A" });
            Assert.Throws<MessageParseError>(delegate { Message.IdentifyType(err1); });
        }

        [Test]
        public void ExtractStringTest()
        {
            string str1 = "8=FIX.4.2\x01" + "9=46\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01";
            int pos = 0;
            StringField sf1 = Message.ExtractField(str1, ref pos);
            Assert.That(pos, Is.EqualTo(10));
            Assert.That(sf1.Tag, Is.EqualTo(8));
            Assert.That(sf1.Obj, Is.EqualTo("FIX.4.2"));
            StringField sf2 = Message.ExtractField(str1, ref pos);
            Assert.That(pos, Is.EqualTo(15));
            Assert.That(sf2.Tag, Is.EqualTo(9));
            Assert.That(sf2.Obj, Is.EqualTo("46"));
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
            string str1 = "8=FIX.4.2\x01" + "9=45\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" +
                "52=20000426-12:05:06\x01" + "56=ISLD\x01";

            int chksum = 0;
            foreach (char c in str1)
                chksum += (int)c;
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
            string str1 = "8=FIX.4.2\x01" + "9=55\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" +
                "52=20000426-12:05:06\x01" + "56=ISLD\x01" + "1=acct123\x01" + "10=123\x01";
            Message msg = new Message();
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
            Assert.That(f1.Obj, Is.EqualTo("FIX.4.2"));
            Assert.That(f2.Obj, Is.EqualTo("55"));
            Assert.That(f3.Obj, Is.EqualTo("0"));
            Assert.That(f4.Obj, Is.EqualTo("3"));
            Assert.That(f5.Obj, Is.EqualTo("TW"));
            Assert.That(f6.Obj, Is.EqualTo("20000426-12:05:06"));
            Assert.That(f7.Obj, Is.EqualTo("ISLD"));
            Assert.That(f8.Obj, Is.EqualTo("123"));
            Assert.That(f9.Obj, Is.EqualTo("acct123"));
        }

        [Test]
        public void ToStringTest()
        {
            string str1 = "8=FIX.4.2\x01" + "9=55\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" +
                "52=20000426-12:05:06\x01" + "56=ISLD\x01" + "1=acct123\x01" + "10=123\x01";
            Message msg = new Message();
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
            Assert.That(f1.Obj, Is.EqualTo("FIX.4.2"));
            Assert.That(f2.Obj, Is.EqualTo("55"));
            Assert.That(f3.Obj, Is.EqualTo("0"));
            Assert.That(f4.Obj, Is.EqualTo("3"));
            Assert.That(f5.Obj, Is.EqualTo("TW"));
            Assert.That(f6.Obj, Is.EqualTo("20000426-12:05:06"));
            Assert.That(f7.Obj, Is.EqualTo("ISLD"));
            Assert.That(f8.Obj, Is.EqualTo("123"));
            Assert.That(f9.Obj, Is.EqualTo("acct123"));
            string raw = msg.ToString();
            Assert.That(raw, Is.EqualTo(str1));
        }

        [Test]
        public void ToStringFieldOrder()
        {
            Message msg = new Message();
            msg.Header.SetField(new QuickFix.Fields.MsgType("A"));
            msg.Header.SetField(new QuickFix.Fields.BeginString("FIX.4.2"));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID("SENDER"));
            msg.Header.SetField(new QuickFix.Fields.TargetCompID("TARGET"));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(42));
            string expect = "8=FIX.4.2\x01" + "9=31\x01" + "35=A\x01" + "34=42\x01" + "49=SENDER\x01" + "56=TARGET\x01" + "10=200\x01";
            Assert.That(msg.ToString(), Is.EqualTo(expect));
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
            Message msg = new Message("8=FIX.4.2\x01" + "9=55\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" + "52=20000426-12:05:06\x01" + "56=ISLD\x01" + "1=acct123\x01" + "10=123\x01");

            int numHeaderFields = 0;
            foreach (KeyValuePair<int, QuickFix.Fields.IField> kvp in msg.Header)
                ++numHeaderFields;
            Assert.AreEqual(7, numHeaderFields);

            int numTrailerFields = 0;
            foreach (KeyValuePair<int, QuickFix.Fields.IField> kvp in msg.Trailer)
                ++numTrailerFields;
            Assert.AreEqual(1, numTrailerFields);

            int numBodyFields = 0;
            foreach (KeyValuePair<int, QuickFix.Fields.IField> kvp in msg)
                ++numBodyFields;
            Assert.AreEqual(1, numBodyFields);
        }

        [Test]
        public void RepeatedTagDetection()
        {
            Message msg = new Message("8=FIX.4.2\x01" + "9=72\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" + "49=BOGUS\x01" + "52=20000426-12:05:06\x01" + "56=ISLD\x01" + "1=acct123\x01" + "1=bogus\x01" + "10=052\x01" + "10=000\x01");
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
        public void RepeatingGroupParseGroupTest()
        {
            String data = "8=FIX.4.4\x01" + "9=309\x01" + "35=8\x01" + "49=ASX\x01" + "56=CL1_FIX44\x01" + "34=4\x01" + "52=20060324-01:05:58\x01" + ""
                + "17=X-B-WOW-1494E9A0:58BD3F9D-1109\x01" + "150=D\x01" + "39=0\x01" + "11=184271\x01" + "38=200\x01" + "198=1494E9A0:58BD3F9D\x01" + ""
                + "526=4324\x01" + "37=B-WOW-1494E9A0:58BD3F9D\x01" + "55=WOW\x01" + "54=1\x01" + "151=200\x01" + "14=0\x01" + "40=2\x01" + "44=15\x01" + "59=1\x01" + "6=0\x01" + ""
                + "453=3\x01"
                + "448=AAA35791\x01" + "447=D\x01" + "452=3\x01" + "802=1\x01" + "523=OHAI123\x01"
                + "448=8\x01" + "447=D\x01" + "452=4\x01" + "448=FIX11\x01" + "447=D\x01" + "452=36\x01" + ""
                + "60=20060320-03:34:29\x01" + "10=169\x01" + "";
            var msg = new QuickFix.FIX44.ExecutionReport();
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            msg.FromString(data, false, dd, dd, _defaultMsgFactory);

            var grp = msg.GetGroup(1, Tags.NoPartyIDs);
            Assert.That(grp.GetString(Tags.PartyID), Is.EqualTo("AAA35791"));
            grp = msg.GetGroup(3, Tags.NoPartyIDs);
            Assert.That(grp.GetString(Tags.PartyID), Is.EqualTo("FIX11"));
        }

        [Test]
        public void NestedRepeatingGroupParseGroupTest()
        {
            String data = "8=FIX.4.4\x01" + "9=309\x01" + "35=8\x01" + "49=ASX\x01" + "56=CL1_FIX44\x01" + "34=4\x01" + "52=20060324-01:05:58\x01" + ""
                + "17=X-B-WOW-1494E9A0:58BD3F9D-1109\x01" + "150=D\x01" + "39=0\x01" + "11=184271\x01" + "38=200\x01" + "198=1494E9A0:58BD3F9D\x01" + ""
                + "526=4324\x01" + "37=B-WOW-1494E9A0:58BD3F9D\x01" + "55=WOW\x01" + "54=1\x01" + "151=200\x01" + "14=0\x01" + "40=2\x01" + "44=15\x01" + "59=1\x01" + "6=0\x01" + ""
                + "453=3\x01"
                  + "448=AAA35791\x01" + "447=D\x01" + "452=3\x01" + "802=1\x01" + "523=OHAI123\x01"
                  + "448=8\x01" + "447=D\x01" + "452=4\x01"
                  + "448=FIX11\x01" + "447=D\x01" + "452=36\x01" + ""
                + "60=20060320-03:34:29\x01" + "10=169\x01" + "";
            var msg = new QuickFix.FIX44.ExecutionReport();
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            msg.FromString(data, false, dd, dd, _defaultMsgFactory);

            var subGrp = msg.GetGroup(1, Tags.NoPartyIDs).GetGroup(1, Tags.NoPartySubIDs);
            Assert.That(subGrp.GetString(Tags.PartySubID), Is.EqualTo("OHAI123"));
        }



        [Test]
        public void HeaderGroupParsingTest()
        {
            string data = "8=FIX.4.4\x01" + "9=40\x01" + "35=A\x01"
                + "627=2\x01" + "628=FOO\x01" + "628=BAR\x01"
                + "98=0\x01" + "384=2\x01" + "372=D\x01" + "385=R\x01" + "372=8\x01" + "385=S\x01" + "10=228\x01";

            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
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
            string m1 = "8=FIX4.2\x01" + "9999=99999\x01";
            string m2 = "987=pants\x01xxxxxxxxxxxxxxxxxxxxxx";

            Assert.AreEqual("FIX4.2", Message.ExtractBeginString(m1));
            Assert.AreEqual("pants", Message.ExtractBeginString(m2));
        }

        [Test]
        public void ExtractFieldTypes()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX42.xml");

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string s = "8=FIX.4.2\x01" + "9=137\x01" + "35=D\x01" + "34=3\x01" + "49=CLIENT1\x01"
                + "52=20110901-18:41:56.917\x01" + "56=EXECUTOR\x01" + "11=asdf\x01" + "21=1\x01"
                + "38=5.5\x01" + "40=1\x01" + "54=1\x01" + "55=ibm\x01" + "59=1\x01" + "60=20110901-13:41:31.804\x01"
                + "377=Y\x01" + "201=1\x01"
                + "10=63\x01";
            n.FromString(s, true, dd, dd, _defaultMsgFactory);

            // string values are good?
            Assert.AreEqual("Y", n.SolicitedFlag.ToString()); //bool, 377
            Assert.AreEqual("1", n.Side.ToString()); //char, 54
            Assert.AreEqual("20110901-13:41:31.804", n.TransactTime.ToString()); //datetime, 60
            Assert.AreEqual("5.5", n.OrderQty.ToString()); //decimal, 38
            Assert.AreEqual("1", n.PutOrCall.ToString()); //int, 201
            Assert.AreEqual("asdf", n.ClOrdID.ToString()); //string, 11

            // type-converted values are good?
            Assert.AreEqual(true, n.SolicitedFlag.getValue());
            Assert.AreEqual('1', n.Side.getValue());
            Assert.AreEqual(DateTime.Parse("2011-09-01 13:41:31.804"), n.TransactTime.getValue());
            Assert.AreEqual(5.5m, n.OrderQty.getValue());
            Assert.AreEqual(1, n.PutOrCall.getValue());
            Assert.AreEqual("asdf", n.ClOrdID.getValue());
        }

        [Test]
        public void RepeatingGroup()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX42.xml");

            QuickFix.FIX42.News news = new QuickFix.FIX42.News(new QuickFix.Fields.Headline("Foo headline"));

            QuickFix.FIX42.News.LinesOfTextGroup group1 = new QuickFix.FIX42.News.LinesOfTextGroup();
            group1.Text = new QuickFix.Fields.Text("line1");
            group1.EncodedTextLen = new QuickFix.Fields.EncodedTextLen(3);
            group1.EncodedText = new QuickFix.Fields.EncodedText("aaa");
            news.AddGroup(group1);

            QuickFix.FIX42.News.LinesOfTextGroup group2 = new QuickFix.FIX42.News.LinesOfTextGroup();
            group2.Text = new QuickFix.Fields.Text("line2");
            group2.EncodedText = new QuickFix.Fields.EncodedText("bbb");
            news.AddGroup(group2);

            string raw = news.ToString();

            string nul = "\x01";
            StringAssert.Contains(
                nul + "33=2" + nul + "58=line1" + nul + "354=3" + nul + "355=aaa" + nul + "58=line2" + nul + "355=bbb",
                raw);
        }

        [Test]
        public void RepeatingGroup_ReuseObject()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX42.xml");

            QuickFix.FIX42.News news = new QuickFix.FIX42.News(new QuickFix.Fields.Headline("Foo headline"));

            QuickFix.FIX42.News.LinesOfTextGroup group = new QuickFix.FIX42.News.LinesOfTextGroup();
            group.Text = new QuickFix.Fields.Text("line1");
            news.AddGroup(group);
            group.Text = new QuickFix.Fields.Text("line2");
            news.AddGroup(group);

            string raw = news.ToString();

            string nul = "\x01";
            StringAssert.Contains(
                nul + "33=2" + nul + "58=line1" + nul + "58=line2",
                raw);
        }

        [Test]
        public void FromString_DoNotCorrectCounter()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX42.xml");

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string nul = "\x01";
            string s = "8=FIX.4.2" + nul + "9=148" + nul + "35=D" + nul + "34=2" + nul + "49=TW" + nul + "52=20111011-15:06:23.103" + nul + "56=ISLD" + nul
                + "11=ID" + nul + "21=1" + nul + "40=1" + nul + "54=1" + nul + "38=200.00" + nul + "55=INTC" + nul
                + "386=3" + nul + "336=PRE-OPEN" + nul + "336=AFTER-HOURS" + nul
                + "60=20111011-15:06:23.103" + nul
                + "10=35" + nul;

            n.FromString(s, true, dd, dd, _defaultMsgFactory);
            Assert.AreEqual("386=3", n.NoTradingSessions.toStringField());
            StringAssert.Contains("386=3", n.ToString()); //don't correct it to 2, you bastard
        }

        [Test]
        public void ReverseRoute()
        {
            string str1 = "8=FIX.4.2\x01" + "9=55\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" +
                "52=20000426-12:05:06\x01" + "56=ISLD\x01" + "1=acct123\x01" + "10=123\x01";
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
        public void TestGetSetSessionID()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "SENDERLOC", "TARGET", "TARGETSUB", "TARGETLOC");
            Message msg = new Message();

            msg.SetSessionID(sessionID);

            Assert.That(msg.Header.GetString(Tags.BeginString), Is.EqualTo("FIX.4.2"));
            Assert.That(msg.Header.GetString(Tags.SenderCompID), Is.EqualTo("SENDER"));
            Assert.That(msg.Header.GetString(Tags.SenderSubID), Is.EqualTo("SENDERSUB"));
            Assert.That(msg.Header.GetString(Tags.SenderLocationID), Is.EqualTo("SENDERLOC"));
            Assert.That(msg.Header.GetString(Tags.TargetCompID), Is.EqualTo("TARGET"));
            Assert.That(msg.Header.GetString(Tags.TargetSubID), Is.EqualTo("TARGETSUB"));
            Assert.That(msg.Header.GetString(Tags.TargetLocationID), Is.EqualTo("TARGETLOC"));

            SessionID getSessionID = msg.GetSessionID(msg);
            Assert.That(getSessionID.BeginString, Is.EqualTo("FIX.4.2"));
            Assert.That(getSessionID.SenderCompID, Is.EqualTo("SENDER"));
            Assert.That(getSessionID.SenderSubID, Is.EqualTo("SENDERSUB"));
            Assert.That(getSessionID.SenderLocationID, Is.EqualTo("SENDERLOC"));
            Assert.That(getSessionID.TargetCompID, Is.EqualTo("TARGET"));
            Assert.That(getSessionID.TargetSubID, Is.EqualTo("TARGETSUB"));
            Assert.That(getSessionID.TargetLocationID, Is.EqualTo("TARGETLOC"));

            ////
            sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            msg = new Message();

            msg.SetSessionID(sessionID);

            Assert.That(msg.Header.GetString(Tags.BeginString), Is.EqualTo("FIX.4.2"));
            Assert.That(msg.Header.GetString(Tags.SenderCompID), Is.EqualTo("SENDER"));
            Assert.That(msg.Header.IsSetField(Tags.SenderSubID), Is.False);
            Assert.That(msg.Header.IsSetField(Tags.SenderLocationID), Is.False);
            Assert.That(msg.Header.GetString(Tags.TargetCompID), Is.EqualTo("TARGET"));
            Assert.That(msg.Header.IsSetField(Tags.TargetSubID), Is.False);
            Assert.That(msg.Header.IsSetField(Tags.TargetLocationID), Is.False);

            getSessionID = msg.GetSessionID(msg);
            Assert.That(getSessionID.BeginString, Is.EqualTo("FIX.4.2"));
            Assert.That(getSessionID.SenderCompID, Is.EqualTo("SENDER"));
            Assert.That(getSessionID.SenderSubID, Is.EqualTo(""));
            Assert.That(getSessionID.SenderLocationID, Is.EqualTo(""));
            Assert.That(getSessionID.TargetCompID, Is.EqualTo("TARGET"));
            Assert.That(getSessionID.TargetSubID, Is.EqualTo(""));
            Assert.That(getSessionID.TargetLocationID, Is.EqualTo(""));
        }

        [Test]
        public void GetMsgTypeTest()
        {
            string[] msgFields = { "8=FIX.4.4", "9=104", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012", "273=22:15:30.444", "10=19" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;
            Assert.AreEqual("W", Message.GetMsgType(msgStr));

            // invalid 35 value, let it ride
            string[] msgFields2 = { "8=FIX.4.4", "9=68", "35=*", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=0", "10=9" };
            string msgStr2 = String.Join(Message.SOH, msgFields2) + Message.SOH;
            Assert.AreEqual("*", Message.GetMsgType(msgStr2));
        }

        [Test]
        public void RepeatingGroup_DelimiterFieldFirst()
        {
            QuickFix.FIX44.MarketDataRequest msg = new QuickFix.FIX44.MarketDataRequest();
            msg.MDReqID = new MDReqID("fooMdReqID");
            msg.SubscriptionRequestType = new SubscriptionRequestType('1');
            msg.MarketDepth = new MarketDepth(0);

            // this group is irrelevant to the test, but it's required in the message
            QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup entryTypesGroup = new QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup();
            entryTypesGroup.MDEntryType = new MDEntryType('0');
            msg.AddGroup(entryTypesGroup);
            entryTypesGroup.MDEntryType = new MDEntryType('1');
            msg.AddGroup(entryTypesGroup);

            QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup symGroup = new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup();
            symGroup.Symbol = new Symbol("FOO1");
            symGroup.SecurityID = new SecurityID("secid1");
            msg.AddGroup(symGroup);
            symGroup.Symbol = new Symbol("FOO2");
            symGroup.SecurityID = new SecurityID("secid2");
            msg.AddGroup(symGroup);

            string msgString = msg.ToString();
            string expected = String.Join(Message.SOH, new string[] { "146=2", "55=FOO1", "48=secid1", "55=FOO2", "48=secid2" });

            StringAssert.Contains(expected, msgString);
        }

        [Test]
        public void RepeatingGroup_FieldOrder()
        {
            QuickFix.FIX44.MarketDataRequest msg = new QuickFix.FIX44.MarketDataRequest();
            msg.MDReqID = new MDReqID("fooMdReqID");
            msg.SubscriptionRequestType = new SubscriptionRequestType('1');
            msg.MarketDepth = new MarketDepth(0);

            // this group is irrelevant to the test, but it's required in the message
            QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup entryTypesGroup = new QuickFix.FIX44.MarketDataRequest.NoMDEntryTypesGroup();
            entryTypesGroup.MDEntryType = new MDEntryType('0');
            msg.AddGroup(entryTypesGroup);
            entryTypesGroup.MDEntryType = new MDEntryType('1');
            msg.AddGroup(entryTypesGroup);

            QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup symGroup = new QuickFix.FIX44.MarketDataRequest.NoRelatedSymGroup();
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

            string msgString = msg.ToString();
            string expected = String.Join(Message.SOH, new string[] { "146=2",
                "55=FOO1", "65=sfx1", "48=secid1", "22=src1",
                "55=FOO2", "65=sfx2", "48=secid2", "22=src2",
            });

            StringAssert.Contains(expected, msgString);
        }

        [Test]
        public void ToString_FIX50()
        {
            QuickFix.FIX50.News msg = new QuickFix.FIX50.News();
            msg.Headline = new Headline("FOO");

            StringAssert.StartsWith("8=FIXT.1.1" + Message.SOH, msg.ToString());
        }

        [Test]
        public void RepeatingGroup_SubgroupCounterTagAppearsOnlyOnce()
        {
            // issue #11 bug, as reported by karabiberoglu's further-down post

            QuickFix.FIX44.CollateralInquiry ci = new QuickFix.FIX44.CollateralInquiry();
            ci.CollInquiryID = new QuickFix.Fields.CollInquiryID("CollateralInquiry");

            // group
            QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup noParty = new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup();
            noParty.PartyID = new QuickFix.Fields.PartyID("ABC");
            noParty.PartyIDSource = new QuickFix.Fields.PartyIDSource(QuickFix.Fields.PartyIDSource.PROPRIETARY_CUSTOM_CODE);
            noParty.PartyRole = new QuickFix.Fields.PartyRole(QuickFix.Fields.PartyRole.CLEARING_FIRM);

            // group in group
            QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup noPartySub = new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup();
            noPartySub.PartySubID = new QuickFix.Fields.PartySubID("subABC");
            noPartySub.PartySubIDType = new QuickFix.Fields.PartySubIDType(QuickFix.Fields.PartySubIDType.FIRM);
            noParty.AddGroup(noPartySub);
            noPartySub.PartySubID = new QuickFix.Fields.PartySubID("subDEF");
            noPartySub.PartySubIDType = new QuickFix.Fields.PartySubIDType(QuickFix.Fields.PartySubIDType.LOCATION);
            noParty.AddGroup(noPartySub);

            ci.AddGroup(noParty);

            string msgString = ci.ToString();
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
        public void issue56_GetGroup_type1()
        {
            // boring message construction stuff
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            string[] msgFields = { "8=FIX.4.2", "9=87", "35=B", "34=3", "49=CLIENT1", "52=20111012-22:15:55.474", "56=EXECUTOR", "148=AAAAAAA", "33=2", "58=L1", "58=L2", "10=016" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;
            QuickFix.FIX42.News msg = new QuickFix.FIX42.News();
            msg.FromString(msgStr, false, dd, dd, _defaultMsgFactory);
            Assert.AreEqual(2, msg.GroupCount(Tags.LinesOfText)); // for sanity

            // the test
            var grp1 = msg.GetGroup(1, Tags.LinesOfText);
            Assert.IsInstanceOf<QuickFix.FIX42.News.LinesOfTextGroup>(grp1);
            Assert.AreEqual("L1", (grp1 as QuickFix.FIX42.News.LinesOfTextGroup).Text.Obj);

            var grp2 = msg.GetGroup(2, Tags.LinesOfText);
            Assert.IsInstanceOf<QuickFix.FIX42.News.LinesOfTextGroup>(grp2);
            Assert.AreEqual("L2", (grp2 as QuickFix.FIX42.News.LinesOfTextGroup).Text.Obj);
        }

        [Test]
        public void issue56_GetGroup_type2()
        {
            // boring message construction stuff
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            string[] msgFields = { "8=FIX.4.2", "9=87", "35=B", "34=3", "49=CLIENT1", "52=20111012-22:15:55.474", "56=EXECUTOR", "148=AAAAAAA", "33=2", "58=L1", "58=L2", "10=016" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;
            QuickFix.FIX42.News msg = new QuickFix.FIX42.News();
            msg.FromString(msgStr, false, dd, dd, _defaultMsgFactory);
            Assert.AreEqual(2, msg.GroupCount(Tags.LinesOfText)); // for sanity

            // the test
            QuickFix.FIX42.News.LinesOfTextGroup grp = new QuickFix.FIX42.News.LinesOfTextGroup(); // for return value

            var rv1 = msg.GetGroup(1, grp);
            Assert.AreSame(rv1, grp);
            Assert.IsInstanceOf<QuickFix.FIX42.News.LinesOfTextGroup>(rv1);
            Assert.AreEqual("L1", grp.Text.Obj);

            var rv2 = msg.GetGroup(2, grp);
            Assert.AreSame(rv2, grp);
            Assert.IsInstanceOf<QuickFix.FIX42.News.LinesOfTextGroup>(rv2);
            Assert.AreEqual("L2", grp.Text.Obj);
        }

        [Test]
        public void MissingDelimiterField()
        {
            // issue 101

            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");

            // message is missing 703
            string[] msgFields = { "8=FIX.4.4", "9=230", "35=AP", "34=3", "49=XXXXX", "52=20120731-14:06:37.848", "56=FixKevindemo",
                "1=20050500001", "55=EURUSD", "453=0", "581=1", "702=1", "704=0", "705=20000", "710=634792896000000000", "715=20120802",
                "721=P-DEA30E1PHC0IW7V", "730=1.22608", "731=1", "734=1.22608", "753=1", "708=20000", "10=030"
            };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            QuickFix.FIX44.PositionReport msg = new QuickFix.FIX44.PositionReport();

            QuickFix.GroupDelimiterTagException ex =
                Assert.Throws<QuickFix.GroupDelimiterTagException>(delegate { msg.FromString(msgStr, true, dd, dd, _defaultMsgFactory); });
            Assert.AreEqual(702, ex.Field);
            Assert.AreEqual("Group 702's first entry does not start with delimiter 703", ex.Message);
        }

        [Test]
        public void DateOnlyTimeOnlyConvertProblem()
        {
            // issue 135

            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");

            string[] msgFields = { "8=FIX.4.4", "9=332", "35=W", "34=2", "49=MA", "52=20121024-12:21:42.170", "56=xxxx",
                "22=4", "48=BE0932900518", "55=[N/A]", "262=1b145288-9c9a-4911-a084-7341c69d3e6b", "762=EURO_EUR", "268=2", 
                "269=0", "270=97.625", "15=EUR", "271=1246000", "272=20121024", "273=07:30:47", "276=I", "282=BEARGB21XXX", "299=15478575", 
                "269=1", "270=108.08", "15=EUR", "271=884000", "272=20121024", "273=07:30:47", "276=I", "282=BEARGB21XXX", "299=15467902", "10=77"
            };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            QuickFix.FIX44.MarketDataSnapshotFullRefresh msg = new QuickFix.FIX44.MarketDataSnapshotFullRefresh();

            msg.FromString(msgStr, true, dd, dd, _defaultMsgFactory);
            QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup gentry1 = (QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup)msg.GetGroup(1, new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup());
            Assert.AreEqual(new DateTime(2012, 10, 24), gentry1.MDEntryDate.getValue());
            Assert.AreEqual(new DateTime(2012, 10, 24, 7, 30, 47).TimeOfDay, gentry1.MDEntryTime.getValue().TimeOfDay);
            Assert.AreEqual(new DateTime(2012, 10, 24, 7, 30, 47), gentry1.MDEntryDate.getValue() + gentry1.MDEntryTime.getValue().TimeOfDay);
        }

        [Test]
        public void SendDateOnlyTimeOnlyConvertProblem()
        {
            // issue 135
            QuickFix.FIX44.MarketDataSnapshotFullRefresh msg = new QuickFix.FIX44.MarketDataSnapshotFullRefresh();
            msg.MDReqID = new MDReqID("1b145288-9c9a-4911-a084-7341c69d3e6b");
            msg.Symbol = new Symbol("[N/A]");
            msg.SecurityIDSource = new SecurityIDSource(SecurityIDSource.ISIN_NUMBER);
            msg.SecurityID = new SecurityID("BE0932900518");
            msg.SecuritySubType = new SecuritySubType("EURO_EUR");
            msg.NoMDEntries = new NoMDEntries(2);
            QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup grp =
                new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup();
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

            string msgString = msg.ToString();

            string expected = String.Join(Message.SOH, new string[] { "35=W", "22=4", "48=BE0932900518", "55=[N/A]", "262=1b145288-9c9a-4911-a084-7341c69d3e6b", "762=EURO_EUR", "268=2", 
                "269=0", "270=97.625", "15=EUR", "271=1246000", "272=20121024", "273=07:30:47", "276=I", "282=BEARGB21XXX", "299=15478575", 
                "269=1", "270=108.08", "15=EUR", "271=884000", "272=20121024", "273=07:30:47", "276=I", "282=BEARGB21XXX", "299=15467902"
            });

            StringAssert.Contains(expected, msgString);
        }

    }
}
