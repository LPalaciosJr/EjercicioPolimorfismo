using EjercicioPolimorfismo.Clases;
using System;
using System.Collections.Generic;

namespace EjercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Animal> animales = new List<Animal>
            {
                new Perro("Rex"),
                new Gato("Michi"),
                new Perro("Fido")
            };

            foreach (Animal animal in animales)
            {
                animal.HacerSonido();
                animal.Comer();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
