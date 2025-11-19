using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ConversoresDeValor
{
    internal class TryParse
    {
        public static void Mostrar()
        {
            Console.WriteLine("Try Parse: ");
            Console.WriteLine();

            var conversores2 = new Conversores2.Conversor2();
            conversores2.AulaTryparse();

            Console.WriteLine();
        }
    }
}

namespace Conversores2
{
    public class Conversor2
    {
        public void AulaTryparse()
        {
            var numero = "123456";
            // tryparse ele devolve um bool, por isso usamos o if.
            if (int.TryParse(numero, out int numeroConvertido))
            {
                Console.WriteLine("Numero foi convertido com sucesso!");
            }

            Console.WriteLine(numeroConvertido);
        }
    }
}