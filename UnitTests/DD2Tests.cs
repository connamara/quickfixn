using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class DD2Tests
    {
        [Test]
        public void VersionTest()
        {
            QuickFix.DataDictionary.DD2 dd = new QuickFix.DataDictionary.DD2();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.MajorVersion, Is.EqualTo("4"));
            Assert.That(dd.MinorVersion, Is.EqualTo("4"));
            Assert.That(dd.Version, Is.EqualTo("FIX.4.4"));
        }

        [Test]
        public void LoadFieldsTest()
        {
            QuickFix.DataDictionary.DD2 dd = new QuickFix.DataDictionary.DD2();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.FieldsByTag[1].Name, Is.EqualTo("Account"));
            Assert.That(dd.FieldsByName["Account"].Tag, Is.EqualTo(1));
            Assert.That(dd.FieldsByTag[1].Enums.Count, Is.EqualTo(0));
            Assert.That(dd.FieldsByTag[QuickFix.Fields.Tags.StatusValue].Enums.Count, Is.EqualTo(4));
        }

        [Test]
        public void FieldHasValueTest()
        {
            QuickFix.DataDictionary.DD2 dd = new QuickFix.DataDictionary.DD2();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "1"), Is.EqualTo(true));
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "CONNECTED"), Is.EqualTo(false));
        }

        [Test]
        public void BasicMessageTest()
        {
            QuickFix.DataDictionary.DD2 dd = new QuickFix.DataDictionary.DD2();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.Messages["3"].Fields.Count, Is.EqualTo(7));
        }
    }
}
