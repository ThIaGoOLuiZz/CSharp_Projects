using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIgite um numero inteiro:");
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("O valor digitado é Par!");
            }
            else
            {
                Console.WriteLine("O valor digitado é impar!");
            }
        }
    }
}