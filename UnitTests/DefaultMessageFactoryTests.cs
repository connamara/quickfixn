using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFix;

namespace UnitTests
{
    [TestFixture]
    public class DefaultMessageFactoryTests
    {
        [Test]
        public void GroupCreateTest()
        {
            DefaultMessageFactory dmf = new DefaultMessageFactory();

            Group g44 = dmf.Create("FIX.4.4", "B", 33);
            Assert.IsInstanceOf<QuickFix.FIX44.News.LinesOfTextGroup>(g44);

            Group g50 = dmf.Create("FIXT.1.1", "B", 33);
            Assert.IsInstanceOf<QuickFix.FIX50.News.NoLinesOfTextGroup>(g50);
        }
    }
}
