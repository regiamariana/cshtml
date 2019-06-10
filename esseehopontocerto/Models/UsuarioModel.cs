using System;
using Microsoft.Extensions.Primitives;

namespace esseehopontocerto.Models
{
    public class UsuarioModel
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public DateTime DataNascimento {get; set;}

        public string Email {get;set;}

        public string Endereco {get; set;}
        public string Senha {get; set;}

        public int Telefone {get; set;}
        




            public UsuarioModel( int id, string nome, string email, string senha, DateTime dataNascimento, string endereco, int telefone){
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.DataNascimento = dataNascimento;
            

        }

       
    }
}