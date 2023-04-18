using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEjercicio2
{
    internal class ControlTiposDeAnimales
    {
        public List<TipoAnimal> listaTipoAnimal;
        public List<Animal> listaAnimales;

        public ControlTiposDeAnimales()
        {
            listaTipoAnimal = new List<TipoAnimal>();
            listaAnimales = new List<Animal>();

            listaTipoAnimal.Add(new TipoAnimal { id = 1, nombre = "perro" });
            listaTipoAnimal.Add(new TipoAnimal { id = 2, nombre = "gato" });
            listaTipoAnimal.Add(new TipoAnimal { id = 3, nombre = "conejo" });

            listaAnimales.Add(new Animal { id = 1, nombre = "Matias", color = "Negro", tipo = 1, edad = 5 });
            listaAnimales.Add(new Animal { id = 2, nombre = "Mateo", color = "Blanco", tipo = 1, edad = 1 });
            listaAnimales.Add(new Animal { id = 3, nombre = "Federico", color = "Marron", tipo = 3, edad = 8 });
            listaAnimales.Add(new Animal { id = 4, nombre = "Mariana", color = "Gris", tipo = 2, edad = 12 });
            listaAnimales.Add(new Animal { id = 5, nombre = "Nick", color = "Naranja", tipo = 2, edad = 3 });
            listaAnimales.Add(new Animal { id = 6, nombre = "Burbuja", color = "Amarillo", tipo = 1, edad = 6 });
            listaAnimales.Add(new Animal { id = 7, nombre = "Paulina", color = "Negro", tipo = 2, edad = 9 });
            listaAnimales.Add(new Animal { id = 8, nombre = "Ron", color = "Gris", tipo = 3, edad = 4 });
        }
        public void GetColores(string _color)
        {
            IEnumerable<Animal> animales = from animal in listaAnimales
                                           where animal.color == _color
                                           select animal;

            foreach (Animal elemento in animales)
            {
                elemento.GetDatosAnimal();
            }
        }

        public void GetAnimalesOrdenados()
        {
            IEnumerable<Animal> animales = from animal in listaAnimales
                                           orderby animal.nombre
                                           select animal;

            foreach (Animal elemento in animales)
            {
                elemento.GetDatosAnimal();
            }
        }

        public void GetAnimalesOrdenadosSegun()
        {
            IEnumerable<Animal> animales = from animal in listaAnimales
                                           orderby animal.edad
                                           select animal;

            foreach (Animal elemento in animales)
            {
                elemento.GetDatosAnimal();
            }
        }

        public void GetTipoAnimal(int _TipoAnimal)
        {
            IEnumerable<Animal> empleados = from animal in listaAnimales
                                            join tipo in listaTipoAnimal on animal.tipo
                                            equals tipo.id
                                            where tipo.id == _TipoAnimal
                                            select animal;

            foreach (Animal elemento in empleados)
            {
                elemento.GetDatosAnimal();
            }
        }

        public void PromedioEdad()
        {
            var consulta = from e in listaAnimales
                           group e by e.tipo into g
                           select new { TipoAnimal = g.Key, PromedioSalario = g.Average(e => e.edad) };

            foreach (var resultado in consulta)
            {
                switch (resultado.TipoAnimal)
                {
                    case 1:
                        Console.WriteLine($"Perros - promedio de edad: {resultado.PromedioSalario}");
                        break;
                    case 2:
                        Console.WriteLine($"Gatos - promedio de edad: {resultado.PromedioSalario}");
                        break;
                    case 3:
                        Console.WriteLine($"Conejos - promedio de edad: {resultado.PromedioSalario}");
                        break;
                }
            }
        }
    }
}
