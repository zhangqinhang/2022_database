using Microsoft.AspNetCore.Mvc;

namespace LIB.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
