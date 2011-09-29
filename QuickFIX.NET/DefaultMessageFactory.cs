using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuickFix.Fields;

namespace QuickFix
{
    public class DefaultMessageFactory : IMessageFactory
    {
        private readonly Dictionary<string, IMessageFactory> _factories = new Dictionary<string, IMessageFactory>();

        public DefaultMessageFactory()
        {
            _factories[FixValues.BeginString.FIX40] = new QuickFix.FIX40.MessageFactory();
            _factories[FixValues.BeginString.FIX41] = new QuickFix.FIX41.MessageFactory();
            _factories[FixValues.BeginString.FIX42] = new QuickFix.FIX42.MessageFactory();
            _factories[FixValues.BeginString.FIX43] = new QuickFix.FIX43.MessageFactory();
            _factories[FixValues.BeginString.FIX44] = new QuickFix.FIX44.MessageFactory();
            _factories[FixValues.BeginString.FIX50] = new QuickFix.FIX50.MessageFactory();
        }

        #region IMessageFactory Members

        public Message Create(string beginString, string msgType)
        {
            // TODO: if FIXT11 and non-admin message, use FIX50

            if (_factories.ContainsKey(beginString) == false)
            {
                Message m = new Message();
                m.Header.SetField(new StringField(QuickFix.Fields.Tags.MsgType, msgType));
                return m;
            }

            IMessageFactory f = _factories[beginString];
            return f.Create(beginString, msgType);
        }

        public Group Create(string beginString, string msgType, int correspondingFieldID)
        {
            if (_factories.ContainsKey(beginString))
            {
                IMessageFactory f = _factories[beginString];
                return f.Create(beginString, msgType, correspondingFieldID);
            }

            throw new UnsupportedVersion(beginString);
        }

        #endregion
    }
}
