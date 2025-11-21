namespace Aulas.Strings
{
    internal class AulaStartsWithEndsWith
    {
        public static void Mostrar()
        {
            Console.WriteLine("StartsWith e EndsWith: ");
            Console.WriteLine();

            var utilizandoStartsWithEndsWith = new DeclaracaoStartsWithEndsWith.UtilizandoStartsWithEndsWith();
            utilizandoStartsWithEndsWith.ImplementandoStartsWithEndsWith();

            Console.WriteLine();
        }
    }
}

namespace DeclaracaoStartsWithEndsWith
{
    public class UtilizandoStartsWithEndsWith
    {
        public void ImplementandoStartsWithEndsWith()
        {
            string teste = "Curso csharp";

            // vai verificar se a palavra inicia com Curso
            Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
            // vai verificar se o final da string contem csharp02
            Console.WriteLine("FINAL: " + teste.EndsWith("csharp02"));
        }

    }
}