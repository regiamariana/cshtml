using System.Collections.Generic;
using System.IO;
using pontodigital1.Models;

namespace pontodigital1.Repositorios
{
    public class UsuarioRepositorio
    {
        private const string PATH = "DataBase/Genero.csv";

        private List<GeneroModel> listaDeGeneros = new List<GeneroModel>();

        public List<GeneroModel> ListarGeneros(){
            string[] generos = File.ReadAllLines(PATH);

            foreach (var item in generos)
            {
                if(item != null){
                    string[] dados = item.Split(";");
                    var genero = new GeneroModel();
                    genero.Masculino = dados[0];
                    genero.Feminino = dados [1];
                    //genero.Indefinido = dados[2];

                    listaDeGeneros.Add(genero);
                }//fim if
            }//fim foreach
            return listaDeGeneros;
        }

        
    }
}