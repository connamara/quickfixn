using System.Collections.Generic;
using QuickFix;
using Xunit;

namespace UnitTests
{
    public class SettingsTest
    {
        [Fact]
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

            LinkedList<QuickFix.Dictionary> foo = settings.Get("FOO");
            Assert.Single(foo);
            Assert.Equal(24, foo.First.Value.GetLong("bar"));
            Assert.Equal("moo", foo.First.Value.GetString("baz"));
            Assert.Equal("moo", foo.First.Value.GetString("baz"));
            Assert.Equal(2, foo.First.Value.Count);

            LinkedList<QuickFix.Dictionary> oren = settings.Get("OREN");
            Assert.Equal(2, oren.Count);            
            Assert.Equal(1, oren.First.Value.Count);
            Assert.Equal("TW", oren.First.Value.GetString("Nero"));
            oren.RemoveFirst();
            Assert.Equal(2, oren.First.Value.Count);
            Assert.Equal("Nero", oren.First.Value.GetString("ISLD"));
            Assert.Equal("./\\:", oren.First.Value.GetString("STUFF"));

            LinkedList<QuickFix.Dictionary> nero = settings.Get("NERO");
            Assert.Single(nero);
            Assert.Equal(5, nero.First.Value.Count);
            Assert.Equal("D:\\This Is\\A-Directory\\Connamara\\", nero.First.Value.GetString("WINDIR"));
            Assert.Equal("/home/mgatny/This Is/A Directory/ok/", nero.First.Value.GetString("UNIXDIR"));
            Assert.Equal("D:\\Program Files\\Tomcat 4.1\\webapps\\mgatny\\WEB-INF\\connamara.cfg", nero.First.Value.GetString("WINFILE"));
            Assert.Equal("last spaces stripped", nero.First.Value.GetString("stripspace"));
            Assert.Equal("We can have '=' in the value", nero.First.Value.GetString("EqualsInValue"));
        }

        [Fact]
        public void CaseInsensitiveSectionName()
        {
            string configuration = @"[foo]
one=uno
two=dos
[bar]
what=huh";
            Settings settings = new Settings(new System.IO.StringReader(configuration));

            LinkedList<QuickFix.Dictionary> byLower = settings.Get("foo");
            Assert.Single(byLower);
            Assert.Equal(2, byLower.First.Value.Count);
            Assert.Equal("uno", byLower.First.Value.GetString("one"));
            Assert.Equal("dos", byLower.First.Value.GetString("two"));

            // too lazy to write a QuickFix.Dictionary#Equals method (which would only be used by this test)
            LinkedList<QuickFix.Dictionary> byUpper = settings.Get("FOO");
            Assert.Equal(byLower.Count, byUpper.Count);
            Assert.Equal(byLower.First.Value.Count, byUpper.First.Value.Count);
            Assert.Equal(byUpper.First.Value.GetString("one"), byUpper.First.Value.GetString("one"));
            Assert.Equal(byUpper.First.Value.GetString("two"), byUpper.First.Value.GetString("two"));
        }
    }
}
