using System;

namespace Hamburgueria_Tarde.Models
{
    public class Cliente
    {
        public ulong ID {get;set;}
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}

        public string Senha {get; set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get; set;}
    }
}