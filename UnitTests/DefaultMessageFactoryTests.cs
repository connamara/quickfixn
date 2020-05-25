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
        public void GroupCreateTest_Fix50()
        {
            DefaultMessageFactory dmf = new DefaultMessageFactory(QuickFix.FixValues.ApplVerID.FIX50);

            Group g44 = dmf.Create("FIX.4.4", "B", 33);
            Assert.IsInstanceOf<QuickFix.FIX44.News.LinesOfTextGroup>(g44);

            Group g50 = dmf.Create("FIXT.1.1", "B", 33);
            Assert.IsInstanceOf<QuickFix.FIX50.News.NoLinesOfTextGroup>(g50);

            Group g50sp2 = dmf.Create("FIXT.1.1", "CD", QuickFix.Fields.Tags.NoAsgnReqs);
            Assert.IsNull(g50sp2);
        }

        [Test]
        public void GroupCreateTest_DefaultFix50Sp2()
        {
            DefaultMessageFactory dmf = new DefaultMessageFactory();

            Group g44 = dmf.Create("FIX.4.4", "B", 33);
            Assert.IsInstanceOf<QuickFix.FIX44.News.LinesOfTextGroup>(g44);

            Group g50sp2 = dmf.Create("FIXT.1.1", "CD", QuickFix.Fields.Tags.NoAsgnReqs);
            Assert.IsInstanceOf<QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup>(g50sp2);
        }
    }
}
