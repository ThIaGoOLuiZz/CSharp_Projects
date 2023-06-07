using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;

            Console.WriteLine("Digite a senha (4 digitos):");
            Console.WriteLine("----------------");

            int tentativa = int.Parse(Console.ReadLine());

            while (tentativa != senha)
            {
                Console.WriteLine("Senha incorreta, por favos, digite novamente:");
                tentativa = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}
