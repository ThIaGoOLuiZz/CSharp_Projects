using CalculoHoraTrabalhadaComposicao.Entities.Enums;
using CalculoHoraTrabalhadaComposicao.Entities;
using System.Globalization;

namespace CalculoHoraTrabalhadaComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior}): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Duratiom (hour): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContrato(contract);
            }

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}\nDepartment: {worker.Department.Name}\nIncome for {monthAndYear}: {worker.Income(year, month)}");
        }
    }
}
