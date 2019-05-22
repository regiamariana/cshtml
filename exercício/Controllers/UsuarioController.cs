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
        [HttpGet]
        public IActionResult Editar(int id){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuarioRecuperado = usuarioRepositorio.BuscarPorId(id);
            if (usuarioRecuperado != null)
            {
                ViewBag.usuario = usuarioRecuperado;
            
            }else{
                TempData["mensagem"] = "Usuario não encontrado";
                return RedirectToAction("Listar");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(
                id: int.Parse(form["id"]),
                nome: form ["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse(form["dataNascimento"])
            );
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.EditarUsuario(usuario);

            TempData["mensagem"] = $"{usuario.Nome} editado com sucesso";
            return RedirectToAction("Listar");

        }
    }
}