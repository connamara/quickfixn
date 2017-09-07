using System;
using System.Collections.Generic;
using Xunit;
using QuickFix;
using QuickFix.DataDictionary;

namespace UnitTests
{
    public class DDFieldTests
    {
        [Fact]
        public void Constructor()
        {
            Dictionary<String, String> enums = new Dictionary<string, string>();
            enums["a"] = "AAA";
            enums["b"] = "BBB";

            DDField ddf = new DDField(5, "Foo", enums, "STRING");

            Assert.Equal(2, ddf.EnumDict.Count);
            Assert.Equal("AAA", ddf.EnumDict["a"]);
            Assert.Equal("BBB", ddf.EnumDict["b"]);

            //obsolete accessor
#pragma warning disable 618
            Assert.Equal(2, ddf.Enums.Count);
            Assert.Contains("a", ddf.Enums);
            Assert.Contains("b", ddf.Enums);
#pragma warning restore 618
        }


        [Fact]
        public void ObsoleteConstructor()
        {
            HashSet<String> enums = new HashSet<string>();
            enums.Add("a");
            enums.Add("b");

#pragma warning disable 618
            DDField ddf = new DDField(5, "Foo", enums, "STRING");
#pragma warning restore 618

            Assert.Equal(String.Empty, ddf.EnumDict["a"]);
            Assert.Equal(String.Empty, ddf.EnumDict["b"]);

            //obsolete accessor
#pragma warning disable 618
            Assert.Equal(2,ddf.Enums.Count);
            Assert.Contains("a", ddf.Enums);
            Assert.Contains("b", ddf.Enums);
#pragma warning restore 618
        }
    }
}
