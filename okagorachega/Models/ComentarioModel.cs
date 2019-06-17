using System;

namespace okagorachega.Models
{
    public class ComentarioModel{
        public ulong Id {get; set;}

        public string NomeUsuario {get; set;}

        public string Mensagem {get; set;}

        public DateTime DataEnvio {get; set;}
    }
}