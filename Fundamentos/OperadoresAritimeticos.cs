using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Fundamentos
{
    internal class OperadoresAritimeticos
    {
        public static void Mostrar()
        {
            Console.WriteLine("Operadores Aritimeticos: ");
            Console.WriteLine();

            int num1 = 2;
            int num2 = 4;

            int soma = num1 + num2;
            int subtracao = num1 - num2;
            int multiplicacao = (num1 * num2) * 10;
            int divisao = num1 / num2;
            int resto = num1 % num2;

            Console.WriteLine($"Resultado Soma: {soma}");
            Console.WriteLine($"Resultado Subtraçao: {subtracao}");
            Console.WriteLine($"Resultado Multiplicaçao: {multiplicacao}");
            Console.WriteLine($"Resultado Divisao: {divisao}");
            Console.WriteLine($"Resultado Resto: {resto}");
            Console.WriteLine();
        }
    }
}