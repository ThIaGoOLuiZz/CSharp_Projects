using System;
using System.Globalization;

namespace CalculoRaio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferencia: {circ.ToString("F2")}");
            Console.WriteLine($"Volume: {volume.ToString("F2")}");
            Console.WriteLine($"PI: {Calculadora.Pi.ToString("F2")}");
        }
    }
}
