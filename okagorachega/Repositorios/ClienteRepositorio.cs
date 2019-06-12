using System;
using System.Collections.Generic;
using System.IO;
using okagorachega.Models;

namespace okagorachega.Repositorios
{
    public class ClienteRepositorio : BaseRepositorio
    {
         public static uint CONT = 0;
        private const string PATH = "Database/Cliente.csv";
        private const string PATH_INDEX = "Database/Cliente_Id.csv";
        private List<ClienteModel> clientes = new List<ClienteModel> ();

        public bool Inserir (ClienteModel cliente) {
            CONT++;
            File.WriteAllText (PATH_INDEX, CONT.ToString ());

            string linha = PrepararRegistroCSV (cliente);
            File.AppendAllText (PATH, linha);

            return true;
        }

         private string PrepararRegistroCSV (ClienteModel cliente) {
            return $"id={CONT};nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento};\n";
        }

        private ClienteModel ConverterEmObjeto (string registro) {

            ClienteModel cliente = new ClienteModel ();
            System.Console.WriteLine ("REGISTRO:" + registro);
            cliente.ID = ulong.Parse (ExtrairCampo ("id", registro));
            cliente.Nome = ExtrairCampo ("nome", registro);
            cliente.Email = ExtrairCampo ("email", registro);
            cliente.Senha = ExtrairCampo ("senha", registro);
            cliente.Endereco = ExtrairCampo ("endereco", registro);
            cliente.Telefone = ExtrairCampo ("telefone", registro);
            cliente.DataNascimento = DateTime.Parse (ExtrairCampo ("data_nascimento", registro));

            return cliente;
        }

         public ClienteModel ObterPor (string email) {
            if (email != null) {

                foreach (var item in ObterRegistrosCSV (PATH)) {
                    if (email.Equals (ExtrairCampo ("email", item))) {
                        return ConverterEmObjeto (item);
                    }
                }
            }
            return null;
        }


    }
}