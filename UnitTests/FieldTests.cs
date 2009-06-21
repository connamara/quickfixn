using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuickFIX.NET;
using QuickFIX.NET.Fields;

namespace UnitTests
{
    [TestFixture]
    public class FieldTests
    {
        [Test]
        public void IntFieldTest()
        {
            IntField field = new IntField(5, 500);
            Assert.That(field.getValue(), Is.EqualTo(500));
            Assert.That(field.Tag, Is.EqualTo(5));
        }

        [Test]
        public void StringFieldTest()
        {
            StringField field = new StringField(200, "wayner");
            Assert.That(field.Obj, Is.EqualTo("wayner"));
            Assert.That(field.getValue(), Is.EqualTo("wayner"));
            Assert.That(field.Tag, Is.EqualTo(200));
            field.setValue("galway");
            Assert.That(field.Obj, Is.EqualTo("galway"));
        }

        [Test]
        public void CharFieldTest()
        {
            CharField field = new CharField(200, '3');
            Assert.That(field.Obj, Is.EqualTo('3'));
            Assert.That(field.getValue(), Is.EqualTo('3'));
            Assert.That(field.Tag, Is.EqualTo(200));
        }

        [Test]
        public void DecimalFieldTest()
        {
            Decimal val = new Decimal(3.232535);
            Decimal newval = new Decimal(3.14159);
            DecimalField field = new DecimalField(200, val);
            Assert.That(field.Obj, Is.EqualTo(val));
            Assert.That(field.getValue(), Is.EqualTo(val));
            Assert.That(field.Tag, Is.EqualTo(200));
            field.Obj = newval;
            Assert.That(field.Obj, Is.EqualTo(newval));
        }

        [Test]
        public void BooleanFieldTest()
        {
            BooleanField field = new BooleanField(10, true);
            Assert.That(field.Obj, Is.EqualTo(true));
            Assert.That(field.getValue(), Is.EqualTo(true));
            Assert.That(field.Tag, Is.EqualTo(10));
            field.Obj = false;
            Assert.That(field.Obj, Is.EqualTo(false));
        }
    }
}
