using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de repetições:");
            int N = int.Parse(Console.ReadLine());

            for (int X = 1; X <= N; X++)
            {
                Console.WriteLine("Digite dois valores (utilize espaço para separar os numeros)");
                string valores = Console.ReadLine();
                string[] lista = valores.Split(' ');

                double valor1 = double.Parse(lista[0]);
                double valor2 = double.Parse(lista[1]);

                Console.Clear();

                if (valor2 == 0)
                {
                    Console.WriteLine("divisão impossivel");
                }

                Console.WriteLine(valor1 / valor2);
            }
        }
    }
}