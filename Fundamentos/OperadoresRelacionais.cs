using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Mostrar()
        {
            Console.WriteLine("Operadores Relacionais: ");
            Console.WriteLine();

            int num1 = 2;
            int num2 = 1;

            bool igual = num1 == num2;
            bool maior = num1 > num2;
            bool menor = num1 < num2;
            bool maiorIgual = num1 >= num2;
            bool menorIgual = num1 <= num2;
            bool diferente = num1 != num2;


            Console.WriteLine($"Resultado Igualdade: {igual}");
            Console.WriteLine($"Resultado Maior: {maior}");
            Console.WriteLine($"Resultado Menor: {menor}");
            Console.WriteLine($"Resultado Maior ou Igual: {maiorIgual}");
            Console.WriteLine($"Resultado Menor ou Igual: {menorIgual}");
            Console.WriteLine($"Resultado Diferente: {diferente}");
            Console.WriteLine();
        }
    }
}