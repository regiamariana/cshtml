using mc_Bonalds.Models;
using mc_Bonalds.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mc_Bonalds.Controllers
{
    public class PedidoController : Controller
    {
        private PedidoRepositorio Repositorio = new PedidoRepositorio();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form){
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hambúrguer"]);
            System.Console.WriteLine(form["shake"]);

            Pedido pedido = new Pedido();

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;

            Hamburguer hamburguer = new Hamburguer(
                Nome: form["hamburguer"]
            );

            pedido.Hamburguer = hamburguer;

            Shake shake = new Shake(){
                Nome = form["shake"]
            };

            pedido.Shake = shake;

            Repositorio.Inserir(pedido);

            return RedirectToAction("Index", "Home");
        }
    }
}