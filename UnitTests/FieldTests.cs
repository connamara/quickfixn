using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{
    public class FieldTests
    {
        [Fact]
        public void IntFieldTest()
        {
            IntField field = new IntField(Tags.AdvTransType, 500);
            Assert.Equal(500, field.getValue());
            Assert.Equal(5, field.Tag);
            Assert.Equal("500", field.ToString());
            Assert.Equal(500, field.Obj);
            Assert.Equal(5, field.Tag);
            field.Tag = 10;
            Assert.Equal(10, field.Tag);
        }

        [Fact]
        public void StringFieldTest()
        {
            StringField field = new StringField(200, "wayner");
            Assert.Equal("wayner", field.Obj);
            Assert.Equal("wayner", field.getValue());
            Assert.Equal(200, field.Tag);
            field.setValue("galway");
            Assert.Equal("galway", field.Obj);
        }

        [Fact]
        public void CharFieldTest()
        {
            CharField field = new CharField(200, '3');
            Assert.Equal('3', field.Obj);
            Assert.Equal('3', field.getValue());
            Assert.Equal(200, field.Tag);
        }

        [Fact]
        public void DecimalFieldTest()
        {
            Decimal val = new Decimal(3.232535);
            Decimal newval = new Decimal(3.14159);
            DecimalField field = new DecimalField(200, val);
            Assert.Equal(field.Obj, val);
            Assert.Equal(field.getValue(), val);
            Assert.Equal(200, field.Tag);
            field.Obj = newval;
            Assert.Equal(field.Obj, newval);
        }

        [Fact]
        public void BooleanFieldTest()
        {
            BooleanField field = new BooleanField(10, true);
            Assert.True(field.Obj);
            Assert.True(field.getValue());
            Assert.Equal(10, field.Tag);
            field.Obj = false;
            Assert.False(field.Obj);
        }

        [Fact]
        public void DateTimeFieldTest()
        {
            DateTime val = new DateTime( 2009, 9, 4, 3, 44, 1 );
            DateTime newval = new DateTime(2009, 9, 4, 3, 44, 1);
            DateTimeField field = new DateTimeField(200, val);
            Assert.Equal(field.Obj, val);
            Assert.Equal(field.getValue(), val);
            Assert.Equal(200, field.Tag);
            field.Obj = newval;
            Assert.Equal(field.Obj, newval);
            Assert.Equal("20090904-03:44:01.000", field.ToString());
        }


        [Fact]
        public void StringFieldTest_TotalAndLength()
        {
            // <remarks>
            // from quickfix/j FieldTest.java
            // </remarks>  
            StringField obj = new StringField(12, "VALUE");
            Assert.Equal("12=VALUE", obj.toStringField());
            Assert.Equal(542, obj.getTotal());
            Assert.Equal(9, obj.getLength());
            obj.Obj = "VALUF"; // F = E+1
            Assert.Equal("12=VALUF", obj.toStringField());
            Assert.Equal(543, obj.getTotal());
            Assert.Equal(9, obj.getLength());
            obj.Tag = 13; // 13 = 12+1
            Assert.Equal("13=VALUF", obj.toStringField());
            Assert.Equal(544, obj.getTotal());
            Assert.Equal(9, obj.getLength());
        }

        [Fact]
        public void StringFieldTest_NonAscii()
        {
            // technically, non-ascii shouldn't be in a StringField, but sometimes it happens, so let's not freak out.
            StringField obj = new StringField(359, "olé!");
            Assert.Equal(839, obj.getTotal()); // sum of all bytes in "359=olé!"+nul
            Assert.Equal(10, obj.getLength()); // 7 single-byte chars + 1 double=byte char + nul = 10 bytes
        }

        [Fact]
        public void DefaultValTest()
        {
            BooleanField bf = new BooleanField(110);
            Assert.False(bf.Obj);
            Assert.Equal(110, bf.Tag);
            CharField cf = new CharField(300);
            Assert.Equal('\0', cf.getValue());
            Assert.Equal(300, cf.Tag);
            DateTimeField dtf = new DateTimeField(3);
            Assert.Equal(3, dtf.Tag);
            StringField sf = new StringField(32);
            Assert.Equal(32, sf.Tag);
            Assert.Equal("", sf.Obj);
            IntField ifld = new IntField(239);
            Assert.Equal(239, ifld.Tag);
            Assert.Equal(0, ifld.Obj);
            DecimalField df = new DecimalField(1);
            Assert.Equal(1, df.Tag);
            Assert.Equal(new Decimal(0.0), df.Obj);
        }

        [Fact]
        public void AccountFieldTest()
        {
            Account acct = new Account("iiiD4");
            Assert.Equal("iiiD4", acct.Obj);
            Assert.Equal(Tags.Account, acct.Tag);
        }

        [Fact]
        public void EnumFieldTest()
        {
            CommType ct = new CommType(CommType.PER_UNIT);
            Assert.Equal('1', ct.getValue());
            ExecInst ei = new ExecInst(ExecInst.STRICT_LIMIT);
            Assert.Equal("b", ei.getValue());
            AllocStatus ass = new AllocStatus(AllocStatus.REVERSED);
            Assert.Equal(7, ass.getValue());
        }

        [Fact]
        public void DateOnlyFieldTest()
        {
            MDEntryDate d = new MDEntryDate(new DateTime(2011, 11, 30, 8, 9, 10, 555));
            Assert.Equal("20111130", d.ToString());
        }

        [Fact]
        public void TimeOnlyFieldTest()
        {
            MDEntryTime t = new MDEntryTime(new DateTime(2011, 11, 30, 8, 9, 10, 555), true);
            Assert.Equal("08:09:10.555", t.ToString());

            t = new MDEntryTime(new DateTime(2011, 11, 30, 8, 9, 10, 555), false);
            Assert.Equal("08:09:10", t.ToString());
        }

        [Fact]
        public void EqualsTest()
        {
            StringField a1 = new StringField(123, "a");
            StringField aSame = a1;
            StringField a2 = new StringField(123, "a");
            StringField diffValue = new StringField(123, "b");
            StringField diffTag = new StringField(999, "a");
            IField diffType = new CharField(123, 'a');

            Assert.True(a1.Equals(aSame));
            Assert.True(a1.Equals(a2));
            Assert.False(a1.Equals(diffValue));
            Assert.False(a1.Equals(diffTag));
            Assert.False(a1.Equals(diffType));
        }
    }
}
