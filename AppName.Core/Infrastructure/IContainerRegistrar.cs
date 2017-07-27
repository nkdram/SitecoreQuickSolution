using Autofac;

namespace AppName.Core.Infrastructure
{
    public interface IContainerRegistrar
    {
        void Register(ContainerBuilder builder);

        int Order { get; }
    }
}
