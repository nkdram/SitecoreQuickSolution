using Glass.Mapper.Sc;
using AppName.Core.Base;
using AppName.Core.Domain.Base;
using System;

namespace AppName.Data.Abstraction
{
    public class GlassMapperContext<T> : SitecoreContext, IDbContext<T> where T : BaseEntity
    {
        #region Fields

        private ISitecoreContext _context;

        #endregion

        #region Ctor

        public GlassMapperContext(ISitecoreContext context)
        {
            _context = context;
        }

        #endregion

        #region Methods

        public T GetCurrentItem()
        {
            return _context.GetCurrentItem<T>();
        }

        public T GetItem(Guid id)
        {
            return _context.GetItem<T>(id);
        }

        #endregion
    }
}
