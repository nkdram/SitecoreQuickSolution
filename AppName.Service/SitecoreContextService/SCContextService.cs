using AppName.Core.Base;
using AppName.Core.Domain.Base;

namespace AppName.Service.SitecoreContextService
{
    public class SCContextService : ISCContextService
    {
        #region Fields

        private IPageContext _pageContext;
        private IRendringContext _rendringContext;

        #endregion

        #region Ctor

        public SCContextService(IPageContext pageContext,
            IRendringContext rendringContext)
        {
            _pageContext = pageContext;
            _rendringContext = rendringContext;
        }

        #endregion

        #region Methods

        public T GetCurrentPageContextItem<T>() where T : BaseEntity
        {
            return _pageContext.GetCurrentItem<T>();
        }

        public T GetCurrentRendringContextItem<T>() where T : BaseEntity
        {
            return _rendringContext.GetCurrentItem<T>();
        }

        #endregion
    }
}
