using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ClassesEOutrosTipos
{
    internal class ClasseAbstrata
    {
        public static void Mostrar()
        {
            /* Classe abstrada ela não pode ser instanciada, nao pode usar o modificador new, 
             * o unico proposito de servir de superclasse para subclasses implemente de forma concreta
             * o que foi definido na classe abstrada, uma das vantagens é a capacidade de reutilização de codigo
             */
            Console.WriteLine("Classe Abstrada: ");
            Console.WriteLine();

            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Loop";
            cachorro.ImprimirDados();


            Console.WriteLine();
        }
    }
}

namespace Cadastro
{
    public abstract class Animal
    {
        public string Nome {  get; set; }

        public abstract string GetIformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome animal: " + Nome);
            Console.WriteLine("Informacoes: " + GetIformacoes());
        }
    }

    public class Cachorro : Animal
    {
        public override string GetIformacoes()
        {
            return "Cachorro é um bom amigo";
        }
    }
}