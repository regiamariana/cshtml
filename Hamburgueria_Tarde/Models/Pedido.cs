using System;

namespace Hamburgueria_Tarde.Models
{
    public class Pedido 
    {
        public ulong ID {get;set;}
        public Cliente Cliente {get;set;}
        public Hamburguer Hamburguer {get;set;}
        public Shake Shake {get;set;}
        public DateTime DataDoPedido {get;set;}

        public double PrecoTotal {get; set;}

    }
}