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

            Group? g44 = dmf.Create("FIX.4.4", "B", 33);
            Assert.That(g44, Is.InstanceOf<QuickFix.FIX44.News.LinesOfTextGroup>());

            Group? g50 = dmf.Create("FIXT.1.1", "B", 33);
            Assert.That(g50, Is.InstanceOf<QuickFix.FIX50.News.NoLinesOfTextGroup>());

            Group? g50sp2 = dmf.Create("FIXT.1.1", "CD", QuickFix.Fields.Tags.NoAsgnReqs);
            Assert.That(g50sp2, Is.Null);
        }

        [Test]
        public void GroupCreateTest_DefaultFix50Sp2()
        {
            DefaultMessageFactory dmf = new DefaultMessageFactory();

            Group? g44 = dmf.Create("FIX.4.4", "B", 33);
            Assert.That(g44, Is.InstanceOf<QuickFix.FIX44.News.LinesOfTextGroup>());

            Group? g50sp2 = dmf.Create("FIXT.1.1", "CD", QuickFix.Fields.Tags.NoAsgnReqs);
            Assert.That(g50sp2, Is.InstanceOf<QuickFix.FIX50SP2.StreamAssignmentReport.NoAsgnReqsGroup>());
        }
    }
}
