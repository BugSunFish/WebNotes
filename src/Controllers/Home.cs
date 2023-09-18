using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}