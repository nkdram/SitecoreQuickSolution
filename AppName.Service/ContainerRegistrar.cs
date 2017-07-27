using System;
using AppName.Core.Infrastructure;
using Autofac;
using AppName.Service.SitecoreContextService;

namespace AppName.Service
{
    public class ContainerRegistrar : IContainerRegistrar
    {
        public int Order
        {
            get
            {
                return 1;
            }
        }

        public void Register(ContainerBuilder builder)
        {
            builder.RegisterType<SCContextService>().As<ISCContextService>();
        }
    }
}
