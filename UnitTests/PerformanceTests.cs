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

            for (int i = 0; i < numMsgs; i++)
            {
                Message m = new Message();

                // Consider replacing split here with an iterative approach.
                string[] fields = fix.Split('\u0001');

                for (int j = 0; j < fields.Length-1; j++)
                {
                    // Split is far less performant here!
                    //string[] tag = fields[j].Split('=');
                    int index = fields[j].IndexOf('=');

                    m.setField(new StringField(
                        IntParse(fields[j].Substring(0, index)), // tag
                        fields[j].Substring(index+1))); // value
                }
            }
            timer.Stop();

            Console.WriteLine("Total per second: " + ((1 / timer.Duration) * numMsgs).ToString());
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
