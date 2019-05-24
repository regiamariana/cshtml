using System.IO;
using mc_Bonalds.Models;

namespace mc_Bonalds.Repositorios
{
    public class PedidoRepositorio
    {
        public bool Inserir(Pedido pedido){

            try
            {
                
            if(!File.Exists("Database/Pedido.csv")){
                //código da gravação
                File.Create("Database/Pedido.csv").Close();
            } 

            var registro = $"{pedido.Id}; {pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email}; {pedido.Hamburguer.Nome};{pedido.Shake.Nome}; {pedido.DataPedido}";

            File.AppendAllText("Database/Pedido.csv", registro);
            }
            catch (PathTooLongException ptle)
            {
            System.Console.WriteLine("chegou no catch");
               System.Console.WriteLine(ptle.StackTrace);
                throw;
            }


            return true;
        }
    }
}
    
