using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace QuickFix;

public class MessageFactoryBuilder
{
    private bool _loadLocalDlls = false;
    private bool _addLoadedDlls = false;

    private readonly List<Assembly> _assemblies = new();
    private readonly List<Type> _factoriesTypes = new();
    private string _defaultApplVerId = QuickFix.FixValues.ApplVerID.FIX50SP2;

    /// <summary>
    /// Set to load local QuickFix.*.dll assemblies from the executing assembly's directory and add them to the builder.
    /// </summary>
    /// <returns></returns>
    public MessageFactoryBuilder LoadLocalDlls()
    {
        _loadLocalDlls = true;
        return this;
    }

    /// <summary>
    /// Sets to add all currently loaded QuickFix.*.dll assemblies from the AppDomain to the builder.
    /// Default is false.
    /// </summary>
    public MessageFactoryBuilder AddLoadedDlls()
    {
        _addLoadedDlls = true;
        return this;
    }

    /// <summary>
    /// Adds a collection of IMessageFactory types to the builder. Each type must implement IMessageFactory and have a parameterless constructor.
    /// </summary>
    /// <param name="factoryTypes"></param>
    /// <returns></returns>
    public MessageFactoryBuilder Add(IEnumerable<Type> factoryTypes)
    {
        ArgumentNullException.ThrowIfNull(factoryTypes);

        foreach (Type factoryType in factoryTypes)
        {
            Add(factoryType);
        }

        return this;
    }

    /// <summary>
    /// Adds a collection of assemblies to the builder. The builder will search for IMessageFactory implementations in these assemblies.
    /// </summary>
    /// <param name="assemblies"></param>
    /// <returns></returns>
    public MessageFactoryBuilder Add(IEnumerable<Assembly> assemblies)
    {
        ArgumentNullException.ThrowIfNull(assemblies);

        foreach (var assembly in assemblies)
        {
            Add(assembly);
        }

        return this;
    }

    /// <summary>
    /// Adds a single IMessageFactory type to the builder. The type must implement IMessageFactory and have a parameterless constructor.
    /// </summary>
    /// <param name="factoryType"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public MessageFactoryBuilder Add(Type factoryType)
    {
        ArgumentNullException.ThrowIfNull(factoryType);

        if (!typeof(IMessageFactory).IsAssignableFrom(factoryType))
            throw new ArgumentException("Type must implement IMessageFactory", nameof(factoryType));

        _factoriesTypes.Add(factoryType);
        return this;
    }

    /// <summary>
    /// Adds a single IMessageFactory type to the builder. The type must implement IMessageFactory and have a parameterless constructor.
    /// </summary>
    /// <typeparam name="TMessageFactory"></typeparam>
    /// <returns></returns>
    public MessageFactoryBuilder Add<TMessageFactory>() where TMessageFactory : IMessageFactory
    {
        _factoriesTypes.Add(typeof(TMessageFactory));
        return this;
    }

    /// <summary>
    /// Adds a single assembly to the builder. The builder will search for IMessageFactory implementations in this assembly.
    /// </summary>
    /// <param name="assembly"></param>
    /// <returns></returns>
    public MessageFactoryBuilder Add(Assembly assembly)
    {
        ArgumentNullException.ThrowIfNull(assembly);
        _assemblies.Add(assembly);
        return this;
    }

    /// <summary>
    /// Sets the default ApplVerID to be used by the built IMessageFactory. This value will be used when creating messages that do not have a specific ApplVerID set.
    /// </summary>
    /// <param name="defaultApplVerId"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public MessageFactoryBuilder SetDefaultApplVerId(string defaultApplVerId)
    {
        if (string.IsNullOrWhiteSpace(defaultApplVerId))
            throw new ArgumentException("ApplVerID cannot be null or whitespace", nameof(defaultApplVerId));
        _defaultApplVerId = defaultApplVerId;
        return this;
    }

    /// <summary>
    /// Builds and returns an IMessageFactory instance based on the configuration provided to the builder.
    /// The built IMessageFactory will include all added IMessageFactory types and assemblies, and will use the specified default ApplVerID.
    /// </summary>
    /// <returns></returns>
    public IMessageFactory Build()
    {
        if (_loadLocalDlls)
        {
            // Load local QuickFix.*.dll assemblies from the executing assembly's directory and add them
            _assemblies.AddRange(MessageFactoryHelper.LoadLocalDlls());
        }

        if (_addLoadedDlls)
        {
            // Add all currently loaded QuickFix.*.dll assemblies from the AppDomain
            // This includes the assemblies loaded previously by LoadLocalDlls, even if not
            // in this iteration
            _assemblies.AddRange(MessageFactoryHelper.GetAppDomainAssemblies());
        }

        // Avoid duplicate assemblies
        var assemblies = _assemblies.DistinctBy(a => a.FullName).ToArray();

        // Get all IMessageFactory types from the specified assemblies
        var factoryTypes = MessageFactoryHelper.GetMessageFactoriesTypes(assemblies);

        // Add the found factory types to the list of factory types
        _factoriesTypes.AddRange(factoryTypes);

        // Avoid duplicate factory types
        var factoriesTypes = _factoriesTypes.DistinctBy(f => f.FullName).ToArray();

        // Instantiate the IMessageFactory instances from the types
        var factories = MessageFactoryHelper.InstantiateMessageFactories(factoriesTypes);

        // Create and return the DefaultMessageFactory with the instantiated factories and the specified default ApplVerID
        return new DefaultMessageFactory(factories, _defaultApplVerId);
    }
}