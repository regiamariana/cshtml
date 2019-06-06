using Microsoft.AspNetCore.Mvc;

namespace pontodigital.Controller
{
    public class CadastroController
    {
        public IActionResult Index(){
            ViewData["NomeView"] = "Cadastro";
            return View();

    }
}
}