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
                msg.FromString(str1, true, null, null);
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
                msg.FromString(str1, true, null, null);
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
                msg.FromString(str1, true, null, null);
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
            msg.FromString(data, false, dd, dd);

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
            msg.FromString(data, false, dd, dd);

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
            nos.FromString(data, false, dd, dd);
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
            n.FromString(s, true, dd, dd);

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

            n.FromString(s, true, dd, dd);
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
                msg.FromString(str1, true, null, null);
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
    }
}
