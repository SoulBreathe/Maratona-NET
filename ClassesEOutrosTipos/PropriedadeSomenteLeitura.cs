using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ClassesEOutrosTipos
{
    internal class PropriedadeSomenteLeitura
    {
        public static void Mostrar()
        {
            Console.WriteLine("Propriedade Somente Leitura: ");
            Console.WriteLine();

            var Produtos = new Cadastro.Produtos();
            Produtos.Descricoes = "Mouse";
            // Produto.Estoque = 1;
            Console.WriteLine(Produtos.Estoque);

            
            Console.WriteLine();

        }
    }
}

namespace Cadastro
{
    public class Produtos
    {
        private int Id;

        public string Descricoes { get; set; }

        public int Estoque { get; }
        
        // public readonly int Estoque;

        public Produtos()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + Descricoes);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }
}