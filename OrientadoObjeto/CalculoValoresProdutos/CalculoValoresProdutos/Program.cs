using System.Globalization;

namespace CalculoValoresProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantidade de produtos: ");
            int qtd = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[qtd];

            for (int i = 0; i < qtd; i++)
            {
                

                Console.Write("Digite o NOME do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o VALOR do produto: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos[i] = new Produto(nome, valor);
            }

            double valorTotal = 0.0;
            for (int i = 0;i < qtd; i++)
            {
                valorTotal += produtos[i].Valor;
            }

            Console.WriteLine($"valor médio: {(valorTotal/qtd).ToString("F2")}");
        }
    }
}
