using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{
    [TestFixture]
    public class GenMessageTests
    {
        [Test]
        public void TCRFieldProperties()
        {
            Decimal val = new Decimal(3.232535);
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.AvgPx = new AvgPx(val);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(val));
        }

        [Test]
        public void TCRFieldGetter()
        {
            AvgPx avgPx = new AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.setField(avgPx);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(avgPx.getValue()));
            AvgPx avgPx2 = new AvgPx();
            tcr.getField(avgPx2);
            Assert.That(avgPx2.getValue(), Is.EqualTo(avgPx.getValue()));
        }

        [Test]
        public void TCRFieldSetterTypeSafeOldWay()
        {
            AvgPx avgPx = new AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.set(avgPx);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(avgPx.getValue()));
        }


        [Test]
        public void TCRFieldGetterTypeSafeOldWay()
        {
            AvgPx avgPx = new AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.set(new AvgPx(new Decimal(10.5)));
            tcr.get(avgPx);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(avgPx.getValue()));
        }
    }
}
