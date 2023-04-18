using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEj5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio5 

            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int sumaTotalValoresParesMayoresA8 = 0;
            int sumaTotalValoresParesMenoresA8 = 0;

            foreach (var valor in valores)
            {
                if (valor % 2 == 0)
                {
                    if (valor > 8)
                    {
                        sumaTotalValoresParesMayoresA8 = sumaTotalValoresParesMayoresA8 + valor;
                    }
                    else
                    {
                        sumaTotalValoresParesMenoresA8 = sumaTotalValoresParesMenoresA8 + valor;
                    }
                }
            }

            Console.WriteLine($"la suma total de los valores pares  mayores de 8: {sumaTotalValoresParesMayoresA8}");
            Console.WriteLine($"la suma total de los valores pares menores de 8: {sumaTotalValoresParesMenoresA8}");


            //////////////////////////////////////////////////////////
            //Parte 1
            Console.WriteLine("Complejidad disminuida");
            int sumaTotalValoresParesMayoresA802 = 0;
            int sumaTotalValoresParesMenoresA802 = 0;
            foreach (var valor in valores)
            {

                if (valor % 2 == 0 && valor > 8)
                {
                    sumaTotalValoresParesMayoresA802 = sumaTotalValoresParesMayoresA802 + valor;
                }
                else if (valor % 2 == 0 && valor < 8)
                {
                    sumaTotalValoresParesMenoresA802 = sumaTotalValoresParesMenoresA802 + valor;
                }
            }
            Console.WriteLine($"la suma total de los valores pares  mayores de 8: {sumaTotalValoresParesMayoresA8}");
            Console.WriteLine($"la suma total de los valores pares menores de 8: {sumaTotalValoresParesMenoresA8}");
            //////////////////////////////////////////////////////////////////////////
            //Linq
            Console.WriteLine("Con Linq");
            List<int> valores02 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var consulta = from p in valores02 where p % 2 == 0 select p;
            var suma = valores02.Where(x => x % 2 == 0 && x > 8);
            var suma02 = valores02.Where(x => x % 2 == 0 && x <= 8);
            var sumaPares05 = suma.Sum();
            var sumaPares06 = suma02.Sum();
            Console.WriteLine($"la suma mayores a 8 es  {sumaPares05}");
            Console.WriteLine($"la suma menores a 8 es  {sumaPares06}");
        }
    }
}
