using Microsoft.AspNetCore.Mvc;

namespace WebAppOne.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
