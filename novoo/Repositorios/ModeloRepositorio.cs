using System.Collections.Generic;
using System.IO;
using novoo.Models;

namespace novoo.Repositorios
{
    public class ModeloRepositorio
    {
        private const string PATH = "DataBases/Modelos.csv";

        public List<ModeloModel> listaDeModelos = new List<ModeloModel>();

        public List<ModeloModel> ListarModelos(){
            string[] modelos = File.ReadAllLines(PATH);

            foreach (var item in modelos)
            {
                if (item != null)
                {
                    string[] dados = item.Split(";");
                    var modelo = new ModeloModel();

                    modelo.Id = int.Parse(dados[0]);
                    modelo.Nome = dados[1];
                    listaDeModelos.Add(modelo);
                }
            }

            return listaDeModelos;
        }

    }
}