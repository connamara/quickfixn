using System;
using Xunit;
using QuickFix;

namespace UnitTests
{
    public class DictionaryTest : IDisposable
    {
        public void Dispose()
        {
#if !NETCOREAPP1_1
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
#else
            System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
#endif
        }

        [Fact]
        public void SetGetString()
        {
            QuickFix.Dictionary d = new QuickFix.Dictionary();
            d.SetString("STRINGKEY1", "STRINGVALUE1");
            d.SetString("STRINGKEY2", "stringvalue2");
            Assert.Equal("STRINGVALUE1", d.GetString("STRINGKEY1"));
            Assert.Equal("stringvalue2", d.GetString("STRINGKEY2"));
            Assert.Equal("STRINGVALUE2", d.GetString("STRINGKEY2", true));
            Assert.Throws<ConfigError>(delegate { d.GetString("STRINGKEY3"); });
        }

        [Fact]
        public void SetGetLong()
        {
            QuickFix.Dictionary d = new QuickFix.Dictionary();
            d.SetLong("LONGKEY1", 12);
            d.SetLong("LONGKEY2", 987362);
            d.SetString("BADLONGKEY", "AB12");
            Assert.Equal(12L, d.GetLong("LONGKEY1"));
            Assert.Equal(987362L, d.GetLong("LONGKEY2"));
            Assert.Throws<ConfigError>(delegate { d.GetLong("LONGKEY3"); });
            Assert.Throws<ConfigError>(delegate { d.GetLong("BADLONGKEY"); });
        }

        [Fact]
        public void SetDouble()
        {
            // make sure that QF/n uses the invariant culture, no matter what the current culture is
#if !NETCOREAPP1_1
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
#else
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
#endif

            QuickFix.Dictionary d = new QuickFix.Dictionary();
            d.SetDouble("DOUBLEKEY1", 12.3);
            d.SetDouble("DOUBLEKEY2", 987362.987362);

            Assert.Equal("12.3", d.GetString("DOUBLEKEY1"));
            Assert.Equal("987362.987362", d.GetString("DOUBLEKEY2"));
        }

        [Fact]
        public void GetDouble()
        {
            // make sure that QF/n uses the invariant culture, no matter what the current culture is
#if !NETCOREAPP1_1
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
#else
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
#endif

            QuickFix.Dictionary d = new QuickFix.Dictionary();
            d.SetString("DOUBLEKEY1", "12.3");
            d.SetString("DOUBLEKEY2", "987362.987362");
            d.SetString("BADDOUBLEKEY", "AB12.3");
            d.SetString("FOREIGNFORMAT", "44,44");

            Assert.Equal(12.3d, d.GetDouble("DOUBLEKEY1"));
            Assert.Equal(987362.987362d, d.GetDouble("DOUBLEKEY2"));
            Assert.Throws<ConfigError>(delegate { d.GetDouble("DOUBLEKEY3"); });
            Assert.Throws<ConfigError>(delegate { d.GetDouble("BADDOUBLEKEY"); });
            Assert.Throws<ConfigError>(delegate { d.GetDouble("BADDOUBLEKEY"); });
        }

        [Fact]
        public void SetGetBool()
        {
            QuickFix.Dictionary d = new QuickFix.Dictionary();
            d.SetBool("BOOLKEY1", true);
            d.SetBool("BOOLKEY2", false);
            d.SetString("BADBOOLKEY2", "YO");
            Assert.True(d.GetBool("BOOLKEY1"));
            Assert.False(d.GetBool("BOOLKEY2"));
            Assert.Throws<ConfigError>(delegate { d.GetBool("BOOLKEY3"); });
            Assert.Throws<ConfigError>(delegate { d.GetBool("BADBOOLKEY2"); });
        }

        [Fact]
        public void SetGetDay()
        {
            QuickFix.Dictionary d = new QuickFix.Dictionary();

            d.SetString("DAY1", "SU");
            d.SetString("DAY2", "MO");
            d.SetString("DAY3", "TU");
            d.SetString("DAY4", "WE");
            d.SetString("DAY5", "TH");
            d.SetString("DAY6", "FR");
            d.SetString("DAY7", "SA");
            Assert.Equal(System.DayOfWeek.Sunday, d.GetDay("DAY1"));
            Assert.Equal(System.DayOfWeek.Monday, d.GetDay("DAY2"));
            Assert.Equal(System.DayOfWeek.Tuesday, d.GetDay("DAY3"));
            Assert.Equal(System.DayOfWeek.Wednesday, d.GetDay("DAY4"));
            Assert.Equal(System.DayOfWeek.Thursday, d.GetDay("DAY5"));
            Assert.Equal(System.DayOfWeek.Friday, d.GetDay("DAY6"));
            Assert.Equal(System.DayOfWeek.Saturday, d.GetDay("DAY7"));

            d.SetDay("NEXTDAY1", System.DayOfWeek.Sunday);
            d.SetDay("NEXTDAY2", System.DayOfWeek.Monday);
            d.SetDay("NEXTDAY3", System.DayOfWeek.Tuesday);
            d.SetDay("NEXTDAY4", System.DayOfWeek.Wednesday);
            d.SetDay("NEXTDAY5", System.DayOfWeek.Thursday);
            d.SetDay("NEXTDAY6", System.DayOfWeek.Friday);
            d.SetDay("NEXTDAY7", System.DayOfWeek.Saturday);
            Assert.Equal(System.DayOfWeek.Sunday, d.GetDay("NEXTDAY1"));
            Assert.Equal(System.DayOfWeek.Monday, d.GetDay("NEXTDAY2"));
            Assert.Equal(System.DayOfWeek.Tuesday, d.GetDay("NEXTDAY3"));
            Assert.Equal(System.DayOfWeek.Wednesday, d.GetDay("NEXTDAY4"));
            Assert.Equal(System.DayOfWeek.Thursday, d.GetDay("NEXTDAY5"));
            Assert.Equal(System.DayOfWeek.Friday, d.GetDay("NEXTDAY6"));
            Assert.Equal(System.DayOfWeek.Saturday, d.GetDay("NEXTDAY7"));
        }

        [Fact]
        public void Merge()
        {
            QuickFix.Dictionary first = new QuickFix.Dictionary();
            first.SetString("FIRSTKEY", "FIRSTVALUE");
            first.SetString("THIRDKEY", "FIRST");

            QuickFix.Dictionary second = new QuickFix.Dictionary();
            second.SetString("SECONDKEY", "SECONDVALUE");
            second.SetString("THIRDKEY", "SECOND");

            first.Merge(second);
            Assert.Equal("FIRSTVALUE", first.GetString("FIRSTKEY"));
            Assert.Equal("SECONDVALUE", first.GetString("SECONDKEY"));
            Assert.Equal("FIRST", first.GetString("THIRDKEY"));
        }

        [Fact]
        public void ValueEquality()
        {
            QuickFix.Dictionary first = new QuickFix.Dictionary("Name");
            QuickFix.Dictionary second = new QuickFix.Dictionary("Name");
            Assert.True(first.Equals(second));

            first.SetString("THIRDKEY", "FIRST");
            second.SetString("THIRDKEY", "SECOND");
            Assert.False(first.Equals(second));

            first.SetString("THIRDKEY", "SECOND");
            Assert.True(first.Equals(second));

            first.SetString("FIRSTKEY", "FIRSTVALUE");
            second.SetString("SECONDKEY", "SECONDVALUE");
            Assert.False(first.Equals(second));

            first.SetString("SECONDKEY", "SECONDVALUE");
            second.SetString("FIRSTKEY", "FIRSTVALUE");
            Assert.True(first.Equals(second));

            QuickFix.Dictionary third = new QuickFix.Dictionary("Name1");
            QuickFix.Dictionary fourth = new QuickFix.Dictionary("Name2");
            Assert.False(third.Equals(fourth));
        }
    }
}
