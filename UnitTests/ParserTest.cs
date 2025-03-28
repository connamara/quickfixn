using NUnit.Framework;
using QuickFix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTests;

[TestFixture]
public class ParserTest
{
    private const string NormalLength   = "8=FIX.4.2\x01" + "9=12\x01" + "35=A\x01" + " 108=30\x01" + "10=31\x01";

    [Test]
    public void ExtractLength()
    {
        Parser parser = new Parser();

        const string badLength = "8=FIX.4.2\x01" + "9=A\x01"  + "35=A\x01" + "108=30\x01"  + "10=31\x01";
        const string negativeLength = "8=FIX.4.2\x01" + "9=-1\x01" + "35=A\x01" + "108=30\x01"  + "10=31\x01";
        const string zeroLength = "8=FIX.4.2\x01" + "9=0\x01" + "35=A\x01" + "108=30\x01"  + "10=31\x01";
        const string incomplete1   = "8=FIX.4.2";
        const string incomplete2   = "8=FIX.4.2\x01" + "9=12";

        Assert.That(parser.ExtractLength(out int len, out int pos, NormalLength), Is.True);
        Assert.That(len, Is.EqualTo(12));
        Assert.That(pos, Is.EqualTo(15));

        Assert.That(parser.ExtractLength(out len, out pos, zeroLength), Is.True);
        Assert.That(len, Is.EqualTo(0));
        Assert.That(pos, Is.EqualTo(14));

        Assert.Throws<MessageParseError>(delegate { parser.ExtractLength(out len, out pos, badLength); });
        Assert.That(pos, Is.EqualTo(0));

        Assert.Throws<MessageParseError>(delegate { parser.ExtractLength(out len, out pos, negativeLength); });
        Assert.That(pos, Is.EqualTo(0));

        Assert.That(parser.ExtractLength(out len, out pos, incomplete1), Is.False);
        Assert.That(pos, Is.EqualTo(0));

        Assert.That(parser.ExtractLength(out len, out pos, incomplete2), Is.False);
        Assert.That(pos, Is.EqualTo(0));

        Assert.That(parser.ExtractLength(out len, out pos, ""), Is.False);
        Assert.That(pos, Is.EqualTo(0));
    }

    [Test]
    [TestCase(100, 1)]
    [TestCase(10, 10)]
    public void ReadCompleteFixMessages(int batchSize, int numBatches)
    {
        const string fixMsg1 = "8=FIX.4.2\x01" + "9=12\x01" + "35=A\x01" + "108=30\x01" + "10=31\x01";
        const string fixMsg2 = "8=FIX.4.2\x01" + "9=17\x01" + "35=4\x01" + "36=88\x01"  + "123=Y\x01"  + "10=34\x01";
        const string fixMsg3 = "8=FIX.4.2\x01" + "9=19\x01" + "35=A\x01" + "108=30\x01" + "9710=8\x01" + "10=31\x01";

        Parser parser = new Parser();

        for (int batchNum = 0; batchNum < numBatches; batchNum++)
        {
            List<string> batch = new();

            for (int i = 0; i < batchSize; i++)
            {
                string message = (i % 3) switch
                {
                    0 => fixMsg1,
                    1 => fixMsg2,
                    _ => fixMsg3
                };

                batch.Add(message);
                using (CharEncoding.GetBytes(message, out ReadOnlySpan<byte> bytesMsg))
                {
                    parser.AddToStream(bytesMsg);
                }
            }

            for (int i = 0; i < batchSize; i++)
            {
                Assert.That(parser.ReadFixMessage(out string message), Is.True);
                Assert.That(message, Is.EqualTo(batch[i]));
            }

            Assert.That(parser.ReadFixMessage(out _), Is.False);
        }
    }

    [Test]
    public void ReadPartialFixMessage()
    {
        List<string> messageParts = new()
        {
            "abcdef8", // Junk
            "8", // No BeginString found yet
            "=FIX.4.2", // No BodyLength tag found yet
            '\x01' + "9=17", // No BodyLength terminating SOH found yet
            '\x01' + "35=4", // Message smaller than BodyLength value
            '\x01' + "36=88\x01" + "123=Y\x01" + "10", // no CheckSum tag found yet
            "=34", // No CheckSum terminating SOH found yet
            "\x01"
        };

        Parser parser = new();

        for(int i = 0; i < messageParts.Count - 1; i++)
        {
            using (CharEncoding.GetBytes(messageParts[i], out ReadOnlySpan<byte> bytesMsg))
            {
                parser.AddToStream(bytesMsg);
            }
            Assert.That(parser.ReadFixMessage(out _), Is.False);
        }

        string expectedMessage = string.Join("", messageParts.Skip(1));

        using (CharEncoding.GetBytes(messageParts[^1], out ReadOnlySpan<byte> bytesMsg2))
        {
            parser.AddToStream(bytesMsg2);
        }
        Assert.That(parser.ReadFixMessage(out string actualMessage), Is.True);
        Assert.That(actualMessage, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void ReadFixMessageWithBadLength()
    {
        const string fixMsg1 = "8=TEST\x01" + "9=TEST\x01" + "35=TEST\x01" + "49=SS1\x01" + "56=RORE\x01" + "34=3\x01" + "52=20050222-16:45:53\x01" + "10=TEST\x01";

        Parser parser = new Parser();
        using (CharEncoding.GetBytes(fixMsg1, out ReadOnlySpan<byte> bytesMsg1))
        {
            parser.AddToStream(bytesMsg1);
        }
        using (CharEncoding.GetBytes(NormalLength, out ReadOnlySpan<byte> bytesMsg2))
        {
            parser.AddToStream(bytesMsg2);
        }

        Assert.Throws<MessageParseError>(delegate { parser.ReadFixMessage(out _); });
        
        // nothing thrown now because the previous call removes bad data from buffer:
        Assert.That(parser.ReadFixMessage(out string readFixMsg), Is.True);
        Assert.That(readFixMsg, Is.EqualTo(NormalLength));
    }

    [Test]
    public void ReadFixMessageWithNonAscii()
    {
        string[] fixMsgFields1 = { "8=FIX.4.4", "9=19", "35=B", "148=Ole!", "33=0", "10=0" };
        string fixMsg1 = string.Join(Message.SOH, fixMsgFields1) + Message.SOH;

        Assert.That("\x00E9", Is.EqualTo("é"));
        Assert.That("\xE9", Is.EqualTo("é"));

        // In 1.8 and earlier, the default encoding was UTF-8, which treated "é" as 2 bytes,
        // and this message had 9=20, which didn't agree with other implementations.
        // Now that the default encoding is ISO-8859-1, "é" is one byte,
        // and 9=19.
        string[] fixMsgFields2 = { "8=FIX.4.4", "9=19", "35=B", "148=Olé!", "33=0", "10=0" };
        string fixMsg2 = string.Join(Message.SOH, fixMsgFields2) + Message.SOH;

        Parser parser = new Parser();
        using (CharEncoding.GetBytes(fixMsg1 + fixMsg2, out ReadOnlySpan<byte> combined))
        {
            parser.AddToStream(combined);
        }

        Assert.That(parser.ReadFixMessage(out string readFixMsg1), Is.True);
        Assert.That(readFixMsg1, Is.EqualTo(fixMsg1));

        Assert.That(parser.ReadFixMessage(out string readFixMsg2), Is.True, "parser.ReadFixMessage(readFixMsg2) failure");
        Assert.That(readFixMsg2, Is.EqualTo(fixMsg2));
    }

    [Test] // Issue #282 investigation
    public void ReadFixMessageWithMissingValues()
    {
        string[] fixMsgFields1 = { "8=FIX.4.4", "9=15", "35=B", "148=", "33=0", "10=0" };
        string fixMsg1 = string.Join("\x01", fixMsgFields1) + "\x01";

        Parser parser = new Parser();
        using (CharEncoding.GetBytes(fixMsg1, out ReadOnlySpan<byte> bytesMsg))
        {
            parser.AddToStream(bytesMsg);
        }

        Assert.That(parser.ReadFixMessage(out string readFixMsg1), Is.True);
        Assert.That(readFixMsg1, Is.EqualTo(fixMsg1));
    }

    private static byte[] BytesForEncodingTest() {
        string fixStart = string.Join("\x01", ["8=FIX.4.4", "9=15", "35=B", "148="]);
        string fixEnd = string.Join("\x01", ["", "33=0", "10=0", ""]);

        List<byte> byteList = fixStart.Select(c => Convert.ToByte(c)).ToList();
        byteList.AddRange([0xEF, 0xE8, 0xE2, 0xEE]);
        byteList.AddRange(fixEnd.Select(c => Convert.ToByte(c)));
        return byteList.ToArray();
    }

    [Test]
    public void EncodingComparison()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // needed for windows-1251

        Encoding encodingIso8859 = Encoding.GetEncoding("iso-8859-1"); // QF/n's default
        Encoding encodingAlt = Encoding.GetEncoding("windows-1251");

        byte[] bytes = BytesForEncodingTest();

        Parser parserIso = new Parser(encodingIso8859);
        parserIso.AddToStream(new ReadOnlySpan<byte>(bytes, 0, bytes.Length));
        Assert.That(parserIso.ReadFixMessage(out string isoMessage), Is.True);

        Parser parserAlt = new Parser(encodingAlt);
        parserAlt.AddToStream(new ReadOnlySpan<byte>(bytes, 0, bytes.Length));
        Assert.That(parserAlt.ReadFixMessage(out string altMessage), Is.True);

        Assert.That(isoMessage, Contains.Substring("148=ïèâî"));
        Assert.That(altMessage, Contains.Substring("148=пиво"));
    }
}

