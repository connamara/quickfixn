using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFIX.NET;
using QuickFIX.NET.Fields;

namespace UnitTests
{
    public class MockFieldMap : FieldMap {}

    [TestFixture]
    public class FieldMapTests
    {
        private MockFieldMap fieldmap;
        public FieldMapTests()
        {
            this.fieldmap = new MockFieldMap();
        }

        [Test]
        public void CharFieldTest()
        {
           
            CharField field = new CharField(100,'d');
            fieldmap.setField(field);
            CharField refield = new CharField(100);
            fieldmap.getField(refield);
            Assert.That('d', Is.EqualTo(refield.Obj));
            field.Obj = 'e';
            fieldmap.setField(field);
            fieldmap.getField(refield);
            Assert.That('e', Is.EqualTo(refield.Obj));
        }

        [Test]
        public void StringFieldTest()
        {

            fieldmap.setField(new Account("hello"));
            Account acct = new Account();
            fieldmap.getField(acct);
            Assert.That("hello", Is.EqualTo(acct.Obj));
            fieldmap.setField(new Account("helloworld"));
            fieldmap.getField(acct);
            Assert.That("helloworld", Is.EqualTo(acct.getValue()));
        }

        [Test]
        public void BooleanFieldTest()
        {
            BooleanField field = new BooleanField(200, true);
            BooleanField refield = new BooleanField(200);
            fieldmap.setField(field);
            fieldmap.getField(refield);
            Assert.That(true, Is.EqualTo(refield.Obj));
            field.setValue(false);
            fieldmap.setField(field);
            fieldmap.getField(refield);
            Assert.That(false, Is.EqualTo(refield.Obj));
        }

        [Test]
        public void IntFieldTest()
        {

            IntField field = new IntField(200, 101);
            IntField refield = new IntField(200);
            fieldmap.setField(field);
            fieldmap.getField(refield);
            Assert.That(101, Is.EqualTo(refield.Obj));
            field.setValue(102);
            fieldmap.setField(field);
            fieldmap.getField(refield);
            Assert.That(102, Is.EqualTo(refield.Obj));
        }

        [Test]
        public void DecimalFieldTest()
        {
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            DecimalField refield = new DecimalField(200);
            fieldmap.setField(field);
            fieldmap.getField(refield);
            Assert.That(101.0001, Is.EqualTo(refield.Obj));
            field.setValue(new Decimal(101.0002));
            fieldmap.setField(field);
            fieldmap.getField(refield);
            Assert.That(101.0002, Is.EqualTo(refield.Obj));
        }

        [Test]
        public void DefaultFieldTest()
        {
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            fieldmap.setField(field);
            string refield = fieldmap.getField(200);
            Assert.That("101.0001", Is.EqualTo(refield));
     
        }
    }
}
