using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Nome { get; set; }
        public double Valor { get; private set; }

        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Valor = 0.0;
        }

        public ContaBancaria(int numeroConta, string nome, double valor) : this(numeroConta, nome)
        {
            Valor = valor;
        }

        public void DepositoBancario (double valor)
        {
            Valor += valor;
        }

        public void SaqueBancario (double valor)
        {
            Valor -= valor - 5.0;
        }
    }
}
