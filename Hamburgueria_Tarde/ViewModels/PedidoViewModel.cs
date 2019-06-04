using System.Collections.Generic;
using Hamburgueria_Tarde.Models;

namespace Hamburgueria_Tarde.ViewModels
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get; set;}
        public List<Shake> Shakes{get; set;}

        public Cliente Cliente {get; set;}
    }
}