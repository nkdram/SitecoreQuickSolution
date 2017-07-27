using AppName.Core.Base;
using AppName.Core.Domain.Base;

namespace AppName.Service.SitecoreContextService
{
    public interface ISCContextService
    {
        T GetCurrentPageContextItem<T>() where T : BaseEntity;

        T GetCurrentRendringContextItem<T>() where T : BaseEntity;
    }
}
