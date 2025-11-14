using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeControle
{
    internal class ForAula
    {
        public static void Mostrar()
        {
            Console.WriteLine("For: ");
            Console.WriteLine();

            var lista = new List<string>() { "Richard", "Curso", "Csharp" };
            var count = lista.Count;

            for(var i =0;i < lista.Count; i++)
            {
                var nome = lista[i];
                Console.WriteLine(nome);
            }

            Console.WriteLine();    
        }
    }
}
