using System;
using System.Collections.Generic;
using System.IO;
using esseehopontocerto.Models;

namespace esseehopontocerto.Repositorios
{
    public class UsuarioRepositorio
    {
        public UsuarioModel Cadastrar(UsuarioModel usuario){
            if (File.Exists("usuarios.csv"))
            {
                usuario.Id = File.ReadAllLines("usuarios.csv").Length +1;
            }else{
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter("usuarios.csv", true);
            sw.WriteLine($"{usuario.Id}; {usuario.Nome}; {usuario.Email};{usuario.Senha};{usuario.DataNascimento};{usuario.Endereco};{usuario.Telefone}");
            sw.Close();

            return usuario;
        }

        public List<UsuarioModel> Listar(){
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
            string[] linhas = File.ReadAllLines("usuarios.csv");
            UsuarioModel usuario;

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    //sair do foreach
                    continue;
                }
                string[]linha = item.Split(";");

                usuario = new UsuarioModel(
                    id: int.Parse(linha[0]),
                    nome: linha[1],
                    email: linha[2],
                    senha: linha[3],
                    dataNascimento: DateTime.Parse(linha[4]),
                    endereco: linha[5],
                    telefone: int.Parse(linha[6])
                    
                );
                listaDeUsuarios.Add(usuario);
            }
            return listaDeUsuarios;
        }
    }
}