using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Fundamentos
{
    internal class Variaveis
    {
        public static void Mostrar()
        {

            Console.WriteLine("Variaveis: ");
            Console.WriteLine();

            int idade = 23;
            String nomePessoa = "Marcelo";
            decimal valor = 200.99m;
            double valorDouble = 15.43;
            float valorFloat = 20.55f;
            char flag = 'Y';
            bool ativo = false;


            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Nome: {nomePessoa}");
            Console.WriteLine($"Valor Decimal: {valor}");
            Console.WriteLine($"Valor Double: {valorDouble}");
            Console.WriteLine($"Valor Float: {valorFloat}");
            Console.WriteLine($"Char: {flag}");
            Console.WriteLine($"Ativo: {ativo}");
            Console.WriteLine();
        }

    }

}