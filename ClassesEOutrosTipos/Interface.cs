using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.ClassesEOutrosTipos
{
    internal class Interface
    {
        public static void Mostrar()
        {
            Console.WriteLine("Interface: ");
            Console.WriteLine();

            // a intereface é utilizada como forma de contrato forte, para obrigar as classes utilizar
            // elas e ter um padrao de contrato estabelecido para melhor desenvolvimento do codigo e segurança

            // aqui temos acesso a o segundo obj dentro da classe
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            // atribuindo uma interface a um obj
            // aqui por conta de atribuir ele, nao conseguimos ter o acesso aos demais produtos,
            // só fica visivel realmente o que esta dentro do contrato
            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();

            Console.WriteLine();
        }
    }
}

namespace Cadastro
{
    /* Usar o I antes do Name para deixar claro que se trata de uma interface
     * essa declaração é considerado um contrato, então todas as classes vao serguir por obrigação essa definição.
     * não é possivel instanciar uma interface, porem da para atribuir um obj para interface
    */
    public interface INotificacao
    {
        string Descricao { get; set; }
        void Notificar();
    }

    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando cliente");
        }
        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros");
        }
    }

    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando cliente");
        }

        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros");
        }
    }

} 