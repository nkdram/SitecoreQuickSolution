using AppName.Core.Base;
using AppName.Core.Domain.Base;
using AppName.Core.Infrastructure;
using Sitecore.Mvc.Presentation;

namespace AppName.Data.Abstraction
{
    public class SCPageContext : PageContext, IPageContext
    {
        public T GetCurrentItem<T>() where T : BaseEntity
        {
            IDbContext<T> _repository = PenContext.Current.Resolve(typeof(IDbContext<T>)) as IDbContext<T>;
            return _repository.GetItem(Item.ID.Guid);
        }
    }
}
