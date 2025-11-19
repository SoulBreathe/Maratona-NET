using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Strings
{
    internal class AulaToLower
    {
        public static void Mostrar()
        {
            Console.WriteLine("ToLower: ");
            Console.WriteLine();

            var trabalhandoComStrings = new ConverterMinusculo.TrabalhandoComMinusculas();
            trabalhandoComStrings.ConverterParaLetrasMinusculas();

            Console.WriteLine();
        }
    }
}

namespace ConverterMinusculo
{
    public class TrabalhandoComMinusculas
    {
        public void ConverterParaLetrasMinusculas()
        {
            Console.Write("Favor digitar alguma informação: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha.ToLower());
        }
    }
}