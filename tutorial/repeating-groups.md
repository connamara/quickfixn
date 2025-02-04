---
layout: page
title: Repeating Groups
menu_title: Repeating Groups
type: tutorial
weight: 8
---

QuickFIX/N creates and reads repeating groups in FIX messages.

Creating Groups
---------------

Creating groups is straightforward - instantiate the specific group
class then add it to the message:

```csharp
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

```csharp
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

To read a group from a message, we use GetGroup() and supply a reference
to a new group object of the appropriate type.  The extracted group
gets assigned to this parameter.

```csharp
var sidesGrp1 = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
tcr.GetGroup(1, sidesGrp1);
// sidesGrp1 now has all fields populated
var sidesGrp2 = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
tcr.GetGroup(2, sidesGrp2);
```

Group indexes start at `1`.  

To iterate the groups, we can use a `for` loop with the value of the group field:

```csharp
var noSidesGrp = new QuickFix.FIX44.TradeCaptureReport.NoSidesGroup();
for(int grpIndex = 1; grpIndex<= message.GetInt(Tags.NoSides); grpIndex += 1)
{
    message.GetGroup(grpIndex, noSidesGrp);
    // ...do stuff with noSidesGrp...
}
```

New in 1.13 - ReadGroups() iterator
===================================

In v1.13 we introduced a new method, `ReadGroups`, that allows you to iterate through
a set of groups with `foreach`:

```csharp
foreach (var grp in msg.ReadGroups<QuickFix.FIX44.TradeCaptureReport.NoSidesGroup>(552)) {
    // ...do stuff with grp...
}
```

