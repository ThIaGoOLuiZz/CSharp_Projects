using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de repetições:");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite 3 valores com uma casa decimal (utilize espaço para separar os valores!):");
                string valor = Console.ReadLine();
                string[] lista = valor.Split(' ');

                double valor1 = double.Parse(lista[0]);
                double valor2 = double.Parse(lista[1]);
                double valor3 = double.Parse(lista[2]);

                Console.WriteLine($"A média dos valores é de: {((valor1 + valor2 + valor3)/3).ToString("F1")}");
            }
        }
    }
}