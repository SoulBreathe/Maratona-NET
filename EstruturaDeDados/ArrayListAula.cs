

using System.Collections;

namespace Aulas.EstruturaDeDados
{
    internal class ArrayListAula
    {
        public static void Mostrar()
        {
            Console.WriteLine("Array List :");
            Console.WriteLine();

            //  var arrayList = new ArrayList(); está errado pois não existe um metodo Add no c#
            // A forma de declarar corretamente é essa
            var arrayList = new System.Collections.ArrayList();

            arrayList.Add(1); // 0
            arrayList.Add("Richard"); // 1
            arrayList.Add(true); // 2

            // arrayList.RemoveAt(1); // remover 1 item da lista
            // arrayList.Clear(); // remover todos os array

            foreach (var item in arrayList) { 
                Console.WriteLine(item);
            }

            // Console.WriteLine(arrayList[1]); // Acesso por indice
            Console.WriteLine();
        }
    }
}
