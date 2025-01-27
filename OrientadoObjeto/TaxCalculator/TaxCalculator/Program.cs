using TaxCalculator.Entities;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

namespace TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Taxpayer#{i + 1} data:");

                Console.Write("Individual orcompany(i/c)?: ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, healthExpenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Numberofemployees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, income, numberEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine($"{taxPayer.Name} $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            double total = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                total += taxPayer.Tax();
            }
            Console.WriteLine($"TOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
