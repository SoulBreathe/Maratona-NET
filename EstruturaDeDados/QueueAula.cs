using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeDados
{
    internal class QueueAula
    {
        public static void Mostrar()
        {
            Console.WriteLine("Queue: ");
            Console.WriteLine();
            /* Queue ou fila, fornece varias estruturas de dados que fornece uma logica
             * especifica, Fist-in Fist-Out (FIFO) o primeiro intem que entra é o primeiro
             * a sair da lista.
             */

            var queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");

            // Ele traz o primeiro que vai sair da fila
            var nome = queue.Peek();
            // para desenpilhar o item da fila 
            var nome1 = queue.Dequeue();

            Console.WriteLine(nome);
            Console.WriteLine(nome1);

            /*
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            */

            Console.WriteLine();
        }
    }
}
