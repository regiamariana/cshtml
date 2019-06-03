using System.Collections.Generic;
using ExEstacionamento.Models;

namespace ExEstacionamento.ViewModels
{
    public class HomeViewModel
    {
        public List<ModeloModel> Modelos {get;set;}

        public List<MarcaModel> Marcas {get;set;}

        public List<RegistroModel> Registros {get;set;}

        
    }
}