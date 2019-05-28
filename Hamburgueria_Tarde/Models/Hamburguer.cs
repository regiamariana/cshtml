using Microsoft.Extensions.Primitives;

namespace Hamburgueria_Tarde.Models
{
    public class Hamburguer : Produto
    {
        public Hamburguer()
        {

        }

        public Hamburguer(StringValues Nome, double Preco)
        {
            this.Nome = Nome;
        }

    }
}