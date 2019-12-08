using System.Web.Mvc;

namespace RSTVideoInc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is my application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This be me contact page.";

            return View();
        }
    }
}