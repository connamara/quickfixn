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
        public void IdentifyMsgTypeTest()
        {
            string msg1 = "\x01" + "35=A\x01";
            Assert.That(Message.IdentifyType(msg1).Obj, Is.EqualTo(new MsgType("A").Obj));
            string msg2 = "a;sldkfjadls;k\x01" + "35=A\x01" + "a;sldkfja;sdlfk";
            Assert.That(Message.IdentifyType(msg2).Obj, Is.EqualTo(new MsgType("A").Obj));
            string msg3 = "8=FIX4.2\x01" + "9=12\x01\x01" + "35=B\x01" + "10=031\x01";
            Assert.That(Message.IdentifyType(msg3).Obj, Is.EqualTo(new MsgType("B").Obj));
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
            nos2.AddGroup(grp);
            grp.SetField(new StringField(300, "Dude"));
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
    }
}
