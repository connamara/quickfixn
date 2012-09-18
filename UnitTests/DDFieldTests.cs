using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;
using QuickFix.DataDictionary;

namespace UnitTests
{
    [TestFixture]
    public class DDFieldTests
    {
        [Test]
        public void Constructor()
        {
            Dictionary<String, String> enums = new Dictionary<string, string>();
            enums["a"] = "AAA";
            enums["b"] = "BBB";

            DDField ddf = new DDField(5, "Foo", enums, "STRING");

            Assert.AreEqual(2, ddf.EnumDict.Count);
            Assert.AreEqual("AAA", ddf.EnumDict["a"]);
            Assert.AreEqual("BBB", ddf.EnumDict["b"]);

            //obsolete accessor
            Assert.AreEqual(2, ddf.Enums.Count);
            Assert.IsTrue(ddf.Enums.Contains("a"));
            Assert.IsTrue(ddf.Enums.Contains("b"));
        }


        [Test]
        public void ObsoleteConstructor()
        {
            HashSet<String> enums = new HashSet<string>();
            enums.Add("a");
            enums.Add("b");

            DDField ddf = new DDField(5, "Foo", enums, "STRING");

            Assert.AreEqual(String.Empty, ddf.EnumDict["a"]);
            Assert.AreEqual(String.Empty, ddf.EnumDict["b"]);
            
            //obsolete accessor
            Assert.AreEqual(2,ddf.Enums.Count);
            Assert.IsTrue(ddf.Enums.Contains("a"));
            Assert.IsTrue(ddf.Enums.Contains("b"));
        }
    }
}
