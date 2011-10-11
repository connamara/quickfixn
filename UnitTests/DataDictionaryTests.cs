using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class DataDictionaryTests
    {

        [Test]
        public void VersionTest()
        {
            QuickFix.DataDictionary.DataDictionary dd44 = new QuickFix.DataDictionary.DataDictionary();
            dd44.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd44.MajorVersion, Is.EqualTo("4"));
            Assert.That(dd44.MinorVersion, Is.EqualTo("4"));
            Assert.That(dd44.Version, Is.EqualTo("FIX.4.4"));
        }

        [Test]
        public void LoadFieldsTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.FieldsByTag[1].Name, Is.EqualTo("Account"));
            Assert.That(dd.FieldsByName["Account"].Tag, Is.EqualTo(1));
            Assert.That(dd.FieldsByTag[1].Enums.Count, Is.EqualTo(0));
            Assert.That(dd.FieldsByTag[QuickFix.Fields.Tags.StatusValue].Enums.Count, Is.EqualTo(4));
        }

        [Test]
        public void FieldHasValueTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "1"), Is.EqualTo(true));
            Assert.That(dd.FieldHasValue(QuickFix.Fields.Tags.StatusValue, "CONNECTED"), Is.EqualTo(false));
            Assert.False(dd.FieldsByTag[1].HasEnums());
            Assert.True(dd.FieldsByTag[945].HasEnums());
        }

        [Test]
        public void BasicMessageTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.Messages["3"].Fields.Count, Is.EqualTo(7));
        }

        [Test]
        public void ComponentSmokeTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            QuickFix.DataDictionary.DDMap tcr = dd.Messages["AE"];
            Assert.True(tcr.Fields.ContainsKey(55));
            Assert.False(tcr.Fields.ContainsKey(5995));
        }

        [Test]
        public void GroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            QuickFix.DataDictionary.DDMap tcrr = dd.Messages["AD"];
            Assert.True(tcrr.IsGroup(711));
            Assert.True(tcrr.IsField(711));  // No Field also a field
            Assert.True(tcrr.GetGroup(711).IsField(311));
            Assert.That(tcrr.Groups[711].Fields[311].Name, Is.EqualTo("UnderlyingSymbol"));
            Assert.That(tcrr.Groups[711].Delim, Is.EqualTo(311));
            QuickFix.DataDictionary.DDMap tcr = dd.Messages["AE"];
            Assert.That(tcr.Groups[711].Groups[457].Fields[458].Name, Is.EqualTo("UnderlyingSecurityAltID"));
        }

        [Test]
        public void HeaderGroupTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            QuickFix.DataDictionary.DDMap headerMap = dd.Header;
            Assert.True(headerMap.IsGroup(627));
            QuickFix.DataDictionary.DDGrp grpMap = headerMap.GetGroup(627);
            Assert.True(dd.Header.GetGroup(627).IsField(628));
            Assert.True(grpMap.IsField(628));
        }

        [Test]
        public void ReqFldTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            Assert.True(dd.Messages["AE"].ReqFields.Contains(571));
            Assert.False(dd.Messages["AE"].ReqFields.Contains(828));
        }

        [Test]
        public void HeaderTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            Assert.True(dd.Header.ReqFields.Contains(9));
            Assert.That(dd.Header.Fields.Count, Is.EqualTo(27));
        }

        [Test]
        public void TrailerTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            Assert.True(dd.Trailer.ReqFields.Contains(10));
            Assert.That(dd.Trailer.Fields.Count, Is.EqualTo(3));
        }

        [Test]
        public void CheckValidTagTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX44.xml");
            Assert.Throws(typeof(InvalidTagNumber),
                delegate { dd.CheckValidTagNumber(999); });
        }

        [Test]
        public void CheckGroupCountTest()
        {
            QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary("../../../spec/fix/FIX42.xml");

            QuickFix.FIX42.NewOrderSingle n = new QuickFix.FIX42.NewOrderSingle();

            string nul = "\x01";
            string s = "8=FIX.4.2" + nul + "9=148" + nul + "35=D" + nul + "34=2" + nul + "49=TW" + nul + "52=20111011-15:06:23.103" + nul + "56=ISLD" + nul
                + "11=ID" + nul + "21=1" + nul + "40=1" + nul + "54=1" + nul + "38=200.00" + nul + "55=INTC" + nul
                + "386=3" + nul + "336=PRE-OPEN" + nul + "336=AFTER-HOURS" + nul
                + "60=20111011-15:06:23.103" + nul
                + "10=34" + nul;

            n.FromString(s, true, dd, dd);
            n.SetField(new QuickFix.Fields.NoTradingSessions(3)); // FromString correct's the value above, but I want it wrong
            StringAssert.Contains("386=3" + nul, s);  //verify it's wrong like I want

            Assert.Throws<QuickFix.RepeatingGroupCountMismatch>(delegate { dd.CheckGroupCount(n.NoTradingSessions, n, "D"); });
        }
    }
}
