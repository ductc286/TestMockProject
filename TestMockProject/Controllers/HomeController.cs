using System.Web.Mvc;
using TestMockProject.Core.Repositories;

namespace TestMockProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            StaffRepository staffRepository = new StaffRepository();
            var list = staffRepository.GetAll();
            if (list != null)
            {
                ViewBag.A = "k null";
            }
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