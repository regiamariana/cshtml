using System.Collections.Generic;
using novoo.Models;

namespace novoo.ViewModels
{
    public class HomeViewModel
    {
        public List<ModeloModel> Modelos {get;set;}
        public List<MarcaModel> Marcas {get;set;}
    }
}