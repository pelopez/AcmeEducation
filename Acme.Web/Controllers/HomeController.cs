using Acme.Web.Models;
using System.Web.Mvc;

namespace Acme.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new SuperComplexModel
            {
                FirstName = "Foo", 
                LastName = "Bar"
            };

            return View(model);
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