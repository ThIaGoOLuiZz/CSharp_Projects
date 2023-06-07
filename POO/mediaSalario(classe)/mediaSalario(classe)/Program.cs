namespace mediaSalario_classe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.Write("Digite o nome do primeiro funcionario: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do primeiro funcionario: ");
            pessoa1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite o nome do segundo funcionario: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do segundo funcionario: ");
            pessoa2.salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"A media dos salarios é de: R${Media(pessoa1.salario, pessoa2.salario)}");

        }
        public static double Media(double a, double b) {
            return (double)(a + b) / 2;    
        }
    }

}