namespace CalculoImpostoFuncionario_class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();

            Console.Write("Digite seu nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite seu salario bruto: ");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o imposto: ");
            funcionario1.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Funcionario: " + funcionario1);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine()) / 100;

            funcionario1.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario1);
        }
    }
}