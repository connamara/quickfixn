using NUnit.Framework;
using QuickFix;
using System;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    public class ParserTest
    {
        static byte[] normalLength   = Encoding.ASCII.GetBytes("8=FIX.4.2\x01" + "9=12\x01" + "35=A\x01" + " 108=30\x01" + "10=31\x01");
        static byte[] badLength = Encoding.ASCII.GetBytes("8=FIX.4.2\x01" + "9=A\x01" + "35=A\x01" + "108=30\x01" + "10=31\x01");
        static byte[] negativeLength = Encoding.ASCII.GetBytes("8=FIX.4.2\x01" + "9=-1\x01" + "35=A\x01" + "108=30\x01" + "10=31\x01");
        static byte[] incomplete_1 = Encoding.ASCII.GetBytes("8=FIX.4.2");
        static byte[] incomplete_2 = Encoding.ASCII.GetBytes("8=FIX.4.2\x01" + "9=12");

        [Test]
        public void ExtractLength()
        {
            int len;
            int pos;
            Assert.True(Parser.ExtractLength(out len, out pos, normalLength, 0, normalLength.Length));
            Assert.AreEqual(12, len);
            Assert.AreEqual(15, pos);

            Assert.Throws<QuickFix.MessageParseError>(delegate { Parser.ExtractLength(out len, out pos, badLength, 0, badLength.Length); });

            Assert.AreEqual(0, pos);
            Assert.Throws<QuickFix.MessageParseError>(delegate { Parser.ExtractLength(out len, out pos, negativeLength, 0, negativeLength.Length); });

            Assert.AreEqual(0, pos);
            Parser.ExtractLength(out len, out pos, incomplete_1, 0, incomplete_1.Length);

            Parser.ExtractLength(out len, out pos, incomplete_2, 0, incomplete_2.Length);
            Assert.AreEqual(0, pos);

            Assert.False(Parser.ExtractLength(out len, out pos, new byte[0], 0, 0));
        }

        [Test]
        public void ReadCompleteFixMessages()
        {
            const string fixMsg1 = "8=FIX.4.2\x01" + "9=12\x01" + "35=A\x01" + "108=30\x01" + "10=31\x01";
            const string fixMsg2 = "8=FIX.4.2\x01" + "9=17\x01" + "35=4\x01" + "36=88\x01"  + "123=Y\x01"  + "10=34\x01";
            const string fixMsg3 = "8=FIX.4.2\x01" + "9=19\x01" + "35=A\x01" + "108=30\x01" + "9710=8\x01" + "10=31\x01";

            Parser parser = new Parser();
            AddToParserStream(parser, fixMsg1 + fixMsg2 + fixMsg3);

            byte[] readFixMsg1;
            Assert.True(parser.ReadFixMessage(out readFixMsg1));
            Assert.AreEqual(fixMsg1, Encoding.ASCII.GetString(readFixMsg1));

            byte[] readFixMsg2;
            Assert.True(parser.ReadFixMessage(out readFixMsg2));
            Assert.AreEqual(fixMsg2, Encoding.ASCII.GetString(readFixMsg2));

            byte[] readFixMsg3;
            Assert.True(parser.ReadFixMessage(out readFixMsg3));
            Assert.AreEqual(fixMsg3, Encoding.ASCII.GetString(readFixMsg3));
        }

        [Test]
        public void ReadPartialFixMessage()
        {
            string partFixMsg1 = "8=FIX.4.2\x01" + "9=17\x01" + "35=4\x01" + "36=";
            string partFixMsg2 = "88\x01" + "123=Y\x01" + "10=34\x01";

            Parser parser = new Parser();
            AddToParserStream(parser, partFixMsg1);

            byte[] readPartFixMsg;
            Assert.False(parser.ReadFixMessage(out readPartFixMsg));

            AddToParserStream(parser, partFixMsg2);
            Assert.True(parser.ReadFixMessage(out readPartFixMsg));
            Assert.AreEqual(partFixMsg1 + partFixMsg2, Encoding.ASCII.GetString(readPartFixMsg));
        }

        [Test]
        public void ReadFixMessageWithBadLength()
        {
            string fixMsg = "8=TEST\x01" + "9=TEST\x01" + "35=TEST\x01" + "49=SS1\x01" + "56=RORE\x01" + "34=3\x01" + "52=20050222-16:45:53\x01" + "10=TEST\x01";

            Parser parser = new Parser();
            AddToParserStream(parser, fixMsg);

            byte[] readFixMsg;
            Assert.Throws<QuickFix.MessageParseError>(delegate { parser.ReadFixMessage(out readFixMsg); });
            
            // nothing thrown now because the previous call removes bad data from buffer:
            Assert.DoesNotThrow(delegate { parser.ReadFixMessage(out readFixMsg); });
        }

        [Test]
        public void ReadFixMessageWithNonAscii()
        {
            string[] fixMsgFields1 = { "8=FIX.4.4", "9=19", "35=B", "148=Ole!", "33=0", "10=0" };
            string fixMsg1 = String.Join("\x01", fixMsgFields1) + "\x01";

            Assert.AreEqual("é", "\x00E9");
            Assert.AreEqual("é", "\xE9");

            string[] fixMsgFields2 = { "8=FIX.4.4", "9=20", "35=B", "148=Olé!", "33=0", "10=0" };
            string fixMsg2 = String.Join("\x01", fixMsgFields2) + "\x01";

            Parser parser = new Parser();
            AddToParserStream(parser, fixMsg1 + fixMsg2);

            byte[] readFixMsg1;
            Assert.True(parser.ReadFixMessage(out readFixMsg1));
            Assert.AreEqual(fixMsg1, Encoding.UTF8.GetString(readFixMsg1));

            byte[] readFixMsg2;
            Assert.True(parser.ReadFixMessage(out readFixMsg2));
            Assert.AreEqual(fixMsg2, Encoding.UTF8.GetString(readFixMsg2));
        }

        [Test] // Issue #282 investigation
        public void ReadFixMessageWithMissingValues()
        {
            string[] fixMsgFields1 = { "8=FIX.4.4", "9=15", "35=B", "148=", "33=0", "10=0" };
            string fixMsg1 = String.Join("\x01", fixMsgFields1) + "\x01";

            Parser parser = new Parser();
            AddToParserStream(parser, fixMsg1);

            byte[] readFixMsg1;
            Assert.True(parser.ReadFixMessage(out readFixMsg1));
            Assert.AreEqual(fixMsg1, Encoding.UTF8.GetString(readFixMsg1));
        }

        private void AddToParserStream(Parser p, string s)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(s);
            p.AddToStream(bytes, bytes.Length);
        }
    }
}