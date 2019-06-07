using System;

namespace pontodigital1.Models
{
    public class RegistroModel
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public DateTime DataNascimento {get; set;}

        public string Email {get;set;}

        public string Endereco {get; set;}

        public GeneroModel Genero {get; set;}

        public int Telefone {get; set;}

        public string Senha {get; set;}
 

    }
}