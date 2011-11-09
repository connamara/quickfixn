using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields.Converters;

namespace UnitTests
{
    [TestFixture]
    public class ConverterTests
    {
        [Test]
        public void BoolConverterTest()
        {
            Assert.That(BoolConverter.Convert("Y"), Is.EqualTo(true));
            Assert.That(BoolConverter.Convert("N"), Is.EqualTo(false));
            Assert.That(BoolConverter.Convert(true), Is.EqualTo("Y"));
            Assert.That(BoolConverter.Convert(false), Is.EqualTo("N"));
            Assert.Throws(typeof(FieldConvertError),
                delegate { BoolConverter.Convert("Z"); });
        }

        [Test]
        public void CharConverterTest()
        {
            Assert.That(CharConverter.Convert('A'), Is.EqualTo("A"));
            Assert.That(CharConverter.Convert("B"), Is.EqualTo('B'));
            Assert.Throws(typeof(FieldConvertError),
                delegate { CharConverter.Convert("AB"); });
        }

        [Test]
        public void IntConverterTest()
        {
            Assert.That(IntConverter.Convert(233), Is.EqualTo("233"));
            Assert.That(IntConverter.Convert(-233), Is.EqualTo("-233"));
            Assert.That(IntConverter.Convert("444556"), Is.EqualTo(444556));

            Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert("+100"); });
            Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert("(100)"); });
            Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert("AB"); });
            Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert("2.3234"); });
            Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert(""); });
            Assert.Throws(typeof(FieldConvertError), delegate { IntConverter.Convert(null); });
        }

        [Test]
        public void DecimalConverterTest()
        {
            Assert.That(DecimalConverter.Convert(new Decimal(4.23322)), Is.EqualTo("4.23322"));
            Assert.That(DecimalConverter.Convert(new Decimal(-4.23322)), Is.EqualTo("-4.23322"));
            Assert.That(DecimalConverter.Convert("4332.33"), Is.EqualTo(new Decimal(4332.33)));
            Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert("2.32a34"); });
            Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert("+1.2"); });
            Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert("(1.2)"); });
            Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert(""); });
            Assert.Throws(typeof(FieldConvertError), delegate { DecimalConverter.Convert(null); });
        }

        [Test]
        public void DateTimeConverterTest()
        {
            Assert.That(DateTimeConverter.Convert("20100912-04:22:01.000"), Is.EqualTo(new DateTime(2010, 9, 12, 4, 22, 01, DateTimeKind.Utc)));

            Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05)), Is.EqualTo("20021201-11:03:05.000"));

            Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("20021201-11:03:05.321"));

            Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321), false), Is.EqualTo("20021201-11:03:05"));
            Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321), true), Is.EqualTo("20021201-11:03:05.321"));
            Assert.That(DateTimeConverter.ConvertDateOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("20021201"));
            Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("11:03:05.321"));
            Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), false), Is.EqualTo("11:03:05"));
            Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), true), Is.EqualTo("11:03:05.321"));

            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.Convert(""); });
            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.Convert("20021201"); });
            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.Convert("20021201-11:03"); });
        }


    }
}