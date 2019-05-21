using System;
using exercício.Models;
using exercício.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace exercício.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(IFormCollection Form){
            UsuarioModel usuario =new UsuarioModel(
                nome: Form["nome"],
                email: Form["email"],
                senha: Form["senha"],
                dataNascimento: DateTime.Parse(Form["dataNascimento"])
            );
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.CadastrarUsuario(usuario);

            return RedirectToAction("Index", "Usuario");

            
        }
        [HttpGet]
        public IActionResult Listar(){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.Listar();

            return View();
        }
    }
}