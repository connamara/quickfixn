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
            string configuration = new System.Text.StringBuilder()
                .AppendLine("[FOO]").AppendLine("bar=24").AppendLine("baz=moo")
                .AppendLine("[OREN]").AppendLine("Nero=TW").AppendLine("#Nero=IGNOREME")
                .AppendLine("# this is a comment")
                .AppendLine("#[OREN]").AppendLine("#Nero=IGNOREME")
                .AppendLine("[OREN]").AppendLine("ISLD=Nero").AppendLine("STUFF=./\\:")
                .AppendLine("[NERO]").AppendLine("WINDIR=D:\\This Is\\A-Directory\\Connamara\\")
                .AppendLine("WINFILE=D:\\Program Files\\Tomcat 4.1\\webapps\\mgatny\\WEB-INF\\connamara.cfg")
                .AppendLine("UNIXDIR=/home/mgatny/This Is/A Directory/ok/")
                .AppendLine("stripspace=last spaces stripped   ")
                .AppendLine("#Nero=IGNOREME")
                .AppendLine("EqualsInValue=We can have '=' in the value")
                .ToString();
            Settings settings = new Settings(new System.IO.StringReader(configuration));

            LinkedList<QuickFix.Dictionary> foo = settings.Get("FOO");
            Assert.That(foo.Count, Is.EqualTo(1));
            Assert.That(foo.First.Value.GetLong("bar"), Is.EqualTo(24));
            Assert.That(foo.First.Value.GetString("baz"), Is.EqualTo("moo"));
            Assert.That(foo.First.Value.GetString("baz"), Is.EqualTo("moo"));
            Assert.That(foo.First.Value.Count, Is.EqualTo(2));

            LinkedList<QuickFix.Dictionary> oren = settings.Get("OREN");
            Assert.That(oren.Count, Is.EqualTo(2));            
            Assert.That(oren.First.Value.Count, Is.EqualTo(1));
            Assert.That(oren.First.Value.GetString("Nero"), Is.EqualTo("TW"));
            oren.RemoveFirst();
            Assert.That(oren.First.Value.Count, Is.EqualTo(2));
            Assert.That(oren.First.Value.GetString("ISLD"), Is.EqualTo("Nero"));
            Assert.That(oren.First.Value.GetString("STUFF"), Is.EqualTo("./\\:"));

            LinkedList<QuickFix.Dictionary> nero = settings.Get("NERO");
            Assert.That(nero.Count, Is.EqualTo(1));
            Assert.That(nero.First.Value.Count, Is.EqualTo(5));
            Assert.That(nero.First.Value.GetString("WINDIR"), Is.EqualTo("D:\\This Is\\A-Directory\\Connamara\\"));
            Assert.That(nero.First.Value.GetString("UNIXDIR"), Is.EqualTo("/home/mgatny/This Is/A Directory/ok/"));
            Assert.That(nero.First.Value.GetString("WINFILE"), Is.EqualTo("D:\\Program Files\\Tomcat 4.1\\webapps\\mgatny\\WEB-INF\\connamara.cfg"));
            Assert.That(nero.First.Value.GetString("stripspace"), Is.EqualTo("last spaces stripped"));
            Assert.That(nero.First.Value.GetString("EqualsInValue"), Is.EqualTo("We can have '=' in the value"));
        }
    }
}
