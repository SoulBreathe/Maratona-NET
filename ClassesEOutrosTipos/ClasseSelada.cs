using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ClassesEOutrosTipos
{
    internal class ClasseSelada
    {
        public static void Mostrar()
        {
            /* Classe selada nao tem a possibilidade de ser herdada.
             * a principal vantagem é nao permitir que nenhuma outra classe consiga herdar e ela fique totalmente unica,
             * porem tu pode instanciar em qualquer lugar do codigo
             */
            Console.WriteLine("Herança: ");
            Console.WriteLine();

            /*
            var configuracao = new Cadastro.Configuracao();
            configuracao.Host = "localhost";
             */

            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);

            Console.WriteLine();
        }
    }
}


namespace Cadastro
{
    // sealed palavra reservada para classe selada
    public sealed class Configuracao
    {
        public string Host { get; set; }
    }
}