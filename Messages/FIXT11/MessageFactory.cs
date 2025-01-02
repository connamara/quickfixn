// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix.FIXT11;

public class MessageFactory : IMessageFactory
{
    public ICollection<string> GetSupportedBeginStrings()
    {
       return new [] { BeginString.FIXT11 };
    }

    public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
    {
        return Create(beginString, msgType);
    }

    public QuickFix.Message Create(string beginString, string msgType)
    {
        return msgType switch
        {
            QuickFix.FIXT11.Heartbeat.MsgType => new QuickFix.FIXT11.Heartbeat(),
            QuickFix.FIXT11.TestRequest.MsgType => new QuickFix.FIXT11.TestRequest(),
            QuickFix.FIXT11.ResendRequest.MsgType => new QuickFix.FIXT11.ResendRequest(),
            QuickFix.FIXT11.Reject.MsgType => new QuickFix.FIXT11.Reject(),
            QuickFix.FIXT11.SequenceReset.MsgType => new QuickFix.FIXT11.SequenceReset(),
            QuickFix.FIXT11.Logout.MsgType => new QuickFix.FIXT11.Logout(),
            QuickFix.FIXT11.Logon.MsgType => new QuickFix.FIXT11.Logon(),
            QuickFix.FIXT11.XMLnonFIX.MsgType => new QuickFix.FIXT11.XMLnonFIX(),
            _ => new QuickFix.Message()
        };
    }

    public Group? Create(string beginString, string msgType, int correspondingFieldId)
    {
        if (QuickFix.FIXT11.Logon.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIXT11.Logon.NoMsgTypesGroup();
            }
        }

        return null;
    }
}
