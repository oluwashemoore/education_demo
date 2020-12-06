
using Microsoft.AspNetCore.Mvc;

namespace web_demo.Controllers
{
    public class SetupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}