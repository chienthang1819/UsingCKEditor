using System.Web.Mvc;
using Ganss.XSS;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(new TestModel());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HandlePost(TestModel model)
        {
            var safeMessage = new HtmlSanitizer().Sanitize(model.Message);

            return new ContentResult()
            {
                Content = safeMessage
            };
        }
    }
}
