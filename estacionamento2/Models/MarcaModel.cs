namespace estacionamento2.Models
{
    public class MarcaModel
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        

        public MarcaModel(int id, string nome)
        {
             this.Id = id;
            this.Nome = nome;
        }
    }
}