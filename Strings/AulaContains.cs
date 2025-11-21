using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Strings
{
    internal class AulaContains
    {
        public static void Mostrar()
        {
            Console.WriteLine("Contains: ");
            Console.WriteLine();

            var utilizandoContains = new DeclaracaoContains.UtilizandoContains();
            utilizandoContains.ImplementandoContains();


            Console.WriteLine();
        }
    }
}


namespace DeclaracaoContains
{
    public class UtilizandoContains
    {
        public void ImplementandoContains()
        {
            string nomeArquivo = "2022_12_01_backup.bak";

            if(nomeArquivo.Contains("backup"))
            {
                Console.WriteLine("Palavra encontrada");
            }
            else
            {
                Console.WriteLine("Palavra não encontrada");
            }

            // Console.WriteLine("Contem nome: " + nomeArquivo.Contains("backup"));
        }
    }
}
