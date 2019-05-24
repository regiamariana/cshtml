using System;
namespace mc_Bonalds.Models {
    public class Pedido {
        
        public ulong Id { get; set; }

        public Cliente Cliente { get; set; }

        public Hamburguer Hamburguer { get; set; }

        public Shake Shake { get; set; }

        public DeteTime DataPedido { get; set; }
    }
}