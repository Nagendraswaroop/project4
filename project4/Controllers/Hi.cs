using Microsoft.AspNetCore.Mvc;

namespace project4.Controllers
{
    public class Hi : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
