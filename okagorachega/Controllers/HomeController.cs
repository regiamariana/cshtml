using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using okagorachega.Repositorios;

namespace okagorachega.Controllers
{
    public class HomeController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";


        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

        public IActionResult Index()
        {
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            ViewData["Comentarios"] = comentarioRepositorio.ListarComentarios();
            
            return View();
        }

       
    }
}