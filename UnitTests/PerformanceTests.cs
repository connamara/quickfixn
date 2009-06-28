using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFIX.NET;
using QuickFIX.NET.Fields;

namespace UnitTests
{
    /// <summary>
    /// TODO: Move performance-related tests into PerformanceTests project.
    /// </summary>
    [TestFixture]
    public class PerformanceTests
    {
        [Test]
        public void TestSplitPerformance()
        {
            string fix = GenRandomFIXString();

            // Split 1000 times
            HiPerfTimer timer = new HiPerfTimer();
            timer.Start();
            for (int i = 0; i < 1000; i++)
            {
                string[] fields = fix.Split('\u0001');
            }

            timer.Stop();
            Console.WriteLine();
            Console.WriteLine("Duration for string split: " + timer.Duration.ToString());

            // Generate FieldMap with actual tags/values:

            timer.Start();

            const int numMsgs = 50000;

            for (int i = 0; i < numMsgs; i++)
            {
                Message m = new Message();
                MakeMessage(m, fix);
            }
            timer.Stop();

            Console.WriteLine("Total per second: " + ((1 / timer.Duration) * numMsgs).ToString());

            // Test message creation latency.

            timer.Start();
            Message newMsg = new Message();
            MakeMessage(newMsg, fix);
            timer.Stop();

            Console.WriteLine(
                String.Format("Latency for parsing one FIX message in microseconds: {0}", (timer.Duration * 1000000).ToString()));
        }

        private static int idx = 0, prevIdx = 0;
        private static int tagIndex = 0;
        private static string field = string.Empty;

        public void MakeMessage(Message m, string fix)
        {
            idx = 0; prevIdx = 0;

            // Handle first field differently, no SOH at start.
            StringField sf = new StringField(0);
            idx = fix.IndexOf('\u0001');
            if (idx != -1)
            {
                field = fix.Substring(prevIdx, (idx - prevIdx));
                tagIndex = field.IndexOf('=');

                sf.Tag = IntParse(field.Substring(0, tagIndex));
                sf.Obj = field.Substring(tagIndex + 1);
                m.setField(sf);
            }
            else return;

            while (idx != -1)
            {
                prevIdx = idx;
                idx = fix.IndexOf('\u0001', prevIdx + 1);

                if (idx == -1) break;

                StringField sf2 = new StringField(0);
                field = fix.Substring(prevIdx + 1, (idx - prevIdx) - 1);
                tagIndex = field.IndexOf('=');

                sf2.Tag = IntParse(field.Substring(0, tagIndex));
                sf2.Obj = field.Substring(tagIndex + 1);
                m.setField(sf2);
            }
        }

        [Test]
        public void TestMessageParserIntegrity()
        {
            string fix = "5=ASDF\u000110=234\u0001";

            Message m = new Message();
            StringField sf = new StringField(0);

            MakeMessage(m, fix);

            Assert.That(m.GetField(5), Is.EqualTo("ASDF"));
            Assert.That(m.GetField(10), Is.EqualTo("234"));
        }

        public static string GenRandomFIXString()
        {
            // Generate random FIX string with 30 fields and parse it out.
            StringBuilder sb = new StringBuilder();

            Random rand = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < 30; i++)
            {
                sb.Append(i.ToString());
                sb.Append("=");
                sb.Append(rand.Next());
                sb.Append("\u0001");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Custom IntParser increases performance of FIX parsing by 33%
        /// </summary>
        /// <param name="stringToConvert"></param>
        /// <returns></returns>
        public unsafe static int IntParse(string stringToConvert)
        {
            int value = 0;
            int length = stringToConvert.Length;
            fixed (char* characters = stringToConvert)
            {
                for (int i = 0; i < length; ++i)
                {
                    value = 10 * value + (characters[i] - 48);
                }
            }
            return value;
        }
    }
}
