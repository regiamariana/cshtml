using System.Collections.Generic;
using System.IO;
using Hamburgueria_Tarde.Models;

namespace Hamburgueria_Tarde.Repositorios
{
    public class ShakeRepositorio
    {
        private const string PATH = "Database/Shake.csv ";

        private List<Shake> shakes = new List<Shake>();

        public List<Shake> Listar(){
            var  registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Shake shake = new Shake();
                shake.Nome = valores[1];
                shake.Preco = double.Parse(valores[2]);



                shakes.Add(shake);
            }

            return shakes;
        }

        public double ObterPrecoDe(string nomeShake){
            var lista = Listar();
            var preco = 0.0;

            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeShake))
                {
                    preco = item.Preco;
                }
            }
            return preco;
        }
    
    
    }
}