using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using NUnit.Framework;
using QuickFix.DataDictionary;

namespace UnitTests
{
    [TestFixture]
    public class DDFieldTests
    {
        [Test]
        public void CtorEnum()
        {
            Dictionary<String, String> enums = new Dictionary<string, string>();
            enums["a"] = "AAA";
            enums["b"] = "BBB";

            DDField ddf = new DDField(5, "Foo", enums, "STRING");

            Assert.AreEqual(ddf.Tag, 5);
            Assert.AreEqual(ddf.Name, "Foo");
            Assert.AreEqual(ddf.EnumDict, enums);
            Assert.AreEqual(ddf.FixFldType, "STRING");
            Assert.AreEqual(ddf.FieldType, typeof(QuickFix.Fields.StringField));

            Assert.IsFalse(ddf.IsMultipleValueFieldWithEnums);
            Assert.IsTrue(ddf.HasEnums());
        }

        [Test]
        public void CtorMultipleValueFieldWithEnums()
        {
            DDField ddf = new DDField(111, "MultiX", new Dictionary<string, string>(), "MULTIPLEVALUESTRING");

            Assert.AreEqual(ddf.Tag, 111);
            Assert.AreEqual(ddf.Name, "MultiX");
            Assert.AreEqual(ddf.EnumDict.Count, 0);
            Assert.AreEqual(ddf.FixFldType, "MULTIPLEVALUESTRING");
            Assert.AreEqual(ddf.FieldType, typeof(QuickFix.Fields.StringField));

            Assert.IsTrue(ddf.IsMultipleValueFieldWithEnums);
            Assert.IsFalse(ddf.HasEnums());
        }
    }
}
