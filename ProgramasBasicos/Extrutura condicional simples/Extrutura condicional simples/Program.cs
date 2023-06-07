using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro:");
            int valor = int.Parse(Console.ReadLine());

            if (valor < 0)
            {
                Console.WriteLine("Valor Negartivo!!");
            }
            else
            {
                Console.WriteLine("Valor positivo!!");
            }
        }
    }
}