using System;
using System.Collections.Generic;
using System.Text;
using QuickFix;
using QuickFix.Fields;
using Xunit;

namespace UnitTests
{
    public class GenMessageTests
    {
        [Fact]
        public void TCRFieldPropertiesTest()
        {
            Decimal val = 3.232535M;
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.AvgPx = new AvgPx(val);
            Assert.Equal(tcr.AvgPx.getValue(), val);
        }

        [Fact]
        public void TCRFieldGetterTest()
        {
            AvgPx avgPx = new AvgPx(10.5M);
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.SetField(avgPx);
            Assert.Equal(tcr.AvgPx.getValue(), avgPx.getValue());
            AvgPx avgPx2 = new AvgPx();
            tcr.GetField(avgPx2);
            Assert.Equal(avgPx2.getValue(), avgPx.getValue());
        }

        [Fact]
        public void TCRFieldSetterTypeSafeOldWayTest()
        {
            AvgPx avgPx = new AvgPx(10.5M);
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.Set(avgPx);
            Assert.Equal(tcr.AvgPx.getValue(), avgPx.getValue());
        }

        [Fact]
        public void TCRFieldGetterTypeSafeOldWayTest()
        {
            AvgPx avgPx = new AvgPx(10.5M);
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            tcr.Set(new AvgPx(10.5M));
            tcr.Get(avgPx);
            Assert.Equal(tcr.AvgPx.getValue(), avgPx.getValue());
        }

        [Fact]
        public void TCRMsgTypeGetsSetTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport();
            Assert.True(tcr.Header.IsSetField(QuickFix.Fields.Tags.MsgType));
            MsgType msgType = new MsgType();
            tcr.Header.GetField(msgType);
            Assert.Equal("AE", msgType.getValue());
        }

        [Fact]
        public void TCRReqFieldsCTORTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport(
                new TradeReportID("dude1"),
                new PreviouslyReported(true),
                new Symbol("AAPL"),
                new LastQty(100.1M),
                new LastPx(100.2M),
                new TradeDate("2010-12-12"),
                new TransactTime(new DateTime(2010, 12, 15, 10, 55, 32, 455)));
            Assert.Equal("AAPL", tcr.Symbol.getValue());
            Assert.Equal("dude1", tcr.TradeReportID.getValue());
            MsgType msgType = new MsgType();
            tcr.Header.GetField(msgType);
            Assert.Equal("AE", msgType.getValue());
        }

        [Fact]
        public void TCRisSetTest()
        {
            QuickFix.FIX44.TradeCaptureReport tcr = new QuickFix.FIX44.TradeCaptureReport(
                new TradeReportID("dude1"),
                new PreviouslyReported(true),
                new Symbol("AAPL"),
                new LastQty(100.1M),
                new LastPx(100.2M),
                new TradeDate("2010-12-12"),
                new TransactTime(new DateTime(2010, 12, 15, 10, 55, 32, 455)));
            LastPx lastPx = new LastPx();
            Assert.True(tcr.IsSet(lastPx));
            AvgPx avgPx = new AvgPx(10.5M);
            Assert.False(tcr.IsSet(avgPx));
            Assert.False(tcr.IsSetAvgPx());
            tcr.Set(avgPx);
            Assert.True(tcr.IsSet(avgPx));
            Assert.True(tcr.IsSetAvgPx());

        }

        [Fact]
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
            Assert.Equal(noSides.FieldOrder, expFieldOrder);
            Assert.Equal(QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.fieldOrder, expFieldOrder);
        }

        [Fact]
        public void TCRGroupInGroupCTORTest()
        {
            int[] expFieldOrder = { 757, 758, 759, 806, 0 };
            QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup grp = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup();
            Assert.Equal(grp.FieldOrder, expFieldOrder);
            Assert.Equal(QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoAllocsGroup.NoNested2PartyIDsGroup.fieldOrder, expFieldOrder);
        }

        [Fact]
        public void TCRGroupFieldGetterSetterTest()
        {
            QuickFix.FIX44.TradeCaptureReport.NoSidesGroup noSides = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
            OrderID ordId = new OrderID("fooey");
            Assert.False(noSides.IsSet(ordId));
            Assert.False(noSides.IsSetOrderID());
            noSides.Set(ordId);
            Assert.True(noSides.IsSet(ordId));
            Assert.True(noSides.IsSetOrderID());
            Assert.Equal("fooey", noSides.OrderID.getValue());
        }
    }
}
