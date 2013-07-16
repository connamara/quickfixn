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
            tcr.AvgPx = new QuickFix.FIX44.Fields.AvgPx(val);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(val));
        }

        [Test]
        public void TCRFieldGetterTest()
        {
            QuickFix.FIX44.Fields.AvgPx avgPx = new QuickFix.FIX44.Fields.AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.SetField(avgPx);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(avgPx.getValue()));
            QuickFix.FIX44.Fields.AvgPx avgPx2 = new QuickFix.FIX44.Fields.AvgPx();
            tcr.GetField(avgPx2);
            Assert.That(avgPx2.getValue(), Is.EqualTo(avgPx.getValue()));
        }

        [Test]
        public void TCRFieldSetterTypeSafeOldWayTest()
        {
            QuickFix.FIX44.Fields.AvgPx avgPx = new QuickFix.FIX44.Fields.AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.Set(avgPx);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(avgPx.getValue()));
        }


        [Test]
        public void TCRFieldGetterTypeSafeOldWayTest()
        {
            QuickFix.FIX44.Fields.AvgPx avgPx = new QuickFix.FIX44.Fields.AvgPx(new Decimal(10.5));
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.Set(new QuickFix.FIX44.Fields.AvgPx(new Decimal(10.5)));
            tcr.Get(avgPx);
            Assert.That(tcr.AvgPx.getValue(), Is.EqualTo(avgPx.getValue()));
        }

        [Test]
        public void TCRMsgTypeGetsSetTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            Assert.That(tcr.Header.IsSetField(QuickFix.Fields.Tags.MsgType), Is.True);
            MsgType msgType = new MsgType();
            tcr.Header.GetField(msgType);
            Assert.That(msgType.getValue(), Is.EqualTo("AE"));
        }

        [Test]
        public void TCRReqFieldsCTORTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport(
                new QuickFix.FIX44.Fields.TradeReportID("dude1"),
                new QuickFix.FIX44.Fields.PreviouslyReported(true),
                new QuickFix.FIX44.Fields.Symbol("AAPL"),
                new QuickFix.FIX44.Fields.LastQty(new Decimal(100.1)),
                new QuickFix.FIX44.Fields.LastPx(new Decimal(100.2)),
                new QuickFix.FIX44.Fields.TradeDate("2010-12-12"),
                new QuickFix.FIX44.Fields.TransactTime(new DateTime(2010, 12, 15, 10, 55, 32, 455)));
            Assert.That(tcr.Symbol.getValue(), Is.EqualTo("AAPL"));
            Assert.That(tcr.TradeReportID.getValue(), Is.EqualTo("dude1"));
            MsgType msgType = new MsgType();
            tcr.Header.GetField(msgType);
            Assert.That(msgType.getValue(), Is.EqualTo("AE"));
        }

        [Test]
        public void TCRisSetTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport(
                new QuickFix.FIX44.Fields.TradeReportID("dude1"),
                new QuickFix.FIX44.Fields.PreviouslyReported(true),
                new QuickFix.FIX44.Fields.Symbol("AAPL"),
                new QuickFix.FIX44.Fields.LastQty(new Decimal(100.1)),
                new QuickFix.FIX44.Fields.LastPx(new Decimal(100.2)),
                new QuickFix.FIX44.Fields.TradeDate("2010-12-12"),
                new QuickFix.FIX44.Fields.TransactTime(new DateTime(2010, 12, 15, 10, 55, 32, 455)));
            QuickFix.FIX44.Fields.LastPx lastPx = new QuickFix.FIX44.Fields.LastPx();
            Assert.That(tcr.IsSet(lastPx), Is.True);
            QuickFix.FIX44.Fields.AvgPx avgPx = new QuickFix.FIX44.Fields.AvgPx(new Decimal(10.5));
            Assert.That(tcr.IsSet(avgPx), Is.False);
            Assert.That(tcr.IsSetAvgPx(), Is.False);
            tcr.Set(avgPx);
            Assert.That(tcr.IsSet(avgPx), Is.True);
            Assert.That(tcr.IsSetAvgPx(), Is.True);

        }

        [Test]
        public void TCRGroupCTORTest()
        {
            int[] expFieldOrder = new int[] {
                    54, 37, 198, 11, 526, 66, 453, 1, 660, 581, 81, 575, 576,
                    635, 578, 579, 821, 15, 376, 377, 528, 529, 582, 40, 18, 483,
                    336, 625, 943, 12, 13, 479, 497, 381, 157, 230, 158, 159,
                    738, 920, 921, 922, 238, 237, 118, 119, 120, 155, 156, 77,
                    58, 354, 355, 752, 518, 232, 136, 825, 826, 591, 70, 78, 0
                };
            QuickFix.FIX44.TradeCaptureReport.NoSidesGroup noSides = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
            Assert.That(noSides.FieldOrder, Is.EqualTo(expFieldOrder));
            Assert.That(QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.fieldOrder, Is.EqualTo(expFieldOrder));
        }

        [Test]
        public void TCRGroupInGroupCTORTest()
        {
            int[] expFieldOrder = { 757, 758, 759, 806, 0 };
            QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup grp = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
            Assert.That(grp.FieldOrder, Is.EqualTo(expFieldOrder));
            Assert.That(QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.fieldOrder, Is.EqualTo(expFieldOrder));
        }

        [Test]
        public void TCRGroupFieldGetterSetterTest()
        {
            QuickFix.FIX44.TradeCaptureReport.NoSidesGroup noSides = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
            QuickFix.FIX44.Fields.OrderID ordId = new QuickFix.FIX44.Fields.OrderID("fooey");
            Assert.That(noSides.IsSet(ordId), Is.False);
            Assert.That(noSides.IsSetOrderID(), Is.False);
            noSides.Set(ordId);
            Assert.That(noSides.IsSet(ordId), Is.True);
            Assert.That(noSides.IsSetOrderID(), Is.True);
            Assert.That(noSides.OrderID.getValue(), Is.EqualTo("fooey"));
        }
    }
}
