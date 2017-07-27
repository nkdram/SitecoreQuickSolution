using Autofac;
using Autofac.Core.Lifetime;
using Autofac.Integration.Mvc;
using System;
using System.Web;
using System.Web.Mvc;

namespace AppName.Core.Infrastructure
{
    public class IOCContainerManager
    {
        #region Fields

        private readonly IContainer _container;

        #endregion

        #region Ctor

        public IOCContainerManager(IContainer container)
        {
            _container = container;
        }

        #endregion

        #region Properties

        public IContainer Container
        {
            get
            {
                return _container;
            }
        }

        #endregion

        #region Methods

        public object Resolve(Type type, ILifetimeScope scope = null)
        {
            //if (scope == null)
            //{
            //    scope = Scope();
            //}

            //return scope.Resolve(type);

            return DependencyResolver.Current.GetService(type);
        }

        public ILifetimeScope Scope()
        {
            if (HttpContext.Current != null)
                return AutofacDependencyResolver.Current.RequestLifetimeScope;

            return Container.BeginLifetimeScope(MatchingScopeLifetimeTags.RequestLifetimeScopeTag);
        }

        #endregion
    }
}
