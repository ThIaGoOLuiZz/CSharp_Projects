using System;
using System.Globalization;

namespace Comeco;

internal class Dados_Basico
{
    static void Main(string[] args)
    {
        string produtor1 = "Computador";
        string produto2 = "Mesa de escritório";
        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';
        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produto: ");
        Console.WriteLine("Computador, cujo preço é $ " + preco1);
        Console.WriteLine("Mesa de escritório cujo preço é $ " + preco2);
        Console.WriteLine("");
        Console.WriteLine($"Registro: 30 anos de idade, código {codigo} e gênero: {genero}");
        Console.WriteLine("");
        Console.WriteLine($"Medida com oito casas decimais: " + medida.ToString("F8"));
        Console.WriteLine($"Arredondar (três casas decimais): {medida.ToString("F3")}");
        Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");



    }
}