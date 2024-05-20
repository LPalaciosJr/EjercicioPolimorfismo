using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo.Clases
{
    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: Guau!");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nombre} está comiendo croquetas.");
        }
    }
}
