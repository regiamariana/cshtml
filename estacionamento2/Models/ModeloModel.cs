namespace estacionamento2.Models
{
    public class ModeloModel
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public ModeloModel (int id, string nome){
            this.Id = id;

            this.Nome = nome;
        }
    }
}