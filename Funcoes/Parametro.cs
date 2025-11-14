using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Funcoes
{
    internal class Parametro
    {
        public static void Mostrar()
        {
            Console.WriteLine("Parametro: ");
            Console.WriteLine();

            var soma = SomarValores(3, 5);
            var nome = NomeEIdade("nome", 26);

            int SomarValores(int a, int b)
            {
                return a + b;
            }

            string NomeEIdade(string nome, int idade)
            {
                return "Meu nome é " + nome + " e tenho " + idade + " anos.";
            }

            Console.WriteLine($"Resultado : {soma}");
            Console.WriteLine();
        }
    }
}