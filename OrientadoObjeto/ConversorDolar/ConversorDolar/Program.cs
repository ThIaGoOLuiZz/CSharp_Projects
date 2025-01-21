using System.Globalization;

namespace ConversorDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do Dólar?: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago: " + ConversorDeMoedas.CalculaConversao(cotacao, valor).ToString("F2"));
        }
    }
}
