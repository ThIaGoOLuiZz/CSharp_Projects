using System.Globalization;

namespace AluguelHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Quantidade de quartos alugados: ");
            int qtdQuartos = int.Parse( Console.ReadLine());

            Quarto[] quartos = new Quarto[qtdQuartos];

            for ( int i = 0; i < qtdQuartos; i++)
            {
                Console.Write("Qual o numero do quarto: ");
                int numero = int.Parse( Console.ReadLine());

                Console.Write("Nome da pessoa: ");
                string nome = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Email da pessoa: ");
                string email = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Idade da pessoa: ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Valor do aluguel: ");
                double valorAluguel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Aluguel aluguel = new Aluguel(valorAluguel);
                Pessoa pessoa = new Pessoa(nome, email, idade);
                Quarto quarto = new Quarto(numero, pessoa, aluguel);

                quartos[i] = quarto;
            }

            Console.WriteLine("Quartos ocupados:");
            for ( int i = 0;i < qtdQuartos;i++)
            {
                Console.WriteLine($"Número: {quartos[i].Numero}: Nome: {quartos[i].Pessoa.Nome} | Email: {quartos[i].Pessoa.Email} | Idade: {quartos[i].Pessoa.Idade} | Aluguel: {quartos[i].Aluguel.Valor.ToString("F2")}");
            }
        }
    }
}
