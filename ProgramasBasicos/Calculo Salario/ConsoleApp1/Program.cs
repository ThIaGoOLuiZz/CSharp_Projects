using System;
using System.Linq;

namespace ProjetoSalario;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Qual o codigo do funcionario?");
        int funcionario = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantas horas foram trabalhadas?");
        int horas = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o valor da hora?");
        double valorHora = double.Parse(Console.ReadLine());

        double salario = valorHora * horas;

        Console.WriteLine($"Numero: {funcionario}");
        Console.WriteLine($"Salario: R$ {salario.ToString("F2")}");

    }
}
