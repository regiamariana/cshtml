using System;
using System.Collections.Generic;
using System.IO;
using okagorachega.Models;

namespace okagorachega.Repositorios
{
    public class ComentarioRepositorio : BaseRepositorio
    {
        public static uint CONT = 0;
        private const string PATH = "DataBase/Comentarios.csv";

        private List<ComentarioModel> comentarios = new List<ComentarioModel>();

        

        public bool Inserir (ComentarioModel cliente) {
            try {

                if (!File.Exists (PATH)) {
                    File.Create (PATH).Close();
                }

                var registro = $"id={CONT};nome={cliente.NomeUsuario};mensagem={cliente.Mensagem};dataEnvio={cliente.DataEnvio};\n";

                File.AppendAllText (PATH, registro);
            } catch (Exception e) {
                System.Console.WriteLine("Chegou no catch!");
                System.Console.WriteLine(e.StackTrace);
            }

            return true;
        }

         private string PrepararRegistroCSV (ComentarioModel cliente) {
            return $"id={CONT};nome={cliente.NomeUsuario};mensagem={cliente.Mensagem};dataEnvio={cliente.DataEnvio};\n";
        }

        private ComentarioModel ConverterEmObjeto (string registro) {

            ComentarioModel cliente = new ComentarioModel ();
            System.Console.WriteLine ("REGISTRO:" + registro);
            cliente.Id = ulong.Parse (ExtrairCampo ("id", registro));
            cliente.NomeUsuario = ExtrairCampo ("nome", registro);
            cliente.Mensagem = ExtrairCampo ("mensagem", registro);
            cliente.DataEnvio =DateTime.Parse(ExtrairCampo ("dataEnvio", registro));

            return cliente;
        }

         public ComentarioModel ObterPor (string nome) {
            if (nome != null) {

                foreach (var item in ObterRegistrosCSV (PATH)) {
                    if (nome.Equals (ExtrairCampo ("nome", item))) {
                        return ConverterEmObjeto (item);
                    }
                }
            }
            return null;
        }

    }

}

        // ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        // public ComentarioModel Inserir (ComentarioModel comentario){
        //     if (!File.Exists(PATH))
        //     {
        //         File.Create(PATH).Close();
        //     }
        //     comentario.Id = (ulong) File.ReadAllLines(PATH).Length + 1;

        //     string dadosDoComentario = $"{comentario.Id};{comentario.NomeUsuario};{comentario.Mensagem};{comentario.DataEnvio}";
        //     File.AppendAllText(PATH, dadosDoComentario);
        //     return comentario;
        // }

        // public List<ComentarioModel> Listar(){
        //     var registros = File.ReadAllLines(PATH);
        //     foreach (var item in registros)
        //     {
        //         ComentarioModel comentario = new ComentarioModel(); 
        //         var dados = item.Split(";");
        //         comentario.Id = ulong.Parse(dados[0]);
        //         comentario.NomeUsuario = dados[1];
        //         comentario.Mensagem = dados[2];
        //         comentario.DataEnvio = DateTime.Parse(dados[3]);
        //         comentarios.Add(comentario);
        //     } return comentarios;
        // }