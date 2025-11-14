using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeDados
{
    internal class ArrayTipado
    {
        public static void Mostrar()
        {
            Console.WriteLine("Array Tipado: ");
            Console.WriteLine();

            // Declaraçao de um array tipado que só aceita numeros:
            var arrayTipadoNumero = new int[3] { 1, 2, 3, };

            // Dessa forma alteramos o valor do array
            arrayTipadoNumero[2] = 10;

            // Essa função aumenta o tamanho do array, por defaut os valores atribuidos é 0
            Array.Resize(ref arrayTipadoNumero, 100);

            foreach(var item in arrayTipadoNumero )
            {
                Console.WriteLine(item);
            }

            // Declaraçao de um array tipado String
            var arrayTipadoString = new string[2] { "Richard", "Martins" };

            foreach (var item in arrayTipadoString)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
