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
            tcr.avgPx = new AvgPx(val);
            Assert.That(tcr.avgPx.getValue(), Is.EqualTo(val));
        }

        [Test]
        public void TCRFieldGetterTest()
        {
            AvgPx avgPx = new AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.setField(avgPx);
            Assert.That(tcr.avgPx.getValue(), Is.EqualTo(avgPx.getValue()));
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
            Assert.That(tcr.avgPx.getValue(), Is.EqualTo(avgPx.getValue()));
        }


        [Test]
        public void TCRFieldGetterTypeSafeOldWayTest()
        {
            AvgPx avgPx = new AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.set(new AvgPx(new Decimal(10.5)));
            tcr.get(avgPx);
            Assert.That(tcr.avgPx.getValue(), Is.EqualTo(avgPx.getValue()));
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
            Assert.That(tcr.symbol.getValue(), Is.EqualTo("AAPL"));
            Assert.That(tcr.tradeReportID.getValue(), Is.EqualTo("dude1"));
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

        [Test]
        public void TCRGroupCTORTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            int[] expFieldOrder = new int[] {
                    54, 37, 198, 11, 526, 66, 453, 1, 660, 581, 81, 575, 576,
                    635, 578, 579, 821, 15, 376, 377, 528, 529, 582, 40, 18, 483,
                    336, 625, 943, 12, 13, 479, 497, 381, 157, 230, 158, 159,
                    738, 920, 921, 922, 238, 237, 118, 119, 120, 155, 156, 77,
                    58, 354, 355, 752, 518, 232, 136, 825, 826, 591, 70, 78, 0
                };
            QuickFix.FIX44.TradeCaptureReport.NoSides noSides = new QuickFix.FIX44.TradeCaptureReport.NoSides();
            Assert.That(noSides.FieldOrder, Is.EqualTo(expFieldOrder));
            Assert.That(QuickFix.FIX44.TradeCaptureReport.NoSides.fieldOrder, Is.EqualTo(expFieldOrder));
        }

        [Test]
        public void TCRGroupInGroupCTORTest()
        {
            int[] expFieldOrder = { 757, 758, 759, 806, 0 };
            QuickFix.FIX44.TradeCaptureReport.NoSides.NoAllocs.NoNested2PartyIDs grp = new QuickFix.FIX44.TradeCaptureReport.NoSides.NoAllocs.NoNested2PartyIDs();
            Assert.That(grp.FieldOrder, Is.EqualTo(expFieldOrder));
            Assert.That(QuickFix.FIX44.TradeCaptureReport.NoSides.NoAllocs.NoNested2PartyIDs.fieldOrder, Is.EqualTo(expFieldOrder));
        }

        [Test]
        public void TCRGroupFieldGetterSetterTest()
        {
            QuickFix.FIX44.TradeCaptureReport.NoSides noSides = new QuickFix.FIX44.TradeCaptureReport.NoSides();
            OrderID ordId = new OrderID("fooey");
            Assert.That(noSides.isSet(ordId), Is.False);
            Assert.That(noSides.isSetOrderID(), Is.False);
            noSides.set(ordId);
            Assert.That(noSides.isSet(ordId), Is.True);
            Assert.That(noSides.isSetOrderID(), Is.True);
            Assert.That(noSides.orderID.getValue(), Is.EqualTo("fooey"));
        }
    }
}
