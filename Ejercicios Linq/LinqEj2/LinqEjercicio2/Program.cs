using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEjercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlTiposDeAnimales ce = new ControlTiposDeAnimales();

            Console.WriteLine("Promedio de edades \n************************ ");
            ce.PromedioEdad();
            Console.WriteLine("");

            Console.WriteLine("Animales Grises \n************************ ");
            ce.GetColores("Gris");

            Console.WriteLine("");
            Console.WriteLine("Animales registrados \n************************ ");
            ce.GetAnimalesOrdenados();
            Console.WriteLine("");
            Console.WriteLine("Animales ordenados por edad\n************************ ");
            ce.GetAnimalesOrdenadosSegun();

            Console.WriteLine("\nIngrese el tipo de animal(entero 1 a 3)\n1 para Perros \n2 para Gatos \n3 para Conejos");
            string _id = Console.ReadLine();
            try
            {
                int _TipoAnimal = int.Parse(_id);
                ce.GetTipoAnimal(_TipoAnimal);
            }
            catch
            {
                Console.WriteLine("ha introducido un id erroneo. Debe ingresar un numero entero");
            }
        }
    }
}


