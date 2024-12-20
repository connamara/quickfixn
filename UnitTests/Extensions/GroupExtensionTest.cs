using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;
using QuickFix.Extensions;
using System;
using UnitTests.TestHelpers;
using System.Linq;

namespace UnitTests.Extensions
{
    [TestFixture]
    public class GroupExtensionTest
    {
        private IMessageFactory _defaultMsgFactory = new DefaultMessageFactory();

        [Test]
        public void EnumerableGroupsTest()
        {
            var nos = new QuickFix.FIX42.NewOrderSingle();
            for (int i = 0; i < 100; i++)
            {
                var noTradingSessions = new QuickFix.FIX42.NewOrderSingle.NoTradingSessionsGroup();
                noTradingSessions.SetField(new StringField(336, $"OHHAI_{i}"));
                nos.AddGroup(noTradingSessions);
            }
            int iterator = 0;
            foreach (var item in nos.ReadGroups<QuickFix.FIX42.NewOrderSingle.NoTradingSessionsGroup>(Tags.NoTradingSessions))
            {
                Assert.That(item.GetString(336), Is.EqualTo($"OHHAI_{iterator++}"));
            }
            Assert.That(iterator == 100);

            // Wrong tag
            Assert.That(nos.ReadGroups<QuickFix.FIX42.NewOrderSingle.NoTradingSessionsGroup>(1), Is.Empty);

            // Wrong group
            foreach (var item in nos.ReadGroups<QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup>(Tags.NoTradingSessions))
            {
                Assert.That(item, Is.Null);
            }

            //--
            String data = "8=FIX.4.4\x01" + "9=309\x01" + "35=8\x01" + "49=ASX\x01" + "56=CL1_FIX44\x01" + "34=4\x01" + "52=20060324-01:05:58\x01" + ""
               + "17=X-B-WOW-1494E9A0:58BD3F9D-1109\x01" + "150=D\x01" + "39=0\x01" + "11=184271\x01" + "38=200\x01" + "198=1494E9A0:58BD3F9D\x01" + ""
               + "526=4324\x01" + "37=B-WOW-1494E9A0:58BD3F9D\x01" + "55=WOW\x01" + "54=1\x01" + "151=200\x01" + "14=0\x01" + "40=2\x01" + "44=15\x01" + "59=1\x01" + "6=0\x01" + ""
               + "453=3\x01"
               + "448=AAA35791\x01" + "447=D\x01" + "452=3\x01" + "802=1\x01" + "523=OHAI123\x01"
               + "448=8\x01" + "447=D\x01" + "452=4\x01" 
               + "448=FIX11\x01" + "447=D\x01" + "452=36\x01" + ""
               + "60=20060320-03:34:29\x01" + "10=169\x01" + "";
            var msg = new QuickFix.FIX44.ExecutionReport();
            var dd = new QuickFix.DataDictionary.DataDictionary();
            dd.LoadFIXSpec("FIX44");
            msg.FromString(data, false, dd, dd, _defaultMsgFactory);

            var eRNoPartyIDsGroup = msg.ReadGroups<QuickFix.FIX44.ExecutionReport.NoPartyIDsGroup>(Tags.NoPartyIDs).ToList();
            Assert.That(eRNoPartyIDsGroup[0].PartyID?.Value, Is.EqualTo("AAA35791"));
            Assert.That(eRNoPartyIDsGroup[2].PartyID?.Value, Is.EqualTo("FIX11"));
        }
    }
}
