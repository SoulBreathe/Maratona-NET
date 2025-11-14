using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Fundamentos
{
    internal class Comentarios
    {
        public static void Mostrar()
        {

            Console.WriteLine("Tipos de comentarios: ");
            Console.WriteLine();
            Console.WriteLine("// cometario de apenas uma linha");
            Console.WriteLine("/* */ comentario de multiplas linhas");
            Console.WriteLine("/// <summary> /// </summary> isso vai abrir um sumario");
            Console.WriteLine();
        }
    }
}