using Microsoft.AspNetCore.Mvc;

namespace pontodigital1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
    }
}