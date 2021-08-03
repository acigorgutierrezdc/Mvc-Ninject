using System.Web.Mvc;
using Mvc_Ninject.Models;

namespace Mvc_Ninject.Controllers
{
    public class HomeController : Controller
    {
        private ITime _time;

        public HomeController(ITime time)
        {
            this._time = time;
        }
        
        public ActionResult Index()
        {
            string timeInfo = this._time.GetInformacaoTime();
            return View(timeInfo as object);
        }
    }
}