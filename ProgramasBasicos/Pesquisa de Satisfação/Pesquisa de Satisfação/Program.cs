using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIAVEIS
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int combustivel = 1;

            while (combustivel > 0)
            {
                Console.WriteLine("Olá, Gostaria de saber qual foi o combustivel de preferencia?");
                Console.WriteLine("[1] - Alcool");
                Console.WriteLine("[2] - Gasolina");
                Console.WriteLine("[3] - Diesel");
                Console.WriteLine("[4] - Fechar programa");
                Console.WriteLine("------------------------------------------------------");

                combustivel = int.Parse(Console.ReadLine());


                if (combustivel == 1)
                {
                    ++alcool;
                    Console.Clear();
                }
                else if (combustivel == 2)
                {
                    ++gasolina;
                    Console.Clear();
                }
                else if (combustivel == 3)
                {
                    ++diesel;
                    Console.Clear();
                }
                else if (combustivel == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Muito Obrigado");
                    Console.WriteLine($"alcool: {alcool}");
                    Console.WriteLine($"Gasolina: {gasolina}");
                    Console.WriteLine($"Diesel: {diesel}");
                    combustivel = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Valor incorreto, digite apenas entre 1 e 4!");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
        }
    }
}
