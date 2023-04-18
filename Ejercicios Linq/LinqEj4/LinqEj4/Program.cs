using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEj4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio4 A
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sumatotal = 0;

            foreach (var valor in valores)
            {
                sumatotal = sumatotal + valor;
            }
            Console.WriteLine($"La suma total es: {sumatotal}");
            //Linq

            List<int> numeros02 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Consulta con Linq");
            int suma = numeros02.Sum();
            Console.WriteLine("La suma total es: " + suma);

            ////////////////////////////////////////////////////////////////////
            // Ejercicio4 B
            List<int> valores02 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sumatotalValoresPares = 0;

            foreach (var valor02 in valores)
            {
                if (valor02 % 2 == 0)
                {
                    sumatotalValoresPares = sumatotalValoresPares + valor02;
                }
            }
            Console.WriteLine($"la suma total es de los valores pares es: {sumatotalValoresPares}");

            //Linq

            List<int> numeros03 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Consulta con Linq");

            var consulta03 = from p in numeros03 where p % 2 == 0 select p;
            var suma02 = consulta03.Where(x => x % 2 == 0);
            var sumaPares = consulta03.Sum();
            Console.WriteLine($"la suma es {sumaPares}");

        }
    }
}
