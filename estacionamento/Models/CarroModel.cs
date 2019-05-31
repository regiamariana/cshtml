using System;

namespace estacionamento.Models
{
    public class CarroModel
    {
        private string modelo;
        private string marca;

        public int Id {get; set;}
        public string NomeCondutor {get; set;}

        public string ModeloCarro {get; set;}

        public string MarcaCarro {get; set;}

        public string Placa {get; set;}

        public DateTime Data {get; set;}

        public CarroModel(string nome, string modelo, string marca, string placa, DateTime data){
            this.NomeCondutor = nome;
            this.ModeloCarro = modelo;
            this.MarcaCarro = marca;
            this.Placa = placa;
            this.Data = data;
        }

        public CarroModel(int id, string nome, string modelo, string marca, string placa, DateTime data){
            this.Id = id;
            this.NomeCondutor = nome;
            this.ModeloCarro = modelo;
            this.MarcaCarro = marca;
            this.Placa = placa;
            this.Data = data;
        }

        public CarroModel(string marca)
        {
            this.marca = marca;
        }

       
    } 
}