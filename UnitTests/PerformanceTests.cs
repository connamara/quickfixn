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

            string fix = sb.ToString();

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

            // Reusable string field to avoid allocations.
            StringField sf = new StringField(0);


            for (int i = 0; i < numMsgs; i++)
            {
                Message m = new Message();
                MakeMessage(m, fix, sf);
            }
            timer.Stop();

            Console.WriteLine("Total per second: " + ((1 / timer.Duration) * numMsgs).ToString());

            // Test message creation latency.

            timer.Start();
            Message newMsg = new Message();
            MakeMessage(newMsg, fix, sf);
            timer.Stop();

            Console.WriteLine(
                String.Format("Latency for parsing one FIX message in microseconds: {0}", (timer.Duration * 1000000).ToString()));
        }

        private static int idx = 0, prevIdx = 0;
        private static int tagIndex = 0;
        private static string field = string.Empty;

        public void MakeMessage(Message m, string fix, StringField sf)
        {
            while (idx != -1)
            {
                prevIdx = idx;
                idx = fix.IndexOf('\u0001', prevIdx + 1);

                if (idx == -1) break;

                try
                {
                    field = fix.Substring(prevIdx, (idx - prevIdx) - 1);
                    tagIndex = fix.Substring(prevIdx, idx - prevIdx).IndexOf('=');
                }
                catch (Exception)
                {
                    Console.WriteLine("Index: " + idx);
                }

                sf.Tag = IntParse(field.Substring(0, tagIndex));
                sf.Obj = field.Substring(tagIndex + 1);
                m.setField(sf);
            }
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
