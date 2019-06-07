using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pontodigital1.Models;
using pontodigital1.Repositorios;
using pontodigital1.ViewModels;

namespace pontodigital1.Controllers
{
    public class HomeController : Controller
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        GeneroRepositorio generoRepositorio = new GeneroRepositorio();
        [HttpGet]
        public IActionResult Index(){
            var listaDeGeneros = usuarioRepositorio.ListarGeneros();

            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Generos = listaDeGeneros;
            return View(homeViewModel);
        }

        public IActionResult RegistrarEntrada(IFormCollection form){
            RegistroModel registro = new RegistroModel();
            registro.Nome = form["nome"];
            registro.Genero = form["genero"];
        }
    }
}