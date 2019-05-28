using System;
using estacionamento.Models;
using estacionamento.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace estacionamento.Controllers
{
    public class CadastroController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(IFormCollection Form){
            CarroModel usuario =new CarroModel(
                nome: Form["nome"],
                modelo: Form["modelo"],
                marca: Form["marca"],
                placa: Form["placa"],
                data: DateTime.Parse(Form["data"])
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