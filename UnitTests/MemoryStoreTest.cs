using System.Collections.Generic;
using QuickFix;
using QuickFix.Fields;
using Xunit;

namespace UnitTests
{
    public class MemoryStoreTests
    {
        [Fact]
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
            Assert.Equal(msgs, expected);

            msgs = new List<string>();
            store.Get(5, 6, msgs);
            Assert.Empty(msgs);


        }
    }
}