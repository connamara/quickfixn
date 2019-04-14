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
            Message msg = new Message();
            msg.FromStringHeader(fixMessage);

            string beginString = msg.Header.GetString(Tags.BeginString);
            string msgType = msg.Header.GetString(Tags.MsgType);

            Message message = _factory.Create(beginString, msgType);
            message.FromString(fixMessage,
                               validate,
                               _dataDictionary,
                               _dataDictionary,
                               _factory);

            return message;
        }
    }
}
