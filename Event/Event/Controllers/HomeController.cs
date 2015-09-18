using Event.DAL;
using System.Web.Mvc;

namespace Event.Controllers
{

    public class HomeController : Controller
    {

        public EventContext db { get; private set; }

        public HomeController()
        {
            db = new EventContext();
        }

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Events");
            }
            else
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}