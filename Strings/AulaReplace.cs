using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Strings
{
    internal class AulaReplace
    {
        public static void Mostrar()
        {
            Console.WriteLine("Replace: ");
            Console.WriteLine();

            var utilizandoReplace = new DeclaracaoReplace.UtilizandoReplace();
            utilizandoReplace.ImplementandoReplace();

            Console.WriteLine();
        }
    }
}

namespace DeclaracaoReplace
{
    public class UtilizandoReplace
    {
        public void ImplementandoReplace()
        {
            string teste = "Curso Csharp";
            Console.WriteLine(teste);
            // 2 parametros. Primeiro parametro é a palavra que queremos encontrar
            // Segundo parametro substiui pelo novo valor caso encontre a palavra
            Console.WriteLine(teste.Replace("Csharp", "C#"));
        }

    }
}