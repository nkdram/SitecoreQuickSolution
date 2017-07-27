using AppName.Core.Domain.Base;

namespace AppName.Core.Base
{
    public interface IRendringContext
    {
        T GetCurrentItem<T>() where T : BaseEntity;
    }
}
