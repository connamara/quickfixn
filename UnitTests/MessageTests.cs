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
            msg.Header.getField(f1);
            msg.Header.getField(f2);
            msg.Header.getField(f3);
            msg.Header.getField(f4);
            msg.Header.getField(f5);
            msg.Header.getField(f6);
            msg.Header.getField(f7);
            msg.getField(f9);
            msg.Trailer.getField(f8);
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
            msg.Header.getField(f1);
            msg.Header.getField(f2);
            msg.Header.getField(f3);
            msg.Header.getField(f4);
            msg.Header.getField(f5);
            msg.Header.getField(f6);
            msg.Header.getField(f7);
            msg.getField(f9);
            msg.Trailer.getField(f8);
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
            msg.Header.setField(new QuickFix.Fields.MsgType("A"));
            msg.Header.setField(new QuickFix.Fields.BeginString("FIX.4.2"));
            msg.Header.setField(new QuickFix.Fields.SenderCompID("SENDER"));
            msg.Header.setField(new QuickFix.Fields.TargetCompID("TARGET"));
            msg.Header.setField(new QuickFix.Fields.MsgSeqNum(42));
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
        public void MsgType()
        {
            Assert.AreEqual("B", QuickFix.FIX42.News.MsgType);
        }
    }
}
