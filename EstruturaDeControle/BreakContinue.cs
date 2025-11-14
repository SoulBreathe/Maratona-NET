using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeControle
{
    internal class BreakContinue
    {
        public static void Mostrar()
        {
            Console.WriteLine("Break/Continue: ");
            Console.WriteLine();

            var i = 0;
            while (i < 1)
            {
                if(i < 2)
                {
                    Console.WriteLine("Continuando...");
                    i++;
                    continue;
                }

                i++;
                Console.WriteLine(i);

                if(i == 2)
                {
                    Console.WriteLine("Valor de i é igual a 2");
                    break;
                }
                
            }

            Console.WriteLine();
        }
    }
}
