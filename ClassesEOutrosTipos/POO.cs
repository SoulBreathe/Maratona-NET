using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ClassesEOutrosTipos
{
    internal class POO
    {
        public static void Mostrar()
        {
            // Pilares do Poo polimorfismo, herança, abstração e encapsulamento

            /* Herança: capacidade de um objeto herdar comportamentos e atributos de outro objeto.
             * 
             * Encapsulamento: tem como premissa proteger atributos/propriedades de uma classe,
             * fazendo com que as aterações sejam feitas apenas por metodos definidos na propria classe.
             * 
             * Abstração: define um contrato que pode nao possuir nenhum tipo de inteligencia,
             * porem a classe que implementa o contrato tem o dever de implementar o que deve ser feito.
             * 
             * Polimorfismo: fornece a capacidade de herdar metodos da classe pai e sobrescrever seu comportamento.
             */

            // Exemplo Polimorfismo: 

            // Classe: Animal
            // void Comer() => Console.WriteLine("Animal Comendo");

            // Cachorro: Animal
            // Override void Comer() => Console.WriteLine("Cachorro Comendo");

            // Girafa: Animal
            // Override void Comer() => Console.WriteLine("Cachorro Comendo");
        }
    }
}
