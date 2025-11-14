using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeControle
{
    internal class IfElse
    {
        public static void Mostrar()
        {
            Console.WriteLine("Estrutura de Condicionais: ");
            Console.WriteLine();
            /*
             
            var diaDaSemana = 0;
            var diaDeTrabalho = false;

            if(diaDaSemana == 0 && diaDeTrabalho)
            {
                Console.WriteLine("Hoje é domingo");
            }
            else if(diaDaSemana == 0 && diaDeTrabalho == false)
            {
                Console.WriteLine("Hoje é domingo, mas nao é dia de trabalho.");
            }
            else
            {
                Console.WriteLine("Hoje não é domingo");
            }

            */

            var diaDaSemana1 = 6;

            if(diaDaSemana1 == 0)
            {
                Console.WriteLine("Hoje é domingo");
            }
            else if(diaDaSemana1 == 1)
            {
                Console.WriteLine("Hoje é Segunda");
            }
            else if (diaDaSemana1 == 2)
            {
                Console.WriteLine("Hoje é Terça");
            }
            else if (diaDaSemana1 == 3)
            {
                Console.WriteLine("Hoje é Quarta");
            }
            else if (diaDaSemana1 == 4)
            {
                Console.WriteLine("Hoje é Quinta");
            }
            else if (diaDaSemana1 == 5)
            {
                Console.WriteLine("Hoje é Sexta");
            }
            else if (diaDaSemana1 == 6)
            {
                Console.WriteLine("Hoje é Sabado");
            }
            else
            {
                Console.WriteLine("Dia da semana invalido");
            }

            Console.WriteLine();
        }
    }
}
