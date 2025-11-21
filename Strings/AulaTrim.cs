namespace Aulas.Strings
{
    internal class AulaTrim
    {
        public static void Mostrar()
        {
            Console.WriteLine("Trim: ");
            Console.WriteLine();

            var utilizandoTrim = new DeclaracaoTrim.UtilizandoTrim();
            utilizandoTrim.ImplementandoTrim();

            Console.WriteLine();
        }
    }
}

namespace DeclaracaoTrim
{
    public class UtilizandoTrim
    {
        public void ImplementandoTrim()
        {
            string teste = "**Richard Martins**";

            // se nao passar nada para o metodo ele vai eliminar os caracteres vazios
            Console.WriteLine("TOTAL: " + teste.Trim('*'));
            // Dessa forma elimina os caracteres do inicio 
            Console.WriteLine("INICIO: " + teste.TrimStart('*'));
            // Dessa forma elimina os caracteres do final 
            Console.WriteLine("FINAL: " + teste.TrimEnd('*'));
        }

    }
}