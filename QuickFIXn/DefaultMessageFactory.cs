using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using QuickFix.Fields;

namespace QuickFix
{

    /// <summary>
    /// The default factory for creating FIX message instances.  (In the v2.0 release, this class should be made sealed.)
    /// 
    /// This class is now used as a MessageFactory factory and should not be used directly or at all.
    /// It is used directly only for the unit tests.
    /// </summary>

    public class DefaultMessageFactory : IMessageFactory
    {
        private static readonly IMessageFactory[] _availableMessageFactories;
        private readonly Dictionary<string, IMessageFactory> _factories = new Dictionary<string, IMessageFactory>();

        public DataDictionary.DataDictionary DataDictionary
        {
            get { throw new NotImplementedException(); }
        }

        public FIXVersion[] SupportedFIXVersions { get; protected set; }

        static DefaultMessageFactory()
        {
            // Load the quickfix versions dlls from the local directory.
            string[] quickFixDlls = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "quickfix.*.dll");

            foreach (string quickFixDll in quickFixDlls)
            {
                Assembly.LoadFile(quickFixDll);
            }

            // Create all available message factories so we can use them later for creating specific message factory
            var factoryInterface = typeof(IMessageFactory);
            Regex namingConvention = new Regex("QuickFix.(?<version>[^\\.]+).MessageFactory");
            //  Create instacne of all concrete types implementing the IMessageFactory interface
            //  which are defined in a quickfix assembly
            //  and which have a public default constructor
            //  and which are named like QuickFix.FIXVERSION.MessageFactory
            _availableMessageFactories = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                    where assembly.FullName.StartsWith("QuickFix", StringComparison.InvariantCultureIgnoreCase)
                                    from type in assembly.GetExportedTypes() // get public classes
                                    where factoryInterface.IsAssignableFrom(type)
                                        && type.IsClass
                                        && !type.IsAbstract
                                    let defaultConstructor = type.GetConstructor(Type.EmptyTypes)
                                    let match = namingConvention.Match(type.FullName)
                                    where defaultConstructor != null
                                        && defaultConstructor.IsPublic
                                        && match.Success
                                        && type != typeof(DefaultMessageFactory)  // Make sure we are not creating DefaultMessageFactory to avoid self recursive creation
                                    select (IMessageFactory)Activator.CreateInstance(type)).
                                   ToArray();

            // We create an instance so we can query for the supported FIX versions of the message factory
            // Enhancement will be to query for attributes to avoid creating the instances.
        }

        public static IMessageFactory CreateMessageFactory(string beginString, string applVerID)
        {
            foreach (var factory in _availableMessageFactories)
            {
                foreach (var supportedFIXVersion in factory.SupportedFIXVersions)
                {
                    if (supportedFIXVersion.BeginString.Equals(beginString) &&
                        string.Compare(supportedFIXVersion.AppVerID, applVerID) == 0)
                    {
                        return (IMessageFactory)Activator.CreateInstance(factory.GetType());
                    }
                }
            }
            throw new UnsupportedVersion(
                "Failed to create message factory, unable to find one with beginString = " + beginString + (applVerID != null ? (" and applVerID = " + applVerID) : null));
        }

        public DefaultMessageFactory()
        {
            foreach (var factory in _availableMessageFactories)
            {
                foreach (var supportedFIXVersion in factory.SupportedFIXVersions)
                {
                    if (_factories.ContainsKey(supportedFIXVersion.BeginString))
                    {
                        throw new AmbiguousMatchException("Failed to create DefaultMessageFactory, " + _factories[supportedFIXVersion.BeginString].GetType().FullName + " and " + factory.GetType().FullName + " uses the same begin string");
                    }

                    _factories[supportedFIXVersion.BeginString] = (IMessageFactory)Activator.CreateInstance(factory.GetType());
                }
            }

            SupportedFIXVersions = _factories.SelectMany(f => f.Value.SupportedFIXVersions).ToArray();
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
            //if(beginString.Equals(FixValues.BeginString.FIXT11))
            //    return _factories[FixValues.BeginString.FIX50].Create(beginString,msgType,groupCounterTag);

            if (_factories.ContainsKey(beginString))
                return _factories[beginString].Create(beginString, msgType, groupCounterTag);

            throw new UnsupportedVersion(beginString);
        }

        #endregion
    }
}
