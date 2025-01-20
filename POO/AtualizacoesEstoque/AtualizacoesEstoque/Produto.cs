using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AtualizacoesEstoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotal()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
