using System;
using System.Linq;
using NUnit.Framework;
using QuickFix.Fields;

namespace UnitTests;

[TestFixture]
public class SessionCmeEnhancedResendTest : SessionTestBase
{
    [SetUp]
    public void Setup() {
        BaseSetup();
        _session!.CmeEnhancedResend = true;
        _session.EnableLastMsgSeqNumProcessed = true;
        _session2!.CmeEnhancedResend = true;
        _session2.EnableLastMsgSeqNumProcessed = true;
    }

    [Test]
    public void TestLogonResponseIsLogoutWith789Equals1() {
        // Capture key behavior of Autocert+ scenario:
        //   "Dropcopy CGW/MSGW Session Management Test - Beginning of week Logon"
        //   The step descriptions are directly from that test.
        // (We can't do an AT because this scenario needs the app-under-test to be an initiator.)

        // Step 1: "Over the Drop Copy client application,
        //   submit a Logon message with a sequence number greater than one"
        _session2!.NextSenderMsgSeqNum = 4;
        _session2.Next(); // session2 (an initiator) sends a logon
        QuickFix.Message sentLogon = _responder.MsgLookup[MsgType.LOGON].Dequeue();
        Assert.That(sentLogon.Header.GetInt(34), Is.EqualTo(4));

        // Step 2: "Receive and process a Logout message"
        //   This message matches exactly what Autocert+ sends (aside from Sender/Target identifiers).
        QuickFix.FIX42.Logout logout = new();
        logout.Header.SetField(new TargetCompID("OTHER_SENDER"));
        logout.Header.SetField(new SenderCompID("OTHER_TARGET"));
        Assert.That(_seqNum, Is.EqualTo(1));
        logout.Header.SetField(new MsgSeqNum(_seqNum++));
        logout.Header.SetField(new LastMsgSeqNumProcessed(0)); // tag 369
        logout.SetField(new Text("Failed to reset sequence numbers at the beginning of the week. Logout forced."));
        logout.SetField(new NextExpectedMsgSeqNum(1));
        _session2.Next(logout.ConstructString());

        QuickFix.Message logoutReply = _responder.MsgLookup[MsgType.LOGOUT].Dequeue();
        Assert.That(logoutReply.Header.GetInt(34), Is.EqualTo(5)); // Autocert+ might not even look at this
        Assert.That(logoutReply.Header.GetInt(369), Is.EqualTo(1));

        // Step 3: "Submit a Logon message using the proper sequence number" (which is 1)
        _session2.SetResponder(_responder); // ("reconnect" after previous logout)
        _session2.Next();
        QuickFix.Message reattemptLogon = _responder.MsgLookup[MsgType.LOGON].Dequeue();
        Assert.That(reattemptLogon.Header.GetInt(34), Is.EqualTo(1));
        Assert.That(reattemptLogon.Header.GetInt(369), Is.EqualTo(1));

        // should be expecting a 2 next
        Assert.That(_session2.NextTargetMsgSeqNum, Is.EqualTo(2));

        // Step 4: "Receive and process a Logon Confirmation message"
        //   Like before, this message matches what Autocert+ sends (aside from Sender/Target identifiers).
        QuickFix.FIX42.Logon logonConf = new();
        logonConf.Header.SetField(new TargetCompID("OTHER_SENDER"));
        logonConf.Header.SetField(new SenderCompID("OTHER_TARGET"));
        Assert.That(_seqNum, Is.EqualTo(2));
        logonConf.Header.SetField(new MsgSeqNum(_seqNum++));
        logonConf.Header.SetField(new LastMsgSeqNumProcessed(1)); // tag 369
        // there is no 789/NextExpectedMsgSeqNum in this msg!
        _session2.Next(logonConf.ConstructString());

        // Steps 5+: We don't need to test these.
        Assert.That(_session2.NextTargetMsgSeqNum, Is.EqualTo(3));
    }

    [Test]
    public void TestDontRepeatResendRequest() {
        // Setup: Connection established.  Server sends Seq too high, causing client to ResendRequest.
        Logon();
        SendNOSMessage();
        Assert.That(_session!.NextTargetMsgSeqNum, Is.EqualTo(3));

        SendNOSMessage(8);
        Assert.That(_responder.MsgLookup[MsgType.RESEND_REQUEST].Count, Is.EqualTo(1));

        QuickFix.Message originalReq = _responder.MsgLookup[MsgType.RESEND_REQUEST].Dequeue();
        Assert.That(originalReq.Header.GetULong(Tags.MsgSeqNum), Is.EqualTo(2));
        Assert.That(originalReq.GetInt(Tags.BeginSeqNo), Is.EqualTo(3));
        Assert.That(originalReq.GetInt(Tags.EndSeqNo), Is.EqualTo(0));
        Assert.That(originalReq.Header.GetInt(Tags.LastMsgSeqNumProcessed), Is.EqualTo(8));

        // Scenario Part 1: Server sends 2 not-resent messages.
        //                  Client does nothing.

        SendNOSMessage(9);
        SendNOSMessage(10);
        Assert.That(_responder.MsgLookup[MsgType.RESEND_REQUEST].Count,  Is.EqualTo(0));

        // current state: Session expects 3, but has received 1 2 8 9 10

        // Scenario Part 2: Server sends a resent message, then a regular message.
        //                  Client processes both and sends no reply.
        var resent = CreateNOSMessage(3);
        resent.Header.SetField(new PossDupFlag(true));
        resent.Header.SetField(new OrigSendingTime(DateTime.MinValue)); // (value doesn't matter for test)
        _session.Next(resent.ConstructString());
        SendNOSMessage(11);
        Assert.That(_responder.MsgLookup[MsgType.RESEND_REQUEST].Count, Is.EqualTo(0)); // no resends sent!
    }

    [Test]
    public void TestInterleavedResend() {
        // In ResendRequested state
        //   Receive regular message with seq == resend-end:
        //     [Exp] range is reset, ResendRequested state is over

        // Setup: Connection established.  Server sends Seq too high, causing client to ResendRequest.
        Logon();
        SendNOSMessage();
        Assert.That(_session!.NextTargetMsgSeqNum, Is.EqualTo(3));

        SendNOSMessage(6);
        QuickFix.Message[] resendRequests = _responder.MsgLookup[MsgType.RESEND_REQUEST].ToArray();
        Assert.That(resendRequests.Count, Is.EqualTo(1));

        QuickFix.Message originalReq = resendRequests[0];
        Assert.That(originalReq.GetInt(Tags.BeginSeqNo), Is.EqualTo(3));
        Assert.That(originalReq.GetInt(Tags.EndSeqNo), Is.EqualTo(0));
        Assert.That(originalReq.Header.GetInt(Tags.LastMsgSeqNumProcessed), Is.EqualTo(6));

        // 7 is not a resend.  The rest are.
        // The client shouldn't have any problem with this.
        foreach (SeqNumType i in new[] { 3, 4, 7, 5, 6, 8 }) {
            if (i < 7) {
                var msg = CreateNOSMessage(i);
                msg.Header.SetField(new PossDupFlag(true));
                msg.Header.SetField(new OrigSendingTime(DateTime.MinValue)); // (value doesn't matter for test)
                _session.Next(msg.ConstructString());
            } else {
                SendNOSMessage(i);
            }
        }
        //_responder.DumpMsgLookup();
        Assert.That(_responder.GetCount(MsgType.RESEND_REQUEST), Is.EqualTo(1)); // just the original
    }

    [Test]
    public void TestResendRequestGapFillBeforeFinish() {
        // Same as in SessionTest.cs, but this class has a different Setup
        // Setup: Establish connection.  Server sends Seq too high, causing client to ResendRequest.
        Logon();
        SendNOSMessage();
        Assert.That(_session!.NextTargetMsgSeqNum, Is.EqualTo(3));
        SendNOSMessage(8);
        Assert.That(_responder.GetCount(MsgType.RESEND_REQUEST), Is.EqualTo(1));
        // results in resend Begin=3 End=7
        Assert.That(_session.IsResendRequested);
        Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(3));

        // Server sends gapfill to cover 3-6, then resends 7 to complete the ResendRequest.
        // Then client processes 8 from its backlog queue.
        var seqReset = new QuickFix.FIX42.SequenceReset(new NewSeqNo(7));
        seqReset.GapFillFlag = new GapFillFlag(true);
        SendTheMessage(seqReset);
        Assert.That(_session.IsResendRequested);
        Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(7));

        var nos = CreateNOSMessage(7);
        nos.Header.SetField(new PossDupFlag(true));
        nos.Header.SetField(new OrigSendingTime(DateTime.MinValue));
        _session.Next(nos.ConstructString());
        // That was 7.  After that, engine processes 8 from the queue.
        Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(9));
        Assert.That(_session.IsResendRequested, Is.False);
    }

    [Test]
    public void TestResendRequestGapFillToFinish() {
        // Same as in SessionTest.cs, but this class has a different Setup
        // Setup: Establish connection.  Server sends Seq too high, causing client to ResendRequest.
        Logon();
        SendNOSMessage();
        Assert.That(_session!.NextTargetMsgSeqNum, Is.EqualTo(3));
        SendNOSMessage(8);
        Assert.That(_responder.GetCount(MsgType.RESEND_REQUEST), Is.EqualTo(1));
        // results in resend Begin=3 End=7
        Assert.That(_session.IsResendRequested);
        Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(3));

        // Server sends gapfill to cover 3-7, which completes the ResendRequest.
        // Then client processes 8 from its backlog queue.
        var seqReset = new QuickFix.FIX42.SequenceReset(new NewSeqNo(8));
        seqReset.GapFillFlag = new GapFillFlag(true);
        SendTheMessage(seqReset);
        // After the seqReset, engine processes 8 from the queue
        Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(9));
        Assert.That(_session.IsResendRequested, Is.False);
    }

    [Test]
    public void TestResendRequestGapFillBeyondMax() {
        // If GapFill overshoots the end, ignore excess and send a new ResendRequest anyway.
        // This is stupid, but it's what CME wants.

        _session!.MaxMessagesInResendRequest = 100;

        // Setup: Establish connection.  Server sends Seq too high, causing client to ResendRequest.
        Logon();
        SendNOSMessage();
        Assert.That(_session!.NextTargetMsgSeqNum, Is.EqualTo(3));
        SendNOSMessage(108);
        Assert.That(_responder.GetCount(MsgType.RESEND_REQUEST), Is.EqualTo(1));

        var resendRequest = (QuickFix.FIX42.ResendRequest) _responder.MsgLookup[MsgType.RESEND_REQUEST].Dequeue();
        Assert.That(resendRequest, Is.Not.Null);
        Assert.That(resendRequest.BeginSeqNo.Value, Is.EqualTo(3));
        Assert.That(resendRequest.EndSeqNo.Value, Is.EqualTo(102));

        Assert.That(_session.IsResendRequested);
        Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(3));

        // Server sends gapfill to cover 3-107, which is beyond what was requested.
        var seqReset = new QuickFix.FIX42.SequenceReset(new NewSeqNo(107));
        seqReset.GapFillFlag = new GapFillFlag(true);
        SendTheMessage(seqReset, 3); // seqno same as the ResendRequest's BeginSeqNo

        // The client treats the NewSeqNo field as 102, which was the EndSeqNo requested.
        Assert.That(_session.NextTargetMsgSeqNum, Is.EqualTo(103));


        resendRequest = (QuickFix.FIX42.ResendRequest) _responder.MsgLookup[MsgType.RESEND_REQUEST].Dequeue();
        Assert.That(resendRequest, Is.Not.Null);
        Assert.That(resendRequest.BeginSeqNo.Value, Is.EqualTo(103));
        Assert.That(resendRequest.EndSeqNo.Value, Is.EqualTo(107));

        // ResendRequest is still unfinished
        Assert.That(_session.IsResendRequested, Is.True);
    }
}
