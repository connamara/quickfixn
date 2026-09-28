using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace QuickFix;

internal static class MessageFactoryHelper
{
    /// <summary>
    /// Loads all QuickFix.*.dll assemblies from the executing assembly's directory and caches them for future use.
    /// </summary>
    private static readonly Lazy<Assembly[]> _loadedDlls = new(LoadLocalDllsImpl);

    /// <summary>
    /// Loads all QuickFix.*.dll assemblies from the executing assembly's directory and caches them for future use.
    /// </summary>
    /// <returns></returns>
    internal static Assembly[] LoadLocalDlls() => _loadedDlls.Value;

    /// <summary>
    /// Gets all currently loaded QuickFix.*.dll assemblies from the AppDomain.
    /// </summary>
    /// <returns></returns>
    internal static ICollection<Assembly> GetAppDomainAssemblies()
    {
        var assemblies = AppDomain
            .CurrentDomain
            .GetAssemblies()
            .Where(assembly => !assembly.IsDynamic &&
                               assembly.GetName().Name!.StartsWith("QuickFix", StringComparison.Ordinal))
            .ToList();
        return assemblies;
    }

    /// <summary>
    /// Gets all IMessageFactory implementations from the provided assemblies.
    /// Each type must implement IMessageFactory and have a parameterless constructor.
    /// </summary>
    /// <param name="assemblies"></param>
    /// <returns></returns>
    internal static ICollection<Type> GetMessageFactoriesTypes(IEnumerable<Assembly> assemblies)
    {
        var factoryTypes = assemblies
            .SelectMany(assembly => assembly.GetExportedTypes())
            .Where(IsMessageFactory)
            .DistinctBy(type => type.FullName)
            .ToList();
        return factoryTypes;
    }

    /// <summary>
    /// Instantiates IMessageFactory implementations from the provided types.
    /// Each type must implement IMessageFactory and have a parameterless constructor.
    /// </summary>
    /// <param name="factoryTypes"></param>
    /// <returns></returns>
    internal static ICollection<IMessageFactory> InstantiateMessageFactories(ICollection<Type> factoryTypes)
    {
        var factories = new List<IMessageFactory>();
        foreach (var factoryType in factoryTypes)
        {
            var factory = (IMessageFactory)Activator.CreateInstance(factoryType)!;
            factories.Add(factory);
        }

        return factories;
    }

    /// <summary>
    /// Determines if the provided type is a valid IMessageFactory implementation.
    /// A valid IMessageFactory must be a non-abstract class that
    /// implements IMessageFactory and has a parameterless constructor.
    /// The DefaultMessageFactory is excluded from this check.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    internal static bool IsMessageFactory(Type type)
    {
        return type != typeof(DefaultMessageFactory) &&
               type.IsClass &&
               !type.IsAbstract &&
               typeof(IMessageFactory).IsAssignableFrom(type) &&
               type.GetConstructor(Type.EmptyTypes) != null;
    }

    /// <summary>
    /// Loads all QuickFix.*.dll assemblies from the executing assembly's directory.
    /// </summary>
    /// <returns></returns>
    private static Assembly[] LoadLocalDllsImpl()
    {
        try
        {
            var assemblyLocation = Assembly.GetExecutingAssembly().Location;
            if (string.IsNullOrWhiteSpace(assemblyLocation))
                return [];

            var directory = Path.GetDirectoryName(assemblyLocation);
            if (string.IsNullOrWhiteSpace(directory))
                return [];

            var dlls = Directory.GetFiles(directory, "QuickFix.*.dll");

            return dlls.Select(Assembly.LoadFrom).ToArray();
        }
        catch (Exception ex)
        {
            // TODO: can we log this properly instead of Console write?
            Console.Error.WriteLine("Found quickfix.*.dll dlls but failed to load them, " + ex);
            return [];
        }
    }
}
