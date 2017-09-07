using System;
using Xunit;
using QuickFix;
using QuickFix.Fields.Converters;

namespace UnitTests
{
    public class ConverterTests : IDisposable
    {
        public ConverterTests()
        {
#if !NETCOREAPP1_1
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
#else
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
#endif
        }

        public void Dispose()
        {
#if !NETCOREAPP1_1
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
#else
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
#endif
        }

        [Fact]
        public void BoolConverterTest()
        {
            Assert.True(BoolConverter.Convert("Y"));
            Assert.False(BoolConverter.Convert("N"));
            Assert.Equal("Y", BoolConverter.Convert(true));
            Assert.Equal("N", BoolConverter.Convert(false));
            Assert.Throws<FieldConvertError>(delegate { BoolConverter.Convert("Z"); });
        }

        [Fact]
        public void CharConverterTest()
        {
            Assert.Equal("A", CharConverter.Convert('A'));
            Assert.Equal('B', CharConverter.Convert("B"));
            Assert.Throws<FieldConvertError>(delegate { CharConverter.Convert("AB"); });
        }

        [Fact]
        public void IntConverterTest()
        {
            Assert.Equal("233", IntConverter.Convert(233));
            Assert.Equal("-233", IntConverter.Convert(-233));
            Assert.Equal(444556, IntConverter.Convert("444556"));

            Assert.Throws<FieldConvertError>(delegate { IntConverter.Convert("+100"); });
            Assert.Throws<FieldConvertError>(delegate { IntConverter.Convert("(100)"); });
            Assert.Throws<FieldConvertError>(delegate { IntConverter.Convert("AB"); });
            Assert.Throws<FieldConvertError>(delegate { IntConverter.Convert("2.3234"); });
            Assert.Throws<FieldConvertError>(delegate { IntConverter.Convert(""); });
            Assert.Throws<FieldConvertError>(delegate { IntConverter.Convert(null); });
        }

        [Fact]
        public void DecimalConverterTest()
        {
            Assert.Equal("4.23322", DecimalConverter.Convert(4.23322M));
            Assert.Equal("-4.23322", DecimalConverter.Convert(-4.23322M));
            Assert.Equal(4332.33M, DecimalConverter.Convert("4332.33"));
            Assert.Throws<FieldConvertError>(delegate { DecimalConverter.Convert("2.32a34"); });
            Assert.Throws<FieldConvertError>(delegate { DecimalConverter.Convert("+1.2"); });
            Assert.Throws<FieldConvertError>(delegate { DecimalConverter.Convert("(1.2)"); });
            Assert.Throws<FieldConvertError>(delegate { DecimalConverter.Convert(""); });
            Assert.Throws<FieldConvertError>(delegate { DecimalConverter.Convert(null); });

            // check for a different culture than en-XX 
#if !NETCOREAPP1_1
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo( "tr-TR" );
#else
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
#endif
            Assert.Equal(4332.33M, DecimalConverter.Convert("4332.33"));
            Assert.Equal(DecimalConverter.Convert("-2.33"), -2.33M);
            Assert.Equal("4.23322", DecimalConverter.Convert(4.23322M));
            Assert.Equal("-4.23322", DecimalConverter.Convert(-4.23322M));
        }

        [Fact]
        public void DecimalConverter_WithoutLeadingTrailingZeros()
        {
            Assert.Equal(23M, DecimalConverter.Convert("23."));
            Assert.Equal(0.23M, DecimalConverter.Convert(".23"));
            Assert.Equal(DecimalConverter.Convert("-.23"), -0.23M);
        }

        [Fact]
        public void DateTimeConverterTest()
        {
            // DateTime types to string
            Assert.Equal("20021201-11:03:05.000", DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05)));
            Assert.Equal("20021201-11:03:05.321", DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321)));
            Assert.Equal("20021201-11:03:05", DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321), false));
            Assert.Equal("20021201-11:03:05.321", DateTimeConverter.Convert(new DateTime(2002, 12, 01, 11, 03, 05, 321), true));

            // 2 valid string-to-DateTime formats
            Assert.Equal(DateTimeConverter.ConvertToDateTime("20100912-04:22:01"), new DateTime(2010, 9, 12, 4, 22, 01, DateTimeKind.Utc));
            Assert.Equal(DateTimeConverter.ConvertToDateTime("20100912-04:22:01.123"), new DateTime(2010, 9, 12, 4, 22, 01, 123, DateTimeKind.Utc));

            // invalid string-to-DateTime formats
            Assert.Throws<FieldConvertError>(delegate { DateTimeConverter.ConvertToDateTime(""); });
            Assert.Throws<FieldConvertError>(delegate { DateTimeConverter.ConvertToDateTime("20021201"); });
            Assert.Throws<FieldConvertError>(delegate { DateTimeConverter.ConvertToDateTime("20021201-11:03"); });
        }

        [Fact]
        public void DateOnlyConverterTest()
        {
            // DateTime types to string
            Assert.Equal("20021201", DateTimeConverter.ConvertDateOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321)));

            // string-to-DateTime but time is zero
            Assert.Equal(DateTimeConverter.ConvertToDateOnly("20100912"), new DateTime(2010, 9, 12, 0, 0, 0, DateTimeKind.Utc));

            // invalid string-to-DateTime formats
            Assert.Throws<FieldConvertError>(delegate { DateTimeConverter.ConvertToDateOnly(""); });
            Assert.Throws<FieldConvertError>(delegate { DateTimeConverter.ConvertToDateOnly("20021201-11:03:00"); });
        }

        [Fact]
        public void TimeOnlyConverterTest()
        {
            // DateTime types to string
            Assert.Equal("11:03:05.000", DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05)));
            Assert.Equal("11:03:05.321", DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321)));
            Assert.Equal("11:03:05", DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), false));
            Assert.Equal("11:03:05.321", DateTimeConverter.ConvertTimeOnly(new DateTime(2002, 12, 01, 11, 03, 05, 321), true));

            // 2 valid string-to-DateTime formats, set date to Jan 1
            Assert.Equal(DateTimeConverter.ConvertToTimeOnly("04:22:01"), new DateTime(1980, 1, 1, 4, 22, 01, DateTimeKind.Utc));
            Assert.Equal(DateTimeConverter.ConvertToTimeOnly("04:22:01.123"),new DateTime(1980, 1, 1, 4, 22, 01, 123, DateTimeKind.Utc));

            // invalid string-to-DateTime formats
            Assert.Throws<FieldConvertError>(delegate { DateTimeConverter.ConvertToTimeOnly(""); });
            Assert.Throws<FieldConvertError>(delegate { DateTimeConverter.ConvertToTimeOnly("20021201-11:03:00"); });
        }
    }
}