using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{
    [TestFixture]
    public class GroupTests
    {
        [Test]
        public void SubGroup()
        {
            // issue #11 bug, as reported by karabiberoglu's further-down post

            QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup noParty = new();
            noParty.PartyID = new PartyID("ABC");
            noParty.PartyIDSource = new PartyIDSource(PartyIDSource.PROPRIETARY_CUSTOM_CODE);
            noParty.PartyRole = new PartyRole(PartyRole.CLEARING_FIRM);

            // group in group
            QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup noPartySub = new();
            noPartySub.PartySubID = new PartySubID("subABC");
            noPartySub.PartySubIDType = new PartySubIDType(PartySubIDType.FIRM);
            noParty.AddGroup(noPartySub);
            noPartySub.PartySubID = new PartySubID("subDEF");
            noPartySub.PartySubIDType = new PartySubIDType(PartySubIDType.LOCATION);
            noParty.AddGroup(noPartySub);

            string msgString = noParty.ToString();
            string expected = "448=ABC|447=D|452=4|"
                              + "802=2|" //NoPartySubIDs
                              + "523=subABC|803=1|"
                              + "523=subDEF|803=31|";

            //Console.WriteLine(msgString);
            StringAssert.Contains(expected, msgString.Replace(Message.SOH, '|'));
        }

        [Test]
        public void GroupClone()
        {
            QuickFix.FIX42.News.LinesOfTextGroup linesGroup = new();
            linesGroup.Text = new Text("foo");
            linesGroup.EncodedText = new EncodedText("bar");

            QuickFix.FIX42.News.LinesOfTextGroup clone = (linesGroup.Clone() as QuickFix.FIX42.News.LinesOfTextGroup)!;

            Assert.AreEqual(linesGroup.Text.Value, clone.Text.Value);
            Assert.AreEqual(linesGroup.EncodedText.Value, clone.EncodedText.Value);
            Assert.AreEqual(linesGroup.Delim, clone.Delim);
            Assert.AreEqual(linesGroup.CounterField, clone.CounterField);
            Assert.AreEqual(linesGroup.FieldOrder, clone.FieldOrder);
        }
    }
}
