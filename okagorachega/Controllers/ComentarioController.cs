using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using okagorachega.Models;
using okagorachega.Repositorios;

namespace okagorachega.Controllers
{
    public class ComentarioController : Controller
    {
        private const string PATH = "DataBase/Comentarios.csv";
        private ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        public IActionResult Index(){
            
            return View();
           
        }

        [HttpPost]
        public IActionResult RegistrarComentario(IFormCollection form){

            ComentarioModel cliente = new ComentarioModel();
            cliente.Id = ulong.Parse(form["id"]);
            cliente.NomeUsuario = form["nome"];
            cliente.Mensagem = form["mensagem"];
            cliente.DataEnvio = DateTime.Parse(form["dataEnvio"]);

            comentarioRepositorio.Inserir(cliente);

            ViewData["Action"] = "Comentario";

            return RedirectToAction("Index", "Home");
        }
    
        
    }
}