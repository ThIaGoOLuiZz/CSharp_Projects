using System.Globalization;
using System.Collections.Generic;

namespace AumentoSalarioList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Quantos funcionarios vão ser registrados?: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Funcionario #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionario funcionario = new Funcionario(id, nome, salario);

                lista.Add(funcionario);

                Console.WriteLine();
            }

            int indexLista;
            while (true)
            {
                Console.Write("Insira o ID do funcionario a receber o aumento: ");
                int idAumento = int.Parse(Console.ReadLine());

                indexLista = lista.FindIndex(x => x.Id == idAumento);
                if (indexLista == -1)
                {
                    Console.WriteLine("Digite um Id correto!");
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine();
            Console.Write("Porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            lista[indexLista].AumentoSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Lista atualizada: ");
            foreach(Funcionario func in lista)
            {
                Console.WriteLine($"{func.Id}, {func.Nome}, {func.Salario}");
            }

        }
    }
}
