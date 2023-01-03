using System;
using System.Collections.Generic;
using NUnit.Framework;
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
        }
    }
}
