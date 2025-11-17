using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ClassesEOutrosTipos
{
    internal class Record
    {
        public static void Mostrar()
        {
            /* o record veio para facilitar a comparaçao de valores instanciados.
             * 
             */

            Console.WriteLine("Record: ");
            Console.WriteLine();

            // Com a classe
            // var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
            // var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };

            // Com record 
            var curso1 = new Cadastro.Curso(1, "Curso");
            var curso2 = curso1 with { Descricao = "Teste Novo" };

            // Aqui estou atribuindo uma descrição nova o que faz com que print o novo valor em ambos
            //var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
            //var curso2 = curso1;
            //curso2.Descricao = "TESTE TESTE";


            /* Aqui eu crio uma instancia nova
             
            var curso2 = new Cadastro.CursoTeste();
            curso2.Id = curso1.Id;
            curso2.Descricao = "Nova descricao";

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);
            */

            // Console.WriteLine(curso1 == curso2);
            // Mesmo comparando dessa forma, vai retornar false, por isso utilizar record
            // Console.WriteLine(curso1.Equals(curso2));

            Console.WriteLine();
        }
    }
}


namespace Cadastro
{
    // instanciando dessa forma, nao podemos alterar os valores 
    public record Curso(int Id, string Descricao);

    public class CursoTeste
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

    /*
     
    public record Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

    }

    */


    /*
     
    public class Curso
    {
        // Prop + enter gera a linha MyProperty

        public int Id { get; set; }
        public string Descricao { get; set; }

        // Fazer comparação em 2 obj 
         
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;

            if(obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }

            return base.Equals(obj);
        }

        public static bool operator == (Curso a, Curso b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Curso a, Curso b)
        {
            return !(a == b);
        }
        
    }

    */

    // utilizando o Record 
}

