namespace QuickFix
{
    internal class MessageBuilder
    {
        private readonly string _msgStr;
        private readonly bool _validateLengthAndChecksum;
        private readonly DataDictionary.DataDictionary _sessionDict;
        private readonly DataDictionary.DataDictionary _appDict;
        private readonly IMessageFactory _msgFactory;

        private Message? _message;
        private readonly Fields.ApplVerID _defaultApplVerId;

        public string OriginalString => _msgStr;
        public Fields.MsgType MsgType { get; }

        /// <summary>
        /// The BeginString from the raw FIX message
        /// </summary>
        public string BeginString { get; }

        internal MessageBuilder(
            string msgStr,
            string defaultApplVerId,
            bool validateLengthAndChecksum,
            DataDictionary.DataDictionary sessionDict,
            DataDictionary.DataDictionary appDict,
            IMessageFactory msgFactory)
        {
            _msgStr = msgStr;
            _defaultApplVerId = new Fields.ApplVerID(defaultApplVerId);
            _validateLengthAndChecksum = validateLengthAndChecksum;
            _sessionDict = sessionDict;
            _appDict = appDict;
            _msgFactory = msgFactory;
            MsgType = Message.IdentifyType(_msgStr);
            BeginString = Message.ExtractBeginString(_msgStr);
        }

        internal Message Build()
        {
            Message message = _msgFactory.Create(BeginString, _defaultApplVerId, MsgType.Value);
            message.FromString(
                _msgStr,
                _validateLengthAndChecksum,
                _sessionDict,
                _appDict,
                _msgFactory,
                ignoreBody: false);
            _message = message;
            return _message;
        }

        internal Message RejectableMessage()
        {
            if (_message is not null)
                return _message;

            Message message = _msgFactory.Create(BeginString, MsgType.Value);
            message.FromString(
                _msgStr,
                false,
                _sessionDict,
                _appDict,
                _msgFactory,
                true);
            return message;
        }
    }
}
