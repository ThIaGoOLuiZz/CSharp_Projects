using System.Globalization;

namespace CalculoMedioArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de valores: ");
            int x = int.Parse(Console.ReadLine());

            double[] valores = new double[x];

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o valor da {i + 1}ª pessoa: ");
                valores[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double total = 0.0;
            for (int i = 0;i < valores.Length; i++)
            {
                total += valores[i];
            }

            Console.WriteLine($"Média: {(total / x).ToString("F2")}");
        }
    }
}
