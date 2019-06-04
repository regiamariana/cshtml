using System;
using System.IO;
using Hamburgueria_Tarde.Models;

namespace Hamburgueria_Tarde.Repositorios {
    public class PedidoRepositorio {
        private const string PATH = "DataBase/Pedido.csv";
        public bool Inserir (Pedido pedido) {
            try {

                if (!File.Exists (PATH)) {
                    File.Create (PATH).Close();
                }

                var registro = $"{pedido.ID};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Hamburguer.Preco};{pedido.Shake.Nome};{pedido.Shake.Preco};{pedido.DataDoPedido};{pedido.PrecoTotal}\n";

                File.AppendAllText (PATH, registro);
            } catch (Exception e) {
                System.Console.WriteLine("Chegou no catch!");
                System.Console.WriteLine(e.StackTrace);
            }

            return true;

        }
    }
}