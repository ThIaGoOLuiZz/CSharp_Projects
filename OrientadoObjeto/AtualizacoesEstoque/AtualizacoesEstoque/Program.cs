using System.Globalization;

namespace AtualizacoesEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());


            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem adicionados ao estoque!: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem removidos do estoque!: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            Console.WriteLine();
        }
    }
}
