using ProdutoMaisCaroGenerics.Entities;
using ProdutoMaisCaroGenerics.Services;
using System.Globalization;

namespace ProdutoMaisCaroGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                Product product = new Product(name, price);

                list.Add(product);
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max: " + max);
        }
    }
}
