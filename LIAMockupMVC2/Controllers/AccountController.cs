using Microsoft.AspNetCore.Mvc;

namespace LIAMockupMVC2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AdminUserSettings()
        {
            return View();
        }
    }
}
