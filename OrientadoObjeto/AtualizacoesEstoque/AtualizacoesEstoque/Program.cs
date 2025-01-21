using System.Globalization;

namespace AtualizacoesEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            produto.Nome = ("");

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);
        }
    }
}
