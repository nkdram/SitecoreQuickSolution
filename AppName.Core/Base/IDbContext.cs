using AppName.Core.Domain.Base;
using System;

namespace AppName.Core.Base
{
    public interface IDbContext<T> where T : BaseEntity
    {
        T GetCurrentItem();

        T GetItem(Guid id);
    }
}
