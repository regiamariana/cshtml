using Microsoft.Extensions.Primitives;

namespace mc_Bonalds.Models
{
    public class Hamburguer
    {
        public Hamburguer(StringValues Nome)
        {
            this.Nome = Nome;
        }

        public string Nome {get; set;}
    }
}