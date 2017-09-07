using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{
    public class MessageTests
    {
        private IMessageFactory _defaultMsgFactory = new DefaultMessageFactory();

        private readonly string specDirectory;
        private readonly string FIX42;
        private readonly string FIX44;

        public MessageTests()
        {
            specDirectory = Path.GetFullPath("../../../../spec");
            FIX42 = Path.Combine(specDirectory, "fix/FIX42.xml");
            FIX44 = Path.Combine(specDirectory, "fix/FIX44.xml");
        }


        [Fact]
        public void IdentifyTypeTest()
        {
            string msg1 = "\x01" + "35=A\x01";
            Assert.Equal(Message.IdentifyType(msg1).Obj, new MsgType("A").Obj);
            string msg2 = "a;sldkfjadls;k\x01" + "35=A\x01" + "a;sldkfja;sdlfk";
            Assert.Equal(Message.IdentifyType(msg2).Obj, new MsgType("A").Obj);
            string msg3 = "8=FIX4.2\x01" + "9=12\x01\x01" + "35=B\x01" + "10=031\x01";
            Assert.Equal(Message.IdentifyType(msg3).Obj, new MsgType("B").Obj);

            // no 35
            string err1 = String.Join(Message.SOH, new string[] { "8=FIX.4.4", "49=Sender", "" });
            Assert.Throws<MessageParseError>(delegate { Message.IdentifyType(err1); });
            // no SOH at end of 35
            string err2 = String.Join(Message.SOH, new string[] { "8=FIX.4.4", "35=A" });
            Assert.Throws<MessageParseError>(delegate { Message.IdentifyType(err2); });
        }

        [Fact]
        public void ExtractStringTest()
        {
            string str1 = "8=FIX.4.2\x01" + "9=46\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01";
            int pos = 0;
            StringField sf1 = Message.ExtractField(str1, ref pos);
            Assert.Equal(10, pos);
            Assert.Equal(8, sf1.Tag);
            Assert.Equal("FIX.4.2", sf1.Obj);
            StringField sf2 = Message.ExtractField(str1, ref pos);
            Assert.Equal(15, pos);
            Assert.Equal(9, sf2.Tag);
            Assert.Equal("46", sf2.Obj);
        }

        [Fact]
        public void ExtractStringErrorsTest()
        {
            int pos = 0;
            Assert.Throws<MessageParseError>(delegate { Message.ExtractField("=", ref pos); });
            Assert.Throws<MessageParseError>(delegate { Message.ExtractField("35=A", ref pos); });
            Assert.Throws<MessageParseError>(delegate { Message.ExtractField("\x01" + "35=A", ref pos); });
            Assert.Throws<MessageParseError>(delegate { Message.ExtractField("35=\x01", ref pos); });
        }
        
        [Fact]
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
                //Assert.Fail("Unexpected exception (InvalidMessage): " + e.Message);
                throw;
            }
            Assert.Equal(msg.CheckSum(), chksum);
        }

        [Fact]
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
                //Assert.Fail("Unexpected exception (InvalidMessage): " + e.Message);
                throw;
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
            Assert.Equal("FIX.4.2", f1.Obj);
            Assert.Equal("55", f2.Obj);
            Assert.Equal("0", f3.Obj);
            Assert.Equal("3", f4.Obj);
            Assert.Equal("TW", f5.Obj);
            Assert.Equal("20000426-12:05:06", f6.Obj);
            Assert.Equal("ISLD", f7.Obj);
            Assert.Equal("123", f8.Obj);
            Assert.Equal("acct123", f9.Obj);
        }

        [Fact]
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
                //Assert.Fail("Unexpected exception (InvalidMessage): " + e.Message);
                throw;
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
            Assert.Equal("FIX.4.2", f1.Obj);
            Assert.Equal("55", f2.Obj);
            Assert.Equal("0", f3.Obj);
            Assert.Equal("3", f4.Obj);
            Assert.Equal("TW", f5.Obj);
            Assert.Equal("20000426-12:05:06", f6.Obj);
            Assert.Equal("ISLD", f7.Obj);
            Assert.Equal("123", f8.Obj);
            Assert.Equal("acct123", f9.Obj);
            string raw = msg.ToString();
            Assert.Equal(raw, str1);
        }

        [Fact]
        public void ToStringFieldOrder()
        {
            Message msg = new Message();
            msg.Header.SetField(new QuickFix.Fields.MsgType("A"));
            msg.Header.SetField(new QuickFix.Fields.BeginString("FIX.4.2"));
            msg.Header.SetField(new QuickFix.Fields.SenderCompID("SENDER"));
            msg.Header.SetField(new QuickFix.Fields.TargetCompID("TARGET"));
            msg.Header.SetField(new QuickFix.Fields.MsgSeqNum(42));
            string expect = "8=FIX.4.2\x01" + "9=31\x01" + "35=A\x01" + "34=42\x01" + "49=SENDER\x01" + "56=TARGET\x01" + "10=200\x01";
            Assert.Equal(msg.ToString(), expect);
        }

        [Fact]
        public void IsHeaderFieldTest()
        {
            Assert.True(Message.IsHeaderField(Tags.BeginString));
            Assert.True(Message.IsHeaderField(Tags.TargetCompID));
            Assert.False(Message.IsHeaderField(Tags.Account));
        }

        [Fact]
        public void IsTrailerFieldTest()
        {
            Assert.True(Message.IsTrailerField(Tags.CheckSum));
            Assert.False(Message.IsTrailerField(Tags.Price));
        }

        [Fact]
        public void EnumeratorTest()
        {
            Message msg = new Message("8=FIX.4.2\x01" + "9=55\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" + "52=20000426-12:05:06\x01" + "56=ISLD\x01" + "1=acct123\x01" + "10=123\x01");

            int numHeaderFields = 0;
            foreach (KeyValuePair<int, QuickFix.Fields.IField> kvp in msg.Header)
                ++numHeaderFields;
            Assert.Equal(7, numHeaderFields);

            int numTrailerFields = 0;
            foreach (KeyValuePair<int, QuickFix.Fields.IField> kvp in msg.Trailer)
                ++numTrailerFields;
            Assert.Equal(1, numTrailerFields);

            int numBodyFields = 0;
            foreach (KeyValuePair<int, QuickFix.Fields.IField> kvp in msg)
                ++numBodyFields;
            Assert.Equal(1, numBodyFields);
        }

        [Fact]
        public void RepeatedTagDetection()
        {
            Message msg = new Message("8=FIX.4.2\x01" + "9=72\x01" + "35=0\x01" + "34=3\x01" + "49=TW\x01" + "49=BOGUS\x01" + "52=20000426-12:05:06\x01" + "56=ISLD\x01" + "1=acct123\x01" + "1=bogus\x01" + "10=052\x01" + "10=000\x01");
            Assert.Single(msg.Header.RepeatedTags);
            Assert.Equal(49, msg.Header.RepeatedTags[0].Tag);

            Assert.Single(msg.Trailer.RepeatedTags);
            Assert.Equal(10, msg.Trailer.RepeatedTags[0].Tag);

            Assert.Single(msg.RepeatedTags);
            Assert.Equal(1, msg.RepeatedTags[0].Tag);
        }

        [Fact]
        public void AddGroupGetGroupTest()
        {
            var nos = new QuickFix.FIX42.NewOrderSingle();
            var noTradingSessions = new QuickFix.FIX42.NewOrderSingle.NoTradingSessionsGroup();
            noTradingSessions.SetField(new StringField(336, "OHHAI"));
            nos.AddGroup(noTradingSessions);
            var noTradingSessionsRE = nos.GetGroup(1, Tags.NoTradingSessions);
            Assert.Equal("OHHAI", noTradingSessionsRE.GetString(336));

            var nos2 = new QuickFix.FIX42.NewOrderSingle();
            var grp = new Group(200, 300);
            grp.SetField(new StringField(300, "Dude"));
            nos2.AddGroup(grp);
            Assert.Equal("Dude", nos2.GetGroup(1, 200).GetString(300));
        }

        [Fact]
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
            dd.Load(FIX44);
            msg.FromString(data, false, dd, dd, _defaultMsgFactory);

            var grp = msg.GetGroup(1, Tags.NoPartyIDs);
            Assert.Equal("AAA35791", grp.GetString(Tags.PartyID));
            grp = msg.GetGroup(3, Tags.NoPartyIDs);
            Assert.Equal("FIX11", grp.GetString(Tags.PartyID));
        }

        [Fact]
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
            dd.Load(FIX44);
            msg.FromString(data, false, dd, dd, _defaultMsgFactory);

            var subGrp = msg.GetGroup(1, Tags.NoPartyIDs).GetGroup(1, Tags.NoPartySubIDs);
            Assert.Equal("OHAI123", subGrp.GetString(Tags.PartySubID));
        }

        [Fact]
        public void HeaderGroupParsingTest()
        {
            string data = "8=FIX.4.4\x01" + "9=40\x01" + "35=A\x01"
                + "627=2\x01" + "628=FOO\x01" + "628=BAR\x01"
                + "98=0\x01" + "384=2\x01" + "372=D\x01" + "385=R\x01" + "372=8\x01" + "385=S\x01" + "10=228\x01";

            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            var nos = new QuickFix.FIX44.Logon();
            nos.FromString(data, false, dd, dd, _defaultMsgFactory);
            Group hops = nos.Header.GetGroup(1, Tags.NoHops);
            Assert.Equal("FOO", hops.GetString(Tags.HopCompID));
            hops = nos.Header.GetGroup(2, Tags.NoHops);
            Assert.Equal("BAR", hops.GetString(Tags.HopCompID));
        }

        [Fact]
        public void MsgType()
        {
            Assert.Equal("B", QuickFix.FIX42.News.MsgType);
        }

        [Fact]
        public void ExtractBeginString()
        {
            string m1 = "8=FIX4.2\x01" + "9999=99999\x01";
            string m2 = "987=pants\x01xxxxxxxxxxxxxxxxxxxxxx";

            Assert.Equal("FIX4.2", Message.ExtractBeginString(m1));
            Assert.Equal("pants", Message.ExtractBeginString(m2));
        }

        [Fact]
        public void ExtractFieldTypes()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX42);

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string s = "8=FIX.4.2\x01" + "9=137\x01" + "35=D\x01" + "34=3\x01" + "49=CLIENT1\x01"
                + "52=20110901-18:41:56.917\x01" + "56=EXECUTOR\x01" + "11=asdf\x01" + "21=1\x01"
                + "38=5.5\x01" + "40=1\x01" + "54=1\x01" + "55=ibm\x01" + "59=1\x01" + "60=20110901-13:41:31.804\x01"
                + "377=Y\x01" + "201=1\x01"
                + "10=63\x01";
            n.FromString(s, true, dd, dd, _defaultMsgFactory);

            // string values are good?
            Assert.Equal("Y", n.SolicitedFlag.ToString()); //bool, 377
            Assert.Equal("1", n.Side.ToString()); //char, 54
            Assert.Equal("20110901-13:41:31.804", n.TransactTime.ToString()); //datetime, 60
            Assert.Equal("5.5", n.OrderQty.ToString()); //decimal, 38
            Assert.Equal("1", n.PutOrCall.ToString()); //int, 201
            Assert.Equal("asdf", n.ClOrdID.ToString()); //string, 11

            // type-converted values are good?
            Assert.True(n.SolicitedFlag.getValue());
            Assert.Equal('1', n.Side.getValue());
            Assert.Equal(DateTime.Parse("2011-09-01 13:41:31.804"), n.TransactTime.getValue());
            Assert.Equal(5.5m, n.OrderQty.getValue());
            Assert.Equal(1, n.PutOrCall.getValue());
            Assert.Equal("asdf", n.ClOrdID.getValue());
        }

        [Fact]
        public void RepeatingGroup()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX42);

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
            Assert.Contains(
                nul + "33=2" + nul + "58=line1" + nul + "354=3" + nul + "355=aaa" + nul + "58=line2" + nul + "355=bbb",
                raw);
        }

        [Fact]
        public void RepeatingGroup_ReuseObject()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX42);

            QuickFix.FIX42.News news = new QuickFix.FIX42.News(new QuickFix.Fields.Headline("Foo headline"));

            QuickFix.FIX42.News.LinesOfTextGroup group = new QuickFix.FIX42.News.LinesOfTextGroup();
            group.Text = new QuickFix.Fields.Text("line1");
            news.AddGroup(group);
            group.Text = new QuickFix.Fields.Text("line2");
            news.AddGroup(group);

            string raw = news.ToString();

            string nul = "\x01";
            Assert.Contains(
                nul + "33=2" + nul + "58=line1" + nul + "58=line2",
                raw);
        }

        [Fact]
        public void FromString_DoNotCorrectCounter()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary(FIX42);

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string nul = "\x01";
            string s = "8=FIX.4.2" + nul + "9=148" + nul + "35=D" + nul + "34=2" + nul + "49=TW" + nul + "52=20111011-15:06:23.103" + nul + "56=ISLD" + nul
                + "11=ID" + nul + "21=1" + nul + "40=1" + nul + "54=1" + nul + "38=200.00" + nul + "55=INTC" + nul
                + "386=3" + nul + "336=PRE-OPEN" + nul + "336=AFTER-HOURS" + nul
                + "60=20111011-15:06:23.103" + nul
                + "10=35" + nul;

            n.FromString(s, true, dd, dd, _defaultMsgFactory);
            Assert.Equal("386=3", n.NoTradingSessions.toStringField());
            Assert.Contains("386=3", n.ToString()); //don't correct it to 2, you bastard
        }

        [Fact]
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
                //Assert.Fail("Unexpected exception (InvalidMessage): " + e.Message);
                throw;
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
            
            Assert.Equal("FIX.4.2", msg.Header.GetString(Tags.BeginString));
            Assert.Equal("SENDER", msg.Header.GetString(Tags.TargetCompID));
            Assert.Equal("SENDERSUB", msg.Header.GetString(Tags.TargetSubID));
            Assert.Equal("SENDERLOC", msg.Header.GetString(Tags.TargetLocationID));
            Assert.Equal("TARGET", msg.Header.GetString(Tags.SenderCompID));
            Assert.Equal("TARGETSUB", msg.Header.GetString(Tags.SenderSubID));
            Assert.Equal("TARGETLOC", msg.Header.GetString(Tags.SenderLocationID));
        }

        [Fact]
        public void TestGetSetSessionID()
        {
            SessionID sessionID = new SessionID("FIX.4.2", "SENDER", "SENDERSUB", "SENDERLOC", "TARGET", "TARGETSUB", "TARGETLOC");
            Message msg = new Message();

            msg.SetSessionID(sessionID);

            Assert.Equal("FIX.4.2", msg.Header.GetString(Tags.BeginString));
            Assert.Equal("SENDER", msg.Header.GetString(Tags.SenderCompID));
            Assert.Equal("SENDERSUB", msg.Header.GetString(Tags.SenderSubID));
            Assert.Equal("SENDERLOC", msg.Header.GetString(Tags.SenderLocationID));
            Assert.Equal("TARGET", msg.Header.GetString(Tags.TargetCompID));
            Assert.Equal("TARGETSUB", msg.Header.GetString(Tags.TargetSubID));
            Assert.Equal("TARGETLOC", msg.Header.GetString(Tags.TargetLocationID));

            SessionID getSessionID = msg.GetSessionID(msg);
            Assert.Equal("FIX.4.2", getSessionID.BeginString);
            Assert.Equal("SENDER", getSessionID.SenderCompID);
            Assert.Equal("SENDERSUB", getSessionID.SenderSubID);
            Assert.Equal("SENDERLOC", getSessionID.SenderLocationID);
            Assert.Equal("TARGET", getSessionID.TargetCompID);
            Assert.Equal("TARGETSUB", getSessionID.TargetSubID);
            Assert.Equal("TARGETLOC", getSessionID.TargetLocationID);

            ////
            sessionID = new SessionID("FIX.4.2", "SENDER", "TARGET");
            msg = new Message();

            msg.SetSessionID(sessionID);

            Assert.Equal("FIX.4.2", msg.Header.GetString(Tags.BeginString));
            Assert.Equal("SENDER", msg.Header.GetString(Tags.SenderCompID));
            Assert.False(msg.Header.IsSetField(Tags.SenderSubID));
            Assert.False(msg.Header.IsSetField(Tags.SenderLocationID));
            Assert.Equal("TARGET", msg.Header.GetString(Tags.TargetCompID));
            Assert.False(msg.Header.IsSetField(Tags.TargetSubID));
            Assert.False(msg.Header.IsSetField(Tags.TargetLocationID));

            getSessionID = msg.GetSessionID(msg);
            Assert.Equal("FIX.4.2", getSessionID.BeginString);
            Assert.Equal("SENDER", getSessionID.SenderCompID);
            Assert.Equal("", getSessionID.SenderSubID);
            Assert.Equal("", getSessionID.SenderLocationID);
            Assert.Equal("TARGET", getSessionID.TargetCompID);
            Assert.Equal("", getSessionID.TargetSubID);
            Assert.Equal("", getSessionID.TargetLocationID);
        }

        [Fact]
        public void GetMsgTypeTest()
        {
            string[] msgFields = { "8=FIX.4.4", "9=104", "35=W", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=1", "269=0", "272=20111012", "273=22:15:30.444", "10=19" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;
            Assert.Equal("W", Message.GetMsgType(msgStr));

            // invalid 35 value, let it ride
            string[] msgFields2 = { "8=FIX.4.4", "9=68", "35=*", "34=3", "49=sender", "52=20110909-09:09:09.999", "56=target",
                                     "55=sym", "268=0", "10=9" };
            string msgStr2 = String.Join(Message.SOH, msgFields2) + Message.SOH;
            Assert.Equal("*", Message.GetMsgType(msgStr2));
        }

        [Fact]
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

            Assert.Contains(expected, msgString);
        }

        [Fact]
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

            Assert.Contains(expected, msgString);
        }

        [Fact]
        public void ToString_FIX50()
        {
            QuickFix.FIX50.News msg = new QuickFix.FIX50.News();
            msg.Headline = new Headline("FOO");

            Assert.StartsWith("8=FIXT.1.1" + Message.SOH, msg.ToString());
        }

        [Fact]
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
            Assert.Contains(expected, msgString);
        }

        [Fact]
        public void issue56_GetGroup_by_tag_and_return()
        {
            // setup
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            string[] msgFields = { "8=FIX.4.2", "9=87", "35=B", "34=3", "49=CLIENT1", "52=20111012-22:15:55.474", "56=EXECUTOR", "148=AAAAAAA", "33=2", "58=L1", "58=L2", "10=016" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;
            QuickFix.FIX42.News msg = new QuickFix.FIX42.News();
            msg.FromString(msgStr, false, dd, dd, _defaultMsgFactory);
            Assert.Equal(2, msg.GroupCount(Tags.LinesOfText)); // for sanity

            // the test
            var grp1 = msg.GetGroup(1, Tags.LinesOfText);
            Assert.IsType<QuickFix.FIX42.News.LinesOfTextGroup>(grp1);
            Assert.Equal("L1", (grp1 as QuickFix.FIX42.News.LinesOfTextGroup).Text.Obj);

            var grp2 = msg.GetGroup(2, Tags.LinesOfText);
            Assert.IsType<QuickFix.FIX42.News.LinesOfTextGroup>(grp2);
            Assert.Equal("L2", (grp2 as QuickFix.FIX42.News.LinesOfTextGroup).Text.Obj);
        }

        [Fact]
        public void issue56_GetGroup_by_reference()
        {
            // setup
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);
            string[] msgFields = { "8=FIX.4.2", "9=87", "35=B", "34=3", "49=CLIENT1", "52=20111012-22:15:55.474", "56=EXECUTOR", "148=AAAAAAA", "33=2", "58=L1", "58=L2", "10=016" };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;
            QuickFix.FIX42.News msg = new QuickFix.FIX42.News();
            msg.FromString(msgStr, false, dd, dd, _defaultMsgFactory);
            Assert.Equal(2, msg.GroupCount(Tags.LinesOfText)); // for sanity

            // the test
            QuickFix.FIX42.News.LinesOfTextGroup grp = new QuickFix.FIX42.News.LinesOfTextGroup(); // for return value

            msg.GetGroup(1, grp);
            Assert.Equal("L1", grp.Text.Obj);

            msg.GetGroup(2, grp);
            Assert.Equal("L2", grp.Text.Obj);
        }

        [Fact]
        public void MissingDelimiterField()
        {
            // issue 101

            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);

            // message is missing 703
            string[] msgFields = { "8=FIX.4.4", "9=230", "35=AP", "34=3", "49=XXXXX", "52=20120731-14:06:37.848", "56=FixKevindemo",
                "1=20050500001", "55=EURUSD", "453=0", "581=1", "702=1", "704=0", "705=20000", "710=634792896000000000", "715=20120802",
                "721=P-DEA30E1PHC0IW7V", "730=1.22608", "731=1", "734=1.22608", "753=1", "708=20000", "10=030"
            };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            QuickFix.FIX44.PositionReport msg = new QuickFix.FIX44.PositionReport();

            QuickFix.GroupDelimiterTagException ex =
                Assert.Throws<QuickFix.GroupDelimiterTagException>(delegate { msg.FromString(msgStr, true, dd, dd, _defaultMsgFactory); });
            Assert.Equal(702, ex.Field);
            Assert.Equal("Group 702's first entry does not start with delimiter 703", ex.Message);
        }

        [Fact]
        public void DateOnlyTimeOnlyConvertProblem()
        {
            // issue 135

            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);

            string[] msgFields = { "8=FIX.4.4", "9=332", "35=W", "34=2", "49=MA", "52=20121024-12:21:42.170", "56=xxxx",
                "22=4", "48=BE0932900518", "55=[N/A]", "262=1b145288-9c9a-4911-a084-7341c69d3e6b", "762=EURO_EUR", "268=2", 
                "269=0", "270=97.625", "15=EUR", "271=1246000", "272=20121024", "273=07:30:47", "276=I", "282=BEARGB21XXX", "299=15478575", 
                "269=1", "270=108.08", "15=EUR", "271=884000", "272=20121024", "273=07:30:47", "276=I", "282=BEARGB21XXX", "299=15467902", "10=77"
            };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            QuickFix.FIX44.MarketDataSnapshotFullRefresh msg = new QuickFix.FIX44.MarketDataSnapshotFullRefresh();

            msg.FromString(msgStr, true, dd, dd, _defaultMsgFactory);
            QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup gentry1 = new QuickFix.FIX44.MarketDataIncrementalRefresh.NoMDEntriesGroup();
            msg.GetGroup(1, gentry1);
            Assert.Equal(new DateTime(2012, 10, 24), gentry1.MDEntryDate.getValue());
            Assert.Equal(new DateTime(2012, 10, 24, 7, 30, 47).TimeOfDay, gentry1.MDEntryTime.getValue().TimeOfDay);
            Assert.Equal(new DateTime(2012, 10, 24, 7, 30, 47), gentry1.MDEntryDate.getValue() + gentry1.MDEntryTime.getValue().TimeOfDay);
        }

        [Fact]
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

            Assert.Contains(expected, msgString);
        }

        [Fact]
        public void MessageHasDecimalWithNoLeadingZero()
        {
            // issue 160
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);

            string[] msgFields = { "8=FIX.4.4", "9=122", "35=8", "34=2", "49=sender", "52=20121024-12:21:42.170", "56=target",
                "37=orderid", "17=execid", "150=0", "39=0",
                "55=ibm", "228=.23", // Instrument component; 228 is a float type in the spec
                "54=1", "151=1", "14=1", "6=1", "10=45"
            };
            string msgStr = String.Join(Message.SOH, msgFields) + Message.SOH;

            QuickFix.FIX44.ExecutionReport msg = new QuickFix.FIX44.ExecutionReport();
            msg.FromString(msgStr, true, dd, dd, _defaultMsgFactory);

            Assert.Equal(0.23M, msg.Factor.getValue());
        }

        [Fact]
        public void FromString_Groups_NoFactory()
        {
            // issue 179
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);

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

            Console.WriteLine(msg.ToString());

            QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup partyGroup = new QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup();
            msg.GetGroup(2, partyGroup);

            Assert.False(partyGroup.IsSetNoPartySubIDs());
        }

        [Fact]
        public void IsAdmin_IsApp()
        {
            // issue 173
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX42);

            string[] newsFields = { "8=FIX4.2", "9=5", "35=B", "10=133" };
            string newsStr = String.Join(Message.SOH, newsFields) + Message.SOH;
            QuickFix.FIX42.News news = new QuickFix.FIX42.News();
            news.FromString(newsStr, true, dd, dd, _defaultMsgFactory);

            string[] hbFields = { "8=FIX.4.2", "9=16", "35=0", "34=3", "49=TW", "10=1" };
            string hbStr = String.Join(Message.SOH, hbFields) + Message.SOH;
            QuickFix.FIX42.Heartbeat heartbeat = new QuickFix.FIX42.Heartbeat();
            heartbeat.FromString(hbStr, true, dd, dd, _defaultMsgFactory);

            Assert.False(news.IsAdmin());
            //Assert.True(news.IsApp());

            //Assert.True(heartbeat.IsAdmin());
            Assert.False(heartbeat.IsApp());
        }

        [Fact]
        public void issue95()
        {
            // Parser screws up on triple-nested groups.  Contributes to ResendRequest failures.
            string msgStr = String.Join(Message.SOH, new string[]{
                "8=FIX.4.4","9=999","35=R","34=6","49=sendercompid","52=20130225-10:44:59.149","56=targetcompid", //headers
                    "131=quotereqid",
                    "146=1", // NoRelatedSym
                        "55=ABC","65=CD","48=securityid","22=1", // group
                        "711=1", // NoUnderlyings
                            "311=underlyingsymbol","312=WI","309=underlyingsecurityid","305=1",
                "10=999",""
            });

            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load(FIX44);

            Message msg = new Message();
            msg.FromString(msgStr, false, dd, dd, _defaultMsgFactory);

            // make sure no fields were dropped in parsing
            Assert.Equal(msgStr.Length, msg.ToString().Length);

            // make sure repeating groups are not rearranged
            // 1 level deep
            Assert.Contains(String.Join(Message.SOH, new string[] { "55=ABC", "65=CD", "48=securityid", "22=1" }), msg.ToString());
            // 2 levels deep
            Assert.Contains(String.Join(Message.SOH, new string[] { "311=underlyingsymbol", "312=WI", "309=underlyingsecurityid", "305=1" }), msg.ToString());
        }

        [Fact]
        public void SetFieldsTest()
        {
            var message = new Message();
            var allocId = new AllocID("123456");
            var allocAccount = new AllocAccount("QuickFixAccount");
            var allocAccountType = new AllocAccountType(AllocAccountType.HOUSE_TRADER);
            message.SetFields(new IField[] { allocAccount, allocAccountType, allocId });

            Assert.True(message.IsSetField(Tags.AllocID));
            Assert.Equal("123456", message.GetField(Tags.AllocID));

            Assert.True(message.IsSetField(Tags.AllocAccount));
            Assert.Equal("QuickFixAccount", message.GetField(Tags.AllocAccount));

            Assert.True(message.IsSetField(Tags.AllocAccountType));
            Assert.Equal(AllocAccountType.HOUSE_TRADER, message.GetInt(Tags.AllocAccountType));
        }
    }
}
