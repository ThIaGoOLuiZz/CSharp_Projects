using System;
using System.Diagnostics;
using System.Globalization;

namespace Segundo;

internal class Program
{
    static void Main(string[] args)
    {
        
        //INPUT PARA STRING
        Console.WriteLine("Entre com seu nome completo:");
        string nome = Console.ReadLine();

        //INPUT PARA NUMERO INTEIRO
        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quartos = int.Parse(Console.ReadLine());

        //INPUT PARA NUMERO DOUBLE
        Console.WriteLine("Entre com o preço de um produto:");
        double preco = double.Parse(Console.ReadLine());

        //INPUT PARA SPLIT DE VALORES
        Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
        string[] vetor = (Console.ReadLine().Split(' '));

        Console.WriteLine(nome);
        Console.WriteLine(quartos);
        Console.WriteLine(preco.ToString("F2"));
        Console.WriteLine(vetor[0]);
        Console.WriteLine(int.Parse(vetor[1]));
        Console.WriteLine(double.Parse(vetor[2]). ToString("F2"));








    }
}