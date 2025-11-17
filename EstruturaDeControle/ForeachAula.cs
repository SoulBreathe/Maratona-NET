using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeControle
{
    internal class ForeachAula
    {
        public static void Mostrar()
        {
            Console.WriteLine("Foreach: ");
            Console.WriteLine();

            var lista = new List<string>() { "Richard", "Curso", "Csharp" };

            /*
            foreach(string item in lista)
            {
                Console.WriteLine(item); 
            }
            */

            foreach(var letra in "Richard Martins")
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine();
        }
    }
}
