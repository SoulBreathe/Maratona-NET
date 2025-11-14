using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeDados
{
    internal class ListaGenerica
    {
        public static void Mostrar()
        {
            Console.WriteLine("Lista Generica: ");
            Console.WriteLine();

            /* Recomendado pela Microsoft pois tem muito mais performance
             * em comparação a o arrayList
             * sempre que utilizar coisas genericas fica dentro de <>
             */

            var list = new List<string>(10)
            {
                "Bola",
                "Futebol",
                "Anime"
            };

            /*
            list.Add("Rafael");
            list.Add("Richard");
            list.Add("Curso");
            */

            // Remove da mesma forma que o clear no arrayList
            list.RemoveAt(1);

            var nome = list[0];
            Console.WriteLine(nome);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
