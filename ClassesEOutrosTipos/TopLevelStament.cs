using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ClassesEOutrosTipos
{
    internal class TopLevelStament
    {
        public static void Mostrar()
        {
            /* O Top level stament foi feito no dotnet 6 para facilitar a inicialização de programas,
             * antes tinha uma estrutura bem definida e agora podemos só colocar um print na tela. 
             * Não é permitido ter mais de um ponto de entrada.
             */

            // Console.WriteLine("Primeiro Programa");

            /* O namespace é para separar o codigo por nomes e arquivos de forma que tu possa utilizar
             * classes separadas para cada coisa, como no exemplo abaixo, tu pode ter duas classes iguais
             * contanto que o namespace seja diferente. 
             */

        }
    }
}

// Antes era dessa forma, essa estrutura pertence ao program.cs 

/*
namespace Exemplo
{
    public class Inicializar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/

/* Exemplo 1:
 
namespace Cadastro
{
    public class Cliente
    {

    }

    public class Funcionario
    {

    }
}
*/


/* Exemplo 2:
 
namespace Financeiro
{
    public class ContasReceber{

    }

    public class Funcionario { 
    }
}
*/
