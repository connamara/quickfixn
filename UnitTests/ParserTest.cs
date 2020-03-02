using NUnit.Framework;
using QuickFix;
using System;

namespace UnitTests
{
    [TestFixture]
    public class ParserTest
    {
        const string normalLength   = "8=FIX.4.2\x01" + "9=12\x01" + "35=A\x01" + " 108=30\x01" + "10=31\x01";
        const string badLength      = "8=FIX.4.2\x01" + "9=A\x01"  + "35=A\x01" + "108=30\x01"  + "10=31\x01";
        const string negativeLength = "8=FIX.4.2\x01" + "9=-1\x01" + "35=A\x01" + "108=30\x01"  + "10=31\x01";
        const string incomplete_1   = "8=FIX.4.2";
        const string incomplete_2   = "8=FIX.4.2\x01" + "9=12";

        public byte[] StrToBytes(string str)
        {
            return CharEncoding.DefaultEncoding.GetBytes(str);
        }

        [Test]
        public void ExtractLength()
        {
            Parser parser = new Parser();

            int len = 0;
            int pos = 0;
            Assert.True(parser.ExtractLength(out len, out pos, normalLength));
            Assert.AreEqual(12, len);
            Assert.AreEqual(15, pos);

            pos = 0;
            Assert.Throws<QuickFix.MessageParseError>(delegate { parser.ExtractLength(out len, out pos, badLength); });

            Assert.AreEqual(0, pos);
            Assert.Throws<QuickFix.MessageParseError>(delegate { parser.ExtractLength(out len, out pos, negativeLength); });

            Assert.AreEqual(0, pos);
            parser.ExtractLength(out len, out pos, incomplete_1);

            parser.ExtractLength(out len, out pos, incomplete_2);
            Assert.AreEqual(0, pos);

            Assert.False(parser.ExtractLength(out len, out pos, ""));
        }

        [Test]
        public void ReadCompleteFixMessages()
        {
            const string fixMsg1 = "8=FIX.4.2\x01" + "9=12\x01" + "35=A\x01" + "108=30\x01" + "10=31\x01";
            const string fixMsg2 = "8=FIX.4.2\x01" + "9=17\x01" + "35=4\x01" + "36=88\x01"  + "123=Y\x01"  + "10=34\x01";
            const string fixMsg3 = "8=FIX.4.2\x01" + "9=19\x01" + "35=A\x01" + "108=30\x01" + "9710=8\x01" + "10=31\x01";

            Parser parser = new Parser();
            byte[] combined = StrToBytes(fixMsg1 + fixMsg2 + fixMsg3);
            parser.AddToStream(combined, combined.Length);

            string readFixMsg1;
            Assert.True(parser.ReadFixMessage(out readFixMsg1));
            Assert.AreEqual(fixMsg1, readFixMsg1);

            string readFixMsg2;
            Assert.True(parser.ReadFixMessage(out readFixMsg2));
            Assert.AreEqual(fixMsg2, readFixMsg2);

            string readFixMsg3;
            Assert.True(parser.ReadFixMessage(out readFixMsg3));
            Assert.AreEqual(fixMsg3, readFixMsg3);
        }

        [Test]
        public void ReadPartialFixMessage()
        {
            string partFixMsg1 = "8=FIX.4.2\x01" + "9=17\x01" + "35=4\x01" + "36=";
            string partFixMsg2 = "88\x01" + "123=Y\x01" + "10=34\x01";

            byte[] partBytes1 = CharEncoding.DefaultEncoding.GetBytes(partFixMsg1);
            byte[] partBytes2 = CharEncoding.DefaultEncoding.GetBytes(partFixMsg2);

            Parser parser = new Parser();
            string readPartFixMsg;

            parser.AddToStream(partBytes1, partBytes1.Length);
            Assert.False(parser.ReadFixMessage(out readPartFixMsg));

            parser.AddToStream(partBytes2, partBytes2.Length);
            Assert.True(parser.ReadFixMessage(out readPartFixMsg));

            Assert.AreEqual(partFixMsg1 + partFixMsg2, readPartFixMsg);
        }

        [Test]
        public void ReadFixMessageWithBadLength()
        {
            byte[] fixMsg = StrToBytes("8=TEST\x01" + "9=TEST\x01" + "35=TEST\x01" + "49=SS1\x01" + "56=RORE\x01" + "34=3\x01" + "52=20050222-16:45:53\x01" + "10=TEST\x01");

            Parser parser = new Parser();
            parser.AddToStream(fixMsg, fixMsg.Length);

            string readFixMsg;
            Assert.Throws<QuickFix.MessageParseError>(delegate { parser.ReadFixMessage(out readFixMsg); });
            
            // nothing thrown now because the previous call removes bad data from buffer:
            Assert.DoesNotThrow(delegate { parser.ReadFixMessage(out readFixMsg); });
        }

        [Test]
        public void ReadFixMessageWithNonAscii()
        {
            string[] fixMsgFields1 = { "8=FIX.4.4", "9=19", "35=B", "148=Ole!", "33=0", "10=0" };
            string fixMsg1 = String.Join(Message.SOH, fixMsgFields1) + Message.SOH;

            Assert.AreEqual("é", "\x00E9");
            Assert.AreEqual("é", "\xE9");

            // In 1.8 and earlier, the default encoding was UTF-8, which treated "é" as 2 bytes,
            // and this message had 9=20, which didn't agree with other implementations.
            // Now that the default encoding is ISO-8859-1, "é" is one byte,
            // and 9=19.
            string[] fixMsgFields2 = { "8=FIX.4.4", "9=19", "35=B", "148=Olé!", "33=0", "10=0" };
            string fixMsg2 = String.Join(Message.SOH, fixMsgFields2) + Message.SOH;

            Parser parser = new Parser();
            byte[] combined = StrToBytes(fixMsg1 + fixMsg2);
            parser.AddToStream(combined, combined.Length);

            string readFixMsg1;
            Assert.True(parser.ReadFixMessage(out readFixMsg1));
            Assert.AreEqual(fixMsg1, readFixMsg1);

            string readFixMsg2;
            Assert.True(parser.ReadFixMessage(out readFixMsg2), "parser.ReadFixMessage(readFixMsg2) failure");
            Assert.AreEqual(fixMsg2, readFixMsg2);
        }

        [Test] // Issue #282 investigation
        public void ReadFixMessageWithMissingValues()
        {
            string[] fixMsgFields1 = { "8=FIX.4.4", "9=15", "35=B", "148=", "33=0", "10=0" };
            string fixMsg1 = String.Join("\x01", fixMsgFields1) + "\x01";

            Parser parser = new Parser();
            byte[] bytesMsg = StrToBytes(fixMsg1);
            parser.AddToStream(bytesMsg, bytesMsg.Length);

            string readFixMsg1;
            Assert.True(parser.ReadFixMessage(out readFixMsg1));
            Assert.AreEqual(fixMsg1, readFixMsg1);
        }
    }
}