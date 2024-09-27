using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class SettingsTest
    {
        [Test]
        public void Load()
        {
            string configuration = @"[FOO]
bar=24
baz=moo
[OREN]
Nero=TW
#Nero=IGNOREME
# this is a comment
#[OREN]
#Nero=IGNOREME
[OREN]
ISLD=Nero
STUFF=./\:
[NERO]
WINDIR=D:\This Is\A-Directory\Connamara\
WINFILE=D:\Program Files\Tomcat 4.1\webapps\mgatny\WEB-INF\connamara.cfg
UNIXDIR=/home/mgatny/This Is/A Directory/ok/
stripspace=last spaces stripped   
#Nero=IGNOREME
EqualsInValue=We can have '=' in the value
";
            Settings settings = new Settings(new System.IO.StringReader(configuration));

            LinkedList<QuickFix.SettingsDictionary> foo = settings.Get("FOO");
            Assert.That(foo.Count, Is.EqualTo(1));
            Assert.That(foo.First!.Value.GetLong("bar"), Is.EqualTo(24));
            Assert.That(foo.First.Value.GetString("baz"), Is.EqualTo("moo"));
            Assert.That(foo.First.Value.GetString("baz"), Is.EqualTo("moo"));
            Assert.That(foo.First.Value.Count, Is.EqualTo(2));

            LinkedList<QuickFix.SettingsDictionary> oren = settings.Get("OREN");
            Assert.That(oren.Count, Is.EqualTo(2));            
            Assert.That(oren.First!.Value.Count, Is.EqualTo(1));
            Assert.That(oren.First.Value.GetString("Nero"), Is.EqualTo("TW"));
            oren.RemoveFirst();
            Assert.That(oren.First.Value.Count, Is.EqualTo(2));
            Assert.That(oren.First.Value.GetString("ISLD"), Is.EqualTo("Nero"));
            Assert.That(oren.First.Value.GetString("STUFF"), Is.EqualTo("./\\:"));

            LinkedList<QuickFix.SettingsDictionary> nero = settings.Get("NERO");
            Assert.That(nero.Count, Is.EqualTo(1));
            Assert.That(nero.First!.Value.Count, Is.EqualTo(5));
            Assert.That(nero.First.Value.GetString("WINDIR"), Is.EqualTo("D:\\This Is\\A-Directory\\Connamara\\"));
            Assert.That(nero.First.Value.GetString("UNIXDIR"), Is.EqualTo("/home/mgatny/This Is/A Directory/ok/"));
            Assert.That(nero.First.Value.GetString("WINFILE"), Is.EqualTo("D:\\Program Files\\Tomcat 4.1\\webapps\\mgatny\\WEB-INF\\connamara.cfg"));
            Assert.That(nero.First.Value.GetString("stripspace"), Is.EqualTo("last spaces stripped"));
            Assert.That(nero.First.Value.GetString("EqualsInValue"), Is.EqualTo("We can have '=' in the value"));
        }

        [Test]
        public void CaseInsensitiveSectionName()
        {
            string configuration = @"[foo]
one=uno
two=dos
[bar]
what=huh";
            Settings settings = new Settings(new System.IO.StringReader(configuration));

            LinkedList<QuickFix.SettingsDictionary> byLower = settings.Get("foo");
            Assert.AreEqual(1, byLower.Count);
            Assert.AreEqual(2, byLower.First!.Value.Count);
            Assert.AreEqual("uno", byLower.First.Value.GetString("one"));
            Assert.AreEqual("dos", byLower.First.Value.GetString("two"));

            // too lazy to write a QuickFix.Dictionary#Equals method (which would only be used by this test)
            LinkedList<QuickFix.SettingsDictionary> byUpper = settings.Get("FOO");
            Assert.AreEqual(byLower.Count, byUpper.Count);
            Assert.AreEqual(byLower.First.Value.Count, byUpper.First!.Value.Count);
            Assert.AreEqual(byUpper.First.Value.GetString("one"), byUpper.First.Value.GetString("one"));
            Assert.AreEqual(byUpper.First.Value.GetString("two"), byUpper.First.Value.GetString("two"));
        }
    }
}
