using System;

namespace ControleEstoqueSimples_classes_
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalemEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) { 
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2") + 
                   ", " + 
                   Quantidade + 
                   " unidade, Total: $" + 
                   ValorTotalemEstoque().ToString("F2");
        }
    }
}
