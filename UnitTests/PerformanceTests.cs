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

            for (int i = 0; i < 60000; i++)
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
                        Convert.ToInt32(fields[j].Substring(0, index)), // tag
                        fields[j].Substring(index+1))); // value
                }
            }
            timer.Stop();

            Console.WriteLine("Duration to generate/parse 60000 messages with tags: " + timer.Duration.ToString());
        }
    }
}
