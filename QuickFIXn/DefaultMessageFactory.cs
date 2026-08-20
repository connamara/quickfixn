using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using QuickFix.Fields;

namespace QuickFix;

/// <summary>
/// The default factory for creating FIX message instances.  (In the v2.0 release, this class should be made sealed.)
/// </summary>
public class DefaultMessageFactory : IMessageFactory
{
    /// <summary>
    /// key is BeginString (including the fake FIX50 beginstrings)
    /// </summary>
    private readonly IReadOnlyDictionary<string, IMessageFactory> _factories;

    private readonly QuickFix.Fields.ApplVerID _defaultApplVerId;

    /// <summary>
    /// This constructor will
    /// 1. Dynamically load all QuickFix.*.dll assemblies into the current appdomain
    /// 2. Find all IMessageFactory implementations in these assemblies (must have parameterless constructor)
    /// 3. Use them based on begin strings they support
    /// </summary>
    /// <param name="defaultApplVerId">ApplVerID value used by default in Create methods that don't explicitly specify it (only relevant for FIX5+)</param>
    public DefaultMessageFactory(string defaultApplVerId = QuickFix.FixValues.ApplVerID.FIX50SP2)
    {
        _defaultApplVerId = new ApplVerID(defaultApplVerId);
        var assemblies = GetAppDomainAssemblies();
        var factories = GetMessageFactories(assemblies);
        _factories = ConvertToDictionary(factories);
    }

    /// <summary>
    /// This constructor will
    /// 1. Locate all IMessageFactory implementations from the provided assemblies (must have parameterless constructor)
    /// 2. Use them based on begin strings they support
    /// </summary>
    /// <param name="assemblies">Assemblies that may contain IMessageFactory implementations</param>
    /// <param name="defaultApplVerId">ApplVerID value used by default in Create methods that don't explicitly specify it (only relevant for FIX5+)</param>
    public DefaultMessageFactory(IEnumerable<Assembly> assemblies, string defaultApplVerId = QuickFix.FixValues.ApplVerID.FIX50SP2)
    {
        _defaultApplVerId = new ApplVerID(defaultApplVerId);
        var factories = GetMessageFactories(assemblies);
        _factories = ConvertToDictionary(factories);
    }

    /// <summary>
    /// This constructor will
    /// 1. Use the provided IMessageFactory implementations
    /// 2. Use them based on begin strings they support
    /// </summary>
    /// <param name="factories">IMessageFactory implementations</param>
    /// <param name="defaultApplVerId">ApplVerID value used by default in Create methods that don't explicitly specify it (only relevant for FIX5+)</param>
    public DefaultMessageFactory(IEnumerable<IMessageFactory> factories, string defaultApplVerId = QuickFix.FixValues.ApplVerID.FIX50SP2)
    {
        _defaultApplVerId = new ApplVerID(defaultApplVerId);
        _factories = ConvertToDictionary(factories);
    }

    #region IMessageFactory Members

    public ICollection<string> GetSupportedBeginStrings()
    {
        return _factories.Keys.ToList();
    }

    public Message Create(string beginString, string msgType)
    {
        return Create(beginString, _defaultApplVerId, msgType);
    }

    public Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
    {
        _factories.TryGetValue(beginString, out IMessageFactory? messageFactory);

        if (beginString == QuickFix.Values.BeginString_FIXT11 && !Message.IsAdminMsgType(msgType))
        {
            _factories.TryGetValue(
                QuickFix.FixValues.ApplVerID.ToBeginString(applVerId.Value),
                out messageFactory);
        }

        if (messageFactory != null)
            return messageFactory.Create(beginString, applVerId, msgType);

        // didn't find a factory, so return a generic Message object
        var message = new Message();
        message.Header.SetField(new StringField(QuickFix.Fields.Tags.MsgType, msgType));
        return message;
    }

    public Group? Create(string beginString, string msgType, int groupCounterTag)
    {
        string key = beginString;
        if(beginString.Equals(FixValues.BeginString.FIXT11))
            key = QuickFix.FixValues.ApplVerID.ToBeginString(_defaultApplVerId.Value);

        if (_factories.TryGetValue(key, out IMessageFactory? factory))
            return factory.Create(beginString, msgType, groupCounterTag);

        throw new MessageFactoryNotFound(beginString);
    }

    #endregion

    #region Dynamic assembly load related methods

    /// <summary>
    /// Creates a dictionary keyed by each IMessageFactory's supported BeginStrings
    /// </summary>
    /// <param name="factories"></param>
    /// <returns></returns>
    private static Dictionary<string, IMessageFactory> ConvertToDictionary(IEnumerable<IMessageFactory> factories)
    {
        var dict = new Dictionary<string, IMessageFactory>();
        foreach (var factory in factories)
        {
            foreach (var beginString in factory.GetSupportedBeginStrings())
            {
                dict[beginString] = factory;
            }
        }

        return dict;
    }

    private static ICollection<IMessageFactory> GetMessageFactories(IEnumerable<Assembly> assemblies)
    {
        var factoryTypes = MessageFactoryHelper.GetMessageFactoriesTypes(assemblies);
        return MessageFactoryHelper.InstantiateMessageFactories(factoryTypes);
    }

    private static ICollection<Assembly> GetAppDomainAssemblies()
    {
        MessageFactoryHelper.LoadLocalDlls();
        return MessageFactoryHelper.GetAppDomainAssemblies();
    }

    #endregion
}
