using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ClassesEOutrosTipos
{
    internal class Heranca
    {
        public static void Mostrar()
        {
            Console.WriteLine("Herança: ");
            Console.WriteLine();

            var PessoaFisica = new Cadastro.PessoaFisica();
            PessoaFisica.Id = 1;
            PessoaFisica.Endereco = "Endereco Teste";
            PessoaFisica.Cidade = "Cidade Teste";
            PessoaFisica.Cep = "1234456";
            PessoaFisica.CPF = "12345678912";

            PessoaFisica.ImprimirDados();
            PessoaFisica.ImprimirCpf();

            Console.WriteLine();

            var Funcionario = new Cadastro.Funcionario();
            Funcionario.Id = 10;
            Funcionario.Endereco = "Endereco Teste";
            Funcionario.Cidade = "Cidade Teste";
            Funcionario.Cep = "1234456";
            Funcionario.CPF = "98712343721";

            Funcionario.ImprimirDados();
            Funcionario.ImprimirCpf();


            Console.WriteLine();
        }
    }
}

namespace Cadastro
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set;  }
    }
}