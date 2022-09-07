// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix
{
    namespace FIXT11
    {
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
                switch (msgType)
                {
                    case QuickFix.FIXT11.Heartbeat.MsgType: return new QuickFix.FIXT11.Heartbeat();
                    case QuickFix.FIXT11.TestRequest.MsgType: return new QuickFix.FIXT11.TestRequest();
                    case QuickFix.FIXT11.ResendRequest.MsgType: return new QuickFix.FIXT11.ResendRequest();
                    case QuickFix.FIXT11.Reject.MsgType: return new QuickFix.FIXT11.Reject();
                    case QuickFix.FIXT11.SequenceReset.MsgType: return new QuickFix.FIXT11.SequenceReset();
                    case QuickFix.FIXT11.Logout.MsgType: return new QuickFix.FIXT11.Logout();
                    case QuickFix.FIXT11.Logon.MsgType: return new QuickFix.FIXT11.Logon();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIXT11.Logon.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIXT11.Logon.NoMsgTypesGroup();
                    }
                }

                return null;
            }

        }
    }
}
