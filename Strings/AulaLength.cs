using DeclaracaoLength;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Strings
{
    internal class AulaLength
    {
        public static void Mostrar()
        {
            Console.WriteLine("Length: ");
            Console.WriteLine();

            var utilizandoLength = new DeclaracaoLength.UtilizandoLength();
            utilizandoLength.ImplementandoLength();

            Console.WriteLine();
        }
    }
}

namespace DeclaracaoLength
{
    public class UtilizandoLength
    {
        public void ImplementandoLength()
        {
            string teste = Console.ReadLine();
            Console.WriteLine(teste);
            Console.WriteLine(teste.Length + " Caracteres.");
        }

    }
}