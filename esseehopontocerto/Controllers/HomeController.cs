using System;
using esseehopontocerto.Models;
using esseehopontocerto.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace esseehopontocerto.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            
            return View();
        }
            

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(
                id: int.Parse(form["id"]),
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                endereco: form["endereco"],
                telefone: int.Parse(form["telefone"]),
                dataNascimento: DateTime.Parse(form["dataNascimento"])
            );
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Cadastrar(usuario);

            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public IActionResult Listar(){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.Listar();

            return View();
        }


    }
}