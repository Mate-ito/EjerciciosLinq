using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 25, Ciudad ="Lima"},
                new Persona { Nombre = "Maria", Edad = 30, Ciudad = "Bogota" },
                new Persona { Nombre = "Pedro", Edad = 35, Ciudad = "Madrid" },
                new Persona { Nombre = "Ana", Edad = 20, Ciudad = "Lima" },
                new Persona { Nombre = "Jose", Edad = 40, Ciudad = "Buenos Aires" },
            };

            var consulta = from p in personas
                           where p.Edad < 25 && p.Ciudad == "Lima"
                           orderby p.Nombre descending
                           select new { p.Nombre, p.Edad };
            foreach (var persona in consulta)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }



            var consulta02 = from p in personas
                             where p.Edad >= 30 && p.Ciudad == "Bogota"
                             orderby p.Nombre descending
                             select new { p.Nombre, p.Edad };
            Console.WriteLine("\n");
            Console.WriteLine("Mostrar el nombre de todas las personas que tengan una edad mayor a 30 y vivan en Bogotá");
            foreach (var persona in consulta02)
            {

                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }



            var consulta03 = from p in personas
                             where p.Edad >= 25 && p.Edad <= 35
                             orderby p.Nombre ascending
                             select new { p.Nombre, p.Edad };
            Console.WriteLine("\n");
            Console.WriteLine("Mostrar el nombre de todas las personas que tengan una edad entre 25 y 35 años, ordenadas por edad de forma ascendente");
            foreach (var persona in consulta03)
            {

                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }
        }
    }
}
