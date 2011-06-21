using NUnit.Framework;
using QuickFIX.NET;

namespace UnitTests
{
    [TestFixture]
    public class DictionaryTest
    {
        [Test]
        public void SetGetString()
        {
            QuickFIX.NET.Dictionary d = new QuickFIX.NET.Dictionary();
            d.SetString("STRINGKEY1", "STRINGVALUE1");
            d.SetString("STRINGKEY2", "stringvalue2");
            Assert.That(d.GetString("STRINGKEY1"), Is.EqualTo("STRINGVALUE1"));
            Assert.That(d.GetString("STRINGKEY2"), Is.EqualTo("stringvalue2"));
            Assert.That(d.GetString("STRINGKEY2", true), Is.EqualTo("STRINGVALUE2"));
            Assert.Throws<ConfigError>(delegate { d.GetString("STRINGKEY3"); });
        }

        [Test]
        public void SetGetLong()
        {
            QuickFIX.NET.Dictionary d = new QuickFIX.NET.Dictionary();
            d.SetLong("LONGKEY1", 12);
            d.SetLong("LONGKEY2", 987362);
            d.SetString("BADLONGKEY", "AB12");
            Assert.That(d.GetLong("LONGKEY1"), Is.EqualTo(12));
            Assert.That(d.GetLong("LONGKEY2"), Is.EqualTo(987362));
            Assert.Throws<ConfigError>(delegate { d.GetLong("LONGKEY3"); });
            Assert.Throws<ConfigError>(delegate { d.GetLong("BADLONGKEY"); });
        }

        [Test]
        public void SetGetDouble()
        {
            QuickFIX.NET.Dictionary d = new QuickFIX.NET.Dictionary();
            d.SetDouble("DOUBLEKEY1", 12.3);
            d.SetDouble("DOUBLEKEY2", 987362.987362);
            d.SetString("BADDOUBLEKEY", "AB12.3");
            Assert.That(d.GetDouble("DOUBLEKEY1"), Is.EqualTo(12.3));
            Assert.That(d.GetDouble("DOUBLEKEY2"), Is.EqualTo(987362.987362));
            Assert.Throws<ConfigError>(delegate { d.GetDouble("DOUBLEKEY3"); });
            Assert.Throws<ConfigError>(delegate { d.GetDouble("BADDOUBLEKEY"); });
        }

        [Test]
        public void SetGetBool()
        {
            QuickFIX.NET.Dictionary d = new QuickFIX.NET.Dictionary();
            d.SetBool("BOOLKEY1", true);
            d.SetBool("BOOLKEY2", false);
            d.SetString("BADBOOLKEY2", "YO");
            Assert.That(d.GetBool("BOOLKEY1"), Is.True);
            Assert.That(d.GetBool("BOOLKEY2"), Is.False);
            Assert.Throws<ConfigError>(delegate { d.GetBool("BOOLKEY3"); });
            Assert.Throws<ConfigError>(delegate { d.GetBool("BADBOOLKEY2"); });
        }

        [Test]
        public void SetGetDay()
        {
            QuickFIX.NET.Dictionary d = new QuickFIX.NET.Dictionary();
            
            d.SetString("DAY1", "SU");
            d.SetString("DAY2", "MO");
            d.SetString("DAY3", "TU");
            d.SetString("DAY4", "WE");
            d.SetString("DAY5", "TH");
            d.SetString("DAY6", "FR");
            d.SetString("DAY7", "SA");
            Assert.That(d.GetDay("DAY1"), Is.EqualTo(1));
            Assert.That(d.GetDay("DAY2"), Is.EqualTo(2));
            Assert.That(d.GetDay("DAY3"), Is.EqualTo(3));
            Assert.That(d.GetDay("DAY4"), Is.EqualTo(4));
            Assert.That(d.GetDay("DAY5"), Is.EqualTo(5));
            Assert.That(d.GetDay("DAY6"), Is.EqualTo(6));
            Assert.That(d.GetDay("DAY7"), Is.EqualTo(7));

            d.SetDay("NEXTDAY1", 1);
            d.SetDay("NEXTDAY2", 2);
            d.SetDay("NEXTDAY3", 3);
            d.SetDay("NEXTDAY4", 4);
            d.SetDay("NEXTDAY5", 5);
            d.SetDay("NEXTDAY6", 6);
            d.SetDay("NEXTDAY7", 7);
            Assert.That(d.GetDay("NEXTDAY1"), Is.EqualTo(1));
            Assert.That(d.GetDay("NEXTDAY2"), Is.EqualTo(2));
            Assert.That(d.GetDay("NEXTDAY3"), Is.EqualTo(3));
            Assert.That(d.GetDay("NEXTDAY4"), Is.EqualTo(4));
            Assert.That(d.GetDay("NEXTDAY5"), Is.EqualTo(5));
            Assert.That(d.GetDay("NEXTDAY6"), Is.EqualTo(6));
            Assert.That(d.GetDay("NEXTDAY7"), Is.EqualTo(7));
        }
        
        [Test]
        public void Merge()
        {
            QuickFIX.NET.Dictionary first = new QuickFIX.NET.Dictionary();
            first.SetString("FIRSTKEY", "FIRSTVALUE");
            first.SetString("THIRDKEY", "FIRST");

            QuickFIX.NET.Dictionary second = new QuickFIX.NET.Dictionary();
            second.SetString("SECONDKEY", "SECONDVALUE");
            second.SetString("THIRDKEY", "SECOND");

            first.Merge(second);
            Assert.That(first.GetString("FIRSTKEY"), Is.EqualTo("FIRSTVALUE"));
            Assert.That(first.GetString("SECONDKEY"), Is.EqualTo("SECONDVALUE"));
            Assert.That(first.GetString("THIRDKEY"), Is.EqualTo("FIRST"));
        }
    }
}
