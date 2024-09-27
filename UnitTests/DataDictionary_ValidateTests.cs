using NUnit.Framework;
using QuickFix;
using QuickFix.DataDictionary;
using QuickFix.Fields;
using UnitTests.TestHelpers;

namespace UnitTests;

public class DataDictionary_ValidateTests
{
    [Test]
    public void UnsupportedVersionTest() {
        DataDictionary dd = new();
        dd.LoadFIXSpec("FIX44");

        var ex = Assert.Throws<UnsupportedVersion>(delegate {
            DataDictionary.Validate(new Message(), dd, dd, "foobar", "X"); });
        StringAssert.Contains("Incorrect BeginString (foobar)", ex!.Message);
    }

    [Test]
    public void TagOutOfOrderTest() {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        string msgStr = ("8=FIX.4.4|9=102|35=B|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "148=headline|33=2|58=line1|58=line2|" +
                         "142=narnia|" +
                         "10=121|").Replace('|', Message.SOH);
        string msgType = "B";
        string beginString = "FIX.4.4";

        Message msg = f.Create(beginString, msgType);
        msg.FromString(msgStr, true, dd, dd, f);

        // Mess the message up to trigger the fail
        msg.SetField(new SenderLocationID("narnia")); // header field in body
        msg.ConstructString(); // recalc checksum
        msg.Validate();

        var ex = Assert.Throws<TagOutOfOrder>(delegate {
            DataDictionary.Validate(msg, dd, dd, "FIX.4.4", "B"); });
        StringAssert.Contains("Tag specified out of required order", ex!.Message);
    }

    [Test]
    public void ValidateWrongType()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        string msgStr = ("8=FIX.4.4|9=120|35=D|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "11=clordid|55=sym|54=1|60=20110909-09:09:09.999|40=1|" +
                         "38=failboat|" + // should be a decimal
                         "10=64|").Replace('|', Message.SOH);
        string msgType = "D";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd, f);

        Assert.That(() => DataDictionary.Validate(message, dd, dd, beginString, msgType),
            Throws.TypeOf<IncorrectDataFormat>());
    }

    [Test]
    public void ValidateWithRepeatingGroupTest()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX42");
        QuickFix.FIX42.MessageFactory f = new QuickFix.FIX42.MessageFactory();

        string msgStr = ("8=FIX.4.2|9=87|35=B|34=3|49=CLIENT1|"
                         + "52=20111012-22:15:55.474|56=EXECUTOR|148=AAAAAAA|"
                         + "33=2|58=L1|58=L2|10=016|").Replace('|', Message.SOH);
        MsgType msgType = Message.IdentifyType(msgStr);
        string beginString = Message.ExtractBeginString(msgStr);

        Message message = f.Create(beginString, msgType.Value);
        message.FromString(msgStr, true, dd, dd, f);

        DataDictionary.Validate(message, dd, dd, beginString, msgType.Value);
    }

    [Test]
    public void ValidateGroupBeginsGroup()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadTestFIXSpec("group_begins_group");

        string msgStr = ("8=FIX.9.9|9=167|35=magic|34=3|49=CLIENT1|52=20111012-22:15:55.474|56=EXECUTOR|"
                         + "1111=mundane|5555=magicfield|6660=1|7770=2|7711=Hoppy|7712=brown|"
                         + "7711=Floppy|7712=white|6661=abracadabra|10=48|").Replace('|', Message.SOH);
        string beginString = Message.ExtractBeginString(msgStr);
        Message msg = new Message(msgStr, dd, dd, false);

        DataDictionary.Validate(msg, dd, dd, beginString, "magic");

        // Verify can retrieve one of the inner groups.
        // (Gotta use generic methods because code isn't generated for this DD)
        Group magicGroup = new Group(6660, 7770, new[] { 7770, 6661 });
        msg.GetGroup(1, magicGroup);
        Group rabbitGroup = new Group(7770, 7711, new[] { 7711, 7722 });
        magicGroup.GetGroup(2, rabbitGroup);

        Assert.AreEqual("abracadabra", magicGroup.GetString(6661));
        Assert.AreEqual("Floppy", rabbitGroup.GetString(7711));
        Assert.AreEqual("white", rabbitGroup.GetString(7712));
    }

    [Test]
    public void ValidateWrongTypeInRepeatingGroup()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        string msgStr = ("8=FIX.4.4|9=111|35=V|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "262=mdreqid|263=0|264=5|" +
                         "267=1|" + // MDReqGrp
                         "269=failboat|" + // should be a char
                         "146=1|" + // InstrmtMDReqGrp
                         "55=sym|" +
                         "10=91|").Replace('|', Message.SOH);
        string msgType = "V";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd, f);

        Assert.Throws<IncorrectDataFormat>(() => DataDictionary.Validate(message, dd, dd, beginString, msgType));
    }

    [Test]
    public void ValidateWrongTypeInNestedRepeatingGroup()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        string msgStr = ("8=FIX.4.4|9=185|35=J|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "70=AllocID|71=0|626=1|857=0|54=1|55=sym|53=1|6=5.5|75=20110909-09:09:09.999|" +
                         "73=1|" + // NoOrders
                         "11=clordid|" +
                         "756=1|" + // NoNested2PartyIDs
                         "757=nested2partyid|" +
                         "759=failboat|" + // supposed to be a int
                         "10=48|").Replace('|', Message.SOH);
        string msgType = "J";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd, f);

        Assert.Throws<IncorrectDataFormat>(() => DataDictionary.Validate(message, dd, dd, beginString, msgType));
    }

    [Test]
    public void ValidateDateAndTimeFields()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        string msgStr = ("8=FIX.4.4|9=104|35=W|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "55=sym|268=1|269=0|272=20111012|273=22:15:30.444|10=19|").Replace('|', Message.SOH);
        string msgType = "W";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd, f);

        DataDictionary.Validate(message, dd, dd, beginString, msgType);
    }

    [Test]
    public void ValidateDateTime_Invalid()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        // intentionally invalid SendingTime (52/DateTime)
        string msgStr = ("8=FIX.4.4|9=91|35=W|34=3|49=sender|52=20110909|56=target|" +
                         "55=sym|268=1|269=0|272=20111012|273=22:15:30.444|10=51|").Replace('|', Message.SOH);
        string msgType = "W";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd, f);

        Assert.Throws<IncorrectDataFormat>(() => DataDictionary.Validate(message, dd, dd, beginString, msgType));
    }

    [Test]
    public void ValidateDateOnly_Invalid()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        // intentionally invalid MDEntryDate (272/DateOnly)
        string msgStr = ("8=FIX.4.4|9=117|35=W|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "55=sym|268=1|269=0|272=20111012-22:15:30.444|273=22:15:30.444|10=175|")
            .Replace('|', Message.SOH);
        string msgType = "W";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd, f);

        Assert.Throws<IncorrectDataFormat>(() => DataDictionary.Validate(message, dd, dd, beginString, msgType));
    }

    [Test]
    public void ValidateTimeOnly_Invalid()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        // intentionally invalid MDEntryTime (272/TimeOnly)
        string msgStr = ("8=FIX.4.4|9=113|35=W|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "55=sym|268=1|269=0|272=20111012|273=20111012-22:15:30.444|10=200|").Replace('|', Message.SOH);
        string msgType = "W";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd, f);

        Assert.Throws<IncorrectDataFormat>(() => DataDictionary.Validate(message, dd, dd, beginString, msgType));
    }

    [Test]
    public void OptionalComponentRequiredField()
    {
        // issue #98 - message erroneously rejected because DD says that
        //   component-required field is missing even though component is not present

        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        string msgStr = ("8=FIX.4.4|9=77|35=AD|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "568=tradereqid|569=0|10=109|").Replace('|', Message.SOH);
        string msgType = "AD";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd, f);

        // AD only requires 568 and 569.
        // It has components, but none are required.
        DataDictionary.Validate(message, dd, dd, beginString, msgType);
    }

    [Test]
    public void RequiredComponentRequiredField()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        string msgStr = ("8=FIX.4.4|9=76|35=7|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "2=AdvId|5=N|4=B|53=1|10=138|").Replace('|', Message.SOH);
        string msgType = "7";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd, f);

        var ex = Assert.Throws<RequiredTagMissing>(() =>
            DataDictionary.Validate(message, dd, dd, beginString, msgType));
        Assert.AreEqual(55, ex!.Field);
    }

    [Test] // Issue #66
    public void ValidateMultipleValueStringType()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        string msgStr = ("8=FIX.4.4|9=99|35=W|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "55=sym|" +
                         "268=1|269=0|270=123.23|271=2|277=A B|" +
                         "10=213|").Replace('|', Message.SOH);
        string msgType = "W";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd);

        DataDictionary.Validate(message, dd, dd, beginString, msgType);
    }

    [Test] // Issue #66
    public void ValidateMultipleValueStringType_Invalid()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX44");
        QuickFix.FIX44.MessageFactory f = new QuickFix.FIX44.MessageFactory();

        string msgStr = ("8=FIX.4.4|9=99|35=W|34=3|49=sender|52=20110909-09:09:09.999|56=target|" +
                         "55=sym|" +
                         "268=1|269=0|270=123.23|271=2|277=A 1|" +
                         "10=196|").Replace('|', Message.SOH);
        string msgType = "W";
        string beginString = "FIX.4.4";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd);

        Assert.Throws<IncorrectTagValue>(() => DataDictionary.Validate(message, dd, dd, beginString, msgType));
    }

    [Test] // Issue #282
    public void ValidateTagSpecifiedWithoutAValue()
    {
        DataDictionary dd = new DataDictionary();
        dd.LoadFIXSpec("FIX42");
        QuickFix.FIX42.MessageFactory f = new QuickFix.FIX42.MessageFactory();

        string msgStr = "8=FIX.4.2|9=70|35=B|34=3|49=sender|52=20110909-09:09:09.999|56=target|358=|148=|33=0|10=150|"
            .Replace('|', Message.SOH);
        string msgType = "B";
        string beginString = "FIX.4.2";

        Message message = f.Create(beginString, msgType);
        message.FromString(msgStr, true, dd, dd);

        dd.CheckFieldsHaveValues = true;
        Assert.Throws<NoTagValue>(delegate { DataDictionary.Validate(message, dd, dd, beginString, msgType); });

        dd.CheckFieldsHaveValues = false;
        Assert.DoesNotThrow(delegate { DataDictionary.Validate(message, dd, dd, beginString, msgType); });
    }
}
