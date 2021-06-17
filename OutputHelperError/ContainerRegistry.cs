using Autofac;
using SpecFlow.Autofac;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace OutputHelperError
{
    public class ContainerRegistry
    {
        //SpecFlow.Autofac: SpecFlow plugin for using Autofac as a dependency injection framework.
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            var builder = new ContainerBuilder();

            builder.RegisterTypes(CollectTypes())
                   .PropertiesAutowired();

            return builder;
        }

        private static Type[] CollectTypes() =>
            AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => Attribute.IsDefined(t, typeof(BindingAttribute)))
                .ToArray();
    }
}
