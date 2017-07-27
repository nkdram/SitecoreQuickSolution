using System;

namespace AppName.Core.Infrastructure
{
    public interface IAppEngine
    {
        IOCContainerManager IOCContainerManager { get; }

        void Initialize();

        object Resolve(Type type);
    }
}
