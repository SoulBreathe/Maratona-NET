using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.EstruturaDeControle
{
    internal class SwitchAula
    {
        public static void Mostrar()
        {
            Console.WriteLine("Switch: ");
            Console.WriteLine();
            // quando tu vai tratar uma unica entrada de dados.

            var diaDaSemana = 0;

            switch(diaDaSemana)
            {
                case 0:
                    Console.WriteLine("Hoje é domingo");
                    break;
                case 1:
                    Console.WriteLine("Hoje é segunda");
                    break;
                case 2:
                    Console.WriteLine("Hoje é terça");
                    break;
                case 3:
                    Console.WriteLine("Hoje é quarta");
                    break;
                case 4:
                    Console.WriteLine("Hoje é quinta");
                    break;
                case 5:
                    Console.WriteLine("Hoje é sexta");
                    break;
                case 6:
                    Console.WriteLine("Hoje é sabado");
                    break;
                default:
                    Console.WriteLine("Dia da semana Invalido");
                    break;
            }

            Console.WriteLine();
        }
    }
}
