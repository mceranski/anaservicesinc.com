using System.Web.Mvc;

namespace anaservicesinc.com.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Portfolio() {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}