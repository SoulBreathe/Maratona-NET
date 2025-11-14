using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeDados
{
    internal class Dicionario
    {
        public static void Mostrar()
        {
            Console.WriteLine("Dicionario: ");
            Console.WriteLine();
            /* essa estrutura recebe 2 parametros (chave e valor) 
             * nao permite duplicidade de chave
             */

            var dicionario1 = new Dictionary<int, string>();

            // Formas de adicionar 
            var dicionario = new Dictionary<int, string>()
            {
                {5, "Teste" },
                {8, "Teste" }
            };
            
            dicionario.Add(2, "Richard");
            dicionario[50] = "Curso";

            // acessando a Key, no caso é o valor dentro do dicionario e nao o index
            //var nome = dicionario[];
            //Console.WriteLine(nome);

            foreach (var item in dicionario)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine();
        }
    }
}
