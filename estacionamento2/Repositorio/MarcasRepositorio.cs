using System.Collections.Generic;
using System.IO;
using estacionamento2.Models;

namespace estacionamento2.Repositorio
{
    public class MarcasRepositorio
    {
        public List<MarcaModel> Listar(){
            List<MarcaModel> listaDeMarcas = new List<MarcaModel>();
            string[] linhas = File.ReadAllLines("DataBase/marcas.csv");
            MarcaModel marca;

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] linha = item.Split(";");
                marca = new MarcaModel(
                    id: int.Parse(linha[0]),
                    nome: linha[1]
                );
                listaDeMarcas.Add(marca);
            }
            return listaDeMarcas;
        }//fim de listar
    }
}