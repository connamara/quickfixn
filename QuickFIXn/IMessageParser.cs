using QuickFix.Fields;

namespace QuickFix
{
    public interface IMessageParser
    {
        BeginString ParseBeginString(string fixMessage);
        MsgType ParseMsgType(string fixMessage);
        Header ParseHeader(string fixMessage);
        Message ParseMessage(string fixMessage, bool validate = true);
    }
}
