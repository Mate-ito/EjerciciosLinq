using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEjercicio2
{
    internal class TipoAnimal
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public void GetDatoTipoAnimal()
        {
            Console.WriteLine("Raza{0} con id{1}", nombre, id);
        }
    }
}
