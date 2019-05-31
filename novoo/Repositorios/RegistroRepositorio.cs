using System;
using System.IO;
using novoo.Models;

namespace novoo.Repositorios
{
    public class RegistroRepositorio
    {
        private const string PATH = "DataBases/Registros.csv";
        public void RegistrarNoCSV(RegistroModel registro){

            if(File.Exists(PATH)){
                registro.Id = File.ReadAllLines(PATH).Length + 1;

            }else
            {
                registro.Id = 1;
            }

            StreamWriter sw = new StreamWriter(PATH, true);

            sw.WriteLine($"{registro.Id};{registro.Nome};{registro.Marca.Nome};{registro.Modelo.Nome};{registro.Placa};{DateTime.Now}");
            sw.Close();

        }
    }
}