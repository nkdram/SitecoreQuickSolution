using AppName.Service.SitecoreContextService;
using AppName.Web.MVC.Models;
using System.Web.Mvc;

namespace AppName.Web.MVC.Controllers
{
    public class TestController : Controller
    {
        #region Fields

        private ISCContextService _scContextService;

        #endregion

        #region Ctor

        public TestController(ISCContextService scContextService)
        {
            this._scContextService = scContextService;
        }

        #endregion

        #region Methods

        public ActionResult Index()
        {
            Header header = _scContextService.GetCurrentRendringContextItem<Header>();
            return View("~/Views/Test/Header.cshtml", header);
        }

        #endregion
    }
}