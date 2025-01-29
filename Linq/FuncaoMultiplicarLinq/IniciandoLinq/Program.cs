using System.Globalization;
using System.Linq;

namespace FuncaoMultiplicarLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {2,3,4,5}; //Especificação da origem dos dados

            var result = numbers //Definindo a expressão de consulta
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            foreach (int x in result) //Executando a consulta
            {
                Console.WriteLine(x);
            }
        }
    }
}
