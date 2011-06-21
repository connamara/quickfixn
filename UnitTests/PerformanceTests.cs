using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{
    /// <summary>
    /// TODO: Move performance-related tests into PerformanceTests project.
    /// </summary>
    [Ignore("Not running perf tests as part of unit test suite.")]
    [TestFixture]
    public class PerformanceTests
    {
        [Test]
        public void TestParsePerformance()
        {
            string fix = GenRandomFIXString();

            HiPerfTimer timer = new HiPerfTimer();
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
            idx = fix.IndexOf('\x01');
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
                idx = fix.IndexOf('\x01', prevIdx + 1);

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
        public void TestNewParser()
        {
            HiPerfTimer timer = new HiPerfTimer();
            string fix = GenRandomFIXString();

            const int times = 50000;
            timer.Start();
            for (int i = 0; i < times; i++)
            {
                Message m = new Message();
                m.FromString(fix);
            }
            timer.Stop();
            Console.WriteLine("Total per second [new parser]: " + ((1 / timer.Duration) * times).ToString());
        }

        [Test]
        public void TestMessageParserIntegrity()
        {
            string fix = "5=ASDF" + Message.SOH + "10=234" + Message.SOH;

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
                sb.Append("\x01");
            }

            return sb.ToString();
        }

        #region General C# Performance Testing
        private class MyClass
        {
            public MyClass(int x) { _x = x; }

            public int X { get { return _x; } set { _x = value; } }

            private int _x;
        }

        private struct MyStruct
        {
            public MyStruct(int x) { _x = x; }

            public int X { get { return _x; } set { _x = value; } }

            private int _x;
        }

        private class MyClassWithSmallClasses
        {
            public MyClassWithSmallClasses(int numObjects)
            {
                classes = new List<MyClass>(numObjects);

                for (int i = 0; i < numObjects; i++)
                    classes.Add(new MyClass(i));
            }

            private List<MyClass> classes;
        }

        private class MyClassWithSmallStructs
        {
            public MyClassWithSmallStructs(int numObjects)
            {
                structs = new List<MyStruct>(numObjects);

                for (int i = 0; i < numObjects; i++)
                    structs.Add(new MyStruct(i));
            }

            private List<MyStruct> structs;
        }

        [Test]
        public void TestStructVsClass()
        {
            HiPerfTimer timer = new HiPerfTimer();
            const int num = 1000000;

            timer.Start();

            List<MyClass> classes = new List<MyClass>(num);
            for (int i = 0; i < num; i++)
                classes.Add(new MyClass(i));

            timer.Stop();

            Console.WriteLine("Constructing {0} classes: {1}", num, timer.Duration.ToString());

            timer.Start();

            List<MyStruct> structs = new List<MyStruct>(num);
            for (int i = 0; i < num; i++)
                structs.Add(new MyStruct(i));

            timer.Stop();

            Console.WriteLine("Constructing {0} structs: {1}", num, timer.Duration.ToString());

            timer.Start();
            MyClassWithSmallClasses test1 = new MyClassWithSmallClasses(num);
            timer.Stop();

            Console.WriteLine("Duration to construct large class containing smaller classes: " + timer.Duration.ToString());

            timer.Start();
            MyClassWithSmallStructs test2 = new MyClassWithSmallStructs(num);
            timer.Stop();

            Console.WriteLine("Duration to construct large class containing smaller structs: " + timer.Duration.ToString());
        }

        [Test]
        public void TestUTFByteEncoding()
        {
            string test = "LKDSAJFLAKJSFLKJFLAKSJFLAKSJFASLFASDJLFLKASFLKAFSJLKALKFSKJASLFLAFSJKLKJAFSLAALKSFKJLSAFLJKFSALJKAFSLJKAFSJKLAFSKJLFSAKJLFASKLJAFSKJLAFSLJKAFSKJLFSKJLFSALJKFSAJKLAFSLJKAFSJKLFSJKKJLAFS";
            const int numIterations = 50000;
            HiPerfTimer timer = new HiPerfTimer();
            timer.Start();
            for (int i = 0; i < numIterations; i++)
            {
                byte[] utf8 = Encoding.UTF8.GetBytes(test);
            }
            timer.Stop();

            Console.WriteLine("Total UTF8 per second for " + test.Length + "-character strings: " + ((1 / timer.Duration) * numIterations).ToString());

            timer.Start();
            for (int i = 0; i < numIterations; i++)
            {
                byte[] utf16 = Encoding.Unicode.GetBytes(test);
            }
            timer.Stop();

            Console.WriteLine("Total UTF16 per second for " + test.Length + "-character strings: " + ((1 / timer.Duration) * numIterations).ToString());
        }



        #endregion

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
