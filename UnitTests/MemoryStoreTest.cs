using System.Collections.Generic;
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
            store.Set(1, "dude");
            store.Set(2, "pude");
            store.Set(3, "ok");
            store.Set(4, "ohai");
            var msgs = new List<string>();
            store.Get(2, 3, msgs);
            var expected = new List<string>() { "pude", "ok" };
            Assert.That(msgs, Is.EqualTo(expected));

            msgs = new List<string>();
            store.Get(5, 6, msgs);
            Assert.That(msgs, Is.Empty);


        }
    }
}