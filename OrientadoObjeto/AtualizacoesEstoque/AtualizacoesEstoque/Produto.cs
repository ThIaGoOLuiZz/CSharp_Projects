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

        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
            _quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 0)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }


        public double ValorTotal()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int qtd)
        {
            _quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            _quantidade -= qtd;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $"
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
