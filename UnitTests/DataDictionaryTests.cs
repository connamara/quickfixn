using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class DataDictionaryTests
    {
        [Test]
        public void FieldEntryTest()
        {
            QuickFix.DataDictionaryParser dd = new QuickFix.DataDictionaryParser();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.MajorVersion, Is.EqualTo("4"));
            Assert.That(dd.MinorVersion, Is.EqualTo("4"));
            Assert.That(dd.Version, Is.EqualTo("FIX.4.4"));
        }

        [Test]
        public void MakeFromType()
        {
            DataDictionaryParser dd = new DataDictionaryParser();
            dd.Load("../../../spec/fix/FIX44.xml");
            Type ft = dd.GetFieldType(1);
            QuickFix.Fields.StringField field = (QuickFix.Fields.StringField)Activator.CreateInstance(dd.GetFieldType(1),1);
            field.Tag = 1;
            field.Obj = "2";
            Assert.That(field.Tag, Is.EqualTo(1));
            Assert.That(field.Obj, Is.EqualTo("2"));
        }

        [Test]
        public void ValidFieldTagTest()
        {
            DataDictionaryParser dd = new DataDictionaryParser();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.ValidFieldTag(1), Is.EqualTo(true));
            Assert.That(dd.ValidFieldTag(742), Is.EqualTo(true));
            Assert.That(dd.ValidFieldTag(203948), Is.EqualTo(false));
        }

        [Test]
        public void GetTagFromNameTest()
        {
            DataDictionaryParser dd = new DataDictionaryParser();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.GetTagFromName("Account"), Is.EqualTo(1));
            Assert.That(dd.GetTagFromName("OfferForwardPoints"), Is.EqualTo(191));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { dd.GetTagFromName("wayner___"); });
        }

        [Test]
        public void GetNameTest()
        {
            DataDictionaryParser dd = new DataDictionaryParser();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.GetFieldName(1), Is.EqualTo("Account"));
            Assert.That(dd.GetFieldName(191), Is.EqualTo("OfferForwardPoints"));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { dd.GetFieldName(13030948); });
        }

        [Test]
        public void BadXmlTests()
        {            
            Assert.Throws(typeof(DictionaryParseException),
                delegate { new DataDictionaryParser().Load("../../TestFiles/MissingFieldName.xml"); });
            Assert.Throws(typeof(DictionaryParseException),
                delegate { new DataDictionaryParser().Load("../../TestFiles/MissingNumber.xml"); });
            Assert.Throws(typeof(DictionaryParseException),
                delegate { new DataDictionaryParser().Load("../../TestFiles/MissingType.xml"); });
            Assert.Throws(typeof(DictionaryParseException),
                delegate { new DataDictionaryParser().Load("../../TestFiles/DuplicateField.xml"); });
        }

        [Test]
        public void ReqFieldsSetTest()
        {
            DataDictionaryParser dd = new DataDictionaryParser();
            dd.Load("../../../spec/fix/FIX44.xml");
            HashSet<int> logonFields = new HashSet<int>();
            Assert.Throws(typeof(MissingRequiredFieldException),
                delegate { dd.ReqFieldsSet("A", logonFields); });
            logonFields.Add(98);
            logonFields.Add(108);
            Assert.That(dd.ReqFieldsSet("A", logonFields), Is.EqualTo(true));
            logonFields.Add(109);
            Assert.That(dd.ReqFieldsSet("A", logonFields), Is.EqualTo(true));
            Assert.Throws(typeof(InvalidMessageTypeException),
                delegate { dd.ReqFieldsSet("__wayner", logonFields); });
        }

        [Test]
        public void ReqFieldsSetWithComponentsTest()
        {
            DataDictionaryParser dd = new DataDictionaryParser();
            dd.Load("../../../spec/fix/FIX44.xml");
            HashSet<int> ioiFields = new HashSet<int>();
            Assert.Throws(typeof(MissingRequiredFieldException),
                delegate { dd.ReqFieldsSet("6", ioiFields); });
            ioiFields.Add(23);
            ioiFields.Add(28);
            Assert.Throws(typeof(MissingRequiredFieldException),
                delegate { dd.ReqFieldsSet("6", ioiFields); });
            ioiFields.Add(55);
            ioiFields.Add(54);
            ioiFields.Add(27);
            Assert.That(dd.ReqFieldsSet("6", ioiFields), Is.EqualTo(true));
            ioiFields.Add(109);
            Assert.That(dd.ReqFieldsSet("6", ioiFields), Is.EqualTo(true));
            Assert.Throws(typeof(InvalidMessageTypeException),
                delegate { dd.ReqFieldsSet("__wayner", ioiFields); });
        }

        [Test]
        public void ReqFieldsSetWithGroupTest()
        {
            DataDictionaryParser dd = new DataDictionaryParser();
            dd.Load("../../../spec/fix/FIX44.xml");
            HashSet<int> emailFields = new HashSet<int>();
            Assert.Throws(typeof(MissingRequiredFieldException),
                delegate { dd.ReqFieldsSet("C", emailFields); });
            emailFields.Add(164);
            emailFields.Add(94);
            Assert.Throws(typeof(MissingRequiredFieldException),
                delegate { dd.ReqFieldsSet("C", emailFields); });
            emailFields.Add(33);  // NumInGroup field
            emailFields.Add(147);
            emailFields.Add(58);
            Assert.That(dd.ReqFieldsSet("C", emailFields), Is.EqualTo(true));
            emailFields.Add(109);
            Assert.That(dd.ReqFieldsSet("C", emailFields), Is.EqualTo(true));
        }

        [Test]
        public void ReqFieldsSetWithGroupTest2()
        {
            DataDictionaryParser dd = new DataDictionaryParser();
            dd.Load("../../../spec/fix/FIX44.xml");
            HashSet<int> emailFields = new HashSet<int>();
            Assert.Throws(typeof(MissingRequiredFieldException),
                delegate { dd.ReqFieldsSet("C", emailFields); });
            emailFields.Add(146);
            emailFields.Add(131);
            Assert.Throws(typeof(MissingRequiredFieldException),
                delegate { dd.ReqFieldsSet("C", emailFields); });
            emailFields.Add(55);
            emailFields.Add(164);
            emailFields.Add(94);
            emailFields.Add(147);
            emailFields.Add(58);
            emailFields.Add(33);
            Assert.That(dd.ReqFieldsSet("C", emailFields), Is.EqualTo(true));
            emailFields.Add(109);
            Assert.That(dd.ReqFieldsSet("C", emailFields), Is.EqualTo(true));
        }
    }
}