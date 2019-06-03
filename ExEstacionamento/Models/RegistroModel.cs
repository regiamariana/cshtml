using System;

namespace ExEstacionamento.Models
{
    public class RegistroModel
    {
        public int Id{get;set;}
        public string Nome{get;set;}
        public MarcaModel Marca{get;set;}
        public ModeloModel Modelo{get;set;}

        public string Placa {get;set;}
        public DateTime DataEntrada{get;set;}

    }
}