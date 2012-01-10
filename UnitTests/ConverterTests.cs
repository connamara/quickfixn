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

            // check for a different culture than en-XX 
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo( "tr-TR" );
            Assert.That( DecimalConverter.Convert( "4332.33" ), Is.EqualTo( new Decimal( 4332.33 ) ) );
            Assert.That( DecimalConverter.Convert( "-2.33" ), Is.EqualTo( new Decimal( -2.33 ) ) );
            Assert.That( DecimalConverter.Convert( new Decimal( 4.23322 ) ), Is.EqualTo( "4.23322" ) );
            Assert.That( DecimalConverter.Convert( new Decimal( -4.23322 ) ), Is.EqualTo( "-4.23322" ) );
        }

        [Test]
        public void DateTimeConverterTest()
        {
            // DateTime types to string
            Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05)), Is.EqualTo("20021201-11:03:05.000"));
            Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("20021201-11:03:05.321"));
            Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321), false), Is.EqualTo("20021201-11:03:05"));
            Assert.That(DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321), true), Is.EqualTo("20021201-11:03:05.321"));

            // 2 valid string-to-DateTime formats
            Assert.That(DateTimeConverter.ConvertToDateTime("20100912-04:22:01"), Is.EqualTo(new DateTime(2010, 9, 12, 4, 22, 01, DateTimeKind.Utc)));
            Assert.That(DateTimeConverter.ConvertToDateTime("20100912-04:22:01.123"), Is.EqualTo(new DateTime(2010, 9, 12, 4, 22, 01, 123, DateTimeKind.Utc)));

            // invalid string-to-DateTime formats
            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateTime(""); });
            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateTime("20021201"); });
            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateTime("20021201-11:03"); });
        }

        [Test]
        public void DateOnlyConverterTest()
        {
            // DateTime types to string
            Assert.That(DateTimeConverter.ConvertDateOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("20021201"));

            // string-to-DateTime but time is zero
            Assert.That(DateTimeConverter.ConvertToDateOnly("20100912"), Is.EqualTo(new DateTime(2010, 9, 12, 0, 0, 0, DateTimeKind.Utc)));

            // invalid string-to-DateTime formats
            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateOnly(""); });
            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToDateOnly("20021201-11:03:00"); });
        }

        [Test]
        public void TimeOnlyConverterTest()
        {
            // DateTime types to string
            Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05)), Is.EqualTo("11:03:05.000"));
            Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321)), Is.EqualTo("11:03:05.321"));
            Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), false), Is.EqualTo("11:03:05"));
            Assert.That(DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), true), Is.EqualTo("11:03:05.321"));

            // 2 valid string-to-DateTime formats, set date to Jan 1
            Assert.That(DateTimeConverter.ConvertToTimeOnly("04:22:01"), Is.EqualTo(new DateTime(1980, 1, 1, 4, 22, 01, DateTimeKind.Utc)));
            Assert.That(DateTimeConverter.ConvertToTimeOnly("04:22:01.123"), Is.EqualTo(new DateTime(1980, 1, 1, 4, 22, 01, 123, DateTimeKind.Utc)));

            // invalid string-to-DateTime formats
            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToTimeOnly(""); });
            Assert.Throws(typeof(FieldConvertError), delegate { DateTimeConverter.ConvertToTimeOnly("20021201-11:03:00"); });
        }
    }
}