using EtiquetasProdutos.Entities;
using System.Globalization;

namespace EtiquetasProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();


            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            string name;
            double price;
            double customFee;
            DateTime manufactureDate;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Common, used or imported? (c/u/i): ");
                string type = Console.ReadLine();

                switch(type.ToLower())
                {
                    case "c": //Common
                        Console.Write("Name: ");
                        name = Console.ReadLine();

                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Product product = new Product(name, price);

                        products.Add(product);
                        break;

                    case "i": //Imported
                        Console.Write("Name: ");
                        name = Console.ReadLine();

                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Custom Fee: ");
                        customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        ImportedProduct importedProduct = new ImportedProduct(name, price, customFee);

                        products.Add(importedProduct);
                        break;

                    case "u":
                        Console.Write("Name: ");
                        name = Console.ReadLine();

                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Manufacture date (dd/MM/yyyy): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        UsedProduct usedproduct = new UsedProduct(name, price, date);
                        products.Add(usedproduct);
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAG: ");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
