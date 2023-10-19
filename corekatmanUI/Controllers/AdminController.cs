using Microsoft.AspNetCore.Mvc;

namespace corekatmanUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        }
}
