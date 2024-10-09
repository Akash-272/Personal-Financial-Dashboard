using Microsoft.AspNetCore.Mvc;

namespace Personal_Financial_Dashboard.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
