using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIAVEIS
            double x = 0.0;
            double y = 0.0;

            
            Console.WriteLine("Digite dois valores com 1 casa decimal:");
            string valor = Console.ReadLine();

            string[] valores = valor.Split(' ');

            x = double.Parse(valores[0]);
            y = double.Parse(valores[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }




        }
    }
}