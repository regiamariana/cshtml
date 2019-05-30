using System;

namespace estacionamento2.Models
{
    public class CondutorModel
    {
        public string Nome {get; set;}

        public string Marca {get; set;}

        public string Modelo {get; set;}

        public int Id {get; set;}

        public string Placa {get; set;}

        public DateTime DataEntrada {get; set;} 

        public CondutorModel (int id, string nome, string marca, string modelo, string placa, DateTime dataEntrada){
            this.Id = id;
            this.Nome = nome;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.DataEntrada = dataEntrada;
        }
    }
}