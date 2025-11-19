using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ConversoresDeValor
{
    internal class ConvertParse
    {
        public static void Mostrar()
        {
            Console.WriteLine("Convert Parse: ");
            Console.WriteLine();

            // por boas praticas usar o int.Parse pois é mais otimizado que o convert 

            var conversores = new Conversores.Conversor();
            conversores.ConvertAndParse();

            Console.WriteLine();

        }
    }
}

namespace Conversores
{
    public class Conversor
    {
        public void ConvertAndParse()
        {
            // int numero = int.Parse("1");
            // int numero = Convert.ToInt32(null);
            // int numero = int.Parse(null);
            bool verdadeiro = bool.Parse("true");
            Console.WriteLine(verdadeiro);
        }
    }
}