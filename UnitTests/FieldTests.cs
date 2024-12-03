using System;
using NUnit.Framework;
using QuickFix.Fields;
using UnitTests.TestHelpers;
using StringField = QuickFix.Fields.StringField;

namespace UnitTests
{
    [TestFixture]
    public class FieldTests
    {
        [Test]
        public void Tag()
        {
            // three paths to this value
            Assert.That(QuickFix.Fields.Account.TAG, Is.EqualTo(1));
            Assert.That(new QuickFix.Fields.Account().Tag, Is.EqualTo(1));
            Assert.That(QuickFix.Fields.Tags.Account, Is.EqualTo(1));
        }

        [Test]
        public void IntFieldTest()
        {
            IntField field = new IntField(Tags.AdvTransType, 500);
            Assert.That(field.Value, Is.EqualTo(500));
            Assert.That(field.Tag, Is.EqualTo(5));
            Assert.That(field.ToString(), Is.EqualTo("500"));
            Assert.That(field.Value, Is.EqualTo(500));
            Assert.That(field.Tag, Is.EqualTo(5));
            field.Tag = 10;
            Assert.That(field.Tag, Is.EqualTo(10));
        }

        [Test]
        public void StringFieldTest()
        {
            StringField field = new StringField(200, "wayner");
            Assert.That(field.Value, Is.EqualTo("wayner"));
            Assert.That(field.Value, Is.EqualTo("wayner"));
            Assert.That(field.Tag, Is.EqualTo(200));
            field.Value = "galway";
            Assert.That(field.Value, Is.EqualTo("galway"));
        }

        [Test]
        public void CharFieldTest()
        {
            CharField field = new CharField(200, '3');
            Assert.That(field.Value, Is.EqualTo('3'));
            Assert.That(field.Value, Is.EqualTo('3'));
            Assert.That(field.Tag, Is.EqualTo(200));
        }

        [Test]
        public void DecimalFieldTest()
        {
            Decimal val = new Decimal(3.232535);
            Decimal newval = new Decimal(3.14159);
            DecimalField field = new DecimalField(200, val);
            Assert.That(field.Value, Is.EqualTo(val));
            Assert.That(field.Value, Is.EqualTo(val));
            Assert.That(field.Tag, Is.EqualTo(200));
            field.Value = newval;
            Assert.That(field.Value, Is.EqualTo(newval));
        }

        [Test]
        public void BooleanFieldTest()
        {
            BooleanField field = new BooleanField(10, true);
            Assert.That(field.Value, Is.EqualTo(true));
            Assert.That(field.Value, Is.EqualTo(true));
            Assert.That(field.Tag, Is.EqualTo(10));
            field.Value = false;
            Assert.That(field.Value, Is.EqualTo(false));
        }

        [Test]
        public void DateTimeFieldTest()
        {
            DateTime val = new DateTime( 2009, 9, 4, 3, 44, 1 );
            DateTime newval = new DateTime(2009, 9, 4, 3, 44, 1);
            DateTimeField field = new DateTimeField(200, val);
            Assert.That(field.Value, Is.EqualTo(val));
            Assert.That(field.Value, Is.EqualTo(val));
            Assert.That(field.Tag, Is.EqualTo(200));
            field.Value = newval;
            Assert.That(field.Value, Is.EqualTo(newval));
            Assert.That(field.ToString(), Is.EqualTo("20090904-03:44:01.000"));
        }
        
        [Test]
        public void DateTimeFieldNanoTest()
        {
            DateTime val = TimeHelper.MakeDateTime(2009, 9, 4, 3, 44, 1, 100, 310, 300);
            DateTime newval = TimeHelper.MakeDateTime(2009, 9, 4, 3, 44, 1, 100, 310, 300);
            DateTimeField field = new DateTimeField(200, val, QuickFix.Fields.Converters.TimeStampPrecision.Nanosecond);
            Assert.That(field.Value, Is.EqualTo(val));
            Assert.That(field.Value, Is.EqualTo(val));
            Assert.That(field.Tag, Is.EqualTo(200));
            field.Value = newval;
            Assert.That(field.Value, Is.EqualTo(newval));
            Assert.That(field.ToString(), Is.EqualTo("20090904-03:44:01.100310300"));
        }
        
        [Test]
        public void StringFieldTest_TotalAndLength()
        {
            StringField obj = new StringField(12, "VALUE");
            Assert.That(obj.ToStringField(), Is.EqualTo("12=VALUE"));
            Assert.That(obj.GetTotal(), Is.EqualTo(542));
            Assert.That(obj.GetLength(), Is.EqualTo(9));
            obj.Value = "VALUF"; // F = E+1
            Assert.That(obj.ToStringField(), Is.EqualTo("12=VALUF"));
            Assert.That(obj.GetTotal(), Is.EqualTo(543));
            Assert.That(obj.GetLength(), Is.EqualTo(9));
            obj.Tag = 13; // 13 = 12+1
            Assert.That(obj.ToStringField(), Is.EqualTo("13=VALUF"));
            Assert.That(obj.GetTotal(), Is.EqualTo(544));
            Assert.That(obj.GetLength(), Is.EqualTo(9));

            // latin-1-specific character
            obj = new StringField(359, "olé!"); // the é is single-byte in iso-8859-1, but is 2 bytes in ascii or utf-8
            Assert.That(obj.GetTotal(), Is.EqualTo(708)); // sum of all bytes in "359=olé!"+nul
            Assert.That(obj.GetLength(), Is.EqualTo(9));  // 8 single-byte chars + 1 nul char
        }

        [Test]
        public void DefaultValTest()
        {
            BooleanField bf = new BooleanField(110);
            Assert.That(false, Is.EqualTo(bf.Value));
            Assert.That(110, Is.EqualTo(bf.Tag));
            CharField cf = new CharField(300);
            Assert.That('\0', Is.EqualTo(cf.Value));
            Assert.That(300, Is.EqualTo(cf.Tag));
            DateTimeField dtf = new DateTimeField(3);
            Assert.That(3, Is.EqualTo(dtf.Tag));
            StringField sf = new StringField(32);
            Assert.That(32, Is.EqualTo(sf.Tag));
            Assert.That("", Is.EqualTo(sf.Value));
            IntField ifld = new IntField(239);
            Assert.That(239, Is.EqualTo(ifld.Tag));
            Assert.That(0, Is.EqualTo(ifld.Value));
            DecimalField df = new DecimalField(1);
            Assert.That(1, Is.EqualTo(df.Tag));
            Assert.That(new Decimal(0.0), Is.EqualTo(df.Value));
        }

        [Test]
        public void AccountFieldTest()
        {
            Account acct = new Account("iiiD4");
            Assert.That("iiiD4", Is.EqualTo(acct.Value));
            Assert.That(Tags.Account, Is.EqualTo(acct.Tag));
        }

        [Test]
        public void EnumFieldTest()
        {
            CommType ct = new CommType(CommType.PER_UNIT);
            Assert.That('1', Is.EqualTo(ct.Value));
            ExecInst ei = new ExecInst(ExecInst.STRICT_LIMIT);
            Assert.That("b", Is.EqualTo(ei.Value));
            AllocStatus ass = new AllocStatus(AllocStatus.REVERSED);
            Assert.That(7, Is.EqualTo(ass.Value));
        }

        [Test]
        public void DateOnlyFieldTest()
        {
            MDEntryDate d = new MDEntryDate(new DateTime(2011, 11, 30, 8, 9, 10, 555));
            Assert.That(d.ToString(), Is.EqualTo("20111130"));
        }

        [Test]
        public void TimeOnlyFieldTest()
        {
            MDEntryTime t = new MDEntryTime(new DateTime(2011, 11, 30, 8, 9, 10, 555), true);
            Assert.That(t.ToString(), Is.EqualTo("08:09:10.555"));

            t = new MDEntryTime(new DateTime(2011, 11, 30, 8, 9, 10, 555), false);
            Assert.That(t.ToString(), Is.EqualTo("08:09:10"));
        }

        [Test]
        public void EqualsTest()
        {
            StringField a1 = new StringField(123, "a");
            StringField aSame = a1;
            StringField a2 = new StringField(123, "a");
            StringField diffValue = new StringField(123, "b");
            StringField diffTag = new StringField(999, "a");
            IField diffType = new CharField(123, 'a');

            Assert.That(a1.Equals(aSame), Is.True);
            Assert.That(a1.Equals(a2), Is.True);
            Assert.That(a1.Equals(diffValue), Is.False);
            Assert.That(a1.Equals(diffTag), Is.False);
            Assert.That(a1.Equals(diffType), Is.False);
        }
    }
}
