using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fora = 0;
            int dentro = 0;

            Console.WriteLine("Digite um numero de repetições: ");
            int N = int.Parse(Console.ReadLine());

            for (int X = 1; X <= N; X++)
            {
                Console.WriteLine("Digite um valor inteiro:");
                int valor = int.Parse(Console.ReadLine());

                if (valor < 10 || valor > 20)
                {
                    fora++;
                }
                else
                {
                    dentro++;
                }

                Console.Clear();
                Console.WriteLine($"Dentro: {dentro}");
                Console.WriteLine($"Fora: {fora}");

            }
        }
    }
}