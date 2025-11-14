using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Fundamentos
{
    internal class Constantes
    {
        public static void Mostrar()
        {
            /* Diferença entre const e var:
            * A const não tem como alterar o valor em outra parte do codigo,
            * pois o valor dela ja foi atribuido a variavel.
            */

            Console.WriteLine("Constante: ");
            Console.WriteLine();

            const string descrição = "Curso C-SHARP";

            Console.WriteLine($"Curso: {descrição}");

            Console.WriteLine();
        }
    }
}