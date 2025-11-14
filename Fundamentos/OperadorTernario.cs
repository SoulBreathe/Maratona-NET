using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Mostrar()
        {
            Console.WriteLine("Operador Ternario: ");
            Console.WriteLine();
            bool ativo = true;
            string status = ativo ? "cadastro Ativo" : "Cadastro Inativo";
            Console.WriteLine($"Cadastro: {status}");
            Console.WriteLine();
        }
    }
}