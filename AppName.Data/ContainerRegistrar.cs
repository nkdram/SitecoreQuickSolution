using Autofac;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.IoC;
using AppName.Core.Base;
using AppName.Core.Infrastructure;
using AppName.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Data
{
    public class ContainerRegistrar : IContainerRegistrar
    {
        public int Order
        {
            get
            {
                return 2;
            }
        }

        public void Register(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(SCRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(GlassMapperContext<>)).As(typeof(IDbContext<>)).InstancePerRequest();

            builder.Register(s => SitecoreContextFactory.Default.GetSitecoreContext(GlassContextProvider.Default.GetContext())).As<ISitecoreContext>().InstancePerRequest();

            builder.RegisterType<SCPageContext>().As<IPageContext>().InstancePerLifetimeScope();

            builder.RegisterType<SCRendringContext>().As<IRendringContext>().InstancePerLifetimeScope();
        }
    }
}
