using System;
using NUnit.Framework;
using QuickFix.Fields;

namespace UnitTests
{
    [TestFixture]
    public class GenMessageTests
    {
        [Test]
        public void TcrFieldPropertiesTest()
        {
            decimal val = 3.232535m;
            QuickFix.FIX44.TradeCaptureReport tcr = new();
            tcr.AvgPx = new AvgPx(val);
            Assert.That(tcr.AvgPx.Value, Is.EqualTo(val));
        }

        [Test]
        public void TcrFieldGetterTest()
        {
            AvgPx avgPx = new AvgPx(10.5m);
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.SetField(avgPx);
            Assert.That(tcr.AvgPx.Value, Is.EqualTo(avgPx.Value));
            AvgPx avgPx2 = new AvgPx();
            tcr.GetField(avgPx2);
            Assert.That(avgPx2.Value, Is.EqualTo(avgPx.Value));
        }

        [Test]
        public void TcrFieldSetterTypeSafeOldWayTest()
        {
            AvgPx avgPx = new AvgPx(10.5m);
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.Set(avgPx);
            Assert.That(tcr.AvgPx.Value, Is.EqualTo(avgPx.Value));
        }


        [Test]
        public void TcrFieldGetterTypeSafeOldWayTest()
        {
            AvgPx avgPx = new AvgPx(10.5m);
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.Set(new AvgPx(10.5m));
            tcr.Get(avgPx);
            Assert.That(tcr.AvgPx.Value, Is.EqualTo(avgPx.Value));
        }

        [Test]
        public void TcrMsgTypeGetsSetTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            Assert.That(tcr.Header.IsSetField(Tags.MsgType), Is.True);
            MsgType msgType = new MsgType();
            tcr.Header.GetField(msgType);
            Assert.That(msgType.Value, Is.EqualTo("AE"));
        }

        [Test]
        public void TcrReqFieldsCtorTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport(
                new TradeReportID("dude1"),
                new PreviouslyReported(true),
                new Symbol("AAPL"),
                new LastQty(100.1m),
                new LastPx(100.2m),
                new TradeDate("2010-12-12"),
                new TransactTime(new DateTime(2010, 12, 15, 10, 55, 32, 455)));
            Assert.That(tcr.Symbol.Value, Is.EqualTo("AAPL"));
            Assert.That(tcr.TradeReportID.Value, Is.EqualTo("dude1"));
            MsgType msgType = new MsgType();
            tcr.Header.GetField(msgType);
            Assert.That(msgType.Value, Is.EqualTo("AE"));
        }

        [Test]
        public void TcrIsSetTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport(
                new TradeReportID("dude1"),
                new PreviouslyReported(true),
                new Symbol("AAPL"),
                new LastQty(100.1m),
                new LastPx(100.2m),
                new TradeDate("2010-12-12"),
                new TransactTime(new DateTime(2010, 12, 15, 10, 55, 32, 455)));
            LastPx lastPx = new LastPx();
            Assert.That(tcr.IsSet(lastPx), Is.True);
            AvgPx avgPx = new AvgPx(10.5m);
            Assert.That(tcr.IsSet(avgPx), Is.False);
            Assert.That(tcr.IsSetAvgPx(), Is.False);
            tcr.Set(avgPx);
            Assert.That(tcr.IsSet(avgPx), Is.True);
            Assert.That(tcr.IsSetAvgPx(), Is.True);

        }

        [Test]
        public void TcrGroupCtorTest()
        {
            int[] expFieldOrder =
            [
                54, 37, 198, 11, 526, 66, 453, 1, 660, 581, 81, 575, 576,
                    635, 578, 579, 821, 15, 376, 377, 528, 529, 582, 40, 18, 483,
                    336, 625, 943, 12, 13, 479, 497, 381, 157, 230, 158, 159,
                    738, 920, 921, 922, 238, 237, 118, 119, 120, 155, 156, 77,
                    58, 354, 355, 752, 518, 232, 136, 825, 826, 591, 70, 78, 0
            ];
            QuickFix.FIX44.TradeCaptureReport.NoSidesGroup noSides = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
            Assert.That(noSides.FieldOrder, Is.EqualTo(expFieldOrder));
            Assert.That(QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.fieldOrder, Is.EqualTo(expFieldOrder));
        }

        [Test]
        public void TcrGroupInGroupCtorTest()
        {
            int[] expFieldOrder = [757, 758, 759, 806, 0];
            QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup grp = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
            Assert.That(grp.FieldOrder, Is.EqualTo(expFieldOrder));
            Assert.That(QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.fieldOrder, Is.EqualTo(expFieldOrder));
        }

        [Test]
        public void TcrGroupFieldGetterSetterTest()
        {
            QuickFix.FIX44.TradeCaptureReport.NoSidesGroup noSides = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
            OrderID ordId = new OrderID("fooey");
            Assert.That(noSides.IsSet(ordId), Is.False);
            Assert.That(noSides.IsSetOrderID(), Is.False);
            noSides.Set(ordId);
            Assert.That(noSides.IsSet(ordId), Is.True);
            Assert.That(noSides.IsSetOrderID(), Is.True);
            Assert.That(noSides.OrderID.Value, Is.EqualTo("fooey"));
        }
    }
}
