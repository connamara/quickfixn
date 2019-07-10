using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class ByteSizeStringTests
    {
        [Test]
        public void NextTagTest()
        {
            byte[] str = new byte[5];
            str = CharEncoding.DefaultEncoding.GetBytes("35=8\u0001");
            ByteSizeString utf8str = new ByteSizeString(str, 5);
            
            int pos = 0;
            int tag = utf8str.GetNextTag(ref pos);
            Assert.That(pos, Is.EqualTo(3));
            ByteSizeString val = utf8str.GetNextValue(ref pos);

            Assert.That(tag, Is.EqualTo(35));
            Assert.That(pos, Is.EqualTo(5));
            Assert.That(val.ByteArray, Is.EqualTo(CharEncoding.DefaultEncoding.GetBytes("8")));
            Assert.That(val.ToString(), Is.EqualTo("8"));
        }
    }
}