using Glass.Mapper.Sc;
using AppName.Core.Base;
using AppName.Core.Domain.Base;
using AppName.Data.Abstraction;
using System;

namespace AppName.Data
{
    public class SCRepository<T> : IRepository<T> where T : BaseEntity
    {
        #region Fields

        private IDbContext<T> _context;

        #endregion

        #region Ctor

        public SCRepository(IDbContext<T> context)
        {
            _context = context;
        }

        #endregion

        #region Methods

        public T GetContextItem()
        {
            return _context.GetCurrentItem();
        }

        public T GetItem(Guid id)
        {
            return _context.GetItem(id);
        }

        #endregion
    }
}
