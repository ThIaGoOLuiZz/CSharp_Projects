using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VALOR 1

            Console.WriteLine("DIgite um valor inteiro:");
            int valor1 = int.Parse(Console.ReadLine());

            //VALOR 2

            Console.WriteLine("Digite outro valor inteiro:");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                if (valor2 % valor1 == 0)
                {
                    Console.WriteLine("Os valores são multiplos");
                }
                else
                {
                    Console.WriteLine("Os valores não são multiplos");
                }
;

            }
            else
            {
                if (valor1 % valor2 == 0)
                {
                    Console.WriteLine("Os valores são multiplos");
                }
                else
                {
                    Console.WriteLine("Os valores não são multiplos");
                }
            }


        }
    }
}