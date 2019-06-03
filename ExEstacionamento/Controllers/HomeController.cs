using System;
using ExEstacionamento.Models;
using ExEstacionamento.Repositorios;
using ExEstacionamento.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExEstacionamento.Controllers
{
    public class HomeController : Controller
    {
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();

        RegistroRepositorio registroRepositorio = new RegistroRepositorio();

        HomeViewModel homeViewModel = new HomeViewModel();

        [HttpGet]
        public IActionResult Index(){
            var listaDeModelos = modeloRepositorio.ListarModelos();
            var listaDeMarcas = marcaRepositorio.ListarMarcas();

            homeViewModel.Modelos = listaDeModelos;
            homeViewModel.Marcas = listaDeMarcas;

            return View(homeViewModel);
        }
        [HttpPost]
        public IActionResult RegistrarEntrada(IFormCollection form){
            RegistroModel registro = new RegistroModel();
            registro.Nome = form["nome"];

            ModeloModel modelo = new ModeloModel();
            modelo.Nome = form["modelo"];

            registro.Modelo = modelo;

            MarcaModel marca = new MarcaModel();
            marca.Nome = form["marca"];

            registro.Marca = marca;

            registro.Placa = form["placa"];
            
            registroRepositorio.RegistrarNoCSV(registro);


            return RedirectToAction("Index","Home");
        }

        public IActionResult ListarRegistros() {
            homeViewModel.Modelos = modeloRepositorio.ListarModelos();
            homeViewModel.Registros = registroRepositorio.Listar();

            return View(homeViewModel);
        }
        public IActionResult BuscarRegistros(IFormCollection form){
            string modelo = form["modelo"];
            string dataForm = form["data"];
            DateTime data;
            if (string.IsNullOrEmpty(modelo) && string.IsNullOrEmpty(dataForm))
            {
                return RedirectToAction("ListarRegistros");

            }else if (string.IsNullOrEmpty(modelo))
            {
                data = DateTime.Parse(dataForm);
                homeViewModel.Registros = registroRepositorio.Filtro(data);
            }else if (string.IsNullOrEmpty(dataForm))
            {
                homeViewModel.Registros = registroRepositorio.Filtro(modelo);
            }else
            {
                data = DateTime.Parse(dataForm);
                homeViewModel.Registros = registroRepositorio.Filtro(data, modelo);
            }
            homeViewModel.Modelos = modeloRepositorio.ListarModelos();
            return View(homeViewModel);

            
        }
    }
}