using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Strings
{
    internal class AulaToUpper
    {
        public static void Mostrar()
        {
            Console.WriteLine("ToUpper: ");
            Console.WriteLine();

            var trabalhandoComStrings = new ConverterMinusculo.TrabalhandoComMaiusculas();
            trabalhandoComStrings.ConverterParaLetrasMaiusculas();

            Console.WriteLine();
        }
    }
}

namespace ConverterMinusculo
{
    public class TrabalhandoComMaiusculas
    {
        public void ConverterParaLetrasMaiusculas()
        {
            Console.Write("Favor digitar alguma informação: ");
            var linha = Console.ReadLine();
            Console.WriteLine(linha.ToUpper());
        }
    }
}
