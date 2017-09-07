using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix;
using Xunit;

namespace UnitTests
{
    public class DefaultMessageFactoryTests
    {
        [Fact]
        public void GroupCreateTest()
        {
            DefaultMessageFactory dmf = new DefaultMessageFactory();

            Group g44 = dmf.Create("FIX.4.4", "B", 33);
            Assert.IsType<QuickFix.FIX44.News.LinesOfTextGroup>(g44);

            Group g50 = dmf.Create("FIXT.1.1", "B", 33);
            Assert.IsType<QuickFix.FIX50.News.NoLinesOfTextGroup>(g50);
        }
    }
}
