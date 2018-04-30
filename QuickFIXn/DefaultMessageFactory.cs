﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using QuickFix.Fields;

namespace QuickFix
{
    /// <summary>
    /// The default factory for creating FIX message instances.  (In the v2.0 release, this class should be made sealed.)
    /// </summary>
    public class DefaultMessageFactory : IMessageFactory
    {
        private static int _dllLoadFlag;
        private readonly IReadOnlyDictionary<string, IMessageFactory> _factories;

        /// <summary>
        /// This consctructor will
        /// 1. Dynamically load all QuickFix.*.dll assemblies into the current appdomain
        /// 2. Find all IMessageFactory implementations in these assemblies (must have parameterless constructor)
        /// 3. Use them based on begin strings they support
        /// </summary>
        public DefaultMessageFactory()
        {
            var assemblies = GetAppDomainAssemblies();
            var factories = GetMessageFactories(assemblies);
            _factories = ConvertToDictionary(factories);
        }

        /// <summary>
        /// This constructor will save the IMessageFactory instances based on what they return from GetSupportedBeginStrings()
        /// </summary>
        /// <param name="factories">IMessageFactory instances</param>
        public DefaultMessageFactory(IEnumerable<IMessageFactory> factories)
        {
            _factories = ConvertToDictionary(factories);
        }

        /// <summary>
        /// This constructor will
        /// 1. Locate all IMessageFactory implementations from the provided assemblies (must have parameterless constructor)
        /// 2. Use them based on begin strings they support
        /// </summary>
        /// <param name="assemblies">Assemblies that may contain IMessageFactory implementations</param>
        public DefaultMessageFactory(IEnumerable<Assembly> assemblies)
        {
            var factories = GetMessageFactories(assemblies);
            _factories = ConvertToDictionary(factories);
        }

        #region IMessageFactory Members

        public ICollection<string> GetSupportedBeginStrings()
        {
            return _factories.Keys.ToList();
        }

        public Message Create(string beginString, string msgType)
        {
            // FIXME: This is a hack.  FIXT11 could mean 50 or 50sp1 or 50sp2.
            // We need some way to choose which 50 version it is.
            // Choosing 50 here is not adequate.
            var key = beginString.Equals(FixValues.BeginString.FIXT11) && !Message.IsAdminMsgType(msgType)
                ? FixValues.BeginString.FIX50
                : beginString;

            if (_factories.TryGetValue(key, out var factory))
            {
                return factory.Create(beginString, msgType);
            }
            else
            {
                var message = new Message();
                message.Header.SetField(new StringField(QuickFix.Fields.Tags.MsgType, msgType));
                return message;
            }
        }

        public Group Create(string beginString, string msgType, int groupCounterTag)
        {
            // FIXME: This is a hack.  FIXT11 could mean 50 or 50sp1 or 50sp2.
            // We need some way to choose which 50 version it is.
            // Choosing 50 here is not adequate.
            var key = beginString.Equals(FixValues.BeginString.FIXT11)
                ? FixValues.BeginString.FIX50
                : beginString;

            if (_factories.TryGetValue(key, out var factory))
            {
                return factory.Create(beginString, msgType, groupCounterTag);
            }
            else
            {
                throw new UnsupportedVersion(beginString);
            }
        }

        #endregion

        #region Dynamic assembly load related methods

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

        private static void LoadLocalDlls()
        {
            const int @true = 1;

            // Because we want to attempt load assemblies once only
            var loadFlag = Interlocked.Exchange(ref _dllLoadFlag, @true);
            if (loadFlag == @true)
            {
                return;
            }

            try
            {
                var assemblyLocation = Assembly.GetExecutingAssembly().Location;
                if (String.IsNullOrWhiteSpace(assemblyLocation))
                {
                    return;
                }

                var directory = Path.GetDirectoryName(assemblyLocation);
                if (String.IsNullOrWhiteSpace(directory))
                {
                    return;
                }

                var dlls = Directory.GetFiles(directory, "quickfix.*.dll");
                foreach (var path in dlls)
                {
                    Assembly.LoadFrom(path);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Found quickfix.*.dll dlls but failed to load them, " + ex);
            }
        }

        private static ICollection<IMessageFactory> GetMessageFactories(IEnumerable<Assembly> assemblies)
        {
            var factoryTypes = assemblies
                .SelectMany(assembly => assembly.GetExportedTypes())
                .Where(IsMessageFactory)
                .ToList();
            var factories = new List<IMessageFactory>();
            foreach (var factoryType in factoryTypes)
            {
                var factory = (IMessageFactory)Activator.CreateInstance(factoryType);
                factories.Add(factory);
            }

            return factories;
        }

        private static ICollection<Assembly> GetAppDomainAssemblies()
        {
            LoadLocalDlls();
            var assemblies = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Where(assembly => !assembly.IsDynamic)
                .ToList();
            return assemblies;
        }

        private static bool IsMessageFactory(Type type)
        {
            return type != typeof(DefaultMessageFactory) &&
                   type.IsClass &&
                   !type.IsAbstract &&
                   typeof(IMessageFactory).IsAssignableFrom(type) &&
                   type.GetConstructor(Type.EmptyTypes) != null;
        }

        #endregion
    }
}
