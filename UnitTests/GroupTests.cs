using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{
    public class GroupTests
    {
        [Fact]
        public void SubGroup()
        {
            // issue #11 bug, as reported by karabiberoglu's further-down post

            QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup noParty = new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup();
            noParty.PartyID = new QuickFix.Fields.PartyID("ABC");
            noParty.PartyIDSource = new QuickFix.Fields.PartyIDSource(QuickFix.Fields.PartyIDSource.PROPRIETARY_CUSTOM_CODE);
            noParty.PartyRole = new QuickFix.Fields.PartyRole(QuickFix.Fields.PartyRole.CLEARING_FIRM);

            // group in group
            QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup noPartySub = new QuickFix.FIX44.CollateralInquiry.NoPartyIDsGroup.NoPartySubIDsGroup();
            noPartySub.PartySubID = new QuickFix.Fields.PartySubID("subABC");
            noPartySub.PartySubIDType = new QuickFix.Fields.PartySubIDType(QuickFix.Fields.PartySubIDType.FIRM);
            noParty.AddGroup(noPartySub);
            noPartySub.PartySubID = new QuickFix.Fields.PartySubID("subDEF");
            noPartySub.PartySubIDType = new QuickFix.Fields.PartySubIDType(QuickFix.Fields.PartySubIDType.LOCATION);
            noParty.AddGroup(noPartySub);

            string msgString = noParty.ToString();
            string expected = String.Join(Message.SOH, new string[] {
                "448=ABC","447=D","452=4",
                "802=2", //NoPartySubIDs
                    "523=subABC","803=1",
                    "523=subDEF","803=31"
            });

            //Console.WriteLine(msgString);
            Assert.Contains(expected, msgString);
        }

        [Fact]
        public void GroupClone()
        {
            QuickFix.FIX42.News.LinesOfTextGroup linesGroup = new QuickFix.FIX42.News.LinesOfTextGroup();
            linesGroup.Text = new QuickFix.Fields.Text("foo");
            linesGroup.EncodedText = new QuickFix.Fields.EncodedText("bar");

            QuickFix.FIX42.News.LinesOfTextGroup clone = linesGroup.Clone() as QuickFix.FIX42.News.LinesOfTextGroup;

            Assert.Equal(linesGroup.Text.Obj, clone.Text.Obj);
            Assert.Equal(linesGroup.EncodedText.Obj, clone.EncodedText.Obj);
            Assert.Equal(linesGroup.Delim, clone.Delim);
            Assert.Equal(linesGroup.Field, clone.Field);
            Assert.Equal(linesGroup.FieldOrder, clone.FieldOrder);
        }
    }
}
