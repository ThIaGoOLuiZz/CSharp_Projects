using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold;

public static class Program
{
    public static void Main()
    {
        //Primeiro Digito
        Console.WriteLine("Digite um valor");
        int num1 = int.Parse(Console.ReadLine());

        //Segundo Digito
        Console.WriteLine("Digite outro valor");
        int num2 = int.Parse(Console.ReadLine());

        //Calculo soma
        Console.WriteLine($"A soma dos dois valores escolhidos é de: {num1 + num2}");
    }
}
