using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using okagorachega.Models;
using okagorachega.Repositorios;

namespace okagorachega.Controllers
{
    public class CadastroController : Controller
    {
        public const string SESSION_EMAIL = "_EMAIL";
        public const string SESSION_SENHA = "_SENHA";
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public IActionResult Index(){
            
            return View();
           
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){

            ClienteModel cliente = new ClienteModel();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Senha = form["senha"];
            cliente.Email = form["email"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            clienteRepositorio.Inserir(cliente);

            ViewData["Action"] = "Cadastro";

            return RedirectToAction("Index", "Home");
        }

       
    }
}