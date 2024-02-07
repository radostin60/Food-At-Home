using Microsoft.AspNetCore.Mvc;

namespace Food_At_Home.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
