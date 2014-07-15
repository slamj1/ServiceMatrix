﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition.Hosting;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Modeling;
using NuPattern;
using NuPattern.Library;
using NuPattern.Library.Automation;
using NuPattern.Runtime;
using NuPattern.Runtime.Bindings;
using NuPattern.Runtime.Composition;
using NuPattern.Runtime.Schema;
using NuPattern.Runtime.Serialization;

namespace CodeGenerationCommandDump
{
    class Program
    {
        static void Main(string[] args)
        {
            // The path of a DSL model file:
            var dslModel =
                args.Length > 0
                    ? args[0]
                    : @"D:\dev\particular\servicematrix\src\ServiceMatrix\PatternModel.patterndefinition";

            var outputFile =
                args.Length > 1
                    ? args[1]
                    : "output.txt";

            // The Model type generated by the DSL:
            IPatternModelSchema patternModel;

            // Set up the Store to read your type of model:

            Type[] domainTypes = { PatternModelReader.DomainModelType, Type.GetType("NuPattern.Library.Automation.LibraryDomainModel, NuPattern.Library") };

            var container = new CompositionContainer(new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory));
            var compositionService =
                (INuPatternCompositionService)Activator.CreateInstance(
                    Type.GetType("NuPattern.Runtime.Bindings.ContainerCompositionServiceAdapter, NuPattern.Runtime.Extensibility", true),
                    container);

            var store = new Store(
                new TrivialServiceProvider(
                    new Dictionary<Type, object>
                    {
                        { typeof(INuPatternCompositionService), compositionService},
                        { typeof(INuPatternProjectTypeProvider), new TrivialNuPatternProjectTypeProvider()}
                    }),
                domainTypes);
            var serializationResult = new SerializationResult();

            // All Store changes must be in a Transaction:
            using (Transaction t = store.TransactionManager.BeginTransaction("Load model"))
            {
                patternModel = PatternModelReader.Read(serializationResult, store, dslModel);
                t.Commit(); // Don't forget this!
            }

            var automationSetupCode = new AutomationSetup(patternModel.Pattern).TransformText();

            File.WriteAllText(outputFile, automationSetupCode);
        }
    }

    public class TrivialServiceProvider : IServiceProvider
    {
        private readonly IDictionary<Type, object> services;

        public TrivialServiceProvider(IDictionary<Type, object> services)
        {
            this.services = services;
        }

        public object GetService(Type serviceType)
        {
            object service;

            return services.TryGetValue(serviceType, out service) ? service : null;
        }
    }

    public class TrivialNuPatternProjectTypeProvider : INuPatternProjectTypeProvider
    {
        private IList<Type> allTypes;

        public IEnumerable<Type> GetTypes<T>()
        {
            return allTypes ?? (allTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).ToList());
        }
    }
}