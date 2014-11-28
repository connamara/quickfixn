using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{
    [TestFixture]
    public class MemoryStoreTests
    {
        [Test]
        public void GetTest()
        {
            MemoryStore store = new MemoryStore();
            store.Set(1, Encoding.ASCII.GetBytes("dude"));
            store.Set(2, Encoding.ASCII.GetBytes("pude"));
            store.Set(3, Encoding.ASCII.GetBytes("ok"));
            store.Set(4, Encoding.ASCII.GetBytes("ohai"));
            var msgs = new List<byte[]>();
            store.Get(2, 3, msgs);
            var expected = new List<byte[]>() { Encoding.ASCII.GetBytes("pude"), Encoding.ASCII.GetBytes("ok") };
            Assert.That(msgs, Is.EqualTo(expected));

            msgs = new List<byte[]>();
            store.Get(5, 6, msgs);
            Assert.That(msgs, Is.Empty);


        }
    }
}