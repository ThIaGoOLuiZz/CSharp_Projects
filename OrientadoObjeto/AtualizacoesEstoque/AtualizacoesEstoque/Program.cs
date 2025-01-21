using System.Globalization;

namespace AtualizacoesEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            produto.SetNome("TV 4K");

            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.GetPreco());
            Console.WriteLine(produto.GetQuantidade());
        }
    }
}
