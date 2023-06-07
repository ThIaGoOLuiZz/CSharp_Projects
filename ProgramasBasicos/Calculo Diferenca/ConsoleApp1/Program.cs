using System;
using System.Linq;

namespace ProjetoCalculoDiferenca;

public static class Program
{
    public static void Main()
    {
        //Atribuir valor A
        Console.WriteLine("Valor do produto A:");
        double valorA = double.Parse(Console.ReadLine());

        //Atribuir valor B
        Console.WriteLine("Valor do produto B:");
        double valorB = double.Parse(Console.ReadLine());

        //Atribuir valor C
        Console.WriteLine("Valor do produto C:");
        double valorC = double.Parse(Console.ReadLine());

        //Atribuir valor D
        Console.WriteLine("Valor do produto A:");
        double valorD = double.Parse(Console.ReadLine());

        Console.WriteLine($"A diferença entre os produtos é de: {(valorA * valorB) - (valorC * valorD)}");




    }
}
