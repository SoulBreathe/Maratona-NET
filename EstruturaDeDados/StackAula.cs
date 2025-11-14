using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeDados
{
    internal class StackAula
    {
        public static void Mostrar()
        {
            Console.WriteLine("Stack: ");
            Console.WriteLine();
            /* stack ou pilha, ela impleta a logica lifo last-in first-out,
             * o ultimo a entrar sera o primeiro a sair 
            */

            var stack = new Stack<string>();
            
            // forma de empilhar dados
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            // o pop desenpilha 
            var nome = stack.Pop();
            var nome1 = stack.Pop();

            Console.WriteLine(nome);
            Console.WriteLine(nome1);

            
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
