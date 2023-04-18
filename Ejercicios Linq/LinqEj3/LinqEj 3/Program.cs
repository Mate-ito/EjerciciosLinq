using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEj_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("La complijidad cignitiva del bloque sin Linq es 5");
            for (var indice = 0; indice < valores.Count - 1; indice++)//+2
            {
                if (valores[indice] > valores[indice + 1])//+2                       // complejidad cognitiva = 5
                {
                    var valorTemporal = valores[indice];
                    valores[indice] = valores[indice + 1];
                    valores[indice + 1] = valorTemporal;
                    indice = -1;
                }
            }

            foreach (var valorOrdenado in valores)//+1
            {
                Console.WriteLine(valorOrdenado);
            }

            //Ejercico3

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };



            var consulta = from p in numeros orderby p select p;
            Console.WriteLine("Consulta Linq:");
            foreach (var numero in consulta)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
