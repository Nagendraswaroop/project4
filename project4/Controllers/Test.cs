using Microsoft.AspNetCore.Mvc;

namespace project4.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
