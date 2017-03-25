using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    internal class MessageBuilder
    {
        private string _msgStr;
        private bool _validateLengthAndChecksum;
        private DataDictionary.DataDictionary _sessionDD;
        private DataDictionary.DataDictionary _appDD;
        private IMessageFactory _msgFactory;

        private QuickFix.Fields.MsgType _msgType;
        private string _beginString;

        private Message _message;
        private Encoding _encoding;

        public string OriginalString { get { return _msgStr; } }
        public QuickFix.Fields.MsgType MsgType { get { return _msgType; } }
        public string BeginString { get { return _beginString; } }

        internal MessageBuilder(
            string msgStr,
            bool validateLengthAndChecksum,
            DataDictionary.DataDictionary sessionDD,
            DataDictionary.DataDictionary appDD,
            IMessageFactory msgFactory,
            Encoding encoding)
        {
            _msgStr = msgStr;
            _validateLengthAndChecksum = validateLengthAndChecksum;
            _sessionDD = sessionDD;
            _appDD = appDD;
            _msgFactory = msgFactory;
            _encoding = encoding;

            _msgType = Message.IdentifyType(_msgStr);
            _beginString = Message.ExtractBeginString(_msgStr);
        }

        internal Message Build()
        {
            Message message = _msgFactory.Create(_beginString, _msgType.Obj);
            message.Encoding = _encoding;
            message.FromString(
                _msgStr,
                _validateLengthAndChecksum,
                _sessionDD,
                _appDD,
                _msgFactory);
            _message = message;
            return _message;
        }

        internal Message RejectableMessage()
        {
            if (_message != null)
                return _message;

            Message message = _msgFactory.Create(_beginString, _msgType.Obj);
            message.Encoding = _encoding;
            message.FromString(
                _msgStr,
                false,
                _sessionDD,
                _appDD,
                _msgFactory,
                true);
            return message;
        }
    }
}
