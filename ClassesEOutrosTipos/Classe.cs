using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Aulas.ClassesEOutrosTipos
{
    internal class Classe
    {
        public static void Mostrar()
        {
            Console.WriteLine("Classe: ");
            Console.WriteLine();

            var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
            Console.WriteLine(resultado);

            var produto = new Cadastro.Produto();
            produto.Descricao = "Teclado";
            produto.SetId(1);

            produto.ImprimirDescricao();

            Console.WriteLine();

        }
    }
}

namespace Cadastro
{
    // Se a classe nao é static tem que instanciar a classe antes de utilizar, ja a static nao é preciso.
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }


    public class Produto
    {
        private int Id;

        public string Descricao { get; set; }

        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + Descricao);
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