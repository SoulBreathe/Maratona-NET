using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Strings
{
    internal class AulaRange
    {
        public static void Mostrar()
        {
            Console.WriteLine("Range: ");
            Console.WriteLine();

            var utilizandoRange = new DeclaracaoRange.UtilizandoRange();
            utilizandoRange.ImplementandoRange();

            Console.WriteLine();
        }
    }
}

namespace DeclaracaoRange
{
    public class UtilizandoRange
    {
        public void ImplementandoRange()
        {

            string nomeArquivo = "2022_12_01_backup.bak";
            // aqui ele vai pegar os primeiros 4 caracteres
            var ano = nomeArquivo[..4];
            Console.WriteLine(ano);
            // aqui ele vai pegar os ultimos 3 caracteres
            var extensao = nomeArquivo[^3..];
            Console.WriteLine(extensao);
            // aqui ele vai pegar os caracteres a partir 11 e deletar os utilmos 4 caracteres
            var nome = nomeArquivo[11..^4];
            Console.WriteLine(nome);
            // aqui ele pega todo o nome, menos a extensao do arquivo
            var ApenasNome = nomeArquivo[..^4];
            Console.WriteLine(ApenasNome);

        }
    }
}