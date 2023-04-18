using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEj6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complejidad cognitiva de 6");
            Console.WriteLine("Ingrese una letra minuscula (desde a hasta f) para saber cual es la siguiente letra del abecedario!!!");
            string letra = Console.ReadLine();

            if (letra == "a")//+1
            {
                Console.WriteLine("La siguente letra del abecedario es B !!!");
            }
            if (letra == "b")//+1
            {
                Console.WriteLine("La siguente letra del abecedario es C !!!");
            }
            if (letra == "c")//+1
            {
                Console.WriteLine("La siguente letra del abecedario es D !!!");
            }
            if (letra == "d")//+1
            {
                Console.WriteLine("La siguente letra del abecedario es E !!!");
            }
            if (letra == "e")//+1
            {
                Console.WriteLine("La siguente letra del abecedario es F !!!");
            }
            if (letra == "f")//+1
            {
                Console.WriteLine("La siguente letra del abecedario es G !!!");
            }
            //////////////////////////////////////////////////////////////////////////
            //Parte B
            Console.WriteLine("Con complejidad disminuida sin Linq");
            Console.WriteLine("Complejidad cognitiva de 1");
            List<string> ListaChars = new List<string> { "a", "b", "c", "d", "f", "g" };
            Console.WriteLine("Ingrese una letra (minuscula) para saber cual es la siguente en el abecedario: ");
            string Letra = Console.ReadLine();

            int resultado = ListaChars.BinarySearch(Letra);//+1
            Console.WriteLine("La siguente letra del abecedario es " + ListaChars[resultado + 1] + "!!!");

        }
    }
}
