using System;
using System.Collections.Generic;
using System.IO;
using estacionamento.Models;

namespace estacionamento.Repositorio {
    public class UsuarioRepositorio {
        public CarroModel CadastrarUsuario (CarroModel usuario) {
            if (File.Exists ("registros.csv")) {
                usuario.Id = File.ReadAllLines ("registros.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter ("registros.csv", true);
            sw.WriteLine ($"{usuario.Id}; {usuario.NomeCondutor}; {usuario.ModeloCarro};{usuario.MarcaCarro};{usuario.Placa};{usuario.Data}; ");
            sw.Close ();

            return usuario;
        }


        public List<CarroModel> Listar () {
            List<CarroModel> listaDeUsuarios = new List<CarroModel> ();
            string[] linhas = File.ReadAllLines ("registros.csv");
            CarroModel usuario;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    //sair do foreach
                    continue;
                }
                string[] linha = item.Split (";");

                usuario = new CarroModel (
                    id: int.Parse (linha[0]),
                    nome: linha[1],
                    modelo: linha[2],
                    marca: linha[3],
                    placa: linha[4],
                    data: DateTime.Parse (linha[5])
                );
                listaDeUsuarios.Add (usuario);
            }
            return listaDeUsuarios;
        }
        //COMEÇA MARCA

        public CarroModel CadastrarMarcas (CarroModel usuario) {
            if (File.Exists ("marcas.csv")) {
                usuario.Id = File.ReadAllLines ("marcas.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter ("marcas.csv", true);
            sw.WriteLine ($"{usuario.Id};{usuario.MarcaCarro};");
            sw.Close ();

            return usuario;
        }

        public List<CarroModel> Listar2 () {
            List<CarroModel> listaDeMarcas = new List<CarroModel> ();
            string[] linhas = File.ReadAllLines ("marcas.csv");
            CarroModel usuario;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    //sair do foreach
                    continue;
                }
                string[] linha = item.Split (";");

                   usuario = new CarroModel(
                    
                    marca: linha[1]  
                    
                );
                listaDeMarcas.Add (usuario);
            }
            return listaDeMarcas;
        }

        //TERMINA MARCA

        //COMEÇA MODELO

        public CarroModel CadastrarModelos (CarroModel usuario) {
            if (File.Exists ("modelos.csv")) {
                usuario.Id = File.ReadAllLines ("modelos.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter ("modelos.csv", true);
            sw.WriteLine ($"{usuario.Id};{usuario.ModeloCarro};");
            sw.Close ();

            return usuario;
        }

        public List<CarroModel> Listar3 () {
            List<CarroModel> listaDeModelos = new List<CarroModel> ();
            string[] linhas = File.ReadAllLines ("modelos.csv");
            CarroModel usuario;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    //sair do foreach
                    continue;
                }
                string[] linha = item.Split (";");

                    usuario = new CarroModel (
                    
                    modelo: linha[1]  
                    
                );
                listaDeModelos.Add (usuario);
            }
            return listaDeModelos;
        }

        public CarroModel BuscarPorModelo (string modelo) {
            List<CarroModel> listaDeUsuarios = Listar ();

            foreach (var item in listaDeUsuarios) {
                if (modelo == item.ModeloCarro) {
                    return item; //Retorna o usuario
                }
            }
            return null;

        }
        


    }
}