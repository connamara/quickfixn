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
        public void TCRFieldPropertiesTest()
        {
            Decimal val = new Decimal(3.232535);
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.AvgPx = new AvgPx(val);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(val));
        }

        [Test]
        public void TCRFieldGetterTest()
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
        public void TCRFieldSetterTypeSafeOldWayTest()
        {
            AvgPx avgPx = new AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.set(avgPx);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(avgPx.getValue()));
        }


        [Test]
        public void TCRFieldGetterTypeSafeOldWayTest()
        {
            AvgPx avgPx = new AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.set(new AvgPx(new Decimal(10.5)));
            tcr.get(avgPx);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(avgPx.getValue()));
        }

        [Test]
        public void TCRMsgTypeGetsSetTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            Assert.That(tcr.Header.isSetField(QuickFix.Fields.Tags.MsgType), Is.True);
            MsgType msgType = new MsgType();
            tcr.Header.getField(msgType);
            Assert.That(msgType.getValue(), Is.EqualTo("AE"));
        }

        [Test]
        public void TCRReqFieldsCTORTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport(
                new TradeReportID("dude1"),
                new PreviouslyReported(true),
                new Symbol("AAPL"),
                new LastQty(new Decimal(100.1)),
                new LastPx(new Decimal(100.2)),
                new TradeDate("2010-12-12"),
                new TransactTime(new DateTime(2010, 12, 15, 10, 55, 32, 455)));
            Assert.That(tcr.Symbol.getValue(), Is.EqualTo("AAPL"));
            Assert.That(tcr.TradeReportID.getValue(), Is.EqualTo("dude1"));
            MsgType msgType = new MsgType();
            tcr.Header.getField(msgType);
            Assert.That(msgType.getValue(), Is.EqualTo("AE"));
        }

        [Test]
        public void TCRisSetTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport(
                new TradeReportID("dude1"),
                new PreviouslyReported(true),
                new Symbol("AAPL"),
                new LastQty(new Decimal(100.1)),
                new LastPx(new Decimal(100.2)),
                new TradeDate("2010-12-12"),
                new TransactTime(new DateTime(2010, 12, 15, 10, 55, 32, 455)));
            LastPx lastPx = new LastPx();
            Assert.That(tcr.isSet(lastPx), Is.True);
            AvgPx avgPx = new AvgPx(new Decimal(10.5));
            Assert.That(tcr.isSet(avgPx), Is.False);
            Assert.That(tcr.isSetAvgPx(), Is.False);
            tcr.set(avgPx);
            Assert.That(tcr.isSet(avgPx), Is.True);
            Assert.That(tcr.isSetAvgPx(), Is.True);

        }
    }
}
