Repeating Groups
================

QuickFIX/N creates and reads repeating groups in FIX messages.

Creating Groups
---------------

Creating groups is straightforward - instantiate the specific group
class then add it to the message:

```c#
var tcr = new QuickfiFix.FIX44.TradeCaptureReport();
var sidesGrp1 = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
sidesGrp1.Account = new Account("Silvio");
sidesGrp1.OrderID = new OrderID("09011900");
sidesGrp1.Side = new Side(Side.BUY);

var sidesGrp2 = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
sidesGrp2.Account = new Account("Sven");
sidesGrp2.OrderID = new OrderID("2000");
sidesGrp2.Side = new Side(Side.BUY);

tcr.AddGroup(sidesGrp1);
tcr.AddGroup(sidesGrp2);
```

We can create groups inside of groups, too:

```c#
var tcr = new QuickFix.FIX44.TradeCaptureReport();
var sidesGrp = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
sidesGrp.Side = new Side(Side.BUY);
sidesGrp.Account = new Account("Piola");
sidesGrp.OrderID = new OrderID("09011900");
var partyIdsGrp = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
partyIdsGrp.PartyID = new PartyID("Nesta13");
sidesGrp.AddGroup(partyIdsGrp);
tcr.AddGroup(sidesGrp);
```

Reading Groups
--------------

To read a group from a message, we supply the tag of the group field and
the index of the group:

```c#
var sidesGrp1 = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
sidesGrp1 = tcr.GetGroup(1, Tags.NoSides);
var sidesGrp2 = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
sidesGrp2 = tcr.GetGroup(2, Tags.NoSides);
```

Group indexes start at `1`.  

To iterate the groups, we use a `for` loop with the value of the group field:

```c#
var noSidesGrp = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
for(int grpIndex = 1; grpIndex<= message.GetInt(Tags.NoSides); grpIndex += 1)
{
    noSidesGrp = message.GetGroup(grpIndex, Tags.NoSides);
}
```

