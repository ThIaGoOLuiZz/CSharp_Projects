using System;
using System.Linq;

namespace Projeto_cálculoFormas;

public static class Program
{
    public static void Main()
    {
        //AREA DO TRIANGULO = (A * C) / 2
        //AREA DO CIRCULO = pi * raio^2
        //AREA DO TRAPEZIO = ((A + B) * C) / 2
        //AREA DO QUADRADO = B^2
        //AREA DO RETANGULO = A * B

        double pi = 3.14159;

        Console.WriteLine("Digite 3 valores.");
        string valores = (Console.ReadLine());

        string[] lista = valores.Split(' ');

        double valorA = double.Parse(lista[0]);
        double valorB = double.Parse(lista[1]);
        double valorC = double.Parse(lista[2]);

        Console.WriteLine($"TRIANGULO: {((valorA * valorC) / 2).ToString("F3")}");
        Console.WriteLine($"CIRCULO: {(pi * (Math.Pow(valorC, 2))).ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {(((valorA + valorB) * valorC) / 2).ToString("F3")}");
        Console.WriteLine($"QUADRADO: {(Math.Pow(valorB, 2).ToString("F3"))}");
        Console.WriteLine($"RETANGULO: {(valorA * valorB).ToString("F3")}");

    }
}
