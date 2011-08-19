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

        [Test]
        public void RequiredHeaderFields()
        {
            DataDictionaryParser dd = new DataDictionaryParser("../../../spec/fix/FIX42.xml");
            HashSet<int> reqFields = dd.GetRequiredHeaderFields();
            Assert.True(reqFields.Contains(QuickFix.Fields.Tags.SenderCompID));
            Assert.True(reqFields.Contains(QuickFix.Fields.Tags.TargetCompID));
            Assert.False(reqFields.Contains(QuickFix.Fields.Tags.CheckSum));
            Assert.False(reqFields.Contains(QuickFix.Fields.Tags.ClOrdID));
        }

        [Test]
        public void RequiredTrailerFields()
        {
            DataDictionaryParser dd = new DataDictionaryParser("../../../spec/fix/FIX42.xml");
            HashSet<int> reqFields = dd.GetRequiredTrailerFields();
            Assert.True(reqFields.Contains(QuickFix.Fields.Tags.CheckSum));
            Assert.False(reqFields.Contains(QuickFix.Fields.Tags.SenderCompID));
            Assert.False(reqFields.Contains(QuickFix.Fields.Tags.ClOrdID));
        }

        [Test]
        public void CheckHasRequired()
        {
            DataDictionaryParser dd = new DataDictionaryParser("../../../spec/fix/FIX42.xml");
            
            // missing tag 56
            Message badMsg = new Message("8=FIX.4.2\x01" + "9=37\x01" + "35=0\x01" + "34=2\x01" + "49=TW\x01" + "52=20110625-08:45:00\x01" + "10=011\x01");
            Assert.Throws<RequiredTagMissing>(delegate { dd.CheckHasRequired(badMsg, QuickFix.Fields.MsgType.HEARTBEAT); });
            
            // no missing tags
            Message goodMsg = new Message("8=FIX.4.2\x01" + "9=45\x01" + "35=0\x01" + "34=2\x01" + "49=TW\x01" + "56=MJKG\x01" + "52=20110625-08:45:00\x01" + "10=220\x01");
            try
            {
                dd.CheckHasRequired(goodMsg, QuickFix.Fields.MsgType.HEARTBEAT);
            }
            catch (RequiredTagMissing e)
            {
                Assert.Fail("Unexpected exception (RequiredTagMissing): " + e.Message + " (" + e.field + ")");
            }
        }

        [Test]
        public void CheckValidTagNumber()
        {
            DataDictionaryParser dd = new DataDictionaryParser("../../../spec/fix/FIX42.xml");
            Assert.Throws<InvalidTagNumber>(delegate { dd.CheckValidTagNumber(5000); });
            Assert.DoesNotThrow(delegate { dd.CheckValidTagNumber(49); });
            Assert.DoesNotThrow(delegate { dd.CheckValidTagNumber(10); });
            Assert.DoesNotThrow(delegate { dd.CheckValidTagNumber(58); });
        }
    }
}