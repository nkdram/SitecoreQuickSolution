using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Autofac.Integration.Mvc;


namespace AppName.Core.Infrastructure
{
    public class PenEngine : IAppEngine
    {
        #region Fields

        private IOCContainerManager _containerManager;

        #endregion

        #region Utilities

        protected void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //dependencies
            builder.RegisterInstance(this).As<IAppEngine>().SingleInstance();

            //Register all controllers 
            builder.RegisterControllers(AppDomain.CurrentDomain.GetAssemblies()
                .Where(s => s.FullName.Contains("AppName.Web")).ToArray());

            //register dependencies provided by other assemblies
            var type = typeof(IContainerRegistrar);

            var drTypes = AppDomain.CurrentDomain.GetAssemblies()
                .Where(s => s.FullName.Contains("AppName."))
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);

            var drInstances = new List<IContainerRegistrar>();

            foreach (var drType in drTypes)
                drInstances.Add((IContainerRegistrar)Activator.CreateInstance(drType));

            //sort
            drInstances = drInstances.AsQueryable().OrderBy(t => t.Order).ToList();

            foreach (var dependencyRegistrar in drInstances)
                dependencyRegistrar.Register(builder);

            var container = builder.Build();

            _containerManager = new IOCContainerManager(container);
        }

        #endregion

        #region Methods

        public void Initialize()
        {
            //register dependencies
            RegisterDependencies();
        }

        public object Resolve(Type type)
        {
            return IOCContainerManager.Resolve(type);
        }

        #endregion

        #region Properties

        public IOCContainerManager IOCContainerManager
        {
            get { return _containerManager; }
        }

        #endregion
    }
}
