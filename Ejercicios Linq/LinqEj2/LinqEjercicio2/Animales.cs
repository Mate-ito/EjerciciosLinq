using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEjercicio2
{
    internal class Animal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int tipo { get; set; }
        public int edad { get; set; }
        public string color { get; set; }


        public void GetDatosAnimal()
        {
            Console.WriteLine("Animal llamado {0} con ID {1}, de color {2}, que es un {3} de {4} años", nombre, id, color, tipo, edad);
        }


    }
}
