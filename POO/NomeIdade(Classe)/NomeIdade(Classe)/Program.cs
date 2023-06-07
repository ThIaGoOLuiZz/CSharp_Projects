namespace NomeIdade_Classe_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            int maiorIdade = 0;

            Console.Write("Digite o nome da primeira pessoa!: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa!: ");
            pessoa1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o nome da primeira pessoa!: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira segunda!: ");
            pessoa2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (pessoa1.idade > pessoa2.idade)
            {
                maiorIdade = pessoa1.idade;
                Console.WriteLine($"{pessoa1.nome} tem a idade maior com {maiorIdade} anos!");
            }
            else
            {
                maiorIdade = pessoa2.idade;
                Console.WriteLine($"{pessoa2.nome} tem a idade maior com {maiorIdade} anos!");
            }

        }
    }
}