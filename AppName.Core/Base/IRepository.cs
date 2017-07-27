using AppName.Core.Domain.Base;
using System;

namespace AppName.Core.Base
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetContextItem();

        T GetItem(Guid id);
    }
}
