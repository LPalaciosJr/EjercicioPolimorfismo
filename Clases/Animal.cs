using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo.Clases
{
    public class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }

        public virtual void Comer()
        {
            Console.WriteLine($"{Nombre} está comiendo.");
        }
    }
}
