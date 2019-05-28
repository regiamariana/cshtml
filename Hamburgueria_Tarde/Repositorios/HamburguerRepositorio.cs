using System.Collections.Generic;
using System.IO;
using Hamburgueria_Tarde.Models;

namespace Hamburgueria_Tarde.Repositorios
{
    public class HamburguerRepositorio
    {
        private const string PATH = "Database/Hamburguer.csv";

        private List<Hamburguer> hamburgueres = new List<Hamburguer>();

        public List<Hamburguer> Listar(){
            var  registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Hamburguer hamburguer = new Hamburguer();
                hamburguer.Nome = valores[1];
                hamburguer.Preco = double.Parse(valores[2]);

                hamburgueres.Add(hamburguer);
            }

            return hamburgueres;
        }

        public double ObterPrecoDe(string nomeHamburguer){
            var lista = Listar();
            var preco = 0.0;

            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeHamburguer))
                {
                    preco = item.Preco;
                }
            }
            return preco;
        }
    }
}