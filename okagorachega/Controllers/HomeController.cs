using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace okagorachega.Controllers
{
    public class HomeController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";

        public IActionResult Index()
        {
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            
            return View();
        }

       
    }
}