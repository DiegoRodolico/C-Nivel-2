using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Animal> animales = new List<Animal>();

            //animales.Add(new Pez());
            //animales.Add(new Gato());
            //animales.Add(new Leon());
            //animales.Add(new Aguila());
            //animales.Add(new Perro());
            //animales.Add(new Perro());

            //foreach (Animal item in animales)
            //{

            //    Console.WriteLine(item.comunicarse());

            //}
            List<Volable_puede_volar_> voladores = new List<Volable_puede_volar_>();
            voladores.Add(new Aguila());
            voladores.Add(new Canario());

          

            Console.ReadKey();
        }
    }
}
