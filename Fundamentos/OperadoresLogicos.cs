using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Mostrar()
        {
            Console.WriteLine("Operadores Logicos: ");
            Console.WriteLine();

            int num1 = 2;
            int num2 = 3;

            bool valido = num2 > num1 && 8 > 7;
            bool valido2 = num2 > num1 || 8 > 7;
            bool valido3 = !(num2 > 10);

            Console.WriteLine($"Resultado And: {valido}");
            Console.WriteLine($"Resultado Or: {valido2}");
            Console.WriteLine($"Resultado NOT: {valido3}");
            Console.WriteLine();
        }
    }
}