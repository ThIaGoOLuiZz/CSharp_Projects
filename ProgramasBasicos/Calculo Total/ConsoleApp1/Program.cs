using System;
using System.Linq;

namespace ProjetoCalculoTotal;

public static class Program
{
    public static void Main()
    {
        //VALOR 1

        //input dos dados
        Console.WriteLine("Qual o codigo da peça, numero de pecas e valor de cada peça? (utilize espaços para separar os valores)");
        string valores1 = Console.ReadLine();

        string[] lista1 = valores1.Split(' ');

        int codigo1 = int.Parse(lista1[0]);
        int qtdPeca1 = int.Parse(lista1[1]);
        double valor1 = double.Parse(lista1[2]);

        double total1 = valor1 * qtdPeca1;

        Console.Clear();

        //VALOR 2


        //input dos dados
        Console.WriteLine("Qual o codigo da peça, numero de pecas e valor de cada peça? (utilize espaços para separar os valores)");
        string valores2 = Console.ReadLine();

        String[] lista2 = valores2.Split(' ');

        int codigo2 = int.Parse(lista2[0]);
        int qtdPeca2 = int.Parse(lista2[1]);
        double valor2 = double.Parse(lista2[2]);

        double total2 = valor2 * qtdPeca2;

        Console.Clear();



        Console.WriteLine($"VALOR A PAGAR: R${(total1 + total2).ToString("F2")}");




    }
}
