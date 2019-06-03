using System;
using System.Collections.Generic;
using System.IO;
using ExEstacionamento.Models;

namespace ExEstacionamento.Repositorios
{
    public class RegistroRepositorio
    {
        private const string PATH = "DataBases/Registros.csv";
        public void RegistrarNoCSV(RegistroModel registro){

            if(File.Exists(PATH)){
                registro.Id = File.ReadAllLines(PATH).Length + 1;
            }else{
                registro.Id = 1;
            }
            
            StreamWriter sw = new StreamWriter(PATH, true);

            sw.WriteLine($"{registro.Id};{registro.Nome};{registro.Marca.Nome};{registro.Modelo.Nome};{registro.Placa};{DateTime.Now}");
            sw.Close();
        }

            public List<RegistroModel> Listar(){
                List<RegistroModel>  listaDeRegistros = new List<RegistroModel>();

                string[] linhas = File.ReadAllLines(PATH);
                foreach (var item in linhas)
                {
                    if (string.IsNullOrEmpty(item))
                    {
                        continue;
                    }
                    string[] dados = item.Split(";");
                    RegistroModel registro = new RegistroModel();

                    registro.Id = int.Parse(dados[0]);
                    registro.Nome = dados[1];
                    registro.Marca = new MarcaModel();
                    registro.Marca.Nome = dados [2];
                    registro.Modelo = new ModeloModel();
                    registro.Modelo.Nome = dados[3];
                    registro.Placa = dados [4];
                    registro.DataEntrada = DateTime.Parse(dados[5]);

                    listaDeRegistros.Add(registro);
                }
                return listaDeRegistros;
            }

            public List<RegistroModel> Filtro(DateTime data){
                List<RegistroModel> listaFiltrada = new List<RegistroModel>();
                List<RegistroModel> listaDeRegistros = Listar();

                foreach (var item in listaDeRegistros)
                {
                    if (item.DataEntrada.ToShortDateString() == data.ToShortDateString())
                    {
                        listaFiltrada.Add(item);
                    }else
                    {
                        continue;
                    }
                }//fim foreach 
                return listaFiltrada;
            }

            public List<RegistroModel> Filtro(string modelo){
                List<RegistroModel> listaFiltrada = new List<RegistroModel>();
                List<RegistroModel> listaDeRegistros = Listar();

                foreach (var item in listaDeRegistros)
                {
                    if (item.Modelo.Nome.Equals(modelo))
                    {
                        listaFiltrada.Add(item);
                    }else
                    {
                        continue;
                    }
                }//fim foreach 
                return listaFiltrada;
            }

            public List<RegistroModel> Filtro(DateTime data, string modelo){
                List<RegistroModel> listaFiltrada = new List<RegistroModel>();
                List<RegistroModel> listaDeRegistros = Listar();

                foreach (var item in listaDeRegistros)
                {
                    if (item.Modelo.Nome.Equals(modelo) && item.DataEntrada.ToShortDateString() == data.ToShortDateString())
                    {
                        listaFiltrada.Add(item);
                    }else
                    {
                        continue;
                    }
                }//fim foreach 
                return listaFiltrada;
            }
    }
}