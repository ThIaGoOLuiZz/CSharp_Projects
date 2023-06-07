using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores:");
            string lista = Console.ReadLine();
            string[] x = lista.Split(' ');


            int valorx = int.Parse(x[0]);
            int valory = int.Parse(x[1]);

            while (valorx != 0 && valory != 0)
            {
                if (valorx > 0 && valory > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (valorx < 0 && valory > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (valorx < 0 && valorx < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (valorx > 0 && valory < 0)
                {
                    Console.WriteLine("Quarto");
                }

                Console.WriteLine("Digite outro Valor:");
                lista = Console.ReadLine();
                x = lista.Split(' ');


                valorx = int.Parse(x[0]);
                valory = int.Parse(x[1]);

                Console.Clear();
            }

            Console.WriteLine("Programa finalizado");



        }
    }
}
