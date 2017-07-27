
using AppName.Core.Domain.Base;
namespace AppName.Core.Base
{
    public interface IPageContext
    {
        T GetCurrentItem<T>() where T : BaseEntity;
    }
}
