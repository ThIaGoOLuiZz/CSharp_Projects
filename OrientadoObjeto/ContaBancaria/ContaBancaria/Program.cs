using System.Net.WebSockets;
using System.Globalization;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o titular da conta: ");
            string nome = Console.ReadLine();

            bool stValidacao = true;
            string vlDeposito = "";
            ContaBancaria conta;

            while (stValidacao)
            {
                Console.WriteLine("Haverá depósito inicial?(S/N)");
                vlDeposito = Console.ReadLine();

                if (vlDeposito.ToUpper() == "S" || vlDeposito.ToUpper() == "N")
                {
                    stValidacao = false;
                }
                else
                {
                    Console.WriteLine("Digite apenas S ou N!");
                }
            }
            if(vlDeposito.ToUpper() == "S")
            {
                Console.WriteLine("Digite o valor de depósito");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numeroConta, nome, valorDeposito);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Conta Criada com sucesso! Dados da conta: ");
            Console.WriteLine($"Conta {conta.NumeroConta}, Titular: {conta.Nome}, Saldo: $ {conta.Valor}");

            int vlEscolha = 1;

            while (vlEscolha != 0)
            {
                stValidacao = false;
                while (!stValidacao)
                {
                    Console.WriteLine("Escolha a opção desejada: \n1 - Depósito;\n2 - Saque;\n3 - Sair;");
                    vlEscolha = int.Parse(Console.ReadLine());
                    if (vlEscolha != 1 && vlEscolha != 2 && vlEscolha != 3)
                    {
                        Console.WriteLine("Selecione apenas 1, 2 ou 3!");
                        break;
                    }
                    stValidacao = true;
                }

                switch (vlEscolha)
                {
                    case 1:
                        Console.Write("Digite o valor para Depósito: ");
                        double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine();

                        conta.DepositoBancario(valorDeposito);

                        Console.WriteLine("Conta Atualizada com sucesso! Dados atualizados: ");
                        Console.WriteLine($"Conta {conta.NumeroConta}, Titular: {conta.Nome}, Saldo: $ {conta.Valor.ToString("F2")}");
                        Console.WriteLine();

                        break;

                    case 2:
                        Console.WriteLine();
                        Console.Write("Digite o valor para Saque: ");
                        double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        conta.SaqueBancario(valorSaque);

                        Console.WriteLine();
                        Console.WriteLine("Conta Atualizada com sucesso! Dados atualizados: ");
                        Console.WriteLine($"Conta {conta.NumeroConta}, Titular: {conta.Nome}, Saldo: $ {conta.Valor.ToString("F2")}");
                        Console.WriteLine();

                        break;

                    case 3:
                        vlEscolha = 0;
                        break;
                }
            }

        }
    }
}
