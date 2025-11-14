using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Funcao
{
    internal class Funcao
    {
        public static void Mostrar()
        {
            Console.WriteLine("Função: ");
            Console.WriteLine();

            var nome = NomeCompleto;
            var soma = SomarValores;

            string NomeCompleto()
            {
                string primeiroNome = "Richard";
                string segundoNome = "Martins";

                return primeiroNome + " " + segundoNome;
            }

            int SomarValores()
            {
                return 8 + 2;
            }

            Console.WriteLine($"Nome : {nome()}");
            Console.WriteLine($"Soma : {soma()}");
            Console.WriteLine();
        }
    }
}