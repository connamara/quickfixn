using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuickFix.Fields;

namespace QuickFix
{
    /// <summary>
    /// The default factory for creating FIX message instances.  (In the v2.0 release, this class should be made sealed.)
    /// </summary>
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
            _factories[FixValues.BeginString.FIX50SP1] = new QuickFix.FIX50SP2.MessageFactory();
            _factories[FixValues.BeginString.FIX50SP2] = new QuickFix.FIX50SP2.MessageFactory();
        }

        #region IMessageFactory Members

        public Message Create(string beginString, string msgType)
        {
            IMessageFactory f = null;

            // FIXME: This is a hack.  FIXT11 could mean 50 or 50sp1 or 50sp2.
            // We need some way to choose which 50 version it is.
            // Choosing 50 here is not adequate.
            if (beginString.Equals(FixValues.BeginString.FIXT11))
            {
                if (!Message.IsAdminMsgType(msgType))
                    f = _factories[FixValues.BeginString.FIX50];
            }
            if(f != null) // really, this should just be in the previous if-block
                return f.Create(beginString, msgType);



            if (_factories.ContainsKey(beginString) == false)
            {
                Message m = new Message();
                m.Header.SetField(new StringField(QuickFix.Fields.Tags.MsgType, msgType));
                return m;
            }

            f = _factories[beginString];
            return f.Create(beginString, msgType);
        }

        public Group Create(string beginString, string msgType, int groupCounterTag)
        {
            // FIXME: This is a hack.  FIXT11 could mean 50 or 50sp1 or 50sp2.
            // We need some way to choose which 50 version it is.
            // Choosing 50 here is not adequate.
            if(beginString.Equals(FixValues.BeginString.FIXT11))
                return _factories[FixValues.BeginString.FIX50].Create(beginString,msgType,groupCounterTag);

            if (_factories.ContainsKey(beginString))
                return _factories[beginString].Create(beginString, msgType, groupCounterTag);

            throw new UnsupportedVersion(beginString);
        }

        #endregion
    }
}
