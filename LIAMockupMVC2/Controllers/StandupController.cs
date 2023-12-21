using Microsoft.AspNetCore.Mvc;

namespace LIAMockupMVC2.Controllers
{
    public class StandupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
