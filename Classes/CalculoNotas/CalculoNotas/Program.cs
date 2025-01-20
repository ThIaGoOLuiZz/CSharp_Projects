using System.Globalization;

namespace CalculoNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");

            Console.Write("Nota 1: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 3: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.CalculoNota();

            Console.WriteLine($"NOTA FINAL: {notaFinal.ToString("F2")}");

            Console.WriteLine(aluno.ValidaNota(notaFinal));
        }
    }
}
