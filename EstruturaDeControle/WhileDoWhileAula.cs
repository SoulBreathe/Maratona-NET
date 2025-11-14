using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeControle
{
    internal class WhileDoWhileAula
    {
        public static void Mostrar()
        {
            Console.WriteLine("While/DoWhile: ");
            Console.WriteLine();

            var i = 0;
            while(i < 1)
            {
                i++;
                Console.WriteLine(i);
            }

            // executa o codigo e depois ele valida
            var j = 0;
            do
            {
                j++;
                Console.WriteLine(j);
            } while (j < 1);

            Console.WriteLine();
        }
    }
}
