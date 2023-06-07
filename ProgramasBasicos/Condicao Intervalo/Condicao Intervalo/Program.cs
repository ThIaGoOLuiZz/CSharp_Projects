using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite um numero entre 0 e 100");
            double valor = double.Parse(Console.ReadLine());

            if (valor > 0 && valor <= 25.00)
            {
                Console.WriteLine("Intervalo  (0, 25)");
            }
            else if (valor > 25.00 && valor <= 50)
            {
                Console.WriteLine("Intervalo(25, 50)");
            }
            else if (valor > 50 && valor <= 75)
            {
                Console.WriteLine("Intervalo(50, 75)");
            }
            else if (valor > 75 && valor <= 100)
            {
                Console.WriteLine("Intervalo(75, 100)");
            }
            else
            {
                Console.WriteLine("Fora do intervalo!!");
            }
        }
    }
}