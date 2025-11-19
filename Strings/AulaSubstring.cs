using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Strings
{
    internal class AulaSubstring
    {
        public static void Mostrar()
        {
            Console.WriteLine("Substring: ");
            Console.WriteLine();

            var trabalhandoComSubstring = new AulaaSubstring.TrabalhandoComSubstring();
            trabalhandoComSubstring.ExemploSubstring();

            Console.WriteLine();
        }
    }
}

namespace AulaaSubstring
{
    public class TrabalhandoComSubstring
    {
        public void ExemploSubstring()
        {
            Console.Write("Favor digitar alguma informação: ");
            var linha = Console.ReadLine();
            // No caso eu limito o numero de caracteres que vai ser entregue 
            // 0 é o inicio como um array e 6 é o ultimo item ele vai devolver sem o ultimo caractere ou palavra e etc
            Console.WriteLine(linha.Substring(0,6));
        }
    }
}