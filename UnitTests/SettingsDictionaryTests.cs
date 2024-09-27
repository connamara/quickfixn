using System;
using NUnit.Framework;
using QuickFix;

namespace UnitTests;

[TestFixture]
public class SettingsDictionaryTests
{
    [TearDown]
    public void Teardown()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
    }

    [Test]
    public void TestSetGetString()
    {
        SettingsDictionary d = new();
        d.SetString("STRINGKEY1", "STRINGVALUE1");
        d.SetString("STRINGKEY2", "stringvalue2");
        Assert.That(d.GetString("STRINGKEY1"), Is.EqualTo("STRINGVALUE1"));
        Assert.That(d.GetString("STRINGKEY2"), Is.EqualTo("stringvalue2"));
        Assert.That(d.GetString("STRINGKEY2", true), Is.EqualTo("STRINGVALUE2"));
        Assert.Throws<ConfigError>(delegate { d.GetString("STRINGKEY3"); });
    }

    [Test]
    public void TestSetGetLong()
    {
        SettingsDictionary d = new();
        d.SetLong("LONGKEY1", 12);
        d.SetLong("LONGKEY2", 987362);
        d.SetString("BADLONGKEY", "AB12");
        Assert.That(d.GetLong("LONGKEY1"), Is.EqualTo(12));
        Assert.That(d.GetLong("LONGKEY2"), Is.EqualTo(987362));
        Assert.Throws<ConfigError>(delegate { d.GetLong("LONGKEY3"); });
        Assert.Throws<ConfigError>(delegate { d.GetLong("BADLONGKEY"); });
    }

    [Test]
    public void TestSetDouble()
    {
        // make sure that QF/n uses the invariant culture, no matter what the current culture is
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");

        SettingsDictionary d = new();
        d.SetDouble("DOUBLEKEY1", 12.3);
        d.SetDouble("DOUBLEKEY2", 987362.987362);

        Assert.AreEqual("12.3", d.GetString("DOUBLEKEY1"));
        Assert.AreEqual("987362.987362", d.GetString("DOUBLEKEY2"));
    }

    [Test]
    public void TestGetDouble()
    {
        // make sure that QF/n uses the invariant culture, no matter what the current culture is
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");

        SettingsDictionary d = new();
        d.SetString("DOUBLEKEY1", "12.3");
        d.SetString("DOUBLEKEY2", "987362.987362");
        d.SetString("BADDOUBLEKEY", "AB12.3");
        d.SetString("FOREIGNFORMAT", "44,44");

        Assert.That(d.GetDouble("DOUBLEKEY1"), Is.EqualTo(12.3));
        Assert.That(d.GetDouble("DOUBLEKEY2"), Is.EqualTo(987362.987362));
        Assert.Throws<ConfigError>(delegate { d.GetDouble("DOUBLEKEY3"); });
        Assert.Throws<ConfigError>(delegate { d.GetDouble("BADDOUBLEKEY"); });
        Assert.Throws<ConfigError>(delegate { d.GetDouble("BADDOUBLEKEY"); });
    }

    [Test]
    public void TestSetGetBool()
    {
        SettingsDictionary d = new();
        d.SetBool("BOOLKEY1", true);
        d.SetBool("BOOLKEY2", false);
        d.SetString("BADBOOLKEY2", "YO");
        Assert.That(d.GetBool("BOOLKEY1"), Is.True);
        Assert.That(d.GetBool("BOOLKEY2"), Is.False);
        Assert.Throws<ConfigError>(delegate { d.GetBool("BOOLKEY3"); });
        Assert.Throws<ConfigError>(delegate { d.GetBool("BADBOOLKEY2"); });
    }

    [Test]
    public void TestIsBoolPresentAndTrue() {
        SettingsDictionary d = new();
        d.SetBool("BOOLKEY-T", true);
        d.SetBool("BOOLKEY-F", false);
        Assert.IsTrue(d.IsBoolPresentAndTrue("BOOLKEY-T"));
        Assert.IsFalse(d.IsBoolPresentAndTrue("BOOLKEY-F"));
        Assert.IsFalse(d.IsBoolPresentAndTrue("nonexistent key"));
    }

    [Test]
    public void TestGetDay()
    {
        SettingsDictionary d = new();

        d.SetString("DAY1", "SU");
        d.SetString("DAY2", "MO");
        d.SetString("DAY3", "TU");
        d.SetString("DAY4", "WE");
        d.SetString("DAY5", "TH");
        d.SetString("DAY6", "FR");
        d.SetString("DAY7", "SA");
        Assert.That(d.GetDay("DAY1"), Is.EqualTo(DayOfWeek.Sunday));
        Assert.That(d.GetDay("DAY2"), Is.EqualTo(DayOfWeek.Monday));
        Assert.That(d.GetDay("DAY3"), Is.EqualTo(DayOfWeek.Tuesday));
        Assert.That(d.GetDay("DAY4"), Is.EqualTo(DayOfWeek.Wednesday));
        Assert.That(d.GetDay("DAY5"), Is.EqualTo(DayOfWeek.Thursday));
        Assert.That(d.GetDay("DAY6"), Is.EqualTo(DayOfWeek.Friday));
        Assert.That(d.GetDay("DAY7"), Is.EqualTo(DayOfWeek.Saturday));

        d.SetString("DAY_X", "invalid");
        var ex = Assert.Throws(typeof(ArgumentException), delegate { d.GetDay("DAY_X"); });
        StringAssert.Contains("Cannot recognize this day: 'invalid'", ex!.Message);
    }

    [Test]
    public void TestSetDay() {
        SettingsDictionary d = new();
        d.SetDay("DAY1", DayOfWeek.Monday);
        d.SetDay("DAY4", DayOfWeek.Thursday);

        Assert.That(d.GetString("DAY1"), Is.EqualTo("Monday"));
        Assert.That(d.GetString("DAY4"), Is.EqualTo("Thursday"));

        var ex = Assert.Throws(typeof(ArgumentException), delegate { d.SetDay("X", (DayOfWeek)9); });
        StringAssert.Contains("Not a valid DayOfWeek value", ex!.Message);
    }

    [Test]
    public void TestMerge()
    {
        SettingsDictionary first = new();
        first.SetString("FIRSTKEY", "FIRSTVALUE");
        first.SetString("THIRDKEY", "FIRST");

        SettingsDictionary second = new();
        second.SetString("SECONDKEY", "SECONDVALUE");
        second.SetString("THIRDKEY", "SECOND");

        first.Merge(second);
        Assert.That(first.GetString("FIRSTKEY"), Is.EqualTo("FIRSTVALUE"));
        Assert.That(first.GetString("SECONDKEY"), Is.EqualTo("SECONDVALUE"));
        Assert.That(first.GetString("THIRDKEY"), Is.EqualTo("FIRST"));
    }

    [Test]
    public void TestValueEquality()
    {
        SettingsDictionary first = new("MyName");
        SettingsDictionary second = new("MyName");
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

        SettingsDictionary third = new("Name1");
        SettingsDictionary fourth = new("Name2");
        Assert.False(third.Equals(fourth));
    }

    [Test]
    public void TestCopyCtor() {
        SettingsDictionary orig = new("orig");
        orig.SetString("uno", "One");
        orig.SetLong("dos", 2);

        SettingsDictionary dupe = new("dupe", orig);

        Assert.AreEqual(2, dupe.Count);
        Assert.AreEqual("One", dupe.GetString("uNo"));
        Assert.AreEqual("2", dupe.GetString("DOs"));
    }
}
