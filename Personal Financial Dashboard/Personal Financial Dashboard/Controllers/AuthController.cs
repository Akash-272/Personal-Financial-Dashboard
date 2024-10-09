using Microsoft.AspNetCore.Mvc;

namespace Personal_Financial_Dashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
