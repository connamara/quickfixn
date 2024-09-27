using System;
using System.Collections.Generic;

namespace UnitTests.SessionTestSupport;

internal class MockResponder : QuickFix.IResponder
{
    private readonly QuickFix.DefaultMessageFactory _messageFactory = new();
    private readonly QuickFix.IMessageFactory _defaultMsgFactory = new QuickFix.DefaultMessageFactory();

    public Dictionary<string, Queue<QuickFix.Message>> MsgLookup = new();
    public Queue<QuickFix.Message> Dups = new();

    public bool Disconnected = false;

    public bool Send(string msgStr)
    {
        QuickFix.Fields.MsgType msgType = QuickFix.Message.IdentifyType(msgStr);
        string beginString = QuickFix.Message.ExtractBeginString(msgStr);

        QuickFix.Message message = _messageFactory.Create(beginString, msgType.Value);
        QuickFix.DataDictionary.DataDictionary dd = new QuickFix.DataDictionary.DataDictionary();
        message.FromString(msgStr, false, dd, dd, _defaultMsgFactory);

        if (!MsgLookup.ContainsKey(msgType.Value))
            MsgLookup.Add(msgType.Value, new Queue<QuickFix.Message>());

        MsgLookup[msgType.Value].Enqueue(message);

        QuickFix.Fields.PossDupFlag possDup = new QuickFix.Fields.PossDupFlag(false);
        if (message.Header.IsSetField(possDup))
            message.Header.GetField(possDup);

        if (possDup.Value && msgType.Value != QuickFix.Fields.MsgType.SEQUENCE_RESET)
        {
            Dups.Enqueue(message);
        }

        return true;
    }

    public void Disconnect()
    {
        Disconnected = true;
    }

    /// <summary>
    /// For debug use if needed
    /// </summary>
    public void DumpMsgLookup()
    {
        Console.WriteLine("Responder dump:");
        foreach (string key in MsgLookup.Keys) {
            Console.WriteLine($"  {key}: count {MsgLookup[key].Count}");
            foreach (QuickFix.Message m in MsgLookup[key]) {
                Console.WriteLine("  - " + m.ConstructString());
            }
        }
    }

    public int GetCount(string msgType)
    {
        return MsgLookup.TryGetValue(msgType, out var value) ? value.Count : 0;
    }
}
