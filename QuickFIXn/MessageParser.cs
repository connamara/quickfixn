using QuickFix.Fields;

namespace QuickFix
{
    public class MessageParser : IMessageParser
    {
        private readonly DataDictionary.DataDictionary _dataDictionary;
        private readonly IMessageFactory _factory;

        public MessageParser(DataDictionary.DataDictionary dataDictionary, IMessageFactory factory)
        {
            _dataDictionary = dataDictionary;
            _factory = factory;
        }

        public Message ParseMessage(string fixMessage, bool validate = true)
        {
            SessionID sessionId = ParseSessionID(fixMessage);
            MsgType msgType = Message.IdentifyType(fixMessage);

            Message message = _factory.Create(sessionId.BeginString, msgType.getValue());

            message.FromString(fixMessage,
                               validate,
                               _dataDictionary,
                               _dataDictionary,
                               _factory);

            return message;
        }

        public BeginString ParseBeginString(string fixMessage)
        {
            return new BeginString(Message.ExtractBeginString(fixMessage));
        }

        public MsgType ParseMsgType(string fixMessage)
        {
            return Message.IdentifyType(fixMessage);
        }

        public SessionID ParseSessionID(string fixMessage)
        {
            Message msg = new Message();
            return msg.FromStringHeader(fixMessage)
                       ? msg.GetSessionID(msg)
                       : null;
        }

        public Header ParseHeader(string fixMessage)
        {
            Message msg = new Message();
            return msg.FromStringHeader(fixMessage)
                       ? msg.Header
                       : null;
        }
    }
}
