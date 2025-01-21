using System.Globalization;

namespace AumentoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite os dados do funcionario: ");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionario: {funcionario.Nome}, ${funcionario.SalarioLiquido().ToString("F2")}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumento do salário: ");
            funcionario.AumentoSalarial(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {funcionario.Nome}, ${funcionario.SalarioLiquido().ToString("F2")}");

        }
    }
}
